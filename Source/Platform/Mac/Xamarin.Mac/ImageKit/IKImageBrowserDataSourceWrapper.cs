using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

internal sealed class IKImageBrowserDataSourceWrapper : BaseWrapper, IIKImageBrowserDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKImageBrowserDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("numberOfItemsInImageBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint ItemCount(IKImageBrowserView aBrowser)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		return Messaging.nint_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("numberOfItemsInImageBrowser:"), aBrowser.Handle);
	}

	[Export("imageBrowser:itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKImageBrowserItem GetItem(IKImageBrowserView aBrowser, nint index)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		return Runtime.GetINativeObject<IIKImageBrowserItem>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, Selector.GetHandle("imageBrowser:itemAtIndex:"), aBrowser.Handle, index), owns: false);
	}
}
