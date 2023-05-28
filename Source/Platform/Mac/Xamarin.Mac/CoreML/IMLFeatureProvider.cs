using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MLFeatureProvider", WrapperType = typeof(MLFeatureProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFeatureValue", Selector = "featureValueForName:", ReturnType = typeof(MLFeatureValue), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FeatureNames", Selector = "featureNames", PropertyType = typeof(NSSet<NSString>), GetterSelector = "featureNames", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMLFeatureProvider : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSSet<NSString> FeatureNames
	{
		[Export("featureNames")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("featureValueForName:")]
	[Preserve(Conditional = true)]
	MLFeatureValue? GetFeatureValue(string featureName);
}
