using System.Diagnostics.CodeAnalysis;
using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcionMasiva : SolicitudRecepcion
{
    public int CantidadFacturas {get; set;}

    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionMasiva(SolicitudRecepcionMasiva src) => Cast<SolicitudRecepcionMasiva, Generated.ServicioFacturacionCompraVenta.solicitudRecepcionMasiva>(src);
    public static implicit operator Generated.ServicioFacturacionElectronica.solicitudRecepcionMasiva(SolicitudRecepcionMasiva src) => Cast<SolicitudRecepcionMasiva, Generated.ServicioFacturacionElectronica.solicitudRecepcionMasiva>(src);
    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudRecepcionMasiva(SolicitudRecepcionMasiva src) => Cast<SolicitudRecepcionMasiva, Generated.ServicioFacturacionComputarizada.solicitudRecepcionMasiva>(src);

    public SolicitudRecepcionMasiva Merge(MessageBase src) => src.Adapt(this);
}