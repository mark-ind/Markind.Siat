using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionOperaciones;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
public partial class ServicioFacturacionOperacionesClient
{
    public ServicioFacturacionOperacionesClient(string token, string url = "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionOperacione"): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public OverridableMessage DefaultMessage { get; set; } = new();
}