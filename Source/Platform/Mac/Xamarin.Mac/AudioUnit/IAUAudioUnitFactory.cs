using System;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[Protocol(Name = "AUAudioUnitFactory", WrapperType = typeof(AUAudioUnitFactoryWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAudioUnit", Selector = "createAudioUnitWithComponentDescription:error:", ReturnType = typeof(AUAudioUnit), ParameterType = new Type[]
{
	typeof(AudioComponentDescription),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
public interface IAUAudioUnitFactory : INativeObject, IDisposable, INSExtensionRequestHandling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("createAudioUnitWithComponentDescription:error:")]
	[Preserve(Conditional = true)]
	AUAudioUnit? CreateAudioUnit(AudioComponentDescription desc, out NSError? error);
}
