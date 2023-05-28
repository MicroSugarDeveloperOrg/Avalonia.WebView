using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "MKMapViewDelegate", WrapperType = typeof(MKMapViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionWillChange", Selector = "mapView:regionWillChangeAnimated:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionChanged", Selector = "mapView:regionDidChangeAnimated:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLoadingMap", Selector = "mapViewWillStartLoadingMap:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapLoaded", Selector = "mapViewDidFinishLoadingMap:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadingMapFailed", Selector = "mapViewDidFailLoadingMap:withError:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForAnnotation", Selector = "mapView:viewForAnnotation:", ReturnType = typeof(MKAnnotationView), ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(IMKAnnotation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddAnnotationViews", Selector = "mapView:didAddAnnotationViews:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKAnnotationView[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedDragState", Selector = "mapView:annotationView:didChangeDragState:fromOldState:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKAnnotationView),
	typeof(MKAnnotationViewDragState),
	typeof(MKAnnotationViewDragState)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectAnnotationView", Selector = "mapView:didSelectAnnotationView:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKAnnotationView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToLocateUser", Selector = "mapView:didFailToLocateUserWithError:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeselectAnnotationView", Selector = "mapView:didDeselectAnnotationView:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKAnnotationView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLocatingUser", Selector = "mapViewWillStartLocatingUser:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopLocatingUser", Selector = "mapViewDidStopLocatingUser:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateUserLocation", Selector = "mapView:didUpdateUserLocation:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKUserLocation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OverlayRenderer", Selector = "mapView:rendererForOverlay:", ReturnType = typeof(MKOverlayRenderer), ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(IMKOverlay)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddOverlayRenderers", Selector = "mapView:didAddOverlayRenderers:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(MKOverlayRenderer[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartRenderingMap", Selector = "mapViewWillStartRenderingMap:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRenderingMap", Selector = "mapViewDidFinishRenderingMap:fullyRendered:", ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateClusterAnnotation", Selector = "mapView:clusterAnnotationForMemberAnnotations:", ReturnType = typeof(MKClusterAnnotation), ParameterType = new Type[]
{
	typeof(MKMapView),
	typeof(IMKAnnotation[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeVisibleRegion", Selector = "mapViewDidChangeVisibleRegion:", ParameterType = new Type[] { typeof(MKMapView) }, ParameterByRef = new bool[] { false })]
public interface IMKMapViewDelegate : INativeObject, IDisposable
{
}
