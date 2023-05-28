using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNKernel", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public abstract class MPSCnnKernel : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBatchBarrier = "appendBatchBarrier";

	private static readonly IntPtr selAppendBatchBarrierHandle = Selector.GetHandle("appendBatchBarrier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRect = "clipRect";

	private static readonly IntPtr selClipRectHandle = Selector.GetHandle("clipRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationFeatureChannelOffset = "destinationFeatureChannelOffset";

	private static readonly IntPtr selDestinationFeatureChannelOffsetHandle = Selector.GetHandle("destinationFeatureChannelOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationImageAllocator = "destinationImageAllocator";

	private static readonly IntPtr selDestinationImageAllocatorHandle = Selector.GetHandle("destinationImageAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationImageDescriptorForSourceImages_SourceStates_ = "destinationImageDescriptorForSourceImages:sourceStates:";

	private static readonly IntPtr selDestinationImageDescriptorForSourceImages_SourceStates_Handle = Selector.GetHandle("destinationImageDescriptorForSourceImages:sourceStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeMode = "edgeMode";

	private static readonly IntPtr selEdgeModeHandle = Selector.GetHandle("edgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_ = "encodeBatchToCommandBuffer:sourceImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_ = "encodeBatchToCommandBuffer:sourceImages:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationImages_ = "encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_ = "encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_ = "encodeToCommandBuffer:sourceImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationImage_ = "encodeToCommandBuffer:sourceImage:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationImage_ = "encodeToCommandBuffer:sourceImage:destinationState:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationState:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationStateIsTemporary_ = "encodeToCommandBuffer:sourceImage:destinationState:destinationStateIsTemporary:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationStateIsTemporary_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationState:destinationStateIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBackwards = "isBackwards";

	private static readonly IntPtr selIsBackwardsHandle = Selector.GetHandle("isBackwards");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsResultStateReusedAcrossBatch = "isResultStateReusedAcrossBatch";

	private static readonly IntPtr selIsResultStateReusedAcrossBatchHandle = Selector.GetHandle("isResultStateReusedAcrossBatch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStateModified = "isStateModified";

	private static readonly IntPtr selIsStateModifiedHandle = Selector.GetHandle("isStateModified");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPadding = "padding";

	private static readonly IntPtr selPaddingHandle = Selector.GetHandle("padding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateBatchForSourceImage_SourceStates_DestinationImage_ = "resultStateBatchForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateBatchForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateForSourceImage_SourceStates_DestinationImage_ = "resultStateForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClipRect_ = "setClipRect:";

	private static readonly IntPtr selSetClipRect_Handle = Selector.GetHandle("setClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationFeatureChannelOffset_ = "setDestinationFeatureChannelOffset:";

	private static readonly IntPtr selSetDestinationFeatureChannelOffset_Handle = Selector.GetHandle("setDestinationFeatureChannelOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationImageAllocator_ = "setDestinationImageAllocator:";

	private static readonly IntPtr selSetDestinationImageAllocator_Handle = Selector.GetHandle("setDestinationImageAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeMode_ = "setEdgeMode:";

	private static readonly IntPtr selSetEdgeMode_Handle = Selector.GetHandle("setEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOffset_ = "setOffset:";

	private static readonly IntPtr selSetOffset_Handle = Selector.GetHandle("setOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPadding_ = "setPadding:";

	private static readonly IntPtr selSetPadding_Handle = Selector.GetHandle("setPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceFeatureChannelMaxCount_ = "setSourceFeatureChannelMaxCount:";

	private static readonly IntPtr selSetSourceFeatureChannelMaxCount_Handle = Selector.GetHandle("setSourceFeatureChannelMaxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceFeatureChannelOffset_ = "setSourceFeatureChannelOffset:";

	private static readonly IntPtr selSetSourceFeatureChannelOffset_Handle = Selector.GetHandle("setSourceFeatureChannelOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFeatureChannelMaxCount = "sourceFeatureChannelMaxCount";

	private static readonly IntPtr selSourceFeatureChannelMaxCountHandle = Selector.GetHandle("sourceFeatureChannelMaxCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFeatureChannelOffset = "sourceFeatureChannelOffset";

	private static readonly IntPtr selSourceFeatureChannelOffsetHandle = Selector.GetHandle("sourceFeatureChannelOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceRegionForDestinationSize_ = "sourceRegionForDestinationSize:";

	private static readonly IntPtr selSourceRegionForDestinationSize_Handle = Selector.GetHandle("sourceRegionForDestinationSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsX = "strideInPixelsX";

	private static readonly IntPtr selStrideInPixelsXHandle = Selector.GetHandle("strideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsY = "strideInPixelsY";

	private static readonly IntPtr selStrideInPixelsYHandle = Selector.GetHandle("strideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual bool AppendBatchBarrier
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("appendBatchBarrier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAppendBatchBarrierHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAppendBatchBarrierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion ClipRect
	{
		[Export("clipRect", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selClipRectHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClipRectHandle);
			}
			return retval;
		}
		[Export("setClipRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetClipRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetClipRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DestinationFeatureChannelOffset
	{
		[Export("destinationFeatureChannelOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDestinationFeatureChannelOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDestinationFeatureChannelOffsetHandle);
		}
		[Export("setDestinationFeatureChannelOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDestinationFeatureChannelOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDestinationFeatureChannelOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual IMPSImageAllocator DestinationImageAllocator
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("destinationImageAllocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationImageAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationImageAllocatorHandle), owns: false);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDestinationImageAllocator:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationImageAllocator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationImageAllocator_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint DilationRateX
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint DilationRateY
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
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
	public virtual MPSImageEdgeMode EdgeMode
	{
		[Export("edgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEdgeModeHandle);
		}
		[Export("setEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool IsBackwards
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isBackwards")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBackwardsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBackwardsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual bool IsResultStateReusedAcrossBatch
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("isResultStateReusedAcrossBatch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsResultStateReusedAcrossBatchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsResultStateReusedAcrossBatchHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual bool IsStateModified
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("isStateModified")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStateModifiedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStateModifiedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint KernelHeight
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("kernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint KernelWidth
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("kernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset Offset
	{
		[Export("offset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOffsetHandle);
			}
			return retval;
		}
		[Export("setOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual IMPSNNPadding Padding
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("padding", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSend(base.Handle, selPaddingHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaddingHandle), owns: false);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setPadding:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPadding_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPadding_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SourceFeatureChannelMaxCount
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("sourceFeatureChannelMaxCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceFeatureChannelMaxCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceFeatureChannelMaxCountHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSourceFeatureChannelMaxCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceFeatureChannelMaxCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceFeatureChannelMaxCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SourceFeatureChannelOffset
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("sourceFeatureChannelOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceFeatureChannelOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceFeatureChannelOffsetHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSourceFeatureChannelOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceFeatureChannelOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceFeatureChannelOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint StrideInPixelsX
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("strideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint StrideInPixelsY
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("strideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	protected MPSCnnKernel(NSCoder coder)
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
	protected MPSCnnKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnKernel(IMTLDevice device)
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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnKernel(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeBatchToCommandBuffer:sourceImages:destinationImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, NSArray<MPSImage> destinationImages)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, destinationImages.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, NSArray<MPSState>? destinationStates, NSArray<MPSImage> destinationImages)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, destinationStates?.Handle ?? IntPtr.Zero, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, destinationStates?.Handle ?? IntPtr.Zero, destinationImages.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_Handle, commandBuffer.Handle, sourceImages.Handle));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_Handle, commandBuffer.Handle, sourceImages.Handle));
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, out NSArray<MPSState>? outStates, bool isTemporary)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray<MPSImage> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_bool(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_Handle, commandBuffer.Handle, sourceImages.Handle, ref arg, isTemporary)) : Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_bool(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_Handle, commandBuffer.Handle, sourceImages.Handle, ref arg, isTemporary)));
		outStates = Runtime.GetNSObject<NSArray<MPSState>>(arg);
		return result;
	}

	[Export("encodeToCommandBuffer:sourceImage:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSImage destinationImage)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceImage:destinationState:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSState destinationState, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationState.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationState.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceImage:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage)
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
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_Handle, commandBuffer.Handle, sourceImage.Handle));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_Handle, commandBuffer.Handle, sourceImage.Handle));
	}

	[Export("encodeToCommandBuffer:sourceImage:destinationState:destinationStateIsTemporary:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, out MPSState? outState, bool isTemporary)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		IntPtr arg = IntPtr.Zero;
		MPSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_bool(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationStateIsTemporary_Handle, commandBuffer.Handle, sourceImage.Handle, ref arg, isTemporary)) : Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_bool(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationState_DestinationStateIsTemporary_Handle, commandBuffer.Handle, sourceImage.Handle, ref arg, isTemporary)));
		outState = Runtime.GetNSObject<MPSState>(arg);
		return result;
	}

	[Export("destinationImageDescriptorForSourceImages:sourceStates:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageDescriptor GetDestinationImageDescriptor(NSArray<MPSImage> sourceImages, NSArray<MPSState>? sourceStates)
	{
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_Handle, sourceImages.Handle, sourceStates?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDestinationImageDescriptorForSourceImages_SourceStates_Handle, sourceImages.Handle, sourceStates?.Handle ?? IntPtr.Zero));
	}

	[Export("resultStateForSourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSState? GetResultState(MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
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
			return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("resultStateBatchForSourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSState>? GetResultStateBatch(NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSState> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}

	[Export("sourceRegionForDestinationSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRegion GetSourceRegion(MTLSize destinationSize)
	{
		MPSRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MPSRegion_objc_msgSend_stret_MTLSize(out retval, base.Handle, selSourceRegionForDestinationSize_Handle, destinationSize);
		}
		else
		{
			Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize(out retval, base.SuperHandle, selSourceRegionForDestinationSize_Handle, destinationSize);
		}
		return retval;
	}

	[Export("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSState? GetTemporaryResultState(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
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
			return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSState>? GetTemporaryResultStateBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
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
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSState> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}
}
