using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDockTile", true)]
public class NSDockTile : NSObject
{
	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	private static readonly IntPtr selShowsApplicationBadgeHandle = Selector.GetHandle("showsApplicationBadge");

	private static readonly IntPtr selSetShowsApplicationBadge_Handle = Selector.GetHandle("setShowsApplicationBadge:");

	private static readonly IntPtr selBadgeLabelHandle = Selector.GetHandle("badgeLabel");

	private static readonly IntPtr selSetBadgeLabel_Handle = Selector.GetHandle("setBadgeLabel:");

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDockTile");

	private object __mt_Owner_var;

	private object __mt_ContentView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Owner_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle))));
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

	public virtual bool ShowsApplicationBadge
	{
		[Export("showsApplicationBadge")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsApplicationBadgeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsApplicationBadgeHandle);
		}
		[Export("setShowsApplicationBadge:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsApplicationBadge_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsApplicationBadge_Handle, value);
			}
		}
	}

	public virtual string BadgeLabel
	{
		[Export("badgeLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBadgeLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBadgeLabelHandle));
		}
		[Export("setBadgeLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBadgeLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBadgeLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDockTile()
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
	public NSDockTile(NSCoder coder)
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
	public NSDockTile(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDockTile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("display")]
	public virtual void Display()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Owner_var = null;
			__mt_ContentView_var = null;
		}
	}
}
