using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLLightProbeIrradianceDataSource", WrapperType = typeof(MDLLightProbeIrradianceDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSphericalHarmonicsCoefficients", Selector = "sphericalHarmonicsCoefficientsAtPosition:", ReturnType = typeof(NSData), ParameterType = new Type[] { typeof(Vector3) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BoundingBox", Selector = "boundingBox", PropertyType = typeof(MDLAxisAlignedBoundingBox), GetterSelector = "boundingBox", SetterSelector = "setBoundingBox:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SphericalHarmonicsLevel", Selector = "sphericalHarmonicsLevel", PropertyType = typeof(nuint), GetterSelector = "sphericalHarmonicsLevel", SetterSelector = "setSphericalHarmonicsLevel:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMDLLightProbeIrradianceDataSource : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	MDLAxisAlignedBoundingBox BoundingBox
	{
		[Export("boundingBox", ArgumentSemantic.Assign)]
		get;
		[Export("setBoundingBox:", ArgumentSemantic.Assign)]
		set;
	}
}
