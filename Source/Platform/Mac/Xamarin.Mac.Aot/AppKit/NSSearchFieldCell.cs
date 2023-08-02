using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSearchFieldCell", true)]
public class NSSearchFieldCell : NSTextFieldCell
{
	private static readonly IntPtr selSearchButtonCellHandle = Selector.GetHandle("searchButtonCell");

	private static readonly IntPtr selSetSearchButtonCell_Handle = Selector.GetHandle("setSearchButtonCell:");

	private static readonly IntPtr selCancelButtonCellHandle = Selector.GetHandle("cancelButtonCell");

	private static readonly IntPtr selSetCancelButtonCell_Handle = Selector.GetHandle("setCancelButtonCell:");

	private static readonly IntPtr selSearchMenuTemplateHandle = Selector.GetHandle("searchMenuTemplate");

	private static readonly IntPtr selSetSearchMenuTemplate_Handle = Selector.GetHandle("setSearchMenuTemplate:");

	private static readonly IntPtr selSendsWholeSearchStringHandle = Selector.GetHandle("sendsWholeSearchString");

	private static readonly IntPtr selSetSendsWholeSearchString_Handle = Selector.GetHandle("setSendsWholeSearchString:");

	private static readonly IntPtr selMaximumRecentsHandle = Selector.GetHandle("maximumRecents");

	private static readonly IntPtr selSetMaximumRecents_Handle = Selector.GetHandle("setMaximumRecents:");

	private static readonly IntPtr selRecentSearchesHandle = Selector.GetHandle("recentSearches");

	private static readonly IntPtr selSetRecentSearches_Handle = Selector.GetHandle("setRecentSearches:");

	private static readonly IntPtr selRecentsAutosaveNameHandle = Selector.GetHandle("recentsAutosaveName");

	private static readonly IntPtr selSetRecentsAutosaveName_Handle = Selector.GetHandle("setRecentsAutosaveName:");

	private static readonly IntPtr selSendsSearchStringImmediatelyHandle = Selector.GetHandle("sendsSearchStringImmediately");

	private static readonly IntPtr selSetSendsSearchStringImmediately_Handle = Selector.GetHandle("setSendsSearchStringImmediately:");

	private static readonly IntPtr selResetSearchButtonCellHandle = Selector.GetHandle("resetSearchButtonCell");

	private static readonly IntPtr selResetCancelButtonCellHandle = Selector.GetHandle("resetCancelButtonCell");

	private static readonly IntPtr selSearchTextRectForBounds_Handle = Selector.GetHandle("searchTextRectForBounds:");

	private static readonly IntPtr selSearchButtonRectForBounds_Handle = Selector.GetHandle("searchButtonRectForBounds:");

	private static readonly IntPtr selCancelButtonRectForBounds_Handle = Selector.GetHandle("cancelButtonRectForBounds:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSearchFieldCell");

	private object __mt_SearchButtonCell_var;

	private object __mt_CancelButtonCell_var;

	private object __mt_SearchMenuTemplate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSButtonCell SearchButtonCell
	{
		[Export("searchButtonCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSButtonCell)(__mt_SearchButtonCell_var = ((!IsDirectBinding) ? ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchButtonCellHandle))) : ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchButtonCellHandle)))));
		}
		[Export("setSearchButtonCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchButtonCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchButtonCell_Handle, value.Handle);
			}
			__mt_SearchButtonCell_var = value;
		}
	}

	public virtual NSButtonCell CancelButtonCell
	{
		[Export("cancelButtonCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSButtonCell)(__mt_CancelButtonCell_var = ((!IsDirectBinding) ? ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCancelButtonCellHandle))) : ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCancelButtonCellHandle)))));
		}
		[Export("setCancelButtonCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCancelButtonCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCancelButtonCell_Handle, value.Handle);
			}
			__mt_CancelButtonCell_var = value;
		}
	}

	public virtual NSMenu SearchMenuTemplate
	{
		[Export("searchMenuTemplate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_SearchMenuTemplate_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchMenuTemplateHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchMenuTemplateHandle)))));
		}
		[Export("setSearchMenuTemplate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchMenuTemplate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchMenuTemplate_Handle, value.Handle);
			}
			__mt_SearchMenuTemplate_var = value;
		}
	}

	public virtual bool SendsWholeSearchString
	{
		[Export("sendsWholeSearchString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsWholeSearchStringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsWholeSearchStringHandle);
		}
		[Export("setSendsWholeSearchString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsWholeSearchString_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsWholeSearchString_Handle, value);
			}
		}
	}

	public virtual long MaximumRecents
	{
		[Export("maximumRecents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaximumRecentsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaximumRecentsHandle);
		}
		[Export("setMaximumRecents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaximumRecents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaximumRecents_Handle, value);
			}
		}
	}

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

	public virtual bool SendsSearchStringImmediately
	{
		[Export("sendsSearchStringImmediately")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsSearchStringImmediatelyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsSearchStringImmediatelyHandle);
		}
		[Export("setSendsSearchStringImmediately:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsSearchStringImmediately_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsSearchStringImmediately_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSearchFieldCell()
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
	public NSSearchFieldCell(NSCoder coder)
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
	public NSSearchFieldCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSearchFieldCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("resetSearchButtonCell")]
	public virtual void ResetSearchButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetSearchButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetSearchButtonCellHandle);
		}
	}

	[Export("resetCancelButtonCell")]
	public virtual void ResetCancelButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCancelButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCancelButtonCellHandle);
		}
	}

	[Export("searchTextRectForBounds:")]
	public virtual CGRect SearchTextRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSearchTextRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSearchTextRectForBounds_Handle, rect);
		}
		return retval;
	}

	[Export("searchButtonRectForBounds:")]
	public virtual CGRect SearchButtonRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSearchButtonRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSearchButtonRectForBounds_Handle, rect);
		}
		return retval;
	}

	[Export("cancelButtonRectForBounds:")]
	public virtual CGRect CancelButtonRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selCancelButtonRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selCancelButtonRectForBounds_Handle, rect);
		}
		return retval;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SearchButtonCell_var = null;
			__mt_CancelButtonCell_var = null;
			__mt_SearchMenuTemplate_var = null;
		}
	}
}
