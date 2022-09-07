using System.Collections;
using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionSincronizacion;
using Markind.Siat.Generated.ServicioFacturacionElectronica;

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

#region ServicioFacturacionElectronica
    public static implicit operator solicitudRecepcionPaquete(OverridableMessage src) => Cast<solicitudRecepcionPaquete>(src);
    public static implicit operator solicitudRecepcionFactura(OverridableMessage src) => Cast<solicitudRecepcionFactura>(src);
    public static implicit operator solicitudValidacionRecepcion(OverridableMessage src) => Cast<solicitudValidacionRecepcion>(src);
    public static implicit operator solicitudRecepcionMasiva(OverridableMessage src) => Cast<solicitudRecepcionMasiva>(src);
    public static implicit operator solicitudVerificacionEstado(OverridableMessage src) => Cast<solicitudVerificacionEstado>(src);
    public static implicit operator solicitudAnulacion(OverridableMessage src) => Cast<solicitudAnulacion>(src);
#endregion

    private static ArrayList configuredAdapters = new ArrayList();
    // TODO: add logging
    private static TDestination Cast<TDestination>(OverridableMessage src)
    {
        ConfigMap<OverridableMessage, TDestination>();
        return src.Adapt<TDestination>();
    }

    private static void ConfigMap<TSource, TDestination>()
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