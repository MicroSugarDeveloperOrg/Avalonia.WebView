using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Obsolete("This type has been renamed to CICmykHalftone.")]
public class CICMYKHalftone : CICmykHalftone
{
	public CICMYKHalftone()
	{
	}

	public CICMYKHalftone(IntPtr handle)
		: base(handle)
	{
	}
}
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CICmykHalftone : CIFilter, ICICmykHalftoneProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'Sharpness' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputSharpness
	{
		get
		{
			return GetFloat("inputSharpness");
		}
		set
		{
			SetFloat("inputSharpness", value);
		}
	}

	[Obsolete("Use 'InputCenter' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Center
	{
		get
		{
			return ValueForKey("inputCenter") as CIVector;
		}
		set
		{
			SetValue("inputCenter", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputImage") as CIImage;
		}
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputCenter");
		}
		[Export("setCenter:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputCenter", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Width
	{
		[Export("width")]
		get
		{
			return GetFloat("inputWidth");
		}
		[Export("setWidth:")]
		set
		{
			SetFloat("inputWidth", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Angle
	{
		[Export("angle")]
		get
		{
			return GetFloat("inputAngle");
		}
		[Export("setAngle:")]
		set
		{
			SetFloat("inputAngle", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Sharpness
	{
		[Export("sharpness")]
		get
		{
			return GetFloat("inputSharpness");
		}
		[Export("setSharpness:")]
		set
		{
			SetFloat("inputSharpness", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float GrayComponentReplacement
	{
		[Export("grayComponentReplacement")]
		get
		{
			return GetFloat("inputGCR");
		}
		[Export("setGrayComponentReplacement:")]
		set
		{
			SetFloat("inputGCR", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float UnderColorRemoval
	{
		[Export("underColorRemoval")]
		get
		{
			return GetFloat("inputUCR");
		}
		[Export("setUnderColorRemoval:")]
		set
		{
			SetFloat("inputUCR", value);
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
	public CICmykHalftone()
		: base("CICMYKHalftone")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CICmykHalftone(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CICmykHalftone(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CICmykHalftone(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
