namespace Avalonia.WebView;

public class AvaloniaCefApp : CefApp
{
    protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine)
    {
    }

    protected override void OnRegisterCustomSchemes(CefSchemeRegistrar registrar)
    {
    }
}
