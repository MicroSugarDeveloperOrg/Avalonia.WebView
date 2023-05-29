using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTabViewItem", true)]
public class NSTabViewItem : NSObject
{
	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	private static readonly IntPtr selInitialFirstResponderHandle = Selector.GetHandle("initialFirstResponder");

	private static readonly IntPtr selSetInitialFirstResponder_Handle = Selector.GetHandle("setInitialFirstResponder:");

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selTabStateHandle = Selector.GetHandle("tabState");

	private static readonly IntPtr selTabViewHandle = Selector.GetHandle("tabView");

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	private static readonly IntPtr selDrawLabelInRect_Handle = Selector.GetHandle("drawLabel:inRect:");

	private static readonly IntPtr selSizeOfLabel_Handle = Selector.GetHandle("sizeOfLabel:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTabViewItem");

	private object __mt_Identifier_var;

	private object __mt_View_var;

	private object __mt_InitialFirstResponder_var;

	private object __mt_Color_var;

	private object __mt_TabView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Identifier_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle))));
		}
		[Export("setIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, value.Handle);
			}
			__mt_Identifier_var = value;
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

	public virtual NSObject InitialFirstResponder
	{
		[Export("initialFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_InitialFirstResponder_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialFirstResponderHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialFirstResponderHandle))));
		}
		[Export("setInitialFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInitialFirstResponder_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInitialFirstResponder_Handle, value.Handle);
			}
			__mt_InitialFirstResponder_var = value;
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

	public virtual NSTabState TabState
	{
		[Export("tabState")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTabState)Messaging.UInt64_objc_msgSend(base.Handle, selTabStateHandle);
			}
			return (NSTabState)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabStateHandle);
		}
	}

	public virtual NSTabView TabView
	{
		[Export("tabView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTabView)(__mt_TabView_var = ((!IsDirectBinding) ? ((NSTabView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabViewHandle))) : ((NSTabView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTabViewHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabViewItem()
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
	public NSTabViewItem(NSCoder coder)
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
	public NSTabViewItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTabViewItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	public NSTabViewItem(NSObject identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, identifier.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("drawLabel:inRect:")]
	public virtual void DrawLabel(bool shouldTruncateLabel, CGRect labelRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_CGRect(base.Handle, selDrawLabelInRect_Handle, shouldTruncateLabel, labelRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_CGRect(base.SuperHandle, selDrawLabelInRect_Handle, shouldTruncateLabel, labelRect);
		}
	}

	[Export("sizeOfLabel:")]
	public virtual CGSize SizeOfLabel(bool computeMin)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_bool(base.Handle, selSizeOfLabel_Handle, computeMin);
		}
		return Messaging.CGSize_objc_msgSendSuper_bool(base.SuperHandle, selSizeOfLabel_Handle, computeMin);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Identifier_var = null;
			__mt_View_var = null;
			__mt_InitialFirstResponder_var = null;
			__mt_Color_var = null;
			__mt_TabView_var = null;
		}
	}
}
