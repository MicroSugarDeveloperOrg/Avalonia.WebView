using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNFullyConnected", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSCnnFullyConnected : MPSCnnConvolution
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_ = "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:";

	private static readonly IntPtr selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle = Selector.GetHandle("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Weights_ = "initWithDevice:weights:";

	private static readonly IntPtr selInitWithDevice_Weights_Handle = Selector.GetHandle("initWithDevice:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNFullyConnected");

	public override IntPtr ClassHandle => class_ptr;

	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use any of the other 'DesignatedInitializer' ctors.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use any of the other 'DesignatedInitializer' ctors.")]
	public unsafe MPSCnnFullyConnected(IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, float[] kernelWeights, float[] biasTerms, MPSCnnConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		if (kernelWeights == null)
		{
			throw new ArgumentNullException("kernelWeights");
		}
		fixed (float* ptr = kernelWeights)
		{
			fixed (float* ptr2 = biasTerms)
			{
				InitializeHandle(InitWithDevice(device, convolutionDescriptor, (IntPtr)ptr, (IntPtr)ptr2, flags), "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnFullyConnected(NSCoder coder)
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
	protected MPSCnnFullyConnected(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnFullyConnected(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnFullyConnected(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:weights:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnFullyConnected(IMTLDevice device, IMPSCnnConvolutionDataSource weights)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_Weights_Handle, device.Handle, weights.Handle), "initWithDevice:weights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_Weights_Handle, device.Handle, weights.Handle), "initWithDevice:weights:");
		}
	}

	[Export("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual IntPtr InitWithDevice(IMTLDevice device, MPSCnnConvolutionDescriptor fullyConnectedDescriptor, IntPtr kernelWeights, IntPtr biasTerms, MPSCnnConvolutionFlags flags)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (fullyConnectedDescriptor == null)
		{
			throw new ArgumentNullException("fullyConnectedDescriptor");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle, device.Handle, fullyConnectedDescriptor.Handle, kernelWeights, biasTerms, (ulong)flags);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle, device.Handle, fullyConnectedDescriptor.Handle, kernelWeights, biasTerms, (ulong)flags);
	}
}
