using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDeviceInput", true)]
public class QTCaptureDeviceInput : QTCaptureInput
{
	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	private static readonly IntPtr selDeviceInputWithDevice_Handle = Selector.GetHandle("deviceInputWithDevice:");

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureDeviceInput");

	private object __mt_Device_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTCaptureDevice Device
	{
		[Export("device")]
		get
		{
			return (QTCaptureDevice)(__mt_Device_var = ((!IsDirectBinding) ? ((QTCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle))) : ((QTCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureDeviceInput(NSCoder coder)
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
	public QTCaptureDeviceInput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureDeviceInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("deviceInputWithDevice:")]
	public static QTCaptureDeviceInput FromDevice(QTCaptureDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return (QTCaptureDeviceInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceInputWithDevice_Handle, device.Handle));
	}

	[Export("initWithDevice:")]
	public QTCaptureDeviceInput(QTCaptureDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle);
		}
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
