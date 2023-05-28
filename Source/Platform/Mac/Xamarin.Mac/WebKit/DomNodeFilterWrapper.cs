using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class DomNodeFilterWrapper : BaseWrapper, IDomNodeFilter, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public DomNodeFilterWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("acceptNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public short AcceptNode(DomNode n)
	{
		if (n == null)
		{
			throw new ArgumentNullException("n");
		}
		return Messaging.short_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("acceptNode:"), n.Handle);
	}
}
