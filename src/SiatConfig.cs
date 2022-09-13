namespace Markind.Siat;

public class SiatConfig
{
    public string Token { get; set; } = null!;
    public OverridableMessage DefaultMessage { get; set; } = null!;
    public string? BaseUrl { get; set; }
}