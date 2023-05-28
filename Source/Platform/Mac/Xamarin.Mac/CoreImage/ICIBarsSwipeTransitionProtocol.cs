using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIBarsSwipeTransition", WrapperType = typeof(CIBarsSwipeTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Angle", Selector = "angle", PropertyType = typeof(float), GetterSelector = "angle", SetterSelector = "setAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(float), GetterSelector = "width", SetterSelector = "setWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BarOffset", Selector = "barOffset", PropertyType = typeof(float), GetterSelector = "barOffset", SetterSelector = "setBarOffset:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIBarsSwipeTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Preserve(Conditional = true)]
	float Angle
	{
		[Export("angle")]
		get;
		[Export("setAngle:")]
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
	float BarOffset
	{
		[Export("barOffset")]
		get;
		[Export("setBarOffset:")]
		set;
	}
}
