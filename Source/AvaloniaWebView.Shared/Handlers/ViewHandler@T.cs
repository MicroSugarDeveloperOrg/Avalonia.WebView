namespace AvaloniaWebView.Shared.Handlers;

//public class ViewHandler<TVirtualView, TPlatformView>: ViewHandler where TVirtualView : Visual
//{
//    protected ViewHandler(IPropertyMapper<TVirtualView, TPlatformView> mapper) : base(mapper)
//    {

//    }

//    //public static Func<ViewHandler<TVirtualView, TPlatformView>, TPlatformView>? PlatformViewFactory { get; set; }

//    public TPlatformView? PlatformView { get; private protected set; }
//    public TVirtualView? VirtualView { get; private protected set; }
//}


public abstract class ViewHandler<TVirtualViewContext, TPlatformViewContext> : ViewHandler where TVirtualViewContext:class where TPlatformViewContext : class
{
    public ViewHandler(bool keepAlive)
    {
        HandleDescriptor = typeof(TPlatformViewContext).FullName;
        KeepAlive = keepAlive;
    }
 
#nullable disable

    public TPlatformViewContext PlatformViewContext { get => PlatformViewContextObject as TPlatformViewContext;  protected set => PlatformViewContextObject = value; }
    public TVirtualViewContext VirtualViewContext { get => VisualViewContextObject as TVirtualViewContext; protected set=> VisualViewContextObject = value; }

#nullable enable
}