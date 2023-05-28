using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICScannerStatus
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequestsOverviewScan;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WarmUpDone;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WarmingUp;

	[Field("ICScannerStatusRequestsOverviewScan", "ImageCaptureCore")]
	public static NSString RequestsOverviewScan
	{
		get
		{
			if (_RequestsOverviewScan == null)
			{
				_RequestsOverviewScan = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICScannerStatusRequestsOverviewScan");
			}
			return _RequestsOverviewScan;
		}
	}

	[Field("ICScannerStatusWarmUpDone", "ImageCaptureCore")]
	public static NSString WarmUpDone
	{
		get
		{
			if (_WarmUpDone == null)
			{
				_WarmUpDone = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICScannerStatusWarmUpDone");
			}
			return _WarmUpDone;
		}
	}

	[Field("ICScannerStatusWarmingUp", "ImageCaptureCore")]
	public static NSString WarmingUp
	{
		get
		{
			if (_WarmingUp == null)
			{
				_WarmingUp = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICScannerStatusWarmingUp");
			}
			return _WarmingUp;
		}
	}
}
