using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSImageHint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Ctm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Interpolation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserInterfaceLayoutDirection;

	[Field("NSImageHintCTM", "AppKit")]
	public static NSString Ctm
	{
		get
		{
			if (_Ctm == null)
			{
				_Ctm = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageHintCTM");
			}
			return _Ctm;
		}
	}

	[Field("NSImageHintInterpolation", "AppKit")]
	public static NSString Interpolation
	{
		get
		{
			if (_Interpolation == null)
			{
				_Interpolation = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageHintInterpolation");
			}
			return _Interpolation;
		}
	}

	[Field("NSImageHintUserInterfaceLayoutDirection", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString UserInterfaceLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_UserInterfaceLayoutDirection == null)
			{
				_UserInterfaceLayoutDirection = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageHintUserInterfaceLayoutDirection");
			}
			return _UserInterfaceLayoutDirection;
		}
	}
}
