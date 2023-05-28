using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCommandBuffer", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSCommandBuffer : NSObject, IMTLCommandBuffer, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGPUEndTime = "GPUEndTime";

	private static readonly IntPtr selGPUEndTimeHandle = Selector.GetHandle("GPUEndTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGPUStartTime = "GPUStartTime";

	private static readonly IntPtr selGPUStartTimeHandle = Selector.GetHandle("GPUStartTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddCompletedHandler_ = "addCompletedHandler:";

	private static readonly IntPtr selAddCompletedHandler_Handle = Selector.GetHandle("addCompletedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddScheduledHandler_ = "addScheduledHandler:";

	private static readonly IntPtr selAddScheduledHandler_Handle = Selector.GetHandle("addScheduledHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlitCommandEncoder = "blitCommandEncoder";

	private static readonly IntPtr selBlitCommandEncoderHandle = Selector.GetHandle("blitCommandEncoder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandBuffer = "commandBuffer";

	private static readonly IntPtr selCommandBufferHandle = Selector.GetHandle("commandBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandBufferFromCommandQueue_ = "commandBufferFromCommandQueue:";

	private static readonly IntPtr selCommandBufferFromCommandQueue_Handle = Selector.GetHandle("commandBufferFromCommandQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandBufferWithCommandBuffer_ = "commandBufferWithCommandBuffer:";

	private static readonly IntPtr selCommandBufferWithCommandBuffer_Handle = Selector.GetHandle("commandBufferWithCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandQueue = "commandQueue";

	private static readonly IntPtr selCommandQueueHandle = Selector.GetHandle("commandQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommit = "commit";

	private static readonly IntPtr selCommitHandle = Selector.GetHandle("commit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitAndContinue = "commitAndContinue";

	private static readonly IntPtr selCommitAndContinueHandle = Selector.GetHandle("commitAndContinue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComputeCommandEncoder = "computeCommandEncoder";

	private static readonly IntPtr selComputeCommandEncoderHandle = Selector.GetHandle("computeCommandEncoder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComputeCommandEncoderWithDispatchType_ = "computeCommandEncoderWithDispatchType:";

	private static readonly IntPtr selComputeCommandEncoderWithDispatchType_Handle = Selector.GetHandle("computeCommandEncoderWithDispatchType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeSignalEvent_Value_ = "encodeSignalEvent:value:";

	private static readonly IntPtr selEncodeSignalEvent_Value_Handle = Selector.GetHandle("encodeSignalEvent:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWaitForEvent_Value_ = "encodeWaitForEvent:value:";

	private static readonly IntPtr selEncodeWaitForEvent_Value_Handle = Selector.GetHandle("encodeWaitForEvent:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnqueue = "enqueue";

	private static readonly IntPtr selEnqueueHandle = Selector.GetHandle("enqueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeapProvider = "heapProvider";

	private static readonly IntPtr selHeapProviderHandle = Selector.GetHandle("heapProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCommandBuffer_ = "initWithCommandBuffer:";

	private static readonly IntPtr selInitWithCommandBuffer_Handle = Selector.GetHandle("initWithCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelEndTime = "kernelEndTime";

	private static readonly IntPtr selKernelEndTimeHandle = Selector.GetHandle("kernelEndTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelStartTime = "kernelStartTime";

	private static readonly IntPtr selKernelStartTimeHandle = Selector.GetHandle("kernelStartTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParallelRenderCommandEncoderWithDescriptor_ = "parallelRenderCommandEncoderWithDescriptor:";

	private static readonly IntPtr selParallelRenderCommandEncoderWithDescriptor_Handle = Selector.GetHandle("parallelRenderCommandEncoderWithDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopDebugGroup = "popDebugGroup";

	private static readonly IntPtr selPopDebugGroupHandle = Selector.GetHandle("popDebugGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefetchHeapForWorkloadSize_ = "prefetchHeapForWorkloadSize:";

	private static readonly IntPtr selPrefetchHeapForWorkloadSize_Handle = Selector.GetHandle("prefetchHeapForWorkloadSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentDrawable_ = "presentDrawable:";

	private static readonly IntPtr selPresentDrawable_Handle = Selector.GetHandle("presentDrawable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentDrawable_AfterMinimumDuration_ = "presentDrawable:afterMinimumDuration:";

	private static readonly IntPtr selPresentDrawable_AfterMinimumDuration_Handle = Selector.GetHandle("presentDrawable:afterMinimumDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentDrawable_AtTime_ = "presentDrawable:atTime:";

	private static readonly IntPtr selPresentDrawable_AtTime_Handle = Selector.GetHandle("presentDrawable:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPushDebugGroup_ = "pushDebugGroup:";

	private static readonly IntPtr selPushDebugGroup_Handle = Selector.GetHandle("pushDebugGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderCommandEncoderWithDescriptor_ = "renderCommandEncoderWithDescriptor:";

	private static readonly IntPtr selRenderCommandEncoderWithDescriptor_Handle = Selector.GetHandle("renderCommandEncoderWithDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetainedReferences = "retainedReferences";

	private static readonly IntPtr selRetainedReferencesHandle = Selector.GetHandle("retainedReferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootCommandBuffer = "rootCommandBuffer";

	private static readonly IntPtr selRootCommandBufferHandle = Selector.GetHandle("rootCommandBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeapProvider_ = "setHeapProvider:";

	private static readonly IntPtr selSetHeapProvider_Handle = Selector.GetHandle("setHeapProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilCompleted = "waitUntilCompleted";

	private static readonly IntPtr selWaitUntilCompletedHandle = Selector.GetHandle("waitUntilCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilScheduled = "waitUntilScheduled";

	private static readonly IntPtr selWaitUntilScheduledHandle = Selector.GetHandle("waitUntilScheduled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCommandBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLBlitCommandEncoder BlitCommandEncoder
	{
		[Export("blitCommandEncoder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBlitCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, selBlitCommandEncoderHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBlitCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBlitCommandEncoderHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLCommandBuffer CommandBuffer
	{
		[Export("commandBuffer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandBufferHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLCommandQueue CommandQueue
	{
		[Export("commandQueue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandQueueHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandQueueHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLComputeCommandEncoder ComputeCommandEncoder
	{
		[Export("computeCommandEncoder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, selComputeCommandEncoderHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComputeCommandEncoderHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLDevice Device
	{
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual double GpuEndTime
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("GPUEndTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selGPUEndTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selGPUEndTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual double GpuStartTime
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("GPUStartTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selGPUStartTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selGPUStartTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHeapProvider? HeapProvider
	{
		[Export("heapProvider", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSHeapProvider>(Messaging.IntPtr_objc_msgSend(base.Handle, selHeapProviderHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSHeapProvider>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeapProviderHandle), owns: false);
		}
		[Export("setHeapProvider:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeapProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeapProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual double KernelEndTime
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("kernelEndTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKernelEndTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKernelEndTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual double KernelStartTime
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("kernelStartTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKernelStartTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKernelStartTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<MPSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool RetainedReferences
	{
		[Export("retainedReferences")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRetainedReferencesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRetainedReferencesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLCommandBuffer RootCommandBuffer
	{
		[Export("rootCommandBuffer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootCommandBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootCommandBufferHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual MTLCommandBufferStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCommandBufferStatus)Messaging.UInt64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (MTLCommandBufferStatus)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[Field("MTLCommandBufferErrorDomain", "MetalPerformanceShaders")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.MetalPerformanceShaders.Handle, "MTLCommandBufferErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCommandBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCommandBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCommandBuffer:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCommandBuffer(IMTLCommandBuffer commandBuffer)
		: base(NSObjectFlag.Empty)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCommandBuffer_Handle, commandBuffer.Handle), "initWithCommandBuffer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCommandBuffer_Handle, commandBuffer.Handle), "initWithCommandBuffer:");
		}
	}

	[Export("addCompletedHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddCompletedHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V64.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddCompletedHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddCompletedHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("addScheduledHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddScheduledHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V64.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddScheduledHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddScheduledHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("commit")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Commit()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCommitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCommitHandle);
		}
	}

	[Export("commitAndContinue")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CommitAndContinue()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCommitAndContinueHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCommitAndContinueHandle);
		}
	}

	[Export("computeCommandEncoderWithDispatchType:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLComputeCommandEncoder? ComputeCommandEncoderDispatch(MTLDispatchType dispatchType)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selComputeCommandEncoderWithDispatchType_Handle, (ulong)dispatchType), owns: false);
		}
		return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selComputeCommandEncoderWithDispatchType_Handle, (ulong)dispatchType), owns: false);
	}

	[Export("commandBufferWithCommandBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCommandBuffer Create(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSCommandBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCommandBufferWithCommandBuffer_Handle, commandBuffer.Handle));
	}

	[Export("commandBufferFromCommandQueue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCommandBuffer Create(IMTLCommandQueue commandQueue)
	{
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		return Runtime.GetNSObject<MPSCommandBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCommandBufferFromCommandQueue_Handle, commandQueue.Handle));
	}

	[Export("parallelRenderCommandEncoderWithDescriptor:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor)
	{
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMTLParallelRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selParallelRenderCommandEncoderWithDescriptor_Handle, renderPassDescriptor.Handle), owns: false);
		}
		return Runtime.GetINativeObject<IMTLParallelRenderCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selParallelRenderCommandEncoderWithDescriptor_Handle, renderPassDescriptor.Handle), owns: false);
	}

	[Export("renderCommandEncoderWithDescriptor:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLRenderCommandEncoder CreateRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor)
	{
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRenderCommandEncoderWithDescriptor_Handle, renderPassDescriptor.Handle), owns: false);
		}
		return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRenderCommandEncoderWithDescriptor_Handle, renderPassDescriptor.Handle), owns: false);
	}

	[Export("encodeSignalEvent:value:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeSignal(IMTLEvent @event, ulong value)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selEncodeSignalEvent_Value_Handle, @event.Handle, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selEncodeSignalEvent_Value_Handle, @event.Handle, value);
		}
	}

	[Export("encodeWaitForEvent:value:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeWait(IMTLEvent @event, ulong value)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selEncodeWaitForEvent_Value_Handle, @event.Handle, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selEncodeWaitForEvent_Value_Handle, @event.Handle, value);
		}
	}

	[Export("enqueue")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Enqueue()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnqueueHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnqueueHandle);
		}
	}

	[Export("popDebugGroup")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PopDebugGroup()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPopDebugGroupHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPopDebugGroupHandle);
		}
	}

	[Export("prefetchHeapForWorkloadSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrefetchHeap(nuint size)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selPrefetchHeapForWorkloadSize_Handle, size);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selPrefetchHeapForWorkloadSize_Handle, size);
		}
	}

	[Export("presentDrawable:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentDrawable(IMTLDrawable drawable)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentDrawable_Handle, drawable.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentDrawable_Handle, drawable.Handle);
		}
	}

	[Export("presentDrawable:atTime:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentDrawable(IMTLDrawable drawable, double presentationTime)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selPresentDrawable_AtTime_Handle, drawable.Handle, presentationTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selPresentDrawable_AtTime_Handle, drawable.Handle, presentationTime);
		}
	}

	[Export("presentDrawable:afterMinimumDuration:")]
	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentDrawableAfter(IMTLDrawable drawable, double duration)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selPresentDrawable_AfterMinimumDuration_Handle, drawable.Handle, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selPresentDrawable_AfterMinimumDuration_Handle, drawable.Handle, duration);
		}
	}

	[Export("pushDebugGroup:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PushDebugGroup(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPushDebugGroup_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPushDebugGroup_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("waitUntilCompleted")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitUntilCompleted()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilCompletedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilCompletedHandle);
		}
	}

	[Export("waitUntilScheduled")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitUntilScheduled()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilScheduledHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilScheduledHandle);
		}
	}
}
