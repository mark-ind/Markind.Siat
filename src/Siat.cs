using Markind.Siat.Generated.FacturacionSincronizacion;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionOperaciones;

namespace Markind.Siat;
public class Siat
{
    private const string defaultBaseUrl = "https://pilotosiatservicios.impuestos.gob.bo/";

    public Siat(SiatConfig config) : this(config.Token, config.DefaultMessage, config.BaseUrl ?? defaultBaseUrl){}
    public Siat(string token, OverridableMessage msg, string baseUrl = defaultBaseUrl) : this(token, baseUrl)
    {
        Codigos.DefaultMessage = msg;
        Operaciones.DefaultMessage = msg;
        Sincronizacion.DefaultMessage = msg;
        FacturacionElectronica.DefaultMessage = msg;
        FacturacionComputarizada.DefaultMessage = msg;
        FacturacionCompraVenta.DefaultMessage = msg;

        DefaultMessage = msg;
    }

    private Siat(string token, string baseUrl = defaultBaseUrl)
    {
        Codigos = new ServicioFacturacionCodigosClient(token, BuildUrl(baseUrl, "v2/FacturacionCodigos"));
        Operaciones = new ServicioFacturacionOperacionesClient(token, BuildUrl(baseUrl, "v2/FacturacionOperaciones"));
        Sincronizacion = new ServicioFacturacionSincronizacionClient(token, BuildUrl(baseUrl, "v2/FacturacionSincronizacion"));
        FacturacionElectronica = new Generated.ServicioFacturacionElectronica.ServicioFacturacionClient(token, BuildUrl(baseUrl, "v2/Facturacion"));
        FacturacionComputarizada = new Generated.ServicioFacturacionComputarizada.ServicioFacturacionClient(token, BuildUrl(baseUrl, "v2/Facturacion"));
        FacturacionCompraVenta = new Generated.ServicioFacturacionCompraVenta.ServicioFacturacionClient(token, BuildUrl(baseUrl, "v2/ServicioFacturacionCompraVenta"));
    }

    private static string BuildUrl(string baseUrl, string path)
    {
        return new Uri(new Uri(baseUrl), path).ToString();
    }

    public OverridableMessage DefaultMessage { get; }

    public ServicioFacturacionCodigosClient Codigos { get; set; }
    public ServicioFacturacionOperacionesClient Operaciones { get; set; }
    public ServicioFacturacionSincronizacionClient Sincronizacion { get; set; }
    public Generated.ServicioFacturacionElectronica.ServicioFacturacionClient FacturacionElectronica { get; set; }
    public Generated.ServicioFacturacionComputarizada.ServicioFacturacionClient FacturacionComputarizada { get; set; }
    public Generated.ServicioFacturacionCompraVenta.ServicioFacturacionClient FacturacionCompraVenta { get; set; }
}