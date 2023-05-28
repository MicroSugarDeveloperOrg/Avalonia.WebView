using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIColorMatrix : CIFilter, ICIColorMatrixProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public CIVector RVector
	{
		[Export("RVector", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputRVector") as CIVector;
		}
		[Export("setRVector:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputRVector", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector GVector
	{
		[Export("GVector", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputGVector") as CIVector;
		}
		[Export("setGVector:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputGVector", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector BVector
	{
		[Export("BVector", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputBVector") as CIVector;
		}
		[Export("setBVector:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputBVector", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector AVector
	{
		[Export("AVector", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputAVector") as CIVector;
		}
		[Export("setAVector:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputAVector", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector BiasVector
	{
		[Export("biasVector", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputBiasVector") as CIVector;
		}
		[Export("setBiasVector:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputBiasVector", value);
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
	public CIColorMatrix()
		: base("CIColorMatrix")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorMatrix(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorMatrix(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColorMatrix(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
