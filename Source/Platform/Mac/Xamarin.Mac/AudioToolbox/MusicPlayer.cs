using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public class MusicPlayer : INativeObject, IDisposable
{
	private IntPtr handle;

	private MusicSequence currentSequence;

	public IntPtr Handle => handle;

	public double Time
	{
		get
		{
			MusicPlayerGetTime(handle, out var outTime);
			return outTime;
		}
		set
		{
			MusicPlayerSetTime(handle, value);
		}
	}

	public bool IsPlaying
	{
		get
		{
			MusicPlayerIsPlaying(handle, out var outIsPlaying);
			return outIsPlaying;
		}
	}

	public double PlayRateScalar
	{
		get
		{
			MusicPlayerGetPlayRateScalar(handle, out var outScaleRate);
			return outScaleRate;
		}
		set
		{
			MusicPlayerSetPlayRateScalar(handle, value);
		}
	}

	public MusicSequence MusicSequence
	{
		get
		{
			if (MusicPlayerGetSequence(handle, out var outSequence) == MusicPlayerStatus.Success)
			{
				return MusicSequence.Lookup(outSequence);
			}
			return null;
		}
		set
		{
			currentSequence = value;
			MusicPlayerSetSequence(handle, value?.Handle ?? IntPtr.Zero);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus NewMusicPlayer(out IntPtr outPlayer);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus DisposeMusicPlayer(IntPtr inPlayer);

	private MusicPlayer(IntPtr handle)
	{
		this.handle = handle;
	}

	~MusicPlayer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		currentSequence = null;
		if (handle != IntPtr.Zero)
		{
			DisposeMusicPlayer(handle);
			handle = IntPtr.Zero;
		}
	}

	public MusicPlayer()
	{
		MusicPlayerStatus musicPlayerStatus = NewMusicPlayer(out handle);
		if (musicPlayerStatus == MusicPlayerStatus.Success)
		{
			return;
		}
		throw new Exception("Unable to create MusicPlayer: " + musicPlayerStatus);
	}

	public static MusicPlayer Create(out MusicPlayerStatus OSstatus)
	{
		OSstatus = NewMusicPlayer(out var outPlayer);
		if (OSstatus == MusicPlayerStatus.Success)
		{
			return new MusicPlayer(outPlayer);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerGetTime(IntPtr inPlayer, out double outTime);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerSetTime(IntPtr inPlayer, double inTime);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerPreroll(IntPtr inPlayer);

	public MusicPlayerStatus Preroll()
	{
		return MusicPlayerPreroll(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerStart(IntPtr inPlayer);

	public MusicPlayerStatus Start()
	{
		return MusicPlayerStart(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerStop(IntPtr inPlayer);

	public MusicPlayerStatus Stop()
	{
		return MusicPlayerStop(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerIsPlaying(IntPtr inPlayer, out bool outIsPlaying);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerSetPlayRateScalar(IntPtr inPlayer, double inScaleRate);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerGetPlayRateScalar(IntPtr inPlayer, out double outScaleRate);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerGetHostTimeForBeats(IntPtr inPlayer, double inBeats, out long outHostTime);

	public MusicPlayerStatus GetHostTimeForBeats(double beats, out long hostTime)
	{
		return MusicPlayerGetHostTimeForBeats(handle, beats, out hostTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerGetBeatsForHostTime(IntPtr inPlayer, long inHostTime, out double outBeats);

	public MusicPlayerStatus GetBeatsForHostTime(long hostTime, out double beats)
	{
		return MusicPlayerGetBeatsForHostTime(handle, hostTime, out beats);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerGetSequence(IntPtr inPlayer, out IntPtr outSequence);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicPlayerSetSequence(IntPtr inPlayer, IntPtr inSequence);
}
