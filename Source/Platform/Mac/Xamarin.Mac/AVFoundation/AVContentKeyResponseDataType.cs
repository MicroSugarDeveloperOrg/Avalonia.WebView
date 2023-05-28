using ObjCRuntime;

namespace AVFoundation;

[TV(10, 2)]
[Mac(10, 12, 4)]
[iOS(10, 3)]
[NoWatch]
public enum AVContentKeyResponseDataType
{
	FairPlayStreamingKeyResponseData,
	[TV(13, 0)]
	[NoWatch]
	[Mac(10, 15)]
	[iOS(13, 0)]
	AuthorizationTokenData
}
