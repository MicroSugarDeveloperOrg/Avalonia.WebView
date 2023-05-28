using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Protocol]
[Register("MKMapViewDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapViewDelegate : NSObject, IMKMapViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKMapViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("mapView:annotationView:didChangeDragState:fromOldState:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangedDragState(MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:clusterAnnotationForMemberAnnotations:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKClusterAnnotation CreateClusterAnnotation(MKMapView mapView, IMKAnnotation[] memberAnnotations)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didAddAnnotationViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddAnnotationViews(MKMapView mapView, MKAnnotationView[] views)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didAddOverlayRenderers:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddOverlayRenderers(MKMapView mapView, MKOverlayRenderer[] renderers)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewDidChangeVisibleRegion:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeVisibleRegion(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didDeselectAnnotationView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDeselectAnnotationView(MKMapView mapView, MKAnnotationView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didFailToLocateUserWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailToLocateUser(MKMapView mapView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewDidFinishRenderingMap:fullyRendered:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishRenderingMap(MKMapView mapView, bool fullyRendered)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didSelectAnnotationView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelectAnnotationView(MKMapView mapView, MKAnnotationView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewDidStopLocatingUser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStopLocatingUser(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:didUpdateUserLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUpdateUserLocation(MKMapView mapView, MKUserLocation userLocation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:viewForAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewDidFailLoadingMap:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadingMapFailed(MKMapView mapView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewDidFinishLoadingMap:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MapLoaded(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:rendererForOverlay:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKOverlayRenderer OverlayRenderer(MKMapView mapView, IMKOverlay overlay)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:regionDidChangeAnimated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegionChanged(MKMapView mapView, bool animated)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapView:regionWillChangeAnimated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegionWillChange(MKMapView mapView, bool animated)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewWillStartLoadingMap:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartLoadingMap(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewWillStartLocatingUser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartLocatingUser(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("mapViewWillStartRenderingMap:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartRenderingMap(MKMapView mapView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
