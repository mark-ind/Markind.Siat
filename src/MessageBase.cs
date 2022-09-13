using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public abstract class MessageBase
{
#region Common
    public CodigoAmbiente? CodigoAmbiente { get; set; }
    public string? CodigoSistema { get; set; }
    public ulong? Nit { get; set; }
    public uint? CodigoPuntoVenta { get; set; }
    public uint? CodigoSucursal { get; set; }
    public string? Cuis { get; set; }
    public CodigoModalidad? CodigoModalidad { get; set; }
#endregion
#region FacturacionOperaciones
    public uint? CodigoTipoPuntoVenta { get; set; }
    public string? Descripcion { get; set; }
    public string? NombrePuntoVenta { get; set; }
    public DateTime? FechaFinField { get; set; }

    public DateTime? FechaInicioField { get; set; }
    public ulong? NitComisionistaField { get; set; }
    public string? NumeroContratoField { get; set; }
    public DateTime? FechaEventoField { get; set; }
    public string? CufdEventoField { get; set; }
    public DateTime? FechaHoraFinEventoField { get; set; }
    public DateTime? FechaHoraInicioEventoField { get; set; }
#endregion
    public string? Certificado { get; set; }
    public DateTime? FechaRevocacion { get; set; }
    public ulong? NitParaVerificacion { get; set; }
#region FacturacionCodigos
    public string? Cafc { get; set; }
    public uint? CantidadFacturas { get; set; }
    public ulong? CodigoEvento { get; set; }
    public byte[]? Archivo { get; set; }
    public string? FechaEnvio { get; set; }
    public string? HashArchivo { get; set; }
    public string? CodigoRecepcion { get; set; }
    public string? Cuf { get; set; }
    public uint? CodigoMotivo { get; set; }
    public solicitudListaCufdDto[]? DatosSolicitud { get; set; }
#endregion
}