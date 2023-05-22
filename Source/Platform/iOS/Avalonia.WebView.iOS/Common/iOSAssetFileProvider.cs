namespace Avalonia.WebView.iOS.Common;

internal class iOSAssetFileProvider : IFileProvider
{
    public iOSAssetFileProvider(string contentRootDir)
    {
        _contentRootDir = contentRootDir;
        _bundleRootDir = Path.Combine(NSBundle.MainBundle.ResourcePath, contentRootDir);
    }
    readonly string _contentRootDir;
    readonly string _bundleRootDir;

    public IDirectoryContents GetDirectoryContents(string subpath) => new iOSAssetDirectoryContents(Path.Combine(_bundleRootDir, subpath));

    public IFileInfo GetFileInfo(string subpath) => new iOSAssetFileInfo(Path.Combine(_bundleRootDir, subpath));


    public IChangeToken Watch(string filter)
        => NullChangeToken.Singleton;


    private sealed class iOSAssetDirectoryContents : IDirectoryContents
    {
        public iOSAssetDirectoryContents(string filePath)
        {
        }

        public bool Exists => false;

        public IEnumerator<IFileInfo> GetEnumerator()
            => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator()
            => throw new NotImplementedException();
    }

    private sealed class iOSAssetFileInfo : IFileInfo
    {
        public iOSAssetFileInfo(string filePath)
        {
            _filePath = filePath;

            Name = Path.GetFileName(_filePath);

            var fileInfo = new FileInfo(_filePath);
            Exists = fileInfo.Exists;
            Length = Exists ? fileInfo.Length : -1;
        }
        readonly string _filePath;

        public bool Exists { get; }
        public long Length { get; }
        public string PhysicalPath { get; } = null!;
        public string Name { get; }
        public DateTimeOffset LastModified { get; } = DateTimeOffset.FromUnixTimeSeconds(0);
        public bool IsDirectory => false;

        public Stream CreateReadStream()
            => File.OpenRead(_filePath);
    }

}
