
namespace Markind.Siat.Tests;

public class BaseTests
{
    protected readonly Siat siat;
    private static readonly Dictionary<uint, string> CuisCache = new();
    private static readonly Dictionary<uint, string> CufdCache = new();

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
            CufdCache[codigoPuntoVenta] = siat.Codigos.cufd().codigo;
        }

        return CufdCache[codigoPuntoVenta];
    }
}
