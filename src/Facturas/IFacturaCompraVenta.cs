namespace Markind.Siat.Generated;

public interface IFacturaCompraVenta
{
    IFacturaCompraVentaCabecera Cabecera { get; set; }

    ICollection<IFacturaCompraVentaDetalle> Detalle { get; }
}
