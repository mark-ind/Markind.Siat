$services = 
"FacturacionCodigos",
"ServicioFacturacionElectronica",
"FacturacionOperaciones",
"FacturacionSincronizacion"

foreach ($s in $services)
{
    dotnet-svcutil -u src/$s
}