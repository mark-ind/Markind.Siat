using System.ComponentModel.DataAnnotations;

namespace Markind.Siat;

public enum EventoSignificativo : short
{
    Ninguno = 0,
    [Display(Name = "CORTE DEL SERVICIO DE INTERNET")]
    CorteDelServicioDeInternet = 1,
    [Display(Name = "INACCESIBILIDAD AL SERVICIO WEB DE LA ADMINISTRACIÓN TRIBUTARIA")]
    InaccesibilidadAlServicioWebDeLaAdministracionTributaria = 2,
    [Display(Name = "INGRESO A ZONAS SIN INTERNET POR DESPLIEGUE DE PUNTO DE VENTA EN VEHICULOS AUTOMOTORES")]
    IngresoAZonasSinInternetPorDespliegueDePuntoDeVentaEnVehiculosAutomotores = 3,
    [Display(Name = "VENTA EN LUGARES SIN INTERNET")]
    VentaEnLugaresSinInternet = 4,
    [Display(Name = "VIRUS INFORMÁTICO O FALLA DE SOFTWARE")]
    VirusInformaticoOFallaDeSoftware = 5,
    [Display(Name = "CAMBIO DE INFRAESTRUCTURA DEL SISTEMA INFORMÁTICO DE FACTURACIÓN O FALLA DE HARDWARE")]
    CambioDeInfraestructuraDelSistemaInformaticoDeFacturacionOFallaDeHardware = 6,
    [Display(Name = "CORTE DE SUMINISTRO DE ENERGIA ELECTRICA")]
    CorteDeSuministroDeEnergiaElectrica = 7,
}