using System;
using System.ComponentModel;
using AppKit;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDecompressedVideoOutput", true)]
public class QTCaptureDecompressedVideoOutput : QTCaptureOutput
{
	[Register]
	internal class _QTCaptureDecompressedVideoOutputDelegate : NSObject, IQTCaptureDecompressedVideoOutputDelegate, INativeObject, IDisposable
	{
		internal EventHandler<QTCaptureVideoDroppedEventArgs>? didDropVideoFrame;

		internal EventHandler<QTCaptureVideoFrameEventArgs>? didOutputVideoFrame;

		public _QTCaptureDecompressedVideoOutputDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didDropVideoFrameWithSampleBuffer:fromConnection:")]
		public void DidDropVideoFrame(QTCaptureOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureVideoDroppedEventArgs> eventHandler = didDropVideoFrame;
			if (eventHandler != null)
			{
				QTCaptureVideoDroppedEventArgs e = new QTCaptureVideoDroppedEventArgs(sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didOutputVideoFrame:withSampleBuffer:fromConnection:")]
		public void DidOutputVideoFrame(QTCaptureOutput captureOutput, CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureVideoFrameEventArgs> eventHandler = didOutputVideoFrame;
			if (eventHandler != null)
			{
				QTCaptureVideoFrameEventArgs e = new QTCaptureVideoFrameEventArgs(videoFrame, sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyDropsLateVideoFrames = "automaticallyDropsLateVideoFrames";

	private static readonly IntPtr selAutomaticallyDropsLateVideoFramesHandle = Selector.GetHandle("automaticallyDropsLateVideoFrames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumVideoFrameInterval = "minimumVideoFrameInterval";

	private static readonly IntPtr selMinimumVideoFrameIntervalHandle = Selector.GetHandle("minimumVideoFrameInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputVideoFrame_WithSampleBuffer_FromConnection_ = "outputVideoFrame:withSampleBuffer:fromConnection:";

	private static readonly IntPtr selOutputVideoFrame_WithSampleBuffer_FromConnection_Handle = Selector.GetHandle("outputVideoFrame:withSampleBuffer:fromConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBufferAttributes = "pixelBufferAttributes";

	private static readonly IntPtr selPixelBufferAttributesHandle = Selector.GetHandle("pixelBufferAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyDropsLateVideoFrames_ = "setAutomaticallyDropsLateVideoFrames:";

	private static readonly IntPtr selSetAutomaticallyDropsLateVideoFrames_Handle = Selector.GetHandle("setAutomaticallyDropsLateVideoFrames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumVideoFrameInterval_ = "setMinimumVideoFrameInterval:";

	private static readonly IntPtr selSetMinimumVideoFrameInterval_Handle = Selector.GetHandle("setMinimumVideoFrameInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelBufferAttributes_ = "setPixelBufferAttributes:";

	private static readonly IntPtr selSetPixelBufferAttributes_Handle = Selector.GetHandle("setPixelBufferAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureDecompressedVideoOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticallyDropsLateVideoFrames
	{
		[Export("automaticallyDropsLateVideoFrames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyDropsLateVideoFramesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyDropsLateVideoFramesHandle);
		}
		[Export("setAutomaticallyDropsLateVideoFrames:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyDropsLateVideoFrames_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyDropsLateVideoFrames_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQTCaptureDecompressedVideoOutputDelegate Delegate
	{
		get
		{
			return WeakDelegate as IQTCaptureDecompressedVideoOutputDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MinimumVideoFrameInterval
	{
		[Export("minimumVideoFrameInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumVideoFrameIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumVideoFrameIntervalHandle);
		}
		[Export("setMinimumVideoFrameInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinimumVideoFrameInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinimumVideoFrameInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary PixelBufferAttributes
	{
		[Export("pixelBufferAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferAttributesHandle));
		}
		[Export("setPixelBufferAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPixelBufferAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPixelBufferAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_QTCaptureDecompressedVideoOutputDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureDecompressedVideoOutput()
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
	protected QTCaptureDecompressedVideoOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureDecompressedVideoOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outputVideoFrame:withSampleBuffer:fromConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OutputVideoFrame(CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		if (videoFrame == null)
		{
			throw new ArgumentNullException("videoFrame");
		}
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selOutputVideoFrame_WithSampleBuffer_FromConnection_Handle, videoFrame.Handle, sampleBuffer.Handle, connection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selOutputVideoFrame_WithSampleBuffer_FromConnection_Handle, videoFrame.Handle, sampleBuffer.Handle, connection.Handle);
		}
	}

	internal virtual _QTCaptureDecompressedVideoOutputDelegate CreateInternalEventDelegateType()
	{
		return new _QTCaptureDecompressedVideoOutputDelegate();
	}

	internal _QTCaptureDecompressedVideoOutputDelegate EnsureQTCaptureDecompressedVideoOutputDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_QTCaptureDecompressedVideoOutputDelegate qTCaptureDecompressedVideoOutputDelegate = Delegate as _QTCaptureDecompressedVideoOutputDelegate;
		if (qTCaptureDecompressedVideoOutputDelegate == null)
		{
			qTCaptureDecompressedVideoOutputDelegate = (_QTCaptureDecompressedVideoOutputDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return qTCaptureDecompressedVideoOutputDelegate;
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
