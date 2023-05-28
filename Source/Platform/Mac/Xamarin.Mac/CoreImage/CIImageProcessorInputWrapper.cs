using System;
using CoreGraphics;
using CoreVideo;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIImageProcessorInputWrapper : BaseWrapper, ICIImageProcessorInput, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect Region
	{
		[Export("region")]
		get
		{
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("region"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("bytesPerRow"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIFormat Format
	{
		[Export("format")]
		get
		{
			return (CIFormat)Messaging.int_objc_msgSend(base.Handle, Selector.GetHandle("format"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IntPtr BaseAddress
	{
		[Export("baseAddress")]
		get
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("baseAddress"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CVPixelBuffer? PixelBuffer
	{
		[Export("pixelBuffer")]
		get
		{
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("pixelBuffer")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? MetalTexture
	{
		[Export("metalTexture")]
		get
		{
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("metalTexture")), owns: false);
		}
	}

	[Preserve(Conditional = true)]
	public CIImageProcessorInputWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
