using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNDropout", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnDropout : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KeepProbability_Seed_MaskStrideInPixels_ = "initWithDevice:keepProbability:seed:maskStrideInPixels:";

	private static readonly IntPtr selInitWithDevice_KeepProbability_Seed_MaskStrideInPixels_Handle = Selector.GetHandle("initWithDevice:keepProbability:seed:maskStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeepProbability = "keepProbability";

	private static readonly IntPtr selKeepProbabilityHandle = Selector.GetHandle("keepProbability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskStrideInPixels = "maskStrideInPixels";

	private static readonly IntPtr selMaskStrideInPixelsHandle = Selector.GetHandle("maskStrideInPixels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDropout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float KeepProbability
	{
		[Export("keepProbability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selKeepProbabilityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selKeepProbabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize MaskStrideInPixels
	{
		[Export("maskStrideInPixels")]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selMaskStrideInPixelsHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaskStrideInPixelsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnDropout(NSCoder coder)
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
	protected MPSCnnDropout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDropout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropout(NSCoder decoder, IMTLDevice device)
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

	[Export("initWithDevice:keepProbability:seed:maskStrideInPixels:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropout(IMTLDevice device, float keepProbability, nuint seed, MTLSize maskStrideInPixels)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_nuint_MTLSize(base.Handle, selInitWithDevice_KeepProbability_Seed_MaskStrideInPixels_Handle, device.Handle, keepProbability, seed, maskStrideInPixels), "initWithDevice:keepProbability:seed:maskStrideInPixels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_nuint_MTLSize(base.SuperHandle, selInitWithDevice_KeepProbability_Seed_MaskStrideInPixels_Handle, device.Handle, keepProbability, seed, maskStrideInPixels), "initWithDevice:keepProbability:seed:maskStrideInPixels:");
		}
	}
}
