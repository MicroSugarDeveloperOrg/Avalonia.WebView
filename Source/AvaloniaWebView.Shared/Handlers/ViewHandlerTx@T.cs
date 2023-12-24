namespace AvaloniaWebView.Shared.Handlers;
public abstract class ViewHandlerTx<TVirtualViewContext, TPlatformViewContext> : ViewHandlerTx where TVirtualViewContext : class where TPlatformViewContext : class
{

    public ViewHandlerTx(bool keepAlive)
    {
        HandleDescriptor = typeof(TPlatformViewContext).FullName;
        KeepAlive = keepAlive;
    }

#nullable disable

    public TPlatformViewContext PlatformViewContext { get => PlatformViewContextObject as TPlatformViewContext; protected set => PlatformViewContextObject = value; }
    public TVirtualViewContext VirtualViewContext { get => VisualViewContextObject as TVirtualViewContext; protected set => VisualViewContextObject = value; }

#nullable enable
}
