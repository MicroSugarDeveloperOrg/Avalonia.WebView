using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNCameraControlConfiguration", WrapperType = typeof(SCNCameraControlConfigurationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoSwitchToFreeCamera", Selector = "autoSwitchToFreeCamera", PropertyType = typeof(bool), GetterSelector = "autoSwitchToFreeCamera", SetterSelector = "setAutoSwitchToFreeCamera:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowsTranslation", Selector = "allowsTranslation", PropertyType = typeof(bool), GetterSelector = "allowsTranslation", SetterSelector = "setAllowsTranslation:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FlyModeVelocity", Selector = "flyModeVelocity", PropertyType = typeof(nfloat), GetterSelector = "flyModeVelocity", SetterSelector = "setFlyModeVelocity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PanSensitivity", Selector = "panSensitivity", PropertyType = typeof(nfloat), GetterSelector = "panSensitivity", SetterSelector = "setPanSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TruckSensitivity", Selector = "truckSensitivity", PropertyType = typeof(nfloat), GetterSelector = "truckSensitivity", SetterSelector = "setTruckSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RotationSensitivity", Selector = "rotationSensitivity", PropertyType = typeof(nfloat), GetterSelector = "rotationSensitivity", SetterSelector = "setRotationSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISCNCameraControlConfiguration : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool AutoSwitchToFreeCamera
	{
		[Export("autoSwitchToFreeCamera")]
		get;
		[Export("setAutoSwitchToFreeCamera:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AllowsTranslation
	{
		[Export("allowsTranslation")]
		get;
		[Export("setAllowsTranslation:")]
		set;
	}

	[Preserve(Conditional = true)]
	nfloat FlyModeVelocity
	{
		[Export("flyModeVelocity")]
		get;
		[Export("setFlyModeVelocity:")]
		set;
	}

	[Preserve(Conditional = true)]
	nfloat PanSensitivity
	{
		[Export("panSensitivity")]
		get;
		[Export("setPanSensitivity:")]
		set;
	}

	[Preserve(Conditional = true)]
	nfloat TruckSensitivity
	{
		[Export("truckSensitivity")]
		get;
		[Export("setTruckSensitivity:")]
		set;
	}

	[Preserve(Conditional = true)]
	nfloat RotationSensitivity
	{
		[Export("rotationSensitivity")]
		get;
		[Export("setRotationSensitivity:")]
		set;
	}
}
