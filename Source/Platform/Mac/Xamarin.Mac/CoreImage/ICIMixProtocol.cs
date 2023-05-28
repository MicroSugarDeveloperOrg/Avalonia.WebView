using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIMix", WrapperType = typeof(CIMixProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BackgroundImage", Selector = "backgroundImage", PropertyType = typeof(CIImage), GetterSelector = "backgroundImage", SetterSelector = "setBackgroundImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Amount", Selector = "amount", PropertyType = typeof(float), GetterSelector = "amount", SetterSelector = "setAmount:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIMixProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? BackgroundImage
	{
		[Export("backgroundImage", ArgumentSemantic.Retain)]
		get;
		[Export("setBackgroundImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Amount
	{
		[Export("amount")]
		get;
		[Export("setAmount:")]
		set;
	}
}
