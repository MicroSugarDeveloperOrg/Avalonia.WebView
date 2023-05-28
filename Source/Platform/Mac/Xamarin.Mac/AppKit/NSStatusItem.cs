using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStatusItem", true)]
public class NSStatusItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateImage = "alternateImage";

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedTitle = "attributedTitle";

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveName = "autosaveName";

	private static readonly IntPtr selAutosaveNameHandle = Selector.GetHandle("autosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehavior = "behavior";

	private static readonly IntPtr selBehaviorHandle = Selector.GetHandle("behavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButton = "button";

	private static readonly IntPtr selButtonHandle = Selector.GetHandle("button");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawStatusBarBackgroundInRect_WithHighlight_ = "drawStatusBarBackgroundInRect:withHighlight:";

	private static readonly IntPtr selDrawStatusBarBackgroundInRect_WithHighlight_Handle = Selector.GetHandle("drawStatusBarBackgroundInRect:withHighlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightMode = "highlightMode";

	private static readonly IntPtr selHighlightModeHandle = Selector.GetHandle("highlightMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVisible = "isVisible";

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopUpStatusItemMenu_ = "popUpStatusItemMenu:";

	private static readonly IntPtr selPopUpStatusItemMenu_Handle = Selector.GetHandle("popUpStatusItemMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendActionOn_ = "sendActionOn:";

	private static readonly IntPtr selSendActionOn_Handle = Selector.GetHandle("sendActionOn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateImage_ = "setAlternateImage:";

	private static readonly IntPtr selSetAlternateImage_Handle = Selector.GetHandle("setAlternateImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedTitle_ = "setAttributedTitle:";

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaveName_ = "setAutosaveName:";

	private static readonly IntPtr selSetAutosaveName_Handle = Selector.GetHandle("setAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBehavior_ = "setBehavior:";

	private static readonly IntPtr selSetBehavior_Handle = Selector.GetHandle("setBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlightMode_ = "setHighlightMode:";

	private static readonly IntPtr selSetHighlightMode_Handle = Selector.GetHandle("setHighlightMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLength_ = "setLength:";

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolTip_ = "setToolTip:";

	private static readonly IntPtr selSetToolTip_Handle = Selector.GetHandle("setToolTip:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetView_ = "setView:";

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisible_ = "setVisible:";

	private static readonly IntPtr selSetVisible_Handle = Selector.GetHandle("setVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusBar = "statusBar";

	private static readonly IntPtr selStatusBarHandle = Selector.GetHandle("statusBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolTip = "toolTip";

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStatusItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual Selector? Action
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual NSImage AlternateImage
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("alternateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setAlternateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual NSAttributedString AttributedTitle
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("attributedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedTitleHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedTitleHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setAttributedTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedTitle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string AutosaveName
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("autosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosaveNameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAutosaveName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSStatusItemBehavior Behavior
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("behavior", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSStatusItemBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selBehaviorHandle);
			}
			return (NSStatusItemBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBehaviorHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setBehavior:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBehavior_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSStatusBarButton Button
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("button", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSStatusBarButton>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonHandle));
			}
			return Runtime.GetNSObject<NSStatusBarButton>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual Selector DoubleAction
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("doubleAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDoubleActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDoubleActionHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setDoubleAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDoubleAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDoubleAction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual bool Enabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
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
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual bool HighlightMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("highlightMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHighlightModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHighlightModeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setHighlightMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHighlightMode_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHighlightMode_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual NSImage Image
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
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
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setImage:")]
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
	public virtual nfloat Length
	{
		[Export("length")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		[Export("setLength:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu? Menu
	{
		[Export("menu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSStatusBar StatusBar
	{
		[Export("statusBar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSStatusBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selStatusBarHandle));
			}
			return Runtime.GetNSObject<NSStatusBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStatusBarHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual NSObject? Target
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("target", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setTarget:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual string Title
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual string? ToolTip
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("toolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolTipHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setToolTip:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	public virtual NSView? View
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
		[Export("setView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool Visible
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVisible_Handle, value);
			}
		}
	}

	public event EventHandler DoubleClick
	{
		add
		{
			Target = ActionDispatcher.SetupDoubleAction(Target, value);
			DoubleAction = ActionDispatcher.DoubleAction;
		}
		remove
		{
			ActionDispatcher.RemoveDoubleAction(Target, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	private NSStatusItem()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSStatusItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStatusItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawStatusBarBackgroundInRect:withHighlight:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use standard button instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawStatusBarBackground(CGRect rect, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selDrawStatusBarBackgroundInRect_WithHighlight_Handle, rect, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selDrawStatusBarBackgroundInRect_WithHighlight_Handle, rect, highlight);
		}
	}

	[Export("popUpStatusItemMenu:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Menu' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PopUpStatusItemMenu(NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPopUpStatusItemMenu_Handle, menu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPopUpStatusItemMenu_Handle, menu.Handle);
		}
	}

	[Export("sendActionOn:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Soft-deprecation, forwards message to button, but will be gone in the future.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SendActionOn(NSTouchPhase mask)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_UInt64(base.Handle, selSendActionOn_Handle, (ulong)mask);
		}
		return Messaging.nint_objc_msgSendSuper_UInt64(base.SuperHandle, selSendActionOn_Handle, (ulong)mask);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
		}
	}
}
