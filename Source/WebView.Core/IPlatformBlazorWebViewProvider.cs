using Microsoft.Extensions.FileProviders;

namespace WebViewCore;

public interface IPlatformBlazorWebViewProvider
{
    string Scheme { get; }

    IFileProvider CreateFileProvider(string contentRootDirFullPath); 
}
