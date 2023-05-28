using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
internal static class _SKReceiptProperty
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsExpired;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsRevoked;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsVolumePurchase;

	[Field("SKReceiptPropertyIsExpired", "StoreKit")]
	internal static NSString IsExpired
	{
		get
		{
			if (_IsExpired == null)
			{
				_IsExpired = Dlfcn.GetStringConstant(Libraries.StoreKit.Handle, "SKReceiptPropertyIsExpired");
			}
			return _IsExpired;
		}
	}

	[Field("SKReceiptPropertyIsRevoked", "StoreKit")]
	internal static NSString IsRevoked
	{
		get
		{
			if (_IsRevoked == null)
			{
				_IsRevoked = Dlfcn.GetStringConstant(Libraries.StoreKit.Handle, "SKReceiptPropertyIsRevoked");
			}
			return _IsRevoked;
		}
	}

	[Field("SKReceiptPropertyIsVolumePurchase", "StoreKit")]
	internal static NSString IsVolumePurchase
	{
		get
		{
			if (_IsVolumePurchase == null)
			{
				_IsVolumePurchase = Dlfcn.GetStringConstant(Libraries.StoreKit.Handle, "SKReceiptPropertyIsVolumePurchase");
			}
			return _IsVolumePurchase;
		}
	}
}
