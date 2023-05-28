using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "VNRequestRevisionProviding", WrapperType = typeof(VNRequestRevisionProvidingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RequestRevision", Selector = "requestRevision", PropertyType = typeof(VNRequestRevision), GetterSelector = "requestRevision", ArgumentSemantic = ArgumentSemantic.None)]
public interface IVNRequestRevisionProviding : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	VNRequestRevision RequestRevision
	{
		[Export("requestRevision")]
		get;
	}
}
