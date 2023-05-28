using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SKWarpable", WrapperType = typeof(SKWarpableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "WarpGeometry", Selector = "warpGeometry", PropertyType = typeof(SKWarpGeometry), GetterSelector = "warpGeometry", SetterSelector = "setWarpGeometry:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SubdivisionLevels", Selector = "subdivisionLevels", PropertyType = typeof(nint), GetterSelector = "subdivisionLevels", SetterSelector = "setSubdivisionLevels:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISKWarpable : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	SKWarpGeometry? WarpGeometry
	{
		[Export("warpGeometry", ArgumentSemantic.Assign)]
		get;
		[Export("setWarpGeometry:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	nint SubdivisionLevels
	{
		[Export("subdivisionLevels")]
		get;
		[Export("setSubdivisionLevels:")]
		set;
	}
}
