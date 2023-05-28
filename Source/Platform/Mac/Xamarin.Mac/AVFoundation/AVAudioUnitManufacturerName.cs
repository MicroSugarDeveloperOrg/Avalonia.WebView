using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public static class AVAudioUnitManufacturerName
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Apple;

	[Field("AVAudioUnitManufacturerNameApple", "AVFoundation")]
	[Obsoleted(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Field will return 'null'.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString Apple
	{
		[Obsoleted(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Field will return 'null'.")]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Apple == null)
			{
				_Apple = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitManufacturerNameApple");
			}
			return _Apple;
		}
	}
}
