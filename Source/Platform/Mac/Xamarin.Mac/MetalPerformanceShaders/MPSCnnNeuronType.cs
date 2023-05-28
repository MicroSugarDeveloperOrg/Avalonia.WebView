using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
public enum MPSCnnNeuronType
{
	None,
	ReLU,
	Linear,
	Sigmoid,
	HardSigmoid,
	TanH,
	Absolute,
	SoftPlus,
	SoftSign,
	Elu,
	PReLU,
	ReLun,
	[TV(11, 3)]
	[Mac(10, 13, 4)]
	[iOS(11, 3)]
	Power,
	[TV(11, 3)]
	[Mac(10, 13, 4)]
	[iOS(11, 3)]
	Exponential,
	[TV(11, 3)]
	[Mac(10, 13, 4)]
	[iOS(11, 3)]
	Logarithm,
	[Obsolete("The value changes when newer versions are released. It will be removed in the future.")]
	Count
}
