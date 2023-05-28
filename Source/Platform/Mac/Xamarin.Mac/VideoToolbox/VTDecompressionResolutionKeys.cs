using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTDecompressionResolutionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Height;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Width;

	[Field("kVTDecompressionResolutionKey_Height", "VideoToolbox")]
	public static NSString Height
	{
		get
		{
			if (_Height == null)
			{
				_Height = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionResolutionKey_Height");
			}
			return _Height;
		}
	}

	[Field("kVTDecompressionResolutionKey_Width", "VideoToolbox")]
	public static NSString Width
	{
		get
		{
			if (_Width == null)
			{
				_Width = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionResolutionKey_Width");
			}
			return _Width;
		}
	}
}
