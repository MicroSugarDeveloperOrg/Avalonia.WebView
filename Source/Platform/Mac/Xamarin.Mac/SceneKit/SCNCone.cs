using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNCone", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNCone : SCNGeometry
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomRadius = "bottomRadius";

	private static readonly IntPtr selBottomRadiusHandle = Selector.GetHandle("bottomRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConeWithTopRadius_BottomRadius_Height_ = "coneWithTopRadius:bottomRadius:height:";

	private static readonly IntPtr selConeWithTopRadius_BottomRadius_Height_Handle = Selector.GetHandle("coneWithTopRadius:bottomRadius:height:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightSegmentCount = "heightSegmentCount";

	private static readonly IntPtr selHeightSegmentCountHandle = Selector.GetHandle("heightSegmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadialSegmentCount = "radialSegmentCount";

	private static readonly IntPtr selRadialSegmentCountHandle = Selector.GetHandle("radialSegmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBottomRadius_ = "setBottomRadius:";

	private static readonly IntPtr selSetBottomRadius_Handle = Selector.GetHandle("setBottomRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeight_ = "setHeight:";

	private static readonly IntPtr selSetHeight_Handle = Selector.GetHandle("setHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeightSegmentCount_ = "setHeightSegmentCount:";

	private static readonly IntPtr selSetHeightSegmentCount_Handle = Selector.GetHandle("setHeightSegmentCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRadialSegmentCount_ = "setRadialSegmentCount:";

	private static readonly IntPtr selSetRadialSegmentCount_Handle = Selector.GetHandle("setRadialSegmentCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTopRadius_ = "setTopRadius:";

	private static readonly IntPtr selSetTopRadius_Handle = Selector.GetHandle("setTopRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopRadius = "topRadius";

	private static readonly IntPtr selTopRadiusHandle = Selector.GetHandle("topRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNCone");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BottomRadius
	{
		[Export("bottomRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBottomRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBottomRadiusHandle);
		}
		[Export("setBottomRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBottomRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBottomRadius_Handle, value);
			}
		}
	}

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
	public virtual nfloat TopRadius
	{
		[Export("topRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTopRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTopRadiusHandle);
		}
		[Export("setTopRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTopRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTopRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNCone()
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
	public SCNCone(NSCoder coder)
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
	protected SCNCone(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNCone(IntPtr handle)
		: base(handle)
	{
	}

	[Export("coneWithTopRadius:bottomRadius:height:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNCone Create(nfloat topRadius, nfloat bottomRadius, nfloat height)
	{
		return Runtime.GetNSObject<SCNCone>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(class_ptr, selConeWithTopRadius_BottomRadius_Height_Handle, topRadius, bottomRadius, height));
	}
}
