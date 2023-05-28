using ObjCRuntime;

namespace CoreFoundation;

[Mac(10, 12)]
[iOS(10, 0)]
[Watch(3, 0)]
[TV(10, 0)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public enum OSLogLevel : byte
{
	Default = 0,
	Info = 1,
	Debug = 2,
	Error = 16,
	Fault = 17
}
