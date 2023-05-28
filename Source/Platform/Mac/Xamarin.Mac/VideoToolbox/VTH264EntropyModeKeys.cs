using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTH264EntropyModeKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CABAC;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CAVLC;

	[Field("kVTH264EntropyMode_CABAC", "VideoToolbox")]
	public static NSString CABAC
	{
		get
		{
			if (_CABAC == null)
			{
				_CABAC = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTH264EntropyMode_CABAC");
			}
			return _CABAC;
		}
	}

	[Field("kVTH264EntropyMode_CAVLC", "VideoToolbox")]
	public static NSString CAVLC
	{
		get
		{
			if (_CAVLC == null)
			{
				_CAVLC = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTH264EntropyMode_CAVLC");
			}
			return _CAVLC;
		}
	}
}
