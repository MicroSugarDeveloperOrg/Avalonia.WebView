using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

[Protocol]
[Register("NCWidgetListViewDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public abstract class NCWidgetListViewDelegate : NSObject, INCWidgetListViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NCWidgetListViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NCWidgetListViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NCWidgetListViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("widgetList:didRemoveRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveRow(NCWidgetListViewController list, nuint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetList:didReorderRow:toRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReorderRow(NCWidgetListViewController list, nuint row, nuint newIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetList:viewControllerForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSViewController GetViewControllerForRow(NCWidgetListViewController list, nuint row);

	[Export("widgetListPerformAddAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformAddAction(NCWidgetListViewController list)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetList:shouldRemoveRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRemoveRow(NCWidgetListViewController list, nuint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetList:shouldReorderRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReorderRow(NCWidgetListViewController list, nuint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
