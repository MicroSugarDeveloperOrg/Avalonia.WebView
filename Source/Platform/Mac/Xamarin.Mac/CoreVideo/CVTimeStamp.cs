using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public struct CVTimeStamp
{
	public uint Version;

	public int VideoTimeScale;

	public long VideoTime;

	public ulong HostTime;

	public double RateScalar;

	public long VideoRefreshPeriod;

	public CVSMPTETime SMPTETime;

	public ulong Flags;

	public ulong Reserved;
}
