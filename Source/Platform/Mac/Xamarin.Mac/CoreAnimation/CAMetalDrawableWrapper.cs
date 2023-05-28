using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreAnimation;

internal sealed class CAMetalDrawableWrapper : BaseWrapper, ICAMetalDrawable, INativeObject, IDisposable, IMTLDrawable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture Texture
	{
		[Export("texture")]
		get
		{
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("texture")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CAMetalLayer Layer
	{
		[Export("layer")]
		get
		{
			return Runtime.GetNSObject<CAMetalLayer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("layer")));
		}
	}

	[Preserve(Conditional = true)]
	public CAMetalDrawableWrapper(IntPtr handle, bool owns)
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
