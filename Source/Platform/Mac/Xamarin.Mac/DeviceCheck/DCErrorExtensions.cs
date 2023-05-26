using Foundation;
using ObjCRuntime;

namespace DeviceCheck;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class DCErrorExtensions
{
	[Field("DCErrorDomain", "DeviceCheck")]
	private static NSString? _domain;

	public static NSString? GetDomain(this DCError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.DeviceCheck.Handle, "DCErrorDomain");
		}
		return _domain;
	}
}
