using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class INIntentErrorCodeExtensions
{
	[Field("INIntentErrorDomain", "Intents")]
	private static NSString? _domain;

	public static NSString? GetDomain(this INIntentErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Intents.Handle, "INIntentErrorDomain");
		}
		return _domain;
	}
}
