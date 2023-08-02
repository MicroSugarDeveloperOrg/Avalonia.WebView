using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIUIParameterSet
{
	private static NSString _Basic;

	private static NSString _Intermediate;

	private static NSString _Advanced;

	private static NSString _Development;

	[Field("kCIUISetBasic", "Quartz")]
	public static NSString Basic
	{
		get
		{
			if (_Basic == null)
			{
				_Basic = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUISetBasic");
			}
			return _Basic;
		}
	}

	[Field("kCIUISetIntermediate", "Quartz")]
	public static NSString Intermediate
	{
		get
		{
			if (_Intermediate == null)
			{
				_Intermediate = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUISetIntermediate");
			}
			return _Intermediate;
		}
	}

	[Field("kCIUISetAdvanced", "Quartz")]
	public static NSString Advanced
	{
		get
		{
			if (_Advanced == null)
			{
				_Advanced = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUISetAdvanced");
			}
			return _Advanced;
		}
	}

	[Field("kCIUISetDevelopment", "Quartz")]
	public static NSString Development
	{
		get
		{
			if (_Development == null)
			{
				_Development = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUISetDevelopment");
			}
			return _Development;
		}
	}
}
