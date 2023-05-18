using Avalonia;

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


public class ViewHandler<TVirtualView, TPlatformView> : ViewHandler 
{
    protected ViewHandler() 
    {

    }

    //public static Func<ViewHandler<TVirtualView, TPlatformView>, TPlatformView>? PlatformViewFactory { get; set; }

    public TPlatformView? PlatformView { get; private protected set; }
    public TVirtualView? VirtualView { get; private protected set; }
}