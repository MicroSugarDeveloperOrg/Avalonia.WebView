namespace Avalonia.WebView.Browser;
internal class AvaloniaCefApp : CefApp
{
    protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine)
    {
        if (!string.IsNullOrWhiteSpace(processType))
            return;

        commandLine.AppendSwitch("disable-gpu");
        commandLine.AppendSwitch("disable-gpu-compositing");
        commandLine.AppendSwitch("enable-begin-frame-scheduling");
        commandLine.AppendSwitch("disable-smooth-scrolling");
    }

    protected override void OnRegisterCustomSchemes(CefSchemeRegistrar registrar)
    {
        base.OnRegisterCustomSchemes(registrar);
    }
}
