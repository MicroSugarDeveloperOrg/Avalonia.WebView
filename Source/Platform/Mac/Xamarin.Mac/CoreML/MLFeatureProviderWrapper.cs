using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

internal sealed class MLFeatureProviderWrapper : BaseWrapper, IMLFeatureProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet<NSString> FeatureNames
	{
		[Export("featureNames")]
		get
		{
			return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("featureNames")));
		}
	}

	[Preserve(Conditional = true)]
	public MLFeatureProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("featureValueForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLFeatureValue? GetFeatureValue(string featureName)
	{
		if (featureName == null)
		{
			throw new ArgumentNullException("featureName");
		}
		IntPtr intPtr = NSString.CreateNative(featureName);
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("featureValueForName:"), intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}
