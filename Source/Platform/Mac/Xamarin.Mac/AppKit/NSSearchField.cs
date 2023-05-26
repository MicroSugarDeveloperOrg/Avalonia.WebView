using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSearchField", true)]
public class NSSearchField : NSTextField
{
	private static readonly IntPtr selRecentSearchesHandle = Selector.GetHandle("recentSearches");

	private static readonly IntPtr selSetRecentSearches_Handle = Selector.GetHandle("setRecentSearches:");

	private static readonly IntPtr selRecentsAutosaveNameHandle = Selector.GetHandle("recentsAutosaveName");

	private static readonly IntPtr selSetRecentsAutosaveName_Handle = Selector.GetHandle("setRecentsAutosaveName:");

	private static readonly IntPtr selCellHandle = Selector.GetHandle("cell");

	private static readonly IntPtr selSetCell_Handle = Selector.GetHandle("setCell:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSearchField");

	private object __mt_Cell_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string[] RecentSearches
	{
		[Export("recentSearches")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRecentSearchesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecentSearchesHandle));
		}
		[Export("setRecentSearches:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecentSearches_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecentSearches_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	public virtual string RecentsAutosaveName
	{
		[Export("recentsAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRecentsAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecentsAutosaveNameHandle));
		}
		[Export("setRecentsAutosaveName:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecentsAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecentsAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual NSSearchFieldCell Cell
	{
		[Export("cell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSearchFieldCell)(__mt_Cell_var = ((!IsDirectBinding) ? ((NSSearchFieldCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellHandle))) : ((NSSearchFieldCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCellHandle)))));
		}
		[Export("setCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCell_Handle, value.Handle);
			}
			__mt_Cell_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSearchField()
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
	public NSSearchField(NSCoder coder)
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
	public NSSearchField(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSearchField(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSSearchField(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Cell_var = null;
		}
	}
}
