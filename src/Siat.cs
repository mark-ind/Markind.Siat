using Markind.Siat.Generated.FacturacionSincronizacion;
using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionOperaciones;
using Markind.Siat.Generated.ServicioFacturacionElectronica;

namespace Markind.Siat;
public class Siat
{
    public Siat(string token, string baseUrl, Message msgBase) : this(token, baseUrl)
    {
        Sincronizacion.DefaultSolicitudSincronizacion = msgBase.Adapt<solicitudSincronizacion>();
    }

    public Siat(string token, string baseUrl)
    {
        Codigos = new ServicioFacturacionCodigosClient(token, BuildUrl(baseUrl, "v2/FacturacionCodigos"));
        Operaciones = new ServicioFacturacionOperacionesClient(token, BuildUrl(baseUrl, "v2/FacturacionOperaciones"));
        Sincronizacion = new ServicioFacturacionSincronizacionClient(token, BuildUrl(baseUrl, "v2/FacturacionSincronizacion"));
        Facturacion = new ServicioFacturacionClient(token, BuildUrl(baseUrl, "v2/Facturacion"));
    }

    private static string BuildUrl(string baseUrl, string path)
    {
        return new Uri(new Uri(baseUrl), path).ToString();
    }

    public ServicioFacturacionCodigosClient Codigos { get; set; }
    public ServicioFacturacionOperacionesClient Operaciones { get; set; }
    public ServicioFacturacionSincronizacionClient Sincronizacion { get; set; }
    public ServicioFacturacionClient Facturacion { get; set; }
}