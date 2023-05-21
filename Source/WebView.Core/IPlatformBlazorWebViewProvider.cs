using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace WebViewCore;

public interface IPlatformBlazorWebViewProvider
{
    string Scheme { get; }

    IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath); 
}
