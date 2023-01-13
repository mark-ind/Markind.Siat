using Mapster;

namespace Markind.Siat;

public class SolicitudValidacionRecepcion : SolicitudFacturacion
{
    public required string CodigoRecepcion { get; set; }

    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudValidacionRecepcion(SolicitudValidacionRecepcion src) => Cast<SolicitudValidacionRecepcion, Generated.ServicioFacturacionComputarizada.solicitudValidacionRecepcion>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudValidacionRecepcion(SolicitudValidacionRecepcion src) => Cast<SolicitudValidacionRecepcion, Generated.ServicioFacturacionCompraVenta.solicitudValidacionRecepcion>(src);

    public SolicitudValidacionRecepcion Merge(MessageBase src) => src.Adapt(this);
}