using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIBarcodeGenerator : CIFilter, ICIBarcodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImageForQRCodeDescriptor => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImageForQRCodeDescriptor"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImageForPdf417CodeDescriptor => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImageForPDF417CodeDescriptor"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImageForDataMatrixCodeDescriptor => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImageForDataMatrixCodeDescriptor"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImageForAztecCodeDescriptor => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImageForAztecCodeDescriptor"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImage => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImage"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBarcodeDescriptor BarcodeDescriptor
	{
		[Export("barcodeDescriptor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<CIBarcodeDescriptor>(GetHandle("inputBarcodeDescriptor"), owns: false);
		}
		[Export("setBarcodeDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			SetHandle("inputBarcodeDescriptor", value.GetHandle());
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return ValueForKey("outputImage") as CIImage;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBarcodeGenerator()
		: base("CIBarcodeGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBarcodeGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIBarcodeGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIBarcodeGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
