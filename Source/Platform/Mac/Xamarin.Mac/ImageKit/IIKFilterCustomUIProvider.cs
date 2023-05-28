using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKFilterCustomUIProvider", WrapperType = typeof(IKFilterCustomUIProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideFilterUIView", Selector = "provideViewForUIConfiguration:excludedKeys:", ReturnType = typeof(IKFilterUIView), ParameterType = new Type[]
{
	typeof(NSDictionary),
	typeof(NSArray)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKFilterCustomUIProvider : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("provideViewForUIConfiguration:excludedKeys:")]
	[Preserve(Conditional = true)]
	IKFilterUIView ProvideFilterUIView(NSDictionary configurationOptions, NSArray? excludedKeys);
}
