using System.ServiceModel;

namespace Markind.Siat.Generated.ServicioFacturacionCompraVenta;

public partial class ServicioFacturacionClient
{
    public ServicioFacturacionClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/ServicioFacturacionCompraVenta") : base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaRecepcion RecepcionPaqueteFactura(SolicitudRecepcionPaquete msg) => recepcionPaqueteFactura((solicitudRecepcionPaquete)msg.Merge(DefaultMessage));
    public Task<recepcionPaqueteFacturaResponse> RecepcionPaqueteFacturaAsync(SolicitudRecepcionPaquete msg) => recepcionPaqueteFacturaAsync((solicitudRecepcionPaquete)msg.Merge(DefaultMessage));

    public respuestaRecepcion RecepcionFactura(SolicitudRecepcionFacturaComputarizada msg) => recepcionFactura((solicitudRecepcionFactura)msg.Merge(DefaultMessage));
    public Task<recepcionFacturaResponse> RecepcionFacturaAsync(SolicitudRecepcionFacturaComputarizada msg) => recepcionFacturaAsync((solicitudRecepcionFactura)msg.Merge(DefaultMessage));

    public respuestaRecepcion ValidacionRecepcionMasivaFactura(SolicitudValidacionRecepcion msg) => validacionRecepcionMasivaFactura((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public Task<validacionRecepcionMasivaFacturaResponse> ValidacionRecepcionMasivaFacturaAsync(SolicitudValidacionRecepcion msg) => validacionRecepcionMasivaFacturaAsync((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));

    public respuestaRecepcion RecepcionAnexos(SolicitudRecepcionAnexos msg) => recepcionAnexos((solicitudRecepcionAnexos)msg.Merge(DefaultMessage));
    public Task<recepcionAnexosResponse> RecepcionAnexosAsync(SolicitudRecepcionAnexos msg) => recepcionAnexosAsync((solicitudRecepcionAnexos)msg.Merge(DefaultMessage));

    public respuestaRecepcion RecepcionMasivaFactura(SolicitudRecepcionMasiva msg) => recepcionMasivaFactura((solicitudRecepcionMasiva)msg.Merge(DefaultMessage));
    public Task<recepcionMasivaFacturaResponse> RecepcionMasivaFacturaAsync(SolicitudRecepcionMasiva msg) => recepcionMasivaFacturaAsync((solicitudRecepcionMasiva)msg.Merge(DefaultMessage));

    public respuestaRecepcion VerificacionEstadoFactura(SolicitudVerificacionEstado msg) => verificacionEstadoFactura((solicitudVerificacionEstado)msg.Merge(DefaultMessage));
    public Task<verificacionEstadoFacturaResponse> VerificacionEstadoFacturaAsync(SolicitudVerificacionEstado msg) => verificacionEstadoFacturaAsync((solicitudVerificacionEstado)msg.Merge(DefaultMessage));

    public respuestaRecepcion ValidacionRecepcionPaqueteFactura(SolicitudValidacionRecepcion msg) => validacionRecepcionPaqueteFactura((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));
    public Task<validacionRecepcionPaqueteFacturaResponse> ValidacionRecepcionPaqueteFacturaAsync(SolicitudValidacionRecepcion msg) => validacionRecepcionPaqueteFacturaAsync((solicitudValidacionRecepcion)msg.Merge(DefaultMessage));

    public respuestaRecepcion AnulacionFactura(SolicitudAnulacion msg) => anulacionFactura((solicitudAnulacion)msg.Merge(DefaultMessage));
    public Task<anulacionFacturaResponse> AnulacionFacturaAsync(SolicitudAnulacion msg) => anulacionFacturaAsync((solicitudAnulacion)msg.Merge(DefaultMessage));
}