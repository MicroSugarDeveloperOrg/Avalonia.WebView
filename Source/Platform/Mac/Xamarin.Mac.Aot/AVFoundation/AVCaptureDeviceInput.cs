using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDeviceInput", true)]
public class AVCaptureDeviceInput : AVCaptureInput
{
	private static NSError globalerr;

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	private static readonly IntPtr selDeviceInputWithDeviceError_Handle = Selector.GetHandle("deviceInputWithDevice:error:");

	private static readonly IntPtr selInitWithDeviceError_Handle = Selector.GetHandle("initWithDevice:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureDeviceInput");

	private object __mt_Device_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureDevice Device
	{
		[Export("device")]
		get
		{
			return (AVCaptureDevice)(__mt_Device_var = ((!IsDirectBinding) ? ((AVCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle))) : ((AVCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle)))));
		}
	}

	[Obsolete("Use FromDevice (AVCaptureDevice, ref NSError) instead")]
	public static AVCaptureDeviceInput FromDevice(AVCaptureDevice device, IntPtr handle)
	{
		NSError error;
		return FromDevice(device, out error);
	}

	public static AVCaptureDeviceInput FromDevice(AVCaptureDevice device)
	{
		NSError error;
		return FromDevice(device, out error);
	}

	[Obsolete("Use AVCaptureDeviceInput (AVCaptureDevice, ref NSError) instead")]
	public AVCaptureDeviceInput(AVCaptureDevice device, IntPtr handle)
		: this(device, out globalerr)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureDeviceInput(NSCoder coder)
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
	public AVCaptureDeviceInput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureDeviceInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("deviceInputWithDevice:error:")]
	public static AVCaptureDeviceInput FromDevice(AVCaptureDevice device, out NSError error)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		AVCaptureDeviceInput result = (AVCaptureDeviceInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDeviceInputWithDeviceError_Handle, device.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initWithDevice:error:")]
	public AVCaptureDeviceInput(AVCaptureDevice device, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDeviceError_Handle, device.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDeviceError_Handle, device.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Device_var = null;
		}
	}
}
