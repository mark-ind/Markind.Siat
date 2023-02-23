using System.Runtime.Serialization;

namespace Markind.Siat;

public enum EventoSignificativo : short
{
    Ninguno = 0,
    [EnumMember(Value = "CORTE DEL SERVICIO DE INTERNET")]
    CorteDelServicioDeInternet = 1,
    [EnumMember(Value = "INACCESIBILIDAD AL SERVICIO WEB DE LA ADMINISTRACIÓN TRIBUTARIA")]
    InaccesibilidadAlServicioWebDeLaAdministracionTributaria = 2,
    [EnumMember(Value = "INGRESO A ZONAS SIN INTERNET POR DESPLIEGUE DE PUNTO DE VENTA EN VEHICULOS AUTOMOTORES")]
    IngresoAZonasSinInternetPorDespliegueDePuntoDeVentaEnVehiculosAutomotores = 3,
    [EnumMember(Value = "VENTA EN LUGARES SIN INTERNET")]
    VentaEnLugaresSinInternet = 4,
    [EnumMember(Value = "VIRUS INFORMÁTICO O FALLA DE SOFTWARE")]
    VirusInformaticoOFallaDeSoftware = 5,
    [EnumMember(Value = "CAMBIO DE INFRAESTRUCTURA DEL SISTEMA INFORMÁTICO DE FACTURACIÓN O FALLA DE HARDWARE")]
    CambioDeInfraestructuraDelSistemaInformaticoDeFacturacionOFallaDeHardware = 6,
    [EnumMember(Value = "CORTE DE SUMINISTRO DE ENERGIA ELECTRICA")]
    CorteDeSuministroDeEnergiaElectrica = 7,
}