using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureAudioDataOutput", true)]
public class AVCaptureAudioDataOutput : AVCaptureOutput
{
	private static readonly IntPtr selSampleBufferDelegateHandle = Selector.GetHandle("sampleBufferDelegate");

	private static readonly IntPtr selSampleBufferCallbackQueueHandle = Selector.GetHandle("sampleBufferCallbackQueue");

	private static readonly IntPtr selSetSampleBufferDelegateQueue_Handle = Selector.GetHandle("setSampleBufferDelegate:queue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureAudioDataOutput");

	private object __mt_SampleBufferDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureAudioDataOutputSampleBufferDelegate SampleBufferDelegate
	{
		[Export("sampleBufferDelegate")]
		get
		{
			return (AVCaptureAudioDataOutputSampleBufferDelegate)(__mt_SampleBufferDelegate_var = ((!IsDirectBinding) ? ((AVCaptureAudioDataOutputSampleBufferDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferDelegateHandle))) : ((AVCaptureAudioDataOutputSampleBufferDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferDelegateHandle)))));
		}
	}

	public virtual DispatchQueue SampleBufferCallbackQueue
	{
		[Export("sampleBufferCallbackQueue")]
		get
		{
			if (IsDirectBinding)
			{
				return new DispatchQueue(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferCallbackQueueHandle));
			}
			return new DispatchQueue(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferCallbackQueueHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureAudioDataOutput()
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
	public AVCaptureAudioDataOutput(NSCoder coder)
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
	public AVCaptureAudioDataOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureAudioDataOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setSampleBufferDelegate:queue:")]
	public virtual void SetSampleBufferDelegatequeue(AVCaptureAudioDataOutputSampleBufferDelegate sampleBufferDelegate, DispatchQueue sampleBufferCallbackDispatchQueue)
	{
		if (sampleBufferDelegate == null)
		{
			throw new ArgumentNullException("sampleBufferDelegate");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegateQueue_Handle, sampleBufferDelegate.Handle, sampleBufferCallbackDispatchQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSampleBufferDelegateQueue_Handle, sampleBufferDelegate.Handle, sampleBufferCallbackDispatchQueue.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SampleBufferDelegate_var = null;
		}
	}
}
