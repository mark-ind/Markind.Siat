using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Mapster;

namespace Markind.Siat;

public class SolicitudRecepcion
{
    public SolicitudRecepcion() {}

    [SetsRequiredMembers]
    public SolicitudRecepcion(MessageBase msg)
    {
        CodigoAmbiente = msg.CodigoAmbiente ?? Ambiente.Ninguno;
        CodigoModalidad = msg.CodigoModalidad ?? Modalidad.Ninguno;
        CodigoPuntoVenta = msg.CodigoPuntoVenta;
        CodigoSistema = msg.CodigoSistema;
        CodigoSucursal = msg.CodigoSucursal ?? 0;
        ArgumentException.ThrowIfNullOrEmpty(msg.Cufd);
        Cufd = msg.Cufd;
        ArgumentException.ThrowIfNullOrEmpty(msg.Cuis);
        Cuis = msg.Cuis;
        Nit = msg.Nit ?? 0;
    }

    public Ambiente CodigoAmbiente { get; set; }
    public DocumentoSector CodigoDocumentoSector { get; set; }
    public TipoEmision CodigoEmision { get; set; }
    public Modalidad CodigoModalidad { get; set; }
    public uint? CodigoPuntoVenta { get; set; }
    public  required string CodigoSistema { get; set; }
    public uint CodigoSucursal { get; set; }
    public required string Cufd { get; set; }
    public required string Cuis { get; set; }
    public ulong Nit { get; set; }
    public TipoFactura TipoFacturaDocumento { get; set; }

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