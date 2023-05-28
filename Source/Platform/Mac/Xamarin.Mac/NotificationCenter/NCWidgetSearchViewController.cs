using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Register("NCWidgetSearchViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NCWidgetSearchViewController : NSViewController
{
	[Register]
	private sealed class _NCWidgetSearchViewDelegate : NCWidgetSearchViewDelegate
	{
		internal EventHandler<NSWidgetSearchResultSelectedEventArgs>? resultSelected;

		internal EventHandler<NSWidgetSearchForTermEventArgs>? searchForTearm;

		internal EventHandler? termCleared;

		public _NCWidgetSearchViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		public override void ResultSelected(NCWidgetSearchViewController controller, NSObject obj)
		{
			EventHandler<NSWidgetSearchResultSelectedEventArgs> eventHandler = resultSelected;
			if (eventHandler != null)
			{
				NSWidgetSearchResultSelectedEventArgs e = new NSWidgetSearchResultSelectedEventArgs(obj);
				eventHandler(controller, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void SearchForTearm(NCWidgetSearchViewController controller, string searchTerm, nuint max)
		{
			EventHandler<NSWidgetSearchForTermEventArgs> eventHandler = searchForTearm;
			if (eventHandler != null)
			{
				NSWidgetSearchForTermEventArgs e = new NSWidgetSearchForTermEventArgs(searchTerm, max);
				eventHandler(controller, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void TermCleared(NCWidgetSearchViewController controller)
		{
			termCleared?.Invoke(controller, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchDescription = "searchDescription";

	private static readonly IntPtr selSearchDescriptionHandle = Selector.GetHandle("searchDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchResultKeyPath = "searchResultKeyPath";

	private static readonly IntPtr selSearchResultKeyPathHandle = Selector.GetHandle("searchResultKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchResults = "searchResults";

	private static readonly IntPtr selSearchResultsHandle = Selector.GetHandle("searchResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchResultsPlaceholderString = "searchResultsPlaceholderString";

	private static readonly IntPtr selSearchResultsPlaceholderStringHandle = Selector.GetHandle("searchResultsPlaceholderString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchDescription_ = "setSearchDescription:";

	private static readonly IntPtr selSetSearchDescription_Handle = Selector.GetHandle("setSearchDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchResultKeyPath_ = "setSearchResultKeyPath:";

	private static readonly IntPtr selSetSearchResultKeyPath_Handle = Selector.GetHandle("setSearchResultKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchResults_ = "setSearchResults:";

	private static readonly IntPtr selSetSearchResults_Handle = Selector.GetHandle("setSearchResults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchResultsPlaceholderString_ = "setSearchResultsPlaceholderString:";

	private static readonly IntPtr selSetSearchResultsPlaceholderString_Handle = Selector.GetHandle("setSearchResultsPlaceholderString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NCWidgetSearchViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INCWidgetSearchViewDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			INCWidgetSearchViewDelegate iNCWidgetSearchViewDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INCWidgetSearchViewDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<INCWidgetSearchViewDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iNCWidgetSearchViewDelegate;
			return iNCWidgetSearchViewDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SearchDescription
	{
		[Export("searchDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchDescriptionHandle));
		}
		[Export("setSearchDescription:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SearchResultKeyPath
	{
		[Export("searchResultKeyPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchResultKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchResultKeyPathHandle));
		}
		[Export("setSearchResultKeyPath:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchResultKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchResultKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? SearchResults
	{
		[Export("searchResults", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchResultsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchResultsHandle));
		}
		[Export("setSearchResults:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchResults_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchResults_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SearchResultsPlaceholderString
	{
		[Export("searchResultsPlaceholderString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchResultsPlaceholderStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchResultsPlaceholderStringHandle));
		}
		[Export("setSearchResultsPlaceholderString:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchResultsPlaceholderString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchResultsPlaceholderString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public event EventHandler<NSWidgetSearchResultSelectedEventArgs> ResultSelected
	{
		add
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.resultSelected = (EventHandler<NSWidgetSearchResultSelectedEventArgs>)System.Delegate.Combine(nCWidgetSearchViewDelegate.resultSelected, value);
		}
		remove
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.resultSelected = (EventHandler<NSWidgetSearchResultSelectedEventArgs>)System.Delegate.Remove(nCWidgetSearchViewDelegate.resultSelected, value);
		}
	}

	public event EventHandler<NSWidgetSearchForTermEventArgs> SearchForTearm
	{
		add
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.searchForTearm = (EventHandler<NSWidgetSearchForTermEventArgs>)System.Delegate.Combine(nCWidgetSearchViewDelegate.searchForTearm, value);
		}
		remove
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.searchForTearm = (EventHandler<NSWidgetSearchForTermEventArgs>)System.Delegate.Remove(nCWidgetSearchViewDelegate.searchForTearm, value);
		}
	}

	public event EventHandler TermCleared
	{
		add
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.termCleared = (EventHandler)System.Delegate.Combine(nCWidgetSearchViewDelegate.termCleared, value);
		}
		remove
		{
			_NCWidgetSearchViewDelegate nCWidgetSearchViewDelegate = EnsureNCWidgetSearchViewDelegate();
			nCWidgetSearchViewDelegate.termCleared = (EventHandler)System.Delegate.Remove(nCWidgetSearchViewDelegate.termCleared, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NCWidgetSearchViewController()
		: base(NSObjectFlag.Empty)
	{
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
	public NCWidgetSearchViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NCWidgetSearchViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NCWidgetSearchViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NCWidgetSearchViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	private _NCWidgetSearchViewDelegate EnsureNCWidgetSearchViewDelegate()
	{
		INCWidgetSearchViewDelegate iNCWidgetSearchViewDelegate = Delegate;
		if (iNCWidgetSearchViewDelegate == null || !(iNCWidgetSearchViewDelegate is _NCWidgetSearchViewDelegate))
		{
			iNCWidgetSearchViewDelegate = (Delegate = new _NCWidgetSearchViewDelegate());
		}
		return (_NCWidgetSearchViewDelegate)iNCWidgetSearchViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
