namespace CefGlue.Adapter;

public class CefInitializeSettings
{
    public CefInitializeSettings()
    {
        var appDirectory = AppContext.BaseDirectory;
        string cefDirectory = Path.Combine(appDirectory, "cef");

        CefLibPath = Path.Combine(cefDirectory, "runtime");
        ResourcePath = Path.Combine(cefDirectory, "Resources");
        LocalesPath = Path.Combine(ResourcePath, "locales");
    }

    public string? CefLibPath { get; set; }
    public string BroswerSubProcessPath { get; set; } = string.Empty;
    public string ResourcePath { get; set; } = string.Empty;
    public string LocalesPath { get; set; } = string.Empty;
    public bool WindowlessRenderingEnabled { get; set; } = true;
    public bool MultiThreadedMessageLoop { get; set; } = true;
    public bool EnableGpu { get; set; } = false;
    public bool EnbaleGpuCompositing { get; set; } = false;
    public bool EnableBeginFrameScheduling { get; set; } = true;
    public bool EnableSmoothScrolling { get; set; } = false;

}
