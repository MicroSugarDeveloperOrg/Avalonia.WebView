using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CBATTErrorExtensions
{
	[Field("CBATTErrorDomain", "CoreBluetooth")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CBATTError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBATTErrorDomain");
		}
		return _domain;
	}
}
