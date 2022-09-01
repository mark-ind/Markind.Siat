using System.Text.Json;
using Metalama.Framework.Aspects;
using Metalama.Framework.Fabrics;
using Markind.Siat.Generated.FacturacionSincronizacion;
namespace Markind.Aop;

internal class Fabric : ProjectFabric
{
    public override void AmendProject(IProjectAmender project)
    {
        project.With(p => p.Types.Where(t => t.Name.Equals(nameof(ServicioFacturacionSincronizacionClient), StringComparison.InvariantCultureIgnoreCase))
                .SelectMany(t => t.Methods)
                .Where(
            m => !m.IsStatic
            && m.Parameters.Count > 0
            && m.Parameters[0].Name.Equals(nameof(solicitudSincronizacion), StringComparison.InvariantCultureIgnoreCase)
            )).AddAspect<MergeSolicitudSincronizacion>();
    }
}

internal class MergeSolicitudSincronizacion : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        if (meta.Target.Method.Parameters.Count <= 0 || meta.This.DefaultSolicitudSincronizacion == null) return meta.Proceed();

        var dest = meta.Target.Method.Parameters[0].Value as solicitudSincronizacion;
        var src = meta.This.DefaultSolicitudSincronizacion as solicitudSincronizacion;

        dest.codigoAmbiente = dest.codigoAmbiente == default ? src.codigoAmbiente : default;
        dest.codigoSistema ??= meta.This.DefaultSolicitudSincronizacion.codigoSistema;
        dest.nit = dest.nit == default ? src.nit : default;
        dest.cuis ??= meta.This.DefaultSolicitudSincronizacion.cuis;
        dest.codigoSucursal = dest.codigoSucursal == default ? src.codigoSucursal : default;
        dest.codigoPuntoVenta ??= meta.This.DefaultSolicitudSincronizacion.codigoPuntoVenta;

        Console.WriteLine($"Executing {meta.Target.Method}. With args {JsonSerializer.Serialize(dest)}");

        return meta.Proceed();
    }
}
