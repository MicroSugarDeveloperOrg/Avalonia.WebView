using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CISmoothLinearGradient : CILinearGradient, ICISmoothLinearGradientProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputPoint1' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIVector? Point1
	{
		get
		{
			return ValueForKey("inputPoint1") as CIVector;
		}
		set
		{
			SetValue("inputPoint1", value);
		}
	}

	[Obsolete("Use 'InputPoint0' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIVector? Point0
	{
		get
		{
			return ValueForKey("inputPoint0") as CIVector;
		}
		set
		{
			SetValue("inputPoint0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CGPoint InputPoint0
	{
		[Export("point0", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint0");
		}
		[Export("setPoint0:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CGPoint InputPoint1
	{
		[Export("point1", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint1");
		}
		[Export("setPoint1:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIColor Color0
	{
		[Export("color0", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor0") as CIColor;
		}
		[Export("setColor0:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor0", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIColor Color1
	{
		[Export("color1", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor1") as CIColor;
		}
		[Export("setColor1:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor1", value);
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
	public CISmoothLinearGradient()
		: base("CISmoothLinearGradient")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CISmoothLinearGradient(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CISmoothLinearGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CISmoothLinearGradient(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
