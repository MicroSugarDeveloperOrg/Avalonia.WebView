namespace AvaloniaBlazorWebView.Common;

internal class AvaloniaResourceFileProvider : IFileProvider
{
    public AvaloniaResourceFileProvider(Assembly assembly, string contentRootDir)
    {
        _assembly = assembly;
        _assemblyName = assembly.GetName().Name!;
        //_assetLoader = AvaloniaLocator.Current.GetRequiredService<IAssetLoader>();
        _contentRootDir = contentRootDir;
    }

    readonly Assembly _assembly;
    //readonly IAssetLoader _assetLoader;
    readonly string _contentRootDir;

    readonly string _assemblyName;
    readonly string _assetHeader = "avares";

    IDirectoryContents IFileProvider.GetDirectoryContents(string subpath) => new AvaloniaDirectoryContents(subpath);

    IFileInfo IFileProvider.GetFileInfo(string subpath) => new AvaloniaAssetFileInfo(_assembly, $"{_assetHeader}://{_assemblyName}/{_contentRootDir}/{subpath}");

    IChangeToken IFileProvider.Watch(string filter) => NullChangeToken.Singleton;

    /// <summary>
    /// 
    /// </summary>
    private sealed class AvaloniaDirectoryContents : IDirectoryContents
    {
        public AvaloniaDirectoryContents(string path)
        {

        }

        public bool Exists => true;

        public IEnumerator<IFileInfo> GetEnumerator() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    private sealed class AvaloniaAssetFileInfo : IFileInfo
    {
        public AvaloniaAssetFileInfo(Assembly? assembly, string filePath)
        {
            _assembly = assembly;
            //_assetLoader = assetLoader;
            _filePath = filePath;
            Name = Path.GetFileName(filePath);

            _lazyAssetExists = new Lazy<bool>(() =>
            {
                try
                {
                    return AssetLoader.Exists(new Uri(filePath)); 
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
                    using var stream = AssetLoader.Open(new Uri(filePath));
                    var buffer = ArrayPool<byte>.Shared.Rent(4096);
                    long length = 0;
                    while (length != (length += stream.Read(buffer)))
                    {
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

        //readonly IAssetLoader _assetLoader;
        readonly Assembly? _assembly;
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
