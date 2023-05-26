using Foundation;
using ObjCRuntime;

namespace Accounts;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ACErrorCodeExtensions
{
	[Field("ACErrorDomain", "Accounts")]
	private static NSString? _domain;

	public static NSString? GetDomain(this ACErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACErrorDomain");
		}
		return _domain;
	}
}
