using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlRequestNetworkServiceType : ulong
{
	Default = 0uL,
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PushKit' framework instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PushKit' framework instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'PushKit' framework instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PushKit' framework instead.")]
	VoIP = 1uL,
	Video = 2uL,
	Background = 3uL,
	Voice = 4uL,
	[Mac(10, 14)]
	[iOS(12, 0)]
	[Watch(5, 0)]
	[TV(12, 0)]
	ResponsiveData = 6uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	AVStreaming = 8uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	ResponsiveAV = 9uL,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[Watch(3, 0)]
	[TV(10, 0)]
	CallSignaling = 11uL
}
