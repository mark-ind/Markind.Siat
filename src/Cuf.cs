using System.Numerics;
using System.Text;

namespace Markind.Siat;

public class Cuf
{
    public static string Generate(SolicitudRecepcion data, DateTime emissionDate, long nroFactura, string controlCode)
    {
        ArgumentException.ThrowIfNullOrEmpty(controlCode);

        var str = new StringBuilder();
        str.Append(data.Nit.ToString("D13"));
        str.Append(emissionDate.ToString("yyyyMMddHHmmssfff"));
        str.Append(data.CodigoSucursal.ToString("D4"));
        str.Append((int)data.CodigoModalidad);
        str.Append((int)data.CodigoEmision);
        str.Append((int)data.TipoFacturaDocumento);
        str.Append(((int)data.CodigoDocumentoSector).ToString("D2"));
        str.Append(nroFactura.ToString("D10"));
        str.Append((data.CodigoPuntoVenta ?? 0).ToString("D4"));
        str.Append(Module11(str.ToString()));

        var base16 = BigInteger.Parse(str.ToString()).ToString("X");

        return base16 + controlCode;
    }

    public static string Module11(string str) => CalculaDigitoMod11(str, 1, 9, false);
    public static string CalculaDigitoMod11(string cadena, int numDig, int limMult, bool x10)
    {
        int mult, suma, i, n, dig;

        if (!x10) numDig = 1;

        for (n = 1; n <= numDig; n++)
        {
            suma = 0;
            mult = 2;
            for (i = cadena.Length - 1; i >= 0; i--)
            {
                suma += mult * (int)char.GetNumericValue(cadena[i]);

                if (++mult > limMult) mult = 2;
            }

            if (x10)
            {
                dig = ((suma * 10) % 11) % 10;
            }
            else
            {
                dig = suma % 11;
            }

            if (dig == 10)
            {
                cadena += "1";
            }

            if (dig == 11)
            {
                cadena += "0";
            }

            if (dig < 10)
            {
                cadena += dig;
            }
        }

        return cadena[^numDig].ToString();
    }
}