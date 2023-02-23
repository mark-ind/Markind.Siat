
namespace Markind.Siat.Tests;

// read https://siatinfo.impuestos.gob.bo/index.php/facturacion-en-linea/emision-y-envio-de-facturas/contingencia-y-eventos-significativos
public class _5_EventosSignificativos : BaseTests
{
    [Test]
    public async Task RegistroEvento()
    {
        DateTime yesterday = DateTime.Today.AddDays(-1).AddHours(22);
        const string yesterdayCufd = "BQT5CREopRUE=NzEE2MjdDREJFQjc=Q0FEMk1XWENYVUFI1QzgxMTNFRTcwO";
        //today BQT5CREopRUE=NzEE2MjdDREJFQjc=Q0t8a0JRWUNYVUFI1QzgxMTNFRTcwO

        var eventos = Enum.GetValues(typeof(EventoSignificativo)).Cast<EventoSignificativo>().ToList();
        eventos.Remove(EventoSignificativo.Ninguno);

        var repeat = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int e = 0; e < eventos.Count; e++)
            {
                for (uint p = 0; p < 1; p++) // punto de venta
                {
                    var msg = (SolicitudEventoSignificativo) siat.DefaultMessage;
                    msg.CodigoMotivoEvento = eventos[e];
                    msg.Descripcion = Enum.GetName(typeof(EventoSignificativo), eventos[e]);
                    msg.CodigoPuntoVenta = p;
                    msg.CodigoPuntoVentaSpecified = true;
                    msg.Cufd = GetCachedCufd(p);
                    msg.CufdEvento = yesterdayCufd;//cufd pasado de cuando se genero el evento
                    msg.Cuis = GetCachedCuis(p);
                    msg.FechaHoraInicioEvento = yesterday.AddMinutes(repeat);
                    msg.FechaHoraFinEvento = msg.FechaHoraInicioEvento.AddMinutes(4);

                    var res = await siat.Operaciones.registroEventoSignificativoAsync(msg);
                    //res.RespuestaListaEventos.mensajesList.Should().BeNullOrEmpty();

                    repeat += 5;
                }
            }
        }
    }
}
