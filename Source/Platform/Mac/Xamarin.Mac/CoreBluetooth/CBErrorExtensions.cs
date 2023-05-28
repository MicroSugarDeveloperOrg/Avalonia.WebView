using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CBErrorExtensions
{
	[Field("CBErrorDomain", "CoreBluetooth")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CBError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBErrorDomain");
		}
		return _domain;
	}
}
