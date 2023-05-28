using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

internal sealed class NCWidgetSearchViewDelegateWrapper : BaseWrapper, INCWidgetSearchViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NCWidgetSearchViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("widgetSearch:searchForTerm:maxResults:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SearchForTearm(NCWidgetSearchViewController controller, string searchTerm, nuint max)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (searchTerm == null)
		{
			throw new ArgumentNullException("searchTerm");
		}
		IntPtr intPtr = NSString.CreateNative(searchTerm);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, Selector.GetHandle("widgetSearch:searchForTerm:maxResults:"), controller.Handle, intPtr, max);
		NSString.ReleaseNative(intPtr);
	}

	[Export("widgetSearchTermCleared:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void TermCleared(NCWidgetSearchViewController controller)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("widgetSearchTermCleared:"), controller.Handle);
	}

	[Export("widgetSearch:resultSelected:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ResultSelected(NCWidgetSearchViewController controller, NSObject obj)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("widgetSearch:resultSelected:"), controller.Handle, obj.Handle);
	}
}
