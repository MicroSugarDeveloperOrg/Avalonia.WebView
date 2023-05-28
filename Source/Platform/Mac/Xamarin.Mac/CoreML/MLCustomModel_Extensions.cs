using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

public static class MLCustomModel_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMLBatchProvider? GetPredictions(this IMLCustomModel This, IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
	{
		if (inputBatch == null)
		{
			throw new ArgumentNullException("inputBatch");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IMLBatchProvider iNativeObject = Runtime.GetINativeObject<IMLBatchProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("predictionsFromBatch:options:error:"), inputBatch.Handle, options.Handle, ref arg), owns: false);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}
}
