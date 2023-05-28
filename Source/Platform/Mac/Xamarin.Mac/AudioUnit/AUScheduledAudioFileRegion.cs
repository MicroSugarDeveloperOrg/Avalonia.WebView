using System;
using System.Runtime.InteropServices;
using AudioToolbox;

namespace AudioUnit;

public class AUScheduledAudioFileRegion : IDisposable
{
	internal struct ScheduledAudioFileRegion
	{
		public AudioTimeStamp TimeStamp;

		public ScheduledAudioFileRegionCompletionHandler CompletionHandler;

		public IntPtr CompletionHandlerUserData;

		public IntPtr AudioFile;

		public uint LoopCount;

		public long StartFrame;

		public uint FramesToPlay;
	}

	internal delegate void ScheduledAudioFileRegionCompletionHandler(IntPtr userData, ref ScheduledAudioFileRegion fileRegion, AudioUnitStatus result);

	private GCHandle handle;

	private AUScheduledAudioFileRegionCompletionHandler completionHandler;

	private bool alreadyUsed = false;

	private static readonly ScheduledAudioFileRegionCompletionHandler static_ScheduledAudioFileRegionCompletionHandler = ScheduledAudioFileRegionCallback;

	public AudioTimeStamp TimeStamp { get; set; }

	public AudioFile AudioFile { get; private set; }

	public uint LoopCount { get; set; }

	public long StartFrame { get; set; }

	public uint FramesToPlay { get; set; }

	public AUScheduledAudioFileRegion(AudioFile audioFile, AUScheduledAudioFileRegionCompletionHandler completionHandler = null)
	{
		if (audioFile == null)
		{
			throw new ArgumentNullException("audioFile");
		}
		AudioFile = audioFile;
		this.completionHandler = completionHandler;
	}

	private static void ScheduledAudioFileRegionCallback(IntPtr userData, ref ScheduledAudioFileRegion fileRegion, AudioUnitStatus status)
	{
		if (!(userData == IntPtr.Zero))
		{
			AUScheduledAudioFileRegion aUScheduledAudioFileRegion = (AUScheduledAudioFileRegion)GCHandle.FromIntPtr(userData).Target;
			aUScheduledAudioFileRegion?.completionHandler(aUScheduledAudioFileRegion, status);
		}
	}

	internal ScheduledAudioFileRegion GetAudioFileRegion()
	{
		if (alreadyUsed)
		{
			throw new InvalidOperationException("You should not call SetScheduledFileRegion with a previously set region instance");
		}
		IntPtr intPtr = IntPtr.Zero;
		if (completionHandler != null)
		{
			handle = GCHandle.Alloc(this);
			intPtr = GCHandle.ToIntPtr(handle);
		}
		ScheduledAudioFileRegion scheduledAudioFileRegion = default(ScheduledAudioFileRegion);
		scheduledAudioFileRegion.TimeStamp = TimeStamp;
		scheduledAudioFileRegion.CompletionHandlerUserData = intPtr;
		scheduledAudioFileRegion.CompletionHandler = ((intPtr != IntPtr.Zero) ? static_ScheduledAudioFileRegionCompletionHandler : null);
		scheduledAudioFileRegion.AudioFile = AudioFile.Handle;
		scheduledAudioFileRegion.LoopCount = LoopCount;
		scheduledAudioFileRegion.StartFrame = StartFrame;
		scheduledAudioFileRegion.FramesToPlay = FramesToPlay;
		ScheduledAudioFileRegion result = scheduledAudioFileRegion;
		alreadyUsed = true;
		return result;
	}

	~AUScheduledAudioFileRegion()
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
		if (disposing)
		{
			completionHandler = null;
		}
		if (handle.IsAllocated)
		{
			handle.Free();
		}
	}
}
