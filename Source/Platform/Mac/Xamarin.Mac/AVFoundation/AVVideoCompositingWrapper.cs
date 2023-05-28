using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVVideoCompositingWrapper : BaseWrapper, IAVVideoCompositing, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVVideoCompositingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("sourcePixelBufferAttributes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary? SourcePixelBufferAttributes()
	{
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("sourcePixelBufferAttributes")));
	}

	[Export("requiredPixelBufferAttributesForRenderContext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary RequiredPixelBufferAttributesForRenderContext()
	{
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("requiredPixelBufferAttributesForRenderContext")));
	}

	[Export("renderContextChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RenderContextChanged(AVVideoCompositionRenderContext newRenderContext)
	{
		if (newRenderContext == null)
		{
			throw new ArgumentNullException("newRenderContext");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("renderContextChanged:"), newRenderContext.Handle);
	}

	[Export("startVideoCompositionRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StartVideoCompositionRequest(AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest)
	{
		if (asyncVideoCompositionRequest == null)
		{
			throw new ArgumentNullException("asyncVideoCompositionRequest");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("startVideoCompositionRequest:"), asyncVideoCompositionRequest.Handle);
	}
}
