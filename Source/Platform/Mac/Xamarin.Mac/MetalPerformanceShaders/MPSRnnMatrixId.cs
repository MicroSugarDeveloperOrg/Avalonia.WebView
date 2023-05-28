using ObjCRuntime;

namespace MetalPerformanceShaders;

[Native]
[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
public enum MPSRnnMatrixId : ulong
{
	SingleGateInputWeights,
	SingleGateRecurrentWeights,
	SingleGateBiasTerms,
	LstmInputGateInputWeights,
	LstmInputGateRecurrentWeights,
	LstmInputGateMemoryWeights,
	LstmInputGateBiasTerms,
	LstmForgetGateInputWeights,
	LstmForgetGateRecurrentWeights,
	LstmForgetGateMemoryWeights,
	LstmForgetGateBiasTerms,
	LstmMemoryGateInputWeights,
	LstmMemoryGateRecurrentWeights,
	LstmMemoryGateMemoryWeights,
	LstmMemoryGateBiasTerms,
	LstmOutputGateInputWeights,
	LstmOutputGateRecurrentWeights,
	LstmOutputGateMemoryWeights,
	LstmOutputGateBiasTerms,
	GruInputGateInputWeights,
	GruInputGateRecurrentWeights,
	GruInputGateBiasTerms,
	GruRecurrentGateInputWeights,
	GruRecurrentGateRecurrentWeights,
	GruRecurrentGateBiasTerms,
	GruOutputGateInputWeights,
	GruOutputGateRecurrentWeights,
	GruOutputGateInputGateWeights,
	GruOutputGateBiasTerms
}
