using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionOperaciones;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionOperacionesClient
{
    public ServicioFacturacionOperacionesClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public ServicioFacturacionOperacionesClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));
}