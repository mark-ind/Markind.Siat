
namespace Markind.Siat.Tests;

public class BaseTests
{
    protected readonly Siat siat;
    private static readonly Dictionary<uint, string> CuisCache = new();

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
}
