
namespace Markind.Siat.Tests;

public class _4_EmisionIndividual : BaseTests
{
    [Ignore("Incomplete")]
    [Repeat(125)]
    [TestCase(0u, DocumentoSector.FacturaEstandar)]
    [TestCase(1u, DocumentoSector.FacturaEstandar)]
    [TestCase(0u, DocumentoSector.FacturaSectoresEducativos)]
    [TestCase(1u, DocumentoSector.FacturaSectoresEducativos)]
    [TestCase(0u, DocumentoSector.FacturaDeArtistasInternacionales)]
    [TestCase(1u, DocumentoSector.FacturaDeArtistasInternacionales)]
    [TestCase(0u, DocumentoSector.NotaFiscalDeArtistasNacionales)]
    [TestCase(1u, DocumentoSector.NotaFiscalDeArtistasNacionales)]
    [TestCase(0u, DocumentoSector.FacturaComercialDeLibreConsignaciónYpfb)]
    [TestCase(1u, DocumentoSector.FacturaComercialDeLibreConsignaciónYpfb)]
    public async Task EmisionIndividual(uint codigoPuntoVenta, DocumentoSector documentoSector)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);
        siat.DefaultMessage.Cufd = GetCachedCufd(codigoPuntoVenta);

        // var res = await siat.Codigos.cufdAsync();
        // res.RespuestaCufd.mensajesList.Should().BeNullOrEmpty();
    }
}
