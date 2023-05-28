using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

internal sealed class NSFileProviderEnumeratorWrapper : BaseWrapper, INSFileProviderEnumerator, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFileProviderEnumeratorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Invalidate()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("invalidate"));
	}

	[Export("enumerateItemsForObserver:startingAtPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EnumerateItems(INSFileProviderEnumerationObserver observer, NSData startPage)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (startPage == null)
		{
			throw new ArgumentNullException("startPage");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("enumerateItemsForObserver:startingAtPage:"), observer.Handle, startPage.Handle);
	}
}
