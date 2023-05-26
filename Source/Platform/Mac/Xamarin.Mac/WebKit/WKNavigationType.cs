using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum WKNavigationType : long
{
	LinkActivated = 0L,
	FormSubmitted = 1L,
	BackForward = 2L,
	Reload = 3L,
	FormResubmitted = 4L,
	Other = -1L
}
