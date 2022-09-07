# Library to consume SIAT services

This library contains clients and messages for https://pilotosiatservicios.impuestos.gob.bo.

## Usage
```csharp
using Markind.Siat;
using Markind.Siat.Utils;
using Markind.Siat.Generated.FacturacionCodigos;
using Markind.Siat.Generated.FacturacionSincronizacion;

var token = "<token from https://pilotosiat.impuestos.gob.bo/facturacionv2/secure/Token/GestorToken.xhtml>";

var msg = new OverridableMessage
{
    CodigoAmbiente = CodigoAmbiente.Pruebas,
    CodigoSistema = "923427FF742E6B55CF9DEB9",
    Nit = 4870903018,
    CodigoSucursal = 0,
    CodigoModalidad = CodigoModalidad.Electronica,
    Cuis = "5C8FD336"
};

var codigos = new ServicioFacturacionCodigosClient(token);
codigos.DefaultMessage = msg;
Console.WriteLine(codigos.verificarComunicacion().ToJson());
Console.WriteLine(codigos.cuis().ToJson());
```

## Advanced usage
Partially override the *DefaultMessage*
```csharp
Console.WriteLine(codigos.cuis(new() { CodigoSucursal = 2 }).ToJson());
Console.WriteLine(codigos.cuis(new() { CodigoPuntoVenta = 1 }).ToJson());
```

## Available clients:
* ServicioFacturacionCodigosClient
* ServicioServicioFacturacionElectronicaClient
* ServicioServicioFacturacionComputarizadaClient (wip)
* ServicioFacturacionOperacionesClient
* ServicioFacturacionSincronizacionClient