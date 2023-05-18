using Avalonia;

namespace AvaloniaWebView.Shared.Handlers;
public abstract class ViewHandler
{
    //protected ViewHandler(IPropertyMapper mapper)
    //{
    //    _mapper = mapper;
    //}

    //protected readonly IPropertyMapper _mapper;

    public object? PlatformViewObject { get; private protected set; }
    public object? VisualView { get; private protected set; }
}
