
namespace Markind.Siat.Tests;

public class BaseTests
{
    protected readonly Siat siat;

    public BaseTests()
    {
        siat = new Siat(Data.Token, Data.OverridableMessage);
    }
}
