using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLDrawableWrapper : BaseWrapper, IMTLDrawable, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MTLDrawableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("present")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Present()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("present"));
	}

	[Export("presentAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Present(double presentationTime)
	{
		Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("presentAtTime:"), presentationTime);
	}
}
