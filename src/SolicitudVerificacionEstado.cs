using Mapster;

namespace Markind.Siat;

public class SolicitudVerificacionEstado : SolicitudFacturacion
{
    public required string CodigoRecepcion { get; set; }

    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudVerificacionEstado(SolicitudVerificacionEstado src) => Cast<SolicitudVerificacionEstado, Generated.ServicioFacturacionComputarizada.solicitudVerificacionEstado>(src);

    public SolicitudVerificacionEstado Merge(MessageBase src) => src.Adapt(this);
}