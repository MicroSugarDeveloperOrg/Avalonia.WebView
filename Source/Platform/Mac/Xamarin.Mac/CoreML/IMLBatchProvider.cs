using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MLBatchProvider", WrapperType = typeof(MLBatchProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFeatures", Selector = "featuresAtIndex:", ReturnType = typeof(IMLFeatureProvider), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Count", Selector = "count", PropertyType = typeof(nint), GetterSelector = "count", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMLBatchProvider : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	nint Count
	{
		[Export("count")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("featuresAtIndex:")]
	[Preserve(Conditional = true)]
	IMLFeatureProvider GetFeatures(nint index);
}
