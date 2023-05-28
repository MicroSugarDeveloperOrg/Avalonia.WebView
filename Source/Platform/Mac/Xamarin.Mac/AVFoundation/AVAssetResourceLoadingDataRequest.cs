using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetResourceLoadingDataRequest", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetResourceLoadingDataRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentOffset = "currentOffset";

	private static readonly IntPtr selCurrentOffsetHandle = Selector.GetHandle("currentOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedLength = "requestedLength";

	private static readonly IntPtr selRequestedLengthHandle = Selector.GetHandle("requestedLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedOffset = "requestedOffset";

	private static readonly IntPtr selRequestedOffsetHandle = Selector.GetHandle("requestedOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestsAllDataToEndOfResource = "requestsAllDataToEndOfResource";

	private static readonly IntPtr selRequestsAllDataToEndOfResourceHandle = Selector.GetHandle("requestsAllDataToEndOfResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRespondWithData_ = "respondWithData:";

	private static readonly IntPtr selRespondWithData_Handle = Selector.GetHandle("respondWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetResourceLoadingDataRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long CurrentOffset
	{
		[Export("currentOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCurrentOffsetHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RequestedLength
	{
		[Export("requestedLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRequestedLengthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRequestedLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long RequestedOffset
	{
		[Export("requestedOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selRequestedOffsetHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRequestedOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool RequestsAllDataToEndOfResource
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("requestsAllDataToEndOfResource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequestsAllDataToEndOfResourceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequestsAllDataToEndOfResourceHandle);
		}
	}

	public override string ToString()
	{
		return "AVAssetResourceLoadingDataRequest";
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetResourceLoadingDataRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetResourceLoadingDataRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("respondWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Respond(NSData responseData)
	{
		if (responseData == null)
		{
			throw new ArgumentNullException("responseData");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRespondWithData_Handle, responseData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRespondWithData_Handle, responseData.Handle);
		}
	}
}
