using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CIColorPolynomial : CIColorCrossPolynomial, ICIColorPolynomialProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public new CIVector RedCoefficients
	{
		[Export("redCoefficients", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputRedCoefficients") as CIVector;
		}
		[Export("setRedCoefficients:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputRedCoefficients", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIVector GreenCoefficients
	{
		[Export("greenCoefficients", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputGreenCoefficients") as CIVector;
		}
		[Export("setGreenCoefficients:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputGreenCoefficients", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIVector BlueCoefficients
	{
		[Export("blueCoefficients", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputBlueCoefficients") as CIVector;
		}
		[Export("setBlueCoefficients:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputBlueCoefficients", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector AlphaCoefficients
	{
		[Export("alphaCoefficients", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputAlphaCoefficients") as CIVector;
		}
		[Export("setAlphaCoefficients:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputAlphaCoefficients", value);
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
	public CIColorPolynomial()
		: base("CIColorPolynomial")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorPolynomial(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorPolynomial(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColorPolynomial(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
