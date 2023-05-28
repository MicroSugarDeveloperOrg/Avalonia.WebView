using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVContentKeyResponse", true)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVContentKeyResponse : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeyResponseWithAuthorizationTokenData_ = "contentKeyResponseWithAuthorizationTokenData:";

	private static readonly IntPtr selContentKeyResponseWithAuthorizationTokenData_Handle = Selector.GetHandle("contentKeyResponseWithAuthorizationTokenData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeyResponseWithClearKeyData_InitializationVector_ = "contentKeyResponseWithClearKeyData:initializationVector:";

	private static readonly IntPtr selContentKeyResponseWithClearKeyData_InitializationVector_Handle = Selector.GetHandle("contentKeyResponseWithClearKeyData:initializationVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeyResponseWithFairPlayStreamingKeyResponseData_ = "contentKeyResponseWithFairPlayStreamingKeyResponseData:";

	private static readonly IntPtr selContentKeyResponseWithFairPlayStreamingKeyResponseData_Handle = Selector.GetHandle("contentKeyResponseWithFairPlayStreamingKeyResponseData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVContentKeyResponse");

	public override IntPtr ClassHandle => class_ptr;

	public static AVContentKeyResponse Create(NSData fairPlayStreamingKeyResponseData)
	{
		return Create(fairPlayStreamingKeyResponseData, AVContentKeyResponseDataType.FairPlayStreamingKeyResponseData);
	}

	[TV(10, 2)]
	[Mac(10, 12, 4)]
	[iOS(10, 3)]
	[NoWatch]
	public static AVContentKeyResponse Create(NSData data, AVContentKeyResponseDataType dataType = AVContentKeyResponseDataType.FairPlayStreamingKeyResponseData)
	{
		if (dataType == AVContentKeyResponseDataType.AuthorizationTokenData)
		{
			return _InitWithAuthorizationToken(data);
		}
		return _InitWithFairPlayStreamingKeyResponseData(data);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVContentKeyResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVContentKeyResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("contentKeyResponseWithClearKeyData:initializationVector:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVContentKeyResponse Create(NSData keyData, NSData? initializationVector)
	{
		if (keyData == null)
		{
			throw new ArgumentNullException("keyData");
		}
		return Runtime.GetNSObject<AVContentKeyResponse>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContentKeyResponseWithClearKeyData_InitializationVector_Handle, keyData.Handle, initializationVector?.Handle ?? IntPtr.Zero));
	}

	[Export("contentKeyResponseWithAuthorizationTokenData:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVContentKeyResponse _InitWithAuthorizationToken(NSData authorizationTokenData)
	{
		if (authorizationTokenData == null)
		{
			throw new ArgumentNullException("authorizationTokenData");
		}
		return Runtime.GetNSObject<AVContentKeyResponse>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContentKeyResponseWithAuthorizationTokenData_Handle, authorizationTokenData.Handle));
	}

	[Export("contentKeyResponseWithFairPlayStreamingKeyResponseData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVContentKeyResponse _InitWithFairPlayStreamingKeyResponseData(NSData fairPlayStreamingKeyResponseData)
	{
		if (fairPlayStreamingKeyResponseData == null)
		{
			throw new ArgumentNullException("fairPlayStreamingKeyResponseData");
		}
		return Runtime.GetNSObject<AVContentKeyResponse>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContentKeyResponseWithFairPlayStreamingKeyResponseData_Handle, fairPlayStreamingKeyResponseData.Handle));
	}
}
