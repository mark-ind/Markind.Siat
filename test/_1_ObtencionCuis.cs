
namespace Markind.Siat.Tests;

public class _1_ObtencionCuis : BaseTests
{
    //[TestCase(0u)]
    [TestCase(1u)]
    public void GetCuis(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.Codigos.cuis();
    }
}
