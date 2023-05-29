using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDrawer", true)]
public class NSDrawer : NSResponder
{
	[Register]
	private sealed class _NSDrawerDelegate : NSDrawerDelegate
	{
		internal EventHandler drawerDidClose;

		internal EventHandler drawerDidOpen;

		internal DrawerShouldCloseDelegate drawerShouldClose;

		internal DrawerShouldOpenDelegate drawerShouldOpen;

		internal EventHandler drawerWillClose;

		internal EventHandler drawerWillOpen;

		internal DrawerWillResizeContentsDelegate drawerWillResizeContents;

		[Preserve(Conditional = true)]
		public override void DrawerDidClose(NSNotification notification)
		{
			drawerDidClose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DrawerDidOpen(NSNotification notification)
		{
			drawerDidOpen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override bool DrawerShouldClose(NSDrawer sender)
		{
			return drawerShouldClose?.Invoke(sender) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DrawerShouldOpen(NSDrawer sender)
		{
			return drawerShouldOpen?.Invoke(sender) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void DrawerWillClose(NSNotification notification)
		{
			drawerWillClose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DrawerWillOpen(NSNotification notification)
		{
			drawerWillOpen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override CGSize DrawerWillResizeContents(NSDrawer sender, CGSize toSize)
		{
			DrawerWillResizeContentsDelegate drawerWillResizeContentsDelegate = drawerWillResizeContents;
			if (drawerWillResizeContentsDelegate != null)
			{
				return drawerWillResizeContentsDelegate(sender, toSize);
			}
			throw new Exception("No event handler has been added to the DrawerWillResizeContents event.");
		}
	}

	private static readonly IntPtr selParentWindowHandle = Selector.GetHandle("parentWindow");

	private static readonly IntPtr selSetParentWindow_Handle = Selector.GetHandle("setParentWindow:");

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	private static readonly IntPtr selPreferredEdgeHandle = Selector.GetHandle("preferredEdge");

	private static readonly IntPtr selSetPreferredEdge_Handle = Selector.GetHandle("setPreferredEdge:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	private static readonly IntPtr selEdgeHandle = Selector.GetHandle("edge");

	private static readonly IntPtr selContentSizeHandle = Selector.GetHandle("contentSize");

	private static readonly IntPtr selSetContentSize_Handle = Selector.GetHandle("setContentSize:");

	private static readonly IntPtr selMinContentSizeHandle = Selector.GetHandle("minContentSize");

	private static readonly IntPtr selSetMinContentSize_Handle = Selector.GetHandle("setMinContentSize:");

	private static readonly IntPtr selMaxContentSizeHandle = Selector.GetHandle("maxContentSize");

	private static readonly IntPtr selSetMaxContentSize_Handle = Selector.GetHandle("setMaxContentSize:");

	private static readonly IntPtr selLeadingOffsetHandle = Selector.GetHandle("leadingOffset");

	private static readonly IntPtr selSetLeadingOffset_Handle = Selector.GetHandle("setLeadingOffset:");

	private static readonly IntPtr selTrailingOffsetHandle = Selector.GetHandle("trailingOffset");

	private static readonly IntPtr selSetTrailingOffset_Handle = Selector.GetHandle("setTrailingOffset:");

	private static readonly IntPtr selInitWithContentSizePreferredEdge_Handle = Selector.GetHandle("initWithContentSize:preferredEdge:");

	private static readonly IntPtr selOpenOnEdge_Handle = Selector.GetHandle("openOnEdge:");

	private static readonly IntPtr selOpen_Handle = Selector.GetHandle("open:");

	private static readonly IntPtr selClose_Handle = Selector.GetHandle("close:");

	private static readonly IntPtr selToggle_Handle = Selector.GetHandle("toggle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDrawer");

	private object __mt_ParentWindow_var;

	private object __mt_ContentView_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSWindow ParentWindow
	{
		[Export("parentWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_ParentWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentWindowHandle)))));
		}
		[Export("setParentWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentWindow_Handle, value.Handle);
			}
			__mt_ParentWindow_var = value;
		}
	}

	public virtual NSView ContentView
	{
		[Export("contentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_ContentView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle)))));
		}
		[Export("setContentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value.Handle);
			}
			__mt_ContentView_var = value;
		}
	}

	public virtual NSRectEdge PreferredEdge
	{
		[Export("preferredEdge")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSRectEdge)Messaging.int_objc_msgSend(base.Handle, selPreferredEdgeHandle);
			}
			return (NSRectEdge)Messaging.int_objc_msgSendSuper(base.SuperHandle, selPreferredEdgeHandle);
		}
		[Export("setPreferredEdge:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetPreferredEdge_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetPreferredEdge_Handle, (int)value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSDrawerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSDrawerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSDrawerState State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDrawerState)Messaging.UInt64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSDrawerState)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	public virtual NSRectEdge Edge
	{
		[Export("edge")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSRectEdge)Messaging.int_objc_msgSend(base.Handle, selEdgeHandle);
			}
			return (NSRectEdge)Messaging.int_objc_msgSendSuper(base.SuperHandle, selEdgeHandle);
		}
	}

	public virtual CGSize ContentSize
	{
		[Export("contentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentSizeHandle);
		}
		[Export("setContentSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentSize_Handle, value);
			}
		}
	}

	public virtual CGSize MinContentSize
	{
		[Export("minContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinContentSizeHandle);
		}
		[Export("setMinContentSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinContentSize_Handle, value);
			}
		}
	}

	public virtual CGSize MaxContentSize
	{
		[Export("maxContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxContentSizeHandle);
		}
		[Export("setMaxContentSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxContentSize_Handle, value);
			}
		}
	}

	public virtual double LeadingOffset
	{
		[Export("leadingOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLeadingOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLeadingOffsetHandle);
		}
		[Export("setLeadingOffset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLeadingOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLeadingOffset_Handle, value);
			}
		}
	}

	public virtual double TrailingOffset
	{
		[Export("trailingOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTrailingOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTrailingOffsetHandle);
		}
		[Export("setTrailingOffset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTrailingOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTrailingOffset_Handle, value);
			}
		}
	}

	public DrawerShouldCloseDelegate DrawerShouldClose
	{
		get
		{
			return EnsureNSDrawerDelegate().drawerShouldClose;
		}
		set
		{
			EnsureNSDrawerDelegate().drawerShouldClose = value;
		}
	}

	public DrawerShouldOpenDelegate DrawerShouldOpen
	{
		get
		{
			return EnsureNSDrawerDelegate().drawerShouldOpen;
		}
		set
		{
			EnsureNSDrawerDelegate().drawerShouldOpen = value;
		}
	}

	public DrawerWillResizeContentsDelegate DrawerWillResizeContents
	{
		get
		{
			return EnsureNSDrawerDelegate().drawerWillResizeContents;
		}
		set
		{
			EnsureNSDrawerDelegate().drawerWillResizeContents = value;
		}
	}

	public event EventHandler DrawerDidClose
	{
		add
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerDidClose = (EventHandler)System.Delegate.Combine(nSDrawerDelegate.drawerDidClose, value);
		}
		remove
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerDidClose = (EventHandler)System.Delegate.Remove(nSDrawerDelegate.drawerDidClose, value);
		}
	}

	public event EventHandler DrawerDidOpen
	{
		add
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerDidOpen = (EventHandler)System.Delegate.Combine(nSDrawerDelegate.drawerDidOpen, value);
		}
		remove
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerDidOpen = (EventHandler)System.Delegate.Remove(nSDrawerDelegate.drawerDidOpen, value);
		}
	}

	public event EventHandler DrawerWillClose
	{
		add
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerWillClose = (EventHandler)System.Delegate.Combine(nSDrawerDelegate.drawerWillClose, value);
		}
		remove
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerWillClose = (EventHandler)System.Delegate.Remove(nSDrawerDelegate.drawerWillClose, value);
		}
	}

	public event EventHandler DrawerWillOpen
	{
		add
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerWillOpen = (EventHandler)System.Delegate.Combine(nSDrawerDelegate.drawerWillOpen, value);
		}
		remove
		{
			_NSDrawerDelegate nSDrawerDelegate = EnsureNSDrawerDelegate();
			nSDrawerDelegate.drawerWillOpen = (EventHandler)System.Delegate.Remove(nSDrawerDelegate.drawerWillOpen, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDrawer()
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
	public NSDrawer(NSCoder coder)
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
	public NSDrawer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDrawer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentSize:preferredEdge:")]
	public NSDrawer(CGSize contentSize, NSRectEdge edge)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGSize_int(base.Handle, selInitWithContentSizePreferredEdge_Handle, contentSize, (int)edge);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGSize_int(base.SuperHandle, selInitWithContentSizePreferredEdge_Handle, contentSize, (int)edge);
		}
	}

	[Export("openOnEdge:")]
	public virtual void OpenOnEdge(NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selOpenOnEdge_Handle, (int)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selOpenOnEdge_Handle, (int)edge);
		}
	}

	[Export("open:")]
	public virtual void Open(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOpen_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpen_Handle, sender.Handle);
		}
	}

	[Export("close:")]
	public virtual void Close(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selClose_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selClose_Handle, sender.Handle);
		}
	}

	[Export("toggle:")]
	public virtual void Toggle(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggle_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggle_Handle, sender.Handle);
		}
	}

	private _NSDrawerDelegate EnsureNSDrawerDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSDrawerDelegate))
		{
			nSObject = (WeakDelegate = new _NSDrawerDelegate());
		}
		return (_NSDrawerDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentWindow_var = null;
			__mt_ContentView_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
