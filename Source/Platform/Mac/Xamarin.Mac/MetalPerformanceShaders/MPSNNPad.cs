using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNPad", true)]
[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
public class MPSNNPad : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillValue = "fillValue";

	private static readonly IntPtr selFillValueHandle = Selector.GetHandle("fillValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_ = "initWithDevice:paddingSizeBefore:paddingSizeAfter:";

	private static readonly IntPtr selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_Handle = Selector.GetHandle("initWithDevice:paddingSizeBefore:paddingSizeAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_FillValueArray_ = "initWithDevice:paddingSizeBefore:paddingSizeAfter:fillValueArray:";

	private static readonly IntPtr selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_FillValueArray_Handle = Selector.GetHandle("initWithDevice:paddingSizeBefore:paddingSizeAfter:fillValueArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingSizeAfter = "paddingSizeAfter";

	private static readonly IntPtr selPaddingSizeAfterHandle = Selector.GetHandle("paddingSizeAfter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingSizeBefore = "paddingSizeBefore";

	private static readonly IntPtr selPaddingSizeBeforeHandle = Selector.GetHandle("paddingSizeBefore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillValue_ = "setFillValue:";

	private static readonly IntPtr selSetFillValue_Handle = Selector.GetHandle("setFillValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaddingSizeAfter_ = "setPaddingSizeAfter:";

	private static readonly IntPtr selSetPaddingSizeAfter_Handle = Selector.GetHandle("setPaddingSizeAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaddingSizeBefore_ = "setPaddingSizeBefore:";

	private static readonly IntPtr selSetPaddingSizeBefore_Handle = Selector.GetHandle("setPaddingSizeBefore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNPad");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FillValue
	{
		[Export("fillValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFillValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFillValueHandle);
		}
		[Export("setFillValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFillValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFillValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageCoordinate PaddingSizeAfter
	{
		[Export("paddingSizeAfter", ArgumentSemantic.Assign)]
		get
		{
			MPSImageCoordinate retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSImageCoordinate_objc_msgSend_stret(out retval, base.Handle, selPaddingSizeAfterHandle);
			}
			else
			{
				Messaging.MPSImageCoordinate_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPaddingSizeAfterHandle);
			}
			return retval;
		}
		[Export("setPaddingSizeAfter:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSImageCoordinate(base.Handle, selSetPaddingSizeAfter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSImageCoordinate(base.SuperHandle, selSetPaddingSizeAfter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageCoordinate PaddingSizeBefore
	{
		[Export("paddingSizeBefore", ArgumentSemantic.Assign)]
		get
		{
			MPSImageCoordinate retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSImageCoordinate_objc_msgSend_stret(out retval, base.Handle, selPaddingSizeBeforeHandle);
			}
			else
			{
				Messaging.MPSImageCoordinate_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPaddingSizeBeforeHandle);
			}
			return retval;
		}
		[Export("setPaddingSizeBefore:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSImageCoordinate(base.Handle, selSetPaddingSizeBefore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSImageCoordinate(base.SuperHandle, selSetPaddingSizeBefore_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNPad(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNPad(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNPad(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPad(IMTLDevice device)
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

	[Export("initWithDevice:paddingSizeBefore:paddingSizeAfter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPad(IMTLDevice device, MPSImageCoordinate paddingSizeBefore, MPSImageCoordinate paddingSizeAfter)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MPSImageCoordinate_MPSImageCoordinate(base.Handle, selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_Handle, device.Handle, paddingSizeBefore, paddingSizeAfter), "initWithDevice:paddingSizeBefore:paddingSizeAfter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MPSImageCoordinate_MPSImageCoordinate(base.SuperHandle, selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_Handle, device.Handle, paddingSizeBefore, paddingSizeAfter), "initWithDevice:paddingSizeBefore:paddingSizeAfter:");
		}
	}

	[Export("initWithDevice:paddingSizeBefore:paddingSizeAfter:fillValueArray:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPad(IMTLDevice device, MPSImageCoordinate paddingSizeBefore, MPSImageCoordinate paddingSizeAfter, NSData? fillValueArray)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MPSImageCoordinate_MPSImageCoordinate_IntPtr(base.Handle, selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_FillValueArray_Handle, device.Handle, paddingSizeBefore, paddingSizeAfter, fillValueArray?.Handle ?? IntPtr.Zero), "initWithDevice:paddingSizeBefore:paddingSizeAfter:fillValueArray:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MPSImageCoordinate_MPSImageCoordinate_IntPtr(base.SuperHandle, selInitWithDevice_PaddingSizeBefore_PaddingSizeAfter_FillValueArray_Handle, device.Handle, paddingSizeBefore, paddingSizeAfter, fillValueArray?.Handle ?? IntPtr.Zero), "initWithDevice:paddingSizeBefore:paddingSizeAfter:fillValueArray:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPad(NSCoder decoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (decoder == null)
		{
			throw new ArgumentNullException("decoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}
}
