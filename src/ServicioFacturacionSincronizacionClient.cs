using System.ServiceModel;
using Markind.Aop;

namespace Markind.Siat.Generated.FacturacionSincronizacion;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
// [MergeMessage]
public partial class ServicioFacturacionSincronizacionClient
{
    public ServicioFacturacionSincronizacionClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));

    internal object Test(solicitudSincronizacion SolicitudSincronizacion)
    {
        Console.WriteLine(SolicitudSincronizacion.nit);
        return 10;
    }

    public ServicioFacturacionSincronizacionClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"Token {token}"));
}