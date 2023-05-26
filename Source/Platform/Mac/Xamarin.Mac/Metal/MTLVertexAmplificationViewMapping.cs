using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
public struct MTLVertexAmplificationViewMapping
{
    public uint ViewportArrayIndexOffset;

    public uint RenderTargetArrayIndexOffset;
}
