using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CWStatusExtensions
{
	[Field("CWErrorDomain", "CoreWlan")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CWStatus self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreWlan.Handle, "CWErrorDomain");
		}
		return _domain;
	}
}
