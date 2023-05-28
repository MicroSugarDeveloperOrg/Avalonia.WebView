using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIRippleTransition", WrapperType = typeof(CIRippleTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadingImage", Selector = "shadingImage", PropertyType = typeof(CIImage), GetterSelector = "shadingImage", SetterSelector = "setShadingImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputExtent", Selector = "extent", PropertyType = typeof(CGRect), GetterSelector = "extent", SetterSelector = "setExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(float), GetterSelector = "width", SetterSelector = "setWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scale", Selector = "scale", PropertyType = typeof(float), GetterSelector = "scale", SetterSelector = "setScale:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIRippleTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? ShadingImage
	{
		[Export("shadingImage", ArgumentSemantic.Retain)]
		get;
		[Export("setShadingImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get;
		[Export("setCenter:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGRect InputExtent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get;
		[Export("setExtent:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	float Width
	{
		[Export("width")]
		get;
		[Export("setWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Scale
	{
		[Export("scale")]
		get;
		[Export("setScale:")]
		set;
	}
}
