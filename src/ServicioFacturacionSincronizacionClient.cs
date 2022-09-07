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

    public OverridableMessage DefaultMessage { get; set; } = new();

    public respuestaListaParametricas sincronizarParametricaMotivoAnulacion() => sincronizarParametricaMotivoAnulacion(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaMotivoAnulacion(Message msg) => sincronizarParametricaMotivoAnulacion(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaMotivoAnulacionResponse> sincronizarParametricaMotivoAnulacionAsync() => sincronizarParametricaMotivoAnulacionAsync(DefaultMessage);
    public Task<sincronizarParametricaMotivoAnulacionResponse> sincronizarParametricaMotivoAnulacionAsync(Message msg) => sincronizarParametricaMotivoAnulacionAsync(DefaultMessage.Merge(msg));
    public respuestaListaActividades sincronizarActividades() => sincronizarActividades(DefaultMessage);
    public respuestaListaActividades sincronizarActividades(Message msg) => sincronizarActividades(DefaultMessage.Merge(msg));
    public Task<sincronizarActividadesResponse> sincronizarActividadesAsync() => sincronizarActividadesAsync(DefaultMessage);
    public Task<sincronizarActividadesResponse> sincronizarActividadesAsync(Message msg) => sincronizarActividadesAsync(DefaultMessage.Merge(msg));
    public respuestaFechaHora sincronizarFechaHora() => sincronizarFechaHora(DefaultMessage);
    public respuestaFechaHora sincronizarFechaHora(Message msg) => sincronizarFechaHora(DefaultMessage.Merge(msg));
    public Task<sincronizarFechaHoraResponse> sincronizarFechaHoraAsync() => sincronizarFechaHoraAsync(DefaultMessage);
    public Task<sincronizarFechaHoraResponse> sincronizarFechaHoraAsync(Message msg) => sincronizarFechaHoraAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricasLeyendas sincronizarListaLeyendasFactura() => sincronizarListaLeyendasFactura(DefaultMessage);
    public respuestaListaParametricasLeyendas sincronizarListaLeyendasFactura(Message msg) => sincronizarListaLeyendasFactura(DefaultMessage.Merge(msg));
    public Task<sincronizarListaLeyendasFacturaResponse> sincronizarListaLeyendasFacturaAsync() => sincronizarListaLeyendasFacturaAsync(DefaultMessage);
    public Task<sincronizarListaLeyendasFacturaResponse> sincronizarListaLeyendasFacturaAsync(Message msg) => sincronizarListaLeyendasFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoHabitacion() => sincronizarParametricaTipoHabitacion(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoHabitacion(Message msg) => sincronizarParametricaTipoHabitacion(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoHabitacionResponse> sincronizarParametricaTipoHabitacionAsync() => sincronizarParametricaTipoHabitacionAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoHabitacionResponse> sincronizarParametricaTipoHabitacionAsync(Message msg) => sincronizarParametricaTipoHabitacionAsync(DefaultMessage.Merge(msg));
    public respuestaListaActividadesDocumentoSector sincronizarListaActividadesDocumentoSector() => sincronizarListaActividadesDocumentoSector(DefaultMessage);
    public respuestaListaActividadesDocumentoSector sincronizarListaActividadesDocumentoSector(Message msg) => sincronizarListaActividadesDocumentoSector(DefaultMessage.Merge(msg));
    public Task<sincronizarListaActividadesDocumentoSectorResponse> sincronizarListaActividadesDocumentoSectorAsync() => sincronizarListaActividadesDocumentoSectorAsync(DefaultMessage);
    public Task<sincronizarListaActividadesDocumentoSectorResponse> sincronizarListaActividadesDocumentoSectorAsync(Message msg) => sincronizarListaActividadesDocumentoSectorAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoIdentidad() => sincronizarParametricaTipoDocumentoIdentidad(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoIdentidad(Message msg) => sincronizarParametricaTipoDocumentoIdentidad(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoDocumentoIdentidadResponse> sincronizarParametricaTipoDocumentoIdentidadAsync() => sincronizarParametricaTipoDocumentoIdentidadAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoDocumentoIdentidadResponse> sincronizarParametricaTipoDocumentoIdentidadAsync(Message msg) => sincronizarParametricaTipoDocumentoIdentidadAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaUnidadMedida() => sincronizarParametricaUnidadMedida(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaUnidadMedida(Message msg) => sincronizarParametricaUnidadMedida(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaUnidadMedidaResponse> sincronizarParametricaUnidadMedidaAsync() => sincronizarParametricaUnidadMedidaAsync(DefaultMessage);
    public Task<sincronizarParametricaUnidadMedidaResponse> sincronizarParametricaUnidadMedidaAsync(Message msg) => sincronizarParametricaUnidadMedidaAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoSector() => sincronizarParametricaTipoDocumentoSector(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoDocumentoSector(Message msg) => sincronizarParametricaTipoDocumentoSector(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoDocumentoSectorResponse> sincronizarParametricaTipoDocumentoSectorAsync() => sincronizarParametricaTipoDocumentoSectorAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoDocumentoSectorResponse> sincronizarParametricaTipoDocumentoSectorAsync(Message msg) => sincronizarParametricaTipoDocumentoSectorAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTiposFactura() => sincronizarParametricaTiposFactura(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTiposFactura(Message msg) => sincronizarParametricaTiposFactura(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTiposFacturaResponse> sincronizarParametricaTiposFacturaAsync() => sincronizarParametricaTiposFacturaAsync(DefaultMessage);
    public Task<sincronizarParametricaTiposFacturaResponse> sincronizarParametricaTiposFacturaAsync(Message msg) => sincronizarParametricaTiposFacturaAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarListaMensajesServicios() => sincronizarListaMensajesServicios(DefaultMessage);
    public respuestaListaParametricas sincronizarListaMensajesServicios(Message msg) => sincronizarListaMensajesServicios(DefaultMessage.Merge(msg));
    public Task<sincronizarListaMensajesServiciosResponse> sincronizarListaMensajesServiciosAsync() => sincronizarListaMensajesServiciosAsync(DefaultMessage);
    public Task<sincronizarListaMensajesServiciosResponse> sincronizarListaMensajesServiciosAsync(Message msg) => sincronizarListaMensajesServiciosAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoMetodoPago() => sincronizarParametricaTipoMetodoPago(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoMetodoPago(Message msg) => sincronizarParametricaTipoMetodoPago(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoMetodoPagoResponse> sincronizarParametricaTipoMetodoPagoAsync() => sincronizarParametricaTipoMetodoPagoAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoMetodoPagoResponse> sincronizarParametricaTipoMetodoPagoAsync(Message msg) => sincronizarParametricaTipoMetodoPagoAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaEventosSignificativos() => sincronizarParametricaEventosSignificativos(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaEventosSignificativos(Message msg) => sincronizarParametricaEventosSignificativos(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaEventosSignificativosResponse> sincronizarParametricaEventosSignificativosAsync() => sincronizarParametricaEventosSignificativosAsync(DefaultMessage);
    public Task<sincronizarParametricaEventosSignificativosResponse> sincronizarParametricaEventosSignificativosAsync(Message msg) => sincronizarParametricaEventosSignificativosAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoPuntoVenta() => sincronizarParametricaTipoPuntoVenta(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoPuntoVenta(Message msg) => sincronizarParametricaTipoPuntoVenta(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoPuntoVentaResponse> sincronizarParametricaTipoPuntoVentaAsync() => sincronizarParametricaTipoPuntoVentaAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoPuntoVentaResponse> sincronizarParametricaTipoPuntoVentaAsync(Message msg) => sincronizarParametricaTipoPuntoVentaAsync(DefaultMessage.Merge(msg));
    public respuestaListaProductos sincronizarListaProductosServicios() => sincronizarListaProductosServicios(DefaultMessage);
    public respuestaListaProductos sincronizarListaProductosServicios(Message msg) => sincronizarListaProductosServicios(DefaultMessage.Merge(msg));
    public Task<sincronizarListaProductosServiciosResponse> sincronizarListaProductosServiciosAsync() => sincronizarListaProductosServiciosAsync(DefaultMessage);
    public Task<sincronizarListaProductosServiciosResponse> sincronizarListaProductosServiciosAsync(Message msg) => sincronizarListaProductosServiciosAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoEmision() => sincronizarParametricaTipoEmision(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoEmision(Message msg) => sincronizarParametricaTipoEmision(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoEmisionResponse> sincronizarParametricaTipoEmisionAsync() => sincronizarParametricaTipoEmisionAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoEmisionResponse> sincronizarParametricaTipoEmisionAsync(Message msg) => sincronizarParametricaTipoEmisionAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaPaisOrigen() => sincronizarParametricaPaisOrigen(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaPaisOrigen(Message msg) => sincronizarParametricaPaisOrigen(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaPaisOrigenResponse> sincronizarParametricaPaisOrigenAsync() => sincronizarParametricaPaisOrigenAsync(DefaultMessage);
    public Task<sincronizarParametricaPaisOrigenResponse> sincronizarParametricaPaisOrigenAsync(Message msg) => sincronizarParametricaPaisOrigenAsync(DefaultMessage.Merge(msg));
    public respuestaListaParametricas sincronizarParametricaTipoMoneda() => sincronizarParametricaTipoMoneda(DefaultMessage);
    public respuestaListaParametricas sincronizarParametricaTipoMoneda(Message msg) => sincronizarParametricaTipoMoneda(DefaultMessage.Merge(msg));
    public Task<sincronizarParametricaTipoMonedaResponse> sincronizarParametricaTipoMonedaAsync() => sincronizarParametricaTipoMonedaAsync(DefaultMessage);
    public Task<sincronizarParametricaTipoMonedaResponse> sincronizarParametricaTipoMonedaAsync(Message msg) => sincronizarParametricaTipoMonedaAsync(DefaultMessage.Merge(msg));
}