using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVContentKeyRequest_AVContentKeyRequestRenewal
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewsExpiringResponseData = "renewsExpiringResponseData";

	private static readonly IntPtr selRenewsExpiringResponseDataHandle = Selector.GetHandle("renewsExpiringResponseData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVContentKeyRequest");

	[Export("renewsExpiringResponseData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetRenewsExpiringResponseData(this AVContentKeyRequest This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selRenewsExpiringResponseDataHandle);
	}
}
