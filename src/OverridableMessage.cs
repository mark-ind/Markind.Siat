using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public class OverridableMessage
{
    static OverridableMessage()
    {
        TypeAdapterConfig<OverridableMessage, solicitudNotifcaRevocado>
            .NewConfig()
            .IgnoreNullValues(true)
            .ForType<int, int>().MapToTargetWith((src, dest) => src == 0 ? dest : src)
            .ForType<double, double>().MapToTargetWith((src, dest) => src == 0 ? dest : src);
            // config.Default.IgnoreIf((src, dst) => src == default)
        TypeAdapterConfig<int, int>.ForType().MapToTargetWith((src, dest) => src == 0 ? dest : src);
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
    public static OverridableMessage Merge(this OverridableMessage o, Message m)
    {
        if (o is null) return m.Adapt<OverridableMessage>();
        return m.Adapt(o);
    }
}