using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSRNNImageInferenceLayer", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSRnnImageInferenceLayer : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBidirectionalCombineMode = "bidirectionalCombineMode";

	private static readonly IntPtr selBidirectionalCombineModeHandle = Selector.GetHandle("bidirectionalCombineMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardImages_DestinationBackwardImages_ = "encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardImages:destinationBackwardImages:";

	private static readonly IntPtr selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardImages_DestinationBackwardImages_Handle = Selector.GetHandle("encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardImages:destinationBackwardImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeSequenceToCommandBuffer_SourceImages_DestinationImages_RecurrentInputState_RecurrentOutputStates_ = "encodeSequenceToCommandBuffer:sourceImages:destinationImages:recurrentInputState:recurrentOutputStates:";

	private static readonly IntPtr selEncodeSequenceToCommandBuffer_SourceImages_DestinationImages_RecurrentInputState_RecurrentOutputStates_Handle = Selector.GetHandle("encodeSequenceToCommandBuffer:sourceImages:destinationImages:recurrentInputState:recurrentOutputStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_RnnDescriptor_ = "initWithDevice:rnnDescriptor:";

	private static readonly IntPtr selInitWithDevice_RnnDescriptor_Handle = Selector.GetHandle("initWithDevice:rnnDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_RnnDescriptors_ = "initWithDevice:rnnDescriptors:";

	private static readonly IntPtr selInitWithDevice_RnnDescriptors_Handle = Selector.GetHandle("initWithDevice:rnnDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFeatureChannels = "inputFeatureChannels";

	private static readonly IntPtr selInputFeatureChannelsHandle = Selector.GetHandle("inputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfLayers = "numberOfLayers";

	private static readonly IntPtr selNumberOfLayersHandle = Selector.GetHandle("numberOfLayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFeatureChannels = "outputFeatureChannels";

	private static readonly IntPtr selOutputFeatureChannelsHandle = Selector.GetHandle("outputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrentOutputIsTemporary = "recurrentOutputIsTemporary";

	private static readonly IntPtr selRecurrentOutputIsTemporaryHandle = Selector.GetHandle("recurrentOutputIsTemporary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBidirectionalCombineMode_ = "setBidirectionalCombineMode:";

	private static readonly IntPtr selSetBidirectionalCombineMode_Handle = Selector.GetHandle("setBidirectionalCombineMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrentOutputIsTemporary_ = "setRecurrentOutputIsTemporary:";

	private static readonly IntPtr selSetRecurrentOutputIsTemporary_Handle = Selector.GetHandle("setRecurrentOutputIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStoreAllIntermediateStates_ = "setStoreAllIntermediateStates:";

	private static readonly IntPtr selSetStoreAllIntermediateStates_Handle = Selector.GetHandle("setStoreAllIntermediateStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreAllIntermediateStates = "storeAllIntermediateStates";

	private static readonly IntPtr selStoreAllIntermediateStatesHandle = Selector.GetHandle("storeAllIntermediateStates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNImageInferenceLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRnnBidirectionalCombineMode BidirectionalCombineMode
	{
		[Export("bidirectionalCombineMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSRnnBidirectionalCombineMode)Messaging.UInt64_objc_msgSend(base.Handle, selBidirectionalCombineModeHandle);
			}
			return (MPSRnnBidirectionalCombineMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBidirectionalCombineModeHandle);
		}
		[Export("setBidirectionalCombineMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBidirectionalCombineMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBidirectionalCombineMode_Handle, (ulong)value);
			}
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
	public virtual bool IsRecurrentOutputTemporary
	{
		[Export("recurrentOutputIsTemporary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRecurrentOutputIsTemporaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRecurrentOutputIsTemporaryHandle);
		}
		[Export("setRecurrentOutputIsTemporary:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRecurrentOutputIsTemporary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRecurrentOutputIsTemporary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfLayers
	{
		[Export("numberOfLayers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfLayersHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfLayersHandle);
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
	public virtual bool StoreAllIntermediateStates
	{
		[Export("storeAllIntermediateStates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selStoreAllIntermediateStatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStoreAllIntermediateStatesHandle);
		}
		[Export("setStoreAllIntermediateStates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStoreAllIntermediateStates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStoreAllIntermediateStates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSRnnImageInferenceLayer(NSCoder coder)
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
	protected MPSRnnImageInferenceLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnImageInferenceLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:rnnDescriptor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnImageInferenceLayer(IMTLDevice device, MPSRnnDescriptor rnnDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (rnnDescriptor == null)
		{
			throw new ArgumentNullException("rnnDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_RnnDescriptor_Handle, device.Handle, rnnDescriptor.Handle), "initWithDevice:rnnDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_RnnDescriptor_Handle, device.Handle, rnnDescriptor.Handle), "initWithDevice:rnnDescriptor:");
		}
	}

	[Export("initWithDevice:rnnDescriptors:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnImageInferenceLayer(IMTLDevice device, MPSRnnDescriptor[] rnnDescriptors)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (rnnDescriptors == null)
		{
			throw new ArgumentNullException("rnnDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(rnnDescriptors);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_RnnDescriptors_Handle, device.Handle, nSArray.Handle), "initWithDevice:rnnDescriptors:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_RnnDescriptors_Handle, device.Handle, nSArray.Handle), "initWithDevice:rnnDescriptors:");
		}
		nSArray.Dispose();
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnImageInferenceLayer(NSCoder aDecoder, IMTLDevice device)
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

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSRnnImageInferenceLayer Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSRnnImageInferenceLayer mPSRnnImageInferenceLayer = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSRnnImageInferenceLayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSRnnImageInferenceLayer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSRnnImageInferenceLayer != null)
		{
			Messaging.void_objc_msgSend(mPSRnnImageInferenceLayer.Handle, Selector.GetHandle("release"));
		}
		return mPSRnnImageInferenceLayer;
	}

	[Export("encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardImages:destinationBackwardImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBidirectionalSequence(IMTLCommandBuffer commandBuffer, MPSImage[] sourceSequence, MPSImage[] destinationForwardImages, MPSImage[]? destinationBackwardImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceSequence == null)
		{
			throw new ArgumentNullException("sourceSequence");
		}
		if (destinationForwardImages == null)
		{
			throw new ArgumentNullException("destinationForwardImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceSequence);
		NSArray nSArray2 = NSArray.FromNSObjects(destinationForwardImages);
		NSArray nSArray3 = ((destinationBackwardImages == null) ? null : NSArray.FromNSObjects(destinationBackwardImages));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardImages_DestinationBackwardImages_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, nSArray3?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardImages_DestinationBackwardImages_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, nSArray3?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3?.Dispose();
	}

	[Export("encodeSequenceToCommandBuffer:sourceImages:destinationImages:recurrentInputState:recurrentOutputStates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeSequence(IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, MPSImage[] destinationImages, MPSRnnRecurrentImageState? recurrentInputState, NSMutableArray<MPSRnnRecurrentImageState>? recurrentOutputStates)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (destinationImages == null)
		{
			throw new ArgumentNullException("destinationImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = NSArray.FromNSObjects(destinationImages);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeSequenceToCommandBuffer_SourceImages_DestinationImages_RecurrentInputState_RecurrentOutputStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeSequenceToCommandBuffer_SourceImages_DestinationImages_RecurrentInputState_RecurrentOutputStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}
}
