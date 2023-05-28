using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixSum", true)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
public class MPSMatrixSum : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumns = "columns";

	private static readonly IntPtr selColumnsHandle = Selector.GetHandle("columns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceMatrices_ResultMatrix_ScaleVector_OffsetVector_BiasVector_StartIndex_ = "encodeToCommandBuffer:sourceMatrices:resultMatrix:scaleVector:offsetVector:biasVector:startIndex:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceMatrices_ResultMatrix_ScaleVector_OffsetVector_BiasVector_StartIndex_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceMatrices:resultMatrix:scaleVector:offsetVector:biasVector:startIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Count_Rows_Columns_Transpose_ = "initWithDevice:count:rows:columns:transpose:";

	private static readonly IntPtr selInitWithDevice_Count_Rows_Columns_Transpose_Handle = Selector.GetHandle("initWithDevice:count:rows:columns:transpose:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterA = "neuronParameterA";

	private static readonly IntPtr selNeuronParameterAHandle = Selector.GetHandle("neuronParameterA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterB = "neuronParameterB";

	private static readonly IntPtr selNeuronParameterBHandle = Selector.GetHandle("neuronParameterB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterC = "neuronParameterC";

	private static readonly IntPtr selNeuronParameterCHandle = Selector.GetHandle("neuronParameterC");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRows = "rows";

	private static readonly IntPtr selRowsHandle = Selector.GetHandle("rows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronType_ParameterA_ParameterB_ParameterC_ = "setNeuronType:parameterA:parameterB:parameterC:";

	private static readonly IntPtr selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle = Selector.GetHandle("setNeuronType:parameterA:parameterB:parameterC:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranspose = "transpose";

	private static readonly IntPtr selTransposeHandle = Selector.GetHandle("transpose");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixSum");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Columns
	{
		[Export("columns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NeuronParameterA
	{
		[Export("neuronParameterA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterAHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterAHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NeuronParameterB
	{
		[Export("neuronParameterB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterBHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterBHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NeuronParameterC
	{
		[Export("neuronParameterC")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterCHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterCHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Export("neuronType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnNeuronType)Messaging.int_objc_msgSend(base.Handle, selNeuronTypeHandle);
			}
			return (MPSCnnNeuronType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selNeuronTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Rows
	{
		[Export("rows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Transpose
	{
		[Export("transpose")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTransposeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTransposeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixSum(NSCoder coder)
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
	protected MPSMatrixSum(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixSum(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:count:rows:columns:transpose:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixSum(IMTLDevice device, nuint count, nuint rows, nuint columns, bool transpose)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_bool(base.Handle, selInitWithDevice_Count_Rows_Columns_Transpose_Handle, device.Handle, count, rows, columns, transpose), "initWithDevice:count:rows:columns:transpose:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_bool(base.SuperHandle, selInitWithDevice_Count_Rows_Columns_Transpose_Handle, device.Handle, count, rows, columns, transpose), "initWithDevice:count:rows:columns:transpose:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixSum(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceMatrices:resultMatrix:scaleVector:offsetVector:biasVector:startIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer buffer, MPSMatrix[] sourceMatrices, MPSMatrix resultMatrix, MPSVector? scaleVector, MPSVector? offsetVector, MPSVector? biasVector, nuint startIndex)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (sourceMatrices == null)
		{
			throw new ArgumentNullException("sourceMatrices");
		}
		if (resultMatrix == null)
		{
			throw new ArgumentNullException("resultMatrix");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceMatrices);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selEncodeToCommandBuffer_SourceMatrices_ResultMatrix_ScaleVector_OffsetVector_BiasVector_StartIndex_Handle, buffer.Handle, nSArray.Handle, resultMatrix.Handle, scaleVector?.Handle ?? IntPtr.Zero, offsetVector?.Handle ?? IntPtr.Zero, biasVector?.Handle ?? IntPtr.Zero, startIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selEncodeToCommandBuffer_SourceMatrices_ResultMatrix_ScaleVector_OffsetVector_BiasVector_StartIndex_Handle, buffer.Handle, nSArray.Handle, resultMatrix.Handle, scaleVector?.Handle ?? IntPtr.Zero, offsetVector?.Handle ?? IntPtr.Zero, biasVector?.Handle ?? IntPtr.Zero, startIndex);
		}
		nSArray.Dispose();
	}

	[Export("setNeuronType:parameterA:parameterB:parameterC:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeuronType(MPSCnnNeuronType neuronType, float parameterA, float parameterB, float parameterC)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_float_float_float(base.Handle, selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle, (int)neuronType, parameterA, parameterB, parameterC);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_float_float_float(base.SuperHandle, selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle, (int)neuronType, parameterA, parameterB, parameterC);
		}
	}
}
