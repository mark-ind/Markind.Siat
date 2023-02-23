using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionOperaciones;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionOperacionesClient
{
    public ServicioFacturacionOperacionesClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionOperacione") : base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaRegistroPuntoVenta registroPuntoVenta() => registroPuntoVenta(DefaultMessage);
    public respuestaRegistroPuntoVenta registroPuntoVenta(Message msg) => registroPuntoVenta(DefaultMessage.Merge(msg));
    public Task<registroPuntoVentaResponse> registroPuntoVentaAsync() => registroPuntoVentaAsync(DefaultMessage);
    public Task<registroPuntoVentaResponse> registroPuntoVentaAsync(Message msg) => registroPuntoVentaAsync(DefaultMessage.Merge(msg));
    public respuestaPuntoVentaComisionista registroPuntoVentaComisionista() => registroPuntoVentaComisionista(DefaultMessage);
    public respuestaPuntoVentaComisionista registroPuntoVentaComisionista(Message msg) => registroPuntoVentaComisionista(DefaultMessage.Merge(msg));
    public Task<registroPuntoVentaComisionistaResponse> registroPuntoVentaComisionistaAsync() => registroPuntoVentaComisionistaAsync(DefaultMessage);
    public Task<registroPuntoVentaComisionistaResponse> registroPuntoVentaComisionistaAsync(Message msg) => registroPuntoVentaComisionistaAsync(DefaultMessage.Merge(msg));
    public respuestaCierreSistemas cierreOperacionesSistema() => cierreOperacionesSistema(DefaultMessage);
    public respuestaCierreSistemas cierreOperacionesSistema(Message msg) => cierreOperacionesSistema(DefaultMessage.Merge(msg));
    public Task<cierreOperacionesSistemaResponse> cierreOperacionesSistemaAsync() => cierreOperacionesSistemaAsync(DefaultMessage);
    public Task<cierreOperacionesSistemaResponse> cierreOperacionesSistemaAsync(Message msg) => cierreOperacionesSistemaAsync(DefaultMessage.Merge(msg));
    public respuestaListaEventos consultaEventoSignificativo() => consultaEventoSignificativo(DefaultMessage);
    public respuestaListaEventos consultaEventoSignificativo(Message msg) => consultaEventoSignificativo(DefaultMessage.Merge(msg));
    public Task<consultaEventoSignificativoResponse> consultaEventoSignificativoAsync() => consultaEventoSignificativoAsync(DefaultMessage);
    public Task<consultaEventoSignificativoResponse> consultaEventoSignificativoAsync(Message msg) => consultaEventoSignificativoAsync(DefaultMessage.Merge(msg));
    public respuestaConsultaPuntoVenta consultaPuntoVenta() => consultaPuntoVenta(DefaultMessage);
    public respuestaConsultaPuntoVenta consultaPuntoVenta(Message msg) => consultaPuntoVenta(DefaultMessage.Merge(msg));
    public Task<consultaPuntoVentaResponse> consultaPuntoVentaAsync() => consultaPuntoVentaAsync(DefaultMessage);
    public Task<consultaPuntoVentaResponse> consultaPuntoVentaAsync(Message msg) => consultaPuntoVentaAsync(DefaultMessage.Merge(msg));
    public respuestaListaEventos registroEventoSignificativo(SolicitudEventoSignificativo msg) => registroEventoSignificativo((solicitudEventoSignificativo)msg);
    public Task<registroEventoSignificativoResponse> registroEventoSignificativoAsync(SolicitudEventoSignificativo msg) => registroEventoSignificativoAsync((solicitudEventoSignificativo)msg);
    public respuestaCierrePuntoVenta cierrePuntoVenta() => cierrePuntoVenta(DefaultMessage);
    public respuestaCierrePuntoVenta cierrePuntoVenta(Message msg) => cierrePuntoVenta(DefaultMessage.Merge(msg));
    public Task<cierrePuntoVentaResponse> cierrePuntoVentaAsync() => cierrePuntoVentaAsync(DefaultMessage);
    public Task<cierrePuntoVentaResponse> cierrePuntoVentaAsync(Message msg) => cierrePuntoVentaAsync(DefaultMessage.Merge(msg));
}