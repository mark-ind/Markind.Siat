using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public abstract class MessageBase
{
    public CodigoAmbiente? CodigoAmbiente { get; set; }
    public string? CodigoSistema { get; set; }
    public long? Nit { get; set; }
    public int? CodigoPuntoVenta { get; set; }
    public int? CodigoSucursal { get; set; }
    public string? Cuis { get; set; }
    public CodigoModalidad? CodigoModalidad { get; set; }

    public string? Certificado { get; set; }
    public DateTime? FechaRevocacion { get; set; }
    public long? NitParaVerificacion { get; set; }

    public string? Cafc { get; set; }
    public int? CantidadFacturas { get; set; }

    public long? CodigoEvento { get; set; }
    public byte[]? Archivo { get; set; }
    public string? FechaEnvio { get; set; }
    public string? HashArchivo { get; set; }
    public string? CodigoRecepcion { get; set; }
    public string? Cuf { get; set; }
    public int? CodigoMotivo { get; set; }
    public solicitudListaCufdDto[]? DatosSolicitud { get; set; }
}