using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSNNTrainableNode", WrapperType = typeof(MPSNNTrainableNodeWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TrainingStyle", Selector = "trainingStyle", PropertyType = typeof(MPSNNTrainingStyle), GetterSelector = "trainingStyle", SetterSelector = "setTrainingStyle:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface IMPSNNTrainableNode : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	MPSNNTrainingStyle TrainingStyle
	{
		[Export("trainingStyle", ArgumentSemantic.Assign)]
		get;
		[Export("setTrainingStyle:", ArgumentSemantic.Assign)]
		set;
	}
}
