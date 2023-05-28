using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CITextImageGenerator : CIImageGenerator, ICITextImageGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Text
	{
		[Export("text", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputText") as NSString;
		}
		[Export("setText:", ArgumentSemantic.Retain)]
		set
		{
			using NSString value2 = new NSString(value);
			SetValue("inputText", value2);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string FontName
	{
		[Export("fontName", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputFontName") as NSString;
		}
		[Export("setFontName:", ArgumentSemantic.Retain)]
		set
		{
			using NSString value2 = new NSString(value);
			SetValue("inputFontName", value2);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float FontSize
	{
		[Export("fontSize")]
		get
		{
			return GetFloat("inputFontSize");
		}
		[Export("setFontSize:")]
		set
		{
			SetFloat("inputFontSize", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new float ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			return GetFloat("inputScaleFactor");
		}
		[Export("setScaleFactor:")]
		set
		{
			SetFloat("inputScaleFactor", value);
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
	public CITextImageGenerator()
		: base("CITextImageGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CITextImageGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CITextImageGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CITextImageGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
