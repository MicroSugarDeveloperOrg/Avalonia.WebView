using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "GKGameModelUpdate", WrapperType = typeof(GKGameModelUpdateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Value", Selector = "value", PropertyType = typeof(nint), GetterSelector = "value", SetterSelector = "setValue:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface IGKGameModelUpdate : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	nint Value
	{
		[Export("value", ArgumentSemantic.Assign)]
		get;
		[Export("setValue:", ArgumentSemantic.Assign)]
		set;
	}
}
