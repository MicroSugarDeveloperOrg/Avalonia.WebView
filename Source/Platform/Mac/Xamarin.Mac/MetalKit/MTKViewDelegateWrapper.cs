using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MetalKit;

internal sealed class MTKViewDelegateWrapper : BaseWrapper, IMTKViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MTKViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("mtkView:drawableSizeWillChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawableSizeWillChange(MTKView view, CGSize size)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_CGSize(base.Handle, Selector.GetHandle("mtkView:drawableSizeWillChange:"), view.Handle, size);
	}

	[Export("drawInMTKView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Draw(MTKView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("drawInMTKView:"), view.Handle);
	}
}
