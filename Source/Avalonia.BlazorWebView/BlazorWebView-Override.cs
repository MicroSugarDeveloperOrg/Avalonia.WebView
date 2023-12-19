using Avalonia.LogicalTree;

namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    protected override async void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);

        if (_platformWebView is null)
        {
            await CreateWebViewManager();

            if (_webviewManager is null)
                return;

            _webviewManager.Navigate(_startAddress);
        }   
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        bool keepAlive = KeepAlive is null ? _creationProperties.KeepAlive : KeepAlive.Value;
        if (!keepAlive)
        {
            Child = null;
            _platformWebView?.Dispose();
            _platformWebView = null;
        }
    }

    protected override void OnDetachedFromLogicalTree(LogicalTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromLogicalTree(e);
        if (_attachControl is IDisposable disposable)
            disposable.Dispose();

        Child = null;
        _attachControl = null;
        _platformWebView?.Dispose();
        _platformWebView = null;
    }
}
