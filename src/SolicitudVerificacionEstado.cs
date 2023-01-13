using Mapster;

namespace Markind.Siat;

public class SolicitudVerificacionEstado : SolicitudFacturacion
{
    public required string Cuf { get; set; }

    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudVerificacionEstado(SolicitudVerificacionEstado src) => Cast<SolicitudVerificacionEstado, Generated.ServicioFacturacionComputarizada.solicitudVerificacionEstado>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudVerificacionEstado(SolicitudVerificacionEstado src) => Cast<SolicitudVerificacionEstado, Generated.ServicioFacturacionCompraVenta.solicitudVerificacionEstado>(src);

    public SolicitudVerificacionEstado Merge(MessageBase src) => src.Adapt(this);
}