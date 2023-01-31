using System.Collections.ObjectModel;

namespace Markind.Siat.Generated;

public interface IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera Cabecera { get; set; }

    Collection<IFacturaCompraVentaDetalle> Detalle { get; }
}
