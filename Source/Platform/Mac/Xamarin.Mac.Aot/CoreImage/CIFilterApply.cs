using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterApply
{
	private static NSString _OptionExtent;

	private static NSString _OptionDefinition;

	private static NSString _OptionUserInfo;

	private static NSString _OptionColorSpace;

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
}
