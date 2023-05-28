using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class PHProjectType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Undefined;

	[Field("PHProjectTypeUndefined", "PhotosUI")]
	public static NSString Undefined
	{
		get
		{
			if (_Undefined == null)
			{
				_Undefined = Dlfcn.GetStringConstant(Libraries.PhotosUI.Handle, "PHProjectTypeUndefined");
			}
			return _Undefined;
		}
	}
}
