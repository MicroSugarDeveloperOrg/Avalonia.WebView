using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public class MusicTrack : INativeObject, IDisposable
{
	private enum SequenceTrackProperty
	{
		LoopInfo,
		OffsetTime,
		MuteStatus,
		SoloStatus,
		AutomatedParameters,
		TrackLength,
		TimeResolution
	}

	private MusicSequence sequence;

	private IntPtr handle;

	private bool owns;

	public IntPtr Handle => handle;

	public MusicSequence Sequence
	{
		get
		{
			if (MusicTrackGetSequence(handle, out var outSequence) == MusicPlayerStatus.Success)
			{
				return MusicSequence.Lookup(outSequence);
			}
			return null;
		}
	}

	public unsafe bool MuteStatus
	{
		get
		{
			int ioLength = 1;
			byte b = default(byte);
			MusicTrackGetProperty(handle, SequenceTrackProperty.MuteStatus, &b, ref ioLength);
			return b != 0;
		}
		set
		{
			MusicTrackSetProperty(handle, SequenceTrackProperty.MuteStatus, &value, 1);
		}
	}

	public unsafe bool SoloStatus
	{
		get
		{
			int ioLength = 1;
			byte b = default(byte);
			MusicTrackGetProperty(handle, SequenceTrackProperty.SoloStatus, &b, ref ioLength);
			return b != 0;
		}
		set
		{
			MusicTrackSetProperty(handle, SequenceTrackProperty.SoloStatus, &value, 1);
		}
	}

	public double TrackLength
	{
		get
		{
			double outData = 0.0;
			int ioLength = 8;
			MusicTrackGetProperty(handle, SequenceTrackProperty.TrackLength, ref outData, ref ioLength);
			return outData;
		}
		set
		{
			MusicTrackSetProperty(handle, SequenceTrackProperty.TrackLength, ref value, 8);
		}
	}

	internal MusicTrack(MusicSequence sequence, IntPtr handle, bool owns)
	{
		this.sequence = sequence;
		this.handle = handle;
		this.owns = owns;
	}

	~MusicTrack()
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
			if (owns)
			{
				MusicSequenceDisposeTrack(sequence.Handle, handle);
			}
			handle = IntPtr.Zero;
		}
		sequence = null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicSequenceDisposeTrack(IntPtr inSequence, IntPtr inTrack);

	public static MusicTrack FromSequence(MusicSequence sequence)
	{
		if (sequence == null)
		{
			throw new ArgumentNullException("sequence");
		}
		return sequence.CreateTrack();
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackGetSequence(IntPtr inTrack, out IntPtr outSequence);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackSetDestNode(IntPtr inTrack, int inNode);

	public MusicPlayerStatus SetDestNode(int node)
	{
		return MusicTrackSetDestNode(handle, node);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern MusicPlayerStatus MusicTrackSetProperty(IntPtr inTrack, SequenceTrackProperty propertyId, void* inData, int inLength);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackSetProperty(IntPtr inTrack, SequenceTrackProperty propertyId, ref double inData, int inLength);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern MusicPlayerStatus MusicTrackGetProperty(IntPtr inTrack, SequenceTrackProperty propertyId, void* outData, ref int ioLength);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackGetProperty(IntPtr inTrack, SequenceTrackProperty propertyId, ref double outData, ref int ioLength);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern MusicPlayerStatus MusicTrackNewMIDINoteEvent(IntPtr inTrack, double inTimeStamp, MidiNoteMessage* inMessage);

	public unsafe MusicPlayerStatus AddMidiNoteEvent(double timeStamp, MidiNoteMessage message)
	{
		return MusicTrackNewMIDINoteEvent(handle, timeStamp, &message);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern MusicPlayerStatus MusicTrackNewMIDIChannelEvent(IntPtr inTrack, double inTimeStamp, MidiChannelMessage* inMessage);

	public unsafe MusicPlayerStatus AddMidiChannelEvent(double timestamp, MidiChannelMessage channelMessage)
	{
		return MusicTrackNewMIDIChannelEvent(handle, timestamp, &channelMessage);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackNewMIDIRawDataEvent(IntPtr inTrack, double inTimestamp, IntPtr inRawData);

	public MusicPlayerStatus AddMidiRawDataEvent(double timestamp, MidiRawData rawData)
	{
		if (rawData == null)
		{
			throw new ArgumentNullException("rawData");
		}
		IntPtr intPtr = rawData.ToUnmanaged();
		MusicPlayerStatus result = MusicTrackNewMIDIRawDataEvent(handle, timestamp, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern MusicPlayerStatus MusicTrackNewExtendedNoteEvent(IntPtr inTrack, double inTimeStamp, ExtendedNoteOnEvent* inInfo);

	public unsafe MusicPlayerStatus AddNewExtendedNoteEvent(double timestamp, ExtendedNoteOnEvent evt)
	{
		return MusicTrackNewExtendedNoteEvent(handle, timestamp, &evt);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackNewExtendedTempoEvent(IntPtr inTrack, double inTimeStamp, double bpm);

	public MusicPlayerStatus AddExtendedTempoEvent(double timestamp, double bmp)
	{
		return MusicTrackNewExtendedTempoEvent(handle, timestamp, bmp);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackNewMetaEvent(IntPtr inTrack, double inTimeStamp, IntPtr inMetaEvent);

	public MusicPlayerStatus AddMetaEvent(double timestamp, MidiMetaEvent metaEvent)
	{
		if (metaEvent == null)
		{
			throw new ArgumentNullException("metaEvent");
		}
		IntPtr intPtr = metaEvent.ToUnmanaged();
		MusicPlayerStatus result = MusicTrackNewMetaEvent(handle, timestamp, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackNewUserEvent(IntPtr inTrack, double inTimeStamp, IntPtr inUserData);

	public MusicPlayerStatus AddUserEvent(double timestamp, MusicEventUserData userData)
	{
		if (userData == null)
		{
			throw new ArgumentNullException("userData");
		}
		IntPtr intPtr = userData.ToUnmanaged();
		MusicPlayerStatus result = MusicTrackNewUserEvent(handle, timestamp, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackMoveEvents(IntPtr inTrack, double inStartTime, double inEndTime, double inMoveTime);

	public MusicPlayerStatus MoveEvents(double startTime, double endTime, double moveTime)
	{
		return MusicTrackMoveEvents(handle, startTime, endTime, moveTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackClear(IntPtr inTrack, double inStartTime, double inEndTime);

	public MusicPlayerStatus Clear(double startTime, double endTime)
	{
		return MusicTrackClear(handle, startTime, endTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackCut(IntPtr inTrack, double inStartTime, double inEndTime);

	public MusicPlayerStatus Cut(double startTime, double endTime)
	{
		return MusicTrackCut(handle, startTime, endTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackCopyInsert(IntPtr inSourceTrack, double inSourceStartTime, double inSourceEndTime, IntPtr inDestTrack, double inDestInsertTime);

	public MusicPlayerStatus CopyInsert(double sourceStartTime, double sourceEndTime, MusicTrack targetTrack, double targetInsertTime)
	{
		if (targetTrack == null)
		{
			throw new ArgumentNullException("targetTrack");
		}
		return MusicTrackCopyInsert(handle, sourceStartTime, sourceEndTime, targetTrack.Handle, targetInsertTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern MusicPlayerStatus MusicTrackMerge(IntPtr inSourceTrack, double inSourceStartTime, double inSourceEndTime, IntPtr inDestTrack, double inDestInsertTime);

	public MusicPlayerStatus Merge(double sourceStartTime, double sourceEndTime, MusicTrack targetTrack, double targetInsertTime)
	{
		if (targetTrack == null)
		{
			throw new ArgumentNullException("targetTrack");
		}
		return MusicTrackMerge(handle, sourceStartTime, sourceEndTime, targetTrack.Handle, targetInsertTime);
	}
}
