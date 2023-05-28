using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIStarShineGenerator : CIFilter, ICIStarShineGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public float CrossScale
	{
		[Export("crossScale")]
		get
		{
			return GetFloat("inputCrossScale");
		}
		[Export("setCrossScale:")]
		set
		{
			SetFloat("inputCrossScale", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossAngle
	{
		[Export("crossAngle")]
		get
		{
			return GetFloat("inputCrossAngle");
		}
		[Export("setCrossAngle:")]
		set
		{
			SetFloat("inputCrossAngle", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossOpacity
	{
		[Export("crossOpacity")]
		get
		{
			return GetFloat("inputCrossOpacity");
		}
		[Export("setCrossOpacity:")]
		set
		{
			SetFloat("inputCrossOpacity", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossWidth
	{
		[Export("crossWidth")]
		get
		{
			return GetFloat("inputCrossWidth");
		}
		[Export("setCrossWidth:")]
		set
		{
			SetFloat("inputCrossWidth", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Epsilon
	{
		[Export("epsilon")]
		get
		{
			return GetFloat("inputEpsilon");
		}
		[Export("setEpsilon:")]
		set
		{
			SetFloat("inputEpsilon", value);
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
	public CIStarShineGenerator()
		: base("CIStarShineGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIStarShineGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIStarShineGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIStarShineGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
