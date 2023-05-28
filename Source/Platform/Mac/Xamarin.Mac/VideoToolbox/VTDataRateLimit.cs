namespace VideoToolbox;

public struct VTDataRateLimit
{
	public uint NumberOfBytes { get; set; }

	public double Seconds { get; set; }

	public VTDataRateLimit(uint numberOfBytes, double seconds)
	{
		this = default(VTDataRateLimit);
		NumberOfBytes = numberOfBytes;
		Seconds = seconds;
	}
}
