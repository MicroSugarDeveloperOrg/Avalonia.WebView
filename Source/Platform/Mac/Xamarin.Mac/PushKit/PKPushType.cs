using Foundation;
using ObjCRuntime;

namespace PushKit;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class PKPushType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileProvider;

	[Field("PKPushTypeFileProvider", "PushKit")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString FileProvider
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_FileProvider == null)
			{
				_FileProvider = Dlfcn.GetStringConstant(Libraries.PushKit.Handle, "PKPushTypeFileProvider");
			}
			return _FileProvider;
		}
	}
}
