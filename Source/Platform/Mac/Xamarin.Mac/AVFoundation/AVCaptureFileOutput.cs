using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureFileOutput", true)]
public class AVCaptureFileOutput : AVCaptureOutput
{
	private static readonly IntPtr selRecordedDurationHandle = Selector.GetHandle("recordedDuration");

	private static readonly IntPtr selRecordedFileSizeHandle = Selector.GetHandle("recordedFileSize");

	private static readonly IntPtr selIsRecordingHandle = Selector.GetHandle("isRecording");

	private static readonly IntPtr selMaxRecordedDurationHandle = Selector.GetHandle("maxRecordedDuration");

	private static readonly IntPtr selSetMaxRecordedDuration_Handle = Selector.GetHandle("setMaxRecordedDuration:");

	private static readonly IntPtr selMaxRecordedFileSizeHandle = Selector.GetHandle("maxRecordedFileSize");

	private static readonly IntPtr selSetMaxRecordedFileSize_Handle = Selector.GetHandle("setMaxRecordedFileSize:");

	private static readonly IntPtr selMinFreeDiskSpaceLimitHandle = Selector.GetHandle("minFreeDiskSpaceLimit");

	private static readonly IntPtr selSetMinFreeDiskSpaceLimit_Handle = Selector.GetHandle("setMinFreeDiskSpaceLimit:");

	private static readonly IntPtr selOutputFileURLHandle = Selector.GetHandle("outputFileURL");

	private static readonly IntPtr selStartRecordingToOutputFileURLRecordingDelegate_Handle = Selector.GetHandle("startRecordingToOutputFileURL:recordingDelegate:");

	private static readonly IntPtr selStopRecordingHandle = Selector.GetHandle("stopRecording");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureFileOutput");

	private object __mt_OutputFileURL_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CMTime RecordedDuration
	{
		[Export("recordedDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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

	public virtual long RecordedFileSize
	{
		[Export("recordedFileSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selRecordedFileSizeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRecordedFileSizeHandle);
		}
	}

	public virtual bool Recording
	{
		[Export("isRecording")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingHandle);
		}
	}

	public virtual CMTime MaxRecordedDuration
	{
		[Export("maxRecordedDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMaxRecordedDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMaxRecordedDuration_Handle, value);
			}
		}
	}

	public virtual long MaxRecordedFileSize
	{
		[Export("maxRecordedFileSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxRecordedFileSizeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxRecordedFileSizeHandle);
		}
		[Export("setMaxRecordedFileSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxRecordedFileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxRecordedFileSize_Handle, value);
			}
		}
	}

	public virtual long MinFreeDiskSpaceLimit
	{
		[Export("minFreeDiskSpaceLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMinFreeDiskSpaceLimitHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMinFreeDiskSpaceLimitHandle);
		}
		[Export("setMinFreeDiskSpaceLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMinFreeDiskSpaceLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMinFreeDiskSpaceLimit_Handle, value);
			}
		}
	}

	public virtual NSUrl OutputFileURL
	{
		[Export("outputFileURL")]
		get
		{
			return (NSUrl)(__mt_OutputFileURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileURLHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureFileOutput(NSCoder coder)
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
	public AVCaptureFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startRecordingToOutputFileURL:recordingDelegate:")]
	public virtual void StartRecordingToOutputFile(NSUrl outputFileUrl, AVCaptureFileOutputRecordingDelegate recordingDelegate)
	{
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (recordingDelegate == null)
		{
			throw new ArgumentNullException("recordingDelegate");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartRecordingToOutputFileURLRecordingDelegate_Handle, outputFileUrl.Handle, recordingDelegate.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartRecordingToOutputFileURLRecordingDelegate_Handle, outputFileUrl.Handle, recordingDelegate.Handle);
		}
	}

	[Export("stopRecording")]
	public virtual void StopRecording()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopRecordingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopRecordingHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OutputFileURL_var = null;
		}
	}
}
