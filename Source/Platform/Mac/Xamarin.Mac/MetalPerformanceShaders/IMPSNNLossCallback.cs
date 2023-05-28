using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Protocol(Name = "MPSNNLossCallback", WrapperType = typeof(MPSNNLossCallbackWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetScalarWeight", Selector = "scalarWeightForSourceImage:destinationImage:", ReturnType = typeof(float), ParameterType = new Type[]
{
	typeof(MPSImage),
	typeof(MPSImage)
}, ParameterByRef = new bool[] { false, false })]
public interface IMPSNNLossCallback : INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("scalarWeightForSourceImage:destinationImage:")]
	[Preserve(Conditional = true)]
	float GetScalarWeight(MPSImage sourceImage, MPSImage destinationImage);
}
