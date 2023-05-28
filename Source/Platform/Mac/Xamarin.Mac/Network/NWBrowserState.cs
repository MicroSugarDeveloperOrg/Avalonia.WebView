using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public enum NWBrowserState
{
	Invalid,
	Ready,
	Failed,
	Cancelled
}
