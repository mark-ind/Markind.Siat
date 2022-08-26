using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Markind.Siat;

public class CustomAuthenticationBehaviour : IEndpointBehavior
{
    private readonly string authToken;

    public CustomAuthenticationBehaviour(string authToken)
    {
        this.authToken = authToken;
    }
    public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }

    public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
    {
        clientRuntime.ClientMessageInspectors.Add(new CustomMessageInspector(authToken));
    }

    public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher) { }

    public void Validate(ServiceEndpoint endpoint) { }
}

public class CustomMessageInspector : IClientMessageInspector
{
    private readonly string authToken;

    public CustomMessageInspector(string authToken)
    {
        this.authToken = authToken;
    }

    public object? BeforeSendRequest(ref Message request, IClientChannel channel)
    {
        var reqMsgProperty = new HttpRequestMessageProperty();
        reqMsgProperty.Headers.Add("Authorization", authToken);
        request.Properties[HttpRequestMessageProperty.Name] = reqMsgProperty;

        return null;
    }

    public void AfterReceiveReply(ref Message reply, object correlationState) { }
}