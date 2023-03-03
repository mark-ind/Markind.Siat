using System.Collections.ObjectModel;
namespace Markind.Siat.Generated;

public partial class FacturaElectronicaCompraVenta : IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera IFacturaCompraVenta.Cabecera { get => Cabecera; set => Cabecera = (FacturaElectronicaCompraVentaCabecera)value; }

    Collection<IFacturaCompraVentaDetalle> IFacturaCompraVenta.Detalle => new (Detalle.Cast<IFacturaCompraVentaDetalle>().ToList());
}