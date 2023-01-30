
namespace Markind.Siat.Generated;

public partial class FacturaComputarizadaCompraVenta : IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera IFacturaCompraVenta.Cabecera { get => Cabecera; set => Cabecera = (FacturaComputarizadaCompraVentaCabecera)value; }

    ICollection<IFacturaCompraVentaDetalle> IFacturaCompraVenta.Detalle => (ICollection<IFacturaCompraVentaDetalle>)Detalle;
}