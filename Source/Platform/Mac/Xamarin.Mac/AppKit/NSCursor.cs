using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCursor", true)]
public class NSCursor : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIBeamCursor = "IBeamCursor";

	private static readonly IntPtr selIBeamCursorHandle = Selector.GetHandle("IBeamCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIBeamCursorForVerticalLayout = "IBeamCursorForVerticalLayout";

	private static readonly IntPtr selIBeamCursorForVerticalLayoutHandle = Selector.GetHandle("IBeamCursorForVerticalLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrowCursor = "arrowCursor";

	private static readonly IntPtr selArrowCursorHandle = Selector.GetHandle("arrowCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClosedHandCursor = "closedHandCursor";

	private static readonly IntPtr selClosedHandCursorHandle = Selector.GetHandle("closedHandCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextualMenuCursor = "contextualMenuCursor";

	private static readonly IntPtr selContextualMenuCursorHandle = Selector.GetHandle("contextualMenuCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCrosshairCursor = "crosshairCursor";

	private static readonly IntPtr selCrosshairCursorHandle = Selector.GetHandle("crosshairCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentCursor = "currentCursor";

	private static readonly IntPtr selCurrentCursorHandle = Selector.GetHandle("currentCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSystemCursor = "currentSystemCursor";

	private static readonly IntPtr selCurrentSystemCursorHandle = Selector.GetHandle("currentSystemCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisappearingItemCursor = "disappearingItemCursor";

	private static readonly IntPtr selDisappearingItemCursorHandle = Selector.GetHandle("disappearingItemCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragCopyCursor = "dragCopyCursor";

	private static readonly IntPtr selDragCopyCursorHandle = Selector.GetHandle("dragCopyCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragLinkCursor = "dragLinkCursor";

	private static readonly IntPtr selDragLinkCursorHandle = Selector.GetHandle("dragLinkCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHide = "hide";

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHotSpot = "hotSpot";

	private static readonly IntPtr selHotSpotHandle = Selector.GetHandle("hotSpot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_ = "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:";

	private static readonly IntPtr selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_Handle = Selector.GetHandle("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImage_HotSpot_ = "initWithImage:hotSpot:";

	private static readonly IntPtr selInitWithImage_HotSpot_Handle = Selector.GetHandle("initWithImage:hotSpot:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSetOnMouseEntered = "isSetOnMouseEntered";

	private static readonly IntPtr selIsSetOnMouseEnteredHandle = Selector.GetHandle("isSetOnMouseEntered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSetOnMouseExited = "isSetOnMouseExited";

	private static readonly IntPtr selIsSetOnMouseExitedHandle = Selector.GetHandle("isSetOnMouseExited");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseEntered_ = "mouseEntered:";

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseExited_ = "mouseExited:";

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenHandCursor = "openHandCursor";

	private static readonly IntPtr selOpenHandCursorHandle = Selector.GetHandle("openHandCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperationNotAllowedCursor = "operationNotAllowedCursor";

	private static readonly IntPtr selOperationNotAllowedCursorHandle = Selector.GetHandle("operationNotAllowedCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointingHandCursor = "pointingHandCursor";

	private static readonly IntPtr selPointingHandCursorHandle = Selector.GetHandle("pointingHandCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPop = "pop";

	private static readonly IntPtr selPopHandle = Selector.GetHandle("pop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPush = "push";

	private static readonly IntPtr selPushHandle = Selector.GetHandle("push");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeDownCursor = "resizeDownCursor";

	private static readonly IntPtr selResizeDownCursorHandle = Selector.GetHandle("resizeDownCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeLeftCursor = "resizeLeftCursor";

	private static readonly IntPtr selResizeLeftCursorHandle = Selector.GetHandle("resizeLeftCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeLeftRightCursor = "resizeLeftRightCursor";

	private static readonly IntPtr selResizeLeftRightCursorHandle = Selector.GetHandle("resizeLeftRightCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeRightCursor = "resizeRightCursor";

	private static readonly IntPtr selResizeRightCursorHandle = Selector.GetHandle("resizeRightCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeUpCursor = "resizeUpCursor";

	private static readonly IntPtr selResizeUpCursorHandle = Selector.GetHandle("resizeUpCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeUpDownCursor = "resizeUpDownCursor";

	private static readonly IntPtr selResizeUpDownCursorHandle = Selector.GetHandle("resizeUpDownCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSet = "set";

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHiddenUntilMouseMoves_ = "setHiddenUntilMouseMoves:";

	private static readonly IntPtr selSetHiddenUntilMouseMoves_Handle = Selector.GetHandle("setHiddenUntilMouseMoves:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOnMouseEntered_ = "setOnMouseEntered:";

	private static readonly IntPtr selSetOnMouseEntered_Handle = Selector.GetHandle("setOnMouseEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOnMouseExited_ = "setOnMouseExited:";

	private static readonly IntPtr selSetOnMouseExited_Handle = Selector.GetHandle("setOnMouseExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnhide = "unhide";

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCursor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ArrowCursor
	{
		[Export("arrowCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selArrowCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ClosedHandCursor
	{
		[Export("closedHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selClosedHandCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ContextualMenuCursor
	{
		[Export("contextualMenuCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selContextualMenuCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor CrosshairCursor
	{
		[Export("crosshairCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCrosshairCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor CurrentCursor
	{
		[Export("currentCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor? CurrentSystemCursor
	{
		[Export("currentSystemCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentSystemCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor DisappearingItemCursor
	{
		[Export("disappearingItemCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDisappearingItemCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor DragCopyCursor
	{
		[Export("dragCopyCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDragCopyCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor DragLinkCursor
	{
		[Export("dragLinkCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDragLinkCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint HotSpot
	{
		[Export("hotSpot")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selHotSpotHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selHotSpotHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor IBeamCursor
	{
		[Export("IBeamCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selIBeamCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor IBeamCursorForVerticalLayout
	{
		[Export("IBeamCursorForVerticalLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selIBeamCursorForVerticalLayoutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor OpenHandCursor
	{
		[Export("openHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selOpenHandCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor OperationNotAllowedCursor
	{
		[Export("operationNotAllowedCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selOperationNotAllowedCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor PointingHandCursor
	{
		[Export("pointingHandCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selPointingHandCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeDownCursor
	{
		[Export("resizeDownCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeDownCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeLeftCursor
	{
		[Export("resizeLeftCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeLeftCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeLeftRightCursor
	{
		[Export("resizeLeftRightCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeLeftRightCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeRightCursor
	{
		[Export("resizeRightCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeRightCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeUpCursor
	{
		[Export("resizeUpCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeUpCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCursor ResizeUpDownCursor
	{
		[Export("resizeUpDownCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(class_ptr, selResizeUpDownCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCursor()
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
	public NSCursor(NSCoder coder)
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
	protected NSCursor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCursor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImage:hotSpot:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCursor(NSImage newImage, CGPoint aPoint)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (newImage == null)
		{
			throw new ArgumentNullException("newImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint(base.Handle, selInitWithImage_HotSpot_Handle, newImage.Handle, aPoint), "initWithImage:hotSpot:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selInitWithImage_HotSpot_Handle, newImage.Handle, aPoint), "initWithImage:hotSpot:");
		}
	}

	[Export("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, "Color hints are ignored. Use NSCursor (NSImage newImage, CGPoint aPoint) instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint(base.Handle, selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_Handle, newImage.Handle, fg.Handle, bg.Handle, hotSpot), "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint(base.SuperHandle, selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_Handle, newImage.Handle, fg.Handle, bg.Handle, hotSpot), "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");
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

	[Export("hide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Hide()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selHideHandle);
	}

	[Export("isSetOnMouseEntered")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSetOnMouseEntered()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsSetOnMouseEnteredHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSetOnMouseEnteredHandle);
	}

	[Export("isSetOnMouseExited")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSetOnMouseExited()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsSetOnMouseExitedHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSetOnMouseExitedHandle);
	}

	[Export("mouseEntered:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	[Export("pop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pop()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPopHandle);
		}
	}

	[Export("push")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Push()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPushHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPushHandle);
		}
	}

	[Export("set")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Set()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("setHiddenUntilMouseMoves:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetHiddenUntilMouseMoves(bool flag)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(class_ptr, selSetHiddenUntilMouseMoves_Handle, flag);
	}

	[Export("setOnMouseEntered:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOnMouseEntered(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOnMouseEntered_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOnMouseEntered_Handle, flag);
		}
	}

	[Export("setOnMouseExited:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOnMouseExited(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOnMouseExited_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOnMouseExited_Handle, flag);
		}
	}

	[Export("unhide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Unhide()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selUnhideHandle);
	}
}
