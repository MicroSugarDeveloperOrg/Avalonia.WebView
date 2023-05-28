using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIDisintegrateWithMaskTransition : CITransitionFilter, ICIDisintegrateWithMaskTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'MaskImage' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? Mask
	{
		get
		{
			return ValueForKey("inputMaskImage") as CIImage;
		}
		set
		{
			SetValue("inputMaskImage", value);
		}
	}

	[Obsolete("Use 'InputShadowOffset' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? ShadowOffset
	{
		get
		{
			return ValueForKey("inputShadowOffset") as CIVector;
		}
		set
		{
			SetValue("inputShadowOffset", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputMaskImage") as CIImage;
		}
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputMaskImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowRadius
	{
		[Export("shadowRadius")]
		get
		{
			return GetFloat("inputShadowRadius");
		}
		[Export("setShadowRadius:")]
		set
		{
			SetFloat("inputShadowRadius", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowDensity
	{
		[Export("shadowDensity")]
		get
		{
			return GetFloat("inputShadowDensity");
		}
		[Export("setShadowDensity:")]
		set
		{
			SetFloat("inputShadowDensity", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputShadowOffset
	{
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputShadowOffset");
		}
		[Export("setShadowOffset:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputShadowOffset", value);
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
	public CIDisintegrateWithMaskTransition()
		: base("CIDisintegrateWithMaskTransition")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIDisintegrateWithMaskTransition(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIDisintegrateWithMaskTransition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIDisintegrateWithMaskTransition(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
