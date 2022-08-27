# Library to consume SIAT services

This library contains clients and messages for https://pilotosiatservicios.impuestos.gob.bo.

```csharp
using Markind.Siat.Generated.FacturacionSincronizacion;

var dto = new solicitudSincronizacion
{
    codigoAmbiente = 2,
    codigoSistema = "<codigo sistema>",
    nit = 487090318,
    cuis = "<cuis>",
    codigoSucursal = 0,
    codigoPuntoVenta=null
};

var service = new ServicioFacturacionSincronizacionClient("<token>");
var resp = service.sincronizarFechaHora(dto);

Console.WriteLine($"Fecha y hora del SIAT {resp.fechaHora}");
```