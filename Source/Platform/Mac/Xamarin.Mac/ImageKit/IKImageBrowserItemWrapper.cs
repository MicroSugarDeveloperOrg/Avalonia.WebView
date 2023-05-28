using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKImageBrowserItemWrapper : BaseWrapper, IIKImageBrowserItem, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string ImageUID
	{
		[Export("imageUID")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("imageUID")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSString ImageRepresentationType
	{
		[Export("imageRepresentationType")]
		get
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("imageRepresentationType")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject ImageRepresentation
	{
		[Export("imageRepresentation")]
		get
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("imageRepresentation")));
		}
	}

	[Preserve(Conditional = true)]
	public IKImageBrowserItemWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
