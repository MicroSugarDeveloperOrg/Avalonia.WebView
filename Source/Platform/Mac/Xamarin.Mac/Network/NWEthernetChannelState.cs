using ObjCRuntime;

namespace Network;

[NoWatch]
[NoTV]
[NoiOS]
[Mac(10, 15)]
public enum NWEthernetChannelState
{
	Invalid,
	Waiting,
	Preparing,
	Ready,
	Failed,
	Cancelled
}
