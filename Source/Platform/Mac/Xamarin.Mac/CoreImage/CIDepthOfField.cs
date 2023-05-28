using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CIDepthOfField : CIFilter, ICIDepthOfFieldProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputPoint0' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point1
	{
		get
		{
			return ValueForKey("inputPoint0") as CIVector;
		}
		set
		{
			SetValue("inputPoint0", value);
		}
	}

	[Obsolete("Use 'InputPoint1' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point2
	{
		get
		{
			return ValueForKey("inputPoint1") as CIVector;
		}
		set
		{
			SetValue("inputPoint1", value);
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
	public CGPoint InputPoint0
	{
		[Export("point0", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint0");
		}
		[Export("setPoint0:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputPoint1
	{
		[Export("point1", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint1");
		}
		[Export("setPoint1:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Saturation
	{
		[Export("saturation")]
		get
		{
			return GetFloat("inputSaturation");
		}
		[Export("setSaturation:")]
		set
		{
			SetFloat("inputSaturation", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float UnsharpMaskRadius
	{
		[Export("unsharpMaskRadius")]
		get
		{
			return GetFloat("inputUnsharpMaskRadius");
		}
		[Export("setUnsharpMaskRadius:")]
		set
		{
			SetFloat("inputUnsharpMaskRadius", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float UnsharpMaskIntensity
	{
		[Export("unsharpMaskIntensity")]
		get
		{
			return GetFloat("inputUnsharpMaskIntensity");
		}
		[Export("setUnsharpMaskIntensity:")]
		set
		{
			SetFloat("inputUnsharpMaskIntensity", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Radius
	{
		[Export("radius")]
		get
		{
			return GetFloat("inputRadius");
		}
		[Export("setRadius:")]
		set
		{
			SetFloat("inputRadius", value);
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
	public CIDepthOfField()
		: base("CIDepthOfField")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIDepthOfField(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIDepthOfField(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIDepthOfField(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
