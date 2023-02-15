
namespace Markind.Siat.Tests;

public class _2_SincronizacionCatalogos : BaseTests
{
    // [Repeat (50)]
    // [TestCase(0u)]
    [TestCase(1u)]
    public async Task FechaYHoraActualAsync(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        await siat.Sincronizacion.sincronizarFechaHoraAsync();
    }
}
