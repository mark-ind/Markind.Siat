$services = 
"FacturacionCodigos",
"ServicioFacturacionElectronica",
"ServicioFacturacionComputarizada",
"FacturacionOperaciones",
"FacturacionSincronizacion"

foreach ($s in $services)
{
    dotnet-svcutil -u src/$s
}