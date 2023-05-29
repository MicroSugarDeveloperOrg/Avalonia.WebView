using System;
using System.ComponentModel;
using CoreFoundation;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemVideoOutput", true)]
public class AVPlayerItemVideoOutput : AVPlayerItemOutput
{
	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	private static readonly IntPtr selInitWithPixelBufferAttributes_Handle = Selector.GetHandle("initWithPixelBufferAttributes:");

	private static readonly IntPtr selHasNewPixelBufferForItemTime_Handle = Selector.GetHandle("hasNewPixelBufferForItemTime:");

	private static readonly IntPtr selCopyPixelBufferForItemTimeItemTimeForDisplay_Handle = Selector.GetHandle("copyPixelBufferForItemTime:itemTimeForDisplay:");

	private static readonly IntPtr selSetDelegateQueue_Handle = Selector.GetHandle("setDelegate:queue:");

	private static readonly IntPtr selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle = Selector.GetHandle("requestNotificationOfMediaDataChangeWithAdvanceInterval:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItemVideoOutput");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
	}

	public AVPlayerItemOutputPullDelegate Delegate => WeakDelegate as AVPlayerItemOutputPullDelegate;

	public virtual DispatchQueue DelegateQueue
	{
		[Export("delegateQueue")]
		get
		{
			if (IsDirectBinding)
			{
				return new DispatchQueue(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			}
			return new DispatchQueue(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemVideoOutput()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVPlayerItemVideoOutput(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemVideoOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemVideoOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPixelBufferAttributes:")]
	protected AVPlayerItemVideoOutput(NSDictionary pixelBufferAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBufferAttributes == null)
		{
			throw new ArgumentNullException("pixelBufferAttributes");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPixelBufferAttributes_Handle, pixelBufferAttributes.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPixelBufferAttributes_Handle, pixelBufferAttributes.Handle);
		}
	}

	public AVPlayerItemVideoOutput(CVPixelBufferAttributes attributes)
		: this(attributes?.Dictionary)
	{
	}

	[Export("hasNewPixelBufferForItemTime:")]
	public virtual bool HasNewPixelBufferForItemTime(CMTime itemTime)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime(base.Handle, selHasNewPixelBufferForItemTime_Handle, itemTime);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime(base.SuperHandle, selHasNewPixelBufferForItemTime_Handle, itemTime);
	}

	[Export("copyPixelBufferForItemTime:itemTimeForDisplay:")]
	protected virtual IntPtr WeakCopyPixelBuffer(CMTime itemTime, ref CMTime outItemTimeForDisplay)
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_CMTime_out_CMTime(base.Handle, selCopyPixelBufferForItemTimeItemTimeForDisplay_Handle, itemTime, out outItemTimeForDisplay);
		}
		return Messaging.IntPtr_objc_msgSendSuper_CMTime_out_CMTime(base.SuperHandle, selCopyPixelBufferForItemTimeItemTimeForDisplay_Handle, itemTime, out outItemTimeForDisplay);
	}

	[Export("setDelegate:queue:")]
	public virtual void SetDelegate(AVPlayerItemOutputPullDelegate delegateClass, DispatchQueue delegateQueue)
	{
		if (delegateClass == null)
		{
			throw new ArgumentNullException("delegateClass");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDelegateQueue_Handle, delegateClass.Handle, delegateQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDelegateQueue_Handle, delegateClass.Handle, delegateQueue.Handle);
		}
	}

	[Export("requestNotificationOfMediaDataChangeWithAdvanceInterval:")]
	public virtual void RequestNotificationOfMediaDataChange(double advanceInterval)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle, advanceInterval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRequestNotificationOfMediaDataChangeWithAdvanceInterval_Handle, advanceInterval);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
