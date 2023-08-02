using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorPanel", true)]
public class NSColorPanel : NSPanel
{
	private static readonly IntPtr selSharedColorPanelHandle = Selector.GetHandle("sharedColorPanel");

	private static readonly IntPtr selSharedColorPanelExistsHandle = Selector.GetHandle("sharedColorPanelExists");

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	private static readonly IntPtr selShowsAlphaHandle = Selector.GetHandle("showsAlpha");

	private static readonly IntPtr selSetShowsAlpha_Handle = Selector.GetHandle("setShowsAlpha:");

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selDragColorWithEventFromView_Handle = Selector.GetHandle("dragColor:withEvent:fromView:");

	private static readonly IntPtr selSetPickerMask_Handle = Selector.GetHandle("setPickerMask:");

	private static readonly IntPtr selSetPickerMode_Handle = Selector.GetHandle("setPickerMode:");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selAttachColorList_Handle = Selector.GetHandle("attachColorList:");

	private static readonly IntPtr selDetachColorList_Handle = Selector.GetHandle("detachColorList:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColorPanel");

	private static object __mt_SharedColorPanel_var_static;

	private object __mt_AccessoryView_var;

	private object __mt_Color_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSColorPanel SharedColorPanel
	{
		[Export("sharedColorPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorPanel)(__mt_SharedColorPanel_var_static = (NSColorPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedColorPanelHandle)));
		}
	}

	public static bool SharedColorPanelExists
	{
		[Export("sharedColorPanelExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedColorPanelExistsHandle);
		}
	}

	public virtual double Alpha
	{
		[Export("alpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
	}

	public virtual NSView AccessoryView
	{
		[Export("accessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_AccessoryView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle)))));
		}
		[Export("setAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_AccessoryView_var = value;
		}
	}

	public virtual bool Continuous
	{
		[Export("isContinuous")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousHandle);
		}
		[Export("setContinuous:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuous_Handle, value);
			}
		}
	}

	public virtual bool ShowsAlpha
	{
		[Export("showsAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsAlphaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsAlphaHandle);
		}
		[Export("setShowsAlpha:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsAlpha_Handle, value);
			}
		}
	}

	public virtual NSColorPanelFlags Mode
	{
		[Export("mode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSColorPanelFlags)Messaging.int_objc_msgSend(base.Handle, selModeHandle);
			}
			return (NSColorPanelFlags)Messaging.int_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMode_Handle, (int)value);
			}
		}
	}

	public virtual NSColor Color
	{
		[Export("color")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Color_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle)))));
		}
		[Export("setColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
			__mt_Color_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorPanel()
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
	public NSColorPanel(NSCoder coder)
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
	public NSColorPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColorPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dragColor:withEvent:fromView:")]
	public static bool DragColor(NSColor color, NSEvent theEvent, NSView sourceView)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (sourceView == null)
		{
			throw new ArgumentNullException("sourceView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDragColorWithEventFromView_Handle, color.Handle, theEvent.Handle, sourceView.Handle);
	}

	[Export("setPickerMask:")]
	public static void SetPickerStyle(NSColorPanelFlags mask)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_int(class_ptr, selSetPickerMask_Handle, (int)mask);
	}

	[Export("setPickerMode:")]
	public static void SetPickerMode(NSColorPanelMode mode)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(class_ptr, selSetPickerMode_Handle, (long)mode);
	}

	[Export("setAction:")]
	public virtual void SetAction(Selector aSelector)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (aSelector == null) ? IntPtr.Zero : aSelector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (aSelector == null) ? IntPtr.Zero : aSelector.Handle);
		}
	}

	[Export("setTarget:")]
	public virtual void SetTarget(NSObject anObject)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("attachColorList:")]
	public virtual void AttachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAttachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachColorList_Handle, colorList.Handle);
		}
	}

	[Export("detachColorList:")]
	public virtual void DetachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetachColorList_Handle, colorList.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AccessoryView_var = null;
			__mt_Color_var = null;
		}
	}
}
