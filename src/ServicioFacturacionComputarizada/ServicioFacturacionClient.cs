using System.ServiceModel;

namespace Markind.Siat.Generated.ServicioFacturacionComputarizada;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionClient
{
    public ServicioFacturacionClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/Facturacion") : base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaRecepcion recepcionPaqueteFactura(SolicitudRecepcionPaquete msg) => recepcionPaqueteFactura((solicitudRecepcionPaquete)msg.Merge(DefaultMessage));
    public Task<recepcionPaqueteFacturaResponse> recepcionPaqueteFacturaAsync(SolicitudRecepcionPaquete msg) => recepcionPaqueteFacturaAsync((solicitudRecepcionPaquete)msg.Merge(DefaultMessage));
    public respuestaRecepcion recepcionFactura(SolicitudRecepcionFacturaComputarizada msg) => recepcionFactura((solicitudRecepcionFactura)msg.Merge(DefaultMessage));
    public Task<recepcionFacturaResponse> recepcionFacturaAsync(SolicitudRecepcionFacturaComputarizada msg) => recepcionFacturaAsync((solicitudRecepcionFactura)msg.Merge(DefaultMessage));
    public respuestaRecepcion validacionRecepcionMasivaFactura(SolicitudValidacionRecepcion msg) => validacionRecepcionMasivaFactura((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public Task<validacionRecepcionMasivaFacturaResponse> validacionRecepcionMasivaFacturaAsync(SolicitudValidacionRecepcion msg) => validacionRecepcionMasivaFacturaAsync((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public respuestaRecepcion recepcionMasivaFactura(SolicitudRecepcionMasiva msg) => recepcionMasivaFactura((solicitudRecepcionMasiva)msg.Merge(DefaultMessage));
    public Task<recepcionMasivaFacturaResponse> recepcionMasivaFacturaAsync(SolicitudRecepcionMasiva msg) => recepcionMasivaFacturaAsync((solicitudRecepcionMasiva)msg.Merge(DefaultMessage));
    public respuestaRecepcion verificacionEstadoFactura(SolicitudVerificacionEstado msg) => verificacionEstadoFactura((solicitudVerificacionEstado)msg.Merge(DefaultMessage));
    public Task<verificacionEstadoFacturaResponse> verificacionEstadoFacturaAsync(SolicitudVerificacionEstado msg) => verificacionEstadoFacturaAsync((solicitudVerificacionEstado)msg.Merge(DefaultMessage));
    public respuestaRecepcion validacionRecepcionPaqueteFactura(SolicitudValidacionRecepcion msg) => validacionRecepcionPaqueteFactura((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public Task<validacionRecepcionPaqueteFacturaResponse> validacionRecepcionPaqueteFacturaAsync(SolicitudValidacionRecepcion msg) => validacionRecepcionPaqueteFacturaAsync((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public respuestaRecepcion anulacionFactura(SolicitudAnulacion msg) => anulacionFactura((solicitudAnulacion)msg.Merge(DefaultMessage));
    public Task<anulacionFacturaResponse> anulacionFacturaAsync(SolicitudAnulacion msg) => anulacionFacturaAsync((solicitudAnulacion)msg.Merge(DefaultMessage));
}