// using Markind.Siat;
// using Markind.Siat.Utils;
// using Markind.Siat.Generated.FacturacionCodigos;
// using Markind.Siat.Generated.FacturacionSincronizacion;

// var dto = new solicitudSincronizacion
// {
//     codigoAmbiente = (int) CodigoAmbiente.Pruebas,
//     codigoSistema = "723427FF742E6B55CF9DEB7",
//     nit = 4870903018,
//     cuis = "4C8FD334",
//     codigoSucursal = 0,
//     codigoPuntoVenta= 1,
// };
// var dto2 = new solicitudCuis
// {
//     codigoAmbiente = (int) CodigoAmbiente.Pruebas,
//     codigoPuntoVenta= 1,
//     codigoSistema = "723427FF742E6B55CF9DEB7",
//     nit = 4870903018,
//     codigoSucursal = 0,
//     codigoModalidad = (int)CodigoModalidad.Electronica
// };

// var token = "<token>";
// var codigos = new ServicioFacturacionCodigosClient(token, "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionCodigos");
// Console.WriteLine(codigos.verificarComunicacion().ToJson());
// Console.WriteLine(codigos.cuis(dto2).ToJson());
// var service = new ServicioFacturacionSincronizacionClient(token, "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionSincronizacion");
// service.DefaultSolicitudSincronizacion = dto;

// Console.WriteLine(service.sincronizarFechaHora().fechaHora);
// Console.WriteLine(service.sincronizarActividades().listaActividades);
// // Or partially override the DefaultSolicitudSincronizacion
// Console.WriteLine(service.sincronizarActividades(new(){ codigoSucursal = 2 }).listaActividades);

// var resp = service.sincronizarFechaHora(dto);
// service.sincronizarListaLeyendasFactura();
// Console.WriteLine($"Fecha y hora del SIAT {resp.fechaHora}");

// service.sincronizarActividades(dto);
// service.sincronizarListaActividadesDocumentoSector(dto);

// var dtoCufd = new solicitudCufd()
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 4870903018,
//     cuis = "",
//     codigoSucursal = 0,
//     codigoPuntoVenta=null,
//     codigoModalidad = 00
// };

// var codigos = new ServicioFacturacionCodigosClient();

// codigos.cufd(dtoCufd);

// var dtoCufdMasivo = new solicitudCufdMasivo()
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 4870903018,
//     codigoModalidad = 00
// };
// codigos.cufdMasivo(dtoCufdMasivo);

// var dtoCuis = new solicitudCuis()
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 4870903018,
//     codigoModalidad = 0,
//     codigoPuntoVenta= 0,
//     codigoSucursal =0
// };
// codigos.cuis(dtoCuis);

// var msg = new MessageBase
// {
//     codigoAmbiente = (int) CodigoAmbiente.Produccion,
//     codigoSistema = "<codigo sistema>",
//     nit = 4870903018,
//     codigoSucursal = 0,
//     codigoPuntoVenta=null,
//     codigoModalidad = 00,
//     cuis = "<cuis>",
// };

// var s = new Siat("<token>", "https://pilotosiatservicios.impuestos.gob.bo", msg);

// s.Sincronizacion.sincronizarFechaHora();
// s.Codigos.cufdMasivo();
// s.Codigos.cuis();