using System.Diagnostics.CodeAnalysis;
using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcionFacturaElectronica : SolicitudRecepcion, ISolicitudRecepcionFactura
{
    public SolicitudRecepcionFacturaElectronica()
    {
    }

    [SetsRequiredMembers]
    public SolicitudRecepcionFacturaElectronica(MessageBase msg) : base(msg)
    {
    }

    public required byte[] Archivo { get; set; }
    public string FechaEnvio { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fff");
    public required string HashArchivo { get; set; }
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura(SolicitudRecepcionFacturaElectronica src) => Cast<SolicitudRecepcionFacturaElectronica, Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura>(src);
    public static implicit operator Generated.ServicioFacturacionElectronica.solicitudRecepcionFactura(SolicitudRecepcionFacturaElectronica src) => Cast<SolicitudRecepcionFacturaElectronica, Generated.ServicioFacturacionElectronica.solicitudRecepcionFactura>(src);

    public SolicitudRecepcionFacturaElectronica Merge(MessageBase src) => src.Adapt(this);
}