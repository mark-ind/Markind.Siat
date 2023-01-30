namespace Markind.Siat.Generated;

public partial class FacturaElectronicaCompraVenta : IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera IFacturaCompraVenta.Cabecera { get => Cabecera; set => Cabecera = (FacturaElectronicaCompraVentaCabecera)value; }

    ICollection<IFacturaCompraVentaDetalle> IFacturaCompraVenta.Detalle => (ICollection<IFacturaCompraVentaDetalle>)Detalle;
}