using DotNetEnv;
namespace Markind.Siat.Tests;

internal static class Data
{
    internal static string Token;
    internal static OverridableMessage OverridableMessage;

    static Data()
    {
        Env.TraversePath().Load();

        Token = Env.GetString("Token");
        OverridableMessage = new()
        {
            CodigoAmbiente = Ambiente.Pruebas,
            CodigoSistema = Env.GetString("CodigoSistema"),
            Nit = ulong.Parse(Env.GetString("Nit")),
            CodigoSucursal = 0,
            CodigoModalidad = (Modalidad)Enum.Parse(typeof(Modalidad), Env.GetString("CodigoModalidad")),
            Cuis = Env.GetString("Cuis")
        };
    }
}