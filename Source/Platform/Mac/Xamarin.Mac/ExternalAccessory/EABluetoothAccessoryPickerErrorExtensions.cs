using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class EABluetoothAccessoryPickerErrorExtensions
{
	[Field("EABluetoothAccessoryPickerErrorDomain", "ExternalAccessory")]
	private static NSString? _domain;

	public static NSString? GetDomain(this EABluetoothAccessoryPickerError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.ExternalAccessory.Handle, "EABluetoothAccessoryPickerErrorDomain");
		}
		return _domain;
	}
}
