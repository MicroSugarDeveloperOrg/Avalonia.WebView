using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIColorCubesMixedWithMask : CIFilter, ICIColorCubesMixedWithMaskProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
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
	public float CubeDimension
	{
		[Export("cubeDimension")]
		get
		{
			return GetFloat("inputCubeDimension");
		}
		[Export("setCubeDimension:")]
		set
		{
			SetFloat("inputCubeDimension", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData Cube0Data
	{
		[Export("cube0Data", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<NSData>(GetHandle("inputCube0Data"), owns: false);
		}
		[Export("setCube0Data:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCube0Data", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData Cube1Data
	{
		[Export("cube1Data", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<NSData>(GetHandle("inputCube1Data"), owns: false);
		}
		[Export("setCube1Data:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCube1Data", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGColorSpace? ColorSpace
	{
		[Export("colorSpace", ArgumentSemantic.Assign)]
		get
		{
			return Runtime.GetINativeObject<CGColorSpace>(GetHandle("inputColorSpace"), owns: false);
		}
		[Export("setColorSpace:", ArgumentSemantic.Assign)]
		set
		{
			SetHandle("inputColorSpace", value.GetHandle());
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
	public CIColorCubesMixedWithMask()
		: base("CIColorCubesMixedWithMask")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorCubesMixedWithMask(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorCubesMixedWithMask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColorCubesMixedWithMask(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
