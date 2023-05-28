using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CITextImageGeneratorProtocolWrapper : BaseWrapper, ICITextImageGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Text
	{
		[Export("text", ArgumentSemantic.Retain)]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("text")));
		}
		[Export("setText:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setText:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string FontName
	{
		[Export("fontName", ArgumentSemantic.Retain)]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("fontName")));
		}
		[Export("setFontName:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setFontName:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float FontSize
	{
		[Export("fontSize")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("fontSize"));
		}
		[Export("setFontSize:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setFontSize:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("scaleFactor"));
		}
		[Export("setScaleFactor:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setScaleFactor:"), value);
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
	public CITextImageGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
