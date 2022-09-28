$files = Get-ChildItem res/
foreach ($xsdFileName in $files)
{
    $name = $xsdFileName.ToString().Replace("factura", "").Replace(".xsd", "");
    echo $xsdFileName.ToString()
    echo $name
    xscgen -o src/Facturas --nc --nu -n "|$($xsdFileName)=Markind.Siat.Generated.Facturas.$($name)" res/$($xsdFileName)
}