using Foundation;
using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLCounterSampleBufferErrorExtensions
{
	[Field("MTLCounterErrorDomain", "Metal")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MTLCounterSampleBufferError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Metal.Handle, "MTLCounterErrorDomain");
		}
		return _domain;
	}
}
