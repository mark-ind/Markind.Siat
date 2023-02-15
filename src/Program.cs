// using Markind.Siat;
// using Markind.Siat.Utils;
// using Markind.Siat.Generated.FacturacionCodigos;
// using Markind.Siat.Generated.FacturacionSincronizacion;

// // var token = "<token from https://pilotosiat.impuestos.gob.bo/facturacionv2/secure/Token/GestorToken.xhtml>";
// var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJtYXJraW5kIiwiY29kaWdvU2lzdGVtYSI6IjcyNUM4MTEzRUU3MDhBNjI3Q0RCRUI3Iiwibml0IjoiSDRzSUFBQUFBQUFBQURPeE1EZXdOREEyTUxRQUFOZzA3cG9LQUFBQSIsImlkIjoxMTQ2ODE1LCJleHAiOjE3MDE5MDcyMDAsImlhdCI6MTY3MDM5MDMyNiwibml0RGVsZWdhZG8iOjQ4NzA5MDMwMTgsInN1YnNpc3RlbWEiOiJTRkUifQ.CHaq707iKfAiEo-S1WbAz2fJFheNUMINjV0WLBsGDlqG0Rzh59-xa61lseVkcuv3WPM5gddeoBerS2oPieCEIA";

// var msg = new OverridableMessage
// {
//     CodigoAmbiente = Ambiente.Pruebas,
//     CodigoSistema = "725C8113EE708A627CDBEB7",
//     Nit = 4870903018,
//     CodigoSucursal = 0,
//     CodigoModalidad = Modalidad.Electronica,
//     Cuis = "87231DA1"
// };

// // var codigos = new ServicioFacturacionCodigosClient(token);
// // codigos.DefaultMessage = msg;
// // Console.WriteLine(codigos.verificarComunicacion().ToJson());
// // Console.WriteLine(codigos.cuis().ToJson());
// // // ------------------------------------------
// // // Partially override the DefaultMessage
// // Console.WriteLine(codigos.cuis(new() { CodigoSucursal = 2 }).ToJson());
// // Console.WriteLine(codigos.cuis(new() { CodigoPuntoVenta = 1 }).ToJson());

// // // =======================================================================
// // var service = new ServicioFacturacionSincronizacionClient(token);
// // service.DefaultMessage = msg;
// // Console.WriteLine(service.verificarComunicacion().ToJson());
// // Console.WriteLine(service.sincronizarFechaHora(msg).ToJson());
// // Console.WriteLine(service.sincronizarActividades().listaActividades);

// // =======================================================================
// var s = new Siat(token, msg);
// // (await siat.Codigos.verificarComunicacionAsync()).Dump("verificarComunicacionAsync");
// // (await s.Sincronizacion.verificarComunicacionAsync()).Dump("verificarComunicacionAsync");

// s.Codigos.cuis().Dump("cuis");
// // s.Sincronizacion.sincronizarFechaHora().Dump("sincronizarFechaHora");
// // s.Sincronizacion.sincronizarActividades().Dump("sincronizarActividades");
// // s.Sincronizacion.sincronizarListaActividadesDocumentoSector().Dump("sincronizarListaActividadesDocumentoSector");
// //  s.Sincronizacion.sincronizarListaLeyendasFactura().Dump("sincronizarListaLeyendasFactura");
// // s.Sincronizacion.sincronizarListaMensajesServicios().Dump("sincronizarListaMensajesServicios");
// //  s.Sincronizacion.sincronizarListaProductosServicios().Dump("sincronizarListaProductosServicios");
// // s.Sincronizacion.sincronizarParametricaTipoMoneda().Dump();
// // s.Codigos.cufd().Dump("cufd 0");
// // s.Codigos.verificarNit(new (){ NitParaVerificacion = 4870903}).Dump("VALID?");

// // s.FacturacionCompraVenta.verificarComunicacion().Dump();

// // var cuis1 = s.Codigos.cuis(new (){CodigoSucursal = 1, Cuis = null});
// // cuis1.Dump("cuis 1");
// // s.Codigos.cufd(new (){CodigoSucursal = 1, Cuis =  cuis1.codigo}).Dump("cufd 1");

//  // s.Sincronizacion.sincronizarParametricaEventosSignificativos().Dump("sincronizarParametricaEventosSignificativos");
// // s.Codigos.cufdMasivo();
// s.FacturacionCompraVenta.recepcionFactura(new SolicitudRecepcionFacturaComputarizada(msg){});