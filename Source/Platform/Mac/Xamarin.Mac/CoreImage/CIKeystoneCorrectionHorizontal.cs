using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class CIKeystoneCorrectionHorizontal : CIKeystoneCorrection, ICIKeystoneCorrectionHorizontalProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICIFourCoordinateGeometryFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGAffineTransform OutputTransform
	{
		get
		{
			NSObject nSObject = ValueForKey("outputTransform");
			if (nSObject is NSValue nSValue)
			{
				return nSValue.CGAffineTransformValue;
			}
			return CGAffineTransform.MakeIdentity();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new float FocalLength
	{
		[Export("focalLength")]
		get
		{
			return GetFloat("inputFocalLength");
		}
		[Export("setFocalLength:")]
		set
		{
			SetFloat("inputFocalLength", value);
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
	public new CGPoint InputTopLeft
	{
		[Export("topLeft", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputTopLeft");
		}
		[Export("setTopLeft:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputTopLeft", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CGPoint InputTopRight
	{
		[Export("topRight", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputTopRight");
		}
		[Export("setTopRight:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputTopRight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CGPoint InputBottomRight
	{
		[Export("bottomRight", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputBottomRight");
		}
		[Export("setBottomRight:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputBottomRight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CGPoint InputBottomLeft
	{
		[Export("bottomLeft", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputBottomLeft");
		}
		[Export("setBottomLeft:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputBottomLeft", value);
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
	public CIKeystoneCorrectionHorizontal()
		: base("CIKeystoneCorrectionHorizontal")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIKeystoneCorrectionHorizontal(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIKeystoneCorrectionHorizontal(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIKeystoneCorrectionHorizontal(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
