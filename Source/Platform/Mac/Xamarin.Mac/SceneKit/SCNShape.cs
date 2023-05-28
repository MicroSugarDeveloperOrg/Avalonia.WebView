using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNShape", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNShape : SCNGeometry
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChamferMode = "chamferMode";

	private static readonly IntPtr selChamferModeHandle = Selector.GetHandle("chamferMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChamferProfile = "chamferProfile";

	private static readonly IntPtr selChamferProfileHandle = Selector.GetHandle("chamferProfile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChamferRadius = "chamferRadius";

	private static readonly IntPtr selChamferRadiusHandle = Selector.GetHandle("chamferRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtrusionDepth = "extrusionDepth";

	private static readonly IntPtr selExtrusionDepthHandle = Selector.GetHandle("extrusionDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChamferMode_ = "setChamferMode:";

	private static readonly IntPtr selSetChamferMode_Handle = Selector.GetHandle("setChamferMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChamferProfile_ = "setChamferProfile:";

	private static readonly IntPtr selSetChamferProfile_Handle = Selector.GetHandle("setChamferProfile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChamferRadius_ = "setChamferRadius:";

	private static readonly IntPtr selSetChamferRadius_Handle = Selector.GetHandle("setChamferRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtrusionDepth_ = "setExtrusionDepth:";

	private static readonly IntPtr selSetExtrusionDepth_Handle = Selector.GetHandle("setExtrusionDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeWithPath_ExtrusionDepth_ = "shapeWithPath:extrusionDepth:";

	private static readonly IntPtr selShapeWithPath_ExtrusionDepth_Handle = Selector.GetHandle("shapeWithPath:extrusionDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNShape");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNChamferMode ChamferMode
	{
		[Export("chamferMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNChamferMode)Messaging.Int64_objc_msgSend(base.Handle, selChamferModeHandle);
			}
			return (SCNChamferMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChamferModeHandle);
		}
		[Export("setChamferMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetChamferMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetChamferMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPath? ChamferProfile
	{
		[Export("chamferProfile", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selChamferProfileHandle));
			}
			return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChamferProfileHandle));
		}
		[Export("setChamferProfile:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChamferProfile_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChamferProfile_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ChamferRadius
	{
		[Export("chamferRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selChamferRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selChamferRadiusHandle);
		}
		[Export("setChamferRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetChamferRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetChamferRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ExtrusionDepth
	{
		[Export("extrusionDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selExtrusionDepthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selExtrusionDepthHandle);
		}
		[Export("setExtrusionDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetExtrusionDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetExtrusionDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPath? Path
	{
		[Export("path", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
		[Export("setPath:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNShape()
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
	public SCNShape(NSCoder coder)
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
	protected SCNShape(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNShape(IntPtr handle)
		: base(handle)
	{
	}

	[Export("shapeWithPath:extrusionDepth:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNShape Create(NSBezierPath path, nfloat extrusionDepth)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SCNShape>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selShapeWithPath_ExtrusionDepth_Handle, path.Handle, extrusionDepth));
	}
}
