using Metal;

namespace MetalPerformanceShaders;

[TV(11, 3)]
[iOS(11, 3)]
[Mac(10, 13, 4)]
public struct MPSStateTextureInfo
{
    public nuint Width;

    public nuint Height;

    public nuint Depth;

    public nuint ArrayLength;

    private nuint _PixelFormat;

    private nuint _TextureType;

    private nuint _TextureUsage;

    private nuint Reserved0;

    private nuint Reserved1;

    private nuint Reserved2;

    private nuint Reserved3;

    public MTLPixelFormat PixelFormat
    {
        get
        {
            return (MTLPixelFormat)(ulong)_PixelFormat;
        }
        set
        {
            _PixelFormat = (nuint)(ulong)value;
        }
    }

    public MTLTextureType TextureType
    {
        get
        {
            return (MTLTextureType)(ulong)_TextureType;
        }
        set
        {
            _TextureType = (nuint)(ulong)value;
        }
    }

    public MTLTextureUsage TextureUsage
    {
        get
        {
            return (MTLTextureUsage)(ulong)_TextureUsage;
        }
        set
        {
            _TextureUsage = (nuint)(ulong)value;
        }
    }
}