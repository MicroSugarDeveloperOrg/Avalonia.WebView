using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CISpotColor", WrapperType = typeof(CISpotColorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor1", Selector = "centerColor1", PropertyType = typeof(CIColor), GetterSelector = "centerColor1", SetterSelector = "setCenterColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor1", Selector = "replacementColor1", PropertyType = typeof(CIColor), GetterSelector = "replacementColor1", SetterSelector = "setReplacementColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness1", Selector = "closeness1", PropertyType = typeof(float), GetterSelector = "closeness1", SetterSelector = "setCloseness1:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast1", Selector = "contrast1", PropertyType = typeof(float), GetterSelector = "contrast1", SetterSelector = "setContrast1:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor2", Selector = "centerColor2", PropertyType = typeof(CIColor), GetterSelector = "centerColor2", SetterSelector = "setCenterColor2:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor2", Selector = "replacementColor2", PropertyType = typeof(CIColor), GetterSelector = "replacementColor2", SetterSelector = "setReplacementColor2:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness2", Selector = "closeness2", PropertyType = typeof(float), GetterSelector = "closeness2", SetterSelector = "setCloseness2:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast2", Selector = "contrast2", PropertyType = typeof(float), GetterSelector = "contrast2", SetterSelector = "setContrast2:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor3", Selector = "centerColor3", PropertyType = typeof(CIColor), GetterSelector = "centerColor3", SetterSelector = "setCenterColor3:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor3", Selector = "replacementColor3", PropertyType = typeof(CIColor), GetterSelector = "replacementColor3", SetterSelector = "setReplacementColor3:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness3", Selector = "closeness3", PropertyType = typeof(float), GetterSelector = "closeness3", SetterSelector = "setCloseness3:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast3", Selector = "contrast3", PropertyType = typeof(float), GetterSelector = "contrast3", SetterSelector = "setContrast3:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICISpotColorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIColor CenterColor1
	{
		[Export("centerColor1", ArgumentSemantic.Retain)]
		get;
		[Export("setCenterColor1:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor ReplacementColor1
	{
		[Export("replacementColor1", ArgumentSemantic.Retain)]
		get;
		[Export("setReplacementColor1:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Closeness1
	{
		[Export("closeness1")]
		get;
		[Export("setCloseness1:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Contrast1
	{
		[Export("contrast1")]
		get;
		[Export("setContrast1:")]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor CenterColor2
	{
		[Export("centerColor2", ArgumentSemantic.Retain)]
		get;
		[Export("setCenterColor2:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor ReplacementColor2
	{
		[Export("replacementColor2", ArgumentSemantic.Retain)]
		get;
		[Export("setReplacementColor2:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Closeness2
	{
		[Export("closeness2")]
		get;
		[Export("setCloseness2:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Contrast2
	{
		[Export("contrast2")]
		get;
		[Export("setContrast2:")]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor CenterColor3
	{
		[Export("centerColor3", ArgumentSemantic.Retain)]
		get;
		[Export("setCenterColor3:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor ReplacementColor3
	{
		[Export("replacementColor3", ArgumentSemantic.Retain)]
		get;
		[Export("setReplacementColor3:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Closeness3
	{
		[Export("closeness3")]
		get;
		[Export("setCloseness3:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Contrast3
	{
		[Export("contrast3")]
		get;
		[Export("setContrast3:")]
		set;
	}
}
