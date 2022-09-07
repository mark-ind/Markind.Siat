using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public class OverridableMessage : MessageBase
{
    static OverridableMessage()
    {
        ConfigMap<OverridableMessage, solicitudCuis>();
        ConfigMap<OverridableMessage, solicitudNotifcaRevocado>();
    }

    public static implicit operator solicitudCuis(OverridableMessage source) => source.Adapt<solicitudCuis>();
    public static implicit operator solicitudNotifcaRevocado(OverridableMessage source) => source.Adapt<solicitudNotifcaRevocado>();

    private static void ConfigMap<TSource, TDestination>()
    {
        TypeAdapterConfig<TSource, TDestination>
                    .NewConfig()
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