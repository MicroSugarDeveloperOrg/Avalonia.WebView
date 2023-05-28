using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class AVCleanAperturePropertiesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HorizontalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VerticalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	[Field("AVVideoCleanApertureHeightKey", "AVFoundation")]
	public static NSString HeightKey
	{
		get
		{
			if (_HeightKey == null)
			{
				_HeightKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureHeightKey");
			}
			return _HeightKey;
		}
	}

	[Field("AVVideoCleanApertureHorizontalOffsetKey", "AVFoundation")]
	public static NSString HorizontalOffsetKey
	{
		get
		{
			if (_HorizontalOffsetKey == null)
			{
				_HorizontalOffsetKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureHorizontalOffsetKey");
			}
			return _HorizontalOffsetKey;
		}
	}

	[Field("AVVideoCleanApertureVerticalOffsetKey", "AVFoundation")]
	public static NSString VerticalOffsetKey
	{
		get
		{
			if (_VerticalOffsetKey == null)
			{
				_VerticalOffsetKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureVerticalOffsetKey");
			}
			return _VerticalOffsetKey;
		}
	}

	[Field("AVVideoCleanApertureWidthKey", "AVFoundation")]
	public static NSString WidthKey
	{
		get
		{
			if (_WidthKey == null)
			{
				_WidthKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureWidthKey");
			}
			return _WidthKey;
		}
	}
}
