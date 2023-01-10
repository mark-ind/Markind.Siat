using Mapster;

namespace Markind.Siat;

public class SolicitudAnulacion : SolicitudFacturacion
{
    public required string CodigoRecepcion { get; set; }

    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudAnulacion(SolicitudAnulacion src) => Cast<SolicitudAnulacion, Generated.ServicioFacturacionComputarizada.solicitudAnulacion>(src);

    public SolicitudAnulacion Merge(MessageBase src) => src.Adapt(this);
}