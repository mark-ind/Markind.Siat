using System.Collections;
using Mapster;

namespace Markind.Siat;

public abstract class SolicitudServicio
{
    public Ambiente CodigoAmbiente { get; set; }
    public uint? CodigoPuntoVenta { get; set; }
    public required string CodigoSistema { get; set; }
    public uint CodigoSucursal { get; set; }
    public ulong Nit { get; set; }

    protected static readonly ArrayList configuredAdapters = new();

    protected static TDestination Cast<TSource, TDestination>(TSource src)
    {
        ConfigMap<TSource, TDestination>();
        return src.Adapt<TDestination>();
    }

    protected static void ConfigMap<TSource, TDestination>()
    {
        var item = (typeof(TSource), typeof(TDestination));
        // Check if type was already configured, otherwise mapster throws exception, and i do not want to use .NewConfig for efficiency
        if (configuredAdapters.Contains(item)) return;
        configuredAdapters.Add(item);

        TypeAdapterConfig<TSource, TDestination>
                    .ForType()
                    .NameMatchingStrategy(NameMatchingStrategy.Flexible)
                    .IgnoreNullValues(true);
    }
}