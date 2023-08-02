namespace CoreVideo;

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
