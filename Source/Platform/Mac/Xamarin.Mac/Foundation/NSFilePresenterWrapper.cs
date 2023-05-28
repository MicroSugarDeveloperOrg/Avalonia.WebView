using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSFilePresenterWrapper : BaseWrapper, INSFilePresenter, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl PresentedItemURL
	{
		[Export("presentedItemURL", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("presentedItemURL")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOperationQueue PesentedItemOperationQueue
	{
		[Export("presentedItemOperationQueue", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("presentedItemOperationQueue")));
		}
	}

	[Preserve(Conditional = true)]
	public NSFilePresenterWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
