using System.Collections;
using Mapster;
using Markind.Siat.Generated.FacturacionOperaciones;

namespace Markind.Siat;

public class SolicitudEventoSignificativo
{
    public Ambiente CodigoAmbiente { get; set; }
    public EventoSignificativo CodigoMotivoEvento {get;set;}
    public uint? CodigoPuntoVenta { get; set; }
    public bool CodigoPuntoVentaSpecified { get; set; }
    public required string CodigoSistema { get; set; }
    public uint CodigoSucursal { get; set; }
    public required string Cufd { get; set; }
    public required string CufdEvento { get; set; }
    public required string Cuis { get; set; }
    public required string Descripcion { get; set; }
    public DateTime FechaHoraFinEvento { get; set; }
    public DateTime FechaHoraInicioEvento { get; set; }
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

    public static implicit operator solicitudEventoSignificativo(SolicitudEventoSignificativo src) => Cast<SolicitudEventoSignificativo, solicitudEventoSignificativo>(src);
    public static explicit operator SolicitudEventoSignificativo(OverridableMessage src) => Cast<OverridableMessage, SolicitudEventoSignificativo>(src);

    public SolicitudEventoSignificativo Merge(MessageBase src) => src.Adapt(this);
}