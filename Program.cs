// using Markind.Siat;
// using Markind.Siat.Generated.FacturacionSincronizacion;

// var dto = new solicitudSincronizacion
// {
//     codigoAmbiente = (int) CodigoAmbiente.Produccion,
//     codigoSistema = "<codigo sistema>",
//     nit = 487090318,
//     cuis = "<cuis>",
//     codigoSucursal = 1,
//     codigoPuntoVenta= null,
// };

// var service = new ServicioFacturacionSincronizacionClient("<token>", "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionSincronizacion");
// service.DefaultSolicitudSincronizacion = dto;

// Console.WriteLine(service.sincronizarFechaHora().fechaHora);
// Console.WriteLine(service.sincronizarActividades().listaActividades);
// // Or partially override the DefaultSolicitudSincronizacion
// Console.WriteLine(service.sincronizarActividades(new(){ codigoSucursal = 2 }).listaActividades);

// var resp = service.sincronizarFechaHora(dto);
// service.sincronizarListaLeyendasFactura()
// Console.WriteLine($"Fecha y hora del SIAT {resp.fechaHora}");

// service.sincronizarActividades(dto);
// service.sincronizarListaActividadesDocumentoSector(dto);

// var dtoCufd = new solicitudCufd
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 487090318,
//     cuis = "",
//     codigoSucursal = 0,
//     codigoPuntoVenta=null,
//     codigoModalidad = 00
// };

// var codigos = new ServicioFacturacionCodigosClient();

// codigos.cufd(dtoCufd);

// var dtoCufdMasivo = new solicitudCufdMasivo
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 487090318,
//     codigoModalidad = 00
// };
// codigos.cufdMasivo(dtoCufdMasivo);

// var dtoCuis = new solicitudCuis
// {
//     codigoAmbiente = 1,
//     codigoSistema = "",
//     nit = 487090318,
//     codigoModalidad = 0,
//     codigoPuntoVenta= 0,
//     codigoSucursal =0
// };
// codigos.cuis(dtoCuis);
