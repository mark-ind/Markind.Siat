using System.ServiceModel;

namespace Markind.Siat.Generated.ServicioFacturacionElectronica;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionClient
{
    public ServicioFacturacionClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/Facturacion") : base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaRecepcion recepcionPaqueteFactura() => recepcionPaqueteFactura(DefaultMessage);
    public respuestaRecepcion recepcionPaqueteFactura(Message msg) => recepcionPaqueteFactura(DefaultMessage.Merge(msg));
    public Task<recepcionPaqueteFacturaResponse> recepcionPaqueteFacturaAsync() => recepcionPaqueteFacturaAsync(DefaultMessage);
    public Task<recepcionPaqueteFacturaResponse> recepcionPaqueteFacturaAsync(Message msg) => recepcionPaqueteFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion recepcionFactura() => recepcionFactura(DefaultMessage);
    public respuestaRecepcion recepcionFactura(Message msg) => recepcionFactura(DefaultMessage.Merge(msg));
    public Task<recepcionFacturaResponse> recepcionFacturaAsync() => recepcionFacturaAsync(DefaultMessage);
    public Task<recepcionFacturaResponse> recepcionFacturaAsync(Message msg) => recepcionFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion validacionRecepcionMasivaFactura() => validacionRecepcionMasivaFactura(DefaultMessage);
    public respuestaRecepcion validacionRecepcionMasivaFactura(Message msg) => validacionRecepcionMasivaFactura(DefaultMessage.Merge(msg));
    public Task<validacionRecepcionMasivaFacturaResponse> validacionRecepcionMasivaFacturaAsync() => validacionRecepcionMasivaFacturaAsync(DefaultMessage);
    public Task<validacionRecepcionMasivaFacturaResponse> validacionRecepcionMasivaFacturaAsync(Message msg) => validacionRecepcionMasivaFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion recepcionMasivaFactura() => recepcionMasivaFactura(DefaultMessage);
    public respuestaRecepcion recepcionMasivaFactura(Message msg) => recepcionMasivaFactura(DefaultMessage.Merge(msg));
    public Task<recepcionMasivaFacturaResponse> recepcionMasivaFacturaAsync() => recepcionMasivaFacturaAsync(DefaultMessage);
    public Task<recepcionMasivaFacturaResponse> recepcionMasivaFacturaAsync(Message msg) => recepcionMasivaFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion verificacionEstadoFactura() => verificacionEstadoFactura(DefaultMessage);
    public respuestaRecepcion verificacionEstadoFactura(Message msg) => verificacionEstadoFactura(DefaultMessage.Merge(msg));
    public Task<verificacionEstadoFacturaResponse> verificacionEstadoFacturaAsync() => verificacionEstadoFacturaAsync(DefaultMessage);
    public Task<verificacionEstadoFacturaResponse> verificacionEstadoFacturaAsync(Message msg) => verificacionEstadoFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion validacionRecepcionPaqueteFactura() => validacionRecepcionPaqueteFactura(DefaultMessage);
    public respuestaRecepcion validacionRecepcionPaqueteFactura(Message msg) => validacionRecepcionPaqueteFactura(DefaultMessage.Merge(msg));
    public Task<validacionRecepcionPaqueteFacturaResponse> validacionRecepcionPaqueteFacturaAsync() => validacionRecepcionPaqueteFacturaAsync(DefaultMessage);
    public Task<validacionRecepcionPaqueteFacturaResponse> validacionRecepcionPaqueteFacturaAsync(Message msg) => validacionRecepcionPaqueteFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaRecepcion anulacionFactura() => anulacionFactura(DefaultMessage);
    public respuestaRecepcion anulacionFactura(Message msg) => anulacionFactura(DefaultMessage.Merge(msg));
    public Task<anulacionFacturaResponse> anulacionFacturaAsync() => anulacionFacturaAsync(DefaultMessage);
    public Task<anulacionFacturaResponse> anulacionFacturaAsync(Message msg) => anulacionFacturaAsync(DefaultMessage.Merge(msg));
}