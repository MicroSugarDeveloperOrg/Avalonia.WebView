using Foundation;
using ObjCRuntime;

namespace CoreMotion;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CMErrorExtensions
{
	[Field("CMErrorDomain", "CoreMotion")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CMError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreMotion.Handle, "CMErrorDomain");
		}
		return _domain;
	}
}
