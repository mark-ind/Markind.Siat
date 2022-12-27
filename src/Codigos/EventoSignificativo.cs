namespace Markind.Siat;

public enum EventoSignificativo : short
{
    Ninguno = 0,
    InicioDeOperaciones = 968,
    CierreDeOperaciones = 969,
    ProblemasDeComunicaciónExternaConServidor = 970,
    ProblemasDeComunicaciónInternaConPuntosDeVentaOClientes = 971,
    CorteDeSuministroDeEnergiaElectrica = 972,
    CorteDelServicioDeInternet = 973,
    VirusInformáticoOFallaDeSoftware = 974,
    CambioDeInfraestructuraDelSistemaOFallaDeHardware = 975,
    InaccesibilidadAlServicioWebDeLaAdministraciónTributaria = 976,
    IngresoAZonasSinInternetPorDespliegueDePuntoDeVenta = 977,
    ActualizaciónDeParamétricas = 978,
    SincronizaciónDeHuellasDeSistema = 979,
    AdiciónDePuntoDeVenta = 3054,
    ImpresoraNoDisponible = 3055,
    RenovaciónDeCertificadoDigital = 3056,
    CorreoElectrónicoNoDisponible = 3057,
}