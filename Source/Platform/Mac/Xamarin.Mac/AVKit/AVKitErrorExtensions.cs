using Foundation;
using ObjCRuntime;

namespace AVKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVKitErrorExtensions
{
	[Field("AVKitErrorDomain", "AVKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this AVKitError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.AVKit.Handle, "AVKitErrorDomain");
		}
		return _domain;
	}
}
