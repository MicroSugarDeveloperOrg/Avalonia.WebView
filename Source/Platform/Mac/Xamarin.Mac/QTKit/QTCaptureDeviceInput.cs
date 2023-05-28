using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDeviceInput", true)]
public class QTCaptureDeviceInput : QTCaptureInput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceInputWithDevice_ = "deviceInputWithDevice:";

	private static readonly IntPtr selDeviceInputWithDevice_Handle = Selector.GetHandle("deviceInputWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureDeviceInput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureDevice Device
	{
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle));
			}
			return Runtime.GetNSObject<QTCaptureDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureDeviceInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureDeviceInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTCaptureDeviceInput(QTCaptureDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("deviceInputWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTCaptureDeviceInput FromDevice(QTCaptureDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetNSObject<QTCaptureDeviceInput>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceInputWithDevice_Handle, device.Handle));
	}
}
