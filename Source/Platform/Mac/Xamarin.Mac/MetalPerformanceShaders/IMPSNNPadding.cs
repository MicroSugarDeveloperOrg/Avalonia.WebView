using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSNNPadding", WrapperType = typeof(MPSNNPaddingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLabel", Selector = "label", ReturnType = typeof(string))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDestinationImageDescriptor", Selector = "destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:", ReturnType = typeof(MPSImageDescriptor), ParameterType = new Type[]
{
	typeof(MPSImage[]),
	typeof(MPSState[]),
	typeof(MPSKernel),
	typeof(MPSImageDescriptor)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInverse", Selector = "inverse", ReturnType = typeof(IMPSNNPadding))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PaddingMethod", Selector = "paddingMethod", PropertyType = typeof(MPSNNPaddingMethod), GetterSelector = "paddingMethod", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSNNPadding : INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	[Preserve(Conditional = true)]
	MPSNNPaddingMethod PaddingMethod
	{
		[Export("paddingMethod")]
		get;
	}
}
