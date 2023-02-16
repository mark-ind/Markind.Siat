
namespace Markind.Siat.Tests;

public class _3_ObtencionCufd : BaseTests
{
    [Repeat(99)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task Cuf(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Codigos.cufdAsync();
        res.RespuestaCufd.mensajesList.Should().BeNullOrEmpty();
    }
}
