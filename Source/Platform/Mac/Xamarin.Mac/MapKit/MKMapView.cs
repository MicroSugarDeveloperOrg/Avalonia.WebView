using System.ComponentModel;
using AppKit;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MapKit;

[Register("MKMapView", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapView : NSView
{
	[Register]
	internal class _MKMapViewDelegate : NSObject, IMKMapViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<MKMapViewDragStateEventArgs>? changedDragState;

		internal MKCreateClusterAnnotation? createClusterAnnotation;

		internal EventHandler<MKMapViewAnnotationEventArgs>? didAddAnnotationViews;

		internal EventHandler<MKDidAddOverlayRenderersEventArgs>? didAddOverlayRenderers;

		internal EventHandler? didChangeVisibleRegion;

		internal EventHandler<MKAnnotationViewEventArgs>? didDeselectAnnotationView;

		internal EventHandler<NSErrorEventArgs>? didFailToLocateUser;

		internal EventHandler<MKDidFinishRenderingMapEventArgs>? didFinishRenderingMap;

		internal EventHandler<MKAnnotationViewEventArgs>? didSelectAnnotationView;

		internal EventHandler? didStopLocatingUser;

		internal EventHandler<MKUserLocationEventArgs>? didUpdateUserLocation;

		internal MKMapViewAnnotation? getViewForAnnotation;

		internal EventHandler<NSErrorEventArgs>? loadingMapFailed;

		internal EventHandler? mapLoaded;

		internal MKRendererForOverlayDelegate? overlayRenderer;

		internal EventHandler<MKMapViewChangeEventArgs>? regionChanged;

		internal EventHandler<MKMapViewChangeEventArgs>? regionWillChange;

		internal EventHandler? willStartLoadingMap;

		internal EventHandler? willStartLocatingUser;

		internal EventHandler? willStartRenderingMap;

		public _MKMapViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("mapView:annotationView:didChangeDragState:fromOldState:")]
		public void ChangedDragState(MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			EventHandler<MKMapViewDragStateEventArgs> eventHandler = changedDragState;
			if (eventHandler != null)
			{
				MKMapViewDragStateEventArgs e = new MKMapViewDragStateEventArgs(annotationView, newState, oldState);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:clusterAnnotationForMemberAnnotations:")]
		public MKClusterAnnotation CreateClusterAnnotation(MKMapView mapView, IMKAnnotation[] memberAnnotations)
		{
			return createClusterAnnotation?.Invoke(mapView, memberAnnotations);
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didAddAnnotationViews:")]
		public void DidAddAnnotationViews(MKMapView mapView, MKAnnotationView[] views)
		{
			EventHandler<MKMapViewAnnotationEventArgs> eventHandler = didAddAnnotationViews;
			if (eventHandler != null)
			{
				MKMapViewAnnotationEventArgs e = new MKMapViewAnnotationEventArgs(views);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didAddOverlayRenderers:")]
		public void DidAddOverlayRenderers(MKMapView mapView, MKOverlayRenderer[] renderers)
		{
			EventHandler<MKDidAddOverlayRenderersEventArgs> eventHandler = didAddOverlayRenderers;
			if (eventHandler != null)
			{
				MKDidAddOverlayRenderersEventArgs e = new MKDidAddOverlayRenderersEventArgs(renderers);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapViewDidChangeVisibleRegion:")]
		public void DidChangeVisibleRegion(MKMapView mapView)
		{
			didChangeVisibleRegion?.Invoke(mapView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didDeselectAnnotationView:")]
		public void DidDeselectAnnotationView(MKMapView mapView, MKAnnotationView view)
		{
			EventHandler<MKAnnotationViewEventArgs> eventHandler = didDeselectAnnotationView;
			if (eventHandler != null)
			{
				MKAnnotationViewEventArgs e = new MKAnnotationViewEventArgs(view);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didFailToLocateUserWithError:")]
		public void DidFailToLocateUser(MKMapView mapView, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = didFailToLocateUser;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapViewDidFinishRenderingMap:fullyRendered:")]
		public void DidFinishRenderingMap(MKMapView mapView, bool fullyRendered)
		{
			EventHandler<MKDidFinishRenderingMapEventArgs> eventHandler = didFinishRenderingMap;
			if (eventHandler != null)
			{
				MKDidFinishRenderingMapEventArgs e = new MKDidFinishRenderingMapEventArgs(fullyRendered);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didSelectAnnotationView:")]
		public void DidSelectAnnotationView(MKMapView mapView, MKAnnotationView view)
		{
			EventHandler<MKAnnotationViewEventArgs> eventHandler = didSelectAnnotationView;
			if (eventHandler != null)
			{
				MKAnnotationViewEventArgs e = new MKAnnotationViewEventArgs(view);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapViewDidStopLocatingUser:")]
		public void DidStopLocatingUser(MKMapView mapView)
		{
			didStopLocatingUser?.Invoke(mapView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("mapView:didUpdateUserLocation:")]
		public void DidUpdateUserLocation(MKMapView mapView, MKUserLocation userLocation)
		{
			EventHandler<MKUserLocationEventArgs> eventHandler = didUpdateUserLocation;
			if (eventHandler != null)
			{
				MKUserLocationEventArgs e = new MKUserLocationEventArgs(userLocation);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:viewForAnnotation:")]
		public MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
		{
			return getViewForAnnotation?.Invoke(mapView, annotation);
		}

		[Preserve(Conditional = true)]
		[Export("mapViewDidFailLoadingMap:withError:")]
		public void LoadingMapFailed(MKMapView mapView, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = loadingMapFailed;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapViewDidFinishLoadingMap:")]
		public void MapLoaded(MKMapView mapView)
		{
			mapLoaded?.Invoke(mapView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("mapView:rendererForOverlay:")]
		public MKOverlayRenderer OverlayRenderer(MKMapView mapView, IMKOverlay overlay)
		{
			return overlayRenderer?.Invoke(mapView, overlay);
		}

		[Preserve(Conditional = true)]
		[Export("mapView:regionDidChangeAnimated:")]
		public void RegionChanged(MKMapView mapView, bool animated)
		{
			EventHandler<MKMapViewChangeEventArgs> eventHandler = regionChanged;
			if (eventHandler != null)
			{
				MKMapViewChangeEventArgs e = new MKMapViewChangeEventArgs(animated);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapView:regionWillChangeAnimated:")]
		public void RegionWillChange(MKMapView mapView, bool animated)
		{
			EventHandler<MKMapViewChangeEventArgs> eventHandler = regionWillChange;
			if (eventHandler != null)
			{
				MKMapViewChangeEventArgs e = new MKMapViewChangeEventArgs(animated);
				eventHandler(mapView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("mapViewWillStartLoadingMap:")]
		public void WillStartLoadingMap(MKMapView mapView)
		{
			willStartLoadingMap?.Invoke(mapView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("mapViewWillStartLocatingUser:")]
		public void WillStartLocatingUser(MKMapView mapView)
		{
			willStartLocatingUser?.Invoke(mapView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("mapViewWillStartRenderingMap:")]
		public void WillStartRenderingMap(MKMapView mapView)
		{
			willStartRenderingMap?.Invoke(mapView, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnnotation_ = "addAnnotation:";

	private static readonly IntPtr selAddAnnotation_Handle = Selector.GetHandle("addAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnnotations_ = "addAnnotations:";

	private static readonly IntPtr selAddAnnotations_Handle = Selector.GetHandle("addAnnotations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOverlay_ = "addOverlay:";

	private static readonly IntPtr selAddOverlay_Handle = Selector.GetHandle("addOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOverlay_Level_ = "addOverlay:level:";

	private static readonly IntPtr selAddOverlay_Level_Handle = Selector.GetHandle("addOverlay:level:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOverlays_ = "addOverlays:";

	private static readonly IntPtr selAddOverlays_Handle = Selector.GetHandle("addOverlays:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOverlays_Level_ = "addOverlays:level:";

	private static readonly IntPtr selAddOverlays_Level_Handle = Selector.GetHandle("addOverlays:level:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotationVisibleRect = "annotationVisibleRect";

	private static readonly IntPtr selAnnotationVisibleRectHandle = Selector.GetHandle("annotationVisibleRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotations = "annotations";

	private static readonly IntPtr selAnnotationsHandle = Selector.GetHandle("annotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotationsInMapRect_ = "annotationsInMapRect:";

	private static readonly IntPtr selAnnotationsInMapRect_Handle = Selector.GetHandle("annotationsInMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCamera = "camera";

	private static readonly IntPtr selCameraHandle = Selector.GetHandle("camera");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraBoundary = "cameraBoundary";

	private static readonly IntPtr selCameraBoundaryHandle = Selector.GetHandle("cameraBoundary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraZoomRange = "cameraZoomRange";

	private static readonly IntPtr selCameraZoomRangeHandle = Selector.GetHandle("cameraZoomRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterCoordinate = "centerCoordinate";

	private static readonly IntPtr selCenterCoordinateHandle = Selector.GetHandle("centerCoordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertCoordinate_ToPointToView_ = "convertCoordinate:toPointToView:";

	private static readonly IntPtr selConvertCoordinate_ToPointToView_Handle = Selector.GetHandle("convertCoordinate:toPointToView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToCoordinateFromView_ = "convertPoint:toCoordinateFromView:";

	private static readonly IntPtr selConvertPoint_ToCoordinateFromView_Handle = Selector.GetHandle("convertPoint:toCoordinateFromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_ToRegionFromView_ = "convertRect:toRegionFromView:";

	private static readonly IntPtr selConvertRect_ToRegionFromView_Handle = Selector.GetHandle("convertRect:toRegionFromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRegion_ToRectToView_ = "convertRegion:toRectToView:";

	private static readonly IntPtr selConvertRegion_ToRectToView_Handle = Selector.GetHandle("convertRegion:toRectToView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDequeueReusableAnnotationViewWithIdentifier_ = "dequeueReusableAnnotationViewWithIdentifier:";

	private static readonly IntPtr selDequeueReusableAnnotationViewWithIdentifier_Handle = Selector.GetHandle("dequeueReusableAnnotationViewWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_ = "dequeueReusableAnnotationViewWithIdentifier:forAnnotation:";

	private static readonly IntPtr selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_Handle = Selector.GetHandle("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectAnnotation_Animated_ = "deselectAnnotation:animated:";

	private static readonly IntPtr selDeselectAnnotation_Animated_Handle = Selector.GetHandle("deselectAnnotation:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeOverlay_WithOverlay_ = "exchangeOverlay:withOverlay:";

	private static readonly IntPtr selExchangeOverlay_WithOverlay_Handle = Selector.GetHandle("exchangeOverlay:withOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeOverlayAtIndex_WithOverlayAtIndex_ = "exchangeOverlayAtIndex:withOverlayAtIndex:";

	private static readonly IntPtr selExchangeOverlayAtIndex_WithOverlayAtIndex_Handle = Selector.GetHandle("exchangeOverlayAtIndex:withOverlayAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertOverlay_AboveOverlay_ = "insertOverlay:aboveOverlay:";

	private static readonly IntPtr selInsertOverlay_AboveOverlay_Handle = Selector.GetHandle("insertOverlay:aboveOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertOverlay_AtIndex_ = "insertOverlay:atIndex:";

	private static readonly IntPtr selInsertOverlay_AtIndex_Handle = Selector.GetHandle("insertOverlay:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertOverlay_AtIndex_Level_ = "insertOverlay:atIndex:level:";

	private static readonly IntPtr selInsertOverlay_AtIndex_Level_Handle = Selector.GetHandle("insertOverlay:atIndex:level:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertOverlay_BelowOverlay_ = "insertOverlay:belowOverlay:";

	private static readonly IntPtr selInsertOverlay_BelowOverlay_Handle = Selector.GetHandle("insertOverlay:belowOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPitchEnabled = "isPitchEnabled";

	private static readonly IntPtr selIsPitchEnabledHandle = Selector.GetHandle("isPitchEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRotateEnabled = "isRotateEnabled";

	private static readonly IntPtr selIsRotateEnabledHandle = Selector.GetHandle("isRotateEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsScrollEnabled = "isScrollEnabled";

	private static readonly IntPtr selIsScrollEnabledHandle = Selector.GetHandle("isScrollEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUserLocationVisible = "isUserLocationVisible";

	private static readonly IntPtr selIsUserLocationVisibleHandle = Selector.GetHandle("isUserLocationVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsZoomEnabled = "isZoomEnabled";

	private static readonly IntPtr selIsZoomEnabledHandle = Selector.GetHandle("isZoomEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapRectThatFits_ = "mapRectThatFits:";

	private static readonly IntPtr selMapRectThatFits_Handle = Selector.GetHandle("mapRectThatFits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapRectThatFits_EdgePadding_ = "mapRectThatFits:edgePadding:";

	private static readonly IntPtr selMapRectThatFits_EdgePadding_Handle = Selector.GetHandle("mapRectThatFits:edgePadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapType = "mapType";

	private static readonly IntPtr selMapTypeHandle = Selector.GetHandle("mapType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlays = "overlays";

	private static readonly IntPtr selOverlaysHandle = Selector.GetHandle("overlays");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlaysInLevel_ = "overlaysInLevel:";

	private static readonly IntPtr selOverlaysInLevel_Handle = Selector.GetHandle("overlaysInLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfInterestFilter = "pointOfInterestFilter";

	private static readonly IntPtr selPointOfInterestFilterHandle = Selector.GetHandle("pointOfInterestFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegion = "region";

	private static readonly IntPtr selRegionHandle = Selector.GetHandle("region");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionThatFits_ = "regionThatFits:";

	private static readonly IntPtr selRegionThatFits_Handle = Selector.GetHandle("regionThatFits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ForAnnotationViewWithReuseIdentifier_ = "registerClass:forAnnotationViewWithReuseIdentifier:";

	private static readonly IntPtr selRegisterClass_ForAnnotationViewWithReuseIdentifier_Handle = Selector.GetHandle("registerClass:forAnnotationViewWithReuseIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnnotation_ = "removeAnnotation:";

	private static readonly IntPtr selRemoveAnnotation_Handle = Selector.GetHandle("removeAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnnotations_ = "removeAnnotations:";

	private static readonly IntPtr selRemoveAnnotations_Handle = Selector.GetHandle("removeAnnotations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOverlay_ = "removeOverlay:";

	private static readonly IntPtr selRemoveOverlay_Handle = Selector.GetHandle("removeOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOverlays_ = "removeOverlays:";

	private static readonly IntPtr selRemoveOverlays_Handle = Selector.GetHandle("removeOverlays:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRendererForOverlay_ = "rendererForOverlay:";

	private static readonly IntPtr selRendererForOverlay_Handle = Selector.GetHandle("rendererForOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAnnotation_Animated_ = "selectAnnotation:animated:";

	private static readonly IntPtr selSelectAnnotation_Animated_Handle = Selector.GetHandle("selectAnnotation:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedAnnotations = "selectedAnnotations";

	private static readonly IntPtr selSelectedAnnotationsHandle = Selector.GetHandle("selectedAnnotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCamera_ = "setCamera:";

	private static readonly IntPtr selSetCamera_Handle = Selector.GetHandle("setCamera:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCamera_Animated_ = "setCamera:animated:";

	private static readonly IntPtr selSetCamera_Animated_Handle = Selector.GetHandle("setCamera:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraBoundary_ = "setCameraBoundary:";

	private static readonly IntPtr selSetCameraBoundary_Handle = Selector.GetHandle("setCameraBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraBoundary_Animated_ = "setCameraBoundary:animated:";

	private static readonly IntPtr selSetCameraBoundary_Animated_Handle = Selector.GetHandle("setCameraBoundary:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraZoomRange_ = "setCameraZoomRange:";

	private static readonly IntPtr selSetCameraZoomRange_Handle = Selector.GetHandle("setCameraZoomRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraZoomRange_Animated_ = "setCameraZoomRange:animated:";

	private static readonly IntPtr selSetCameraZoomRange_Animated_Handle = Selector.GetHandle("setCameraZoomRange:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterCoordinate_ = "setCenterCoordinate:";

	private static readonly IntPtr selSetCenterCoordinate_Handle = Selector.GetHandle("setCenterCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterCoordinate_Animated_ = "setCenterCoordinate:animated:";

	private static readonly IntPtr selSetCenterCoordinate_Animated_Handle = Selector.GetHandle("setCenterCoordinate:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMapType_ = "setMapType:";

	private static readonly IntPtr selSetMapType_Handle = Selector.GetHandle("setMapType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPitchEnabled_ = "setPitchEnabled:";

	private static readonly IntPtr selSetPitchEnabled_Handle = Selector.GetHandle("setPitchEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfInterestFilter_ = "setPointOfInterestFilter:";

	private static readonly IntPtr selSetPointOfInterestFilter_Handle = Selector.GetHandle("setPointOfInterestFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegion_ = "setRegion:";

	private static readonly IntPtr selSetRegion_Handle = Selector.GetHandle("setRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegion_Animated_ = "setRegion:animated:";

	private static readonly IntPtr selSetRegion_Animated_Handle = Selector.GetHandle("setRegion:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotateEnabled_ = "setRotateEnabled:";

	private static readonly IntPtr selSetRotateEnabled_Handle = Selector.GetHandle("setRotateEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollEnabled_ = "setScrollEnabled:";

	private static readonly IntPtr selSetScrollEnabled_Handle = Selector.GetHandle("setScrollEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedAnnotations_ = "setSelectedAnnotations:";

	private static readonly IntPtr selSetSelectedAnnotations_Handle = Selector.GetHandle("setSelectedAnnotations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsBuildings_ = "setShowsBuildings:";

	private static readonly IntPtr selSetShowsBuildings_Handle = Selector.GetHandle("setShowsBuildings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsCompass_ = "setShowsCompass:";

	private static readonly IntPtr selSetShowsCompass_Handle = Selector.GetHandle("setShowsCompass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsPointsOfInterest_ = "setShowsPointsOfInterest:";

	private static readonly IntPtr selSetShowsPointsOfInterest_Handle = Selector.GetHandle("setShowsPointsOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsScale_ = "setShowsScale:";

	private static readonly IntPtr selSetShowsScale_Handle = Selector.GetHandle("setShowsScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsTraffic_ = "setShowsTraffic:";

	private static readonly IntPtr selSetShowsTraffic_Handle = Selector.GetHandle("setShowsTraffic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsUserLocation_ = "setShowsUserLocation:";

	private static readonly IntPtr selSetShowsUserLocation_Handle = Selector.GetHandle("setShowsUserLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsZoomControls_ = "setShowsZoomControls:";

	private static readonly IntPtr selSetShowsZoomControls_Handle = Selector.GetHandle("setShowsZoomControls:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibleMapRect_ = "setVisibleMapRect:";

	private static readonly IntPtr selSetVisibleMapRect_Handle = Selector.GetHandle("setVisibleMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibleMapRect_Animated_ = "setVisibleMapRect:animated:";

	private static readonly IntPtr selSetVisibleMapRect_Animated_Handle = Selector.GetHandle("setVisibleMapRect:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibleMapRect_EdgePadding_Animated_ = "setVisibleMapRect:edgePadding:animated:";

	private static readonly IntPtr selSetVisibleMapRect_EdgePadding_Animated_Handle = Selector.GetHandle("setVisibleMapRect:edgePadding:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoomEnabled_ = "setZoomEnabled:";

	private static readonly IntPtr selSetZoomEnabled_Handle = Selector.GetHandle("setZoomEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowAnnotations_Animated_ = "showAnnotations:animated:";

	private static readonly IntPtr selShowAnnotations_Animated_Handle = Selector.GetHandle("showAnnotations:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsBuildings = "showsBuildings";

	private static readonly IntPtr selShowsBuildingsHandle = Selector.GetHandle("showsBuildings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsCompass = "showsCompass";

	private static readonly IntPtr selShowsCompassHandle = Selector.GetHandle("showsCompass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsPointsOfInterest = "showsPointsOfInterest";

	private static readonly IntPtr selShowsPointsOfInterestHandle = Selector.GetHandle("showsPointsOfInterest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsScale = "showsScale";

	private static readonly IntPtr selShowsScaleHandle = Selector.GetHandle("showsScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsTraffic = "showsTraffic";

	private static readonly IntPtr selShowsTrafficHandle = Selector.GetHandle("showsTraffic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsUserLocation = "showsUserLocation";

	private static readonly IntPtr selShowsUserLocationHandle = Selector.GetHandle("showsUserLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsZoomControls = "showsZoomControls";

	private static readonly IntPtr selShowsZoomControlsHandle = Selector.GetHandle("showsZoomControls");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserLocation = "userLocation";

	private static readonly IntPtr selUserLocationHandle = Selector.GetHandle("userLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewForAnnotation_ = "viewForAnnotation:";

	private static readonly IntPtr selViewForAnnotation_Handle = Selector.GetHandle("viewForAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleMapRect = "visibleMapRect";

	private static readonly IntPtr selVisibleMapRectHandle = Selector.GetHandle("visibleMapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect AnnotationVisibleRect
	{
		[Export("annotationVisibleRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAnnotationVisibleRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAnnotationVisibleRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKAnnotation[] Annotations
	{
		[Export("annotations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnnotationsHandle));
			}
			return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnnotationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual MKMapCamera Camera
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("camera", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraHandle));
			}
			return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setCamera:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCamera_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCamera_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKMapCameraBoundary? CameraBoundary
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("cameraBoundary", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapCameraBoundary>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraBoundaryHandle));
			}
			return Runtime.GetNSObject<MKMapCameraBoundary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraBoundaryHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setCameraBoundary:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCameraBoundary_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCameraBoundary_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKMapCameraZoomRange CameraZoomRange
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("cameraZoomRange", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapCameraZoomRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraZoomRangeHandle));
			}
			return Runtime.GetNSObject<MKMapCameraZoomRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraZoomRangeHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setCameraZoomRange:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCameraZoomRange_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCameraZoomRange_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D CenterCoordinate
	{
		[Export("centerCoordinate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCenterCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCenterCoordinateHandle);
		}
		[Export("setCenterCoordinate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CLLocationCoordinate2D(base.Handle, selSetCenterCoordinate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selSetCenterCoordinate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMKMapViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IMKMapViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapType MapType
	{
		[Export("mapType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKMapType)Messaging.UInt64_objc_msgSend(base.Handle, selMapTypeHandle);
			}
			return (MKMapType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMapTypeHandle);
		}
		[Export("setMapType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMapType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMapType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKOverlay[] Overlays
	{
		[Export("overlays")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMKOverlay>(Messaging.IntPtr_objc_msgSend(base.Handle, selOverlaysHandle));
			}
			return NSArray.ArrayFromHandle<IMKOverlay>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOverlaysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool PitchEnabled
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("isPitchEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPitchEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPitchEnabledHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setPitchEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPitchEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPitchEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKPointOfInterestFilter? PointOfInterestFilter
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pointOfInterestFilter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfInterestFilterHandle));
			}
			return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfInterestFilterHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPointOfInterestFilter:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion Region
	{
		[Export("region")]
		get
		{
			MKCoordinateRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKCoordinateRegion_objc_msgSend_stret(out retval, base.Handle, selRegionHandle);
			}
			else
			{
				Messaging.MKCoordinateRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRegionHandle);
			}
			return retval;
		}
		[Export("setRegion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MKCoordinateRegion(base.Handle, selSetRegion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MKCoordinateRegion(base.SuperHandle, selSetRegion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool RotateEnabled
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("isRotateEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRotateEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRotateEnabledHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setRotateEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRotateEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRotateEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ScrollEnabled
	{
		[Export("isScrollEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsScrollEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsScrollEnabledHandle);
		}
		[Export("setScrollEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKAnnotation[]? SelectedAnnotations
	{
		[Export("selectedAnnotations", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedAnnotationsHandle));
			}
			return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedAnnotationsHandle));
		}
		[Export("setSelectedAnnotations:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedAnnotations_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedAnnotations_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool ShowsBuildings
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("showsBuildings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBuildingsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBuildingsHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setShowsBuildings:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBuildings_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBuildings_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool ShowsCompass
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("showsCompass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsCompassHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsCompassHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setShowsCompass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsCompass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsCompass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool ShowsPointsOfInterest
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("showsPointsOfInterest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPointsOfInterestHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPointsOfInterestHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setShowsPointsOfInterest:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsPointsOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsPointsOfInterest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool ShowsScale
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("showsScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsScaleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsScaleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setShowsScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool ShowsTraffic
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("showsTraffic")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsTrafficHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsTrafficHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setShowsTraffic:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsTraffic_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsTraffic_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsUserLocation
	{
		[Export("showsUserLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsUserLocationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsUserLocationHandle);
		}
		[Export("setShowsUserLocation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsUserLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsUserLocation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsZoomControls
	{
		[Export("showsZoomControls")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsZoomControlsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsZoomControlsHandle);
		}
		[Export("setShowsZoomControls:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsZoomControls_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsZoomControls_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKUserLocation UserLocation
	{
		[Export("userLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKUserLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserLocationHandle));
			}
			return Runtime.GetNSObject<MKUserLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UserLocationVisible
	{
		[Export("isUserLocationVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUserLocationVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUserLocationVisibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapRect VisibleMapRect
	{
		[Export("visibleMapRect")]
		get
		{
			MKMapRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKMapRect_objc_msgSend_stret(out retval, base.Handle, selVisibleMapRectHandle);
			}
			else
			{
				Messaging.MKMapRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVisibleMapRectHandle);
			}
			return retval;
		}
		[Export("setVisibleMapRect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MKMapRect(base.Handle, selSetVisibleMapRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MKMapRect(base.SuperHandle, selSetVisibleMapRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ZoomEnabled
	{
		[Export("isZoomEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsZoomEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsZoomEnabledHandle);
		}
		[Export("setZoomEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZoomEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZoomEnabled_Handle, value);
			}
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_MKMapViewDelegate);

	public MKCreateClusterAnnotation? CreateClusterAnnotation
	{
		get
		{
			return EnsureMKMapViewDelegate().createClusterAnnotation;
		}
		set
		{
			EnsureMKMapViewDelegate().createClusterAnnotation = value;
		}
	}

	public MKMapViewAnnotation? GetViewForAnnotation
	{
		get
		{
			return EnsureMKMapViewDelegate().getViewForAnnotation;
		}
		set
		{
			EnsureMKMapViewDelegate().getViewForAnnotation = value;
		}
	}

	public MKRendererForOverlayDelegate? OverlayRenderer
	{
		get
		{
			return EnsureMKMapViewDelegate().overlayRenderer;
		}
		set
		{
			EnsureMKMapViewDelegate().overlayRenderer = value;
		}
	}

	public event EventHandler<MKMapViewDragStateEventArgs> ChangedDragState
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.changedDragState = (EventHandler<MKMapViewDragStateEventArgs>)System.Delegate.Combine(mKMapViewDelegate.changedDragState, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.changedDragState = (EventHandler<MKMapViewDragStateEventArgs>)System.Delegate.Remove(mKMapViewDelegate.changedDragState, value);
		}
	}

	public event EventHandler<MKMapViewAnnotationEventArgs> DidAddAnnotationViews
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didAddAnnotationViews = (EventHandler<MKMapViewAnnotationEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didAddAnnotationViews, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didAddAnnotationViews = (EventHandler<MKMapViewAnnotationEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didAddAnnotationViews, value);
		}
	}

	public event EventHandler<MKDidAddOverlayRenderersEventArgs> DidAddOverlayRenderers
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didAddOverlayRenderers = (EventHandler<MKDidAddOverlayRenderersEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didAddOverlayRenderers, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didAddOverlayRenderers = (EventHandler<MKDidAddOverlayRenderersEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didAddOverlayRenderers, value);
		}
	}

	public event EventHandler DidChangeVisibleRegion
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didChangeVisibleRegion = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.didChangeVisibleRegion, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didChangeVisibleRegion = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.didChangeVisibleRegion, value);
		}
	}

	public event EventHandler<MKAnnotationViewEventArgs> DidDeselectAnnotationView
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didDeselectAnnotationView = (EventHandler<MKAnnotationViewEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didDeselectAnnotationView, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didDeselectAnnotationView = (EventHandler<MKAnnotationViewEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didDeselectAnnotationView, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> DidFailToLocateUser
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didFailToLocateUser = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didFailToLocateUser, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didFailToLocateUser = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didFailToLocateUser, value);
		}
	}

	public event EventHandler<MKDidFinishRenderingMapEventArgs> DidFinishRenderingMap
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didFinishRenderingMap = (EventHandler<MKDidFinishRenderingMapEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didFinishRenderingMap, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didFinishRenderingMap = (EventHandler<MKDidFinishRenderingMapEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didFinishRenderingMap, value);
		}
	}

	public event EventHandler<MKAnnotationViewEventArgs> DidSelectAnnotationView
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didSelectAnnotationView = (EventHandler<MKAnnotationViewEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didSelectAnnotationView, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didSelectAnnotationView = (EventHandler<MKAnnotationViewEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didSelectAnnotationView, value);
		}
	}

	public event EventHandler DidStopLocatingUser
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didStopLocatingUser = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.didStopLocatingUser, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didStopLocatingUser = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.didStopLocatingUser, value);
		}
	}

	public event EventHandler<MKUserLocationEventArgs> DidUpdateUserLocation
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didUpdateUserLocation = (EventHandler<MKUserLocationEventArgs>)System.Delegate.Combine(mKMapViewDelegate.didUpdateUserLocation, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.didUpdateUserLocation = (EventHandler<MKUserLocationEventArgs>)System.Delegate.Remove(mKMapViewDelegate.didUpdateUserLocation, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> LoadingMapFailed
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.loadingMapFailed = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(mKMapViewDelegate.loadingMapFailed, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.loadingMapFailed = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(mKMapViewDelegate.loadingMapFailed, value);
		}
	}

	public event EventHandler MapLoaded
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.mapLoaded = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.mapLoaded, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.mapLoaded = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.mapLoaded, value);
		}
	}

	public event EventHandler<MKMapViewChangeEventArgs> RegionChanged
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.regionChanged = (EventHandler<MKMapViewChangeEventArgs>)System.Delegate.Combine(mKMapViewDelegate.regionChanged, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.regionChanged = (EventHandler<MKMapViewChangeEventArgs>)System.Delegate.Remove(mKMapViewDelegate.regionChanged, value);
		}
	}

	public event EventHandler<MKMapViewChangeEventArgs> RegionWillChange
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.regionWillChange = (EventHandler<MKMapViewChangeEventArgs>)System.Delegate.Combine(mKMapViewDelegate.regionWillChange, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.regionWillChange = (EventHandler<MKMapViewChangeEventArgs>)System.Delegate.Remove(mKMapViewDelegate.regionWillChange, value);
		}
	}

	public event EventHandler WillStartLoadingMap
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartLoadingMap = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.willStartLoadingMap, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartLoadingMap = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.willStartLoadingMap, value);
		}
	}

	public event EventHandler WillStartLocatingUser
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartLocatingUser = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.willStartLocatingUser, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartLocatingUser = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.willStartLocatingUser, value);
		}
	}

	public event EventHandler WillStartRenderingMap
	{
		add
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartRenderingMap = (EventHandler)System.Delegate.Combine(mKMapViewDelegate.willStartRenderingMap, value);
		}
		remove
		{
			_MKMapViewDelegate mKMapViewDelegate = EnsureMKMapViewDelegate();
			mKMapViewDelegate.willStartRenderingMap = (EventHandler)System.Delegate.Remove(mKMapViewDelegate.willStartRenderingMap, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapView()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MKMapView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKMapView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMapView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("addAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnnotation(IMKAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAnnotation_Handle, annotation.Handle);
		}
	}

	[Export("addAnnotations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnnotations(params IMKAnnotation[] annotations)
	{
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		NSArray nSArray = NSArray.FromNSObjects(annotations);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAnnotations_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAnnotations_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addOverlay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOverlay(IMKOverlay overlay)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOverlay_Handle, overlay.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOverlay_Handle, overlay.Handle);
		}
	}

	[Export("addOverlay:level:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOverlay(IMKOverlay overlay, MKOverlayLevel level)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddOverlay_Level_Handle, overlay.Handle, (long)level);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddOverlay_Level_Handle, overlay.Handle, (long)level);
		}
	}

	[Export("addOverlays:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOverlays(IMKOverlay[] overlays)
	{
		if (overlays == null)
		{
			throw new ArgumentNullException("overlays");
		}
		NSArray nSArray = NSArray.FromNSObjects(overlays);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOverlays_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOverlays_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addOverlays:level:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOverlays(IMKOverlay[] overlays, MKOverlayLevel level)
	{
		if (overlays == null)
		{
			throw new ArgumentNullException("overlays");
		}
		NSArray nSArray = NSArray.FromNSObjects(overlays);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddOverlays_Level_Handle, nSArray.Handle, (long)level);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddOverlays_Level_Handle, nSArray.Handle, (long)level);
		}
		nSArray.Dispose();
	}

	[Export("convertCoordinate:toPointToView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, NSView? toPointToView)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr(base.Handle, selConvertCoordinate_ToPointToView_Handle, coordinate, toPointToView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr(base.SuperHandle, selConvertCoordinate_ToPointToView_Handle, coordinate, toPointToView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertPoint:toCoordinateFromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D ConvertPoint(CGPoint point, NSView? toCoordinateFromView)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToCoordinateFromView_Handle, point, toCoordinateFromView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToCoordinateFromView_Handle, point, toCoordinateFromView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertRect:toRegionFromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion ConvertRect(CGRect rect, NSView? toRegionFromView)
	{
		MKCoordinateRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MKCoordinateRegion_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_ToRegionFromView_Handle, rect, toRegionFromView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_ToRegionFromView_Handle, rect, toRegionFromView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertRegion:toRectToView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRegion(MKCoordinateRegion region, NSView? toRectToView)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_MKCoordinateRegion_IntPtr(out retval, base.Handle, selConvertRegion_ToRectToView_Handle, region, toRectToView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_MKCoordinateRegion_IntPtr(out retval, base.SuperHandle, selConvertRegion_ToRectToView_Handle, region, toRectToView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("dequeueReusableAnnotationViewWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKAnnotationView? DequeueReusableAnnotation(string withViewIdentifier)
	{
		if (withViewIdentifier == null)
		{
			throw new ArgumentNullException("withViewIdentifier");
		}
		IntPtr arg = NSString.CreateNative(withViewIdentifier);
		MKAnnotationView result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDequeueReusableAnnotationViewWithIdentifier_Handle, arg)) : Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDequeueReusableAnnotationViewWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKAnnotationView DequeueReusableAnnotation(string identifier, IMKAnnotation annotation)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		MKAnnotationView result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_Handle, arg, annotation.Handle)) : Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_Handle, arg, annotation.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("deselectAnnotation:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectAnnotation(IMKAnnotation annotation, bool animated)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selDeselectAnnotation_Animated_Handle, annotation.Handle, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selDeselectAnnotation_Animated_Handle, annotation.Handle, animated);
		}
	}

	[Export("exchangeOverlay:withOverlay:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExchangeOverlay(IMKOverlay overlay1, IMKOverlay overlay2)
	{
		if (overlay1 == null)
		{
			throw new ArgumentNullException("overlay1");
		}
		if (overlay2 == null)
		{
			throw new ArgumentNullException("overlay2");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selExchangeOverlay_WithOverlay_Handle, overlay1.Handle, overlay2.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExchangeOverlay_WithOverlay_Handle, overlay1.Handle, overlay2.Handle);
		}
	}

	[Export("exchangeOverlayAtIndex:withOverlayAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExchangeOverlays(nint index1, nint index2)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selExchangeOverlayAtIndex_WithOverlayAtIndex_Handle, index1, index2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selExchangeOverlayAtIndex_WithOverlayAtIndex_Handle, index1, index2);
		}
	}

	[Export("annotationsInMapRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetAnnotations(MKMapRect mapRect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_MKMapRect(base.Handle, selAnnotationsInMapRect_Handle, mapRect));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_MKMapRect(base.SuperHandle, selAnnotationsInMapRect_Handle, mapRect));
	}

	[Export("insertOverlay:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertOverlay(IMKOverlay overlay, nint index)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertOverlay_AtIndex_Handle, overlay.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertOverlay_AtIndex_Handle, overlay.Handle, index);
		}
	}

	[Export("insertOverlay:atIndex:level:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertOverlay(IMKOverlay overlay, nuint index, MKOverlayLevel level)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Int64(base.Handle, selInsertOverlay_AtIndex_Level_Handle, overlay.Handle, index, (long)level);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Int64(base.SuperHandle, selInsertOverlay_AtIndex_Level_Handle, overlay.Handle, index, (long)level);
		}
	}

	[Export("insertOverlay:aboveOverlay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertOverlayAbove(IMKOverlay overlay, IMKOverlay sibling)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (sibling == null)
		{
			throw new ArgumentNullException("sibling");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertOverlay_AboveOverlay_Handle, overlay.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertOverlay_AboveOverlay_Handle, overlay.Handle, sibling.Handle);
		}
	}

	[Export("insertOverlay:belowOverlay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertOverlayBelow(IMKOverlay overlay, IMKOverlay sibling)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (sibling == null)
		{
			throw new ArgumentNullException("sibling");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertOverlay_BelowOverlay_Handle, overlay.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertOverlay_BelowOverlay_Handle, overlay.Handle, sibling.Handle);
		}
	}

	[Export("mapRectThatFits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapRect MapRectThatFits(MKMapRect mapRect)
	{
		MKMapRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.MKMapRect_objc_msgSend_stret_MKMapRect(out retval, base.Handle, selMapRectThatFits_Handle, mapRect);
		}
		else
		{
			Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect(out retval, base.SuperHandle, selMapRectThatFits_Handle, mapRect);
		}
		return retval;
	}

	[Export("mapRectThatFits:edgePadding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapRect MapRectThatFits(MKMapRect mapRect, NSEdgeInsets edgePadding)
	{
		MKMapRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.MKMapRect_objc_msgSend_stret_MKMapRect_NSEdgeInsets(out retval, base.Handle, selMapRectThatFits_EdgePadding_Handle, mapRect, edgePadding);
		}
		else
		{
			Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect_NSEdgeInsets(out retval, base.SuperHandle, selMapRectThatFits_EdgePadding_Handle, mapRect, edgePadding);
		}
		return retval;
	}

	[Export("overlaysInLevel:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKOverlay[] OverlaysInLevel(MKOverlayLevel level)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<IMKOverlay>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selOverlaysInLevel_Handle, (long)level));
		}
		return NSArray.ArrayFromHandle<IMKOverlay>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selOverlaysInLevel_Handle, (long)level));
	}

	[Export("regionThatFits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion RegionThatFits(MKCoordinateRegion region)
	{
		MKCoordinateRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MKCoordinateRegion_objc_msgSend_stret_MKCoordinateRegion(out retval, base.Handle, selRegionThatFits_Handle, region);
		}
		else
		{
			Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_MKCoordinateRegion(out retval, base.SuperHandle, selRegionThatFits_Handle, region);
		}
		return retval;
	}

	[Export("registerClass:forAnnotationViewWithReuseIdentifier:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Register(Class? viewClass, string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterClass_ForAnnotationViewWithReuseIdentifier_Handle, viewClass?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterClass_ForAnnotationViewWithReuseIdentifier_Handle, viewClass?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Register(Type? viewType, string identifier)
	{
		Register((viewType == null) ? null : new Class(viewType), identifier);
	}

	[Export("removeAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnnotation(IMKAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnnotation_Handle, annotation.Handle);
		}
	}

	[Export("removeAnnotations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnnotations(params IMKAnnotation[] annotations)
	{
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		NSArray nSArray = NSArray.FromNSObjects(annotations);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnnotations_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnnotations_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeOverlay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveOverlay(IMKOverlay overlay)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOverlay_Handle, overlay.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOverlay_Handle, overlay.Handle);
		}
	}

	[Export("removeOverlays:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveOverlays(params IMKOverlay[] overlays)
	{
		if (overlays == null)
		{
			throw new ArgumentNullException("overlays");
		}
		NSArray nSArray = NSArray.FromNSObjects(overlays);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOverlays_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOverlays_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("rendererForOverlay:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKOverlayRenderer RendererForOverlay(IMKOverlay overlay)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MKOverlayRenderer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRendererForOverlay_Handle, overlay.Handle));
		}
		return Runtime.GetNSObject<MKOverlayRenderer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRendererForOverlay_Handle, overlay.Handle));
	}

	[Export("selectAnnotation:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAnnotation(IMKAnnotation annotation, bool animated)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectAnnotation_Animated_Handle, annotation.Handle, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectAnnotation_Animated_Handle, annotation.Handle, animated);
		}
	}

	[Export("setCamera:animated:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCamera(MKMapCamera camera, bool animated)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetCamera_Animated_Handle, camera.Handle, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetCamera_Animated_Handle, camera.Handle, animated);
		}
	}

	[Export("setCameraBoundary:animated:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCameraBoundary(MKMapCameraBoundary? cameraBoundary, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetCameraBoundary_Animated_Handle, cameraBoundary?.Handle ?? IntPtr.Zero, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetCameraBoundary_Animated_Handle, cameraBoundary?.Handle ?? IntPtr.Zero, animated);
		}
	}

	[Export("setCameraZoomRange:animated:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCameraZoomRange(MKMapCameraZoomRange? cameraZoomRange, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetCameraZoomRange_Animated_Handle, cameraZoomRange?.Handle ?? IntPtr.Zero, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetCameraZoomRange_Animated_Handle, cameraZoomRange?.Handle ?? IntPtr.Zero, animated);
		}
	}

	[Export("setCenterCoordinate:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCenterCoordinate(CLLocationCoordinate2D coordinate, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool(base.Handle, selSetCenterCoordinate_Animated_Handle, coordinate, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool(base.SuperHandle, selSetCenterCoordinate_Animated_Handle, coordinate, animated);
		}
	}

	[Export("setRegion:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRegion(MKCoordinateRegion region, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKCoordinateRegion_bool(base.Handle, selSetRegion_Animated_Handle, region, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKCoordinateRegion_bool(base.SuperHandle, selSetRegion_Animated_Handle, region, animated);
		}
	}

	[Export("setVisibleMapRect:edgePadding:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVisibleMapRect(MKMapRect mapRect, NSEdgeInsets edgePadding, bool animate)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKMapRect_NSEdgeInsets_bool(base.Handle, selSetVisibleMapRect_EdgePadding_Animated_Handle, mapRect, edgePadding, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKMapRect_NSEdgeInsets_bool(base.SuperHandle, selSetVisibleMapRect_EdgePadding_Animated_Handle, mapRect, edgePadding, animate);
		}
	}

	[Export("setVisibleMapRect:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVisibleMapRect(MKMapRect mapRect, bool animate)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKMapRect_bool(base.Handle, selSetVisibleMapRect_Animated_Handle, mapRect, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKMapRect_bool(base.SuperHandle, selSetVisibleMapRect_Animated_Handle, mapRect, animate);
		}
	}

	[Export("showAnnotations:animated:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowAnnotations(IMKAnnotation[] annotations, bool animated)
	{
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		NSArray nSArray = NSArray.FromNSObjects(annotations);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selShowAnnotations_Animated_Handle, nSArray.Handle, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selShowAnnotations_Animated_Handle, nSArray.Handle, animated);
		}
		nSArray.Dispose();
	}

	[Export("viewForAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKAnnotationView ViewForAnnotation(IMKAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selViewForAnnotation_Handle, annotation.Handle));
		}
		return Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewForAnnotation_Handle, annotation.Handle));
	}

	internal virtual _MKMapViewDelegate CreateInternalEventDelegateType()
	{
		return new _MKMapViewDelegate();
	}

	internal _MKMapViewDelegate EnsureMKMapViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_MKMapViewDelegate mKMapViewDelegate = Delegate as _MKMapViewDelegate;
		if (mKMapViewDelegate == null)
		{
			mKMapViewDelegate = (_MKMapViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return mKMapViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
