using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontPanel", true)]
public class NSFontPanel : NSPanel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPanelConvertFont_ = "panelConvertFont:";

	private static readonly IntPtr selPanelConvertFont_Handle = Selector.GetHandle("panelConvertFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadDefaultFontFamilies = "reloadDefaultFontFamilies";

	private static readonly IntPtr selReloadDefaultFontFamiliesHandle = Selector.GetHandle("reloadDefaultFontFamilies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPanelFont_IsMultiple_ = "setPanelFont:isMultiple:";

	private static readonly IntPtr selSetPanelFont_IsMultiple_Handle = Selector.GetHandle("setPanelFont:isMultiple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedFontPanel = "sharedFontPanel";

	private static readonly IntPtr selSharedFontPanelHandle = Selector.GetHandle("sharedFontPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedFontPanelExists = "sharedFontPanelExists";

	private static readonly IntPtr selSharedFontPanelExistsHandle = Selector.GetHandle("sharedFontPanelExists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorksWhenModal = "worksWhenModal";

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFontPanel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? AccessoryView
	{
		[Export("accessoryView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle));
		}
		[Export("setAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
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
	public static NSFontPanel SharedFontPanel
	{
		[Export("sharedFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSFontPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedFontPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SharedFontPanelExists
	{
		[Export("sharedFontPanelExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedFontPanelExistsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontPanel()
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
	public NSFontPanel(NSCoder coder)
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
	protected NSFontPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFontPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("panelConvertFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont PanelConvertFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPanelConvertFont_Handle, fontObj.Handle));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPanelConvertFont_Handle, fontObj.Handle));
	}

	[Export("reloadDefaultFontFamilies")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadDefaultFontFamilies()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDefaultFontFamiliesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDefaultFontFamiliesHandle);
		}
	}

	[Export("setPanelFont:isMultiple:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPanelFont(NSFont fontObj, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetPanelFont_IsMultiple_Handle, fontObj.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetPanelFont_IsMultiple_Handle, fontObj.Handle, isMultiple);
		}
	}
}
