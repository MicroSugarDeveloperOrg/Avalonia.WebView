using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CIAztecCodeGenerator : CICodeGenerator, ICIAztecCodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputCompactStyle' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CompactStyle
	{
		get
		{
			return GetBool("inputCompactStyle");
		}
		set
		{
			SetBool("inputCompactStyle", value);
		}
	}

	[Obsolete("Use 'InputLayers' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public int Layers
	{
		get
		{
			return GetInt("inputLayers");
		}
		set
		{
			SetInt("inputLayers", value);
		}
	}

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
	public float CorrectionLevel
	{
		[Export("correctionLevel")]
		get
		{
			return GetFloat("inputCorrectionLevel");
		}
		[Export("setCorrectionLevel:")]
		set
		{
			SetFloat("inputCorrectionLevel", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputLayers
	{
		[Export("layers")]
		get
		{
			return GetFloat("inputLayers");
		}
		[Export("setLayers:")]
		set
		{
			SetFloat("inputLayers", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactStyle
	{
		[Export("compactStyle")]
		get
		{
			return GetFloat("inputCompactStyle");
		}
		[Export("setCompactStyle:")]
		set
		{
			SetFloat("inputCompactStyle", value);
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
	public CIAztecCodeGenerator()
		: base("CIAztecCodeGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIAztecCodeGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIAztecCodeGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIAztecCodeGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
