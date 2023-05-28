using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CIQRCodeGenerator : CICodeGenerator, ICIQRCodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImage => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImage"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<NSData>(GetHandle("inputMessage"), owns: false);
		}
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputMessage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string CorrectionLevel
	{
		[Export("correctionLevel", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputCorrectionLevel") as NSString;
		}
		[Export("setCorrectionLevel:", ArgumentSemantic.Retain)]
		set
		{
			using NSString value2 = new NSString(value);
			SetValue("inputCorrectionLevel", value2);
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
	public CIQRCodeGenerator()
		: base("CIQRCodeGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIQRCodeGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIQRCodeGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIQRCodeGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
