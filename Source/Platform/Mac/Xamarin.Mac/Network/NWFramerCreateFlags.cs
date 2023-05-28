using System;
using ObjCRuntime;

namespace Network;

[Flags]
[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public enum NWFramerCreateFlags : uint
{
	Default = 0u
}
