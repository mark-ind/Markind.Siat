# Library to consume SIAT services

This library contains clients and messages for https://pilotosiatservicios.impuestos.gob.bo.

```csharp
using Markind.Siat;
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
service.DefaultSolicitudSincronizacion = dto;

Console.WriteLine(service.sincronizarFechaHora().fechaHora);
Console.WriteLine(service.sincronizarActividades().listaActividades);
// Or partially override the DefaultSolicitudSincronizacion
Console.WriteLine(service.sincronizarActividades(new(){ codigoSucursal = 2 }).listaActividades);
```