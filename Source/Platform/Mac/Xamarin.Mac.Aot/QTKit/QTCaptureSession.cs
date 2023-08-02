using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureSession", true)]
public class QTCaptureSession : NSObject
{
	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	private static readonly IntPtr selAddInputError_Handle = Selector.GetHandle("addInput:error:");

	private static readonly IntPtr selRemoveInput_Handle = Selector.GetHandle("removeInput:");

	private static readonly IntPtr selAddOutputError_Handle = Selector.GetHandle("addOutput:error:");

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	private static readonly IntPtr selStartRunningHandle = Selector.GetHandle("startRunning");

	private static readonly IntPtr selStopRunningHandle = Selector.GetHandle("stopRunning");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureSession");

	private object __mt_Inputs_var;

	private object __mt_Outputs_var;

	private static NSString _RuntimeErrorNotification;

	private static NSString _ErrorKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTCaptureInput[] Inputs
	{
		[Export("inputs")]
		get
		{
			return (QTCaptureInput[])(__mt_Inputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTCaptureInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle)) : NSArray.ArrayFromHandle<QTCaptureInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle))));
		}
	}

	public virtual QTCaptureOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			return (QTCaptureOutput[])(__mt_Outputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTCaptureOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle)) : NSArray.ArrayFromHandle<QTCaptureOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle))));
		}
	}

	public virtual bool IsRunning
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

	[Field("QTCaptureSessionRuntimeErrorNotification", "QTKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureSession()
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
	public QTCaptureSession(NSCoder coder)
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
	public QTCaptureSession(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addInput:error:")]
	public virtual bool AddInput(QTCaptureInput input, out NSError error)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddInputError_Handle, input.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddInputError_Handle, input.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeInput:")]
	public virtual void RemoveInput(QTCaptureInput input)
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

	[Export("addOutput:error:")]
	public virtual bool AddOutput(QTCaptureOutput output, out NSError error)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddOutputError_Handle, output.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddOutputError_Handle, output.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeOutput:")]
	public virtual void RemoveOutput(QTCaptureOutput output)
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
			__mt_Inputs_var = null;
			__mt_Outputs_var = null;
		}
	}
}
