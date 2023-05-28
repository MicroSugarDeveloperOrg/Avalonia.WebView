using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDeviceInput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureDeviceInput : AVCaptureInput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceInputWithDevice_Error_ = "deviceInputWithDevice:error:";

	private static readonly IntPtr selDeviceInputWithDevice_Error_Handle = Selector.GetHandle("deviceInputWithDevice:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Error_ = "initWithDevice:error:";

	private static readonly IntPtr selInitWithDevice_Error_Handle = Selector.GetHandle("initWithDevice:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureDeviceInput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureDevice Device
	{
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle));
			}
			return Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle));
		}
	}

	public static AVCaptureDeviceInput FromDevice(AVCaptureDevice device)
	{
		NSError error;
		return FromDevice(device, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureDeviceInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureDeviceInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCaptureDeviceInput(AVCaptureDevice device, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithDevice_Error_Handle, device.Handle, ref arg), "initWithDevice:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDevice_Error_Handle, device.Handle, ref arg), "initWithDevice:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("deviceInputWithDevice:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDeviceInput? FromDevice(AVCaptureDevice device, out NSError error)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		AVCaptureDeviceInput nSObject = Runtime.GetNSObject<AVCaptureDeviceInput>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selDeviceInputWithDevice_Error_Handle, device.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
