using Foundation;
using ObjCRuntime;

namespace StoreKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SKErrorExtensions
{
	[Field("SKErrorDomain", "StoreKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this SKError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.StoreKit.Handle, "SKErrorDomain");
		}
		return _domain;
	}
}
