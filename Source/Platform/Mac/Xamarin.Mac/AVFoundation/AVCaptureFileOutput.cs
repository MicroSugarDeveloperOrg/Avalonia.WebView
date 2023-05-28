using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureFileOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureFileOutput : AVCaptureOutput
{
	private class recordingProxy : AVCaptureFileOutputRecordingDelegate
	{
		private Action<NSObject[]> startRecordingFromConnections;

		private Action<NSObject[], NSError> finishedRecording;

		public recordingProxy(Action<NSObject[]> startRecordingFromConnections, Action<NSObject[], NSError> finishedRecording)
		{
			this.startRecordingFromConnections = startRecordingFromConnections;
			this.finishedRecording = finishedRecording;
		}

		public override void DidStartRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
		{
			startRecordingFromConnections(connections);
		}

		public override void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError error)
		{
			finishedRecording(connections, error);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRecording = "isRecording";

	private static readonly IntPtr selIsRecordingHandle = Selector.GetHandle("isRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRecordingPaused = "isRecordingPaused";

	private static readonly IntPtr selIsRecordingPausedHandle = Selector.GetHandle("isRecordingPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxRecordedDuration = "maxRecordedDuration";

	private static readonly IntPtr selMaxRecordedDurationHandle = Selector.GetHandle("maxRecordedDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxRecordedFileSize = "maxRecordedFileSize";

	private static readonly IntPtr selMaxRecordedFileSizeHandle = Selector.GetHandle("maxRecordedFileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFreeDiskSpaceLimit = "minFreeDiskSpaceLimit";

	private static readonly IntPtr selMinFreeDiskSpaceLimitHandle = Selector.GetHandle("minFreeDiskSpaceLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFileURL = "outputFileURL";

	private static readonly IntPtr selOutputFileURLHandle = Selector.GetHandle("outputFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseRecording = "pauseRecording";

	private static readonly IntPtr selPauseRecordingHandle = Selector.GetHandle("pauseRecording");

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
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxRecordedDuration_ = "setMaxRecordedDuration:";

	private static readonly IntPtr selSetMaxRecordedDuration_Handle = Selector.GetHandle("setMaxRecordedDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxRecordedFileSize_ = "setMaxRecordedFileSize:";

	private static readonly IntPtr selSetMaxRecordedFileSize_Handle = Selector.GetHandle("setMaxRecordedFileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFreeDiskSpaceLimit_ = "setMinFreeDiskSpaceLimit:";

	private static readonly IntPtr selSetMinFreeDiskSpaceLimit_Handle = Selector.GetHandle("setMinFreeDiskSpaceLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartRecordingToOutputFileURL_RecordingDelegate_ = "startRecordingToOutputFileURL:recordingDelegate:";

	private static readonly IntPtr selStartRecordingToOutputFileURL_RecordingDelegate_Handle = Selector.GetHandle("startRecordingToOutputFileURL:recordingDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopRecording = "stopRecording";

	private static readonly IntPtr selStopRecordingHandle = Selector.GetHandle("stopRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureFileOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IAVCaptureFileOutputDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			IAVCaptureFileOutputDelegate iAVCaptureFileOutputDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IAVCaptureFileOutputDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<IAVCaptureFileOutputDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iAVCaptureFileOutputDelegate;
			return iAVCaptureFileOutputDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime MaxRecordedDuration
	{
		[Export("maxRecordedDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMaxRecordedDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaxRecordedDurationHandle);
			}
			return retval;
		}
		[Export("setMaxRecordedDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMaxRecordedDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMaxRecordedDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long MaxRecordedFileSize
	{
		[Export("maxRecordedFileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxRecordedFileSizeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxRecordedFileSizeHandle);
		}
		[Export("setMaxRecordedFileSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxRecordedFileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxRecordedFileSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long MinFreeDiskSpaceLimit
	{
		[Export("minFreeDiskSpaceLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMinFreeDiskSpaceLimitHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMinFreeDiskSpaceLimitHandle);
		}
		[Export("setMinFreeDiskSpaceLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMinFreeDiskSpaceLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMinFreeDiskSpaceLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? OutputFileURL
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
	public virtual CMTime RecordedDuration
	{
		[Export("recordedDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRecordedDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRecordedDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long RecordedFileSize
	{
		[Export("recordedFileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selRecordedFileSizeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRecordedFileSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Recording
	{
		[Export("isRecording")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RecordingPaused
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

	public void StartRecordingToOutputFile(NSUrl outputFileUrl, Action<NSObject[]> startRecordingFromConnections, Action<NSObject[], NSError> finishedRecording)
	{
		StartRecordingToOutputFile(outputFileUrl, new recordingProxy(startRecordingFromConnections, finishedRecording));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pauseRecording")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
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

	[Export("resumeRecording")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
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

	[Export("startRecordingToOutputFileURL:recordingDelegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartRecordingToOutputFile(NSUrl outputFileUrl, IAVCaptureFileOutputRecordingDelegate recordingDelegate)
	{
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (recordingDelegate != null)
		{
			if (!(recordingDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + recordingDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartRecordingToOutputFileURL_RecordingDelegate_Handle, outputFileUrl.Handle, recordingDelegate.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartRecordingToOutputFileURL_RecordingDelegate_Handle, outputFileUrl.Handle, recordingDelegate.Handle);
			}
			return;
		}
		throw new ArgumentNullException("recordingDelegate");
	}

	[Export("stopRecording")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopRecording()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopRecordingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
