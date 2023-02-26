namespace Markind.Siat;

// Notice this may change and there is an API to get it await siat.Sincronizacion.sincronizarParametricaTipoPuntoVentaAsync();
public enum PuntoVenta : short
{
    Ninguno = 0,
    Comisionista = 1,
    VentanillaDeCobranza = 2,
    VentaMoviles = 3,
    VentaYPFB = 4,
    VentaCajeros = 5,
    VentaConjunta = 6,
}