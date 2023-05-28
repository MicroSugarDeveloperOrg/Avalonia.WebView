using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindowTabGroup", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSWindowTabGroup : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddWindow_ = "addWindow:";

	private static readonly IntPtr selAddWindow_Handle = Selector.GetHandle("addWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertWindow_AtIndex_ = "insertWindow:atIndex:";

	private static readonly IntPtr selInsertWindow_AtIndex_Handle = Selector.GetHandle("insertWindow:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOverviewVisible = "isOverviewVisible";

	private static readonly IntPtr selIsOverviewVisibleHandle = Selector.GetHandle("isOverviewVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTabBarVisible = "isTabBarVisible";

	private static readonly IntPtr selIsTabBarVisibleHandle = Selector.GetHandle("isTabBarVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveWindow_ = "removeWindow:";

	private static readonly IntPtr selRemoveWindow_Handle = Selector.GetHandle("removeWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedWindow = "selectedWindow";

	private static readonly IntPtr selSelectedWindowHandle = Selector.GetHandle("selectedWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverviewVisible_ = "setOverviewVisible:";

	private static readonly IntPtr selSetOverviewVisible_Handle = Selector.GetHandle("setOverviewVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedWindow_ = "setSelectedWindow:";

	private static readonly IntPtr selSetSelectedWindow_Handle = Selector.GetHandle("setSelectedWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindows = "windows";

	private static readonly IntPtr selWindowsHandle = Selector.GetHandle("windows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSWindowTabGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_SelectedWindow_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OverviewVisible
	{
		[Export("isOverviewVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOverviewVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOverviewVisibleHandle);
		}
		[Export("setOverviewVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOverviewVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOverviewVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow? SelectedWindow
	{
		[Export("selectedWindow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSWindow nSWindow = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedWindowHandle)) : Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedWindowHandle)));
			MarkDirty();
			__mt_SelectedWindow_var = nSWindow;
			return nSWindow;
		}
		[Export("setSelectedWindow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_SelectedWindow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TabBarVisible
	{
		[Export("isTabBarVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTabBarVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTabBarVisibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow[] Windows
	{
		[Export("windows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowsHandle));
			}
			return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSWindowTabGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWindowTabGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddWindow_Handle, window.Handle);
		}
	}

	[Export("insertWindow:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSWindow window, nint index)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertWindow_AtIndex_Handle, window.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertWindow_AtIndex_Handle, window.Handle, index);
		}
	}

	[Export("removeWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWindow_Handle, window.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SelectedWindow_var = null;
		}
	}
}
