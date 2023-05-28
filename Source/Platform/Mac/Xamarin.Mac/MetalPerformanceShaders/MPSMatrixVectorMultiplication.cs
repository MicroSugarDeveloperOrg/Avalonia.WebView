using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixVectorMultiplication", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSMatrixVectorMultiplication : MPSMatrixBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InputMatrix_InputVector_ResultVector_ = "encodeToCommandBuffer:inputMatrix:inputVector:resultVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_InputMatrix_InputVector_ResultVector_Handle = Selector.GetHandle("encodeToCommandBuffer:inputMatrix:inputVector:resultVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Rows_Columns_ = "initWithDevice:rows:columns:";

	private static readonly IntPtr selInitWithDevice_Rows_Columns_Handle = Selector.GetHandle("initWithDevice:rows:columns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Transpose_Rows_Columns_Alpha_Beta_ = "initWithDevice:transpose:rows:columns:alpha:beta:";

	private static readonly IntPtr selInitWithDevice_Transpose_Rows_Columns_Alpha_Beta_Handle = Selector.GetHandle("initWithDevice:transpose:rows:columns:alpha:beta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixVectorMultiplication");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixVectorMultiplication(NSCoder coder)
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
	protected MPSMatrixVectorMultiplication(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixVectorMultiplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:transpose:rows:columns:alpha:beta:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixVectorMultiplication(IMTLDevice device, bool transpose, nuint rows, nuint columns, double alpha, double beta)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_nuint_nuint_Double_Double(base.Handle, selInitWithDevice_Transpose_Rows_Columns_Alpha_Beta_Handle, device.Handle, transpose, rows, columns, alpha, beta), "initWithDevice:transpose:rows:columns:alpha:beta:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_nuint_nuint_Double_Double(base.SuperHandle, selInitWithDevice_Transpose_Rows_Columns_Alpha_Beta_Handle, device.Handle, transpose, rows, columns, alpha, beta), "initWithDevice:transpose:rows:columns:alpha:beta:");
		}
	}

	[Export("initWithDevice:rows:columns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixVectorMultiplication(IMTLDevice device, nuint rows, nuint columns)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selInitWithDevice_Rows_Columns_Handle, device.Handle, rows, columns), "initWithDevice:rows:columns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selInitWithDevice_Rows_Columns_Handle, device.Handle, rows, columns), "initWithDevice:rows:columns:");
		}
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixVectorMultiplication(IMTLDevice device)
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
	public MPSMatrixVectorMultiplication(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:inputMatrix:inputVector:resultVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSMatrix inputMatrix, MPSVector inputVector, MPSVector resultVector)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (inputMatrix == null)
		{
			throw new ArgumentNullException("inputMatrix");
		}
		if (inputVector == null)
		{
			throw new ArgumentNullException("inputVector");
		}
		if (resultVector == null)
		{
			throw new ArgumentNullException("resultVector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InputMatrix_InputVector_ResultVector_Handle, commandBuffer.Handle, inputMatrix.Handle, inputVector.Handle, resultVector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InputMatrix_InputVector_ResultVector_Handle, commandBuffer.Handle, inputMatrix.Handle, inputVector.Handle, resultVector.Handle);
		}
	}
}
