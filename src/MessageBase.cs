namespace Markind.Siat;

public class MessageBase
{
    public int codigoAmbiente { get; set; }
    public string codigoSistema { get; set; }
    public long nit { get; set; }

    public int? codigoPuntoVenta { get; set; }

    public int codigoSucursal { get; set; }

    public string cuis { get; set; }

    public int codigoModalidad {get; set;}

}