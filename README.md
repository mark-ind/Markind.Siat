# Library to consume SIAT services

This library contains clients and messages for https://pilotosiatservicios.impuestos.gob.bo.

```csharp
using Markind.Siat;

var service = new ServicioFacturacionSincronizacionClient("<token>");
service.sincronizarFechaHora(new(){.....});
```