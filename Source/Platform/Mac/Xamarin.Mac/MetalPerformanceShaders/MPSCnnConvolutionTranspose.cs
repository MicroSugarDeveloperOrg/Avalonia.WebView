using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionTranspose", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionTranspose : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccumulatorPrecisionOption = "accumulatorPrecisionOption";

	private static readonly IntPtr selAccumulatorPrecisionOptionHandle = Selector.GetHandle("accumulatorPrecisionOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_ = "encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_ = "encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_ = "encodeToCommandBuffer:sourceImage:convolutionGradientState:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:convolutionGradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_ = "encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_ConvolutionState_ = "encodeToCommandBuffer:sourceImage:convolutionState:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_ConvolutionState_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:convolutionState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroups = "groups";

	private static readonly IntPtr selGroupsHandle = Selector.GetHandle("groups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Weights_ = "initWithDevice:weights:";

	private static readonly IntPtr selInitWithDevice_Weights_Handle = Selector.GetHandle("initWithDevice:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFeatureChannels = "inputFeatureChannels";

	private static readonly IntPtr selInputFeatureChannelsHandle = Selector.GetHandle("inputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelOffsetX = "kernelOffsetX";

	private static readonly IntPtr selKernelOffsetXHandle = Selector.GetHandle("kernelOffsetX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelOffsetY = "kernelOffsetY";

	private static readonly IntPtr selKernelOffsetYHandle = Selector.GetHandle("kernelOffsetY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFeatureChannels = "outputFeatureChannels";

	private static readonly IntPtr selOutputFeatureChannelsHandle = Selector.GetHandle("outputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccumulatorPrecisionOption_ = "setAccumulatorPrecisionOption:";

	private static readonly IntPtr selSetAccumulatorPrecisionOption_Handle = Selector.GetHandle("setAccumulatorPrecisionOption:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelOffsetX_ = "setKernelOffsetX:";

	private static readonly IntPtr selSetKernelOffsetX_Handle = Selector.GetHandle("setKernelOffsetX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelOffsetY_ = "setKernelOffsetY:";

	private static readonly IntPtr selSetKernelOffsetY_Handle = Selector.GetHandle("setKernelOffsetY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionTranspose");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSNNConvolutionAccumulatorPrecisionOption AccumulatorPrecisionOption
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("accumulatorPrecisionOption", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSend(base.Handle, selAccumulatorPrecisionOptionHandle);
			}
			return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAccumulatorPrecisionOptionHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setAccumulatorPrecisionOption:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAccumulatorPrecisionOption_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAccumulatorPrecisionOption_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Groups
	{
		[Export("groups")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selGroupsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selGroupsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint InputFeatureChannels
	{
		[Export("inputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selInputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selInputFeatureChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint KernelOffsetX
	{
		[Export("kernelOffsetX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selKernelOffsetXHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selKernelOffsetXHandle);
		}
		[Export("setKernelOffsetX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetKernelOffsetX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetKernelOffsetX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint KernelOffsetY
	{
		[Export("kernelOffsetY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selKernelOffsetYHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selKernelOffsetYHandle);
		}
		[Export("setKernelOffsetY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetKernelOffsetY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetKernelOffsetY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint OutputFeatureChannels
	{
		[Export("outputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOutputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOutputFeatureChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnConvolutionTranspose(NSCoder coder)
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
	protected MPSCnnConvolutionTranspose(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionTranspose(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:weights:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionTranspose(IMTLDevice device, IMPSCnnConvolutionDataSource weights)
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

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionTranspose(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, MPSCnnConvolutionGradientState[]? convolutionGradientState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		NSArray nSArray = ((convolutionGradientState == null) ? null : NSArray.FromNSObjects(convolutionGradientState));
		NSArray<MPSImage> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, MPSCnnConvolutionGradientState[]? convolutionGradientState, NSArray<MPSImage> destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		NSArray nSArray = ((convolutionGradientState == null) ? null : NSArray.FromNSObjects(convolutionGradientState));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle);
		}
		nSArray?.Dispose();
	}

	[Export("encodeToCommandBuffer:sourceImage:convolutionState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionState? convolutionState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionState_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionState?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_ConvolutionState_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionState?.Handle ?? IntPtr.Zero));
	}

	[Export("encodeToCommandBuffer:sourceImage:convolutionGradientState:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState? convolutionGradientState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero));
	}

	[Export("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState? convolutionGradientState, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero, destinationImage.Handle);
		}
	}
}
