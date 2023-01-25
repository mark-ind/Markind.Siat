using System.Diagnostics.CodeAnalysis;
using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcionFacturaComputarizada : SolicitudRecepcion
{
    public SolicitudRecepcionFacturaComputarizada()
    {
    }

    [SetsRequiredMembers]
    public SolicitudRecepcionFacturaComputarizada(MessageBase msg) : base(msg)
    {
    }

    public required byte[] Archivo { get; set; }
    public required string FechaEnvio { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fff");
    public required string HashArchivo { get; set; }

    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura(SolicitudRecepcionFacturaComputarizada src) => Cast<SolicitudRecepcionFacturaComputarizada, Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura>(src);
    public static implicit operator Generated.ServicioFacturacionComputarizada.solicitudRecepcionFactura(SolicitudRecepcionFacturaComputarizada src) => Cast<SolicitudRecepcionFacturaComputarizada, Generated.ServicioFacturacionComputarizada.solicitudRecepcionFactura>(src);

    public SolicitudRecepcionFacturaComputarizada Merge(MessageBase src) => src.Adapt(this);
}