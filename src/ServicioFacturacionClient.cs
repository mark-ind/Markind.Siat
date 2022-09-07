using System.ServiceModel;

namespace Markind.Siat.Generated.ServicioFacturacionElectronica;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionClient
{
    public ServicioFacturacionClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/Facturacion"): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public OverridableMessage DefaultMessage { get; set; } = new();
}