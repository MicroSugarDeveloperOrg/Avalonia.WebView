using System;
using System.Text;

namespace AudioToolbox;

public struct AudioTimeStamp
{
	[Flags]
	public enum AtsFlags : uint
	{
		NothingValid = 0u,
		SampleTimeValid = 1u,
		HostTimeValid = 2u,
		RateScalarValid = 4u,
		WordClockTimeValid = 8u,
		SmpteTimeValid = 0x10u,
		SampleHostTimeValid = 3u
	}

	public double SampleTime;

	public ulong HostTime;

	public double RateScalar;

	public ulong WordClockTime;

	public SmpteTime SMPTETime;

	public AtsFlags Flags;

	public uint Reserved;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("{");
		if ((Flags & AtsFlags.SampleTimeValid) != 0)
		{
			stringBuilder.Append("SampleTime=" + SampleTime);
		}
		if ((Flags & AtsFlags.HostTimeValid) != 0)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append("HostTime=" + HostTime);
		}
		if ((Flags & AtsFlags.RateScalarValid) != 0)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append("RateScalar=" + RateScalar);
		}
		if ((Flags & AtsFlags.WordClockTimeValid) != 0)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append("WordClock=" + HostTime + ",");
		}
		if ((Flags & AtsFlags.SmpteTimeValid) != 0)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append("SmpteTime=" + SMPTETime.ToString());
		}
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}
}
