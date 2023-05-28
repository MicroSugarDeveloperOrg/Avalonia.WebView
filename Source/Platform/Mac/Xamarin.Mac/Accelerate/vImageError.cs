using ObjCRuntime;

namespace Accelerate;

[Native]
public enum vImageError : long
{
	NoError = 0L,
	RoiLargerThanInputBuffer = -21766L,
	InvalidKernelSize = -21767L,
	InvalidEdgeStyle = -21768L,
	InvalidOffsetX = -21769L,
	InvalidOffsetY = -21770L,
	MemoryAllocationError = -21771L,
	NullPointerArgument = -21772L,
	InvalidParameter = -21773L,
	BufferSizeMismatch = -21774L,
	UnknownFlagsBit = -21775L,
	InternalError = -21776L,
	InvalidRowBytes = -21777L,
	InvalidImageFormat = -21778L,
	ColorSyncIsAbsent = -21779L,
	OutOfPlaceOperationRequired = -21780L
}
