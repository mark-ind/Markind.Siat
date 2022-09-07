using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionSincronizacion;

namespace Markind.Siat;

public class OverridableMessage : MessageBase
{
#region FacturacionCodigos
    public static implicit operator solicitudVerificarNit(OverridableMessage src) => Cast<solicitudVerificarNit>(src);
    public static implicit operator solicitudCuis(OverridableMessage src) => Cast<solicitudCuis>(src);
    public static implicit operator solicitudCufdMasivo(OverridableMessage src) => Cast<solicitudCufdMasivo>(src);
    public static implicit operator solicitudCufd(OverridableMessage src) => Cast<solicitudCufd>(src);
    public static implicit operator solicitudCuisMasivoSistemas(OverridableMessage src) => Cast<solicitudCuisMasivoSistemas>(src);
    public static implicit operator solicitudNotifcaRevocado(OverridableMessage src) => Cast<solicitudNotifcaRevocado>(src);
#endregion

#region FacturacionSincronizacion
    public static implicit operator solicitudSincronizacion(OverridableMessage src) => Cast<solicitudSincronizacion>(src);
#endregion

    // TODO: add logging
    private static TDestination Cast<TDestination>(OverridableMessage src)
    {
        ConfigMap<OverridableMessage, TDestination>();
        return src.Adapt<TDestination>();
    }

    private static void ConfigMap<TSource, TDestination>()
    {
        TypeAdapterConfig<TSource, TDestination>
                    .ForType()
                    .NameMatchingStrategy(NameMatchingStrategy.Flexible)
                    .IgnoreNullValues(true);
    }
}

static class OverridableMessageStatic
{
    static OverridableMessageStatic()
    {
        TypeAdapterConfig<Message, OverridableMessage>
            .NewConfig()
            .IgnoreNullValues(true);
             // works but better make nullable all Message properties
            // .IgnoreIf((src, dest) => dest.codigoAmbiente != 0, dest => dest.codigoAmbiente);
    }

    public static OverridableMessage Merge(this OverridableMessage dest, Message src)
    {
        if (dest is null) return src.Adapt<OverridableMessage>();
        return src.Adapt(dest);
    }
}