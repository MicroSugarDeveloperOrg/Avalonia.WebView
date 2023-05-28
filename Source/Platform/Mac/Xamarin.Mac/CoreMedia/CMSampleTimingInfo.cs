using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public struct CMSampleTimingInfo
{
	public CMTime Duration;

	public CMTime PresentationTimeStamp;

	public CMTime DecodeTimeStamp;
}
