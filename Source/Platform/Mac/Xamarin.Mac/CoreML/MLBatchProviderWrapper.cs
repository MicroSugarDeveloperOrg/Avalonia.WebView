using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

internal sealed class MLBatchProviderWrapper : BaseWrapper, IMLBatchProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint Count
	{
		[Export("count")]
		get
		{
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("count"));
		}
	}

	[Preserve(Conditional = true)]
	public MLBatchProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("featuresAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMLFeatureProvider GetFeatures(nint index)
	{
		return Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, Selector.GetHandle("featuresAtIndex:"), index), owns: false);
	}
}
