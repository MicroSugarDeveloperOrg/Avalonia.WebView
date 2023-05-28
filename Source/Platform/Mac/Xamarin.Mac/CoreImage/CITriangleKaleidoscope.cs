using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CITriangleKaleidoscope : CIFilter, ICITriangleKaleidoscopeProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputPoint' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point
	{
		get
		{
			return ValueForKey("inputPoint") as CIVector;
		}
		set
		{
			SetValue("inputPoint", value);
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
	public CGPoint InputPoint
	{
		[Export("point", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint");
		}
		[Export("setPoint:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Size
	{
		[Export("size")]
		get
		{
			return GetFloat("inputSize");
		}
		[Export("setSize:")]
		set
		{
			SetFloat("inputSize", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Rotation
	{
		[Export("rotation")]
		get
		{
			return GetFloat("inputRotation");
		}
		[Export("setRotation:")]
		set
		{
			SetFloat("inputRotation", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Decay
	{
		[Export("decay")]
		get
		{
			return GetFloat("inputDecay");
		}
		[Export("setDecay:")]
		set
		{
			SetFloat("inputDecay", value);
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
	public CITriangleKaleidoscope()
		: base("CITriangleKaleidoscope")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CITriangleKaleidoscope(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CITriangleKaleidoscope(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CITriangleKaleidoscope(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
