using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "MKOverlay", WrapperType = typeof(MKOverlayWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Intersects", Selector = "intersectsMapRect:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MKMapRect) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BoundingMapRect", Selector = "boundingMapRect", PropertyType = typeof(MKMapRect), GetterSelector = "boundingMapRect", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CanReplaceMapContent", Selector = "canReplaceMapContent", PropertyType = typeof(bool), GetterSelector = "canReplaceMapContent", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMKOverlay : INativeObject, IDisposable, IMKAnnotation
{
	[Preserve(Conditional = true)]
	MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get;
	}
}
