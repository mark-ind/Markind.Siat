$services = 
"FacturacionSincronizacion",
"FacturacionOperaciones",
"FacturacionCodigos",
"ServicioFacturacionCompraVenta",
"ServicioFacturacionElectronica",
"ServicioFacturacionComputarizada"

foreach ($s in $services)
{
    dotnet-svcutil -u src/$s
}