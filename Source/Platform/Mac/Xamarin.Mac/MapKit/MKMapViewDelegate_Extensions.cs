using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

public static class MKMapViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegionWillChange(this IMKMapViewDelegate This, MKMapView mapView, bool animated)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("mapView:regionWillChangeAnimated:"), mapView.Handle, animated);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegionChanged(this IMKMapViewDelegate This, MKMapView mapView, bool animated)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("mapView:regionDidChangeAnimated:"), mapView.Handle, animated);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartLoadingMap(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewWillStartLoadingMap:"), mapView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MapLoaded(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewDidFinishLoadingMap:"), mapView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadingMapFailed(this IMKMapViewDelegate This, MKMapView mapView, NSError error)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapViewDidFailLoadingMap:withError:"), mapView.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKAnnotationView GetViewForAnnotation(this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		return Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:viewForAnnotation:"), mapView.Handle, annotation.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddAnnotationViews(this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView[] views)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didAddAnnotationViews:"), mapView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangedDragState(this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (annotationView == null)
		{
			throw new ArgumentNullException("annotationView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64(This.Handle, Selector.GetHandle("mapView:annotationView:didChangeDragState:fromOldState:"), mapView.Handle, annotationView.Handle, (ulong)newState, (ulong)oldState);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSelectAnnotationView(this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didSelectAnnotationView:"), mapView.Handle, view.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailToLocateUser(this IMKMapViewDelegate This, MKMapView mapView, NSError error)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didFailToLocateUserWithError:"), mapView.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDeselectAnnotationView(this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didDeselectAnnotationView:"), mapView.Handle, view.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartLocatingUser(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewWillStartLocatingUser:"), mapView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStopLocatingUser(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewDidStopLocatingUser:"), mapView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdateUserLocation(this IMKMapViewDelegate This, MKMapView mapView, MKUserLocation userLocation)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (userLocation == null)
		{
			throw new ArgumentNullException("userLocation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didUpdateUserLocation:"), mapView.Handle, userLocation.Handle);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKOverlayRenderer OverlayRenderer(this IMKMapViewDelegate This, MKMapView mapView, IMKOverlay overlay)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		return Runtime.GetNSObject<MKOverlayRenderer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:rendererForOverlay:"), mapView.Handle, overlay.Handle));
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddOverlayRenderers(this IMKMapViewDelegate This, MKMapView mapView, MKOverlayRenderer[] renderers)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (renderers == null)
		{
			throw new ArgumentNullException("renderers");
		}
		NSArray nSArray = NSArray.FromNSObjects(renderers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:didAddOverlayRenderers:"), mapView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartRenderingMap(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewWillStartRenderingMap:"), mapView.Handle);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishRenderingMap(this IMKMapViewDelegate This, MKMapView mapView, bool fullyRendered)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("mapViewDidFinishRenderingMap:fullyRendered:"), mapView.Handle, fullyRendered);
	}

	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKClusterAnnotation CreateClusterAnnotation(this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation[] memberAnnotations)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		if (memberAnnotations == null)
		{
			throw new ArgumentNullException("memberAnnotations");
		}
		NSArray nSArray = NSArray.FromNSObjects(memberAnnotations);
		MKClusterAnnotation nSObject = Runtime.GetNSObject<MKClusterAnnotation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("mapView:clusterAnnotationForMemberAnnotations:"), mapView.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeVisibleRegion(this IMKMapViewDelegate This, MKMapView mapView)
	{
		if (mapView == null)
		{
			throw new ArgumentNullException("mapView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("mapViewDidChangeVisibleRegion:"), mapView.Handle);
	}
}
