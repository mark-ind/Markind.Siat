
namespace Markind.Siat.Tests;

public class _1_ObtencionCufd : BaseTests
{
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task Cuis(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        var res = await siat.Codigos.cuisAsync();
        res.RespuestaCuis.mensajesList.Should().BeNullOrEmpty();
    }
}
