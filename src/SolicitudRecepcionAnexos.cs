using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcionAnexos : SolicitudFacturacion
{
    public required string CodigoRecepcion { get; set; }

    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionAnexos(SolicitudRecepcionAnexos src) => Cast<SolicitudRecepcionAnexos, Generated.ServicioFacturacionCompraVenta.solicitudRecepcionAnexos>(src);

    public SolicitudRecepcionAnexos Merge(MessageBase src) => src.Adapt(this);
}