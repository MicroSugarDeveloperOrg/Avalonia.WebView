using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterApply
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionDefinition;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionExtent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionUserInfo;

	[Field("kCIApplyOptionColorSpace", "Quartz")]
	public static NSString OptionColorSpace
	{
		get
		{
			if (_OptionColorSpace == null)
			{
				_OptionColorSpace = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIApplyOptionColorSpace");
			}
			return _OptionColorSpace;
		}
	}

	[Field("kCIApplyOptionDefinition", "Quartz")]
	public static NSString OptionDefinition
	{
		get
		{
			if (_OptionDefinition == null)
			{
				_OptionDefinition = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIApplyOptionDefinition");
			}
			return _OptionDefinition;
		}
	}

	[Field("kCIApplyOptionExtent", "Quartz")]
	public static NSString OptionExtent
	{
		get
		{
			if (_OptionExtent == null)
			{
				_OptionExtent = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIApplyOptionExtent");
			}
			return _OptionExtent;
		}
	}

	[Field("kCIApplyOptionUserInfo", "Quartz")]
	public static NSString OptionUserInfo
	{
		get
		{
			if (_OptionUserInfo == null)
			{
				_OptionUserInfo = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIApplyOptionUserInfo");
			}
			return _OptionUserInfo;
		}
	}
}
