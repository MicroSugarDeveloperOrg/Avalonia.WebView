using Foundation;
using ObjCRuntime;

namespace GameKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class GKErrorExtensions
{
	[Field("GKErrorDomain", "GameKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this GKError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.GameKit.Handle, "GKErrorDomain");
		}
		return _domain;
	}
}
