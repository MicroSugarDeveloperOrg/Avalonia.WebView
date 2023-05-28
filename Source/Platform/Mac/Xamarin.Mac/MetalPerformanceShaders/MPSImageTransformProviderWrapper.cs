using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSImageTransformProviderWrapper : BaseWrapper, IMPSImageTransformProvider, INativeObject, IDisposable, INSCoding
{
	[Preserve(Conditional = true)]
	public MPSImageTransformProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("transformForSourceImage:handle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSScaleTransform GetTransform(MPSImage image, IMPSHandle? handle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		Messaging.MPSScaleTransform_objc_msgSend_stret_IntPtr_IntPtr(out var retval, base.Handle, Selector.GetHandle("transformForSourceImage:handle:"), image.Handle, handle?.Handle ?? IntPtr.Zero);
		return retval;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("encodeWithCoder:"), encoder.Handle);
	}
}
