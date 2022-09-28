$services = 
"FacturacionSincronizacion",
"FacturacionOperaciones",
"FacturacionCodigos",
"ServicioFacturacionCompraVenta",
"ServicioFacturacionElectronica",
"ServicioFacturacionComputarizada"
# "ServicioAutenticacionSoap" Only works with v1

foreach ($s in $services)
{
    dotnet-svcutil "https://pilotosiatservicios.impuestos.gob.bo/v2/$($s)?wsdl" -n "*,Markind.Siat.Generated.$($s)" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d src/$s
}