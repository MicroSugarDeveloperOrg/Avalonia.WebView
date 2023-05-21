using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Avalonia.WebView.iOS.Common;
internal class iOSAssetFileProvider : IFileProvider
{
    public iOSAssetFileProvider(string contentRootDir)
    {
        _contentRootDir = contentRootDir;
    }
    readonly string _contentRootDir;
    public IDirectoryContents GetDirectoryContents(string subpath)
    {
        throw new NotImplementedException();
    }

    public IFileInfo GetFileInfo(string subpath)
    {
        throw new NotImplementedException();
    }

    public IChangeToken Watch(string filter)
    {
        throw new NotImplementedException();
    }
}
