using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class AudioQueueProcessingTap : IDisposable
{
	internal static readonly AudioQueueProcessingTapCallbackShared CreateTapCallback = TapCallback;

	private AudioQueueProcessingTapDelegate callback;

	private readonly GCHandle gc_handle;

	internal GCHandle Handle => gc_handle;

	internal IntPtr TapHandle { get; set; }

	public uint MaxFrames { get; internal set; }

	public AudioStreamBasicDescription ProcessingFormat { get; internal set; }

	internal AudioQueueProcessingTap(AudioQueueProcessingTapDelegate callback)
	{
		this.callback = callback;
		gc_handle = GCHandle.Alloc(this);
	}

	~AudioQueueProcessingTap()
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
			callback = null;
		}
		if (gc_handle.IsAllocated)
		{
			gc_handle.Free();
			AudioQueueProcessingTapDispose(TapHandle);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueProcessingTapDispose(IntPtr inAQTap);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[Obsolete]
	private static extern AudioQueueStatus AudioQueueProcessingTapGetSourceAudio(IntPtr inAQTap, uint inNumberFrames, ref AudioTimeStamp ioTimeStamp, out AudioQueueProcessingTapFlags outFlags, out uint outNumberFrames, AudioBufferList ioData);

	[Obsolete("Use overload with AudioBuffers")]
	public AudioQueueStatus GetSourceAudio(uint numberOfFrames, ref AudioTimeStamp timeStamp, out AudioQueueProcessingTapFlags flags, out uint parentNumberOfFrames, AudioBufferList data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return AudioQueueProcessingTapGetSourceAudio(TapHandle, numberOfFrames, ref timeStamp, out flags, out parentNumberOfFrames, data);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueProcessingTapGetSourceAudio(IntPtr inAQTap, uint inNumberFrames, ref AudioTimeStamp ioTimeStamp, out AudioQueueProcessingTapFlags outFlags, out uint outNumberFrames, IntPtr ioData);

	public AudioQueueStatus GetSourceAudio(uint numberOfFrames, ref AudioTimeStamp timeStamp, out AudioQueueProcessingTapFlags flags, out uint parentNumberOfFrames, AudioBuffers data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return AudioQueueProcessingTapGetSourceAudio(TapHandle, numberOfFrames, ref timeStamp, out flags, out parentNumberOfFrames, (IntPtr)data);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueProcessingTapGetQueueTime(IntPtr inAQTap, out double outQueueSampleTime, out uint outQueueFrameCount);

	public AudioQueueStatus GetQueueTime(out double sampleTime, out uint frameCount)
	{
		return AudioQueueProcessingTapGetQueueTime(TapHandle, out sampleTime, out frameCount);
	}

	[MonoPInvokeCallback(typeof(AudioQueueProcessingTapCallbackShared))]
	private static void TapCallback(IntPtr clientData, IntPtr tap, uint numberFrames, ref AudioTimeStamp timeStamp, ref AudioQueueProcessingTapFlags flags, out uint outNumberFrames, IntPtr data)
	{
		AudioQueueProcessingTap audioQueueProcessingTap = (AudioQueueProcessingTap)GCHandle.FromIntPtr(clientData).Target;
		outNumberFrames = audioQueueProcessingTap.callback(audioQueueProcessingTap, numberFrames, ref timeStamp, ref flags, new AudioBuffers(data));
	}
}
