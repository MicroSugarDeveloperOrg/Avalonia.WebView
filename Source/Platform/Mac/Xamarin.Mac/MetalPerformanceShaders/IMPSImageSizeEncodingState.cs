using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSImageSizeEncodingState", WrapperType = typeof(MPSImageSizeEncodingStateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceWidth", Selector = "sourceWidth", PropertyType = typeof(nuint), GetterSelector = "sourceWidth", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceHeight", Selector = "sourceHeight", PropertyType = typeof(nuint), GetterSelector = "sourceHeight", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSImageSizeEncodingState : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	nuint SourceWidth
	{
		[Export("sourceWidth")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint SourceHeight
	{
		[Export("sourceHeight")]
		get;
	}
}
