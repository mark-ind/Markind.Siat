$services = 
"FacturacionCodigos",
"ServicioFacturacionElectronica",
"FacturacionOperaciones",
"FacturacionSincronizacion"

foreach ($s in $services)
{
    dotnet-svcutil "https://pilotosiatservicios.impuestos.gob.bo/v2/$($s)?wsdl" -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -wr -mc -d src/$s
}