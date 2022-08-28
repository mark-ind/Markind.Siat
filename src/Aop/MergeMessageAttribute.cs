using Metalama.Framework.Aspects;
using Metalama.Framework.Fabrics;

namespace Markind.Aop;


internal class Fabric : ProjectFabric
    {
        public override void AmendProject( IProjectAmender project )
        {
            project.With( p => p.Types.Where(t=> t.Name == "ServicioFacturacionSincronizacionClient").SelectMany( t => t.Methods ).Where(
                m => !m.IsStatic 
                && m.Parameters.Count > 0
                && m.Parameters[0].Name == "SolicitudSincronizacion"
                ) ).AddAspect<MergeMessageAttribute>();
        }
    }

internal class MergeMessageAttribute : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        string p = string.Empty;
        if(meta.Target.Method.Parameters.Count > 0)
        {
            var a = meta.Target.Method.Parameters[0];
            p = "" + a.Value.nit;
        }
        Console.WriteLine( $"Executing {meta.Target.Method}. With args {p}" );

        try
        {
            return meta.Proceed();
        }
        finally
        {
            Console.WriteLine( $"Exiting {meta.Target.Method}." );
        }
    }
}