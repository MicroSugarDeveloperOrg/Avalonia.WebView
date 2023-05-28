using ObjCRuntime;

namespace QTKit;

[Native]
public enum QTCaptureDeviceControlsSpeed : long
{
	FastestReverse = -19000L,
	VeryFastReverse = -16000L,
	FastReverse = -13000L,
	NormalReverse = -10000L,
	SlowReverse = -7000L,
	VerySlowReverse = -4000L,
	SlowestReverse = -1000L,
	Stopped = 0L,
	SlowestForward = 1000L,
	VerySlowForward = 4000L,
	SlowForward = 7000L,
	NormalForward = 10000L,
	FastForward = 13000L,
	VeryFastForward = 16000L,
	FastestForward = 19000L
}
