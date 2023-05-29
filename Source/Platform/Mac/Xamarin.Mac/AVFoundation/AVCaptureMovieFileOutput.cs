using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureMovieFileOutput", true)]
public class AVCaptureMovieFileOutput : AVCaptureFileOutput
{
	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	private static readonly IntPtr selMovieFragmentIntervalHandle = Selector.GetHandle("movieFragmentInterval");

	private static readonly IntPtr selSetMovieFragmentInterval_Handle = Selector.GetHandle("setMovieFragmentInterval:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureMovieFileOutput");

	private object __mt_Metadata_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVMetadataItem[] Metadata
	{
		[Export("metadata")]
		get
		{
			return (AVMetadataItem[])(__mt_Metadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle))));
		}
		[Export("setMetadata:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Metadata_var = value;
		}
	}

	public virtual CMTime MovieFragmentInterval
	{
		[Export("movieFragmentInterval")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMovieFragmentIntervalHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMovieFragmentIntervalHandle);
			}
			return retval;
		}
		[Export("setMovieFragmentInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMovieFragmentInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMovieFragmentInterval_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureMovieFileOutput()
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
	public AVCaptureMovieFileOutput(NSCoder coder)
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
	public AVCaptureMovieFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureMovieFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Metadata_var = null;
		}
	}
}
