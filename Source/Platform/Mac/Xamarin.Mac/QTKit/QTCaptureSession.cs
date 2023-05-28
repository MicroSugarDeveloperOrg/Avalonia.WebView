using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureSession", true)]
public class QTCaptureSession : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveRuntimeError(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RuntimeErrorNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRuntimeError(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RuntimeErrorNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddInput_Error_ = "addInput:error:";

	private static readonly IntPtr selAddInput_Error_Handle = Selector.GetHandle("addInput:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOutput_Error_ = "addOutput:error:";

	private static readonly IntPtr selAddOutput_Error_Handle = Selector.GetHandle("addOutput:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputs = "inputs";

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRunning = "isRunning";

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputs = "outputs";

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveInput_ = "removeInput:";

	private static readonly IntPtr selRemoveInput_Handle = Selector.GetHandle("removeInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOutput_ = "removeOutput:";

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartRunning = "startRunning";

	private static readonly IntPtr selStartRunningHandle = Selector.GetHandle("startRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopRunning = "stopRunning";

	private static readonly IntPtr selStopRunningHandle = Selector.GetHandle("stopRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RuntimeErrorNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureInput[] Inputs
	{
		[Export("inputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTCaptureInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle));
			}
			return NSArray.ArrayFromHandle<QTCaptureInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRunning
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
	public virtual QTCaptureOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTCaptureOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle));
			}
			return NSArray.ArrayFromHandle<QTCaptureOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle));
		}
	}

	[Field("QTCaptureSessionErrorKey", "QTKit")]
	public static NSString ErrorKey
	{
		get
		{
			if (_ErrorKey == null)
			{
				_ErrorKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureSessionErrorKey");
			}
			return _ErrorKey;
		}
	}

	[Field("QTCaptureSessionRuntimeErrorNotification", "QTKit")]
	[Advice("Use QTCaptureSession.Notifications.ObserveRuntimeError helper method instead.")]
	public static NSString RuntimeErrorNotification
	{
		get
		{
			if (_RuntimeErrorNotification == null)
			{
				_RuntimeErrorNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureSessionRuntimeErrorNotification");
			}
			return _RuntimeErrorNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureSession()
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
	protected QTCaptureSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addInput:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddInput(QTCaptureInput input, out NSError error)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selAddInput_Error_Handle, input.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selAddInput_Error_Handle, input.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("addOutput:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddOutput(QTCaptureOutput output, out NSError error)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selAddOutput_Error_Handle, output.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selAddOutput_Error_Handle, output.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveInput(QTCaptureInput input)
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
	public virtual void RemoveOutput(QTCaptureOutput output)
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
