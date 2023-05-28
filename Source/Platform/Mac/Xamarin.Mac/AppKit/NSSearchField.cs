using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSSearchField", true)]
public class NSSearchField : NSTextField
{
	[Register]
	internal class _NSSearchFieldDelegate : _NSTextFieldDelegate, INSSearchFieldDelegate, INativeObject, IDisposable, INSTextFieldDelegate
	{
		internal EventHandler? searchingEnded;

		internal EventHandler? searchingStarted;

		public _NSSearchFieldDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("searchFieldDidEndSearching:")]
		public void SearchingEnded(NSSearchField sender)
		{
			searchingEnded?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("searchFieldDidStartSearching:")]
		public void SearchingStarted(NSSearchField sender)
		{
			searchingStarted?.Invoke(sender, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCell = "cell";

	private static readonly IntPtr selCellHandle = Selector.GetHandle("cell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCentersPlaceholder = "centersPlaceholder";

	private static readonly IntPtr selCentersPlaceholderHandle = Selector.GetHandle("centersPlaceholder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

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
	private const string selRectForCancelButtonWhenCentered_ = "rectForCancelButtonWhenCentered:";

	private static readonly IntPtr selRectForCancelButtonWhenCentered_Handle = Selector.GetHandle("rectForCancelButtonWhenCentered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForSearchButtonWhenCentered_ = "rectForSearchButtonWhenCentered:";

	private static readonly IntPtr selRectForSearchButtonWhenCentered_Handle = Selector.GetHandle("rectForSearchButtonWhenCentered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForSearchTextWhenCentered_ = "rectForSearchTextWhenCentered:";

	private static readonly IntPtr selRectForSearchTextWhenCentered_Handle = Selector.GetHandle("rectForSearchTextWhenCentered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchMenuTemplate = "searchMenuTemplate";

	private static readonly IntPtr selSearchMenuTemplateHandle = Selector.GetHandle("searchMenuTemplate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendsSearchStringImmediately = "sendsSearchStringImmediately";

	private static readonly IntPtr selSendsSearchStringImmediatelyHandle = Selector.GetHandle("sendsSearchStringImmediately");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendsWholeSearchString = "sendsWholeSearchString";

	private static readonly IntPtr selSendsWholeSearchStringHandle = Selector.GetHandle("sendsWholeSearchString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCell_ = "setCell:";

	private static readonly IntPtr selSetCell_Handle = Selector.GetHandle("setCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCentersPlaceholder_ = "setCentersPlaceholder:";

	private static readonly IntPtr selSetCentersPlaceholder_Handle = Selector.GetHandle("setCentersPlaceholder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

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
	private const string selSetSearchMenuTemplate_ = "setSearchMenuTemplate:";

	private static readonly IntPtr selSetSearchMenuTemplate_Handle = Selector.GetHandle("setSearchMenuTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendsSearchStringImmediately_ = "setSendsSearchStringImmediately:";

	private static readonly IntPtr selSetSendsSearchStringImmediately_Handle = Selector.GetHandle("setSendsSearchStringImmediately:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendsWholeSearchString_ = "setSendsWholeSearchString:";

	private static readonly IntPtr selSetSendsWholeSearchString_Handle = Selector.GetHandle("setSendsWholeSearchString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSearchField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSSearchFieldCell Cell
	{
		[Export("cell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSearchFieldCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellHandle));
			}
			return Runtime.GetNSObject<NSSearchFieldCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellHandle));
		}
		[Export("setCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool CentersPlaceholder
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("centersPlaceholder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCentersPlaceholderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCentersPlaceholderHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCentersPlaceholder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCentersPlaceholder_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCentersPlaceholder_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSSearchFieldDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSSearchFieldDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint MaximumRecents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSMenu SearchMenuTemplate
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool SendsSearchStringImmediately
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool SendsWholeSearchString
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual NSObject? WeakDelegate
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal override Type GetInternalEventDelegateType => typeof(_NSSearchFieldDelegate);

	public event EventHandler SearchingEnded
	{
		add
		{
			_NSSearchFieldDelegate nSSearchFieldDelegate = EnsureNSSearchFieldDelegate();
			nSSearchFieldDelegate.searchingEnded = (EventHandler)System.Delegate.Combine(nSSearchFieldDelegate.searchingEnded, value);
		}
		remove
		{
			_NSSearchFieldDelegate nSSearchFieldDelegate = EnsureNSSearchFieldDelegate();
			nSSearchFieldDelegate.searchingEnded = (EventHandler)System.Delegate.Remove(nSSearchFieldDelegate.searchingEnded, value);
		}
	}

	public event EventHandler SearchingStarted
	{
		add
		{
			_NSSearchFieldDelegate nSSearchFieldDelegate = EnsureNSSearchFieldDelegate();
			nSSearchFieldDelegate.searchingStarted = (EventHandler)System.Delegate.Combine(nSSearchFieldDelegate.searchingStarted, value);
		}
		remove
		{
			_NSSearchFieldDelegate nSSearchFieldDelegate = EnsureNSSearchFieldDelegate();
			nSSearchFieldDelegate.searchingStarted = (EventHandler)System.Delegate.Remove(nSSearchFieldDelegate.searchingStarted, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSearchField()
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
	public NSSearchField(NSCoder coder)
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
	protected NSSearchField(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSearchField(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSearchField(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("rectForCancelButtonWhenCentered:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectForCancelButton(bool isCentered)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_bool(out retval, base.Handle, selRectForCancelButtonWhenCentered_Handle, isCentered);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_bool(out retval, base.SuperHandle, selRectForCancelButtonWhenCentered_Handle, isCentered);
		}
		return retval;
	}

	[Export("rectForSearchButtonWhenCentered:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectForSearchButton(bool isCentered)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_bool(out retval, base.Handle, selRectForSearchButtonWhenCentered_Handle, isCentered);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_bool(out retval, base.SuperHandle, selRectForSearchButtonWhenCentered_Handle, isCentered);
		}
		return retval;
	}

	[Export("rectForSearchTextWhenCentered:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectForSearchText(bool isCentered)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_bool(out retval, base.Handle, selRectForSearchTextWhenCentered_Handle, isCentered);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_bool(out retval, base.SuperHandle, selRectForSearchTextWhenCentered_Handle, isCentered);
		}
		return retval;
	}

	internal override _NSTextFieldDelegate CreateInternalEventDelegateType()
	{
		return new _NSSearchFieldDelegate();
	}

	internal _NSSearchFieldDelegate EnsureNSSearchFieldDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSSearchFieldDelegate nSSearchFieldDelegate = Delegate as _NSSearchFieldDelegate;
		if (nSSearchFieldDelegate == null)
		{
			nSSearchFieldDelegate = (_NSSearchFieldDelegate)(Delegate = (_NSSearchFieldDelegate)CreateInternalEventDelegateType());
		}
		return nSSearchFieldDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
