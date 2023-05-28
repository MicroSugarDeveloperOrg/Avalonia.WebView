using ObjCRuntime;

namespace OpenGL;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum CGLErrorCode : uint
{
	NoError = 0u,
	BadAttribute = 10000u,
	BadProperty = 10001u,
	BadPixelFormat = 10002u,
	BadRendererInfo = 10003u,
	BadContext = 10004u,
	BadDrawable = 10005u,
	BadDisplay = 10006u,
	BadState = 10007u,
	BadValue = 10008u,
	BadMatch = 10009u,
	BadEnumeration = 10010u,
	BadOffScreen = 10011u,
	BadFullScreen = 10012u,
	BadWindow = 10013u,
	BadAddress = 10014u,
	BadCodeModule = 10015u,
	BadAlloc = 10016u,
	BadConnection = 10017u
}
