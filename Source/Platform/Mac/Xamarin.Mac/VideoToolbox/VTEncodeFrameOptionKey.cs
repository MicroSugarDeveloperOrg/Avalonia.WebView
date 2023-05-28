using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTEncodeFrameOptionKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForceKeyFrame;

	[Field("kVTEncodeFrameOptionKey_ForceKeyFrame", "VideoToolbox")]
	public static NSString ForceKeyFrame
	{
		get
		{
			if (_ForceKeyFrame == null)
			{
				_ForceKeyFrame = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTEncodeFrameOptionKey_ForceKeyFrame");
			}
			return _ForceKeyFrame;
		}
	}
}
