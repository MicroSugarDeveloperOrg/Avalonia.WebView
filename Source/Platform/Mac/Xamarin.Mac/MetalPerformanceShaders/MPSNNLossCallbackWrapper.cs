using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSNNLossCallbackWrapper : BaseWrapper, IMPSNNLossCallback, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[Preserve(Conditional = true)]
	public MPSNNLossCallbackWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("scalarWeightForSourceImage:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float GetScalarWeight(MPSImage sourceImage, MPSImage destinationImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		return Messaging.float_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("scalarWeightForSourceImage:destinationImage:"), sourceImage.Handle, destinationImage.Handle);
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

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
