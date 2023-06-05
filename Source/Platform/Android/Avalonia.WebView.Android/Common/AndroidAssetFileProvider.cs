using Android.Content.Res;

namespace Avalonia.WebView.Android.Common;

internal class AndroidAssetFileProvider : IFileProvider
{
    public AndroidAssetFileProvider(Assembly? assembly, string contentRootDir)
    {
        var assets = AndroidApplication.Context.Assets;
        if (assets is null)
            throw new ArgumentNullException(nameof(assets));

        _assetManager = assets;
        _assembly = assembly;
        _contentRootDir = contentRootDir;

    }

    readonly AssetManager _assetManager;
    readonly Assembly? _assembly;
    readonly string _contentRootDir;

    public IDirectoryContents GetDirectoryContents(string subpath) => new AndroidAssetDirectoryContents();

    public IFileInfo GetFileInfo(string subpath) => new AndroidAssetFileInfo(_assetManager, Path.Combine(_contentRootDir, subpath));

    public IChangeToken Watch(string filter) => NullChangeToken.Singleton;


    private sealed class AndroidAssetDirectoryContents : IDirectoryContents
    {
        public bool Exists => false;

        public IEnumerator<IFileInfo> GetEnumerator() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }


    private sealed class AndroidAssetFileInfo : IFileInfo
    {
        public AndroidAssetFileInfo(AssetManager assetManager, string filePath)
        {
            _assetManager = assetManager;
            _filePath = filePath;
            Name = Path.GetFileName(filePath);

            _lazyAssetExists = new Lazy<bool>(() =>
            {
                try
                {
 
                    using var stream = _assetManager.Open(_filePath);
                    return true;
                }
                catch
                {
                    return false;
                }
            });


            _lazyAssetLength = new Lazy<long>(() =>
            {
                try
                {
                    // The stream returned by AssetManager.Open() is not seekable, so we have to read
                    // the contents to get its length. In practice, Length is never called by BlazorWebView,
                    // so it's here "just in case."
                    using var stream = _assetManager.Open(_filePath);
                    var buffer = ArrayPool<byte>.Shared.Rent(4096);
                    long length = 0;
                    while (length != (length += stream.Read(buffer)))
                    {
                        // just read the stream to get its length; we don't need the contents here
                    }
                    ArrayPool<byte>.Shared.Return(buffer);
                    return length;
                }
                catch
                {
                    return -1;
                }
            });
        }

        readonly AssetManager _assetManager;
        private readonly string _filePath;
        private readonly Lazy<bool> _lazyAssetExists;
        private readonly Lazy<long> _lazyAssetLength;

        public bool Exists => _lazyAssetExists.Value;
        public long Length => _lazyAssetLength.Value;
        public string? PhysicalPath => null!;
        public string Name { get; }
        public DateTimeOffset LastModified { get; } = DateTimeOffset.FromUnixTimeSeconds(0);
        public bool IsDirectory => false;

        public Stream CreateReadStream() => AssetLoader.Open(new Uri(_filePath));
    }

}
