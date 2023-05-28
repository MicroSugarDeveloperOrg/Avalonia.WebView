using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Register("NCWidgetListViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NCWidgetListViewController : NSViewController
{
	[Register]
	private sealed class _NCWidgetListViewDelegate : NCWidgetListViewDelegate
	{
		internal EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs>? didRemoveRow;

		internal EventHandler<NCWidgetListViewControllerDidReorderEventArgs>? didReorderRow;

		internal NCWidgetListViewGetController? getViewControllerForRow;

		internal EventHandler? performAddAction;

		internal NCWidgetListViewControllerShouldRemoveRow? shouldRemoveRow;

		internal NCWidgetListViewControllerShouldReorderRow? shouldReorderRow;

		public _NCWidgetListViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		public override void DidRemoveRow(NCWidgetListViewController list, nuint row)
		{
			EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs> eventHandler = didRemoveRow;
			if (eventHandler != null)
			{
				NCWidgetListViewControllerDidRemoveRowEventArgs e = new NCWidgetListViewControllerDidRemoveRowEventArgs(row);
				eventHandler(list, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidReorderRow(NCWidgetListViewController list, nuint row, nuint newIndex)
		{
			EventHandler<NCWidgetListViewControllerDidReorderEventArgs> eventHandler = didReorderRow;
			if (eventHandler != null)
			{
				NCWidgetListViewControllerDidReorderEventArgs e = new NCWidgetListViewControllerDidReorderEventArgs(row, newIndex);
				eventHandler(list, e);
			}
		}

		[Preserve(Conditional = true)]
		public override NSViewController GetViewControllerForRow(NCWidgetListViewController list, nuint row)
		{
			return getViewControllerForRow?.Invoke(list, row);
		}

		[Preserve(Conditional = true)]
		public override void PerformAddAction(NCWidgetListViewController list)
		{
			performAddAction?.Invoke(list, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override bool ShouldRemoveRow(NCWidgetListViewController list, nuint row)
		{
			return shouldRemoveRow?.Invoke(list, row) ?? false;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldReorderRow(NCWidgetListViewController list, nuint row)
		{
			return shouldReorderRow?.Invoke(list, row) ?? false;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContents = "contents";

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditing = "editing";

	private static readonly IntPtr selEditingHandle = Selector.GetHandle("editing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDividerLines = "hasDividerLines";

	private static readonly IntPtr selHasDividerLinesHandle = Selector.GetHandle("hasDividerLines");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumVisibleRowCount = "minimumVisibleRowCount";

	private static readonly IntPtr selMinimumVisibleRowCountHandle = Selector.GetHandle("minimumVisibleRowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowForViewController_ = "rowForViewController:";

	private static readonly IntPtr selRowForViewController_Handle = Selector.GetHandle("rowForViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContents_ = "setContents:";

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditing_ = "setEditing:";

	private static readonly IntPtr selSetEditing_Handle = Selector.GetHandle("setEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasDividerLines_ = "setHasDividerLines:";

	private static readonly IntPtr selSetHasDividerLines_Handle = Selector.GetHandle("setHasDividerLines:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumVisibleRowCount_ = "setMinimumVisibleRowCount:";

	private static readonly IntPtr selSetMinimumVisibleRowCount_Handle = Selector.GetHandle("setMinimumVisibleRowCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsAddButtonWhenEditing_ = "setShowsAddButtonWhenEditing:";

	private static readonly IntPtr selSetShowsAddButtonWhenEditing_Handle = Selector.GetHandle("setShowsAddButtonWhenEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsAddButtonWhenEditing = "showsAddButtonWhenEditing";

	private static readonly IntPtr selShowsAddButtonWhenEditingHandle = Selector.GetHandle("showsAddButtonWhenEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewControllerAtRow_MakeIfNecessary_ = "viewControllerAtRow:makeIfNecessary:";

	private static readonly IntPtr selViewControllerAtRow_MakeIfNecessary_Handle = Selector.GetHandle("viewControllerAtRow:makeIfNecessary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NCWidgetListViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController[] Contents
	{
		[Export("contents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle));
		}
		[Export("setContents:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INCWidgetListViewDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			INCWidgetListViewDelegate iNCWidgetListViewDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INCWidgetListViewDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<INCWidgetListViewDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iNCWidgetListViewDelegate;
			return iNCWidgetListViewDelegate;
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
	public virtual bool Editing
	{
		[Export("editing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEditingHandle);
		}
		[Export("setEditing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDividerLines
	{
		[Export("hasDividerLines")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDividerLinesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDividerLinesHandle);
		}
		[Export("setHasDividerLines:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDividerLines_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDividerLines_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinimumVisibleRowCount
	{
		[Export("minimumVisibleRowCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinimumVisibleRowCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinimumVisibleRowCountHandle);
		}
		[Export("setMinimumVisibleRowCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinimumVisibleRowCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinimumVisibleRowCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsAddButtonWhenEditing
	{
		[Export("showsAddButtonWhenEditing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsAddButtonWhenEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsAddButtonWhenEditingHandle);
		}
		[Export("setShowsAddButtonWhenEditing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsAddButtonWhenEditing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsAddButtonWhenEditing_Handle, value);
			}
		}
	}

	public NCWidgetListViewGetController? GetViewControllerForRow
	{
		get
		{
			return EnsureNCWidgetListViewDelegate().getViewControllerForRow;
		}
		set
		{
			EnsureNCWidgetListViewDelegate().getViewControllerForRow = value;
		}
	}

	public NCWidgetListViewControllerShouldRemoveRow? ShouldRemoveRow
	{
		get
		{
			return EnsureNCWidgetListViewDelegate().shouldRemoveRow;
		}
		set
		{
			EnsureNCWidgetListViewDelegate().shouldRemoveRow = value;
		}
	}

	public NCWidgetListViewControllerShouldReorderRow? ShouldReorderRow
	{
		get
		{
			return EnsureNCWidgetListViewDelegate().shouldReorderRow;
		}
		set
		{
			EnsureNCWidgetListViewDelegate().shouldReorderRow = value;
		}
	}

	public event EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs> DidRemoveRow
	{
		add
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.didRemoveRow = (EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs>)System.Delegate.Combine(nCWidgetListViewDelegate.didRemoveRow, value);
		}
		remove
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.didRemoveRow = (EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs>)System.Delegate.Remove(nCWidgetListViewDelegate.didRemoveRow, value);
		}
	}

	public event EventHandler<NCWidgetListViewControllerDidReorderEventArgs> DidReorderRow
	{
		add
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.didReorderRow = (EventHandler<NCWidgetListViewControllerDidReorderEventArgs>)System.Delegate.Combine(nCWidgetListViewDelegate.didReorderRow, value);
		}
		remove
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.didReorderRow = (EventHandler<NCWidgetListViewControllerDidReorderEventArgs>)System.Delegate.Remove(nCWidgetListViewDelegate.didReorderRow, value);
		}
	}

	public event EventHandler PerformAddAction
	{
		add
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.performAddAction = (EventHandler)System.Delegate.Combine(nCWidgetListViewDelegate.performAddAction, value);
		}
		remove
		{
			_NCWidgetListViewDelegate nCWidgetListViewDelegate = EnsureNCWidgetListViewDelegate();
			nCWidgetListViewDelegate.performAddAction = (EventHandler)System.Delegate.Remove(nCWidgetListViewDelegate.performAddAction, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NCWidgetListViewController()
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
	public NCWidgetListViewController(NSCoder coder)
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
	protected NCWidgetListViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NCWidgetListViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NCWidgetListViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
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

	[Export("rowForViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetRow(NSViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selRowForViewController_Handle, viewController.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForViewController_Handle, viewController.Handle);
	}

	[Export("viewControllerAtRow:makeIfNecessary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController GetViewController(nuint row, bool makeIfNecesary)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_nuint_bool(base.Handle, selViewControllerAtRow_MakeIfNecessary_Handle, row, makeIfNecesary));
		}
		return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper_nuint_bool(base.SuperHandle, selViewControllerAtRow_MakeIfNecessary_Handle, row, makeIfNecesary));
	}

	private _NCWidgetListViewDelegate EnsureNCWidgetListViewDelegate()
	{
		INCWidgetListViewDelegate iNCWidgetListViewDelegate = Delegate;
		if (iNCWidgetListViewDelegate == null || !(iNCWidgetListViewDelegate is _NCWidgetListViewDelegate))
		{
			iNCWidgetListViewDelegate = (Delegate = new _NCWidgetListViewDelegate());
		}
		return (_NCWidgetListViewDelegate)iNCWidgetListViewDelegate;
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
