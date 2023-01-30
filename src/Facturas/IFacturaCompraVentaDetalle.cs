namespace Markind.Siat.Generated;

public interface IFacturaCompraVentaDetalle
{
    string ActividadEconomica { get; set; }
    uint CodigoProductoSin { get; set; }
    string CodigoProducto { get; set; }
    string Descripcion { get; set; }
    decimal Cantidad { get; set; }
    byte UnidadMedida { get; set; }
    decimal PrecioUnitario { get; set; }
    decimal? MontoDescuento { get; set; }
    decimal SubTotal { get; set; }
    string NumeroSerie { get; set; }
    string NumeroImei { get; set; }
}
