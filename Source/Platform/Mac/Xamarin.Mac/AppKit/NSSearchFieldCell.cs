using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSSearchFieldCell", true)]
public class NSSearchFieldCell : NSTextFieldCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelButtonCell = "cancelButtonCell";

	private static readonly IntPtr selCancelButtonCellHandle = Selector.GetHandle("cancelButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelButtonRectForBounds_ = "cancelButtonRectForBounds:";

	private static readonly IntPtr selCancelButtonRectForBounds_Handle = Selector.GetHandle("cancelButtonRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRecents = "maximumRecents";

	private static readonly IntPtr selMaximumRecentsHandle = Selector.GetHandle("maximumRecents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecentSearches = "recentSearches";

	private static readonly IntPtr selRecentSearchesHandle = Selector.GetHandle("recentSearches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecentsAutosaveName = "recentsAutosaveName";

	private static readonly IntPtr selRecentsAutosaveNameHandle = Selector.GetHandle("recentsAutosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetCancelButtonCell = "resetCancelButtonCell";

	private static readonly IntPtr selResetCancelButtonCellHandle = Selector.GetHandle("resetCancelButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetSearchButtonCell = "resetSearchButtonCell";

	private static readonly IntPtr selResetSearchButtonCellHandle = Selector.GetHandle("resetSearchButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchButtonCell = "searchButtonCell";

	private static readonly IntPtr selSearchButtonCellHandle = Selector.GetHandle("searchButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchButtonRectForBounds_ = "searchButtonRectForBounds:";

	private static readonly IntPtr selSearchButtonRectForBounds_Handle = Selector.GetHandle("searchButtonRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchMenuTemplate = "searchMenuTemplate";

	private static readonly IntPtr selSearchMenuTemplateHandle = Selector.GetHandle("searchMenuTemplate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchTextRectForBounds_ = "searchTextRectForBounds:";

	private static readonly IntPtr selSearchTextRectForBounds_Handle = Selector.GetHandle("searchTextRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendsSearchStringImmediately = "sendsSearchStringImmediately";

	private static readonly IntPtr selSendsSearchStringImmediatelyHandle = Selector.GetHandle("sendsSearchStringImmediately");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendsWholeSearchString = "sendsWholeSearchString";

	private static readonly IntPtr selSendsWholeSearchStringHandle = Selector.GetHandle("sendsWholeSearchString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCancelButtonCell_ = "setCancelButtonCell:";

	private static readonly IntPtr selSetCancelButtonCell_Handle = Selector.GetHandle("setCancelButtonCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumRecents_ = "setMaximumRecents:";

	private static readonly IntPtr selSetMaximumRecents_Handle = Selector.GetHandle("setMaximumRecents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecentSearches_ = "setRecentSearches:";

	private static readonly IntPtr selSetRecentSearches_Handle = Selector.GetHandle("setRecentSearches:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecentsAutosaveName_ = "setRecentsAutosaveName:";

	private static readonly IntPtr selSetRecentsAutosaveName_Handle = Selector.GetHandle("setRecentsAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchButtonCell_ = "setSearchButtonCell:";

	private static readonly IntPtr selSetSearchButtonCell_Handle = Selector.GetHandle("setSearchButtonCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchMenuTemplate_ = "setSearchMenuTemplate:";

	private static readonly IntPtr selSetSearchMenuTemplate_Handle = Selector.GetHandle("setSearchMenuTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendsSearchStringImmediately_ = "setSendsSearchStringImmediately:";

	private static readonly IntPtr selSetSendsSearchStringImmediately_Handle = Selector.GetHandle("setSendsSearchStringImmediately:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendsWholeSearchString_ = "setSendsWholeSearchString:";

	private static readonly IntPtr selSetSendsWholeSearchString_Handle = Selector.GetHandle("setSendsWholeSearchString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSearchFieldCell");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButtonCell CancelButtonCell
	{
		[Export("cancelButtonCell", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selCancelButtonCellHandle));
			}
			return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCancelButtonCellHandle));
		}
		[Export("setCancelButtonCell:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCancelButtonCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCancelButtonCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumRecents
	{
		[Export("maximumRecents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumRecentsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumRecentsHandle);
		}
		[Export("setMaximumRecents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumRecents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumRecents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] RecentSearches
	{
		[Export("recentSearches")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RecentsAutosaveName
	{
		[Export("recentsAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButtonCell SearchButtonCell
	{
		[Export("searchButtonCell", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchButtonCellHandle));
			}
			return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchButtonCellHandle));
		}
		[Export("setSearchButtonCell:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchButtonCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchButtonCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu SearchMenuTemplate
	{
		[Export("searchMenuTemplate", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchMenuTemplateHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchMenuTemplateHandle));
		}
		[Export("setSearchMenuTemplate:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchMenuTemplate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchMenuTemplate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendsSearchStringImmediately
	{
		[Export("sendsSearchStringImmediately")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsSearchStringImmediatelyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsSearchStringImmediatelyHandle);
		}
		[Export("setSendsSearchStringImmediately:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsSearchStringImmediately_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsSearchStringImmediately_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendsWholeSearchString
	{
		[Export("sendsWholeSearchString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsWholeSearchStringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsWholeSearchStringHandle);
		}
		[Export("setSendsWholeSearchString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsWholeSearchString_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsWholeSearchString_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSearchFieldCell()
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
	public NSSearchFieldCell(NSCoder coder)
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
	protected NSSearchFieldCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSearchFieldCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSearchFieldCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cancelButtonRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CancelButtonRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selCancelButtonRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selCancelButtonRectForBounds_Handle, rect);
		}
		return retval;
	}

	[Export("resetCancelButtonCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetCancelButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCancelButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCancelButtonCellHandle);
		}
	}

	[Export("resetSearchButtonCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetSearchButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetSearchButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetSearchButtonCellHandle);
		}
	}

	[Export("searchButtonRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SearchButtonRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSearchButtonRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSearchButtonRectForBounds_Handle, rect);
		}
		return retval;
	}

	[Export("searchTextRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SearchTextRectForBounds(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSearchTextRectForBounds_Handle, rect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSearchTextRectForBounds_Handle, rect);
		}
		return retval;
	}
}
