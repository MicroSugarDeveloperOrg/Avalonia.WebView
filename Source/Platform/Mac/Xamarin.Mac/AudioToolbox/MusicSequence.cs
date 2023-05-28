using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace AudioToolbox;

public class MusicSequence : INativeObject, IDisposable
{
	private IntPtr handle;

	private static Dictionary<IntPtr, MusicSequenceUserCallback> userCallbackHandles = new Dictionary<IntPtr, MusicSequenceUserCallback>(Runtime.IntPtrEqualityComparer);

	private static MusicSequenceUserCallbackProxy userCallbackProxy = UserCallbackProxy;

	private static readonly Dictionary<IntPtr, WeakReference> sequenceMap = new Dictionary<IntPtr, WeakReference>(Runtime.IntPtrEqualityComparer);

	public IntPtr Handle => handle;

	public AUGraph AUGraph
	{
		get
		{
			if (MusicSequenceGetAUGraph(handle, out var outGraph) != 0)
			{
				return null;
			}
			return new AUGraph(outGraph);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			MusicSequenceSetAUGraph(handle, value.Handle);
		}
	}

	public MusicSequenceType SequenceType
	{
		get
		{
			MusicSequenceGetSequenceType(handle, out var outType);
			return outType;
		}
		set
		{
			MusicSequenceSetSequenceType(handle, value);
		}
	}

	public int TrackCount
	{
		get
		{
			if (MusicSequenceGetTrackCount(handle, out var outNumberOfTracks) == MusicPlayerStatus.Success)
			{
				return outNumberOfTracks;
			}
			return 0;
		}
	}

	internal MusicSequence(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus NewMusicSequence(out IntPtr outSequence);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus DisposeMusicSequence(IntPtr inSequence);

	public MusicSequence()
	{
		NewMusicSequence(out handle);
		lock (sequenceMap)
		{
			sequenceMap[handle] = new WeakReference(this);
		}
	}

	~MusicSequence()
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
		if (handle != IntPtr.Zero)
		{
			lock (userCallbackHandles)
			{
				userCallbackHandles.Remove(handle);
			}
			MusicSequenceSetUserCallback(handle, null, IntPtr.Zero);
			DisposeMusicSequence(handle);
			lock (sequenceMap)
			{
				sequenceMap.Remove(handle);
			}
			handle = IntPtr.Zero;
		}
	}

	internal static MusicSequence Lookup(IntPtr handle)
	{
		lock (sequenceMap)
		{
			if (sequenceMap.TryGetValue(handle, out var value))
			{
				object target = value.Target;
				if (target != null)
				{
					return (MusicSequence)target;
				}
				sequenceMap.Remove(handle);
			}
			MusicSequence musicSequence = new MusicSequence(handle);
			sequenceMap[handle] = new WeakReference(musicSequence);
			return musicSequence;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceSetAUGraph(IntPtr inSequence, IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetAUGraph(IntPtr inSequence, out IntPtr outGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceSetSequenceType(IntPtr inSequence, MusicSequenceType inType);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetSequenceType(IntPtr inSequence, out MusicSequenceType outType);

	public void GetSmpteResolution(short resolution, out sbyte fps, out byte ticks)
	{
		fps = (sbyte)((resolution & 0xFF00) >> 8);
		ticks = (byte)((uint)resolution & 0x7Fu);
	}

	public short SetSmpteResolution(sbyte fps, byte ticks)
	{
		if (fps > 0)
		{
			fps = (sbyte)(-fps);
		}
		return (short)((fps << 8) + ticks);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern IntPtr MusicSequenceGetInfoDictionary(IntPtr inSequence);

	public NSDictionary GetInfoDictionary()
	{
		return Runtime.GetNSObject<NSDictionary>(MusicSequenceGetInfoDictionary(handle));
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceNewTrack(IntPtr inSequence, out IntPtr outTrack);

	public MusicTrack CreateTrack()
	{
		if (MusicSequenceNewTrack(handle, out var outTrack) == MusicPlayerStatus.Success)
		{
			return new MusicTrack(this, outTrack, owns: true);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetTrackCount(IntPtr inSequence, out int outNumberOfTracks);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetIndTrack(IntPtr inSequence, int inTrackIndex, out IntPtr outTrack);

	public MusicTrack GetTrack(int trackIndex)
	{
		if (MusicSequenceGetIndTrack(handle, trackIndex, out var outTrack) == MusicPlayerStatus.Success)
		{
			return new MusicTrack(this, outTrack, owns: false);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetTrackIndex(IntPtr inSequence, IntPtr inTrack, out int outTrackIndex);

	public MusicPlayerStatus GetTrackIndex(MusicTrack track, out int index)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return MusicSequenceGetTrackIndex(handle, track.Handle, out index);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetTempoTrack(IntPtr sequence, out IntPtr outTrack);

	public MusicTrack GetTempoTrack()
	{
		if (MusicSequenceGetTempoTrack(handle, out var outTrack) == MusicPlayerStatus.Success)
		{
			return new MusicTrack(this, outTrack, owns: false);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetSecondsForBeats(IntPtr inSequence, double inBeats, out double outSeconds);

	public double GetSecondsForBeats(double beats)
	{
		if (MusicSequenceGetSecondsForBeats(handle, beats, out var outSeconds) == MusicPlayerStatus.Success)
		{
			return outSeconds;
		}
		return 0.0;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceGetBeatsForSeconds(IntPtr inSequence, double inSeconds, out double outBeats);

	public double GetBeatsForSeconds(double seconds)
	{
		if (MusicSequenceGetBeatsForSeconds(handle, seconds, out var outBeats) == MusicPlayerStatus.Success)
		{
			return outBeats;
		}
		return 0.0;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceSetUserCallback(IntPtr inSequence, MusicSequenceUserCallbackProxy inCallback, IntPtr inClientData);

	public void SetUserCallback(MusicSequenceUserCallback callback)
	{
		lock (userCallbackHandles)
		{
			userCallbackHandles[handle] = callback;
		}
		MusicSequenceSetUserCallback(handle, userCallbackProxy, IntPtr.Zero);
	}

	private static void UserCallbackProxy(IntPtr inClientData, IntPtr inSequence, IntPtr inTrack, double inEventTime, IntPtr inEventData, double inStartSliceBeat, double inEndSliceBeat)
	{
		MusicSequenceUserCallback value;
		lock (userCallbackHandles)
		{
			userCallbackHandles.TryGetValue(inSequence, out value);
		}
		if (value != null)
		{
			MusicEventUserData inEventData2 = new MusicEventUserData(inEventData);
			MusicSequence sequence = Lookup(inSequence);
			MusicTrack track = new MusicTrack(sequence, inTrack, owns: false);
			value(track, inEventTime, inEventData2, inStartSliceBeat, inEndSliceBeat);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceBeatsToBarBeatTime(IntPtr inSequence, double inBeats, int inSubbeatDivisor, out CABarBeatTime outBarBeatTime);

	public MusicPlayerStatus BeatsToBarBeatTime(double beats, int subbeatDivisor, out CABarBeatTime barBeatTime)
	{
		return MusicSequenceBeatsToBarBeatTime(handle, beats, subbeatDivisor, out barBeatTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceBarBeatTimeToBeats(IntPtr inSequence, CABarBeatTime inBarBeatTime, out double outBeats);

	public MusicPlayerStatus BarBeatTimeToBeats(CABarBeatTime barBeatTime, out double beats)
	{
		return MusicSequenceBarBeatTimeToBeats(handle, barBeatTime, out beats);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceReverse(IntPtr inSequence);

	public MusicPlayerStatus Reverse()
	{
		return MusicSequenceReverse(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceFileLoad(IntPtr inSequence, IntPtr inFileRef, MusicSequenceFileTypeID inFileTypeHint, MusicSequenceLoadFlags inFlags);

	public MusicPlayerStatus LoadFile(NSUrl url, MusicSequenceFileTypeID fileTypeId, MusicSequenceLoadFlags loadFlags = MusicSequenceLoadFlags.PreserveTracks)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return MusicSequenceFileLoad(handle, url.Handle, fileTypeId, loadFlags);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceFileLoadData(IntPtr inSequence, IntPtr inData, MusicSequenceFileTypeID inFileTypeHint, MusicSequenceLoadFlags inFlags);

	public MusicPlayerStatus LoadData(NSData data, MusicSequenceFileTypeID fileTypeId, MusicSequenceLoadFlags loadFlags = MusicSequenceLoadFlags.PreserveTracks)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return MusicSequenceFileLoadData(handle, data.Handle, fileTypeId, loadFlags);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceFileCreate(IntPtr inSequence, IntPtr inFileRef, MusicSequenceFileTypeID inFileType, MusicSequenceFileFlags inFlags, ushort resolution);

	public MusicPlayerStatus CreateFile(NSUrl url, MusicSequenceFileTypeID fileType, MusicSequenceFileFlags flags = MusicSequenceFileFlags.Default, ushort resolution = 0)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return MusicSequenceFileCreate(handle, url.Handle, fileType, flags, resolution);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceFileCreateData(IntPtr inSequence, MusicSequenceFileTypeID inFileType, MusicSequenceFileFlags inFlags, ushort resolution, out IntPtr outData);

	public NSData CreateData(MusicSequenceFileTypeID fileType, MusicSequenceFileFlags flags = MusicSequenceFileFlags.Default, ushort resolution = 0)
	{
		if (MusicSequenceFileCreateData(handle, fileType, flags, resolution, out var outData) == MusicPlayerStatus.Success)
		{
			return Runtime.GetNSObject<NSData>(outData);
		}
		return null;
	}
}
