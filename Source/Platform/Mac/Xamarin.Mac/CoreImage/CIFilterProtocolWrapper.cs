using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIFilterProtocolWrapper : BaseWrapper, ICIFilterProtocol, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("outputImage")));
		}
	}

	[Preserve(Conditional = true)]
	public CIFilterProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
