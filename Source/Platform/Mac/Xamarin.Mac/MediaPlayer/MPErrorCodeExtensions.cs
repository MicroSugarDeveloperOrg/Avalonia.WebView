using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 14, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MPErrorCodeExtensions
{
	[Field("MPErrorDomain", "MediaPlayer")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MPErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPErrorDomain");
		}
		return _domain;
	}
}
