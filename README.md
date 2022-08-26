# Library to consume SIAT services

Use the script `generate.ps1`.

Or if you prefer generate individually:

## FacturacionCodigos

```powershell
dotnet-svcutil https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionCodigos?wsdl -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d FacturacionCodigos
```
https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionCodigos?wsdl

## ServicioFacturacionElectronica

```powershell
dotnet-svcutil https://pilotosiatservicios.impuestos.gob.bo/v2/ServicioFacturacionElectronica?wsdl -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d ./ServicioFacturacionElectronica
```
https://pilotosiatservicios.impuestos.gob.bo/v2/ServicioFacturacionElectronica?wsdl

## FacturacionOperaciones

```powershell
dotnet-svcutil https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionOperaciones?wsdl -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d ./FacturacionOperaciones
```
https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionOperaciones?wsdl

## FacturacionSincronizacion

```powershell
dotnet-svcutil https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionSincronizacion?wsdl -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d ./FacturacionSincronizacion
```
https://pilotosiatservicios.impuestos.gob.bo/v2/FacturacionSincronizacion?wsdl

