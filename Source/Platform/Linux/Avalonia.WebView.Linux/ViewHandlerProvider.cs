using Avalonia.Controls.ApplicationLifetimes;
using Linux.WebView.Core;

namespace Avalonia.WebView.Linux;

internal class ViewHandlerProvider : IViewHandlerProvider
{
    public ViewHandlerProvider()
    {
        _linuxApplication = WebViewLocator.s_ResolverContext.GetRequiredService<ILinuxApplication>();
        var bRet = _linuxApplication.RunAsync(default, default).Result;
        if (!bRet)
            throw new ArgumentNullException(nameof(ILinuxApplication), "create gtk application failed!");

        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime deskTop)
            deskTop.ShutdownRequested += DeskTop_ShutdownRequested;
    }

    readonly ILinuxApplication _linuxApplication;

    IViewHandler IViewHandlerProvider.CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, IVirtualBlazorWebViewProvider? provider, Action<WebViewCreationProperties>? configDelegate)
    {
        var creatonProperty = new WebViewCreationProperties();
        configDelegate?.Invoke(creatonProperty);

        return new WebViewHandler(_linuxApplication, virtualView, virtualViewCallBack, provider, creatonProperty);
    }

    private void DeskTop_ShutdownRequested(object sender, ShutdownRequestedEventArgs e)
    {
        _linuxApplication.Dispose();
    }

}
