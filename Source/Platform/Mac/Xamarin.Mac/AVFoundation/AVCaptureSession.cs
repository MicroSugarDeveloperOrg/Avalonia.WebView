using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureSession", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureSession : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidStartRunning(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartRunningNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidStartRunning(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartRunningNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidStopRunning(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStopRunningNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidStopRunning(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStopRunningNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveInterruptionEnded(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(InterruptionEndedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveInterruptionEnded(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(InterruptionEndedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRuntimeError(EventHandler<AVCaptureSessionRuntimeErrorEventArgs> handler)
		{
			EventHandler<AVCaptureSessionRuntimeErrorEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RuntimeErrorNotification, delegate(NSNotification notification)
			{
				handler2(null, new AVCaptureSessionRuntimeErrorEventArgs(notification));
			});
		}

		public static NSObject ObserveRuntimeError(NSObject objectToObserve, EventHandler<AVCaptureSessionRuntimeErrorEventArgs> handler)
		{
			EventHandler<AVCaptureSessionRuntimeErrorEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RuntimeErrorNotification, delegate(NSNotification notification)
			{
				handler2(null, new AVCaptureSessionRuntimeErrorEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasInterrupted(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasInterruptedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasInterrupted(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasInterruptedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddConnection_ = "addConnection:";

	private static readonly IntPtr selAddConnection_Handle = Selector.GetHandle("addConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddInput_ = "addInput:";

	private static readonly IntPtr selAddInput_Handle = Selector.GetHandle("addInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddInputWithNoConnections_ = "addInputWithNoConnections:";

	private static readonly IntPtr selAddInputWithNoConnections_Handle = Selector.GetHandle("addInputWithNoConnections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOutput_ = "addOutput:";

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOutputWithNoConnections_ = "addOutputWithNoConnections:";

	private static readonly IntPtr selAddOutputWithNoConnections_Handle = Selector.GetHandle("addOutputWithNoConnections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginConfiguration = "beginConfiguration";

	private static readonly IntPtr selBeginConfigurationHandle = Selector.GetHandle("beginConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddConnection_ = "canAddConnection:";

	private static readonly IntPtr selCanAddConnection_Handle = Selector.GetHandle("canAddConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddInput_ = "canAddInput:";

	private static readonly IntPtr selCanAddInput_Handle = Selector.GetHandle("canAddInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddOutput_ = "canAddOutput:";

	private static readonly IntPtr selCanAddOutput_Handle = Selector.GetHandle("canAddOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSetSessionPreset_ = "canSetSessionPreset:";

	private static readonly IntPtr selCanSetSessionPreset_Handle = Selector.GetHandle("canSetSessionPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitConfiguration = "commitConfiguration";

	private static readonly IntPtr selCommitConfigurationHandle = Selector.GetHandle("commitConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnections = "connections";

	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputs = "inputs";

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRunning = "isRunning";

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMasterClock = "masterClock";

	private static readonly IntPtr selMasterClockHandle = Selector.GetHandle("masterClock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputs = "outputs";

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveConnection_ = "removeConnection:";

	private static readonly IntPtr selRemoveConnection_Handle = Selector.GetHandle("removeConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveInput_ = "removeInput:";

	private static readonly IntPtr selRemoveInput_Handle = Selector.GetHandle("removeInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOutput_ = "removeOutput:";

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionPreset = "sessionPreset";

	private static readonly IntPtr selSessionPresetHandle = Selector.GetHandle("sessionPreset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSessionPreset_ = "setSessionPreset:";

	private static readonly IntPtr selSetSessionPreset_Handle = Selector.GetHandle("setSessionPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartRunning = "startRunning";

	private static readonly IntPtr selStartRunningHandle = Selector.GetHandle("startRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopRunning = "stopRunning";

	private static readonly IntPtr selStopRunningHandle = Selector.GetHandle("stopRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidStartRunningNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidStopRunningNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InterruptionEndedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset1280x720;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset1920x1080;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset320x240;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset352x288;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset3840x2160;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset640x480;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset960x540;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHigh;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetLow;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetMedium;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetPhoto;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetiFrame1280x720;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetiFrame960x540;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RuntimeErrorNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasInterruptedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual AVCaptureConnection[] Connections
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("connections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureInput[] Inputs
	{
		[Export("inputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual CMClock? MasterClock
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("masterClock")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMasterClockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selMasterClockHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMClock(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Running
	{
		[Export("isRunning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRunningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString SessionPreset
	{
		[Export("sessionPreset", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionPresetHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionPresetHandle));
		}
		[Export("setSessionPreset:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionPreset_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionPreset_Handle, value.Handle);
			}
		}
	}

	[Field("AVCaptureSessionDidStartRunningNotification", "AVFoundation")]
	[Advice("Use AVCaptureSession.Notifications.ObserveDidStartRunning helper method instead.")]
	public static NSString DidStartRunningNotification
	{
		get
		{
			if (_DidStartRunningNotification == null)
			{
				_DidStartRunningNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionDidStartRunningNotification");
			}
			return _DidStartRunningNotification;
		}
	}

	[Field("AVCaptureSessionDidStopRunningNotification", "AVFoundation")]
	[Advice("Use AVCaptureSession.Notifications.ObserveDidStopRunning helper method instead.")]
	public static NSString DidStopRunningNotification
	{
		get
		{
			if (_DidStopRunningNotification == null)
			{
				_DidStopRunningNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionDidStopRunningNotification");
			}
			return _DidStopRunningNotification;
		}
	}

	[Field("AVCaptureSessionErrorKey", "AVFoundation")]
	public static NSString ErrorKey
	{
		get
		{
			if (_ErrorKey == null)
			{
				_ErrorKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionErrorKey");
			}
			return _ErrorKey;
		}
	}

	[Field("AVCaptureSessionInterruptionEndedNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Advice("Use AVCaptureSession.Notifications.ObserveInterruptionEnded helper method instead.")]
	public static NSString InterruptionEndedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_InterruptionEndedNotification == null)
			{
				_InterruptionEndedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionInterruptionEndedNotification");
			}
			return _InterruptionEndedNotification;
		}
	}

	[Field("AVCaptureSessionPreset1280x720", "AVFoundation")]
	public static NSString Preset1280x720
	{
		get
		{
			if (_Preset1280x720 == null)
			{
				_Preset1280x720 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset1280x720");
			}
			return _Preset1280x720;
		}
	}

	[Field("AVCaptureSessionPreset1920x1080", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString Preset1920x1080
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_Preset1920x1080 == null)
			{
				_Preset1920x1080 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset1920x1080");
			}
			return _Preset1920x1080;
		}
	}

	[Field("AVCaptureSessionPreset320x240", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public static NSString Preset320x240
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		get
		{
			if (_Preset320x240 == null)
			{
				_Preset320x240 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset320x240");
			}
			return _Preset320x240;
		}
	}

	[Field("AVCaptureSessionPreset352x288", "AVFoundation")]
	public static NSString Preset352x288
	{
		get
		{
			if (_Preset352x288 == null)
			{
				_Preset352x288 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset352x288");
			}
			return _Preset352x288;
		}
	}

	[Field("AVCaptureSessionPreset3840x2160", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString Preset3840x2160
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Preset3840x2160 == null)
			{
				_Preset3840x2160 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset3840x2160");
			}
			return _Preset3840x2160;
		}
	}

	[Field("AVCaptureSessionPreset640x480", "AVFoundation")]
	public static NSString Preset640x480
	{
		get
		{
			if (_Preset640x480 == null)
			{
				_Preset640x480 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset640x480");
			}
			return _Preset640x480;
		}
	}

	[Field("AVCaptureSessionPreset960x540", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public static NSString Preset960x540
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		get
		{
			if (_Preset960x540 == null)
			{
				_Preset960x540 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPreset960x540");
			}
			return _Preset960x540;
		}
	}

	[Field("AVCaptureSessionPresetHigh", "AVFoundation")]
	public static NSString PresetHigh
	{
		get
		{
			if (_PresetHigh == null)
			{
				_PresetHigh = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetHigh");
			}
			return _PresetHigh;
		}
	}

	[Field("AVCaptureSessionPresetLow", "AVFoundation")]
	public static NSString PresetLow
	{
		get
		{
			if (_PresetLow == null)
			{
				_PresetLow = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetLow");
			}
			return _PresetLow;
		}
	}

	[Field("AVCaptureSessionPresetMedium", "AVFoundation")]
	public static NSString PresetMedium
	{
		get
		{
			if (_PresetMedium == null)
			{
				_PresetMedium = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetMedium");
			}
			return _PresetMedium;
		}
	}

	[Field("AVCaptureSessionPresetPhoto", "AVFoundation")]
	public static NSString PresetPhoto
	{
		get
		{
			if (_PresetPhoto == null)
			{
				_PresetPhoto = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetPhoto");
			}
			return _PresetPhoto;
		}
	}

	[Field("AVCaptureSessionPresetiFrame1280x720", "AVFoundation")]
	public static NSString PresetiFrame1280x720
	{
		get
		{
			if (_PresetiFrame1280x720 == null)
			{
				_PresetiFrame1280x720 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetiFrame1280x720");
			}
			return _PresetiFrame1280x720;
		}
	}

	[Field("AVCaptureSessionPresetiFrame960x540", "AVFoundation")]
	public static NSString PresetiFrame960x540
	{
		get
		{
			if (_PresetiFrame960x540 == null)
			{
				_PresetiFrame960x540 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionPresetiFrame960x540");
			}
			return _PresetiFrame960x540;
		}
	}

	[Field("AVCaptureSessionRuntimeErrorNotification", "AVFoundation")]
	[Advice("Use AVCaptureSession.Notifications.ObserveRuntimeError helper method instead.")]
	public static NSString RuntimeErrorNotification
	{
		get
		{
			if (_RuntimeErrorNotification == null)
			{
				_RuntimeErrorNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionRuntimeErrorNotification");
			}
			return _RuntimeErrorNotification;
		}
	}

	[Field("AVCaptureSessionWasInterruptedNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Advice("Use AVCaptureSession.Notifications.ObserveWasInterrupted helper method instead.")]
	public static NSString WasInterruptedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_WasInterruptedNotification == null)
			{
				_WasInterruptedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureSessionWasInterruptedNotification");
			}
			return _WasInterruptedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureSession()
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
	protected AVCaptureSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddConnection(AVCaptureConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConnection_Handle, connection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConnection_Handle, connection.Handle);
		}
	}

	[Export("addInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInput_Handle, input.Handle);
		}
	}

	[Export("addInputWithNoConnections:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddInputWithNoConnections(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInputWithNoConnections_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInputWithNoConnections_Handle, input.Handle);
		}
	}

	[Export("addOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
	}

	[Export("addOutputWithNoConnections:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOutputWithNoConnections(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutputWithNoConnections_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutputWithNoConnections_Handle, output.Handle);
		}
	}

	[Export("beginConfiguration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginConfiguration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginConfigurationHandle);
		}
	}

	[Export("canAddConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddConnection(AVCaptureConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddConnection_Handle, connection.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddConnection_Handle, connection.Handle);
	}

	[Export("canAddInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddInput_Handle, input.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddInput_Handle, input.Handle);
	}

	[Export("canAddOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddOutput_Handle, output.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddOutput_Handle, output.Handle);
	}

	[Export("canSetSessionPreset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanSetSessionPreset(NSString preset)
	{
		if (preset == null)
		{
			throw new ArgumentNullException("preset");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanSetSessionPreset_Handle, preset.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanSetSessionPreset_Handle, preset.Handle);
	}

	[Export("commitConfiguration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CommitConfiguration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCommitConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCommitConfigurationHandle);
		}
	}

	[Export("removeConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveConnection(AVCaptureConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveConnection_Handle, connection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveConnection_Handle, connection.Handle);
		}
	}

	[Export("removeInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveInput_Handle, input.Handle);
		}
	}

	[Export("removeOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOutput_Handle, output.Handle);
		}
	}

	[Export("startRunning")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartRunning()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartRunningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartRunningHandle);
		}
	}

	[Export("stopRunning")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopRunning()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopRunningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopRunningHandle);
		}
	}
}
