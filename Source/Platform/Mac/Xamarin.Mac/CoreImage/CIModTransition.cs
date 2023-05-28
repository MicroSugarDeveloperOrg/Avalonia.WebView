using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIModTransition : CITransitionFilter, ICIModTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
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
	public float Compression
	{
		[Export("compression")]
		get
		{
			return GetFloat("inputCompression");
		}
		[Export("setCompression:")]
		set
		{
			SetFloat("inputCompression", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIImage? InputImage
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
	public new CIImage? TargetImage
	{
		[Export("targetImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputTargetImage") as CIImage;
		}
		[Export("setTargetImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputTargetImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new float Time
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
	public CIModTransition()
		: base("CIModTransition")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIModTransition(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIModTransition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIModTransition(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
