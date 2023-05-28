using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNCameraControlConfigurationWrapper : BaseWrapper, ISCNCameraControlConfiguration, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AutoSwitchToFreeCamera
	{
		[Export("autoSwitchToFreeCamera")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("autoSwitchToFreeCamera"));
		}
		[Export("setAutoSwitchToFreeCamera:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAutoSwitchToFreeCamera:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AllowsTranslation
	{
		[Export("allowsTranslation")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("allowsTranslation"));
		}
		[Export("setAllowsTranslation:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAllowsTranslation:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat FlyModeVelocity
	{
		[Export("flyModeVelocity")]
		get
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("flyModeVelocity"));
		}
		[Export("setFlyModeVelocity:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, Selector.GetHandle("setFlyModeVelocity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat PanSensitivity
	{
		[Export("panSensitivity")]
		get
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("panSensitivity"));
		}
		[Export("setPanSensitivity:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, Selector.GetHandle("setPanSensitivity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat TruckSensitivity
	{
		[Export("truckSensitivity")]
		get
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("truckSensitivity"));
		}
		[Export("setTruckSensitivity:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, Selector.GetHandle("setTruckSensitivity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat RotationSensitivity
	{
		[Export("rotationSensitivity")]
		get
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("rotationSensitivity"));
		}
		[Export("setRotationSensitivity:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, Selector.GetHandle("setRotationSensitivity:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNCameraControlConfigurationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
