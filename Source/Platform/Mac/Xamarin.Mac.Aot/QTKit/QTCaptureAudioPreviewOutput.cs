using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureAudioPreviewOutput", true)]
public class QTCaptureAudioPreviewOutput : QTCaptureOutput
{
	private static readonly IntPtr selOutputDeviceUniqueIDHandle = Selector.GetHandle("outputDeviceUniqueID");

	private static readonly IntPtr selSetOutputDeviceUniqueID_Handle = Selector.GetHandle("setOutputDeviceUniqueID:");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureAudioPreviewOutput");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string OutputDeviceUniqueID
	{
		[Export("outputDeviceUniqueID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputDeviceUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputDeviceUniqueIDHandle));
		}
		[Export("setOutputDeviceUniqueID:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputDeviceUniqueID_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputDeviceUniqueID_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureAudioPreviewOutput()
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
	public QTCaptureAudioPreviewOutput(NSCoder coder)
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
	public QTCaptureAudioPreviewOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureAudioPreviewOutput(IntPtr handle)
		: base(handle)
	{
	}
}
