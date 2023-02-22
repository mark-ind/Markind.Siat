
namespace Markind.Siat.Tests;

public class _2_SincronizacionCatalogos : BaseTests
{
    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task Actividades(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarActividadesAsync();
        res.RespuestaListaActividades.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task FechaYHoraActual(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarFechaHoraAsync();
        res.RespuestaFechaHora.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task ActividadesDocumentoSector(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarListaActividadesDocumentoSectorAsync();
        res.RespuestaListaActividadesDocumentoSector.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task LeyendasFactura(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarListaLeyendasFacturaAsync();
        res.RespuestaListaParametricasLeyendas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task MensajesServicios(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarListaMensajesServiciosAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task ProductosServicios(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarListaProductosServiciosAsync();
        res.RespuestaListaProductos.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task EventosSignificativos(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaEventosSignificativosAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task MotivoAnulacion(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaMotivoAnulacionAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task Paises(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaPaisOrigenAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoDocumentoIdentidad(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoDocumentoIdentidadAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TiposDocumentoSector(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoDocumentoSectorAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoEmision(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoEmisionAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoHabitacion(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoHabitacionAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task MetodoPago(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoMetodoPagoAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (1)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoMoneda(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoMonedaAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoPuntoVenta(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTipoPuntoVentaAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (50)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task TipoFactura(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaTiposFacturaAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }

    [Repeat (1)]
    [TestCase(0u)]
    [TestCase(1u)]
    public async Task UnidadMedida(uint codigoPuntoVenta)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);

        var res = await siat.Sincronizacion.sincronizarParametricaUnidadMedidaAsync();
        res.RespuestaListaParametricas.mensajesList.Should().BeNullOrEmpty();
    }
}
