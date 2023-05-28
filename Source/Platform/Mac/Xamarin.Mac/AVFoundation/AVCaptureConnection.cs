using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureConnection", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureConnection : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioChannels = "audioChannels";

	private static readonly IntPtr selAudioChannelsHandle = Selector.GetHandle("audioChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyAdjustsVideoMirroring = "automaticallyAdjustsVideoMirroring";

	private static readonly IntPtr selAutomaticallyAdjustsVideoMirroringHandle = Selector.GetHandle("automaticallyAdjustsVideoMirroring");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithInputPort_VideoPreviewLayer_ = "connectionWithInputPort:videoPreviewLayer:";

	private static readonly IntPtr selConnectionWithInputPort_VideoPreviewLayer_Handle = Selector.GetHandle("connectionWithInputPort:videoPreviewLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithInputPorts_Output_ = "connectionWithInputPorts:output:";

	private static readonly IntPtr selConnectionWithInputPorts_Output_Handle = Selector.GetHandle("connectionWithInputPorts:output:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInputPort_VideoPreviewLayer_ = "initWithInputPort:videoPreviewLayer:";

	private static readonly IntPtr selInitWithInputPort_VideoPreviewLayer_Handle = Selector.GetHandle("initWithInputPort:videoPreviewLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInputPorts_Output_ = "initWithInputPorts:output:";

	private static readonly IntPtr selInitWithInputPorts_Output_Handle = Selector.GetHandle("initWithInputPorts:output:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputPorts = "inputPorts";

	private static readonly IntPtr selInputPortsHandle = Selector.GetHandle("inputPorts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideoFieldModeSupported = "isVideoFieldModeSupported";

	private static readonly IntPtr selIsVideoFieldModeSupportedHandle = Selector.GetHandle("isVideoFieldModeSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideoMinFrameDurationSupported = "isVideoMinFrameDurationSupported";

	private static readonly IntPtr selIsVideoMinFrameDurationSupportedHandle = Selector.GetHandle("isVideoMinFrameDurationSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideoMirrored = "isVideoMirrored";

	private static readonly IntPtr selIsVideoMirroredHandle = Selector.GetHandle("isVideoMirrored");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideoMirroringSupported = "isVideoMirroringSupported";

	private static readonly IntPtr selIsVideoMirroringSupportedHandle = Selector.GetHandle("isVideoMirroringSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideoOrientationSupported = "isVideoOrientationSupported";

	private static readonly IntPtr selIsVideoOrientationSupportedHandle = Selector.GetHandle("isVideoOrientationSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutput = "output";

	private static readonly IntPtr selOutputHandle = Selector.GetHandle("output");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyAdjustsVideoMirroring_ = "setAutomaticallyAdjustsVideoMirroring:";

	private static readonly IntPtr selSetAutomaticallyAdjustsVideoMirroring_Handle = Selector.GetHandle("setAutomaticallyAdjustsVideoMirroring:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoFieldMode_ = "setVideoFieldMode:";

	private static readonly IntPtr selSetVideoFieldMode_Handle = Selector.GetHandle("setVideoFieldMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoMinFrameDuration_ = "setVideoMinFrameDuration:";

	private static readonly IntPtr selSetVideoMinFrameDuration_Handle = Selector.GetHandle("setVideoMinFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoMirrored_ = "setVideoMirrored:";

	private static readonly IntPtr selSetVideoMirrored_Handle = Selector.GetHandle("setVideoMirrored:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoOrientation_ = "setVideoOrientation:";

	private static readonly IntPtr selSetVideoOrientation_Handle = Selector.GetHandle("setVideoOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoFieldMode = "videoFieldMode";

	private static readonly IntPtr selVideoFieldModeHandle = Selector.GetHandle("videoFieldMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoMinFrameDuration = "videoMinFrameDuration";

	private static readonly IntPtr selVideoMinFrameDurationHandle = Selector.GetHandle("videoMinFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoOrientation = "videoOrientation";

	private static readonly IntPtr selVideoOrientationHandle = Selector.GetHandle("videoOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoPreviewLayer = "videoPreviewLayer";

	private static readonly IntPtr selVideoPreviewLayerHandle = Selector.GetHandle("videoPreviewLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureConnection");

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
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

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	public bool SupportsVideoMaxFrameDuration => false;

	[Obsolete("Use AvailableAudioChannels property instead.")]
	public virtual AVCaptureAudioChannel AudioChannels
	{
		get
		{
			throw new NotSupportedException("Use AvailableAudioChannels property instead.");
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticallyAdjustsVideoMirroring
	{
		[Export("automaticallyAdjustsVideoMirroring")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyAdjustsVideoMirroringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyAdjustsVideoMirroringHandle);
		}
		[Export("setAutomaticallyAdjustsVideoMirroring:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyAdjustsVideoMirroring_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyAdjustsVideoMirroring_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureAudioChannel[] AvailableAudioChannels
	{
		[Export("audioChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureAudioChannel>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioChannelsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureAudioChannel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioChannelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureInputPort[] InputPorts
	{
		[Export("inputPorts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputPortsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputPortsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureOutput? Output
	{
		[Export("output")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputHandle));
			}
			return Runtime.GetNSObject<AVCaptureOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public virtual bool SupportsVideoFieldMode
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("isVideoFieldModeSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoFieldModeSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoFieldModeSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsVideoMirroring
	{
		[Export("isVideoMirroringSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMirroringSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMirroringSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsVideoOrientation
	{
		[Export("isVideoOrientationSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoOrientationSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoOrientationSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoFieldMode VideoFieldMode
	{
		[Export("videoFieldMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVVideoFieldMode)Messaging.Int64_objc_msgSend(base.Handle, selVideoFieldModeHandle);
			}
			return (AVVideoFieldMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVideoFieldModeHandle);
		}
		[Export("setVideoFieldMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVideoFieldMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVideoFieldMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	public virtual CMTime VideoMinFrameDuration
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Export("videoMinFrameDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selVideoMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVideoMinFrameDurationHandle);
			}
			return retval;
		}
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Export("setVideoMinFrameDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetVideoMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetVideoMinFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VideoMirrored
	{
		[Export("isVideoMirrored")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMirroredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMirroredHandle);
		}
		[Export("setVideoMirrored:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVideoMirrored_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVideoMirrored_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureVideoOrientation VideoOrientation
	{
		[Export("videoOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureVideoOrientation)Messaging.Int64_objc_msgSend(base.Handle, selVideoOrientationHandle);
			}
			return (AVCaptureVideoOrientation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVideoOrientationHandle);
		}
		[Export("setVideoOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVideoOrientation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVideoOrientation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureVideoPreviewLayer? VideoPreviewLayer
	{
		[Export("videoPreviewLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureVideoPreviewLayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoPreviewLayerHandle));
			}
			return Runtime.GetNSObject<AVCaptureVideoPreviewLayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoPreviewLayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _SupportsVideoMinFrameDuration
	{
		[Export("isVideoMinFrameDurationSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoMinFrameDurationSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoMinFrameDurationSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureConnection()
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
	protected AVCaptureConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInputPorts:output:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCaptureConnection(AVCaptureInputPort[] inputPorts, AVCaptureOutput output)
		: base(NSObjectFlag.Empty)
	{
		if (inputPorts == null)
		{
			throw new ArgumentNullException("inputPorts");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		NSArray nSArray = NSArray.FromNSObjects(inputPorts);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithInputPorts_Output_Handle, nSArray.Handle, output.Handle), "initWithInputPorts:output:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithInputPorts_Output_Handle, nSArray.Handle, output.Handle), "initWithInputPorts:output:");
		}
		nSArray.Dispose();
	}

	[Export("initWithInputPort:videoPreviewLayer:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCaptureConnection(AVCaptureInputPort inputPort, AVCaptureVideoPreviewLayer layer)
		: base(NSObjectFlag.Empty)
	{
		if (inputPort == null)
		{
			throw new ArgumentNullException("inputPort");
		}
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithInputPort_VideoPreviewLayer_Handle, inputPort.Handle, layer.Handle), "initWithInputPort:videoPreviewLayer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithInputPort_VideoPreviewLayer_Handle, inputPort.Handle, layer.Handle), "initWithInputPort:videoPreviewLayer:");
		}
	}

	[Export("connectionWithInputPort:videoPreviewLayer:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureConnection FromInputPort(AVCaptureInputPort port, AVCaptureVideoPreviewLayer layer)
	{
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		return Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithInputPort_VideoPreviewLayer_Handle, port.Handle, layer.Handle));
	}

	[Export("connectionWithInputPorts:output:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureConnection FromInputPorts(AVCaptureInputPort[] ports, AVCaptureOutput output)
	{
		if (ports == null)
		{
			throw new ArgumentNullException("ports");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		NSArray nSArray = NSArray.FromNSObjects(ports);
		AVCaptureConnection nSObject = Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithInputPorts_Output_Handle, nSArray.Handle, output.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
