using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public enum NWListenerState
{
	Invalid,
	Waiting,
	Ready,
	Failed,
	Cancelled
}
