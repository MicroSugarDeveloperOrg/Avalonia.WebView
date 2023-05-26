using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class NSUrlSessionTaskPriority
{
	[Field("NSURLSessionTaskPriorityDefault", "Foundation")]
	public static float Default => Dlfcn.GetFloat(Libraries.Foundation.Handle, "NSURLSessionTaskPriorityDefault");

	[Field("NSURLSessionTaskPriorityHigh", "Foundation")]
	public static float High => Dlfcn.GetFloat(Libraries.Foundation.Handle, "NSURLSessionTaskPriorityHigh");

	[Field("NSURLSessionTaskPriorityLow", "Foundation")]
	public static float Low => Dlfcn.GetFloat(Libraries.Foundation.Handle, "NSURLSessionTaskPriorityLow");
}
