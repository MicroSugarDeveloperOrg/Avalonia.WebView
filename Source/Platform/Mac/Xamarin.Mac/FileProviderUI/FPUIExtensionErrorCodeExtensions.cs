using Foundation;
using ObjCRuntime;

namespace FileProviderUI;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class FPUIExtensionErrorCodeExtensions
{
	[Field("FPUIErrorDomain", "FileProviderUI")]
	private static NSString? _domain;

	public static NSString? GetDomain(this FPUIExtensionErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.FileProviderUI.Handle, "FPUIErrorDomain");
		}
		return _domain;
	}
}
