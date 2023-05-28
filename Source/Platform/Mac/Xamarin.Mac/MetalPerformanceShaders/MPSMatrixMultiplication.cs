using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSMatrixMultiplication", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSMatrixMultiplication : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchSize = "batchSize";

	private static readonly IntPtr selBatchSizeHandle = Selector.GetHandle("batchSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchStart = "batchStart";

	private static readonly IntPtr selBatchStartHandle = Selector.GetHandle("batchStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_LeftMatrix_RightMatrix_ResultMatrix_ = "encodeToCommandBuffer:leftMatrix:rightMatrix:resultMatrix:";

	private static readonly IntPtr selEncodeToCommandBuffer_LeftMatrix_RightMatrix_ResultMatrix_Handle = Selector.GetHandle("encodeToCommandBuffer:leftMatrix:rightMatrix:resultMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ResultRows_ResultColumns_InteriorColumns_ = "initWithDevice:resultRows:resultColumns:interiorColumns:";

	private static readonly IntPtr selInitWithDevice_ResultRows_ResultColumns_InteriorColumns_Handle = Selector.GetHandle("initWithDevice:resultRows:resultColumns:interiorColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_TransposeLeft_TransposeRight_ResultRows_ResultColumns_InteriorColumns_Alpha_Beta_ = "initWithDevice:transposeLeft:transposeRight:resultRows:resultColumns:interiorColumns:alpha:beta:";

	private static readonly IntPtr selInitWithDevice_TransposeLeft_TransposeRight_ResultRows_ResultColumns_InteriorColumns_Alpha_Beta_Handle = Selector.GetHandle("initWithDevice:transposeLeft:transposeRight:resultRows:resultColumns:interiorColumns:alpha:beta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftMatrixOrigin = "leftMatrixOrigin";

	private static readonly IntPtr selLeftMatrixOriginHandle = Selector.GetHandle("leftMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultMatrixOrigin = "resultMatrixOrigin";

	private static readonly IntPtr selResultMatrixOriginHandle = Selector.GetHandle("resultMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMatrixOrigin = "rightMatrixOrigin";

	private static readonly IntPtr selRightMatrixOriginHandle = Selector.GetHandle("rightMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchSize_ = "setBatchSize:";

	private static readonly IntPtr selSetBatchSize_Handle = Selector.GetHandle("setBatchSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchStart_ = "setBatchStart:";

	private static readonly IntPtr selSetBatchStart_Handle = Selector.GetHandle("setBatchStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeftMatrixOrigin_ = "setLeftMatrixOrigin:";

	private static readonly IntPtr selSetLeftMatrixOrigin_Handle = Selector.GetHandle("setLeftMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultMatrixOrigin_ = "setResultMatrixOrigin:";

	private static readonly IntPtr selSetResultMatrixOrigin_Handle = Selector.GetHandle("setResultMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightMatrixOrigin_ = "setRightMatrixOrigin:";

	private static readonly IntPtr selSetRightMatrixOrigin_Handle = Selector.GetHandle("setRightMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixMultiplication");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint BatchSize
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("batchSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchSizeHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint BatchStart
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("batchStart")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchStartHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchStartHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
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
	public virtual MTLOrigin LeftMatrixOrigin
	{
		[Export("leftMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selLeftMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLeftMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setLeftMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetLeftMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetLeftMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin ResultMatrixOrigin
	{
		[Export("resultMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selResultMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selResultMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setResultMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetResultMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetResultMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin RightMatrixOrigin
	{
		[Export("rightMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selRightMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRightMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setRightMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetRightMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetRightMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixMultiplication(NSCoder coder)
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
	protected MPSMatrixMultiplication(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixMultiplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:resultRows:resultColumns:interiorColumns:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixMultiplication(IMTLDevice device, nuint resultRows, nuint resultColumns, nuint interiorColumns)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint(base.Handle, selInitWithDevice_ResultRows_ResultColumns_InteriorColumns_Handle, device.Handle, resultRows, resultColumns, interiorColumns), "initWithDevice:resultRows:resultColumns:interiorColumns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint(base.SuperHandle, selInitWithDevice_ResultRows_ResultColumns_InteriorColumns_Handle, device.Handle, resultRows, resultColumns, interiorColumns), "initWithDevice:resultRows:resultColumns:interiorColumns:");
		}
	}

	[Export("initWithDevice:transposeLeft:transposeRight:resultRows:resultColumns:interiorColumns:alpha:beta:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixMultiplication(IMTLDevice device, bool transposeLeft, bool transposeRight, nuint resultRows, nuint resultColumns, nuint interiorColumns, double alpha, double beta)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_nuint_nuint_nuint_Double_Double(base.Handle, selInitWithDevice_TransposeLeft_TransposeRight_ResultRows_ResultColumns_InteriorColumns_Alpha_Beta_Handle, device.Handle, transposeLeft, transposeRight, resultRows, resultColumns, interiorColumns, alpha, beta), "initWithDevice:transposeLeft:transposeRight:resultRows:resultColumns:interiorColumns:alpha:beta:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_nuint_nuint_nuint_Double_Double(base.SuperHandle, selInitWithDevice_TransposeLeft_TransposeRight_ResultRows_ResultColumns_InteriorColumns_Alpha_Beta_Handle, device.Handle, transposeLeft, transposeRight, resultRows, resultColumns, interiorColumns, alpha, beta), "initWithDevice:transposeLeft:transposeRight:resultRows:resultColumns:interiorColumns:alpha:beta:");
		}
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixMultiplication(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:leftMatrix:rightMatrix:resultMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSMatrix leftMatrix, MPSMatrix rightMatrix, MPSMatrix resultMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (leftMatrix == null)
		{
			throw new ArgumentNullException("leftMatrix");
		}
		if (rightMatrix == null)
		{
			throw new ArgumentNullException("rightMatrix");
		}
		if (resultMatrix == null)
		{
			throw new ArgumentNullException("resultMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_LeftMatrix_RightMatrix_ResultMatrix_Handle, commandBuffer.Handle, leftMatrix.Handle, rightMatrix.Handle, resultMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_LeftMatrix_RightMatrix_ResultMatrix_Handle, commandBuffer.Handle, leftMatrix.Handle, rightMatrix.Handle, resultMatrix.Handle);
		}
	}
}
