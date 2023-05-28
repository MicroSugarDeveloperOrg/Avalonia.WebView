using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIRadialGradient : CIFilter, ICIRadialGradientProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public float Radius0
	{
		[Export("radius0")]
		get
		{
			return GetFloat("inputRadius0");
		}
		[Export("setRadius0:")]
		set
		{
			SetFloat("inputRadius0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Radius1
	{
		[Export("radius1")]
		get
		{
			return GetFloat("inputRadius1");
		}
		[Export("setRadius1:")]
		set
		{
			SetFloat("inputRadius1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor Color0
	{
		[Export("color0", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor0") as CIColor;
		}
		[Export("setColor0:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor Color1
	{
		[Export("color1", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor1") as CIColor;
		}
		[Export("setColor1:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor1", value);
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
	public CIRadialGradient()
		: base("CIRadialGradient")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRadialGradient(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIRadialGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIRadialGradient(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
