using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CKErrorCodeExtensions
{
	[Field("CKErrorDomain", "CloudKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CKErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKErrorDomain");
		}
		return _domain;
	}
}
