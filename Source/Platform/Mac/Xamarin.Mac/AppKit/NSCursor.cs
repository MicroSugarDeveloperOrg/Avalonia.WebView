using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCursor", true)]
public class NSCursor : NSObject
{
	private static readonly IntPtr selCurrentCursorHandle = Selector.GetHandle("currentCursor");

	private static readonly IntPtr selCurrentSystemCursorHandle = Selector.GetHandle("currentSystemCursor");

	private static readonly IntPtr selArrowCursorHandle = Selector.GetHandle("arrowCursor");

	private static readonly IntPtr selIBeamCursorHandle = Selector.GetHandle("IBeamCursor");

	private static readonly IntPtr selPointingHandCursorHandle = Selector.GetHandle("pointingHandCursor");

	private static readonly IntPtr selClosedHandCursorHandle = Selector.GetHandle("closedHandCursor");

	private static readonly IntPtr selOpenHandCursorHandle = Selector.GetHandle("openHandCursor");

	private static readonly IntPtr selResizeLeftCursorHandle = Selector.GetHandle("resizeLeftCursor");

	private static readonly IntPtr selResizeRightCursorHandle = Selector.GetHandle("resizeRightCursor");

	private static readonly IntPtr selResizeLeftRightCursorHandle = Selector.GetHandle("resizeLeftRightCursor");

	private static readonly IntPtr selResizeUpCursorHandle = Selector.GetHandle("resizeUpCursor");

	private static readonly IntPtr selResizeDownCursorHandle = Selector.GetHandle("resizeDownCursor");

	private static readonly IntPtr selResizeUpDownCursorHandle = Selector.GetHandle("resizeUpDownCursor");

	private static readonly IntPtr selCrosshairCursorHandle = Selector.GetHandle("crosshairCursor");

	private static readonly IntPtr selDisappearingItemCursorHandle = Selector.GetHandle("disappearingItemCursor");

	private static readonly IntPtr selOperationNotAllowedCursorHandle = Selector.GetHandle("operationNotAllowedCursor");

	private static readonly IntPtr selDragLinkCursorHandle = Selector.GetHandle("dragLinkCursor");

	private static readonly IntPtr selDragCopyCursorHandle = Selector.GetHandle("dragCopyCursor");

	private static readonly IntPtr selContextualMenuCursorHandle = Selector.GetHandle("contextualMenuCursor");

	private static readonly IntPtr selIBeamCursorForVerticalLayoutHandle = Selector.GetHandle("IBeamCursorForVerticalLayout");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selHotSpotHandle = Selector.GetHandle("hotSpot");

	private static readonly IntPtr selInitWithImageHotSpot_Handle = Selector.GetHandle("initWithImage:hotSpot:");

	private static readonly IntPtr selInitWithImageForegroundColorHintBackgroundColorHintHotSpot_Handle = Selector.GetHandle("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	private static readonly IntPtr selSetHiddenUntilMouseMoves_Handle = Selector.GetHandle("setHiddenUntilMouseMoves:");

	private static readonly IntPtr selPushHandle = Selector.GetHandle("push");

	private static readonly IntPtr selPopHandle = Selector.GetHandle("pop");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selSetOnMouseExited_Handle = Selector.GetHandle("setOnMouseExited:");

	private static readonly IntPtr selSetOnMouseEntered_Handle = Selector.GetHandle("setOnMouseEntered:");

	private static readonly IntPtr selIsSetOnMouseExitedHandle = Selector.GetHandle("isSetOnMouseExited");

	private static readonly IntPtr selIsSetOnMouseEnteredHandle = Selector.GetHandle("isSetOnMouseEntered");

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCursor");

	private static object __mt_CurrentCursor_var_static;

	private static object __mt_CurrentSystemCursor_var_static;

	private static object __mt_ArrowCursor_var_static;

	private static object __mt_IBeamCursor_var_static;

	private static object __mt_PointingHandCursor_var_static;

	private static object __mt_ClosedHandCursor_var_static;

	private static object __mt_OpenHandCursor_var_static;

	private static object __mt_ResizeLeftCursor_var_static;

	private static object __mt_ResizeRightCursor_var_static;

	private static object __mt_ResizeLeftRightCursor_var_static;

	private static object __mt_ResizeUpCursor_var_static;

	private static object __mt_ResizeDownCursor_var_static;

	private static object __mt_ResizeUpDownCursor_var_static;

	private static object __mt_CrosshairCursor_var_static;

	private static object __mt_DisappearingItemCursor_var_static;

	private static object __mt_OperationNotAllowedCursor_var_static;

	private static object __mt_DragLinkCursor_var_static;

	private static object __mt_DragCopyCursor_var_static;

	private static object __mt_ContextualMenuCursor_var_static;

	private static object __mt_IBeamCursorForVerticalLayout_var_static;

	private object __mt_Image_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSCursor CurrentCursor
	{
		[Export("currentCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_CurrentCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCursorHandle)));
		}
	}

	public static NSCursor CurrentSystemCursor
	{
		[Export("currentSystemCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_CurrentSystemCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentSystemCursorHandle)));
		}
	}

	public static NSCursor ArrowCursor
	{
		[Export("arrowCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ArrowCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selArrowCursorHandle)));
		}
	}

	public static NSCursor IBeamCursor
	{
		[Export("IBeamCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_IBeamCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selIBeamCursorHandle)));
		}
	}

	public static NSCursor PointingHandCursor
	{
		[Export("pointingHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_PointingHandCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPointingHandCursorHandle)));
		}
	}

	public static NSCursor ClosedHandCursor
	{
		[Export("closedHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ClosedHandCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selClosedHandCursorHandle)));
		}
	}

	public static NSCursor OpenHandCursor
	{
		[Export("openHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_OpenHandCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOpenHandCursorHandle)));
		}
	}

	public static NSCursor ResizeLeftCursor
	{
		[Export("resizeLeftCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeLeftCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeLeftCursorHandle)));
		}
	}

	public static NSCursor ResizeRightCursor
	{
		[Export("resizeRightCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeRightCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeRightCursorHandle)));
		}
	}

	public static NSCursor ResizeLeftRightCursor
	{
		[Export("resizeLeftRightCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeLeftRightCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeLeftRightCursorHandle)));
		}
	}

	public static NSCursor ResizeUpCursor
	{
		[Export("resizeUpCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeUpCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeUpCursorHandle)));
		}
	}

	public static NSCursor ResizeDownCursor
	{
		[Export("resizeDownCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeDownCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeDownCursorHandle)));
		}
	}

	public static NSCursor ResizeUpDownCursor
	{
		[Export("resizeUpDownCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ResizeUpDownCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeUpDownCursorHandle)));
		}
	}

	public static NSCursor CrosshairCursor
	{
		[Export("crosshairCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_CrosshairCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCrosshairCursorHandle)));
		}
	}

	public static NSCursor DisappearingItemCursor
	{
		[Export("disappearingItemCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_DisappearingItemCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDisappearingItemCursorHandle)));
		}
	}

	public static NSCursor OperationNotAllowedCursor
	{
		[Export("operationNotAllowedCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_OperationNotAllowedCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOperationNotAllowedCursorHandle)));
		}
	}

	public static NSCursor DragLinkCursor
	{
		[Export("dragLinkCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_DragLinkCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDragLinkCursorHandle)));
		}
	}

	public static NSCursor DragCopyCursor
	{
		[Export("dragCopyCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_DragCopyCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDragCopyCursorHandle)));
		}
	}

	public static NSCursor ContextualMenuCursor
	{
		[Export("contextualMenuCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_ContextualMenuCursor_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selContextualMenuCursorHandle)));
		}
	}

	public static NSCursor IBeamCursorForVerticalLayout
	{
		[Export("IBeamCursorForVerticalLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_IBeamCursorForVerticalLayout_var_static = (NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selIBeamCursorForVerticalLayoutHandle)));
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
	}

	public virtual CGPoint HotSpot
	{
		[Export("hotSpot")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selHotSpotHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selHotSpotHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCursor()
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
	public NSCursor(NSCoder coder)
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
	public NSCursor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCursor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImage:hotSpot:")]
	public NSCursor(NSImage newImage, CGPoint aPoint)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (newImage == null)
		{
			throw new ArgumentNullException("newImage");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint(base.Handle, selInitWithImageHotSpot_Handle, newImage.Handle, aPoint);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selInitWithImageHotSpot_Handle, newImage.Handle, aPoint);
		}
	}

	[Export("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:")]
	public NSCursor(NSImage newImage, NSColor fg, NSColor bg, CGPoint hotSpot)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (newImage == null)
		{
			throw new ArgumentNullException("newImage");
		}
		if (fg == null)
		{
			throw new ArgumentNullException("fg");
		}
		if (bg == null)
		{
			throw new ArgumentNullException("bg");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint(base.Handle, selInitWithImageForegroundColorHintBackgroundColorHintHotSpot_Handle, newImage.Handle, fg.Handle, bg.Handle, hotSpot);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint(base.SuperHandle, selInitWithImageForegroundColorHintBackgroundColorHintHotSpot_Handle, newImage.Handle, fg.Handle, bg.Handle, hotSpot);
		}
	}

	[Export("hide")]
	public static void Hide()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selHideHandle);
	}

	[Export("unhide")]
	public static void Unhide()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selUnhideHandle);
	}

	[Export("setHiddenUntilMouseMoves:")]
	public static void SetHiddenUntilMouseMoves(bool flag)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(class_ptr, selSetHiddenUntilMouseMoves_Handle, flag);
	}

	[Export("push")]
	public virtual void Push()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPushHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPushHandle);
		}
	}

	[Export("pop")]
	public virtual void Pop()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPopHandle);
		}
	}

	[Export("set")]
	public virtual void Set()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("setOnMouseExited:")]
	public virtual void SetOnMouseExited(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOnMouseExited_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOnMouseExited_Handle, flag);
		}
	}

	[Export("setOnMouseEntered:")]
	public virtual void SetOnMouseEntered(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOnMouseEntered_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOnMouseEntered_Handle, flag);
		}
	}

	[Export("isSetOnMouseExited")]
	public virtual bool IsSetOnMouseExited()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsSetOnMouseExitedHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSetOnMouseExitedHandle);
	}

	[Export("isSetOnMouseEntered")]
	public virtual bool IsSetOnMouseEntered()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsSetOnMouseEnteredHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSetOnMouseEnteredHandle);
	}

	[Export("mouseEntered:")]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Image_var = null;
		}
	}
}
