using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CILenticularHaloGenerator : CIFilter, ICILenticularHaloGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
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
	public CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor") as CIColor;
		}
		[Export("setColor:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float HaloRadius
	{
		[Export("haloRadius")]
		get
		{
			return GetFloat("inputHaloRadius");
		}
		[Export("setHaloRadius:")]
		set
		{
			SetFloat("inputHaloRadius", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float HaloWidth
	{
		[Export("haloWidth")]
		get
		{
			return GetFloat("inputHaloWidth");
		}
		[Export("setHaloWidth:")]
		set
		{
			SetFloat("inputHaloWidth", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float HaloOverlap
	{
		[Export("haloOverlap")]
		get
		{
			return GetFloat("inputHaloOverlap");
		}
		[Export("setHaloOverlap:")]
		set
		{
			SetFloat("inputHaloOverlap", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationStrength
	{
		[Export("striationStrength")]
		get
		{
			return GetFloat("inputStriationStrength");
		}
		[Export("setStriationStrength:")]
		set
		{
			SetFloat("inputStriationStrength", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationContrast
	{
		[Export("striationContrast")]
		get
		{
			return GetFloat("inputStriationContrast");
		}
		[Export("setStriationContrast:")]
		set
		{
			SetFloat("inputStriationContrast", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Time
	{
		[Export("time")]
		get
		{
			return GetFloat("inputTime");
		}
		[Export("setTime:")]
		set
		{
			SetFloat("inputTime", value);
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
	public CILenticularHaloGenerator()
		: base("CILenticularHaloGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CILenticularHaloGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CILenticularHaloGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CILenticularHaloGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
