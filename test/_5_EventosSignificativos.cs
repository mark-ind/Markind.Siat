
namespace Markind.Siat.Tests;

public class _5_EventosSignificativos : BaseTests
{
    [Repeat(1)]
    [TestCase(0u, EventoSignificativo.CorteDelServicioDeInternet)]
    // [TestCase(1u, EventoSignificativo.CorteDelServicioDeInternet)]
    // [TestCase(0u, EventoSignificativo.InaccesibilidadAlServicioWebDeLaAdministracionTributaria)]
    // [TestCase(1u, EventoSignificativo.InaccesibilidadAlServicioWebDeLaAdministracionTributaria)]
    // [TestCase(0u, EventoSignificativo.IngresoAZonasSinInternetPorDespliegueDePuntoDeVentaEnVehiculosAutomotores)]
    // [TestCase(1u, EventoSignificativo.IngresoAZonasSinInternetPorDespliegueDePuntoDeVentaEnVehiculosAutomotores)]
    // [TestCase(0u, EventoSignificativo.VentaEnLugaresSinInternet)]
    // [TestCase(1u, EventoSignificativo.VentaEnLugaresSinInternet)]
    // [TestCase(0u, EventoSignificativo.VirusInformaticoOFallaDeSoftware)]
    // [TestCase(1u, EventoSignificativo.VirusInformaticoOFallaDeSoftware)]
    // [TestCase(0u, EventoSignificativo.CambioDeInfraestructuraDelSistemaInformaticoDeFacturacionOFallaDeHardware)]
    // [TestCase(1u, EventoSignificativo.CambioDeInfraestructuraDelSistemaInformaticoDeFacturacionOFallaDeHardware)]
    // [TestCase(0u, EventoSignificativo.CorteDeSuministroDeEnergiaElectrica)]
    // [TestCase(1u, EventoSignificativo.CorteDeSuministroDeEnergiaElectrica)]
    public async Task RegistroEvento(uint codigoPuntoVenta, EventoSignificativo evento)
    {
        var msg = (SolicitudEventoSignificativo) siat.DefaultMessage;
        msg.CodigoMotivoEvento = evento;
        msg.Descripcion = evento.ToString();
        msg.CodigoPuntoVenta = codigoPuntoVenta;
        msg.CodigoPuntoVentaSpecified = true;
        msg.Cufd = GetCachedCufd(codigoPuntoVenta);
        msg.CufdEvento = "BQT5CREopRUE=NzEE2MjdDREJFQjc=Q0FEMk1XWENYVUFI1QzgxMTNFRTcwO";//cufd pasado de cuando se genero el evento
        msg.Cuis = GetCachedCuis(codigoPuntoVenta);
        msg.FechaHoraInicioEvento = DateTime.Now.AddHours(-2);
        msg.FechaHoraFinEvento = DateTime.Now.AddHours(-1);

        var res = await siat.Operaciones.registroEventoSignificativoAsync(msg);
        res.RespuestaListaEventos.mensajesList.Should().BeNullOrEmpty();
    }
}
