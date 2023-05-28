using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKSlideshowDataSourceWrapper : BaseWrapper, IIKSlideshowDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint ItemCount
	{
		[Export("numberOfSlideshowItems")]
		get
		{
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("numberOfSlideshowItems"));
		}
	}

	[Preserve(Conditional = true)]
	public IKSlideshowDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("slideshowItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject GetItemAt(nint index)
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, Selector.GetHandle("slideshowItemAtIndex:"), index));
	}
}
