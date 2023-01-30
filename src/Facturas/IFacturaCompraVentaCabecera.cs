namespace Markind.Siat.Generated;

using System;

public interface IFacturaCompraVentaCabecera
{
    ulong NitEmisor { get; set; }
    string RazonSocialEmisor { get; set; }
    string Municipio { get; set; }
    string Telefono { get; set; }
    ulong NumeroFactura { get; set; }
    string Cuf { get; set; }
    string Cufd { get; set; }
    ushort CodigoSucursal { get; set; }
    string Direccion { get; set; }
    ushort? CodigoPuntoVenta { get; set; }
    DateTime FechaEmision { get; set; }
    string NombreRazonSocial { get; set; }
    byte CodigoTipoDocumentoIdentidad { get; set; }
    string NumeroDocumento { get; set; }
    string Complemento { get; set; }
    string CodigoCliente { get; set; }
    ushort CodigoMetodoPago { get; set; }
    ulong? NumeroTarjeta { get; set; }
    decimal MontoTotal { get; set; }
    decimal MontoTotalSujetoIva { get; set; }
    byte CodigoMoneda { get; set; }
    decimal TipoCambio { get; set; }
    decimal MontoTotalMoneda { get; set; }
    decimal? MontoGiftCard { get; set; }
    decimal? DescuentoAdicional { get; set; }
    byte? CodigoExcepcion { get; set; }
    string Cafc { get; set; }
    string Leyenda { get; set; }
    string Usuario { get; set; }
    string CodigoDocumentoSector { get; set; }
}
