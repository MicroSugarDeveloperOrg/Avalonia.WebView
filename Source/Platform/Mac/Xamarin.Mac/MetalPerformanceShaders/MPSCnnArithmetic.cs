using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNArithmetic", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnArithmetic : MPSCnnBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBias = "bias";

	private static readonly IntPtr selBiasHandle = Selector.GetHandle("bias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationImages_ = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationImage_ = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumValue = "maximumValue";

	private static readonly IntPtr selMaximumValueHandle = Selector.GetHandle("maximumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumValue = "minimumValue";

	private static readonly IntPtr selMinimumValueHandle = Selector.GetHandle("minimumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryScale = "primaryScale";

	private static readonly IntPtr selPrimaryScaleHandle = Selector.GetHandle("primaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInFeatureChannels = "primaryStrideInFeatureChannels";

	private static readonly IntPtr selPrimaryStrideInFeatureChannelsHandle = Selector.GetHandle("primaryStrideInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryScale = "secondaryScale";

	private static readonly IntPtr selSecondaryScaleHandle = Selector.GetHandle("secondaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInFeatureChannels = "secondaryStrideInFeatureChannels";

	private static readonly IntPtr selSecondaryStrideInFeatureChannelsHandle = Selector.GetHandle("secondaryStrideInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBias_ = "setBias:";

	private static readonly IntPtr selSetBias_Handle = Selector.GetHandle("setBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumValue_ = "setMaximumValue:";

	private static readonly IntPtr selSetMaximumValue_Handle = Selector.GetHandle("setMaximumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumValue_ = "setMinimumValue:";

	private static readonly IntPtr selSetMinimumValue_Handle = Selector.GetHandle("setMinimumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryScale_ = "setPrimaryScale:";

	private static readonly IntPtr selSetPrimaryScale_Handle = Selector.GetHandle("setPrimaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInFeatureChannels_ = "setPrimaryStrideInFeatureChannels:";

	private static readonly IntPtr selSetPrimaryStrideInFeatureChannels_Handle = Selector.GetHandle("setPrimaryStrideInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryScale_ = "setSecondaryScale:";

	private static readonly IntPtr selSetSecondaryScale_Handle = Selector.GetHandle("setSecondaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInFeatureChannels_ = "setSecondaryStrideInFeatureChannels:";

	private static readonly IntPtr selSetSecondaryStrideInFeatureChannels_Handle = Selector.GetHandle("setSecondaryStrideInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNArithmetic");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Bias
	{
		[Export("bias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBiasHandle);
		}
		[Export("setBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumValue
	{
		[Export("maximumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumValueHandle);
		}
		[Export("setMaximumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumValue
	{
		[Export("minimumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumValueHandle);
		}
		[Export("setMinimumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PrimaryScale
	{
		[Export("primaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPrimaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPrimaryScaleHandle);
		}
		[Export("setPrimaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPrimaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPrimaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PrimaryStrideInFeatureChannels
	{
		[Export("primaryStrideInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInFeatureChannelsHandle);
		}
		[Export("setPrimaryStrideInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SecondaryScale
	{
		[Export("secondaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSecondaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSecondaryScaleHandle);
		}
		[Export("setSecondaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSecondaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSecondaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInFeatureChannels
	{
		[Export("secondaryStrideInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInFeatureChannelsHandle);
		}
		[Export("setSecondaryStrideInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnArithmetic(NSCoder coder)
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
	protected MPSCnnArithmetic(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnArithmetic(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, MPSCnnArithmeticGradientState destinationState, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (primaryImage == null)
		{
			throw new ArgumentNullException("primaryImage");
		}
		if (secondaryImage == null)
		{
			throw new ArgumentNullException("secondaryImage");
		}
		if (destinationState == null)
		{
			throw new ArgumentNullException("destinationState");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationState.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationState.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, MPSCnnArithmeticGradientState[] destinationStates, NSArray<MPSImage> destinationImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (primaryImages == null)
		{
			throw new ArgumentNullException("primaryImages");
		}
		if (secondaryImages == null)
		{
			throw new ArgumentNullException("secondaryImages");
		}
		if (destinationStates == null)
		{
			throw new ArgumentNullException("destinationStates");
		}
		if (destinationImages == null)
		{
			throw new ArgumentNullException("destinationImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(destinationStates);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationImages_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, nSArray.Handle, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationImages_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, nSArray.Handle, destinationImages.Handle);
		}
		nSArray.Dispose();
	}
}
