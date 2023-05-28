using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIPerspectiveTile : CIFilter, ICIPerspectiveTileProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputBottomLeft' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? BottomLeft
	{
		get
		{
			return ValueForKey("inputBottomLeft") as CIVector;
		}
		set
		{
			SetValue("inputBottomLeft", value);
		}
	}

	[Obsolete("Use 'InputTopRight' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? TopRight
	{
		get
		{
			return ValueForKey("inputTopRight") as CIVector;
		}
		set
		{
			SetValue("inputTopRight", value);
		}
	}

	[Obsolete("Use 'InputTopLeft' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? TopLeft
	{
		get
		{
			return ValueForKey("inputTopLeft") as CIVector;
		}
		set
		{
			SetValue("inputTopLeft", value);
		}
	}

	[Obsolete("Use 'InputBottomRight' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? BottomRight
	{
		get
		{
			return ValueForKey("inputBottomRight") as CIVector;
		}
		set
		{
			SetValue("inputBottomRight", value);
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
	public CGPoint InputTopLeft
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
	public CGPoint InputTopRight
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
	public CGPoint InputBottomRight
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
	public CGPoint InputBottomLeft
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
	public CIPerspectiveTile()
		: base("CIPerspectiveTile")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIPerspectiveTile(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIPerspectiveTile(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIPerspectiveTile(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
