using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CIColorCubeWithColorSpace : CIColorCube, ICIColorCubeWithColorSpaceProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
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
	public new float CubeDimension
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
	public new NSData CubeData
	{
		[Export("cubeData", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<NSData>(GetHandle("inputCubeData"), owns: false);
		}
		[Export("setCubeData:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCubeData", value);
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
	public CIColorCubeWithColorSpace()
		: base("CIColorCubeWithColorSpace")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorCubeWithColorSpace(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorCubeWithColorSpace(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColorCubeWithColorSpace(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
