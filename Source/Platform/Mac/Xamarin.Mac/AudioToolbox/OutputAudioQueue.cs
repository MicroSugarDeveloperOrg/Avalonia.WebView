using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace AudioToolbox;

public class OutputAudioQueue : AudioQueue
{
	private static readonly AudioQueueOutputCallback dOutputCallback = output_callback;

	public event EventHandler<BufferCompletedEventArgs> BufferCompleted;

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueNewOutput(ref AudioStreamBasicDescription format, AudioQueueOutputCallback callback, IntPtr userData, IntPtr cfrunLoop_callbackRunloop, IntPtr cfstr_runMode, uint flags, out IntPtr audioQueue);

	[MonoPInvokeCallback(typeof(AudioQueueOutputCallback))]
	private static void output_callback(IntPtr userData, IntPtr AQ, IntPtr audioQueueBuffer)
	{
		OutputAudioQueue outputAudioQueue = GCHandle.FromIntPtr(userData).Target as OutputAudioQueue;
		outputAudioQueue.OnBufferCompleted(audioQueueBuffer);
	}

	protected virtual void OnBufferCompleted(IntPtr audioQueueBuffer)
	{
		this.BufferCompleted?.Invoke(this, new BufferCompletedEventArgs(audioQueueBuffer));
	}

	public OutputAudioQueue(AudioStreamBasicDescription desc)
		: this(desc, (CFRunLoop)null, (CFString)null)
	{
	}

	public OutputAudioQueue(AudioStreamBasicDescription desc, CFRunLoop runLoop, string runMode)
		: this(desc, runLoop, (runMode == null) ? null : new CFString(runMode))
	{
	}

	public OutputAudioQueue(AudioStreamBasicDescription desc, CFRunLoop runLoop, CFString runMode)
	{
		GCHandle value = GCHandle.Alloc(this);
		IntPtr audioQueue;
		int num = AudioQueueNewOutput(ref desc, dOutputCallback, GCHandle.ToIntPtr(value), (runLoop == null) ? IntPtr.Zero : runLoop.Handle, runMode?.Handle ?? IntPtr.Zero, 0u, out audioQueue);
		if (num != 0)
		{
			value.Free();
			throw new AudioQueueException(num);
		}
		gch = value;
		handle = audioQueue;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", EntryPoint = "AudioQueueSetOfflineRenderFormat")]
	private static extern AudioQueueStatus AudioQueueSetOfflineRenderFormat2(IntPtr aq, IntPtr format, IntPtr layout);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueSetOfflineRenderFormat(IntPtr aq, ref AudioStreamBasicDescription format, IntPtr layout);

	public AudioQueueStatus SetOfflineRenderFormat(AudioStreamBasicDescription desc, AudioChannelLayout layout)
	{
		int size;
		IntPtr intPtr = layout?.ToBlock(out size) ?? IntPtr.Zero;
		try
		{
			return AudioQueueSetOfflineRenderFormat(handle, ref desc, intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public AudioQueueStatus DisableOfflineRender()
	{
		return AudioQueueSetOfflineRenderFormat2(handle, IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern AudioQueueStatus AudioQueueOfflineRender(IntPtr aq, ref AudioTimeStamp stamp, AudioQueueBuffer* buffer, int frames);

	public unsafe AudioQueueStatus RenderOffline(double timeStamp, AudioQueueBuffer* audioQueueBuffer, int frameCount)
	{
		if (audioQueueBuffer == null)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		AudioTimeStamp audioTimeStamp = default(AudioTimeStamp);
		audioTimeStamp.SampleTime = timeStamp;
		audioTimeStamp.Flags = AudioTimeStamp.AtsFlags.SampleTimeValid;
		AudioTimeStamp stamp = audioTimeStamp;
		return AudioQueueOfflineRender(handle, ref stamp, audioQueueBuffer, frameCount);
	}
}
