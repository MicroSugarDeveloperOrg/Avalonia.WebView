using System;
using ObjCRuntime;

namespace QTKit;

[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
public struct QTTime
{
	public static readonly QTTime Zero = new QTTime(0L, 1, (TimeFlags)0);

	public static readonly QTTime IndefiniteTime = new QTTime(0L, 1, TimeFlags.TimeIsIndefinite);

	private long timeValue;

	private nint timeScale;

	private nint flags;

	public long TimeValue
	{
		get
		{
			return timeValue;
		}
		set
		{
			timeValue = value;
		}
	}

	public nint TimeScale
	{
		get
		{
			return timeScale;
		}
		set
		{
			timeScale = value;
		}
	}

	public TimeFlags Flags
	{
		get
		{
			return (TimeFlags)(long)flags;
		}
		set
		{
			flags = (nint)(long)value;
		}
	}

	public QTTime(long timeValue, nint timeScale, TimeFlags flags)
	{
		this.timeValue = timeValue;
		this.timeScale = timeScale;
		this.flags = (nint)(long)flags;
	}

	public QTTime(long timeValue, nint timeScale)
		: this(timeValue, timeScale, (TimeFlags)0)
	{
	}

	public override string ToString()
	{
		if (Flags == (TimeFlags)0)
		{
			return $"[TimeValue={TimeValue} scale={TimeScale}]";
		}
		return $"[TimeValue={TimeValue} scale={TimeScale} Flags={Flags}]";
	}
}
