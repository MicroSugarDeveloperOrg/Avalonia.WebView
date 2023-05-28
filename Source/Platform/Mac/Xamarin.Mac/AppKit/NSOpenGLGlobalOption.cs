using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSOpenGLGlobalOption : uint
{
	FormatCacheSize = 501u,
	ClearFormatCache = 502u,
	RetainRenderers = 503u,
	UseBuildCache = 506u,
	[Deprecated(PlatformName.MacOSX, 10, 4, PlatformArchitecture.None, null)]
	ResetLibrary = 504u
}
