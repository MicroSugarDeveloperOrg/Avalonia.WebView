using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MKErrorCodeExtensions
{
	[Field("MKErrorDomain", "MapKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MKErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKErrorDomain");
		}
		return _domain;
	}
}
