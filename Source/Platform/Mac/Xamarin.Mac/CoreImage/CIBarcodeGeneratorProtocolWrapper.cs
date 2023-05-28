using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIBarcodeGeneratorProtocolWrapper : BaseWrapper, ICIBarcodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBarcodeDescriptor BarcodeDescriptor
	{
		[Export("barcodeDescriptor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBarcodeDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("barcodeDescriptor")));
		}
		[Export("setBarcodeDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setBarcodeDescriptor:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("outputImage")));
		}
	}

	[Preserve(Conditional = true)]
	public CIBarcodeGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
