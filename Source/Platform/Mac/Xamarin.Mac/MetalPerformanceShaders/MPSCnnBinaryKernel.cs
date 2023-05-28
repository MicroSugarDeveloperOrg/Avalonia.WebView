using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBinaryKernel", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnBinaryKernel : MPSKernel
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
	private const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_ = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:primaryImages:secondaryImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_ = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_ = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_ = "encodeToCommandBuffer:primaryImage:secondaryImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryImage:secondaryImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_ = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_ = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:");

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
	private const string selPadding = "padding";

	private static readonly IntPtr selPaddingHandle = Selector.GetHandle("padding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryDilationRateX = "primaryDilationRateX";

	private static readonly IntPtr selPrimaryDilationRateXHandle = Selector.GetHandle("primaryDilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryDilationRateY = "primaryDilationRateY";

	private static readonly IntPtr selPrimaryDilationRateYHandle = Selector.GetHandle("primaryDilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryEdgeMode = "primaryEdgeMode";

	private static readonly IntPtr selPrimaryEdgeModeHandle = Selector.GetHandle("primaryEdgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryKernelHeight = "primaryKernelHeight";

	private static readonly IntPtr selPrimaryKernelHeightHandle = Selector.GetHandle("primaryKernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryKernelWidth = "primaryKernelWidth";

	private static readonly IntPtr selPrimaryKernelWidthHandle = Selector.GetHandle("primaryKernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryOffset = "primaryOffset";

	private static readonly IntPtr selPrimaryOffsetHandle = Selector.GetHandle("primaryOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimarySourceFeatureChannelMaxCount = "primarySourceFeatureChannelMaxCount";

	private static readonly IntPtr selPrimarySourceFeatureChannelMaxCountHandle = Selector.GetHandle("primarySourceFeatureChannelMaxCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimarySourceFeatureChannelOffset = "primarySourceFeatureChannelOffset";

	private static readonly IntPtr selPrimarySourceFeatureChannelOffsetHandle = Selector.GetHandle("primarySourceFeatureChannelOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInPixelsX = "primaryStrideInPixelsX";

	private static readonly IntPtr selPrimaryStrideInPixelsXHandle = Selector.GetHandle("primaryStrideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInPixelsY = "primaryStrideInPixelsY";

	private static readonly IntPtr selPrimaryStrideInPixelsYHandle = Selector.GetHandle("primaryStrideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_ = "resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_ = "resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryDilationRateX = "secondaryDilationRateX";

	private static readonly IntPtr selSecondaryDilationRateXHandle = Selector.GetHandle("secondaryDilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryDilationRateY = "secondaryDilationRateY";

	private static readonly IntPtr selSecondaryDilationRateYHandle = Selector.GetHandle("secondaryDilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryEdgeMode = "secondaryEdgeMode";

	private static readonly IntPtr selSecondaryEdgeModeHandle = Selector.GetHandle("secondaryEdgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryKernelHeight = "secondaryKernelHeight";

	private static readonly IntPtr selSecondaryKernelHeightHandle = Selector.GetHandle("secondaryKernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryKernelWidth = "secondaryKernelWidth";

	private static readonly IntPtr selSecondaryKernelWidthHandle = Selector.GetHandle("secondaryKernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryOffset = "secondaryOffset";

	private static readonly IntPtr selSecondaryOffsetHandle = Selector.GetHandle("secondaryOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySourceFeatureChannelMaxCount = "secondarySourceFeatureChannelMaxCount";

	private static readonly IntPtr selSecondarySourceFeatureChannelMaxCountHandle = Selector.GetHandle("secondarySourceFeatureChannelMaxCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySourceFeatureChannelOffset = "secondarySourceFeatureChannelOffset";

	private static readonly IntPtr selSecondarySourceFeatureChannelOffsetHandle = Selector.GetHandle("secondarySourceFeatureChannelOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsX = "secondaryStrideInPixelsX";

	private static readonly IntPtr selSecondaryStrideInPixelsXHandle = Selector.GetHandle("secondaryStrideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsY = "secondaryStrideInPixelsY";

	private static readonly IntPtr selSecondaryStrideInPixelsYHandle = Selector.GetHandle("secondaryStrideInPixelsY");

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
	private const string selSetPadding_ = "setPadding:";

	private static readonly IntPtr selSetPadding_Handle = Selector.GetHandle("setPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryEdgeMode_ = "setPrimaryEdgeMode:";

	private static readonly IntPtr selSetPrimaryEdgeMode_Handle = Selector.GetHandle("setPrimaryEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryOffset_ = "setPrimaryOffset:";

	private static readonly IntPtr selSetPrimaryOffset_Handle = Selector.GetHandle("setPrimaryOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimarySourceFeatureChannelMaxCount_ = "setPrimarySourceFeatureChannelMaxCount:";

	private static readonly IntPtr selSetPrimarySourceFeatureChannelMaxCount_Handle = Selector.GetHandle("setPrimarySourceFeatureChannelMaxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimarySourceFeatureChannelOffset_ = "setPrimarySourceFeatureChannelOffset:";

	private static readonly IntPtr selSetPrimarySourceFeatureChannelOffset_Handle = Selector.GetHandle("setPrimarySourceFeatureChannelOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInPixelsX_ = "setPrimaryStrideInPixelsX:";

	private static readonly IntPtr selSetPrimaryStrideInPixelsX_Handle = Selector.GetHandle("setPrimaryStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInPixelsY_ = "setPrimaryStrideInPixelsY:";

	private static readonly IntPtr selSetPrimaryStrideInPixelsY_Handle = Selector.GetHandle("setPrimaryStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryEdgeMode_ = "setSecondaryEdgeMode:";

	private static readonly IntPtr selSetSecondaryEdgeMode_Handle = Selector.GetHandle("setSecondaryEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryOffset_ = "setSecondaryOffset:";

	private static readonly IntPtr selSetSecondaryOffset_Handle = Selector.GetHandle("setSecondaryOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondarySourceFeatureChannelMaxCount_ = "setSecondarySourceFeatureChannelMaxCount:";

	private static readonly IntPtr selSetSecondarySourceFeatureChannelMaxCount_Handle = Selector.GetHandle("setSecondarySourceFeatureChannelMaxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondarySourceFeatureChannelOffset_ = "setSecondarySourceFeatureChannelOffset:";

	private static readonly IntPtr selSetSecondarySourceFeatureChannelOffset_Handle = Selector.GetHandle("setSecondarySourceFeatureChannelOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsX_ = "setSecondaryStrideInPixelsX:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsX_Handle = Selector.GetHandle("setSecondaryStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsY_ = "setSecondaryStrideInPixelsY:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsY_Handle = Selector.GetHandle("setSecondaryStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_ = "temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_ = "temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBinaryKernel");

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
	public virtual IMPSImageAllocator DestinationImageAllocator
	{
		[Export("destinationImageAllocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationImageAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationImageAllocatorHandle), owns: false);
		}
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
	public virtual bool IsBackwards
	{
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
	[Obsolete("This was exposed by mistake, it will be removed in a future release.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual nuint KernelHeight => (nuint)0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("This was exposed by mistake, it will be removed in a future release.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual nuint KernelWidth => (nuint)0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSNNPadding Padding
	{
		[Export("padding", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSend(base.Handle, selPaddingHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaddingHandle), owns: false);
		}
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
	public virtual nuint PrimaryDilationRateX
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryDilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryDilationRateXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimaryDilationRateY
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryDilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryDilationRateYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageEdgeMode PrimaryEdgeMode
	{
		[Export("primaryEdgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selPrimaryEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPrimaryEdgeModeHandle);
		}
		[Export("setPrimaryEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPrimaryEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPrimaryEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimaryKernelHeight
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryKernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryKernelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimaryKernelWidth
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryKernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryKernelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset PrimaryOffset
	{
		[Export("primaryOffset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selPrimaryOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPrimaryOffsetHandle);
			}
			return retval;
		}
		[Export("setPrimaryOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetPrimaryOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetPrimaryOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimarySourceFeatureChannelMaxCount
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primarySourceFeatureChannelMaxCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimarySourceFeatureChannelMaxCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimarySourceFeatureChannelMaxCountHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setPrimarySourceFeatureChannelMaxCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimarySourceFeatureChannelMaxCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimarySourceFeatureChannelMaxCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimarySourceFeatureChannelOffset
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primarySourceFeatureChannelOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimarySourceFeatureChannelOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimarySourceFeatureChannelOffsetHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setPrimarySourceFeatureChannelOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimarySourceFeatureChannelOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimarySourceFeatureChannelOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimaryStrideInPixelsX
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryStrideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInPixelsXHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setPrimaryStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint PrimaryStrideInPixelsY
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("primaryStrideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInPixelsYHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setPrimaryStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryDilationRateX
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryDilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryDilationRateXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryDilationRateY
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryDilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryDilationRateYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageEdgeMode SecondaryEdgeMode
	{
		[Export("secondaryEdgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selSecondaryEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSecondaryEdgeModeHandle);
		}
		[Export("setSecondaryEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSecondaryEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSecondaryEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryKernelHeight
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryKernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryKernelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryKernelWidth
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryKernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryKernelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset SecondaryOffset
	{
		[Export("secondaryOffset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selSecondaryOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSecondaryOffsetHandle);
			}
			return retval;
		}
		[Export("setSecondaryOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetSecondaryOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetSecondaryOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondarySourceFeatureChannelMaxCount
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondarySourceFeatureChannelMaxCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondarySourceFeatureChannelMaxCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondarySourceFeatureChannelMaxCountHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSecondarySourceFeatureChannelMaxCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondarySourceFeatureChannelMaxCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondarySourceFeatureChannelMaxCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondarySourceFeatureChannelOffset
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondarySourceFeatureChannelOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondarySourceFeatureChannelOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondarySourceFeatureChannelOffsetHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSecondarySourceFeatureChannelOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondarySourceFeatureChannelOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondarySourceFeatureChannelOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryStrideInPixelsX
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryStrideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsXHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSecondaryStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint SecondaryStrideInPixelsY
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("secondaryStrideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsYHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSecondaryStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnBinaryKernel(NSCoder coder)
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
	protected MPSCnnBinaryKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBinaryKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBinaryKernel(IMTLDevice device)
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
	public MPSCnnBinaryKernel(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, NSArray<MPSImage> destinationImages)
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
		if (destinationImages == null)
		{
			throw new ArgumentNullException("destinationImages");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, destinationImages.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:primaryImages:secondaryImages:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage)
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle));
	}

	[Export("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, out MPSState[]? outState, bool isTemporary)
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
		IntPtr arg = IntPtr.Zero;
		NSArray<MPSImage> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr_bool(base.SuperHandle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, ref arg, isTemporary)) : Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr_bool(base.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_Handle, commandBuffer.Handle, primaryImages.Handle, secondaryImages.Handle, ref arg, isTemporary)));
		outState = NSArray.ArrayFromHandle<MPSState>(arg);
		return result;
	}

	[Export("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, MPSImage destinationImage)
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
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeToCommandBuffer:primaryImage:secondaryImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage)
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle));
	}

	[Export("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, out MPSState? outState, bool isTemporary)
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
		IntPtr arg = IntPtr.Zero;
		MPSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr_bool(base.SuperHandle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, ref arg, isTemporary)) : Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr_bool(base.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, ref arg, isTemporary)));
		outState = Runtime.GetNSObject<MPSState>(arg);
		return result;
	}

	[Export("destinationImageDescriptorForSourceImages:sourceStates:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
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

	[Export("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSState? GetResultState(MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
		if (primaryImage == null)
		{
			throw new ArgumentNullException("primaryImage");
		}
		if (secondaryImage == null)
		{
			throw new ArgumentNullException("secondaryImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, primaryImage.Handle, secondaryImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, primaryImage.Handle, secondaryImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSState>? GetResultStateBatch(NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
	{
		if (primaryImage == null)
		{
			throw new ArgumentNullException("primaryImage");
		}
		if (secondaryImage == null)
		{
			throw new ArgumentNullException("secondaryImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSState> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, primaryImage.Handle, secondaryImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, primaryImage.Handle, secondaryImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}

	[Export("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSState? GetTemporaryResultState(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
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
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSState>? GetTemporaryResultStateBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
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
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSState> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : Runtime.GetNSObject<NSArray<MPSState>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}
}
