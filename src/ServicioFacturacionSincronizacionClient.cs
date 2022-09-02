using System.ServiceModel;

namespace Markind.Siat.Generated.FacturacionSincronizacion;

// Sample code at https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
// [MergeMessage]
public partial class ServicioFacturacionSincronizacionClient
{
    public ServicioFacturacionSincronizacionClient(string token) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public ServicioFacturacionSincronizacionClient(string token, string url): base(GetDefaultBinding(), new EndpointAddress(url)) =>
        Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour(new (){{"apikey", $"TokenApi {token}"}} ));

    public solicitudSincronizacion? DefaultSolicitudSincronizacion { get; set; }

    public respuestaListaParametricas sincronizarParametricaMotivoAnulacion() => sincronizarParametricaMotivoAnulacion(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaMotivoAnulacionResponse> sincronizarParametricaMotivoAnulacionAsync() => sincronizarParametricaMotivoAnulacionAsync(DefaultSolicitudSincronizacion);
    public respuestaListaActividades sincronizarActividades() => sincronizarActividades(DefaultSolicitudSincronizacion);
    public Task<sincronizarActividadesResponse> sincronizarActividadesAsync() => sincronizarActividadesAsync(DefaultSolicitudSincronizacion);
    public respuestaFechaHora sincronizarFechaHora() => sincronizarFechaHora(DefaultSolicitudSincronizacion);
    public Task<sincronizarFechaHoraResponse> sincronizarFechaHoraAsync() => sincronizarFechaHoraAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricasLeyendas sincronizarListaLeyendasFactura() => sincronizarListaLeyendasFactura(DefaultSolicitudSincronizacion);
    public Task<sincronizarListaLeyendasFacturaResponse> sincronizarListaLeyendasFacturaAsync() => sincronizarListaLeyendasFacturaAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoHabitacion() => sincronizarParametricaTipoHabitacion(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoHabitacionResponse> sincronizarParametricaTipoHabitacionAsync() => sincronizarParametricaTipoHabitacionAsync(DefaultSolicitudSincronizacion);
    public respuestaListaActividadesDocumentoSector sincronizarListaActividadesDocumentoSector() => sincronizarListaActividadesDocumentoSector(DefaultSolicitudSincronizacion);
    public Task<sincronizarListaActividadesDocumentoSectorResponse> sincronizarListaActividadesDocumentoSectorAsync() => sincronizarListaActividadesDocumentoSectorAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoIdentidad() => sincronizarParametricaTipoDocumentoIdentidad(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoDocumentoIdentidadResponse> sincronizarParametricaTipoDocumentoIdentidadAsync() => sincronizarParametricaTipoDocumentoIdentidadAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaUnidadMedida() => sincronizarParametricaUnidadMedida(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaUnidadMedidaResponse> sincronizarParametricaUnidadMedidaAsync() => sincronizarParametricaUnidadMedidaAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoSector() => sincronizarParametricaTipoDocumentoSector(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoDocumentoSectorResponse> sincronizarParametricaTipoDocumentoSectorAsync() => sincronizarParametricaTipoDocumentoSectorAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTiposFactura() => sincronizarParametricaTiposFactura(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTiposFacturaResponse> sincronizarParametricaTiposFacturaAsync() => sincronizarParametricaTiposFacturaAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarListaMensajesServicios() => sincronizarListaMensajesServicios(DefaultSolicitudSincronizacion);
    public Task<sincronizarListaMensajesServiciosResponse> sincronizarListaMensajesServiciosAsync() => sincronizarListaMensajesServiciosAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoMetodoPago() => sincronizarParametricaTipoMetodoPago(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoMetodoPagoResponse> sincronizarParametricaTipoMetodoPagoAsync() => sincronizarParametricaTipoMetodoPagoAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaEventosSignificativos() => sincronizarParametricaEventosSignificativos(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaEventosSignificativosResponse> sincronizarParametricaEventosSignificativosAsync() => sincronizarParametricaEventosSignificativosAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoPuntoVenta() => sincronizarParametricaTipoPuntoVenta(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoPuntoVentaResponse> sincronizarParametricaTipoPuntoVentaAsync() => sincronizarParametricaTipoPuntoVentaAsync(DefaultSolicitudSincronizacion);
    public respuestaListaProductos sincronizarListaProductosServicios() => sincronizarListaProductosServicios(DefaultSolicitudSincronizacion);
    public Task<sincronizarListaProductosServiciosResponse> sincronizarListaProductosServiciosAsync() => sincronizarListaProductosServiciosAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoEmision() => sincronizarParametricaTipoEmision(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoEmisionResponse> sincronizarParametricaTipoEmisionAsync() => sincronizarParametricaTipoEmisionAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaPaisOrigen() => sincronizarParametricaPaisOrigen(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaPaisOrigenResponse> sincronizarParametricaPaisOrigenAsync() => sincronizarParametricaPaisOrigenAsync(DefaultSolicitudSincronizacion);
    public respuestaListaParametricas sincronizarParametricaTipoMoneda() => sincronizarParametricaTipoMoneda(DefaultSolicitudSincronizacion);
    public Task<sincronizarParametricaTipoMonedaResponse> sincronizarParametricaTipoMonedaAsync() => sincronizarParametricaTipoMonedaAsync(DefaultSolicitudSincronizacion);
}