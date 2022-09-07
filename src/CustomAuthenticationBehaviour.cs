using System.Collections.Specialized;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Markind.Siat;

public class CustomAuthenticationBehaviour : IEndpointBehavior
{
    private readonly NameValueCollection headers;

    public CustomAuthenticationBehaviour(NameValueCollection headers)
    {
        this.headers = headers;
    }
    public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }

    public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
    {
        clientRuntime.ClientMessageInspectors.Add(new CustomMessageInspector(headers));
    }

    public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher) { }

    public void Validate(ServiceEndpoint endpoint) { }
}

public class CustomMessageInspector : IClientMessageInspector
{
    private readonly NameValueCollection headers;

    public CustomMessageInspector(NameValueCollection headers)
    {
        this.headers = headers;
    }

    public object? BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
    {
        var reqMsgProperty = new HttpRequestMessageProperty();
        // https://siatanexo.impuestos.gob.bo/index.php/implementacion-servicios-facturacion/autenticacion/token-de-autenticacion
        // reqMsgProperty.Headers.Add("Authorization", authToken); // seems for v1
        // https://siatinfo.impuestos.gob.bo/index.php/facturacion-en-linea/emision-y-envio-de-facturas/solicitud-token
        // reqMsgProperty.Headers.Add("apikey", "TokenApi " + authToken);
        reqMsgProperty.Headers.Add(headers);
        request.Properties[HttpRequestMessageProperty.Name] = reqMsgProperty;

        return null;
    }

    public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState) { }
}