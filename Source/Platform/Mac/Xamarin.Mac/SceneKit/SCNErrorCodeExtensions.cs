using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SCNErrorCodeExtensions
{
	[Field("SCNErrorDomain", "SceneKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this SCNErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNErrorDomain");
		}
		return _domain;
	}
}
