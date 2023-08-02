using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontPanel", true)]
public class NSFontPanel : NSPanel
{
	private static readonly IntPtr selSharedFontPanelHandle = Selector.GetHandle("sharedFontPanel");

	private static readonly IntPtr selSharedFontPanelExistsHandle = Selector.GetHandle("sharedFontPanelExists");

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selSetPanelFontIsMultiple_Handle = Selector.GetHandle("setPanelFont:isMultiple:");

	private static readonly IntPtr selPanelConvertFont_Handle = Selector.GetHandle("panelConvertFont:");

	private static readonly IntPtr selReloadDefaultFontFamiliesHandle = Selector.GetHandle("reloadDefaultFontFamilies");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFontPanel");

	private static object __mt_SharedFontPanel_var_static;

	private object __mt_AccessoryView_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSFontPanel SharedFontPanel
	{
		[Export("sharedFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFontPanel)(__mt_SharedFontPanel_var_static = (NSFontPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedFontPanelHandle)));
		}
	}

	public static bool SharedFontPanelExists
	{
		[Export("sharedFontPanelExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedFontPanelExistsHandle);
		}
	}

	public new virtual bool WorksWhenModal
	{
		[Export("worksWhenModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWorksWhenModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWorksWhenModalHandle);
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

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontPanel()
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
	public NSFontPanel(NSCoder coder)
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
	public NSFontPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFontPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setPanelFont:isMultiple:")]
	public virtual void SetPanelFont(NSFont fontObj, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetPanelFontIsMultiple_Handle, fontObj.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetPanelFontIsMultiple_Handle, fontObj.Handle, isMultiple);
		}
	}

	[Export("panelConvertFont:")]
	public virtual NSFont PanelConvertFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPanelConvertFont_Handle, fontObj.Handle));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPanelConvertFont_Handle, fontObj.Handle));
	}

	[Export("reloadDefaultFontFamilies")]
	public virtual void ReloadDefaultFontFamilies()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDefaultFontFamiliesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDefaultFontFamiliesHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AccessoryView_var = null;
		}
	}
}
