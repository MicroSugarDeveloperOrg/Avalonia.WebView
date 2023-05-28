using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
internal static class SecKeyKeyExchangeParameterKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequestedSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharedInfoKey;

	[Field("kSecKeyKeyExchangeParameterRequestedSize", "Security")]
	public static NSString RequestedSizeKey
	{
		get
		{
			if (_RequestedSizeKey == null)
			{
				_RequestedSizeKey = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecKeyKeyExchangeParameterRequestedSize");
			}
			return _RequestedSizeKey;
		}
	}

	[Field("kSecKeyKeyExchangeParameterSharedInfo", "Security")]
	public static NSString SharedInfoKey
	{
		get
		{
			if (_SharedInfoKey == null)
			{
				_SharedInfoKey = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecKeyKeyExchangeParameterSharedInfo");
			}
			return _SharedInfoKey;
		}
	}
}
