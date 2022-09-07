namespace Markind.Siat;

public abstract class MessageBase
{
    public CodigoAmbiente? CodigoAmbiente { get; set; }
    public string? CodigoSistema { get; set; }
    public long? Nit { get; set; }
    public int? CodigoPuntoVenta { get; set; }
    public int? CodigoSucursal { get; set; }
    public string? Cuis { get; set; }
    public CodigoModalidad? CodigoModalidad {get; set;}
    public string? Certificado {get;set;}
    public DateTime? FechaRevocacion {get; set;}
    public long? NitParaVerificacion {get; set;}
}