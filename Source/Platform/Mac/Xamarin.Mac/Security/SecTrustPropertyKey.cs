using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public static class SecTrustPropertyKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Error;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Title;

	[Field("kSecPropertyTypeError", "Security")]
	public static NSString Error
	{
		get
		{
			if (_Error == null)
			{
				_Error = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPropertyTypeError");
			}
			return _Error;
		}
	}

	[Field("kSecPropertyTypeTitle", "Security")]
	public static NSString Title
	{
		get
		{
			if (_Title == null)
			{
				_Title = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPropertyTypeTitle");
			}
			return _Title;
		}
	}
}
