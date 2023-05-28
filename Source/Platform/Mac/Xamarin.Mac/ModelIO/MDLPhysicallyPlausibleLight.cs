using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLPhysicallyPlausibleLight", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLPhysicallyPlausibleLight : MDLLight
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttenuationEndDistance = "attenuationEndDistance";

	private static readonly IntPtr selAttenuationEndDistanceHandle = Selector.GetHandle("attenuationEndDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttenuationStartDistance = "attenuationStartDistance";

	private static readonly IntPtr selAttenuationStartDistanceHandle = Selector.GetHandle("attenuationStartDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInnerConeAngle = "innerConeAngle";

	private static readonly IntPtr selInnerConeAngleHandle = Selector.GetHandle("innerConeAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLumens = "lumens";

	private static readonly IntPtr selLumensHandle = Selector.GetHandle("lumens");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOuterConeAngle = "outerConeAngle";

	private static readonly IntPtr selOuterConeAngleHandle = Selector.GetHandle("outerConeAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttenuationEndDistance_ = "setAttenuationEndDistance:";

	private static readonly IntPtr selSetAttenuationEndDistance_Handle = Selector.GetHandle("setAttenuationEndDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttenuationStartDistance_ = "setAttenuationStartDistance:";

	private static readonly IntPtr selSetAttenuationStartDistance_Handle = Selector.GetHandle("setAttenuationStartDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorByTemperature_ = "setColorByTemperature:";

	private static readonly IntPtr selSetColorByTemperature_Handle = Selector.GetHandle("setColorByTemperature:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInnerConeAngle_ = "setInnerConeAngle:";

	private static readonly IntPtr selSetInnerConeAngle_Handle = Selector.GetHandle("setInnerConeAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLumens_ = "setLumens:";

	private static readonly IntPtr selSetLumens_Handle = Selector.GetHandle("setLumens:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOuterConeAngle_ = "setOuterConeAngle:";

	private static readonly IntPtr selSetOuterConeAngle_Handle = Selector.GetHandle("setOuterConeAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLPhysicallyPlausibleLight");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AttenuationEndDistance
	{
		[Export("attenuationEndDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAttenuationEndDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAttenuationEndDistanceHandle);
		}
		[Export("setAttenuationEndDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAttenuationEndDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAttenuationEndDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AttenuationStartDistance
	{
		[Export("attenuationStartDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAttenuationStartDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAttenuationStartDistanceHandle);
		}
		[Export("setAttenuationStartDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAttenuationStartDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAttenuationStartDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? Color
	{
		[Export("color", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InnerConeAngle
	{
		[Export("innerConeAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInnerConeAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInnerConeAngleHandle);
		}
		[Export("setInnerConeAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInnerConeAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInnerConeAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Lumens
	{
		[Export("lumens")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLumensHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLumensHandle);
		}
		[Export("setLumens:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLumens_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLumens_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float OuterConeAngle
	{
		[Export("outerConeAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOuterConeAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOuterConeAngleHandle);
		}
		[Export("setOuterConeAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOuterConeAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOuterConeAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLPhysicallyPlausibleLight()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLPhysicallyPlausibleLight(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLPhysicallyPlausibleLight(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setColorByTemperature:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetColor(float temperature)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selSetColorByTemperature_Handle, temperature);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetColorByTemperature_Handle, temperature);
		}
	}
}
