
namespace Markind.Siat.Tests;

public class _0_Registros : BaseTests
{
    [Test]
    public async Task PuntoVentaAsync()
    {
        siat.DefaultMessage.CodigoTipoPuntoVenta = PuntoVenta.VentanillaDeCobranza;
        siat.DefaultMessage.NombrePuntoVenta = "Punto 1";
        siat.DefaultMessage.Descripcion = "Solo para pruebas";

        var res = await siat.Operaciones.registroPuntoVentaAsync();
        res.RespuestaRegistroPuntoVenta.mensajesList.Should().BeNullOrEmpty();
    }
}
