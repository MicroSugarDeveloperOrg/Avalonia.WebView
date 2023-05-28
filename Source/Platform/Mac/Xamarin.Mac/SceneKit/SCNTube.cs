using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNTube", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNTube : SCNGeometry
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightSegmentCount = "heightSegmentCount";

	private static readonly IntPtr selHeightSegmentCountHandle = Selector.GetHandle("heightSegmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInnerRadius = "innerRadius";

	private static readonly IntPtr selInnerRadiusHandle = Selector.GetHandle("innerRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOuterRadius = "outerRadius";

	private static readonly IntPtr selOuterRadiusHandle = Selector.GetHandle("outerRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadialSegmentCount = "radialSegmentCount";

	private static readonly IntPtr selRadialSegmentCountHandle = Selector.GetHandle("radialSegmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeight_ = "setHeight:";

	private static readonly IntPtr selSetHeight_Handle = Selector.GetHandle("setHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeightSegmentCount_ = "setHeightSegmentCount:";

	private static readonly IntPtr selSetHeightSegmentCount_Handle = Selector.GetHandle("setHeightSegmentCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInnerRadius_ = "setInnerRadius:";

	private static readonly IntPtr selSetInnerRadius_Handle = Selector.GetHandle("setInnerRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOuterRadius_ = "setOuterRadius:";

	private static readonly IntPtr selSetOuterRadius_Handle = Selector.GetHandle("setOuterRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRadialSegmentCount_ = "setRadialSegmentCount:";

	private static readonly IntPtr selSetRadialSegmentCount_Handle = Selector.GetHandle("setRadialSegmentCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTubeWithInnerRadius_OuterRadius_Height_ = "tubeWithInnerRadius:outerRadius:height:";

	private static readonly IntPtr selTubeWithInnerRadius_OuterRadius_Height_Handle = Selector.GetHandle("tubeWithInnerRadius:outerRadius:height:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNTube");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Height
	{
		[Export("height")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHeightHandle);
		}
		[Export("setHeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HeightSegmentCount
	{
		[Export("heightSegmentCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHeightSegmentCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHeightSegmentCountHandle);
		}
		[Export("setHeightSegmentCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHeightSegmentCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHeightSegmentCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat InnerRadius
	{
		[Export("innerRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selInnerRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selInnerRadiusHandle);
		}
		[Export("setInnerRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInnerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInnerRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat OuterRadius
	{
		[Export("outerRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selOuterRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selOuterRadiusHandle);
		}
		[Export("setOuterRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetOuterRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetOuterRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RadialSegmentCount
	{
		[Export("radialSegmentCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRadialSegmentCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRadialSegmentCountHandle);
		}
		[Export("setRadialSegmentCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetRadialSegmentCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetRadialSegmentCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNTube()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNTube(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNTube(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNTube(IntPtr handle)
		: base(handle)
	{
	}

	[Export("tubeWithInnerRadius:outerRadius:height:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNTube Create(nfloat innerRadius, nfloat outerRadius, nfloat height)
	{
		return Runtime.GetNSObject<SCNTube>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(class_ptr, selTubeWithInnerRadius_OuterRadius_Height_Handle, innerRadius, outerRadius, height));
	}
}
