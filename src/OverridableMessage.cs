using System.Collections;
using System.ComponentModel;
using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionOperaciones;
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

#region FacturacionOperaciones
    public static implicit operator solicitudRegistroPuntoVenta(OverridableMessage src) => Cast<solicitudRegistroPuntoVenta>(src);
    public static implicit operator solicitudPuntoVentaComisionista(OverridableMessage src) => Cast<solicitudPuntoVentaComisionista>(src);
    public static implicit operator solicitudOperaciones(OverridableMessage src) => Cast<solicitudOperaciones>(src);
    public static implicit operator solicitudConsultaEvento(OverridableMessage src) => Cast<solicitudConsultaEvento>(src);
    public static implicit operator solicitudConsultaPuntoVenta(OverridableMessage src) => Cast<solicitudConsultaPuntoVenta>(src);
    public static implicit operator solicitudEventoSignificativo(OverridableMessage src) => Cast<solicitudEventoSignificativo>(src);
    public static implicit operator solicitudCierrePuntoVenta(OverridableMessage src) => Cast<solicitudCierrePuntoVenta>(src);
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

#region ServicioFacturacion
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionPaquete(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudRecepcionPaquete>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudRecepcionFactura>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudValidacionRecepcion(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudValidacionRecepcion>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionAnexos(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudRecepcionAnexos>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudRecepcionMasiva(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudRecepcionMasiva>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudVerificacionEstado(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudVerificacionEstado>(src);
    public static implicit operator Generated.ServicioFacturacionCompraVenta.solicitudAnulacion(OverridableMessage src) => Cast<Generated.ServicioFacturacionCompraVenta.solicitudAnulacion>(src);
#endregion

    private static ArrayList configuredAdapters = new ArrayList();
    // TODO: add logging
    private static TDestination Cast<TDestination>(OverridableMessage src) where TDestination : new()
    {
        ConfigMap<OverridableMessage, TDestination>();
        var res = new TDestination();
        if(res is INotifyPropertyChanged) ((INotifyPropertyChanged)res).Autospecify();
        src.Adapt(res);


        return res;
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

    public OverridableMessage()
    {
        this.Autospecify();
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