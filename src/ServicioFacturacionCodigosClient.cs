using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionCodigos;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionCodigosClient
{
    public ServicioFacturacionCodigosClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public ServicioFacturacionCodigosClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public OverridableMessage DefaultMessage { get; set; }
    public solicitudCuis? DefaultSolicitudCuis { get; set; }
    public solicitudNotifcaRevocado? DefaultSolicitudNotifcaRevocado { get; set; }
    public solicitudCufd? DefaultSolicitudCufd { get; set; }
    public solicitudCuisMasivoSistemas? DefaultSolicitudCuisMasivoSistemas { get; set; }
    
    public respuestaCuis cuis() => cuis(DefaultMessage);
    public respuestaCuis cuis(Message message)
    {
        return cuis(DefaultMessage.Merge(message));
    }
}