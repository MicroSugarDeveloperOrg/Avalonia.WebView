using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

internal sealed class MLCustomLayerWrapper : BaseWrapper, IMLCustomLayer, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MLCustomLayerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setWeightData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool SetWeightData(NSData[] weights, out NSError? error)
	{
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(weights);
		bool result = Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("setWeightData:error:"), nSArray.Handle, ref arg);
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("outputShapesForInputShapes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSArray[]? GetOutputShapes(NSArray[] inputShapes, out NSError? error)
	{
		if (inputShapes == null)
		{
			throw new ArgumentNullException("inputShapes");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(inputShapes);
		NSArray[] result = NSArray.ArrayFromHandle<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("outputShapesForInputShapes:error:"), nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("evaluateOnCPUWithInputs:outputs:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool EvaluateOnCpu(MLMultiArray[] inputs, MLMultiArray[] outputs, out NSError? error)
	{
		if (inputs == null)
		{
			throw new ArgumentNullException("inputs");
		}
		if (outputs == null)
		{
			throw new ArgumentNullException("outputs");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(inputs);
		NSArray nSArray2 = NSArray.FromNSObjects(outputs);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("evaluateOnCPUWithInputs:outputs:error:"), nSArray.Handle, nSArray2.Handle, ref arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
