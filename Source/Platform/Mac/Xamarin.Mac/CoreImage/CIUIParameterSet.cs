using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public static class CIUIParameterSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Advanced;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Basic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Development;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Intermediate;

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
}
