using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDecompressedVideoOutput", true)]
public class QTCaptureDecompressedVideoOutput : QTCaptureOutput
{
	[Register]
	private sealed class _QTCaptureDecompressedVideoOutputDelegate : QTCaptureDecompressedVideoOutputDelegate
	{
		internal EventHandler<QTCaptureVideoFrameEventArgs> didOutputVideoFrame;

		internal EventHandler<QTCaptureVideoDroppedEventArgs> didDropVideoFrame;

		[Preserve(Conditional = true)]
		public override void DidOutputVideoFrame(QTCaptureOutput captureOutput, CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureVideoFrameEventArgs> eventHandler = didOutputVideoFrame;
			if (eventHandler != null)
			{
				QTCaptureVideoFrameEventArgs e = new QTCaptureVideoFrameEventArgs(videoFrame, sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidDropVideoFrame(QTCaptureOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureVideoDroppedEventArgs> eventHandler = didDropVideoFrame;
			if (eventHandler != null)
			{
				QTCaptureVideoDroppedEventArgs e = new QTCaptureVideoDroppedEventArgs(sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}
	}

	private static readonly IntPtr selPixelBufferAttributesHandle = Selector.GetHandle("pixelBufferAttributes");

	private static readonly IntPtr selSetPixelBufferAttributes_Handle = Selector.GetHandle("setPixelBufferAttributes:");

	private static readonly IntPtr selMinimumVideoFrameIntervalHandle = Selector.GetHandle("minimumVideoFrameInterval");

	private static readonly IntPtr selSetMinimumVideoFrameInterval_Handle = Selector.GetHandle("setMinimumVideoFrameInterval:");

	private static readonly IntPtr selAutomaticallyDropsLateVideoFramesHandle = Selector.GetHandle("automaticallyDropsLateVideoFrames");

	private static readonly IntPtr selSetAutomaticallyDropsLateVideoFrames_Handle = Selector.GetHandle("setAutomaticallyDropsLateVideoFrames:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selOutputVideoFrameWithSampleBufferFromConnection_Handle = Selector.GetHandle("outputVideoFrame:withSampleBuffer:fromConnection:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureDecompressedVideoOutput");

	private object __mt_PixelBufferAttributes_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary PixelBufferAttributes
	{
		[Export("pixelBufferAttributes")]
		get
		{
			return (NSDictionary)(__mt_PixelBufferAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferAttributesHandle)))));
		}
		[Export("setPixelBufferAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPixelBufferAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPixelBufferAttributes_Handle, value.Handle);
			}
			__mt_PixelBufferAttributes_var = value;
		}
	}

	public virtual double MinimumVideoFrameInterval
	{
		[Export("minimumVideoFrameInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumVideoFrameIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumVideoFrameIntervalHandle);
		}
		[Export("setMinimumVideoFrameInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinimumVideoFrameInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinimumVideoFrameInterval_Handle, value);
			}
		}
	}

	public virtual bool AutomaticallyDropsLateVideoFrames
	{
		[Export("automaticallyDropsLateVideoFrames")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyDropsLateVideoFramesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyDropsLateVideoFramesHandle);
		}
		[Export("setAutomaticallyDropsLateVideoFrames:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyDropsLateVideoFrames_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyDropsLateVideoFrames_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public QTCaptureDecompressedVideoOutputDelegate Delegate
	{
		get
		{
			return WeakDelegate as QTCaptureDecompressedVideoOutputDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public event EventHandler<QTCaptureVideoFrameEventArgs> DidOutputVideoFrame
	{
		add
		{
			_QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = EnsureQTCaptureDecompressedVideoOutputDelegate();
			qTCaptureDecompressedVideoOutputDelegate.didOutputVideoFrame = (EventHandler<QTCaptureVideoFrameEventArgs>)System.Delegate.Combine(qTCaptureDecompressedVideoOutputDelegate.didOutputVideoFrame, value);
		}
		remove
		{
			_QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = EnsureQTCaptureDecompressedVideoOutputDelegate();
			qTCaptureDecompressedVideoOutputDelegate.didOutputVideoFrame = (EventHandler<QTCaptureVideoFrameEventArgs>)System.Delegate.Remove(qTCaptureDecompressedVideoOutputDelegate.didOutputVideoFrame, value);
		}
	}

	public event EventHandler<QTCaptureVideoDroppedEventArgs> DidDropVideoFrame
	{
		add
		{
			_QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = EnsureQTCaptureDecompressedVideoOutputDelegate();
			qTCaptureDecompressedVideoOutputDelegate.didDropVideoFrame = (EventHandler<QTCaptureVideoDroppedEventArgs>)System.Delegate.Combine(qTCaptureDecompressedVideoOutputDelegate.didDropVideoFrame, value);
		}
		remove
		{
			_QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = EnsureQTCaptureDecompressedVideoOutputDelegate();
			qTCaptureDecompressedVideoOutputDelegate.didDropVideoFrame = (EventHandler<QTCaptureVideoDroppedEventArgs>)System.Delegate.Remove(qTCaptureDecompressedVideoOutputDelegate.didDropVideoFrame, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureDecompressedVideoOutput()
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
	public QTCaptureDecompressedVideoOutput(NSCoder coder)
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
	public QTCaptureDecompressedVideoOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureDecompressedVideoOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outputVideoFrame:withSampleBuffer:fromConnection:")]
	public virtual void OutputVideoFrame(CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selOutputVideoFrameWithSampleBufferFromConnection_Handle, videoFrame.Handle, sampleBuffer.Handle, connection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selOutputVideoFrameWithSampleBufferFromConnection_Handle, videoFrame.Handle, sampleBuffer.Handle, connection.Handle);
		}
	}

	private _QTCaptureDecompressedVideoOutputDelegate EnsureQTCaptureDecompressedVideoOutputDelegate()
	{
		QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = Delegate;
		if (qTCaptureDecompressedVideoOutputDelegate == null || !(qTCaptureDecompressedVideoOutputDelegate is _QTCaptureDecompressedVideoOutputDelegate))
		{
			qTCaptureDecompressedVideoOutputDelegate = (Delegate = new _QTCaptureDecompressedVideoOutputDelegate());
		}
		return (_QTCaptureDecompressedVideoOutputDelegate)qTCaptureDecompressedVideoOutputDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PixelBufferAttributes_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
