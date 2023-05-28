using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPersistableContentKeyRequest", true)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPersistableContentKeyRequest : AVContentKeyRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistableContentKeyFromKeyVendorResponse_Options_Error_ = "persistableContentKeyFromKeyVendorResponse:options:error:";

	private static readonly IntPtr selPersistableContentKeyFromKeyVendorResponse_Options_Error_Handle = Selector.GetHandle("persistableContentKeyFromKeyVendorResponse:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPersistableContentKeyRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPersistableContentKeyRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPersistableContentKeyRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("persistableContentKeyFromKeyVendorResponse:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetPersistableContentKey(NSData keyVendorResponse, NSDictionary<NSString, NSObject>? options, out NSError outError)
	{
		if (keyVendorResponse == null)
		{
			throw new ArgumentNullException("keyVendorResponse");
		}
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPersistableContentKeyFromKeyVendorResponse_Options_Error_Handle, keyVendorResponse.Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPersistableContentKeyFromKeyVendorResponse_Options_Error_Handle, keyVendorResponse.Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
