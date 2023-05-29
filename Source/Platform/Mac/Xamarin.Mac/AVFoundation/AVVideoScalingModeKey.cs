using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVVideoScalingModeKey
{
	private static NSString _Fit;

	private static NSString _Resize;

	private static NSString _ResizeAspect;

	private static NSString _ResizeAspectFill;

	[Field("AVVideoScalingModeFit", "AVFoundation")]
	public static NSString Fit
	{
		get
		{
			if (_Fit == null)
			{
				_Fit = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeFit");
			}
			return _Fit;
		}
	}

	[Field("AVVideoScalingModeResize", "AVFoundation")]
	public static NSString Resize
	{
		get
		{
			if (_Resize == null)
			{
				_Resize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeResize");
			}
			return _Resize;
		}
	}

	[Field("AVVideoScalingModeResizeAspect", "AVFoundation")]
	public static NSString ResizeAspect
	{
		get
		{
			if (_ResizeAspect == null)
			{
				_ResizeAspect = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeResizeAspect");
			}
			return _ResizeAspect;
		}
	}

	[Field("AVVideoScalingModeResizeAspectFill", "AVFoundation")]
	public static NSString ResizeAspectFill
	{
		get
		{
			if (_ResizeAspectFill == null)
			{
				_ResizeAspectFill = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeResizeAspectFill");
			}
			return _ResizeAspectFill;
		}
	}
}
