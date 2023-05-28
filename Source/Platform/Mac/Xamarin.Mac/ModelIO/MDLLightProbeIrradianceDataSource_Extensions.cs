using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

public static class MDLLightProbeIrradianceDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData GetSphericalHarmonicsCoefficients(this IMDLLightProbeIrradianceDataSource This, Vector3 position)
	{
		return Runtime.GetNSObject<NSData>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3(This.Handle, Selector.GetHandle("sphericalHarmonicsCoefficientsAtPosition:"), position));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetSphericalHarmonicsLevel(this IMDLLightProbeIrradianceDataSource This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("sphericalHarmonicsLevel"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSphericalHarmonicsLevel(this IMDLLightProbeIrradianceDataSource This, nuint value)
	{
		Messaging.void_objc_msgSend_nuint(This.Handle, Selector.GetHandle("setSphericalHarmonicsLevel:"), value);
	}
}
