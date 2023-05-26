using Foundation;
using ObjCRuntime;

namespace EventKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class EKErrorCodeExtensions
{
	[Field("EKErrorDomain", "EventKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this EKErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.EventKit.Handle, "EKErrorDomain");
		}
		return _domain;
	}
}
