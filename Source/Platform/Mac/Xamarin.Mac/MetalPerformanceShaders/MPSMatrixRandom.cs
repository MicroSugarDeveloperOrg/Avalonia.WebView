using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSMatrixRandom", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSMatrixRandom : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchSize = "batchSize";

	private static readonly IntPtr selBatchSizeHandle = Selector.GetHandle("batchSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchStart = "batchStart";

	private static readonly IntPtr selBatchStartHandle = Selector.GetHandle("batchStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationDataType = "destinationDataType";

	private static readonly IntPtr selDestinationDataTypeHandle = Selector.GetHandle("destinationDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistributionType = "distributionType";

	private static readonly IntPtr selDistributionTypeHandle = Selector.GetHandle("distributionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_DestinationMatrix_ = "encodeToCommandBuffer:destinationMatrix:";

	private static readonly IntPtr selEncodeToCommandBuffer_DestinationMatrix_Handle = Selector.GetHandle("encodeToCommandBuffer:destinationMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_DestinationVector_ = "encodeToCommandBuffer:destinationVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_DestinationVector_Handle = Selector.GetHandle("encodeToCommandBuffer:destinationVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchSize_ = "setBatchSize:";

	private static readonly IntPtr selSetBatchSize_Handle = Selector.GetHandle("setBatchSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchStart_ = "setBatchStart:";

	private static readonly IntPtr selSetBatchStart_Handle = Selector.GetHandle("setBatchStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixRandom");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BatchSize
	{
		[Export("batchSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchSizeHandle);
		}
		[Export("setBatchSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBatchSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBatchSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BatchStart
	{
		[Export("batchStart")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchStartHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchStartHandle);
		}
		[Export("setBatchStart:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBatchStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBatchStart_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataType DestinationDataType
	{
		[Export("destinationDataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, selDestinationDataTypeHandle);
			}
			return (MPSDataType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDestinationDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSMatrixRandomDistribution DistributionType
	{
		[Export("distributionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSMatrixRandomDistribution)Messaging.UInt64_objc_msgSend(base.Handle, selDistributionTypeHandle);
			}
			return (MPSMatrixRandomDistribution)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDistributionTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixRandom(NSCoder coder)
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
	protected MPSMatrixRandom(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixRandom(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeToCommandBuffer:destinationVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSVector destinationVector)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (destinationVector == null)
		{
			throw new ArgumentNullException("destinationVector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_DestinationVector_Handle, commandBuffer.Handle, destinationVector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_DestinationVector_Handle, commandBuffer.Handle, destinationVector.Handle);
		}
	}

	[Export("encodeToCommandBuffer:destinationMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSMatrix destinationMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (destinationMatrix == null)
		{
			throw new ArgumentNullException("destinationMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_DestinationMatrix_Handle, commandBuffer.Handle, destinationMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_DestinationMatrix_Handle, commandBuffer.Handle, destinationMatrix.Handle);
		}
	}
}
