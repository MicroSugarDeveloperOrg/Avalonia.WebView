using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureSession", true)]
public class AVCaptureSession : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveRuntimeError(EventHandler<AVCaptureSessionRuntimeErrorEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(RuntimeErrorNotification, delegate(NSNotification notification)
			{
				handler(null, new AVCaptureSessionRuntimeErrorEventArgs(notification));
			});
		}

		public static NSObject ObserveDidStartRunning(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartRunningNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidStopRunning(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStopRunningNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selSessionPresetHandle = Selector.GetHandle("sessionPreset");

	private static readonly IntPtr selSetSessionPreset_Handle = Selector.GetHandle("setSessionPreset:");

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	private static readonly IntPtr selCanSetSessionPreset_Handle = Selector.GetHandle("canSetSessionPreset:");

	private static readonly IntPtr selCanAddInput_Handle = Selector.GetHandle("canAddInput:");

	private static readonly IntPtr selAddInput_Handle = Selector.GetHandle("addInput:");

	private static readonly IntPtr selRemoveInput_Handle = Selector.GetHandle("removeInput:");

	private static readonly IntPtr selCanAddOutput_Handle = Selector.GetHandle("canAddOutput:");

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	private static readonly IntPtr selBeginConfigurationHandle = Selector.GetHandle("beginConfiguration");

	private static readonly IntPtr selCommitConfigurationHandle = Selector.GetHandle("commitConfiguration");

	private static readonly IntPtr selStartRunningHandle = Selector.GetHandle("startRunning");

	private static readonly IntPtr selStopRunningHandle = Selector.GetHandle("stopRunning");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureSession");

	private object __mt_SessionPreset_var;

	private object __mt_Inputs_var;

	private object __mt_Outputs_var;

	private static NSString _PresetPhoto;

	private static NSString _PresetHigh;

	private static NSString _PresetMedium;

	private static NSString _PresetLow;

	private static NSString _Preset640x480;

	private static NSString _Preset1280x720;

	private static NSString _PresetiFrame960x540;

	private static NSString _PresetiFrame1280x720;

	private static NSString _Preset352x288;

	private static NSString _RuntimeErrorNotification;

	private static NSString _ErrorKey;

	private static NSString _DidStartRunningNotification;

	private static NSString _DidStopRunningNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSString SessionPreset
	{
		[Export("sessionPreset")]
		get
		{
			return (NSString)(__mt_SessionPreset_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionPresetHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionPresetHandle)))));
		}
		[Export("setSessionPreset:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionPreset_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionPreset_Handle, value.Handle);
			}
			__mt_SessionPreset_var = value;
		}
	}

	public virtual AVCaptureInput[] Inputs
	{
		[Export("inputs")]
		get
		{
			return (AVCaptureInput[])(__mt_Inputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCaptureInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle)) : NSArray.ArrayFromHandle<AVCaptureInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle))));
		}
	}

	public virtual AVCaptureOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			return (AVCaptureOutput[])(__mt_Outputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCaptureOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle)) : NSArray.ArrayFromHandle<AVCaptureOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle))));
		}
	}

	public virtual bool Running
	{
		[Export("isRunning")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRunningHandle);
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

	[Field("AVCaptureSessionRuntimeErrorNotification", "AVFoundation")]
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

	[Field("AVCaptureSessionDidStartRunningNotification", "AVFoundation")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureSession()
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
	public AVCaptureSession(NSCoder coder)
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
	public AVCaptureSession(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canSetSessionPreset:")]
	public virtual bool CanSetSessionPreset(NSString preset)
	{
		if (preset == null)
		{
			throw new ArgumentNullException("preset");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanSetSessionPreset_Handle, preset.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanSetSessionPreset_Handle, preset.Handle);
	}

	[Export("canAddInput:")]
	public virtual bool CanAddInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddInput_Handle, input.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddInput_Handle, input.Handle);
	}

	[Export("addInput:")]
	public virtual void AddInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInput_Handle, input.Handle);
		}
	}

	[Export("removeInput:")]
	public virtual void RemoveInput(AVCaptureInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveInput_Handle, input.Handle);
		}
	}

	[Export("canAddOutput:")]
	public virtual bool CanAddOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddOutput_Handle, output.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddOutput_Handle, output.Handle);
	}

	[Export("addOutput:")]
	public virtual void AddOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
	}

	[Export("removeOutput:")]
	public virtual void RemoveOutput(AVCaptureOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOutput_Handle, output.Handle);
		}
	}

	[Export("beginConfiguration")]
	public virtual void BeginConfiguration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginConfigurationHandle);
		}
	}

	[Export("commitConfiguration")]
	public virtual void CommitConfiguration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCommitConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCommitConfigurationHandle);
		}
	}

	[Export("startRunning")]
	public virtual void StartRunning()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartRunningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartRunningHandle);
		}
	}

	[Export("stopRunning")]
	public virtual void StopRunning()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopRunningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopRunningHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SessionPreset_var = null;
			__mt_Inputs_var = null;
			__mt_Outputs_var = null;
		}
	}
}
