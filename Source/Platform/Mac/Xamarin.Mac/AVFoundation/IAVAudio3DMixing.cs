using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAudio3DMixing", WrapperType = typeof(AVAudio3DMixingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSourceMode", Selector = "sourceMode", ReturnType = typeof(AVAudio3DMixingSourceMode))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSourceMode", Selector = "setSourceMode:", ParameterType = new Type[] { typeof(AVAudio3DMixingSourceMode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPointSourceInHeadMode", Selector = "pointSourceInHeadMode", ReturnType = typeof(AVAudio3DMixingPointSourceInHeadMode))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPointSourceInHeadMode", Selector = "setPointSourceInHeadMode:", ParameterType = new Type[] { typeof(AVAudio3DMixingPointSourceInHeadMode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenderingAlgorithm", Selector = "renderingAlgorithm", PropertyType = typeof(AVAudio3DMixingRenderingAlgorithm), GetterSelector = "renderingAlgorithm", SetterSelector = "setRenderingAlgorithm:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Rate", Selector = "rate", PropertyType = typeof(float), GetterSelector = "rate", SetterSelector = "setRate:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReverbBlend", Selector = "reverbBlend", PropertyType = typeof(float), GetterSelector = "reverbBlend", SetterSelector = "setReverbBlend:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Obstruction", Selector = "obstruction", PropertyType = typeof(float), GetterSelector = "obstruction", SetterSelector = "setObstruction:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Occlusion", Selector = "occlusion", PropertyType = typeof(float), GetterSelector = "occlusion", SetterSelector = "setOcclusion:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Position", Selector = "position", PropertyType = typeof(Vector3), GetterSelector = "position", SetterSelector = "setPosition:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVAudio3DMixing : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm
	{
		[Export("renderingAlgorithm")]
		get;
		[Export("setRenderingAlgorithm:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Rate
	{
		[Export("rate")]
		get;
		[Export("setRate:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ReverbBlend
	{
		[Export("reverbBlend")]
		get;
		[Export("setReverbBlend:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Obstruction
	{
		[Export("obstruction")]
		get;
		[Export("setObstruction:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Occlusion
	{
		[Export("occlusion")]
		get;
		[Export("setOcclusion:")]
		set;
	}

	[Preserve(Conditional = true)]
	Vector3 Position
	{
		[Export("position")]
		get;
		[Export("setPosition:")]
		set;
	}
}
