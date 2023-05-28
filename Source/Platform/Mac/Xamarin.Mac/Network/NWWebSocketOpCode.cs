using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public enum NWWebSocketOpCode
{
	Cont = 0,
	Text = 1,
	Binary = 2,
	Close = 8,
	Ping = 9,
	Pong = 10,
	Invalid = -1
}
