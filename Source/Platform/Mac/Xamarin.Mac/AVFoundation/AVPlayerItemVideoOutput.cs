using System;
using System.ComponentModel;
using CoreFoundation;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemVideoOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPlayerItemVideoOutput : AVPlayerItemOutput
{
	private enum InitMode
	{
		PixelAttributes,
		OutputSettings
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyPixelBufferForItemTime_ItemTimeForDisplay_ = "copyPixelBufferForItemTime:itemTimeForDisplay:";

	private static readonly IntPtr selCopyPixelBufferForItemTime_ItemTimeForDisplay_Handle = Selector.GetHandle("copyPixelBufferForItemTime:itemTimeForDisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasNewPixelBufferForItemTime_ = "hasNewPixelBufferForItemTime:";

	private static readonly IntPtr selHasNewPixelBufferForItemTime_Handle = Selector.GetHandle("hasNewPixelBufferForItemTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOutputSettings_ = "initWithOutputSettings:";

	private static readonly IntPtr selInitWithOutputSettings_Handle = Selector.GetHandle("initWithOutputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPixelBufferAttributes_ = "initWithPixelBufferAttributes:";

	private static readonly IntPtr selInitWithPixelBufferAttributes_Handle = Selector.GetHandle("initWithPixelBufferAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestNotificationOfMediaDataChangeWithAdvanceInterval_ = "requestNotificationOfMediaDataChangeWithAdvanceInterval:";

	private static readonly IntPtr selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle = Selector.GetHandle("requestNotificationOfMediaDataChangeWithAdvanceInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_Queue_ = "setDelegate:queue:";

	private static readonly IntPtr selSetDelegate_Queue_Handle = Selector.GetHandle("setDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemVideoOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVPlayerItemOutputPullDelegate? Delegate => WeakDelegate as IAVPlayerItemOutputPullDelegate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? DelegateQueue
	{
		[Export("delegateQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
	}

	private AVPlayerItemVideoOutput(NSDictionary data, InitMode mode)
		: base(NSObjectFlag.Empty)
	{
		switch (mode)
		{
		case InitMode.PixelAttributes:
			InitializeHandle(_FromPixelBufferAttributes(data), "initWithPixelBufferAttributes:");
			break;
		case InitMode.OutputSettings:
			InitializeHandle(_FromOutputSettings(data), "initWithOutputSettings:");
			break;
		default:
			throw new ArgumentException("mode");
		}
	}

	[DesignatedInitializer]
	[Advice("Please use the constructor that uses one of the available StrongDictionaries. This constructor expects PixelBuffer attributes.")]
	protected AVPlayerItemVideoOutput(NSDictionary pixelBufferAttributes)
		: this(pixelBufferAttributes, InitMode.PixelAttributes)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemVideoOutput()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerItemVideoOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemVideoOutput(IntPtr handle)
		: base(handle)
	{
	}

	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemVideoOutput(CVPixelBufferAttributes attributes)
		: this(attributes.GetDictionary(), InitMode.PixelAttributes)
	{
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemVideoOutput(AVPlayerItemVideoOutputSettings settings)
		: this(settings.GetDictionary(), InitMode.OutputSettings)
	{
	}

	[Export("hasNewPixelBufferForItemTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasNewPixelBufferForItemTime(CMTime itemTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime(base.Handle, selHasNewPixelBufferForItemTime_Handle, itemTime);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime(base.SuperHandle, selHasNewPixelBufferForItemTime_Handle, itemTime);
	}

	[Export("requestNotificationOfMediaDataChangeWithAdvanceInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestNotificationOfMediaDataChange(double advanceInterval)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle, advanceInterval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle, advanceInterval);
		}
	}

	[Export("setDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegate(IAVPlayerItemOutputPullDelegate? delegateClass, DispatchQueue? delegateQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDelegate_Queue_Handle, delegateClass?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDelegate_Queue_Handle, delegateClass?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
	}

	[Export("copyPixelBufferForItemTime:itemTimeForDisplay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual IntPtr WeakCopyPixelBuffer(CMTime itemTime, ref CMTime outItemTimeForDisplay)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_CMTime_ref_CMTime(base.Handle, selCopyPixelBufferForItemTime_ItemTimeForDisplay_Handle, itemTime, ref outItemTimeForDisplay);
		}
		return Messaging.IntPtr_objc_msgSendSuper_CMTime_ref_CMTime(base.SuperHandle, selCopyPixelBufferForItemTime_ItemTimeForDisplay_Handle, itemTime, ref outItemTimeForDisplay);
	}

	[Export("initWithOutputSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _FromOutputSettings(NSDictionary? outputSettings)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOutputSettings_Handle, outputSettings?.Handle ?? IntPtr.Zero);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOutputSettings_Handle, outputSettings?.Handle ?? IntPtr.Zero);
	}

	[Export("initWithPixelBufferAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _FromPixelBufferAttributes(NSDictionary? pixelBufferAttributes)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPixelBufferAttributes_Handle, pixelBufferAttributes?.Handle ?? IntPtr.Zero);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPixelBufferAttributes_Handle, pixelBufferAttributes?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
