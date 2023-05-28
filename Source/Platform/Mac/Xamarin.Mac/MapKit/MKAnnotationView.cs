using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKAnnotationView", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKAnnotationView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotation = "annotation";

	private static readonly IntPtr selAnnotationHandle = Selector.GetHandle("annotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalloutOffset = "calloutOffset";

	private static readonly IntPtr selCalloutOffsetHandle = Selector.GetHandle("calloutOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanShowCallout = "canShowCallout";

	private static readonly IntPtr selCanShowCalloutHandle = Selector.GetHandle("canShowCallout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterOffset = "centerOffset";

	private static readonly IntPtr selCenterOffsetHandle = Selector.GetHandle("centerOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClusterAnnotationView = "clusterAnnotationView";

	private static readonly IntPtr selClusterAnnotationViewHandle = Selector.GetHandle("clusterAnnotationView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClusteringIdentifier = "clusteringIdentifier";

	private static readonly IntPtr selClusteringIdentifierHandle = Selector.GetHandle("clusteringIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollisionMode = "collisionMode";

	private static readonly IntPtr selCollisionModeHandle = Selector.GetHandle("collisionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetailCalloutAccessoryView = "detailCalloutAccessoryView";

	private static readonly IntPtr selDetailCalloutAccessoryViewHandle = Selector.GetHandle("detailCalloutAccessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayPriority = "displayPriority";

	private static readonly IntPtr selDisplayPriorityHandle = Selector.GetHandle("displayPriority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragState = "dragState";

	private static readonly IntPtr selDragStateHandle = Selector.GetHandle("dragState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAnnotation_ReuseIdentifier_ = "initWithAnnotation:reuseIdentifier:";

	private static readonly IntPtr selInitWithAnnotation_ReuseIdentifier_Handle = Selector.GetHandle("initWithAnnotation:reuseIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDraggable = "isDraggable";

	private static readonly IntPtr selIsDraggableHandle = Selector.GetHandle("isDraggable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHighlighted = "isHighlighted";

	private static readonly IntPtr selIsHighlightedHandle = Selector.GetHandle("isHighlighted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelected = "isSelected";

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftCalloutAccessoryView = "leftCalloutAccessoryView";

	private static readonly IntPtr selLeftCalloutAccessoryViewHandle = Selector.GetHandle("leftCalloutAccessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftCalloutOffset = "leftCalloutOffset";

	private static readonly IntPtr selLeftCalloutOffsetHandle = Selector.GetHandle("leftCalloutOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForDisplay = "prepareForDisplay";

	private static readonly IntPtr selPrepareForDisplayHandle = Selector.GetHandle("prepareForDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForReuse = "prepareForReuse";

	private static readonly IntPtr selPrepareForReuseHandle = Selector.GetHandle("prepareForReuse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReuseIdentifier = "reuseIdentifier";

	private static readonly IntPtr selReuseIdentifierHandle = Selector.GetHandle("reuseIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightCalloutAccessoryView = "rightCalloutAccessoryView";

	private static readonly IntPtr selRightCalloutAccessoryViewHandle = Selector.GetHandle("rightCalloutAccessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightCalloutOffset = "rightCalloutOffset";

	private static readonly IntPtr selRightCalloutOffsetHandle = Selector.GetHandle("rightCalloutOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnnotation_ = "setAnnotation:";

	private static readonly IntPtr selSetAnnotation_Handle = Selector.GetHandle("setAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalloutOffset_ = "setCalloutOffset:";

	private static readonly IntPtr selSetCalloutOffset_Handle = Selector.GetHandle("setCalloutOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanShowCallout_ = "setCanShowCallout:";

	private static readonly IntPtr selSetCanShowCallout_Handle = Selector.GetHandle("setCanShowCallout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterOffset_ = "setCenterOffset:";

	private static readonly IntPtr selSetCenterOffset_Handle = Selector.GetHandle("setCenterOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClusteringIdentifier_ = "setClusteringIdentifier:";

	private static readonly IntPtr selSetClusteringIdentifier_Handle = Selector.GetHandle("setClusteringIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollisionMode_ = "setCollisionMode:";

	private static readonly IntPtr selSetCollisionMode_Handle = Selector.GetHandle("setCollisionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDetailCalloutAccessoryView_ = "setDetailCalloutAccessoryView:";

	private static readonly IntPtr selSetDetailCalloutAccessoryView_Handle = Selector.GetHandle("setDetailCalloutAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayPriority_ = "setDisplayPriority:";

	private static readonly IntPtr selSetDisplayPriority_Handle = Selector.GetHandle("setDisplayPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDragState_ = "setDragState:";

	private static readonly IntPtr selSetDragState_Handle = Selector.GetHandle("setDragState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDragState_Animated_ = "setDragState:animated:";

	private static readonly IntPtr selSetDragState_Animated_Handle = Selector.GetHandle("setDragState:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggable_ = "setDraggable:";

	private static readonly IntPtr selSetDraggable_Handle = Selector.GetHandle("setDraggable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlighted_ = "setHighlighted:";

	private static readonly IntPtr selSetHighlighted_Handle = Selector.GetHandle("setHighlighted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeftCalloutAccessoryView_ = "setLeftCalloutAccessoryView:";

	private static readonly IntPtr selSetLeftCalloutAccessoryView_Handle = Selector.GetHandle("setLeftCalloutAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeftCalloutOffset_ = "setLeftCalloutOffset:";

	private static readonly IntPtr selSetLeftCalloutOffset_Handle = Selector.GetHandle("setLeftCalloutOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightCalloutAccessoryView_ = "setRightCalloutAccessoryView:";

	private static readonly IntPtr selSetRightCalloutAccessoryView_Handle = Selector.GetHandle("setRightCalloutAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightCalloutOffset_ = "setRightCalloutOffset:";

	private static readonly IntPtr selSetRightCalloutOffset_Handle = Selector.GetHandle("setRightCalloutOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_ = "setSelected:";

	private static readonly IntPtr selSetSelected_Handle = Selector.GetHandle("setSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_Animated_ = "setSelected:animated:";

	private static readonly IntPtr selSetSelected_Animated_Handle = Selector.GetHandle("setSelected:animated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKAnnotationView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ClusterAnnotationView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual IMKAnnotation? Annotation
	{
		[Export("annotation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMKAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnnotationHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMKAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnnotationHandle), owns: false);
		}
		[Export("setAnnotation:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnnotation_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnnotation_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CalloutOffset
	{
		[Export("calloutOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCalloutOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCalloutOffsetHandle);
		}
		[Export("setCalloutOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetCalloutOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetCalloutOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanShowCallout
	{
		[Export("canShowCallout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanShowCalloutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanShowCalloutHandle);
		}
		[Export("setCanShowCallout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanShowCallout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanShowCallout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CenterOffset
	{
		[Export("centerOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCenterOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCenterOffsetHandle);
		}
		[Export("setCenterOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetCenterOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetCenterOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual MKAnnotationView? ClusterAnnotationView
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("clusterAnnotationView", ArgumentSemantic.Weak)]
		get
		{
			MKAnnotationView mKAnnotationView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClusterAnnotationViewHandle)) : Runtime.GetNSObject<MKAnnotationView>(Messaging.IntPtr_objc_msgSend(base.Handle, selClusterAnnotationViewHandle)));
			MarkDirty();
			__mt_ClusterAnnotationView_var = mKAnnotationView;
			return mKAnnotationView;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual string? ClusteringIdentifier
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("clusteringIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selClusteringIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClusteringIdentifierHandle));
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setClusteringIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClusteringIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClusteringIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual MKAnnotationViewCollisionMode CollisionMode
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("collisionMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKAnnotationViewCollisionMode)Messaging.Int64_objc_msgSend(base.Handle, selCollisionModeHandle);
			}
			return (MKAnnotationViewCollisionMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCollisionModeHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setCollisionMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCollisionMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCollisionMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSView? DetailCalloutAccessoryView
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("detailCalloutAccessoryView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selDetailCalloutAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDetailCalloutAccessoryViewHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDetailCalloutAccessoryView:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDetailCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDetailCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Advice("Pre-defined constants are available from 'MKFeatureDisplayPriority'.")]
	public virtual float DisplayPriority
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("displayPriority")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selDisplayPriorityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selDisplayPriorityHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setDisplayPriority:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetDisplayPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetDisplayPriority_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual MKAnnotationViewDragState DragState
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("dragState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKAnnotationViewDragState)Messaging.UInt64_objc_msgSend(base.Handle, selDragStateHandle);
			}
			return (MKAnnotationViewDragState)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDragStateHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setDragState:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDragState_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDragState_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual bool Draggable
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("isDraggable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDraggableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDraggableHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setDraggable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDraggable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDraggable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Highlighted
	{
		[Export("isHighlighted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHighlightedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHighlightedHandle);
		}
		[Export("setHighlighted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHighlighted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHighlighted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? Image
	{
		[Export("image", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
		[Export("setImage:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? LeftCalloutAccessoryView
	{
		[Export("leftCalloutAccessoryView", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftCalloutAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftCalloutAccessoryViewHandle));
		}
		[Export("setLeftCalloutAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLeftCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLeftCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LeftCalloutOffset
	{
		[Export("leftCalloutOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selLeftCalloutOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLeftCalloutOffsetHandle);
		}
		[Export("setLeftCalloutOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetLeftCalloutOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetLeftCalloutOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ReuseIdentifier
	{
		[Export("reuseIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReuseIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReuseIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? RightCalloutAccessoryView
	{
		[Export("rightCalloutAccessoryView", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightCalloutAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightCalloutAccessoryViewHandle));
		}
		[Export("setRightCalloutAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRightCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRightCalloutAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint RightCallpoutOffset
	{
		[Export("rightCalloutOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selRightCalloutOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selRightCalloutOffsetHandle);
		}
		[Export("setRightCalloutOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetRightCalloutOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetRightCalloutOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Selected
	{
		[Export("isSelected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
		[Export("setSelected:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKAnnotationView()
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
	public MKAnnotationView(NSCoder coder)
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
	protected MKAnnotationView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKAnnotationView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAnnotation:reuseIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKAnnotationView(IMKAnnotation? annotation, string? reuseIdentifier)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(reuseIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAnnotation_ReuseIdentifier_Handle, annotation?.Handle ?? IntPtr.Zero, arg), "initWithAnnotation:reuseIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAnnotation_ReuseIdentifier_Handle, annotation?.Handle ?? IntPtr.Zero, arg), "initWithAnnotation:reuseIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKAnnotationView(CGRect frame)
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

	[Export("prepareForDisplay")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void PrepareForDisplay()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareForDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareForDisplayHandle);
		}
	}

	[Export("prepareForReuse")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void PrepareForReuse()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareForReuseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareForReuseHandle);
		}
	}

	[Export("setDragState:animated:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDragState(MKAnnotationViewDragState newDragState, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDragState_Animated_Handle, (ulong)newDragState, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDragState_Animated_Handle, (ulong)newDragState, animated);
		}
	}

	[Export("setSelected:animated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelected(bool selected, bool animated)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_bool(base.Handle, selSetSelected_Animated_Handle, selected, animated);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_bool(base.SuperHandle, selSetSelected_Animated_Handle, selected, animated);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ClusterAnnotationView_var = null;
		}
	}
}
