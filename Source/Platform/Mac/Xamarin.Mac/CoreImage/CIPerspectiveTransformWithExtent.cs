using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CIPerspectiveTransformWithExtent : CIPerspectiveTransform, ICIPerspectiveTransformWithExtentProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICIFourCoordinateGeometryFilterProtocol
{
	[Obsolete("Use 'InputExtent' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Extent
	{
		get
		{
			return ValueForKey("inputExtent") as CIVector;
		}
		set
		{
			SetValue("inputExtent", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect InputExtent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get
		{
			return GetRect("inputExtent");
		}
		[Export("setExtent:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputExtent", value);
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
	public CIPerspectiveTransformWithExtent()
		: base("CIPerspectiveTransformWithExtent")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIPerspectiveTransformWithExtent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIPerspectiveTransformWithExtent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIPerspectiveTransformWithExtent(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
