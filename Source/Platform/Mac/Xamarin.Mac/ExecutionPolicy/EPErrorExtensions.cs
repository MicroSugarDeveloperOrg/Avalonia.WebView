using Foundation;
using ObjCRuntime;

namespace ExecutionPolicy;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class EPErrorExtensions
{
	[Field("EPErrorDomain", "ExecutionPolicy")]
	private static NSString? _domain;

	public static NSString? GetDomain(this EPError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.ExecutionPolicy.Handle, "EPErrorDomain");
		}
		return _domain;
	}
}
