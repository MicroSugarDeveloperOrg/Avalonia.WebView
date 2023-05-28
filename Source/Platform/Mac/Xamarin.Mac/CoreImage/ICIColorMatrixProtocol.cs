using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorMatrix", WrapperType = typeof(CIColorMatrixProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RVector", Selector = "RVector", PropertyType = typeof(CIVector), GetterSelector = "RVector", SetterSelector = "setRVector:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "GVector", Selector = "GVector", PropertyType = typeof(CIVector), GetterSelector = "GVector", SetterSelector = "setGVector:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BVector", Selector = "BVector", PropertyType = typeof(CIVector), GetterSelector = "BVector", SetterSelector = "setBVector:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AVector", Selector = "AVector", PropertyType = typeof(CIVector), GetterSelector = "AVector", SetterSelector = "setAVector:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BiasVector", Selector = "biasVector", PropertyType = typeof(CIVector), GetterSelector = "biasVector", SetterSelector = "setBiasVector:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIColorMatrixProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIVector RVector
	{
		[Export("RVector", ArgumentSemantic.Retain)]
		get;
		[Export("setRVector:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector GVector
	{
		[Export("GVector", ArgumentSemantic.Retain)]
		get;
		[Export("setGVector:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector BVector
	{
		[Export("BVector", ArgumentSemantic.Retain)]
		get;
		[Export("setBVector:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector AVector
	{
		[Export("AVector", ArgumentSemantic.Retain)]
		get;
		[Export("setAVector:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector BiasVector
	{
		[Export("biasVector", ArgumentSemantic.Retain)]
		get;
		[Export("setBiasVector:", ArgumentSemantic.Retain)]
		set;
	}
}
