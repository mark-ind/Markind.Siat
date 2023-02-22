
using DotNetEnv;
using Markind.Siat.Generated;

namespace Markind.Siat.Tests;

public class _4_EmisionIndividual : BaseTests
{
    private static short NumeroFactura = 120;
    private readonly DateTime date;

    public int CodigoPuntoVenta { get; private set; } = 41;

    public _4_EmisionIndividual()
    {
        date = TimeZoneInfo.ConvertTime(DateTime.Now, (TimeZoneInfo?)TimeZoneInfo.FindSystemTimeZoneById("SA Western Standard Time"));
    }

    [OneTimeSetUp]
    public async Task SetupAsync()
    {
        return;
        siat.DefaultMessage.CodigoTipoPuntoVenta = PuntoVenta.VentanillaDeCobranza;
        siat.DefaultMessage.NombrePuntoVenta = "Punto X";
        siat.DefaultMessage.Descripcion = "Solo para pruebas";

        var res = await siat.Operaciones.registroPuntoVentaAsync();
        CodigoPuntoVenta = res.RespuestaRegistroPuntoVenta.codigoPuntoVenta;
        res.RespuestaRegistroPuntoVenta.mensajesList.Should().BeNullOrEmpty();
    }

    [OneTimeTearDown]
    public async Task TeardownAsync()
    {
        return;
        siat.DefaultMessage.CodigoPuntoVenta = (uint?)CodigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis((uint)CodigoPuntoVenta);
        await siat.Operaciones.cierrePuntoVentaAsync(new Message{ CodigoPuntoVenta = (uint)CodigoPuntoVenta });
    }

    [Repeat(125)]
    [TestCase(DocumentoSector.FacturaEstandar)]
    // [TestCase(DocumentoSector.FacturaSectoresEducativos)]
    // [TestCase(DocumentoSector.FacturaDeArtistasInternacionales)]
    // [TestCase(DocumentoSector.NotaFiscalDeArtistasNacionales)]
    // [TestCase(DocumentoSector.FacturaComercialDeLibreConsignaciónYpfb)]
    public async Task EmisionIndividual(DocumentoSector documentoSector)
    {
        var t0 = EmisionIndividual(0, documentoSector);
        //var t1 = EmisionIndividual((uint)CodigoPuntoVenta, documentoSector);

        Task.WaitAll(t0);
    }

    public async Task EmisionIndividual(uint codigoPuntoVenta, DocumentoSector documentoSector)
    {
        siat.DefaultMessage.CodigoPuntoVenta = codigoPuntoVenta;
        siat.DefaultMessage.Cuis = GetCachedCuis(codigoPuntoVenta);
        siat.DefaultMessage.Cufd = GetCachedCufd(codigoPuntoVenta);
        var recepcion = NewRecepcion<SolicitudRecepcionFacturaComputarizada>(siat.DefaultMessage.CodigoModalidad, documentoSector);
        siat.DefaultMessage.Cuf = Cuf.Generate(recepcion, date, NumeroFactura, GetCachedCodigoControl(codigoPuntoVenta));

        var fac = await NewFactura<FacturaComputarizadaCompraVenta, FacturaComputarizadaCompraVentaCabecera>(date, documentoSector);
        fac.Detalle.Add(await NewDetail<FacturaComputarizadaCompraVentaDetalle>());
        fac.Cabecera.MontoTotal = fac.Cabecera.MontoTotalSujetoIva = fac.Cabecera.MontoTotalMoneda = fac.Detalle.Sum(d => d.SubTotal);

        SetFileDate(recepcion, fac);
        var res = await siat.FacturacionCompraVenta.recepcionFacturaAsync(recepcion);
        res.RespuestaServicioFacturacion.mensajesList.Should().BeNullOrEmpty();

        NumeroFactura++;
    }

    private T NewRecepcion<T>(Modalidad modalidad, DocumentoSector documentoSector) where T : SolicitudRecepcion
    {
        var recepcion = Activator.CreateInstance(typeof(T), new object[] { siat.DefaultMessage }) as T;

        recepcion.CodigoEmision = TipoEmision.OnLine;
        recepcion.CodigoModalidad = modalidad;
        recepcion.Cufd = siat.DefaultMessage.Cufd;
        recepcion.TipoFacturaDocumento = TipoFactura.ConDerechoACreditoFiscal;
        recepcion.CodigoDocumentoSector = documentoSector;

        return recepcion;
    }

    public async Task<F> NewFactura<F, C>(DateTime date, DocumentoSector documentoSector)
    where F : IFacturaCompraVenta, new()
    where C : IFacturaCompraVentaCabecera, new()
    {
        var factura = new F();

        factura.Cabecera = new C
        {
            NitEmisor = (ulong)siat.DefaultMessage.Nit,
            RazonSocialEmisor = Env.GetString("RazonSocial"),
            Municipio = Env.GetString("Municipio"),
            Telefono = Env.GetString("Telefono"),
            NumeroFactura = (ulong)NumeroFactura,
            Cuf = siat.DefaultMessage.Cuf,
            Cufd = siat.DefaultMessage.Cufd,
            CodigoSucursal = 0,
            Direccion = Env.GetString("Direccion"),
            CodigoPuntoVenta = (ushort?)siat.DefaultMessage.CodigoPuntoVenta, //TODO
            FechaEmision = date,
            NombreRazonSocial = "Medrano",
            CodigoTipoDocumentoIdentidad = (byte)DocumentoIdentidad.CarnetDeIdentidad,
            NumeroDocumento = "4870903",
            Complemento = string.Empty,
            CodigoCliente = $"1",
            CodigoMetodoPago = (ushort)MetodoPago.Efectivo,
            NumeroTarjeta = 0,
            MontoTotal = 10,
            MontoTotalSujetoIva = 10, //TODO  ...
            MontoGiftCard = 0,
            DescuentoAdicional = 0,
            CodigoExcepcion = null,
            Cafc = null, //TODO
            CodigoMoneda = (byte)Moneda.Boliviano,
            TipoCambio = 1, //TODO should be configurable in Company
            MontoTotalMoneda = 10,// TODO calc
            Leyenda = await GetCachedRandomLeyendaAsync(),
            Usuario = "Vendedor 1",
            CodigoDocumentoSector = ((int)documentoSector).ToString(),
        };

        return factura;
    }

    private async Task<D> NewDetail<D>() where D : IFacturaCompraVentaDetalle, new()
    {
        var producto = await GetCachedRandomProductoAsync();
        return new D()
        {
            ActividadEconomica = producto.codigoActividad,
            CodigoProductoSin = (uint)producto.codigoProducto,
            CodigoProducto = $"{producto.codigoProducto}", // using same code just for testing
            Descripcion = producto.descripcionProducto.ToLower(), // using same just for testing
            Cantidad = 1,
            UnidadMedida = (byte)1, //Bobinas, just for testing
            PrecioUnitario = 10,
            MontoDescuento = 0,
            SubTotal = 10,
            NumeroSerie = null, // "TODO",
            NumeroImei = null, // "TODO",
        };
    }

    private void SetFileDate<T>(ISolicitudRecepcionFactura recepcion, T fac)
    {
        var file = new SiatFile<T>(fac);
        recepcion.Archivo = file.Bytes;
        recepcion.HashArchivo = file.Hash;
        recepcion.FechaEnvio = date.ToString("yyyy-MM-ddTHH:mm:ss.fff");
    }
}
