using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VNErrorCodeExtensions
{
	[Field("VNErrorDomain", "Vision")]
	private static NSString? _domain;

	public static NSString? GetDomain(this VNErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Vision.Handle, "VNErrorDomain");
		}
		return _domain;
	}
}
