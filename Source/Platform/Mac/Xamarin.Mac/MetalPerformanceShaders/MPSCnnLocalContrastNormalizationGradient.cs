using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLocalContrastNormalizationGradient", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLocalContrastNormalizationGradient : MPSCnnGradientKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta = "beta";

	private static readonly IntPtr selBetaHandle = Selector.GetHandle("beta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelta = "delta";

	private static readonly IntPtr selDeltaHandle = Selector.GetHandle("delta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelWidth_KernelHeight_ = "initWithDevice:kernelWidth:kernelHeight:";

	private static readonly IntPtr selInitWithDevice_KernelWidth_KernelHeight_Handle = Selector.GetHandle("initWithDevice:kernelWidth:kernelHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selP0 = "p0";

	private static readonly IntPtr selP0Handle = Selector.GetHandle("p0");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPm = "pm";

	private static readonly IntPtr selPmHandle = Selector.GetHandle("pm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPs = "ps";

	private static readonly IntPtr selPsHandle = Selector.GetHandle("ps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBeta_ = "setBeta:";

	private static readonly IntPtr selSetBeta_Handle = Selector.GetHandle("setBeta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelta_ = "setDelta:";

	private static readonly IntPtr selSetDelta_Handle = Selector.GetHandle("setDelta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetP0_ = "setP0:";

	private static readonly IntPtr selSetP0_Handle = Selector.GetHandle("setP0:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPm_ = "setPm:";

	private static readonly IntPtr selSetPm_Handle = Selector.GetHandle("setPm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPs_ = "setPs:";

	private static readonly IntPtr selSetPs_Handle = Selector.GetHandle("setPs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLocalContrastNormalizationGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Beta
	{
		[Export("beta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBetaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBetaHandle);
		}
		[Export("setBeta:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBeta_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBeta_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Delta
	{
		[Export("delta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selDeltaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selDeltaHandle);
		}
		[Export("setDelta:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetDelta_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetDelta_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float P0
	{
		[Export("p0")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selP0Handle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selP0Handle);
		}
		[Export("setP0:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetP0_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetP0_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Pm
	{
		[Export("pm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPmHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPmHandle);
		}
		[Export("setPm:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPm_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPm_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Ps
	{
		[Export("ps")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPsHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPsHandle);
		}
		[Export("setPs:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPs_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPs_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnLocalContrastNormalizationGradient(NSCoder coder)
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
	protected MPSCnnLocalContrastNormalizationGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLocalContrastNormalizationGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:kernelWidth:kernelHeight:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLocalContrastNormalizationGradient(IMTLDevice device, nuint kernelWidth, nuint kernelHeight)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selInitWithDevice_KernelWidth_KernelHeight_Handle, device.Handle, kernelWidth, kernelHeight), "initWithDevice:kernelWidth:kernelHeight:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selInitWithDevice_KernelWidth_KernelHeight_Handle, device.Handle, kernelWidth, kernelHeight), "initWithDevice:kernelWidth:kernelHeight:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLocalContrastNormalizationGradient(NSCoder decoder, IMTLDevice device)
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
