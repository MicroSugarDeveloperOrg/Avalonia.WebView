using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "MKAnnotation", WrapperType = typeof(MKAnnotationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCoordinate", Selector = "setCoordinate:", ParameterType = new Type[] { typeof(CLLocationCoordinate2D) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Coordinate", Selector = "coordinate", PropertyType = typeof(CLLocationCoordinate2D), GetterSelector = "coordinate", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof(string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Subtitle", Selector = "subtitle", PropertyType = typeof(string), GetterSelector = "subtitle", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface IMKAnnotation : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get;
	}
}
