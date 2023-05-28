using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSNNPaddingWrapper : BaseWrapper, IMPSNNPadding, INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPaddingMethod PaddingMethod
	{
		[Export("paddingMethod")]
		get
		{
			return (MPSNNPaddingMethod)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("paddingMethod"));
		}
	}

	[Preserve(Conditional = true)]
	public MPSNNPaddingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
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
