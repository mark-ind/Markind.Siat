using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public class OverridableMessage
{
    static OverridableMessage()
    {
        TypeAdapterConfig<OverridableMessage, solicitudNotifcaRevocado>
            .NewConfig()
            .NameMatchingStrategy(NameMatchingStrategy.Flexible);
    }

    public int codigoAmbiente { get; set; }
    public string codigoSistema { get; set; }
    public long nit { get; set; }
    public int? codigoPuntoVenta { get; set; }
    public int codigoSucursal { get; set; }
    public string cuis { get; set; }
    public int codigoModalidad {get; set;}
    public string certificado {get;set;}
    public DateTime? fechaRevocacion {get; set;}
    public long nitParaVerificacion {get; set;}

    public static implicit operator solicitudNotifcaRevocado(OverridableMessage m) => m.Adapt<solicitudNotifcaRevocado>();
    public static implicit operator solicitudCuis(OverridableMessage m) => m.Adapt<solicitudCuis>();

}

static class OverridableMessageStatic
{
    static OverridableMessageStatic()
    {
        TypeAdapterConfig<Message, OverridableMessage>
            .NewConfig()
            .NameMatchingStrategy(NameMatchingStrategy.Flexible)
            .IgnoreNullValues(true);
            // .IgnoreIf((src, dest) => dest.codigoAmbiente != 0, dest => dest.codigoAmbiente); // works but better make nullable all Message properties
    }

    public static OverridableMessage Merge(this OverridableMessage dest, Message src)
    {
        if (dest is null) return src.Adapt<OverridableMessage>();
        return src.Adapt(dest);
    }
}