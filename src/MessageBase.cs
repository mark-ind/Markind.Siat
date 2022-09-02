namespace Markind.Siat;

public class MessageBase
{
    public int codigoAmbiente { get; set; }
    public string codigoSistema { get; set; }
    public long nit { get; set; }

    private int? codigoPuntoVenta { get; set; }

    private int codigoSucursal { get; set; }

    private string cuis { get; set; }
}