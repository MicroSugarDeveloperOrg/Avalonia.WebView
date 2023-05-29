using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureConnection", true)]
public class AVCaptureConnection : NSObject
{
	private static readonly IntPtr selOutputHandle = Selector.GetHandle("output");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selAudioChannelsHandle = Selector.GetHandle("audioChannels");

	private static readonly IntPtr selIsVideoMirroredHandle = Selector.GetHandle("isVideoMirrored");

	private static readonly IntPtr selSetVideoMirrored_Handle = Selector.GetHandle("setVideoMirrored:");

	private static readonly IntPtr selVideoOrientationHandle = Selector.GetHandle("videoOrientation");

	private static readonly IntPtr selSetVideoOrientation_Handle = Selector.GetHandle("setVideoOrientation:");

	private static readonly IntPtr selInputPortsHandle = Selector.GetHandle("inputPorts");

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	private static readonly IntPtr selIsVideoMirroringSupportedHandle = Selector.GetHandle("isVideoMirroringSupported");

	private static readonly IntPtr selIsVideoOrientationSupportedHandle = Selector.GetHandle("isVideoOrientationSupported");

	private static readonly IntPtr selIsVideoMinFrameDurationSupportedHandle = Selector.GetHandle("isVideoMinFrameDurationSupported");

	private static readonly IntPtr selVideoMinFrameDurationHandle = Selector.GetHandle("videoMinFrameDuration");

	private static readonly IntPtr selSetVideoMinFrameDuration_Handle = Selector.GetHandle("setVideoMinFrameDuration:");

	private static readonly IntPtr selVideoPreviewLayerHandle = Selector.GetHandle("videoPreviewLayer");

	private static readonly IntPtr selAutomaticallyAdjustsVideoMirroringHandle = Selector.GetHandle("automaticallyAdjustsVideoMirroring");

	private static readonly IntPtr selSetAutomaticallyAdjustsVideoMirroring_Handle = Selector.GetHandle("setAutomaticallyAdjustsVideoMirroring:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureConnection");

	private object __mt_Output_var;

	private object __mt_AudioChannels_var;

	private object __mt_InputPorts_var;

	private object __mt_VideoPreviewLayer_var;

	public bool SupportsVideoMinFrameDuration
	{
		get
		{
			if (RespondsToSelector(new Selector("isVideoMinFrameDurationSupported")))
			{
				return _SupportsVideoMinFrameDuration;
			}
			return false;
		}
	}

	public bool SupportsVideoMaxFrameDuration => false;

	[Advice("Use InputPorts")]
	public AVCaptureInputPort[] inputPorts => InputPorts;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureOutput Output
	{
		[Export("output")]
		get
		{
			return (AVCaptureOutput)(__mt_Output_var = ((!IsDirectBinding) ? ((AVCaptureOutput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputHandle))) : ((AVCaptureOutput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputHandle)))));
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	public virtual AVCaptureAudioChannel AudioChannels
	{
		[Export("audioChannels")]
		get
		{
			return (AVCaptureAudioChannel)(__mt_AudioChannels_var = ((!IsDirectBinding) ? ((AVCaptureAudioChannel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioChannelsHandle))) : ((AVCaptureAudioChannel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioChannelsHandle)))));
		}
	}

	public virtual bool VideoMirrored
	{
		[Export("isVideoMirrored")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMirroredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMirroredHandle);
		}
		[Export("setVideoMirrored:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVideoMirrored_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVideoMirrored_Handle, value);
			}
		}
	}

	public virtual AVCaptureVideoOrientation VideoOrientation
	{
		[Export("videoOrientation")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureVideoOrientation)Messaging.int_objc_msgSend(base.Handle, selVideoOrientationHandle);
			}
			return (AVCaptureVideoOrientation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selVideoOrientationHandle);
		}
		[Export("setVideoOrientation:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetVideoOrientation_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetVideoOrientation_Handle, (int)value);
			}
		}
	}

	public virtual AVCaptureInputPort[] InputPorts
	{
		[Export("inputPorts")]
		get
		{
			return (AVCaptureInputPort[])(__mt_InputPorts_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputPortsHandle)) : NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputPortsHandle))));
		}
	}

	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	public virtual bool SupportsVideoMirroring
	{
		[Export("isVideoMirroringSupported")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMirroringSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMirroringSupportedHandle);
		}
	}

	public virtual bool SupportsVideoOrientation
	{
		[Export("isVideoOrientationSupported")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoOrientationSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoOrientationSupportedHandle);
		}
	}

	internal virtual bool _SupportsVideoMinFrameDuration
	{
		[Export("isVideoMinFrameDurationSupported")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMinFrameDurationSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMinFrameDurationSupportedHandle);
		}
	}

	public virtual CMTime VideoMinFrameDuration
	{
		[Export("videoMinFrameDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selVideoMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVideoMinFrameDurationHandle);
			}
			return retval;
		}
		[Export("setVideoMinFrameDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetVideoMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetVideoMinFrameDuration_Handle, value);
			}
		}
	}

	[Since(6, 0)]
	public virtual AVCaptureVideoPreviewLayer VideoPreviewLayer
	{
		[Export("videoPreviewLayer")]
		get
		{
			return (AVCaptureVideoPreviewLayer)(__mt_VideoPreviewLayer_var = ((!IsDirectBinding) ? ((AVCaptureVideoPreviewLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoPreviewLayerHandle))) : ((AVCaptureVideoPreviewLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoPreviewLayerHandle)))));
		}
	}

	[Since(6, 0)]
	public virtual bool AutomaticallyAdjustsVideoMirroring
	{
		[Export("automaticallyAdjustsVideoMirroring")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyAdjustsVideoMirroringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyAdjustsVideoMirroringHandle);
		}
		[Export("setAutomaticallyAdjustsVideoMirroring:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyAdjustsVideoMirroring_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyAdjustsVideoMirroring_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureConnection()
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
	public AVCaptureConnection(NSCoder coder)
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
	public AVCaptureConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureConnection(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Output_var = null;
			__mt_AudioChannels_var = null;
			__mt_InputPorts_var = null;
			__mt_VideoPreviewLayer_var = null;
		}
	}
}
