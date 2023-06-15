namespace AvaloniaBlazorWebView.Configurations;
public class BlazorWebViewSetting
{
    public string WWWRoot { get; set; } = "wwwroot";
    public string AppAddress { get; set; } = "localhost";
    public string StartAddress { get; set; } = "/";

    public Type? ComponentType { get; set; }
    public string? Selector { get; set; }

    /// <summary>
    /// 支持使用资源加载
    /// </summary>
    //public bool IsAvaloniaResource { get; set; }
    public Assembly? ResourceAssembly { get; set; }

}
