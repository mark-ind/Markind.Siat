$files = Get-ChildItem res/facturas

$args = @()
foreach ($file in $files)
{
    $args += "res/facturas/$($file.Name)";
}

& xscgen -o src/Facturas --nc --nu --cn -n =Markind.Siat.Generated $args