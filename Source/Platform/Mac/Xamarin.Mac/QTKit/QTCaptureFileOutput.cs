using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureFileOutput", true)]
public class QTCaptureFileOutput : QTCaptureOutput
{
	[Register]
	private sealed class _QTCaptureFileOutputDelegate : QTCaptureFileOutputDelegate
	{
		internal EventHandler<QTCaptureFileSampleEventArgs> didOutputSampleBuffer;

		internal EventHandler<QTCaptureFileUrlEventArgs> willStartRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs> didStartRecording;

		internal QTCaptureFileError shouldChangeOutputFile;

		internal EventHandler<QTCaptureFileErrorEventArgs> mustChangeOutputFile;

		internal EventHandler<QTCaptureFileErrorEventArgs> willFinishRecording;

		internal EventHandler<QTCaptureFileErrorEventArgs> didFinishRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs> didPauseRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs> didResumeRecording;

		[Preserve(Conditional = true)]
		public override void DidOutputSampleBuffer(QTCaptureFileOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureFileSampleEventArgs> eventHandler = didOutputSampleBuffer;
			if (eventHandler != null)
			{
				QTCaptureFileSampleEventArgs e = new QTCaptureFileSampleEventArgs(sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = willStartRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didStartRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool ShouldChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			return shouldChangeOutputFile?.Invoke(captureOutput, outputFileURL, connections, reason) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void MustChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = mustChangeOutputFile;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = willFinishRecording;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = didFinishRecording;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidPauseRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didPauseRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidResumeRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didResumeRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}
	}

	private static readonly IntPtr selOutputFileURLHandle = Selector.GetHandle("outputFileURL");

	private static readonly IntPtr selIsRecordingPausedHandle = Selector.GetHandle("isRecordingPaused");

	private static readonly IntPtr selRecordedDurationHandle = Selector.GetHandle("recordedDuration");

	private static readonly IntPtr selRecordedFileSizeHandle = Selector.GetHandle("recordedFileSize");

	private static readonly IntPtr selMaximumVideoSizeHandle = Selector.GetHandle("maximumVideoSize");

	private static readonly IntPtr selSetMaximumVideoSize_Handle = Selector.GetHandle("setMaximumVideoSize:");

	private static readonly IntPtr selMinimumVideoFrameIntervalHandle = Selector.GetHandle("minimumVideoFrameInterval");

	private static readonly IntPtr selSetMinimumVideoFrameInterval_Handle = Selector.GetHandle("setMinimumVideoFrameInterval:");

	private static readonly IntPtr selMaximumRecordedDurationHandle = Selector.GetHandle("maximumRecordedDuration");

	private static readonly IntPtr selSetMaximumRecordedDuration_Handle = Selector.GetHandle("setMaximumRecordedDuration:");

	private static readonly IntPtr selMaximumRecordedFileSizeHandle = Selector.GetHandle("maximumRecordedFileSize");

	private static readonly IntPtr selSetMaximumRecordedFileSize_Handle = Selector.GetHandle("setMaximumRecordedFileSize:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selRecordToOutputFileURL_Handle = Selector.GetHandle("recordToOutputFileURL:");

	private static readonly IntPtr selRecordToOutputFileURLBufferDestination_Handle = Selector.GetHandle("recordToOutputFileURL:bufferDestination:");

	private static readonly IntPtr selPauseRecordingHandle = Selector.GetHandle("pauseRecording");

	private static readonly IntPtr selResumeRecordingHandle = Selector.GetHandle("resumeRecording");

	private static readonly IntPtr selCompressionOptionsForConnection_Handle = Selector.GetHandle("compressionOptionsForConnection:");

	private static readonly IntPtr selSetCompressionOptionsForConnection_Handle = Selector.GetHandle("setCompressionOptions:forConnection:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureFileOutput");

	private object __mt_OutputFileUrl_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl OutputFileUrl
	{
		[Export("outputFileURL")]
		get
		{
			return (NSUrl)(__mt_OutputFileUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileURLHandle)))));
		}
	}

	public virtual bool IsRecordingPaused
	{
		[Export("isRecordingPaused")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingPausedHandle);
		}
	}

	public virtual QTTime RecordedDuration
	{
		[Export("recordedDuration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selRecordedDurationHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selRecordedDurationHandle);
		}
	}

	public virtual ulong RecordedFileSize
	{
		[Export("recordedFileSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selRecordedFileSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRecordedFileSizeHandle);
		}
	}

	public virtual CGSize MaximumVideoSize
	{
		[Export("maximumVideoSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumVideoSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumVideoSizeHandle);
		}
		[Export("setMaximumVideoSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaximumVideoSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaximumVideoSize_Handle, value);
			}
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

	public virtual QTTime MaximumRecordedDuration
	{
		[Export("maximumRecordedDuration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selMaximumRecordedDurationHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selMaximumRecordedDurationHandle);
		}
		[Export("setMaximumRecordedDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_QTTime(base.Handle, selSetMaximumRecordedDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_QTTime(base.SuperHandle, selSetMaximumRecordedDuration_Handle, value);
			}
		}
	}

	public virtual ulong MaximumRecordedFileSize
	{
		[Export("maximumRecordedFileSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMaximumRecordedFileSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaximumRecordedFileSizeHandle);
		}
		[Export("setMaximumRecordedFileSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaximumRecordedFileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaximumRecordedFileSize_Handle, value);
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

	public QTCaptureFileOutputDelegate Delegate
	{
		get
		{
			return WeakDelegate as QTCaptureFileOutputDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public QTCaptureFileError ShouldChangeOutputFile
	{
		get
		{
			return EnsureQTCaptureFileOutputDelegate().shouldChangeOutputFile;
		}
		set
		{
			EnsureQTCaptureFileOutputDelegate().shouldChangeOutputFile = value;
		}
	}

	public event EventHandler<QTCaptureFileSampleEventArgs> DidOutputSampleBuffer
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didOutputSampleBuffer = (EventHandler<QTCaptureFileSampleEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.didOutputSampleBuffer, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didOutputSampleBuffer = (EventHandler<QTCaptureFileSampleEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.didOutputSampleBuffer, value);
		}
	}

	public event EventHandler<QTCaptureFileUrlEventArgs> WillStartRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.willStartRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.willStartRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.willStartRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.willStartRecording, value);
		}
	}

	public event EventHandler<QTCaptureFileUrlEventArgs> DidStartRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didStartRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.didStartRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didStartRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.didStartRecording, value);
		}
	}

	public event EventHandler<QTCaptureFileErrorEventArgs> MustChangeOutputFile
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.mustChangeOutputFile = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.mustChangeOutputFile, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.mustChangeOutputFile = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.mustChangeOutputFile, value);
		}
	}

	public event EventHandler<QTCaptureFileErrorEventArgs> WillFinishRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.willFinishRecording = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.willFinishRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.willFinishRecording = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.willFinishRecording, value);
		}
	}

	public event EventHandler<QTCaptureFileErrorEventArgs> DidFinishRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didFinishRecording = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.didFinishRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didFinishRecording = (EventHandler<QTCaptureFileErrorEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.didFinishRecording, value);
		}
	}

	public event EventHandler<QTCaptureFileUrlEventArgs> DidPauseRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didPauseRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.didPauseRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didPauseRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.didPauseRecording, value);
		}
	}

	public event EventHandler<QTCaptureFileUrlEventArgs> DidResumeRecording
	{
		add
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didResumeRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Combine(qTCaptureFileOutputDelegate.didResumeRecording, value);
		}
		remove
		{
			_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = EnsureQTCaptureFileOutputDelegate();
			qTCaptureFileOutputDelegate.didResumeRecording = (EventHandler<QTCaptureFileUrlEventArgs>)System.Delegate.Remove(qTCaptureFileOutputDelegate.didResumeRecording, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureFileOutput(NSCoder coder)
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
	public QTCaptureFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("recordToOutputFileURL:")]
	public virtual void RecordToOutputFile(NSUrl url)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRecordToOutputFileURL_Handle, url?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordToOutputFileURL_Handle, url?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("recordToOutputFileURL:bufferDestination:")]
	public virtual void RecordToOutputFile(NSUrl url, QTCaptureDestination bufferDestination)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selRecordToOutputFileURLBufferDestination_Handle, url?.Handle ?? IntPtr.Zero, (int)bufferDestination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selRecordToOutputFileURLBufferDestination_Handle, url?.Handle ?? IntPtr.Zero, (int)bufferDestination);
		}
	}

	[Export("pauseRecording")]
	public virtual void PauseRecording()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseRecordingHandle);
		}
	}

	[Export("resumeRecording")]
	public virtual void ResumeRecording()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeRecordingHandle);
		}
	}

	[Export("compressionOptionsForConnection:")]
	public virtual QTCompressionOptions GetCompressionOptions(QTCaptureConnection forConnection)
	{
		if (forConnection == null)
		{
			throw new ArgumentNullException("forConnection");
		}
		if (IsDirectBinding)
		{
			return (QTCompressionOptions)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompressionOptionsForConnection_Handle, forConnection.Handle));
		}
		return (QTCompressionOptions)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompressionOptionsForConnection_Handle, forConnection.Handle));
	}

	[Export("setCompressionOptions:forConnection:")]
	public virtual void SetCompressionOptions(QTCompressionOptions compressionOptions, QTCaptureConnection forConnection)
	{
		if (compressionOptions == null)
		{
			throw new ArgumentNullException("compressionOptions");
		}
		if (forConnection == null)
		{
			throw new ArgumentNullException("forConnection");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetCompressionOptionsForConnection_Handle, compressionOptions.Handle, forConnection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetCompressionOptionsForConnection_Handle, compressionOptions.Handle, forConnection.Handle);
		}
	}

	private _QTCaptureFileOutputDelegate EnsureQTCaptureFileOutputDelegate()
	{
		QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = Delegate;
		if (qTCaptureFileOutputDelegate == null || !(qTCaptureFileOutputDelegate is _QTCaptureFileOutputDelegate))
		{
			qTCaptureFileOutputDelegate = (Delegate = new _QTCaptureFileOutputDelegate());
		}
		return (_QTCaptureFileOutputDelegate)qTCaptureFileOutputDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OutputFileUrl_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
