using System;
using CoreML;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CICoreMLModel", WrapperType = typeof(CICoreMLModelProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Model", Selector = "model", PropertyType = typeof(MLModel), GetterSelector = "model", SetterSelector = "setModel:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HeadIndex", Selector = "headIndex", PropertyType = typeof(float), GetterSelector = "headIndex", SetterSelector = "setHeadIndex:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SoftmaxNormalization", Selector = "softmaxNormalization", PropertyType = typeof(bool), GetterSelector = "softmaxNormalization", SetterSelector = "setSoftmaxNormalization:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICICoreMLModelProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get;
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	MLModel Model
	{
		[Export("model", ArgumentSemantic.Retain)]
		get;
		[Export("setModel:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float HeadIndex
	{
		[Export("headIndex")]
		get;
		[Export("setHeadIndex:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool SoftmaxNormalization
	{
		[Export("softmaxNormalization")]
		get;
		[Export("setSoftmaxNormalization:")]
		set;
	}
}
