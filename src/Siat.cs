using Markind.Siat.Generated.FacturacionSincronizacion;
using Mapster;

namespace Markind.Siat;
// maybe https://stackoverflow.com/a/3734761/1100301
public class Siat
{
    private readonly MessageBase msgBase;

    public Siat(string token, string baseUrl, MessageBase msgBase)
    {
        this.msgBase = msgBase;

        ServicioSyncronizacion = new ServicioFacturacionSincronizacionClient(token, new Uri(new Uri(baseUrl), "v2/FacturacionSincronizacion").ToString());
        ServicioSyncronizacion.DefaultSolicitudSincronizacion = msgBase.Adapt<solicitudSincronizacion>(); // better merge?
    }

    public Siat(MessageBase msgBase, string token, string url)
    {
        this.msgBase = msgBase;

        ServicioSyncronizacion = new ServicioFacturacionSincronizacionClient(token, url);
    }

    public ServicioFacturacionSincronizacionClient ServicioSyncronizacion { get; set; }
}