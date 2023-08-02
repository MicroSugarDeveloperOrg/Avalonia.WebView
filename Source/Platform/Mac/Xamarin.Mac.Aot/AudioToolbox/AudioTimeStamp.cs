using System;
using System.Text;

namespace AudioToolbox;

public struct AudioTimeStamp
{
	[Flags]
	public enum AtsFlags
	{
		SampleTimeValid = 1,
		HostTimeValid = 2,
		RateScalarValid = 4,
		WordClockTimeValid = 8,
		SmpteTimeValid = 0x10,
		SampleHostTimeValid = 3
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
