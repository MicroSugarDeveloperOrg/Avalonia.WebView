using System;
using Foundation;
using ObjCRuntime;

namespace CoreAudioKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "AUCustomViewPersistentData", WrapperType = typeof(AUCustomViewPersistentDataWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CustomViewPersistentData", Selector = "customViewPersistentData", PropertyType = typeof(NSDictionary<NSString, NSObject>), GetterSelector = "customViewPersistentData", SetterSelector = "setCustomViewPersistentData:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface IAUCustomViewPersistentData : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSDictionary<NSString, NSObject>? CustomViewPersistentData
	{
		[Export("customViewPersistentData", ArgumentSemantic.Assign)]
		get;
		[Export("setCustomViewPersistentData:", ArgumentSemantic.Assign)]
		set;
	}
}
