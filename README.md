# Library to consume SIAT services

This library contains clients and messages for https://pilotosiatservicios.impuestos.gob.bo.

## Usage
```csharp
using Markind.Siat;
using Markind.Siat.Utils;
using Markind.Siat.Generated.FacturacionCodigos;

var dto = new solicitudCuis
{
    codigoAmbiente = (int) CodigoAmbiente.Pruebas,
    codigoPuntoVenta= 1,
    codigoSistema = "<codigo sistema>",
    nit = 4870903018,
    codigoSucursal = 0,
    codigoModalidad = (int) CodigoModalidad.Electronica
};

var token = "token from https://pilotosiat.impuestos.gob.bo/facturacionv2/secure/Token/GestorToken.xhtml";
var codigos = new ServicioFacturacionCodigosClient(token, "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionCodigos");
Console.WriteLine(codigos.verificarComunicacion().ToJson()));
Console.WriteLine(codigos.cuis(dto).ToJson()));
```

## Advanced usage
```csharp
using Markind.Siat;
using Markind.Siat.Utils;
using Markind.Siat.Generated.FacturacionSincronizacion;

var dto = new solicitudSincronizacion
{
    codigoAmbiente = (int) CodigoAmbiente.Produccion,
    codigoSistema = "<codigo sistema>",
    nit = 487090318,
    cuis = "<cuis>",
    codigoSucursal = 1,
    codigoPuntoVenta= null,
};

var service = new ServicioFacturacionSincronizacionClient("<token>", "https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionSincronizacion");
service.DefaultSolicitudSincronizacion = dto; // sets the default message.

Console.WriteLine(service.sincronizarFechaHora().fechaHora); // So you can execute requests without building the message, it wil take the DefaultSolicitudSincronizacion instead.
Console.WriteLine(service.sincronizarActividades().listaActividades.ToJson());
// Or partially override the DefaultSolicitudSincronizacion
Console.WriteLine(service.sincronizarActividades(new(){ codigoSucursal = 2 }).listaActividades.ToJson()); // It stills uses DefaultSolicitudSincronizacion but overrides codigoSucursal = 2  // is in it great? (:
```

## Available clients:
* ServicioFacturacionCodigosClient
* ServicioServicioFacturacionElectronicaClient
* ServicioServicioFacturacionComputarizadaClient
* ServicioFacturacionOperacionesClient
* ServicioFacturacionSincronizacionClient