using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIToneCurve : CIFilter, ICIToneCurveProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputPoint0' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point0
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

	[Obsolete("Use 'InputPoint1' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point1
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

	[Obsolete("Use 'InputPoint2' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point2
	{
		get
		{
			return ValueForKey("inputPoint2") as CIVector;
		}
		set
		{
			SetValue("inputPoint2", value);
		}
	}

	[Obsolete("Use 'InputPoint3' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point3
	{
		get
		{
			return ValueForKey("inputPoint3") as CIVector;
		}
		set
		{
			SetValue("inputPoint3", value);
		}
	}

	[Obsolete("Use 'InputPoint4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Point4
	{
		get
		{
			return ValueForKey("inputPoint4") as CIVector;
		}
		set
		{
			SetValue("inputPoint4", value);
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
	public CGPoint InputPoint0
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
	public CGPoint InputPoint1
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
	public CGPoint InputPoint2
	{
		[Export("point2", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint2");
		}
		[Export("setPoint2:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint2", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputPoint3
	{
		[Export("point3", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint3");
		}
		[Export("setPoint3:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint3", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputPoint4
	{
		[Export("point4", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputPoint4");
		}
		[Export("setPoint4:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputPoint4", value);
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
	public CIToneCurve()
		: base("CIToneCurve")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIToneCurve(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIToneCurve(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIToneCurve(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
