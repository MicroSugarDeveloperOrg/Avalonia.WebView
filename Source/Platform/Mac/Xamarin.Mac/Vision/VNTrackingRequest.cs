using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNTrackingRequest", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public abstract class VNTrackingRequest : VNImageBasedRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompletionHandler_ = "initWithCompletionHandler:";

	private static readonly IntPtr selInitWithCompletionHandler_Handle = Selector.GetHandle("initWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputObservation = "inputObservation";

	private static readonly IntPtr selInputObservationHandle = Selector.GetHandle("inputObservation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLastFrame = "isLastFrame";

	private static readonly IntPtr selIsLastFrameHandle = Selector.GetHandle("isLastFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputObservation_ = "setInputObservation:";

	private static readonly IntPtr selSetInputObservation_Handle = Selector.GetHandle("setInputObservation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLastFrame_ = "setLastFrame:";

	private static readonly IntPtr selSetLastFrame_Handle = Selector.GetHandle("setLastFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackingLevel_ = "setTrackingLevel:";

	private static readonly IntPtr selSetTrackingLevel_Handle = Selector.GetHandle("setTrackingLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackingLevel = "trackingLevel";

	private static readonly IntPtr selTrackingLevelHandle = Selector.GetHandle("trackingLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNTrackingRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNDetectedObjectObservation InputObservation
	{
		[Export("inputObservation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNDetectedObjectObservation>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputObservationHandle));
			}
			return Runtime.GetNSObject<VNDetectedObjectObservation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputObservationHandle));
		}
		[Export("setInputObservation:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputObservation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputObservation_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LastFrame
	{
		[Export("isLastFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLastFrameHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLastFrameHandle);
		}
		[Export("setLastFrame:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLastFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLastFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNRequestTrackingLevel TrackingLevel
	{
		[Export("trackingLevel", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNRequestTrackingLevel)Messaging.UInt64_objc_msgSend(base.Handle, selTrackingLevelHandle);
			}
			return (VNRequestTrackingLevel)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTrackingLevelHandle);
		}
		[Export("setTrackingLevel:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTrackingLevel_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTrackingLevel_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNTrackingRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNTrackingRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNTrackingRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
