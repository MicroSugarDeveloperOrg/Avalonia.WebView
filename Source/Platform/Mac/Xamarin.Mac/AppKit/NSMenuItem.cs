using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenuItem", true)]
public class NSMenuItem : NSObject
{
	private static readonly IntPtr selSeparatorItemHandle = Selector.GetHandle("separatorItem");

	private static readonly IntPtr selHasSubmenuHandle = Selector.GetHandle("hasSubmenu");

	private static readonly IntPtr selParentItemHandle = Selector.GetHandle("parentItem");

	private static readonly IntPtr selIsSeparatorItemHandle = Selector.GetHandle("isSeparatorItem");

	private static readonly IntPtr selUserKeyEquivalentHandle = Selector.GetHandle("userKeyEquivalent");

	private static readonly IntPtr selIsHighlightedHandle = Selector.GetHandle("isHighlighted");

	private static readonly IntPtr selIsHiddenOrHasHiddenAncestorHandle = Selector.GetHandle("isHiddenOrHasHiddenAncestor");

	private static readonly IntPtr selUsesUserKeyEquivalentsHandle = Selector.GetHandle("usesUserKeyEquivalents");

	private static readonly IntPtr selSetUsesUserKeyEquivalents_Handle = Selector.GetHandle("setUsesUserKeyEquivalents:");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selSubmenuHandle = Selector.GetHandle("submenu");

	private static readonly IntPtr selSetSubmenu_Handle = Selector.GetHandle("setSubmenu:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	private static readonly IntPtr selKeyEquivalentHandle = Selector.GetHandle("keyEquivalent");

	private static readonly IntPtr selSetKeyEquivalent_Handle = Selector.GetHandle("setKeyEquivalent:");

	private static readonly IntPtr selKeyEquivalentModifierMaskHandle = Selector.GetHandle("keyEquivalentModifierMask");

	private static readonly IntPtr selSetKeyEquivalentModifierMask_Handle = Selector.GetHandle("setKeyEquivalentModifierMask:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	private static readonly IntPtr selOnStateImageHandle = Selector.GetHandle("onStateImage");

	private static readonly IntPtr selSetOnStateImage_Handle = Selector.GetHandle("setOnStateImage:");

	private static readonly IntPtr selOffStateImageHandle = Selector.GetHandle("offStateImage");

	private static readonly IntPtr selSetOffStateImage_Handle = Selector.GetHandle("setOffStateImage:");

	private static readonly IntPtr selMixedStateImageHandle = Selector.GetHandle("mixedStateImage");

	private static readonly IntPtr selSetMixedStateImage_Handle = Selector.GetHandle("setMixedStateImage:");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selIsAlternateHandle = Selector.GetHandle("isAlternate");

	private static readonly IntPtr selSetAlternate_Handle = Selector.GetHandle("setAlternate:");

	private static readonly IntPtr selIndentationLevelHandle = Selector.GetHandle("indentationLevel");

	private static readonly IntPtr selSetIndentationLevel_Handle = Selector.GetHandle("setIndentationLevel:");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selSetTag_Handle = Selector.GetHandle("setTag:");

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	private static readonly IntPtr selSetToolTip_Handle = Selector.GetHandle("setToolTip:");

	private static readonly IntPtr selInitWithTitleActionKeyEquivalent_Handle = Selector.GetHandle("initWithTitle:action:keyEquivalent:");

	private static readonly IntPtr selSetTitleWithMnemonic_Handle = Selector.GetHandle("setTitleWithMnemonic:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMenuItem");

	private static object __mt_SeparatorItem_var_static;

	private object __mt_ParentItem_var;

	private object __mt_Menu_var;

	private object __mt_Submenu_var;

	private object __mt_AttributedTitle_var;

	private object __mt_Image_var;

	private object __mt_OnStateImage_var;

	private object __mt_OffStateImage_var;

	private object __mt_MixedStateImage_var;

	private object __mt_Target_var;

	private object __mt_RepresentedObject_var;

	private object __mt_View_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSMenuItem SeparatorItem
	{
		[Export("separatorItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_SeparatorItem_var_static = (NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSeparatorItemHandle)));
		}
	}

	public virtual bool HasSubmenu
	{
		[Export("hasSubmenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasSubmenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasSubmenuHandle);
		}
	}

	public virtual NSMenuItem ParentItem
	{
		[Export("parentItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_ParentItem_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentItemHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentItemHandle)))));
		}
	}

	public virtual bool IsSeparatorItem
	{
		[Export("isSeparatorItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSeparatorItemHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSeparatorItemHandle);
		}
	}

	public virtual string UserKeyEquivalent
	{
		[Export("userKeyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserKeyEquivalentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserKeyEquivalentHandle));
		}
	}

	public virtual bool Highlighted
	{
		[Export("isHighlighted")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHighlightedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHighlightedHandle);
		}
	}

	public virtual bool IsHiddenOrHasHiddenAncestor
	{
		[Export("isHiddenOrHasHiddenAncestor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenOrHasHiddenAncestorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenOrHasHiddenAncestorHandle);
		}
	}

	public static bool UsesUserKeyEquivalents
	{
		[Export("usesUserKeyEquivalents")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selUsesUserKeyEquivalentsHandle);
		}
		[Export("setUsesUserKeyEquivalents:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetUsesUserKeyEquivalents_Handle, value);
		}
	}

	public virtual NSMenu Menu
	{
		[Export("menu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Menu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle)))));
		}
		[Export("setMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value.Handle);
			}
			__mt_Menu_var = value;
		}
	}

	public virtual NSMenu Submenu
	{
		[Export("submenu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Submenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubmenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSubmenuHandle)))));
		}
		[Export("setSubmenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubmenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubmenu_Handle, value.Handle);
			}
			__mt_Submenu_var = value;
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSAttributedString AttributedTitle
	{
		[Export("attributedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_AttributedTitle_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedTitleHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedTitleHandle)))));
		}
		[Export("setAttributedTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedTitle_Handle, value.Handle);
			}
			__mt_AttributedTitle_var = value;
		}
	}

	public virtual string KeyEquivalent
	{
		[Export("keyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentHandle));
		}
		[Export("setKeyEquivalent:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyEquivalent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyEquivalent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSEventModifierMask KeyEquivalentModifierMask
	{
		[Export("keyEquivalentModifierMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selKeyEquivalentModifierMaskHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentModifierMaskHandle);
		}
		[Export("setKeyEquivalentModifierMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
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

	public virtual NSCellStateValue State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSCellStateValue)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSCellStateValue)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
		[Export("setState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetState_Handle, (long)value);
			}
		}
	}

	public virtual NSImage OnStateImage
	{
		[Export("onStateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_OnStateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOnStateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOnStateImageHandle)))));
		}
		[Export("setOnStateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOnStateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOnStateImage_Handle, value.Handle);
			}
			__mt_OnStateImage_var = value;
		}
	}

	public virtual NSImage OffStateImage
	{
		[Export("offStateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_OffStateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOffStateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOffStateImageHandle)))));
		}
		[Export("setOffStateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOffStateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOffStateImage_Handle, value.Handle);
			}
			__mt_OffStateImage_var = value;
		}
	}

	public virtual NSImage MixedStateImage
	{
		[Export("mixedStateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_MixedStateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMixedStateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMixedStateImageHandle)))));
		}
		[Export("setMixedStateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMixedStateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMixedStateImage_Handle, value.Handle);
			}
			__mt_MixedStateImage_var = value;
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

	public virtual bool Alternate
	{
		[Export("isAlternate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAlternateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAlternateHandle);
		}
		[Export("setAlternate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlternate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlternate_Handle, value);
			}
		}
	}

	public virtual long IndentationLevel
	{
		[Export("indentationLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selIndentationLevelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIndentationLevelHandle);
		}
		[Export("setIndentationLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetIndentationLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetIndentationLevel_Handle, value);
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_View_var = value;
		}
	}

	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
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

	public NSMenuItem(string title, EventHandler handler)
		: this(title, "", handler)
	{
	}

	public NSMenuItem(string title, string charCode, EventHandler handler)
		: this(title, null, charCode)
	{
		Activated += handler;
	}

	public NSMenuItem(string title, string charCode)
		: this(title, null, charCode)
	{
	}

	public NSMenuItem(string title)
		: this(title, null, "")
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuItem()
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
	public NSMenuItem(NSCoder coder)
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
	public NSMenuItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMenuItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTitle:action:keyEquivalent:")]
	public NSMenuItem(string title, Selector selectorAction, string charCode)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (charCode == null)
		{
			throw new ArgumentNullException("charCode");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(charCode);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTitleActionKeyEquivalent_Handle, arg, (selectorAction == null) ? IntPtr.Zero : selectorAction.Handle, arg2);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTitleActionKeyEquivalent_Handle, arg, (selectorAction == null) ? IntPtr.Zero : selectorAction.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("setTitleWithMnemonic:")]
	public virtual void SetTitleWithMnemonic(string stringWithAmpersand)
	{
		NSApplication.EnsureUIThread();
		if (stringWithAmpersand == null)
		{
			throw new ArgumentNullException("stringWithAmpersand");
		}
		IntPtr arg = NSString.CreateNative(stringWithAmpersand);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithMnemonic_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithMnemonic_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentItem_var = null;
			__mt_Menu_var = null;
			__mt_Submenu_var = null;
			__mt_AttributedTitle_var = null;
			__mt_Image_var = null;
			__mt_OnStateImage_var = null;
			__mt_OffStateImage_var = null;
			__mt_MixedStateImage_var = null;
			__mt_Target_var = null;
			__mt_RepresentedObject_var = null;
			__mt_View_var = null;
		}
	}
}
