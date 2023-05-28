using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNGradientKernel", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnGradientKernel : MPSCnnBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_ = "encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_DestinationGradients_ = "encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:destinationGradients:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_DestinationGradients_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:destinationGradients:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_ = "encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_DestinationGradient_ = "encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:destinationGradient:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_DestinationGradient_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:destinationGradient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelOffsetX = "kernelOffsetX";

	private static readonly IntPtr selKernelOffsetXHandle = Selector.GetHandle("kernelOffsetX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelOffsetY = "kernelOffsetY";

	private static readonly IntPtr selKernelOffsetYHandle = Selector.GetHandle("kernelOffsetY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelOffsetX_ = "setKernelOffsetX:";

	private static readonly IntPtr selSetKernelOffsetX_Handle = Selector.GetHandle("setKernelOffsetX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelOffsetY_ = "setKernelOffsetY:";

	private static readonly IntPtr selSetKernelOffsetY_Handle = Selector.GetHandle("setKernelOffsetY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNGradientKernel");

	public override IntPtr ClassHandle => class_ptr;

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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnGradientKernel(NSCoder coder)
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
	protected MPSCnnGradientKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnGradientKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnGradientKernel(IMTLDevice device)
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

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnGradientKernel(NSCoder decoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceGradient, MPSImage sourceImage, MPSState gradientState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle));
	}

	[Export("encodeToCommandBuffer:sourceGradient:sourceImage:gradientState:destinationGradient:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceGradient, MPSImage sourceImage, MPSState gradientState, MPSImage destinationGradient)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (destinationGradient == null)
		{
			throw new ArgumentNullException("destinationGradient");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_DestinationGradient_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, destinationGradient.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceGradient_SourceImage_GradientState_DestinationGradient_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, destinationGradient.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceGradients, NSArray<MPSImage> sourceImages, NSArray<MPSState> gradientStates)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (gradientStates == null)
		{
			throw new ArgumentNullException("gradientStates");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, gradientStates.Handle));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, gradientStates.Handle));
	}

	[Export("encodeBatchToCommandBuffer:sourceGradients:sourceImages:gradientStates:destinationGradients:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceGradients, NSArray<MPSImage> sourceImages, NSArray<MPSState> gradientStates, NSArray<MPSImage> destinationGradients)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (gradientStates == null)
		{
			throw new ArgumentNullException("gradientStates");
		}
		if (destinationGradients == null)
		{
			throw new ArgumentNullException("destinationGradients");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_DestinationGradients_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, gradientStates.Handle, destinationGradients.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_GradientStates_DestinationGradients_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, gradientStates.Handle, destinationGradients.Handle);
		}
	}
}
