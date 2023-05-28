using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class DomEventListenerWrapper : BaseWrapper, IDomEventListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public DomEventListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("handleEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void HandleEvent(DomEvent evt)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("handleEvent:"), evt.Handle);
	}
}
