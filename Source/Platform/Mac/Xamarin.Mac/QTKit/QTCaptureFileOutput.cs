using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureFileOutput", true)]
public class QTCaptureFileOutput : QTCaptureOutput
{
	[Register]
	internal class _QTCaptureFileOutputDelegate : NSObject, IQTCaptureFileOutputDelegate, INativeObject, IDisposable
	{
		internal EventHandler<QTCaptureFileErrorEventArgs>? didFinishRecording;

		internal EventHandler<QTCaptureFileSampleEventArgs>? didOutputSampleBuffer;

		internal EventHandler<QTCaptureFileUrlEventArgs>? didPauseRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs>? didResumeRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs>? didStartRecording;

		internal EventHandler<QTCaptureFileErrorEventArgs>? mustChangeOutputFile;

		internal QTCaptureFileError? shouldChangeOutputFile;

		internal EventHandler<QTCaptureFileErrorEventArgs>? willFinishRecording;

		internal EventHandler<QTCaptureFileUrlEventArgs>? willStartRecording;

		public _QTCaptureFileOutputDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
		public void DidFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = didFinishRecording;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didOutputSampleBuffer:fromConnection:")]
		public void DidOutputSampleBuffer(QTCaptureFileOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
		{
			EventHandler<QTCaptureFileSampleEventArgs> eventHandler = didOutputSampleBuffer;
			if (eventHandler != null)
			{
				QTCaptureFileSampleEventArgs e = new QTCaptureFileSampleEventArgs(sampleBuffer, connection);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didPauseRecordingToOutputFileAtURL:forConnections:")]
		public void DidPauseRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didPauseRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didResumeRecordingToOutputFileAtURL:forConnections:")]
		public void DidResumeRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didResumeRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:didStartRecordingToOutputFileAtURL:forConnections:")]
		public void DidStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = didStartRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:mustChangeOutputFileAtURL:forConnections:dueToError:")]
		public void MustChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = mustChangeOutputFile;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:shouldChangeOutputFileAtURL:forConnections:dueToError:")]
		public bool ShouldChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			return shouldChangeOutputFile?.Invoke(captureOutput, outputFileURL, connections, reason) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:willFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
		public void WillFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
		{
			EventHandler<QTCaptureFileErrorEventArgs> eventHandler = willFinishRecording;
			if (eventHandler != null)
			{
				QTCaptureFileErrorEventArgs e = new QTCaptureFileErrorEventArgs(outputFileURL, connections, reason);
				eventHandler(captureOutput, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("captureOutput:willStartRecordingToOutputFileAtURL:forConnections:")]
		public void WillStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
		{
			EventHandler<QTCaptureFileUrlEventArgs> eventHandler = willStartRecording;
			if (eventHandler != null)
			{
				QTCaptureFileUrlEventArgs e = new QTCaptureFileUrlEventArgs(fileUrl, connections);
				eventHandler(captureOutput, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressionOptionsForConnection_ = "compressionOptionsForConnection:";

	private static readonly IntPtr selCompressionOptionsForConnection_Handle = Selector.GetHandle("compressionOptionsForConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRecordingPaused = "isRecordingPaused";

	private static readonly IntPtr selIsRecordingPausedHandle = Selector.GetHandle("isRecordingPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRecordedDuration = "maximumRecordedDuration";

	private static readonly IntPtr selMaximumRecordedDurationHandle = Selector.GetHandle("maximumRecordedDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRecordedFileSize = "maximumRecordedFileSize";

	private static readonly IntPtr selMaximumRecordedFileSizeHandle = Selector.GetHandle("maximumRecordedFileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumVideoSize = "maximumVideoSize";

	private static readonly IntPtr selMaximumVideoSizeHandle = Selector.GetHandle("maximumVideoSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumVideoFrameInterval = "minimumVideoFrameInterval";

	private static readonly IntPtr selMinimumVideoFrameIntervalHandle = Selector.GetHandle("minimumVideoFrameInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFileURL = "outputFileURL";

	private static readonly IntPtr selOutputFileURLHandle = Selector.GetHandle("outputFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseRecording = "pauseRecording";

	private static readonly IntPtr selPauseRecordingHandle = Selector.GetHandle("pauseRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordToOutputFileURL_ = "recordToOutputFileURL:";

	private static readonly IntPtr selRecordToOutputFileURL_Handle = Selector.GetHandle("recordToOutputFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordToOutputFileURL_BufferDestination_ = "recordToOutputFileURL:bufferDestination:";

	private static readonly IntPtr selRecordToOutputFileURL_BufferDestination_Handle = Selector.GetHandle("recordToOutputFileURL:bufferDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordedDuration = "recordedDuration";

	private static readonly IntPtr selRecordedDurationHandle = Selector.GetHandle("recordedDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordedFileSize = "recordedFileSize";

	private static readonly IntPtr selRecordedFileSizeHandle = Selector.GetHandle("recordedFileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeRecording = "resumeRecording";

	private static readonly IntPtr selResumeRecordingHandle = Selector.GetHandle("resumeRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompressionOptions_ForConnection_ = "setCompressionOptions:forConnection:";

	private static readonly IntPtr selSetCompressionOptions_ForConnection_Handle = Selector.GetHandle("setCompressionOptions:forConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumRecordedDuration_ = "setMaximumRecordedDuration:";

	private static readonly IntPtr selSetMaximumRecordedDuration_Handle = Selector.GetHandle("setMaximumRecordedDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumRecordedFileSize_ = "setMaximumRecordedFileSize:";

	private static readonly IntPtr selSetMaximumRecordedFileSize_Handle = Selector.GetHandle("setMaximumRecordedFileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumVideoSize_ = "setMaximumVideoSize:";

	private static readonly IntPtr selSetMaximumVideoSize_Handle = Selector.GetHandle("setMaximumVideoSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumVideoFrameInterval_ = "setMinimumVideoFrameInterval:";

	private static readonly IntPtr selSetMinimumVideoFrameInterval_Handle = Selector.GetHandle("setMinimumVideoFrameInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureFileOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQTCaptureFileOutputDelegate Delegate
	{
		get
		{
			return WeakDelegate as IQTCaptureFileOutputDelegate;
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
	public virtual bool IsRecordingPaused
	{
		[Export("isRecordingPaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingPausedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime MaximumRecordedDuration
	{
		[Export("maximumRecordedDuration")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selMaximumRecordedDurationHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaximumRecordedDurationHandle);
			}
			return retval;
		}
		[Export("setMaximumRecordedDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_QTTime(base.Handle, selSetMaximumRecordedDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_QTTime(base.SuperHandle, selSetMaximumRecordedDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong MaximumRecordedFileSize
	{
		[Export("maximumRecordedFileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMaximumRecordedFileSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaximumRecordedFileSizeHandle);
		}
		[Export("setMaximumRecordedFileSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaximumRecordedFileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaximumRecordedFileSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaximumVideoSize
	{
		[Export("maximumVideoSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumVideoSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumVideoSizeHandle);
		}
		[Export("setMaximumVideoSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaximumVideoSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaximumVideoSize_Handle, value);
			}
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
	public virtual NSUrl OutputFileUrl
	{
		[Export("outputFileURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime RecordedDuration
	{
		[Export("recordedDuration")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selRecordedDurationHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRecordedDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong RecordedFileSize
	{
		[Export("recordedFileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selRecordedFileSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRecordedFileSizeHandle);
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

	internal virtual Type GetInternalEventDelegateType => typeof(_QTCaptureFileOutputDelegate);

	public QTCaptureFileError? ShouldChangeOutputFile
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compressionOptionsForConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCompressionOptions GetCompressionOptions(QTCaptureConnection forConnection)
	{
		if (forConnection == null)
		{
			throw new ArgumentNullException("forConnection");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<QTCompressionOptions>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompressionOptionsForConnection_Handle, forConnection.Handle));
		}
		return Runtime.GetNSObject<QTCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompressionOptionsForConnection_Handle, forConnection.Handle));
	}

	[Export("pauseRecording")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseRecording()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseRecordingHandle);
		}
	}

	[Export("recordToOutputFileURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RecordToOutputFile(NSUrl? url)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRecordToOutputFileURL_Handle, (url == null) ? IntPtr.Zero : url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordToOutputFileURL_Handle, (url == null) ? IntPtr.Zero : url.Handle);
		}
	}

	[Export("recordToOutputFileURL:bufferDestination:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RecordToOutputFile(NSUrl? url, QTCaptureDestination bufferDestination)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selRecordToOutputFileURL_BufferDestination_Handle, (url == null) ? IntPtr.Zero : url.Handle, (ulong)bufferDestination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selRecordToOutputFileURL_BufferDestination_Handle, (url == null) ? IntPtr.Zero : url.Handle, (ulong)bufferDestination);
		}
	}

	[Export("resumeRecording")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeRecording()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeRecordingHandle);
		}
	}

	[Export("setCompressionOptions:forConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetCompressionOptions_ForConnection_Handle, compressionOptions.Handle, forConnection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetCompressionOptions_ForConnection_Handle, compressionOptions.Handle, forConnection.Handle);
		}
	}

	internal virtual _QTCaptureFileOutputDelegate CreateInternalEventDelegateType()
	{
		return new _QTCaptureFileOutputDelegate();
	}

	internal _QTCaptureFileOutputDelegate EnsureQTCaptureFileOutputDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_QTCaptureFileOutputDelegate qTCaptureFileOutputDelegate = Delegate as _QTCaptureFileOutputDelegate;
		if (qTCaptureFileOutputDelegate == null)
		{
			qTCaptureFileOutputDelegate = (_QTCaptureFileOutputDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return qTCaptureFileOutputDelegate;
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
