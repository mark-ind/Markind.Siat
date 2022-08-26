using System.ServiceModel;

namespace Markind.Siat;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionClient
{
    public ServicioFacturacionClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));

    public ServicioFacturacionClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));
}