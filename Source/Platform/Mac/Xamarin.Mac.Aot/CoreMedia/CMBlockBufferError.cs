namespace CoreMedia;

public enum CMBlockBufferError
{
	None = 0,
	StructureAllocationFailed = -12700,
	BlockAllocationFailed = -12701,
	BadCustomBlockSource = -12702,
	BadOffsetParameter = -12703,
	BadLengthParameter = -12704,
	BadPointerParameter = -12705,
	EmptyBlockBuffer = -12706,
	UnallocatedBlock = -12707
}
