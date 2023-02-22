
using Markind.Siat.Generated.FacturacionSincronizacion;

namespace Markind.Siat.Tests;

public class BaseTests
{
    protected readonly Siat siat;
    private static readonly Dictionary<uint, string> CuisCache = new();
    private static readonly Dictionary<uint, string> CufdCache = new();
    private static readonly Dictionary<uint, string> CodigoControlCache = new();
    private static readonly List<string> Leyendas = new();
    private static readonly List<string> Actividades = new();
    private static readonly List<productosDto> Productos = new();

    public BaseTests()
    {
        siat = new Siat(Data.Token, Data.OverridableMessage);
    }

    public string GetCachedCuis(uint codigoPuntoVenta)
    {
        if(!CuisCache.ContainsKey(codigoPuntoVenta))
        {
            siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
            CuisCache[codigoPuntoVenta] = siat.Codigos.cuis().codigo;
        }

        return CuisCache[codigoPuntoVenta];
    }

    public string GetCachedCufd(uint codigoPuntoVenta)
    {
        if(!CufdCache.ContainsKey(codigoPuntoVenta))
        {
            siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;

            var respuestaCufd = siat.Codigos.cufd();
            CufdCache[codigoPuntoVenta] = respuestaCufd.codigo;
            CodigoControlCache[codigoPuntoVenta] = respuestaCufd.codigoControl;
        }

        return CufdCache[codigoPuntoVenta];
    }

    public string GetCachedCodigoControl(uint codigoPuntoVenta)
    {
        if(!CodigoControlCache.ContainsKey(codigoPuntoVenta))
        {
            siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;

            var respuestaCufd = siat.Codigos.cufd();
            CufdCache[codigoPuntoVenta] = respuestaCufd.codigo;
            CodigoControlCache[codigoPuntoVenta] = respuestaCufd.codigoControl;
        }

        return CodigoControlCache[codigoPuntoVenta];
    }

    public async Task<string> GetCachedRandomLeyendaAsync()
    {
        if(Leyendas.Any()) return Leyendas[new Random().Next(0, Leyendas.Count - 1)];

        var res = await siat.Sincronizacion.sincronizarListaLeyendasFacturaAsync();
        Leyendas.AddRange(res.RespuestaListaParametricasLeyendas.listaLeyendas.Select(l => l.descripcionLeyenda));

        return Leyendas[0];
    }

    public async Task<string> GetCachedRandomCodigoActividadAsync()
    {
        if(Actividades.Any()) return Actividades[new Random().Next(0, Actividades.Count - 1)];

        var res = await siat.Sincronizacion.sincronizarActividadesAsync();
        Actividades.AddRange(res.RespuestaListaActividades.listaActividades.Select(l => l.codigoCaeb));

        return Actividades[0];
    }

    public async Task<productosDto> GetCachedRandomProductoAsync()
    {
        if(Productos.Any()) return Productos[new Random().Next(0, Productos.Count - 1)];

        var res = await siat.Sincronizacion.sincronizarListaProductosServiciosAsync();
        Productos.AddRange(res.RespuestaListaProductos.listaCodigos);

        return Productos[0];
    }
}
