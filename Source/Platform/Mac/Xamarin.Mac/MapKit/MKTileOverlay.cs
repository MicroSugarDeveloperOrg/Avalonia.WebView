using System.ComponentModel;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MapKit;

[Register("MKTileOverlay", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class MKTileOverlay : NSObject, IMKOverlay, INativeObject, IDisposable, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForTilePath_ = "URLForTilePath:";

	private static readonly IntPtr selURLForTilePath_Handle = Selector.GetHandle("URLForTilePath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLTemplate = "URLTemplate";

	private static readonly IntPtr selURLTemplateHandle = Selector.GetHandle("URLTemplate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingMapRect = "boundingMapRect";

	private static readonly IntPtr selBoundingMapRectHandle = Selector.GetHandle("boundingMapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReplaceMapContent = "canReplaceMapContent";

	private static readonly IntPtr selCanReplaceMapContentHandle = Selector.GetHandle("canReplaceMapContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinate = "coordinate";

	private static readonly IntPtr selCoordinateHandle = Selector.GetHandle("coordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURLTemplate_ = "initWithURLTemplate:";

	private static readonly IntPtr selInitWithURLTemplate_Handle = Selector.GetHandle("initWithURLTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsMapRect_ = "intersectsMapRect:";

	private static readonly IntPtr selIntersectsMapRect_Handle = Selector.GetHandle("intersectsMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGeometryFlipped = "isGeometryFlipped";

	private static readonly IntPtr selIsGeometryFlippedHandle = Selector.GetHandle("isGeometryFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadTileAtPath_Result_ = "loadTileAtPath:result:";

	private static readonly IntPtr selLoadTileAtPath_Result_Handle = Selector.GetHandle("loadTileAtPath:result:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumZ = "maximumZ";

	private static readonly IntPtr selMaximumZHandle = Selector.GetHandle("maximumZ");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumZ = "minimumZ";

	private static readonly IntPtr selMinimumZHandle = Selector.GetHandle("minimumZ");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanReplaceMapContent_ = "setCanReplaceMapContent:";

	private static readonly IntPtr selSetCanReplaceMapContent_Handle = Selector.GetHandle("setCanReplaceMapContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGeometryFlipped_ = "setGeometryFlipped:";

	private static readonly IntPtr selSetGeometryFlipped_Handle = Selector.GetHandle("setGeometryFlipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumZ_ = "setMaximumZ:";

	private static readonly IntPtr selSetMaximumZ_Handle = Selector.GetHandle("setMaximumZ:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumZ_ = "setMinimumZ:";

	private static readonly IntPtr selSetMinimumZ_Handle = Selector.GetHandle("setMinimumZ:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileSize_ = "setTileSize:";

	private static readonly IntPtr selSetTileSize_Handle = Selector.GetHandle("setTileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSize = "tileSize";

	private static readonly IntPtr selTileSizeHandle = Selector.GetHandle("tileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKTileOverlay");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get
		{
			MKMapRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKMapRect_objc_msgSend_stret(out retval, base.Handle, selBoundingMapRectHandle);
			}
			else
			{
				Messaging.MKMapRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingMapRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanReplaceMapContent
	{
		[Export("canReplaceMapContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanReplaceMapContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanReplaceMapContentHandle);
		}
		[Export("setCanReplaceMapContent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanReplaceMapContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanReplaceMapContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCoordinateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GeometryFlipped
	{
		[Export("isGeometryFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGeometryFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGeometryFlippedHandle);
		}
		[Export("setGeometryFlipped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeometryFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeometryFlipped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumZ
	{
		[Export("maximumZ")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumZHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumZHandle);
		}
		[Export("setMaximumZ:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumZ_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumZ_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MinimumZ
	{
		[Export("minimumZ")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMinimumZHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMinimumZHandle);
		}
		[Export("setMinimumZ:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMinimumZ_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMinimumZ_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize TileSize
	{
		[Export("tileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selTileSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selTileSizeHandle);
		}
		[Export("setTileSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetTileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetTileSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string URLTemplate
	{
		[Export("URLTemplate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURLTemplateHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLTemplateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKTileOverlay()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKTileOverlay(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKTileOverlay(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURLTemplate:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKTileOverlay(string URLTemplate)
		: base(NSObjectFlag.Empty)
	{
		if (URLTemplate == null)
		{
			throw new ArgumentNullException("URLTemplate");
		}
		IntPtr arg = NSString.CreateNative(URLTemplate);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURLTemplate_Handle, arg), "initWithURLTemplate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURLTemplate_Handle, arg), "initWithURLTemplate:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("intersectsMapRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(MKMapRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_MKMapRect(base.Handle, selIntersectsMapRect_Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_MKMapRect(base.SuperHandle, selIntersectsMapRect_Handle, rect);
	}

	[Export("loadTileAtPath:result:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadTileAtPath(MKTileOverlayPath path, [BlockProxy(typeof(Trampolines.NIDMKTileOverlayLoadTileCompletionHandler))] MKTileOverlayLoadTileCompletionHandler result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKTileOverlayLoadTileCompletionHandler.Handler, result);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKTileOverlayPath_IntPtr(base.Handle, selLoadTileAtPath_Result_Handle, path, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKTileOverlayPath_IntPtr(base.SuperHandle, selLoadTileAtPath_Result_Handle, path, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("URLForTilePath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl URLForTilePath(MKTileOverlayPath path)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_MKTileOverlayPath(base.Handle, selURLForTilePath_Handle, path));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_MKTileOverlayPath(base.SuperHandle, selURLForTilePath_Handle, path));
	}
}
