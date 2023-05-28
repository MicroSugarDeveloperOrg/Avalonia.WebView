using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public enum CVReturn
{
	Success = 0,
	First = -6660,
	Error = -6660,
	InvalidArgument = -6661,
	AllocationFailed = -6662,
	Unsupported = -6663,
	InvalidDisplay = -6670,
	DisplayLinkAlreadyRunning = -6671,
	DisplayLinkNotRunning = -6672,
	DisplayLinkCallbacksNotSet = -6673,
	InvalidPixelFormat = -6680,
	InvalidSize = -6681,
	InvalidPixelBufferAttributes = -6682,
	PixelBufferNotOpenGLCompatible = -6683,
	PixelBufferNotMetalCompatible = -6684,
	WouldExceedAllocationThreshold = -6689,
	PoolAllocationFailed = -6690,
	InvalidPoolAttributes = -6691,
	Retry = -6692,
	Last = -6699
}
