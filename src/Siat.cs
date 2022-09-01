using Markind.Siat.Generated.FacturacionSincronizacion;

namespace Markind.Siat;
// maybe https://stackoverflow.com/a/3734761/1100301
public class Siat
{
    private readonly MessageBase msgBase;

    public Siat(MessageBase msgBase, string token)
    {
        this.msgBase = msgBase;

        ServicioSyncronizacion = new ServicioFacturacionSincronizacionClient(token);
    }

    public Siat(MessageBase msgBase, string token, string url)
    {
        this.msgBase = msgBase;

        ServicioSyncronizacion = new ServicioFacturacionSincronizacionClient(token, url);
    }

    public ServicioFacturacionSincronizacionClient ServicioSyncronizacion { get; set; }
}