namespace CefGlue.Adapter.Browser;

public class CefAppAdapter : CefApp
{
    public CefAppAdapter(CefInitializeSettings settings, IAppScheme appScheme)
    {
        _settings = settings;
        _appScheme = appScheme;
    }

    readonly CefInitializeSettings _settings;
    readonly IAppScheme _appScheme;

    protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine)
    {
        if (!string.IsNullOrWhiteSpace(processType))
            return;

        if (!_settings.EnableGpu)
            commandLine.AppendSwitch("disable-gpu");

        if (!_settings.EnbaleGpuCompositing)
            commandLine.AppendSwitch("disable-gpu-compositing");

        if (_settings.EnableBeginFrameScheduling)
            commandLine.AppendSwitch("enable-begin-frame-scheduling");

        if (!_settings.EnableSmoothScrolling)
            commandLine.AppendSwitch("disable-smooth-scrolling");
    }

    protected override void OnRegisterCustomSchemes(CefSchemeRegistrar registrar)
    {
        //base.OnRegisterCustomSchemes(registrar);
    }
}
