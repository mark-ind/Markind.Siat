using System.Diagnostics.CodeAnalysis;
using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcionPaquete : SolicitudRecepcion
{
    public SolicitudRecepcionPaquete()
    {
    }

    [SetsRequiredMembers]
    public SolicitudRecepcionPaquete(MessageBase msg) : base(msg)
    {
    }

    public int CantidadFacturas {get; set;}
    public long CodigoEvento {get; set;}

    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionPaquete(SolicitudRecepcionPaquete src) => Cast<SolicitudRecepcionPaquete, Generated.ServicioFacturacionCompraVenta.solicitudRecepcionPaquete>(src);
    public static implicit operator Generated.ServicioFacturacionElectronica.solicitudRecepcionPaquete(SolicitudRecepcionPaquete src) => Cast<SolicitudRecepcionPaquete, Generated.ServicioFacturacionElectronica.solicitudRecepcionPaquete>(src);
    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudRecepcionPaquete(SolicitudRecepcionPaquete src) => Cast<SolicitudRecepcionPaquete, Generated.ServicioFacturacionComputarizada.solicitudRecepcionPaquete>(src);

    public SolicitudRecepcionPaquete Merge(MessageBase src) => src.Adapt(this);
}