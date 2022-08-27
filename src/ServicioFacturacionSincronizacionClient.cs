using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionSincronizacion;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionSincronizacionClient
{
    public ServicioFacturacionSincronizacionClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));

    public ServicioFacturacionSincronizacionClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));
}