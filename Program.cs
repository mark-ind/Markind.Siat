// using Markind.Siat;
// using Markind.Siat.Utils;
// using Markind.Siat.Generated.FacturacionCodigos;
// using Markind.Siat.Generated.FacturacionSincronizacion;

// var token = "<token from https://pilotosiat.impuestos.gob.bo/facturacionv2/secure/Token/GestorToken.xhtml>";



// var msg = new OverridableMessage
// {
//     CodigoAmbiente = CodigoAmbiente.Pruebas,
//     CodigoSistema = "9723427FF742E6B55CF9DEB7",
//     Nit = 4870903018,
//     CodigoSucursal = 0,
//     CodigoModalidad = CodigoModalidad.Electronica,
//     Cuis = "94C8FD334"
// };

// var codigos = new ServicioFacturacionCodigosClient(token);
// codigos.DefaultMessage = msg;
// Console.WriteLine(codigos.verificarComunicacion().ToJson());
// Console.WriteLine(codigos.cuis().ToJson());
// // ------------------------------------------
// // Partially override the DefaultMessage
// Console.WriteLine(codigos.cuis(new() { CodigoSucursal = 2 }).ToJson());
// Console.WriteLine(codigos.cuis(new() { CodigoPuntoVenta = 1 }).ToJson());

// // =======================================================================
// var service = new ServicioFacturacionSincronizacionClient(token);
// service.DefaultMessage = msg;
// Console.WriteLine(service.verificarComunicacion().ToJson());
// Console.WriteLine(service.sincronizarFechaHora(msg).ToJson());
// Console.WriteLine(service.sincronizarActividades().listaActividades);

// // =======================================================================
// var s = new Siat(token, msg);

// s.Sincronizacion.sincronizarFechaHora().Dump();
// s.Codigos.cuis().Dump();
// // s.Codigos.cufdMasivo();