using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRulerMarker", true)]
public class NSRulerMarker : NSObject
{
	private static readonly IntPtr selRulerHandle = Selector.GetHandle("ruler");

	private static readonly IntPtr selIsDraggingHandle = Selector.GetHandle("isDragging");

	private static readonly IntPtr selImageRectInRulerHandle = Selector.GetHandle("imageRectInRuler");

	private static readonly IntPtr selThicknessRequiredInRulerHandle = Selector.GetHandle("thicknessRequiredInRuler");

	private static readonly IntPtr selMarkerLocationHandle = Selector.GetHandle("markerLocation");

	private static readonly IntPtr selSetMarkerLocation_Handle = Selector.GetHandle("setMarkerLocation:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selImageOriginHandle = Selector.GetHandle("imageOrigin");

	private static readonly IntPtr selSetImageOrigin_Handle = Selector.GetHandle("setImageOrigin:");

	private static readonly IntPtr selIsMovableHandle = Selector.GetHandle("isMovable");

	private static readonly IntPtr selSetMovable_Handle = Selector.GetHandle("setMovable:");

	private static readonly IntPtr selIsRemovableHandle = Selector.GetHandle("isRemovable");

	private static readonly IntPtr selSetRemovable_Handle = Selector.GetHandle("setRemovable:");

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	private static readonly IntPtr selInitWithRulerViewMarkerLocationImageImageOrigin_Handle = Selector.GetHandle("initWithRulerView:markerLocation:image:imageOrigin:");

	private static readonly IntPtr selDrawRect_Handle = Selector.GetHandle("drawRect:");

	private static readonly IntPtr selTrackMouseAdding_Handle = Selector.GetHandle("trackMouse:adding:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRulerMarker");

	private object __mt_Ruler_var;

	private object __mt_Image_var;

	private object __mt_RepresentedObject_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSRulerView Ruler
	{
		[Export("ruler")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRulerView)(__mt_Ruler_var = ((!IsDirectBinding) ? ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRulerHandle))) : ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRulerHandle)))));
		}
	}

	public virtual bool IsDragging
	{
		[Export("isDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDraggingHandle);
		}
	}

	public virtual CGRect ImageRectInRuler
	{
		[Export("imageRectInRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual double ThicknessRequiredInRuler
	{
		[Export("thicknessRequiredInRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selThicknessRequiredInRulerHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selThicknessRequiredInRulerHandle);
		}
	}

	public virtual double MarkerLocation
	{
		[Export("markerLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMarkerLocationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMarkerLocationHandle);
		}
		[Export("setMarkerLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMarkerLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMarkerLocation_Handle, value);
			}
		}
	}

	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Image_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
		[Export("setImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
			__mt_Image_var = value;
		}
	}

	public virtual CGPoint ImageOrigin
	{
		[Export("imageOrigin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selImageOriginHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selImageOriginHandle);
		}
		[Export("setImageOrigin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetImageOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetImageOrigin_Handle, value);
			}
		}
	}

	public virtual bool Movable
	{
		[Export("isMovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableHandle);
		}
		[Export("setMovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovable_Handle, value);
			}
		}
	}

	public virtual bool Removable
	{
		[Export("isRemovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemovableHandle);
		}
		[Export("setRemovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRemovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRemovable_Handle, value);
			}
		}
	}

	public virtual NSObject RepresentedObject
	{
		[Export("representedObject")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_RepresentedObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle))));
		}
		[Export("setRepresentedObject:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedObject_Handle, value.Handle);
			}
			__mt_RepresentedObject_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRulerMarker()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSRulerMarker(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRulerMarker(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRulerMarker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRulerView:markerLocation:image:imageOrigin:")]
	public NSRulerMarker(NSRulerView ruler, double location, NSImage image, CGPoint imageOrigin)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Double_IntPtr_CGPoint(base.Handle, selInitWithRulerViewMarkerLocationImageImageOrigin_Handle, ruler.Handle, location, image.Handle, imageOrigin);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_CGPoint(base.SuperHandle, selInitWithRulerViewMarkerLocationImageImageOrigin_Handle, ruler.Handle, location, image.Handle, imageOrigin);
		}
	}

	[Export("drawRect:")]
	public virtual void DrawRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawRect_Handle, rect);
		}
	}

	[Export("trackMouse:adding:")]
	public virtual bool TrackMouse(NSEvent mouseDownEvent, bool isAdding)
	{
		NSApplication.EnsureUIThread();
		if (mouseDownEvent == null)
		{
			throw new ArgumentNullException("mouseDownEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selTrackMouseAdding_Handle, mouseDownEvent.Handle, isAdding);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selTrackMouseAdding_Handle, mouseDownEvent.Handle, isAdding);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Ruler_var = null;
			__mt_Image_var = null;
			__mt_RepresentedObject_var = null;
		}
	}
}
