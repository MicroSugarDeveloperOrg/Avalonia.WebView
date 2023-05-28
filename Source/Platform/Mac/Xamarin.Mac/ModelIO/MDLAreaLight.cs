using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLAreaLight", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLAreaLight : MDLPhysicallyPlausibleLight
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreaRadius = "areaRadius";

	private static readonly IntPtr selAreaRadiusHandle = Selector.GetHandle("areaRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAspect = "aspect";

	private static readonly IntPtr selAspectHandle = Selector.GetHandle("aspect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAreaRadius_ = "setAreaRadius:";

	private static readonly IntPtr selSetAreaRadius_Handle = Selector.GetHandle("setAreaRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAspect_ = "setAspect:";

	private static readonly IntPtr selSetAspect_Handle = Selector.GetHandle("setAspect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuperEllipticPower_ = "setSuperEllipticPower:";

	private static readonly IntPtr selSetSuperEllipticPower_Handle = Selector.GetHandle("setSuperEllipticPower:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperEllipticPower = "superEllipticPower";

	private static readonly IntPtr selSuperEllipticPowerHandle = Selector.GetHandle("superEllipticPower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAreaLight");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AreaRadius
	{
		[Export("areaRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAreaRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAreaRadiusHandle);
		}
		[Export("setAreaRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAreaRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAreaRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Aspect
	{
		[Export("aspect")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAspectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAspectHandle);
		}
		[Export("setAspect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAspect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAspect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 SuperEllipticPower
	{
		[Export("superEllipticPower", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selSuperEllipticPowerHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selSuperEllipticPowerHandle);
		}
		[Export("setSuperEllipticPower:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetSuperEllipticPower_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetSuperEllipticPower_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLAreaLight(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAreaLight(IntPtr handle)
		: base(handle)
	{
	}
}
