using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
public enum CVImageBufferAlphaChannelMode
{
	[Field("kCVImageBufferAlphaChannelMode_StraightAlpha")]
	Straight,
	[Field("kCVImageBufferAlphaChannelMode_PremultipliedAlpha")]
	Premultiplied
}
