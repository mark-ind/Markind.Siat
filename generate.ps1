$services = 
# "FacturacionCodigos",
# "ServicioFacturacionElectronica",
"ServicioFacturacionComputarizada"
# "FacturacionOperaciones",
# "FacturacionSincronizacion"
# "ServicioAutenticacionSoap" Only works with v1

foreach ($s in $services)
{
    dotnet-svcutil "https://pilotosiatservicios.impuestos.gob.bo/v1/$($s)?wsdl" -n "*,Markind.Siat" -ct System.Collections.Generic.List``1 -ct System.Collections.Generic.Dictionary``2 --sync -d src/$s
}