using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionCodigos;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionCodigosClient
{
    public ServicioFacturacionCodigosClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public ServicioFacturacionCodigosClient(string token, string url) : base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new() { { "apikey", $"TokenApi {token}" } }));

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaVerificarNit verificarNit() => verificarNit(DefaultMessage);
    public respuestaVerificarNit verificarNit(Message msg) => verificarNit(DefaultMessage.Merge(msg));
    public Task<verificarNitResponse> verificarNitAsync() => verificarNitAsync(DefaultMessage);
    public Task<verificarNitResponse> verificarNitAsync(Message msg) => verificarNitAsync(DefaultMessage.Merge(msg));
    public respuestaCuisMasivo cuisMasivo() => cuisMasivo(DefaultMessage);
    public respuestaCuisMasivo cuisMasivo(Message msg) => cuisMasivo(DefaultMessage.Merge(msg));
    public Task<cuisMasivoResponse> cuisMasivoAsync() => cuisMasivoAsync(DefaultMessage);
    public Task<cuisMasivoResponse> cuisMasivoAsync(Message msg) => cuisMasivoAsync(DefaultMessage.Merge(msg));
    public respuestaCufd cufd() => cufd(DefaultMessage);
    public respuestaCufd cufd(Message msg) => cufd(DefaultMessage.Merge(msg));
    public Task<cufdResponse> cufdAsync() => cufdAsync(DefaultMessage);
    public Task<cufdResponse> cufdAsync(Message msg) => cufdAsync(DefaultMessage.Merge(msg));
    public respuestaNotificaRevocado notificaCertificadoRevocado() => notificaCertificadoRevocado(DefaultMessage);
    public respuestaNotificaRevocado notificaCertificadoRevocado(Message msg) => notificaCertificadoRevocado(DefaultMessage.Merge(msg));
    public Task<notificaCertificadoRevocadoResponse> notificaCertificadoRevocadoAsync() => notificaCertificadoRevocadoAsync(DefaultMessage);
    public Task<notificaCertificadoRevocadoResponse> notificaCertificadoRevocadoAsync(Message msg) => notificaCertificadoRevocadoAsync(DefaultMessage.Merge(msg));
    public respuestaCuis cuis() => cuis(DefaultMessage);
    public respuestaCuis cuis(Message msg) => cuis(DefaultMessage.Merge(msg));
    public Task<cuisResponse> cuisAsync() => cuisAsync(DefaultMessage);
    public Task<cuisResponse> cuisAsync(Message msg) => cuisAsync(DefaultMessage.Merge(msg));
    public respuestaCufdMasivo cufdMasivo() => cufdMasivo(DefaultMessage);
    public respuestaCufdMasivo cufdMasivo(Message msg) => cufdMasivo(DefaultMessage.Merge(msg));
    public Task<cufdMasivoResponse> cufdMasivoAsync() => cufdMasivoAsync(DefaultMessage);
    public Task<cufdMasivoResponse> cufdMasivoAsync(Message msg) => cufdMasivoAsync(DefaultMessage.Merge(msg));
}