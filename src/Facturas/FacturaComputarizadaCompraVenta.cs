
using System.Collections.ObjectModel;

namespace Markind.Siat.Generated;

public partial class FacturaComputarizadaCompraVenta : IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera IFacturaCompraVenta.Cabecera { get => Cabecera; set => Cabecera = (FacturaComputarizadaCompraVentaCabecera)value; }

    Collection<IFacturaCompraVentaDetalle> IFacturaCompraVenta.Detalle => new (Detalle.Cast<IFacturaCompraVentaDetalle>().ToList());
}