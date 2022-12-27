using System.ComponentModel;

namespace Markind.Siat;

public enum MensajesSoap : short
{
    [Description("Ninguno")]
    Ninguno = 0,

    [Description("Ambiente Inválido")]
    AmbienteInvalido = 1,

    [Description("Código de Sistema Invalido")]
    CodigoDeSistemaInvalido = 2,

    [Description("Código Único de Inicio de Sistema (CUIS) Invalido")]
    CodigoUnicoDeInicioDeSistemaCuisInvalido = 3,

    [Description("Código Único de Facturación Diario (CUFD) Invalido")]
    CodigoUnicoDeFacturacionDiarioCufdInvalido = 4,

    [Description("Documento Fiscal Invalido")]
    DocumentoFiscalInvalido = 5,

    [Description("Tipo Emisión Invalido")]
    TipoEmisionInvalido = 6,

    [Description("Modalidad Invalida")]
    ModalidadInvalida = 7,

    [Description("Sucursal Invalida")]
    SucursalInvalida = 8,

    [Description("NIT Invalido")]
    NitInvalido = 9,

    [Description("Archivo Invalido")]
    ArchivoInvalido = 10,

    [Description("Firma Incorrecta")]
    FirmaIncorrecta = 11,

    [Description("Firma No corresponde al Contribuyente")]
    FirmaNoCorrespondeAlContribuyente = 12,

    [Description("Código de Recepción Invalido")]
    CodigoDeRecepcionInvalido = 13,

    [Description("Numero Documento Fiscal Duplicado")]
    NumeroDocumentoFiscalDuplicado = 14,

    [Description("Numero Documento Fiscal Inexistente")]
    NumeroDocumentoFiscalInexistente = 15,

    [Description("Nombre de Cajero con caracteres inválidos")]
    NombreDeCajeroConCaracteresInvalidos = 16,

    [Description("Fecha Emision mayor a definido en normativa")]
    FechaEmisionMayorADefinidoEnNormativa = 17,

    [Description("Fecha Emision menor a definido en normativa")]
    FechaEmisionMenorADefinidoEnNormativa = 18,

    [Description("Tipo Documento Identidad Invalido")]
    TipoDocumentoIdentidadInvalido = 19,

    [Description("Código Único de Factura (CUF) Invalido")]
    CodigoUnicoDeFacturaCufInvalido = 20,

    [Description("XML Invalido")]
    XmlInvalido = 21,

    [Description("El periodo_facturado no contiene un valor valido")]
    ElPeriodoFacturadoNoContieneUnValorValido = 22,

    [Description("El campo Estudiante es requerido para este tipo de factura")]
    ElCampoEstudianteEsRequeridoParaEsteTipoDeFactura = 23,

    [Description("El Tipo Cambio es requerido en este tipo de factura")]
    ElTipoCambioEsRequeridoEnEsteTipoDeFactura = 24,

    [Description("Incoterm es requerido en este tipo de factura")]
    IncotermEsRequeridoEnEsteTipoDeFactura = 25,

    [Description("Puerto destino es requerido en este tipo de factura")]
    PuertoDestinoEsRequeridoEnEsteTipoDeFactura = 26,

    [Description("Tipo moneda es requerido en este tipo de factura")]
    TipoMonedaEsRequeridoEnEsteTipoDeFactura = 27,

    [Description("Tipo de  Moneda Invalido")]
    TipoDeMonedaInvalido = 28,

    [Description("Precio valor bruto es requerido en este tipo de factura")]
    PrecioValorBrutoEsRequeridoEnEsteTipoDeFactura = 29,

    [Description("Gastos transporte frontera es requerido en este tipo de factura")]
    GastosTransporteFronteraEsRequeridoEnEsteTipoDeFactura = 30,

    [Description("Gastos seguro frontera es requerido en este tipo de factura")]
    GastosSeguroFronteraEsRequeridoEnEsteTipoDeFactura = 31,

    [Description("Total fob frontera es requerido en este tipo de factura")]
    TotalFobFronteraEsRequeridoEnEsteTipoDeFactura = 32,

    [Description("Monto transporte internacional es requerido en este tipo de factura")]
    MontoTransporteInternacionalEsRequeridoEnEsteTipoDeFactura = 33,

    [Description("Monto seguro internacional es requerido en este tipo de factura")]
    MontoSeguroInternacionalEsRequeridoEnEsteTipoDeFactura = 34,

    [Description("Otros montos es requerido en este tipo de factura")]
    OtrosMontosEsRequeridoEnEsteTipoDeFactura = 35,

    [Description("Total Moneda es requerido en este tipo de factura")]
    TotalMonedaEsRequeridoEnEsteTipoDeFactura = 36,

    [Description("Total Puerto es requerido en este tipo de factura")]
    TotalPuertoEsRequeridoEnEsteTipoDeFactura = 37,

    [Description("Operador Turismo receptivo es requerido en este tipo de factura")]
    OperadorTurismoReceptivoEsRequeridoEnEsteTipoDeFactura = 38,

    [Description("Remitente es requerido en este tipo de factura")]
    RemitenteEsRequeridoEnEsteTipoDeFactura = 39,

    [Description("Consignatario es requerido en este tipo de factura")]
    ConsignatarioEsRequeridoEnEsteTipoDeFactura = 40,

    [Description("Placa es requerido en este tipo de factura")]
    PlacaEsRequeridoEnEsteTipoDeFactura = 41,

    [Description("Código de pais es requerido en este tipo de factura")]
    CodigoDePaisEsRequeridoEnEsteTipoDeFactura = 42,

    [Description("Código de País Invalido")]
    CodigoDePaisInvalido = 43,

    [Description("Monto Ley 317 es requerido en este tipo de factura")]
    MontoLey_317EsRequeridoEnEsteTipoDeFactura = 44,

    [Description("Monto Total Sujeto a IVA es requerido en este tipo de factura")]
    MontoTotalSujetoAIvaEsRequeridoEnEsteTipoDeFactura = 45,

    [Description("Monto Total Sujeto a IPJ es requerido en este tipo de factura")]
    MontoTotalSujetoAIpjEsRequeridoEnEsteTipoDeFactura = 46,

    [Description("Monto Total IJ es requerido en este tipo de factura")]
    MontoTotalIjEsRequeridoEnEsteTipoDeFactura = 47,

    [Description("Monto por diferencia de tipo de cambio es requerido en este tipo de factura")]
    MontoPorDiferenciaDeTipoDeCambioEsRequeridoEnEsteTipoDeFactura = 48,

    [Description("Monto ICE es requerido en este tipo de factura")]
    MontoIceEsRequeridoEnEsteTipoDeFactura = 49,

    [Description("Monto IDH es requerido en este tipo de factura")]
    MontoIdhEsRequeridoEnEsteTipoDeFactura = 50,

    [Description("Código de Producto Invalido")]
    CodigoDeProductoInvalido = 51,

    [Description("Producto no coincide con la actividad")]
    ProductoNoCoincideConLaActividad = 52,

    [Description("Actividad Invalida")]
    ActividadInvalida = 53,

    [Description("Monto total no coincide con la sumatoria de los subtotales y descuentos")]
    MontoTotalNoCoincideConLaSumatoriaDeLosSubtotalesYDescuentos = 54,

    [Description("Calculo del subtotal incorrecto")]
    CalculoDelSubtotalIncorrecto = 55,

    [Description("Monto Ley 317 incorrecto")]
    MontoLey_317Incorrecto = 56,

    [Description("Monto Total Sujeto a IVA incorrecto")]
    MontoTotalSujetoAIvaIncorrecto = 57,

    [Description("Monto Total Sujeto IPJ incorrecto")]
    MontoTotalSujetoIpjIncorrecto = 58,

    [Description("Monto Total IJ incorrecto")]
    MontoTotalIjIncorrecto = 59,

    [Description("Monto ICE incorrecto")]
    MontoIceIncorrecto = 60,

    [Description("Monto IDH incorrecto")]
    MontoIdhIncorrecto = 61,

    [Description("Motivo de Anulación Invalido")]
    MotivoDeAnulacionInvalido = 62,

    [Description("Error de ejecución del servicio")]
    ErrorDeEjecucionDelServicio = 63,

    [Description("Servicio de verificación de recepción incorrecto")]
    ServicioDeVerificacionDeRecepcionIncorrecto = 64,

    [Description("Error de datos")]
    ErrorDeDatos = 65,

    [Description("Comunicacion exitosa")]
    ComunicacionExitosa = 66,

    [Description("Error al recuperar datos básicos asociados al NIT")]
    ErrorAlRecuperarDatosBasicosAsociadosAlNit = 67,

    [Description("Error durante la validación de datos de emisor")]
    ErrorDuranteLaValidacionDeDatosDeEmisor = 68,

    [Description("Error durante la recepción de Nota Fiscal")]
    ErrorDuranteLaRecepcionDeNotaFiscal = 69,

    [Description("Error durante la recepción de Nota Fiscal Paquete")]
    ErrorDuranteLaRecepcionDeNotaFiscalPaquete = 70,

    [Description("Error durante la recepción del documento fiscal")]
    ErrorDuranteLaRecepcionDelDocumentoFiscal = 71,

    [Description("Fecha Firma Invalida")]
    FechaFirmaInvalida = 72,

    [Description("Firma Revocada")]
    FirmaRevocada = 73,

    [Description("Certificado Firma Invalido")]
    CertificadoFirmaInvalido = 74,

    [Description("NIT no tiene asociada la modalidad")]
    NitNoTieneAsociadaLaModalidad = 75,

    [Description("El NIT presenta marcas de control")]
    ElNitPresentaMarcasDeControl = 76,

    [Description("NIT Inactivo")]
    NitInactivo = 77,

    [Description("CUIS no esta vigente")]
    CuisNoEstaVigente = 78,

    [Description("CUIS no corresponde a la Sucursal/punto Venta")]
    CuisNoCorrespondeALaSucursalPuntoVenta = 79,

    [Description("Codigo Documento Sector invalido")]
    CodigoDocumentoSectorInvalido = 80,

    [Description("Codigo de Sector no corresponde al servicio")]
    CodigoDeSectorNoCorrespondeAlServicio = 81,

    [Description("Punto de venta invalido")]
    PuntoDeVentaInvalido = 82,

    [Description("Anulacion Fuera de Plazo")]
    AnulacionFueraDePlazo = 83,

    [Description("Archivo no corresponde a la huella")]
    ArchivoNoCorrespondeALaHuella = 84,

    [Description("Feha envío inválida")]
    FehaEnvioInvalida = 85,

    [Description("Factura Inexistente")]
    FacturaInexistente = 86,

    [Description("Factura ya esta Anulada")]
    FacturaYaEstaAnulada = 87,

    [Description("Error en parámetros enviados al servicio")]
    ErrorEnParametrosEnviadosAlServicio = 88,

    [Description("El Documento Fiscal no cumple con el formato del XSD especificado")]
    ElDocumentoFiscalNoCumpleConElFormatoDelXsdEspecificado = 89,

    [Description("Servicio solo habilitado para entorno de producción")]
    ServicioSoloHabilitadoParaEntornoDeProduccion = 90,

    [Description("Error de ejecución del servicio en validación a detalle del Documento Fiscal")]
    ErrorDeEjecucionDelServicioEnValidacionADetalleDelDocumentoFiscal = 91,

    [Description("Su catalogo ya se encuentra sincronizado")]
    SuCatalogoYaSeEncuentraSincronizado = 92,

    [Description("La Fecha y Hora ya se encuentra sincronizado")]
    LaFechaYHoraYaSeEncuentraSincronizado = 93,

    [Description("Factura no consignada correctamente")]
    FacturaNoConsignadaCorrectamente = 94,

    [Description("Nit sin asociación con tipo documento sector")]
    NitSinAsociacionConTipoDocumentoSector = 95,

    [Description("Código Método de Pago Inválido")]
    CodigoMetodoDePagoInvalido = 96,

    [Description("Factura no disponible para anulación")]
    FacturaNoDisponibleParaAnulacion = 97,

    [Description("Numero Documento de Identidad Invalido")]
    NumeroDocumentoDeIdentidadInvalido = 98,

    [Description("Nit Emisor Invalido")]
    NitEmisorInvalido = 99,

    [Description("Numero de Tarjeta Invalido")]
    NumeroDeTarjetaInvalido = 100,

    [Description("Monto Total en Moneda Invalido")]
    MontoTotalEnMonedaInvalido = 101,

    [Description("Código de Producto SIN Invalido")]
    CodigoDeProductoSinInvalido = 102,

    [Description("Producto no coincide con Codigo Nandina")]
    ProductoNoCoincideConCodigoNandina = 103,

    [Description("Sistema no asociado al contribuyente")]
    SistemaNoAsociadoAlContribuyente = 104,

    [Description("Codigo de Autorizacion de Sincronizacion no valido")]
    CodigoDeAutorizacionDeSincronizacionNoValido = 105,

    [Description("Campo Descripcion obligatorio")]
    CampoDescripcionObligatorio = 106,

    [Description("Codigo de Solicitud de nuevo valor de producto/servicio no valido")]
    CodigoDeSolicitudDeNuevoValorDeProductoServicioNoValido = 107,

    [Description("Solicitud de nuevo valor producto/servicio pendiente de respuesta")]
    SolicitudDeNuevoValorProductoServicioPendienteDeRespuesta = 108,

    [Description("Solicitud de nuevo valor producto/servicio rechazada")]
    SolicitudDeNuevoValorProductoServicioRechazada = 109,

    [Description("Actualizar en la sincronización siguiente habilitada")]
    ActualizarEnLaSincronizacionSiguienteHabilitada = 110,

    [Description("Asociar al código de producto/servicio que se indica")]
    AsociarAlCodigoDeProductoServicioQueSeIndica = 111,

    [Description("Codigo de Recepcion de Evento Significativo no Habilitado")]
    CodigoDeRecepcionDeEventoSignificativoNoHabilitado = 112,

    [Description("Formato de fecha incorrecta")]
    FormatoDeFechaIncorrecta = 113,

    [Description("Recepción Anulación Inexistente")]
    RecepcionAnulacionInexistente = 114,

    [Description("Estado de Recepción Anulación Incorrecta")]
    EstadoDeRecepcionAnulacionIncorrecta = 115,

    [Description("Código Único de Factura (CUF) Inexistente")]
    CodigoUnicoDeFacturaCufInexistente = 116,

    [Description("Codigo Tipo Punto Venta invalido")]
    CodigoTipoPuntoVentaInvalido = 117,

    [Description("Nombre Punto Venta vacio")]
    NombrePuntoVentaVacio = 118,

    [Description("Descripcion Punto Venta vacio")]
    DescripcionPuntoVentaVacio = 119,

    [Description("Codigo Evento invalido")]
    CodigoEventoInvalido = 120,

    [Description("Descripcion Evento vacio")]
    DescripcionEventoVacio = 121,

    [Description("Código Único de Factura (CUF) duplicado")]
    CodigoUnicoDeFacturaCufDuplicado = 122,

    [Description("Código Único de Facturación Diario (CUFD) fuera de tolerancia")]
    CodigoUnicoDeFacturacionDiarioCufdFueraDeTolerancia = 123,

    [Description("CI Invalido")]
    CiInvalido = 124,

    [Description("Unidad de Medida Invalido")]
    UnidadDeMedidaInvalido = 125,

    [Description("Cantidad de documentos por paquete excedido")]
    CantidadDeDocumentosPorPaqueteExcedido = 126,

    [Description("Envio fuera de horario")]
    EnvioFueraDeHorario = 127,

    [Description("NIT sin asociacion de actividades. ")]
    NitSinAsociacionDeActividades = 128,

    [Description("Registro de solicitud de proceso masivo inexistente")]
    RegistroDeSolicitudDeProcesoMasivoInexistente = 129,

    [Description("Cantidad de documentos fiscales superior al límite asignado")]
    CantidadDeDocumentosFiscalesSuperiorAlLimiteAsignado = 130,

    [Description("Código de Sistema Proveedor Invalido")]
    CodigoDeSistemaProveedorInvalido = 131,

    [Description("Registro de evento significativo inexistente")]
    RegistroDeEventoSignificativoInexistente = 132,

    [Description("Tiempo espera agotado Conexion a Base de Datos")]
    TiempoEsperaAgotadoConexionABaseDeDatos = 500,

    [Description("Recepción Pendiente")]
    RecepcionPendiente = 901,

    [Description("Recepción Rechazada")]
    RecepcionRechazada = 902,

    [Description("Recepción Procesada")]
    RecepcionProcesada = 903,

    [Description("Recepción Observada")]
    RecepcionObservada = 904,

    [Description("Anulación Confirmada")]
    AnulacionConfirmada = 905,

    [Description("Anulación Rechazada")]
    AnulacionRechazada = 906,

    [Description("Anulación Pendiente de Confirmación")]
    AnulacionPendienteDeConfirmacion = 907,

    [Description("Recepción Validada")]
    RecepcionValidada = 908,

    [Description("Anulada Procesado por PIN")]
    AnuladaProcesadoPorPin = 909,

    [Description("Ya existe una solicitud de Anulación")]
    YaExisteUnaSolicitudDeAnulacion = 910,

    [Description("Hash Invalido")]
    HashInvalido = 911,

    [Description("Gestion incorrecta")]
    GestionIncorrecta = 912,

    [Description("Fecha ingreso hospedaje incorrecto")]
    FechaIngresoHospedajeIncorrecto = 913,

    [Description("Documento medico incorrecto")]
    DocumentoMedicoIncorrecto = 914,

    [Description("NIT salon incorrecto")]
    NitSalonIncorrecto = 915,

    [Description("Fecha evento incorrecto")]
    FechaEventoIncorrecto = 916,

    [Description("Monto total puerto incorrecto")]
    MontoTotalPuertoIncorrecto = 917,

    [Description("Monto total fob frontera incorrecto")]
    MontoTotalFobFronteraIncorrecto = 918,

    [Description("Codigo nandina incorrecto")]
    CodigoNandinaIncorrecto = 919,

    [Description("Monto total devuelto incorrecto")]
    MontoTotalDevueltoIncorrecto = 920,

    [Description("Monto efectivo credito debito incorrecto")]
    MontoEfectivoCreditoDebitoIncorrecto = 921,

    [Description("Monto original incorrecto")]
    MontoOriginalIncorrecto = 922,

    [Description("Monto Iehd incorrecto")]
    MontoIehdIncorrecto = 923,

    [Description("Ingreso diferencia cambio incorrecto")]
    IngresoDiferenciaCambioIncorrecto = 924,

    [Description("Oficina Inexistente")]
    OficinaInexistente = 925,

}