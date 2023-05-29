using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

public struct CMTime
{
	[Flags]
	public enum Flags
	{
		Valid = 1,
		HasBeenRounded = 2,
		PositiveInfinity = 4,
		NegativeInfinity = 8,
		Indefinite = 0x10,
		ImpliedValueFlagsMask = 0x1C
	}

	public static CMTime Invalid;

	private const Flags kIndefinite = Flags.Valid | Flags.Indefinite;

	public static CMTime Indefinite;

	private const Flags kPositive = Flags.Valid | Flags.PositiveInfinity;

	public static CMTime PositiveInfinity;

	private const Flags kNegative = Flags.Valid | Flags.NegativeInfinity;

	public static CMTime NegativeInfinity;

	public static CMTime Zero;

	public const int MaxTimeScale = int.MaxValue;

	public long Value;

	public int TimeScale;

	public Flags TimeFlags;

	public long TimeEpoch;

	public static readonly NSString ValueKey;

	public static readonly NSString ScaleKey;

	public static readonly NSString EpochKey;

	public static readonly NSString FlagsKey;

	public bool IsInvalid => (TimeFlags & Flags.Valid) == 0;

	public bool IsIndefinite => (TimeFlags & (Flags.Valid | Flags.Indefinite)) == (Flags.Valid | Flags.Indefinite);

	public bool IsPositiveInfinity => (TimeFlags & (Flags.Valid | Flags.PositiveInfinity)) == (Flags.Valid | Flags.PositiveInfinity);

	public bool IsNegativeInfinity => (TimeFlags & (Flags.Valid | Flags.NegativeInfinity)) == (Flags.Valid | Flags.NegativeInfinity);

	public CMTime AbsoluteValue => CMTimeAbsoluteValue(this);

	public double Seconds => CMTimeGetSeconds(this);

	public IntPtr AsDictionary => CMTimeCopyAsDictionary(this, IntPtr.Zero);

	public string Description => NSString.FromHandle(CMTimeCopyDescription(IntPtr.Zero, this)).ToString();

	private CMTime(Flags f)
	{
		Value = 0L;
		TimeScale = 0;
		TimeEpoch = 0L;
		TimeFlags = f;
	}

	private CMTime(Flags f, int timescale)
	{
		Value = 0L;
		TimeScale = timescale;
		TimeEpoch = 0L;
		TimeFlags = f;
	}

	public CMTime(long value, int timescale)
	{
		Value = value;
		TimeScale = timescale;
		TimeFlags = Flags.Valid;
		TimeEpoch = 0L;
	}

	public CMTime(long value, int timescale, long epoch)
	{
		Value = value;
		TimeScale = timescale;
		TimeFlags = Flags.Valid;
		TimeEpoch = epoch;
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeAbsoluteValue(CMTime time);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern int CMTimeCompare(CMTime time1, CMTime time2);

	public static int Compare(CMTime time1, CMTime time2)
	{
		return CMTimeCompare(time1, time2);
	}

	public static bool operator ==(CMTime time1, CMTime time2)
	{
		return Compare(time1, time2) == 0;
	}

	public static bool operator !=(CMTime time1, CMTime time2)
	{
		return !(time1 == time2);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CMTime))
		{
			return false;
		}
		return (CMTime)obj == this;
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode() ^ TimeScale.GetHashCode() ^ TimeFlags.GetHashCode() ^ TimeEpoch.GetHashCode();
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeAdd(CMTime addend1, CMTime addend2);

	public static CMTime Add(CMTime time1, CMTime time2)
	{
		return CMTimeAdd(time1, time2);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeSubtract(CMTime minuend, CMTime subtraend);

	public static CMTime Subtract(CMTime minuend, CMTime subtraend)
	{
		return CMTimeSubtract(minuend, subtraend);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMultiply(CMTime time, int multiplier);

	public static CMTime Multiply(CMTime time, int multiplier)
	{
		return CMTimeMultiply(time, multiplier);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMultiplyByFloat64(CMTime time, double multiplier);

	public static CMTime Multiply(CMTime time, double multiplier)
	{
		return CMTimeMultiplyByFloat64(time, multiplier);
	}

	public static CMTime operator +(CMTime time1, CMTime time2)
	{
		return Add(time1, time2);
	}

	public static CMTime operator -(CMTime minuend, CMTime subtraend)
	{
		return Subtract(minuend, subtraend);
	}

	public static CMTime operator *(CMTime time, int multiplier)
	{
		return Multiply(time, multiplier);
	}

	public static CMTime operator *(CMTime time, double multiplier)
	{
		return Multiply(time, multiplier);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeConvertScale(CMTime time, int newScale, CMTimeRoundingMethod method);

	public CMTime ConvertScale(int newScale, CMTimeRoundingMethod method)
	{
		return CMTimeConvertScale(this, newScale, method);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern double CMTimeGetSeconds(CMTime time);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMakeWithSeconds(double seconds, int preferredTimeScale);

	public static CMTime FromSeconds(double seconds, int preferredTimeScale)
	{
		return CMTimeMakeWithSeconds(seconds, preferredTimeScale);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMaximum(CMTime time1, CMTime time2);

	public static CMTime GetMaximum(CMTime time1, CMTime time2)
	{
		return CMTimeMaximum(time1, time2);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMinimum(CMTime time1, CMTime time2);

	public static CMTime GetMinimum(CMTime time1, CMTime time2)
	{
		return CMTimeMinimum(time1, time2);
	}

	static CMTime()
	{
		Invalid = new CMTime((Flags)0);
		Indefinite = new CMTime(Flags.Valid | Flags.Indefinite);
		PositiveInfinity = new CMTime(Flags.Valid | Flags.PositiveInfinity);
		NegativeInfinity = new CMTime(Flags.Valid | Flags.NegativeInfinity);
		Zero = new CMTime(Flags.Valid, 1);
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia", 0);
		if (intPtr != IntPtr.Zero)
		{
			try
			{
				ValueKey = Dlfcn.GetStringConstant(intPtr, "kCMTimeValueKey");
				ScaleKey = Dlfcn.GetStringConstant(intPtr, "kCMTimeScaleKey");
				EpochKey = Dlfcn.GetStringConstant(intPtr, "kCMTimeEpochKey");
				FlagsKey = Dlfcn.GetStringConstant(intPtr, "kCMTimeFlagsKey");
			}
			finally
			{
				Dlfcn.dlclose(intPtr);
			}
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMTimeCopyAsDictionary(CMTime time, IntPtr allocator);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMTimeCopyDescription(IntPtr allocator, CMTime time);

	public override string ToString()
	{
		return Description;
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMTimeMakeFromDictionary(IntPtr dict);

	public static CMTime FromDictionary(IntPtr dict)
	{
		return CMTimeMakeFromDictionary(dict);
	}
}
