using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

internal sealed class NCWidgetListViewDelegateWrapper : BaseWrapper, INCWidgetListViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NCWidgetListViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("widgetList:viewControllerForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSViewController GetViewControllerForRow(NCWidgetListViewController list, nuint row)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("widgetList:viewControllerForRow:"), list.Handle, row));
	}
}
