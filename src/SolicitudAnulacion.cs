using Mapster;

namespace Markind.Siat;

public class SolicitudAnulacion : SolicitudFacturacion
{
    public required int CodigoMotivo {get;set;}
    public required string Cuf { get; set; }

    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudAnulacion(SolicitudAnulacion src) => Cast<SolicitudAnulacion, Generated.ServicioFacturacionComputarizada.solicitudAnulacion>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudAnulacion(SolicitudAnulacion src) => Cast<SolicitudAnulacion, Generated.ServicioFacturacionCompraVenta.solicitudAnulacion>(src);

    public SolicitudAnulacion Merge(MessageBase src) => src.Adapt(this);
}