using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSToolbarItem", true)]
public class NSToolbarItem : NSObject
{
	private static readonly IntPtr selItemIdentifierHandle = Selector.GetHandle("itemIdentifier");

	private static readonly IntPtr selToolbarHandle = Selector.GetHandle("toolbar");

	private static readonly IntPtr selAllowsDuplicatesInToolbarHandle = Selector.GetHandle("allowsDuplicatesInToolbar");

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	private static readonly IntPtr selPaletteLabelHandle = Selector.GetHandle("paletteLabel");

	private static readonly IntPtr selSetPaletteLabel_Handle = Selector.GetHandle("setPaletteLabel:");

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	private static readonly IntPtr selSetToolTip_Handle = Selector.GetHandle("setToolTip:");

	private static readonly IntPtr selMenuFormRepresentationHandle = Selector.GetHandle("menuFormRepresentation");

	private static readonly IntPtr selSetMenuFormRepresentation_Handle = Selector.GetHandle("setMenuFormRepresentation:");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selSetTag_Handle = Selector.GetHandle("setTag:");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	private static readonly IntPtr selMinSizeHandle = Selector.GetHandle("minSize");

	private static readonly IntPtr selSetMinSize_Handle = Selector.GetHandle("setMinSize:");

	private static readonly IntPtr selMaxSizeHandle = Selector.GetHandle("maxSize");

	private static readonly IntPtr selSetMaxSize_Handle = Selector.GetHandle("setMaxSize:");

	private static readonly IntPtr selVisibilityPriorityHandle = Selector.GetHandle("visibilityPriority");

	private static readonly IntPtr selSetVisibilityPriority_Handle = Selector.GetHandle("setVisibilityPriority:");

	private static readonly IntPtr selAutovalidatesHandle = Selector.GetHandle("autovalidates");

	private static readonly IntPtr selSetAutovalidates_Handle = Selector.GetHandle("setAutovalidates:");

	private static readonly IntPtr selInitWithItemIdentifier_Handle = Selector.GetHandle("initWithItemIdentifier:");

	private static readonly IntPtr selValidateHandle = Selector.GetHandle("validate");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSToolbarItem");

	private object __mt_Toolbar_var;

	private object __mt_MenuFormRepresentation_var;

	private object __mt_Target_var;

	private object __mt_Image_var;

	private object __mt_View_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Identifier
	{
		[Export("itemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selItemIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemIdentifierHandle));
		}
	}

	public virtual NSToolbar Toolbar
	{
		[Export("toolbar")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSToolbar)(__mt_Toolbar_var = ((!IsDirectBinding) ? ((NSToolbar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarHandle))) : ((NSToolbar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarHandle)))));
		}
	}

	public virtual bool AllowsDuplicatesInToolbar
	{
		[Export("allowsDuplicatesInToolbar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDuplicatesInToolbarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDuplicatesInToolbarHandle);
		}
	}

	public virtual string Label
	{
		[Export("label")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string PaletteLabel
	{
		[Export("paletteLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPaletteLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaletteLabelHandle));
		}
		[Export("setPaletteLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPaletteLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPaletteLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ToolTip
	{
		[Export("toolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolTipHandle));
		}
		[Export("setToolTip:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToolTip_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToolTip_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSMenuItem MenuFormRepresentation
	{
		[Export("menuFormRepresentation")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_MenuFormRepresentation_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuFormRepresentationHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuFormRepresentationHandle)))));
		}
		[Export("setMenuFormRepresentation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuFormRepresentation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuFormRepresentation_Handle, value.Handle);
			}
			__mt_MenuFormRepresentation_var = value;
		}
	}

	public virtual long Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
		[Export("setTag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTag_Handle, value);
			}
		}
	}

	public virtual NSObject Target
	{
		[Export("target")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Target_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle))));
		}
		[Export("setTarget:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Target_var = value;
		}
	}

	public virtual Selector Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Image_var = value;
		}
	}

	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_View_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)))));
		}
		[Export("setView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value.Handle);
			}
			__mt_View_var = value;
		}
	}

	public virtual CGSize MinSize
	{
		[Export("minSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinSizeHandle);
		}
		[Export("setMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinSize_Handle, value);
			}
		}
	}

	public virtual CGSize MaxSize
	{
		[Export("maxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxSizeHandle);
		}
		[Export("setMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxSize_Handle, value);
			}
		}
	}

	public virtual long VisibilityPriority
	{
		[Export("visibilityPriority")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selVisibilityPriorityHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVisibilityPriorityHandle);
		}
		[Export("setVisibilityPriority:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVisibilityPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVisibilityPriority_Handle, value);
			}
		}
	}

	public virtual bool Autovalidates
	{
		[Export("autovalidates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutovalidatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutovalidatesHandle);
		}
		[Export("setAutovalidates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutovalidates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutovalidates_Handle, value);
			}
		}
	}

	public event EventHandler Activated
	{
		add
		{
			Target = ActionDispatcher.SetupAction(Target, value);
			Action = ActionDispatcher.Action;
		}
		remove
		{
			ActionDispatcher.RemoveAction(Target, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSToolbarItem()
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
	public NSToolbarItem(NSCoder coder)
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
	public NSToolbarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSToolbarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItemIdentifier:")]
	public NSToolbarItem(string itemIdentifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItemIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItemIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("validate")]
	public virtual void Validate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Toolbar_var = null;
			__mt_MenuFormRepresentation_var = null;
			__mt_Target_var = null;
			__mt_Image_var = null;
			__mt_View_var = null;
		}
	}
}
