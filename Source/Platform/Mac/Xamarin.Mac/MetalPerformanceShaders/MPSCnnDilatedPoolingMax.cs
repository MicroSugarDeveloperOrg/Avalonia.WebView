using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNDilatedPoolingMax", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnDilatedPoolingMax : MPSCnnPooling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelWidth_KernelHeight_DilationRateX_DilationRateY_StrideInPixelsX_StrideInPixelsY_ = "initWithDevice:kernelWidth:kernelHeight:dilationRateX:dilationRateY:strideInPixelsX:strideInPixelsY:";

	private static readonly IntPtr selInitWithDevice_KernelWidth_KernelHeight_DilationRateX_DilationRateY_StrideInPixelsX_StrideInPixelsY_Handle = Selector.GetHandle("initWithDevice:kernelWidth:kernelHeight:dilationRateX:dilationRateY:strideInPixelsX:strideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDilatedPoolingMax");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nuint DilationRateX
	{
		[Export("dilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nuint DilationRateY
	{
		[Export("dilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnDilatedPoolingMax(NSCoder coder)
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
	protected MPSCnnDilatedPoolingMax(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDilatedPoolingMax(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:kernelWidth:kernelHeight:dilationRateX:dilationRateY:strideInPixelsX:strideInPixelsY:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMax(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, nuint dilationRateX, nuint dilationRateY, nuint strideInPixelsX, nuint strideInPixelsY)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.Handle, selInitWithDevice_KernelWidth_KernelHeight_DilationRateX_DilationRateY_StrideInPixelsX_StrideInPixelsY_Handle, device.Handle, kernelWidth, kernelHeight, dilationRateX, dilationRateY, strideInPixelsX, strideInPixelsY), "initWithDevice:kernelWidth:kernelHeight:dilationRateX:dilationRateY:strideInPixelsX:strideInPixelsY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.SuperHandle, selInitWithDevice_KernelWidth_KernelHeight_DilationRateX_DilationRateY_StrideInPixelsX_StrideInPixelsY_Handle, device.Handle, kernelWidth, kernelHeight, dilationRateX, dilationRateY, strideInPixelsX, strideInPixelsY), "initWithDevice:kernelWidth:kernelHeight:dilationRateX:dilationRateY:strideInPixelsX:strideInPixelsY:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMax(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}
}
