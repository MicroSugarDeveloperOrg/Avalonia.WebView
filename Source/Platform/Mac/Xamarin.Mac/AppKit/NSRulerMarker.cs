using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRulerMarker", true)]
public class NSRulerMarker : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawRect_ = "drawRect:";

	private static readonly IntPtr selDrawRect_Handle = Selector.GetHandle("drawRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageOrigin = "imageOrigin";

	private static readonly IntPtr selImageOriginHandle = Selector.GetHandle("imageOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRectInRuler = "imageRectInRuler";

	private static readonly IntPtr selImageRectInRulerHandle = Selector.GetHandle("imageRectInRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRulerView_MarkerLocation_Image_ImageOrigin_ = "initWithRulerView:markerLocation:image:imageOrigin:";

	private static readonly IntPtr selInitWithRulerView_MarkerLocation_Image_ImageOrigin_Handle = Selector.GetHandle("initWithRulerView:markerLocation:image:imageOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDragging = "isDragging";

	private static readonly IntPtr selIsDraggingHandle = Selector.GetHandle("isDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMovable = "isMovable";

	private static readonly IntPtr selIsMovableHandle = Selector.GetHandle("isMovable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRemovable = "isRemovable";

	private static readonly IntPtr selIsRemovableHandle = Selector.GetHandle("isRemovable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkerLocation = "markerLocation";

	private static readonly IntPtr selMarkerLocationHandle = Selector.GetHandle("markerLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedObject = "representedObject";

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRuler = "ruler";

	private static readonly IntPtr selRulerHandle = Selector.GetHandle("ruler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageOrigin_ = "setImageOrigin:";

	private static readonly IntPtr selSetImageOrigin_Handle = Selector.GetHandle("setImageOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkerLocation_ = "setMarkerLocation:";

	private static readonly IntPtr selSetMarkerLocation_Handle = Selector.GetHandle("setMarkerLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovable_ = "setMovable:";

	private static readonly IntPtr selSetMovable_Handle = Selector.GetHandle("setMovable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemovable_ = "setRemovable:";

	private static readonly IntPtr selSetRemovable_Handle = Selector.GetHandle("setRemovable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepresentedObject_ = "setRepresentedObject:";

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThicknessRequiredInRuler = "thicknessRequiredInRuler";

	private static readonly IntPtr selThicknessRequiredInRulerHandle = Selector.GetHandle("thicknessRequiredInRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackMouse_Adding_ = "trackMouse:adding:";

	private static readonly IntPtr selTrackMouse_Adding_Handle = Selector.GetHandle("trackMouse:adding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRulerMarker");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Image
	{
		[Export("image", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
		[Export("setImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ImageOrigin
	{
		[Export("imageOrigin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selImageOriginHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selImageOriginHandle);
		}
		[Export("setImageOrigin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetImageOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetImageOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ImageRectInRuler
	{
		[Export("imageRectInRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selImageRectInRulerHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selImageRectInRulerHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDragging
	{
		[Export("isDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDraggingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MarkerLocation
	{
		[Export("markerLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMarkerLocationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMarkerLocationHandle);
		}
		[Export("setMarkerLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMarkerLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMarkerLocation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Movable
	{
		[Export("isMovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableHandle);
		}
		[Export("setMovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Removable
	{
		[Export("isRemovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemovableHandle);
		}
		[Export("setRemovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRemovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRemovable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RepresentedObject
	{
		[Export("representedObject", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle));
		}
		[Export("setRepresentedObject:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedObject_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRulerView Ruler
	{
		[Export("ruler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSend(base.Handle, selRulerHandle));
			}
			return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRulerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ThicknessRequiredInRuler
	{
		[Export("thicknessRequiredInRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selThicknessRequiredInRulerHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selThicknessRequiredInRulerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRulerMarker()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSRulerMarker(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSRulerMarker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRulerMarker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRulerView:markerLocation:image:imageOrigin:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRulerMarker(NSRulerView ruler, nfloat location, NSImage image, CGPoint imageOrigin)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_IntPtr_CGPoint(base.Handle, selInitWithRulerView_MarkerLocation_Image_ImageOrigin_Handle, ruler.Handle, location, image.Handle, imageOrigin), "initWithRulerView:markerLocation:image:imageOrigin:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_IntPtr_CGPoint(base.SuperHandle, selInitWithRulerView_MarkerLocation_Image_ImageOrigin_Handle, ruler.Handle, location, image.Handle, imageOrigin), "initWithRulerView:markerLocation:image:imageOrigin:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("drawRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawRect_Handle, rect);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("trackMouse:adding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TrackMouse(NSEvent mouseDownEvent, bool isAdding)
	{
		NSApplication.EnsureUIThread();
		if (mouseDownEvent == null)
		{
			throw new ArgumentNullException("mouseDownEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selTrackMouse_Adding_Handle, mouseDownEvent.Handle, isAdding);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selTrackMouse_Adding_Handle, mouseDownEvent.Handle, isAdding);
	}
}
