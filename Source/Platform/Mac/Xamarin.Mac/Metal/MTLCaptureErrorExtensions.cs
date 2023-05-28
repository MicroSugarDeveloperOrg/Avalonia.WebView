using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLCaptureErrorExtensions
{
	[Field("MTLCaptureErrorDomain", "Metal")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MTLCaptureError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Metal.Handle, "MTLCaptureErrorDomain");
		}
		return _domain;
	}
}
