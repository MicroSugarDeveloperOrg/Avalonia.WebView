using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

internal sealed class MLCustomModelWrapper : BaseWrapper, IMLCustomModel, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MLCustomModelWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("predictionFromFeatures:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMLFeatureProvider? GetPrediction(IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error)
	{
		if (inputFeatures == null)
		{
			throw new ArgumentNullException("inputFeatures");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IMLFeatureProvider iNativeObject = Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("predictionFromFeatures:options:error:"), inputFeatures.Handle, options.Handle, ref arg), owns: false);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}
}
