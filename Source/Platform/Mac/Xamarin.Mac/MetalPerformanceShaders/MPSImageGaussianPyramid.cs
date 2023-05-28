using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageGaussianPyramid", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageGaussianPyramid : MPSImagePyramid
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelWidth_KernelHeight_Weights_ = "initWithDevice:kernelWidth:kernelHeight:weights:";

	private static readonly IntPtr selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle = Selector.GetHandle("initWithDevice:kernelWidth:kernelHeight:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageGaussianPyramid");

	public override IntPtr ClassHandle => class_ptr;

	[DesignatedInitializer]
	public unsafe MPSImageGaussianPyramid(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights)
		: base(NSObjectFlag.Empty)
	{
		if (kernelWeights == null)
		{
			throw new ArgumentNullException("kernelWeights");
		}
		fixed (float* ptr = kernelWeights)
		{
			InitializeHandle(InitWithDevice(device, kernelWidth, kernelHeight, (IntPtr)ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageGaussianPyramid(NSCoder coder)
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
	protected MPSImageGaussianPyramid(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageGaussianPyramid(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageGaussianPyramid(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:kernelWidth:kernelHeight:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual IntPtr InitWithDevice(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, IntPtr kernelWeights)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_IntPtr(base.Handle, selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle, device.Handle, kernelWidth, kernelHeight, kernelWeights);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_IntPtr(base.SuperHandle, selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle, device.Handle, kernelWidth, kernelHeight, kernelWeights);
	}
}
