using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCounterSampleBuffer", WrapperType = typeof(MTLCounterSampleBufferWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResolveCounterRange", Selector = "resolveCounterRange:", ReturnType = typeof(NSData), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SampleCount", Selector = "sampleCount", PropertyType = typeof(nuint), GetterSelector = "sampleCount", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCounterSampleBuffer : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint SampleCount
	{
		[Export("sampleCount")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resolveCounterRange:")]
	[Preserve(Conditional = true)]
	NSData? ResolveCounterRange(NSRange range);
}
