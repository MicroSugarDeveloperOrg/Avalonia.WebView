using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIDisintegrateWithMaskTransition", WrapperType = typeof(CIDisintegrateWithMaskTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaskImage", Selector = "maskImage", PropertyType = typeof(CIImage), GetterSelector = "maskImage", SetterSelector = "setMaskImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadowRadius", Selector = "shadowRadius", PropertyType = typeof(float), GetterSelector = "shadowRadius", SetterSelector = "setShadowRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadowDensity", Selector = "shadowDensity", PropertyType = typeof(float), GetterSelector = "shadowDensity", SetterSelector = "setShadowDensity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputShadowOffset", Selector = "shadowOffset", PropertyType = typeof(CGPoint), GetterSelector = "shadowOffset", SetterSelector = "setShadowOffset:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIDisintegrateWithMaskTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get;
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float ShadowRadius
	{
		[Export("shadowRadius")]
		get;
		[Export("setShadowRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ShadowDensity
	{
		[Export("shadowDensity")]
		get;
		[Export("setShadowDensity:")]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputShadowOffset
	{
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		get;
		[Export("setShadowOffset:", ArgumentSemantic.Assign)]
		set;
	}
}
