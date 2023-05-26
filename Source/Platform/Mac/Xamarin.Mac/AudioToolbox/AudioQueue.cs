using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace AudioToolbox;

public abstract class AudioQueue : IDisposable
{
	private delegate void AudioQueuePropertyListenerProc(IntPtr userData, IntPtr AQ, AudioQueueProperty id);

	public delegate void AudioQueuePropertyChanged(AudioQueueProperty property);

	protected internal IntPtr handle;

	protected internal GCHandle gch;

	private Dictionary<AudioQueueProperty, List<AudioQueuePropertyChanged>> listeners;

	public IntPtr Handle => handle;

	public AudioTimeStamp CurrentTime
	{
		get
		{
			AudioTimeStamp time = default(AudioTimeStamp);
			if (AudioQueueDeviceGetCurrentTime(handle, ref time) != 0)
			{
				time.Flags = (AudioTimeStamp.AtsFlags)0;
			}
			return time;
		}
	}

	public float Volume
	{
		get
		{
			float result;
			int num = AudioQueueGetParameter(handle, AudioQueueParameter.Volume, out result);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
			return result;
		}
		set
		{
			int num = AudioQueueSetParameter(handle, AudioQueueParameter.Volume, value);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
		}
	}

	public float VolumeRampTime
	{
		get
		{
			float result;
			int num = AudioQueueGetParameter(handle, AudioQueueParameter.VolumeRampTime, out result);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
			return result;
		}
		set
		{
			int num = AudioQueueSetParameter(handle, AudioQueueParameter.VolumeRampTime, value);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
		}
	}

	public float Pan
	{
		get
		{
			float result;
			int num = AudioQueueGetParameter(handle, AudioQueueParameter.Pan, out result);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
			return result;
		}
		set
		{
			int num = AudioQueueSetParameter(handle, AudioQueueParameter.Pan, value);
			if (num != 0)
			{
				throw new AudioQueueException(num);
			}
		}
	}

	public bool IsRunning => GetInt(AudioQueueProperty.IsRunning) != 0;

	public double SampleRate => GetDouble(AudioQueueProperty.DeviceSampleRate);

	public int DeviceChannels => GetInt(AudioQueueProperty.DeviceNumberChannels);

	public string CurrentDevice
	{
		get
		{
			return CFString.FetchString((IntPtr)GetInt(AudioQueueProperty.CurrentDevice));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public unsafe byte[] MagicCookie
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioQueueProperty.MagicCookie, out size);
			if (property == IntPtr.Zero)
			{
				return new byte[0];
			}
			byte[] array = new byte[size];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Marshal.ReadByte(property, i);
			}
			Marshal.FreeHGlobal(property);
			return array;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 0)
			{
				fixed (byte* ptr = &value[0])
				{
					SetProperty(AudioQueueProperty.MagicCookie, value.Length, (IntPtr)ptr);
				}
			}
		}
	}

	public AudioChannelLayout ChannelLayout
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioQueueProperty.ChannelLayout, out size);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			AudioChannelLayout result = AudioChannelLayout.FromHandle(property);
			Marshal.FreeHGlobal(property);
			return result;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int size;
			IntPtr intPtr = value.ToBlock(out size);
			SetProperty(AudioQueueProperty.ChannelLayout, size, intPtr);
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public bool EnableLevelMetering
	{
		get
		{
			return GetInt(AudioQueueProperty.EnableLevelMetering) != 0;
		}
		set
		{
			SetInt(AudioQueueProperty.EnableLevelMetering, value ? 1 : 0);
		}
	}

	public int MaximumOutputPacketSize => GetInt(AudioQueueProperty.MaximumOutputPacketSize);

	public int DecodeBufferSizeFrames => GetInt(AudioQueueProperty.DecodeBufferSizeFrames);

	public AudioStreamBasicDescription AudioStreamPacketDescription => GetProperty<AudioStreamBasicDescription>(AudioQueueProperty.StreamDescription);

	public unsafe AudioQueueLevelMeterState[] CurrentLevelMeter
	{
		get
		{
			_ = DeviceChannels;
			int size;
			IntPtr property = GetProperty(AudioQueueProperty.CurrentLevelMeter, out size);
			if (property == IntPtr.Zero)
			{
				return new AudioQueueLevelMeterState[0];
			}
			AudioQueueLevelMeterState[] array = new AudioQueueLevelMeterState[size];
			AudioQueueLevelMeterState* ptr = (AudioQueueLevelMeterState*)(void*)property;
			for (int i = 0; i < size; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public unsafe AudioQueueLevelMeterState[] CurrentLevelMeterDB
	{
		get
		{
			_ = DeviceChannels;
			int size;
			IntPtr property = GetProperty(AudioQueueProperty.CurrentLevelMeterDB, out size);
			if (property == IntPtr.Zero)
			{
				return new AudioQueueLevelMeterState[0];
			}
			AudioQueueLevelMeterState[] array = new AudioQueueLevelMeterState[size];
			AudioQueueLevelMeterState* ptr = (AudioQueueLevelMeterState*)(void*)property;
			for (int i = 0; i < size; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public uint ConverterError => (uint)GetInt(AudioQueueProperty.ConverterError);

	internal AudioQueue()
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true, immediate: true);
	}

	public void QueueDispose()
	{
		Dispose(disposing: true, immediate: false);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueDispose(IntPtr AQ, bool immediate);

	public virtual void Dispose(bool disposing, bool immediate)
	{
		if (handle != IntPtr.Zero)
		{
			if (disposing && listeners != null)
			{
				foreach (AudioQueueProperty key in listeners.Keys)
				{
					AudioQueueRemovePropertyListener(handle, key, property_changed, GCHandle.ToIntPtr(gch));
				}
			}
			AudioQueueDispose(handle, immediate);
			handle = IntPtr.Zero;
		}
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueStart(IntPtr AQ, ref AudioTimeStamp startTime);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueStart(IntPtr AQ, IntPtr startTime);

	public AudioQueueStatus Start(AudioTimeStamp startTime)
	{
		return AudioQueueStart(handle, ref startTime);
	}

	public AudioQueueStatus Start()
	{
		return AudioQueueStart(handle, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueuePrime(IntPtr AQ, int toPrepare, out int prepared);

	public AudioQueueStatus Prime(int toPrepare, out int prepared)
	{
		return AudioQueuePrime(handle, toPrepare, out prepared);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueFlush(IntPtr aq);

	public AudioQueueStatus Flush()
	{
		return AudioQueueFlush(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueStop(IntPtr aq, bool immediate);

	public AudioQueueStatus Stop(bool immediate)
	{
		return AudioQueueStop(handle, immediate);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueuePause(IntPtr aq);

	public AudioQueueStatus Pause()
	{
		return AudioQueuePause(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueReset(IntPtr aq);

	public AudioQueueStatus Reset()
	{
		return AudioQueueReset(handle);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueAllocateBuffer(IntPtr AQ, int bufferSize, out IntPtr audioQueueBuffer);

	public AudioQueueStatus AllocateBuffer(int bufferSize, out IntPtr audioQueueBuffer)
	{
		return AudioQueueAllocateBuffer(handle, bufferSize, out audioQueueBuffer);
	}

	public unsafe AudioQueueStatus AllocateBuffer(int bufferSize, out AudioQueueBuffer* audioQueueBuffer)
	{
		IntPtr audioQueueBuffer2;
		AudioQueueStatus result = AudioQueueAllocateBuffer(handle, bufferSize, out audioQueueBuffer2);
		audioQueueBuffer = (AudioQueueBuffer*)(void*)audioQueueBuffer2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueAllocateBufferWithPacketDescriptions(IntPtr AQ, int bufferSize, int nPackets, out IntPtr audioQueueBuffer);

	public AudioQueueStatus AllocateBufferWithPacketDescriptors(int bufferSize, int nPackets, out IntPtr audioQueueBuffer)
	{
		return AudioQueueAllocateBufferWithPacketDescriptions(handle, bufferSize, nPackets, out audioQueueBuffer);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueFreeBuffer(IntPtr AQ, IntPtr audioQueueBuffer);

	public void FreeBuffer(IntPtr audioQueueBuffer)
	{
		if (audioQueueBuffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		AudioQueueFreeBuffer(handle, audioQueueBuffer);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	internal unsafe static extern void memcpy(byte* target, byte* source, int n);

	public unsafe static void FillAudioData(IntPtr audioQueueBuffer, int offset, IntPtr source, int sourceOffset, int size)
	{
		byte* ptr = (byte*)(void*)Marshal.ReadIntPtr(audioQueueBuffer, 4);
		byte* ptr2 = (byte*)(void*)source;
		memcpy(ptr + offset, ptr2 + sourceOffset, size);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	internal unsafe static extern AudioQueueStatus AudioQueueEnqueueBuffer(IntPtr AQ, AudioQueueBuffer* audioQueueBuffer, int nPackets, AudioStreamPacketDescription[] desc);

	public unsafe AudioQueueStatus EnqueueBuffer(IntPtr audioQueueBuffer, int bytes, AudioStreamPacketDescription[] desc)
	{
		if (audioQueueBuffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		AudioQueueBuffer* ptr = (AudioQueueBuffer*)(void*)audioQueueBuffer;
		ptr->AudioDataByteSize = (uint)bytes;
		return EnqueueBuffer(ptr, desc);
	}

	public unsafe AudioQueueStatus EnqueueBuffer(AudioQueueBuffer* audioQueueBuffer, AudioStreamPacketDescription[] desc)
	{
		if (audioQueueBuffer == null)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		return AudioQueueEnqueueBuffer(handle, audioQueueBuffer, (desc != null) ? desc.Length : 0, desc);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern AudioQueueStatus AudioQueueEnqueueBufferWithParameters(IntPtr AQ, AudioQueueBuffer* audioQueueBuffer, int nPackets, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, int nParam, AudioQueueParameterEvent[] parameterEvents, ref AudioTimeStamp startTime, out AudioTimeStamp actualStartTime);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern AudioQueueStatus AudioQueueEnqueueBufferWithParameters(IntPtr AQ, AudioQueueBuffer* audioQueueBuffer, int nPackets, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, int nParam, AudioQueueParameterEvent[] parameterEvents, AudioTimeStamp* startTime, out AudioTimeStamp actualStartTime);

	public unsafe AudioQueueStatus EnqueueBuffer(IntPtr audioQueueBuffer, int bytes, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, AudioQueueParameterEvent[] parameterEvents, ref AudioTimeStamp startTime, out AudioTimeStamp actualStartTime)
	{
		if (audioQueueBuffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		AudioQueueBuffer* ptr = (AudioQueueBuffer*)(void*)audioQueueBuffer;
		ptr->AudioDataByteSize = (uint)bytes;
		return AudioQueueEnqueueBufferWithParameters(handle, ptr, (desc != null) ? desc.Length : 0, desc, trimFramesAtStart, trimFramesAtEnd, (parameterEvents != null) ? parameterEvents.Length : 0, parameterEvents, ref startTime, out actualStartTime);
	}

	public unsafe AudioQueueStatus EnqueueBuffer(IntPtr audioQueueBuffer, int bytes, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, AudioQueueParameterEvent[] parameterEvents, out AudioTimeStamp actualStartTime)
	{
		if (audioQueueBuffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		AudioQueueBuffer* ptr = (AudioQueueBuffer*)(void*)audioQueueBuffer;
		ptr->AudioDataByteSize = (uint)bytes;
		return AudioQueueEnqueueBufferWithParameters(handle, ptr, (desc != null) ? desc.Length : 0, desc, trimFramesAtStart, trimFramesAtEnd, (parameterEvents != null) ? parameterEvents.Length : 0, parameterEvents, null, out actualStartTime);
	}

	public unsafe AudioQueueStatus EnqueueBuffer(AudioQueueBuffer* audioQueueBuffer, int bytes, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, AudioQueueParameterEvent[] parameterEvents, ref AudioTimeStamp startTime, out AudioTimeStamp actualStartTime)
	{
		if (audioQueueBuffer == null)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		return AudioQueueEnqueueBufferWithParameters(handle, audioQueueBuffer, (desc != null) ? desc.Length : 0, desc, trimFramesAtStart, trimFramesAtEnd, (parameterEvents != null) ? parameterEvents.Length : 0, parameterEvents, ref startTime, out actualStartTime);
	}

	public unsafe AudioQueueStatus EnqueueBuffer(AudioQueueBuffer* audioQueueBuffer, int bytes, AudioStreamPacketDescription[] desc, int trimFramesAtStart, int trimFramesAtEnd, AudioQueueParameterEvent[] parameterEvents, out AudioTimeStamp actualStartTime)
	{
		if (audioQueueBuffer == null)
		{
			throw new ArgumentNullException("audioQueueBuffer");
		}
		return AudioQueueEnqueueBufferWithParameters(handle, audioQueueBuffer, (desc != null) ? desc.Length : 0, desc, trimFramesAtStart, trimFramesAtEnd, (parameterEvents != null) ? parameterEvents.Length : 0, parameterEvents, null, out actualStartTime);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueCreateTimeline(IntPtr AQ, out IntPtr timeline);

	public AudioQueueTimeline CreateTimeline()
	{
		if (AudioQueueCreateTimeline(handle, out var timeline) == AudioQueueStatus.Ok)
		{
			return new AudioQueueTimeline(handle, timeline);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueGetCurrentTime(IntPtr AQ, IntPtr timelineHandle, ref AudioTimeStamp time, ref bool discontinuty);

	public AudioQueueStatus GetCurrentTime(AudioQueueTimeline timeline, ref AudioTimeStamp time, ref bool timelineDiscontinuty)
	{
		IntPtr intPtr;
		if (timeline == null)
		{
			intPtr = IntPtr.Zero;
		}
		else
		{
			intPtr = timeline.timelineHandle;
			if (intPtr == IntPtr.Zero)
			{
				throw new ObjectDisposedException("timeline");
			}
		}
		return AudioQueueGetCurrentTime(handle, intPtr, ref time, ref timelineDiscontinuty);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueDeviceGetCurrentTime(IntPtr AQ, ref AudioTimeStamp time);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueDeviceGetNearestStartTime(IntPtr AQ, ref AudioTimeStamp data, int flags);

	public AudioTimeStamp GetNearestStartTime(AudioTimeStamp requestedStartTime)
	{
		AudioQueueStatus audioQueueStatus = AudioQueueDeviceGetNearestStartTime(handle, ref requestedStartTime, 0);
		if (audioQueueStatus != 0)
		{
			throw new AudioQueueException(audioQueueStatus);
		}
		return requestedStartTime;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueDeviceTranslateTime(IntPtr AQ, ref AudioTimeStamp inTime, out AudioTimeStamp translatedTime);

	public AudioTimeStamp TranslateTime(AudioTimeStamp timeToTranslate)
	{
		AudioQueueDeviceTranslateTime(handle, ref timeToTranslate, out var translatedTime);
		return translatedTime;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueGetParameter(IntPtr AQ, AudioQueueParameter parameterId, out float result);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueSetParameter(IntPtr AQ, AudioQueueParameter parameterId, float value);

	[MonoPInvokeCallback(typeof(AudioQueuePropertyListenerProc))]
	private static void property_changed(IntPtr userData, IntPtr AQ, AudioQueueProperty id)
	{
		AudioQueue audioQueue = GCHandle.FromIntPtr(userData).Target as AudioQueue;
		lock (audioQueue.listeners)
		{
			if (!audioQueue.listeners.TryGetValue(id, out var value))
			{
				return;
			}
			foreach (AudioQueuePropertyChanged item in value)
			{
				item(id);
			}
		}
	}

	public AudioQueueStatus AddListener(AudioQueueProperty property, AudioQueuePropertyChanged callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		if (listeners == null)
		{
			listeners = new Dictionary<AudioQueueProperty, List<AudioQueuePropertyChanged>>();
		}
		AudioQueueStatus audioQueueStatus = AudioQueueStatus.Ok;
		lock (listeners)
		{
			if (!listeners.TryGetValue(property, out var value))
			{
				audioQueueStatus = AudioQueueAddPropertyListener(handle, property, property_changed, GCHandle.ToIntPtr(gch));
				if (audioQueueStatus != 0)
				{
					return audioQueueStatus;
				}
				value = (listeners[property] = new List<AudioQueuePropertyChanged>());
			}
			value.Add(callback);
			return audioQueueStatus;
		}
	}

	public void RemoveListener(AudioQueueProperty property, AudioQueuePropertyChanged callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		if (listeners == null)
		{
			return;
		}
		lock (listeners)
		{
			if (listeners.TryGetValue(property, out var value))
			{
				value.Remove(callback);
				if (value.Count == 0)
				{
					AudioQueueRemovePropertyListener(handle, property, property_changed, GCHandle.ToIntPtr(gch));
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueAddPropertyListener(IntPtr AQ, AudioQueueProperty id, AudioQueuePropertyListenerProc proc, IntPtr data);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueRemovePropertyListener(IntPtr AQ, AudioQueueProperty id, AudioQueuePropertyListenerProc proc, IntPtr data);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueGetProperty(IntPtr AQ, AudioQueueProperty id, IntPtr outdata, ref int dataSize);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueGetPropertySize(IntPtr AQ, AudioQueueProperty id, out int size);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueSetProperty(IntPtr AQ, AudioQueueProperty id, IntPtr data, int size);

	public bool GetProperty(AudioQueueProperty property, ref int dataSize, IntPtr outdata)
	{
		return AudioQueueGetProperty(handle, property, outdata, ref dataSize) == AudioQueueStatus.Ok;
	}

	public bool SetProperty(AudioQueueProperty property, int dataSize, IntPtr propertyData)
	{
		return AudioQueueSetProperty(handle, property, propertyData, dataSize) == AudioQueueStatus.Ok;
	}

	public IntPtr GetProperty(AudioQueueProperty property, out int size)
	{
		AudioQueueStatus audioQueueStatus = AudioQueueGetPropertySize(handle, property, out size);
		if (audioQueueStatus != 0)
		{
			throw new AudioQueueException(audioQueueStatus);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (AudioQueueGetProperty(handle, property, intPtr, ref size) == AudioQueueStatus.Ok)
		{
			return intPtr;
		}
		Marshal.FreeHGlobal(intPtr);
		return IntPtr.Zero;
	}

	public T GetProperty<T>(AudioQueueProperty property) where T : struct
	{
		AudioQueueStatus audioQueueStatus = AudioQueueGetPropertySize(handle, property, out var size);
		if (audioQueueStatus != 0)
		{
			throw new AudioQueueException(audioQueueStatus);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		if (intPtr == IntPtr.Zero)
		{
			return default(T);
		}
		try
		{
			audioQueueStatus = AudioQueueGetProperty(handle, property, intPtr, ref size);
			if (audioQueueStatus == AudioQueueStatus.Ok)
			{
				return (T)Marshal.PtrToStructure(intPtr, typeof(T));
			}
			throw new AudioQueueException(audioQueueStatus);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private unsafe int GetInt(AudioQueueProperty property)
	{
		int result = 0;
		int dataSize = 4;
		AudioQueueStatus audioQueueStatus = AudioQueueGetProperty(handle, property, (IntPtr)(&result), ref dataSize);
		if (audioQueueStatus == AudioQueueStatus.Ok)
		{
			return result;
		}
		throw new AudioQueueException(audioQueueStatus);
	}

	private unsafe int SetInt(AudioQueueProperty property, int val)
	{
		int size = 4;
		AudioQueueStatus audioQueueStatus = AudioQueueSetProperty(handle, property, (IntPtr)(&val), size);
		if (audioQueueStatus == AudioQueueStatus.Ok)
		{
			return val;
		}
		throw new AudioQueueException(audioQueueStatus);
	}

	private unsafe double GetDouble(AudioQueueProperty property)
	{
		double result = 0.0;
		int dataSize = 8;
		AudioQueueStatus audioQueueStatus = AudioQueueGetProperty(handle, property, (IntPtr)(&result), ref dataSize);
		if (audioQueueStatus == AudioQueueStatus.Ok)
		{
			return result;
		}
		throw new AudioQueueException(audioQueueStatus);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueProcessingTapNew(IntPtr inAQ, AudioQueueProcessingTapCallbackShared inCallback, IntPtr inClientData, AudioQueueProcessingTapFlags inFlags, out uint outMaxFrames, out AudioStreamBasicDescription outProcessingFormat, out IntPtr outAQTap);

	[Obsolete("Use CreateProcessingTap (AudioQueueProcessingTapDelegate, AudioQueueProcessingTapFlags, out AudioQueueStatus) instead", true)]
	[Since(6, 0)]
	public AudioQueueProcessingTap CreateProcessingTap(AudioQueueProcessingTapCallback processingCallback, AudioQueueProcessingTapFlags flags, out AudioQueueStatus status)
	{
		throw new NotSupportedException();
	}

	[Since(6, 0)]
	public AudioQueueProcessingTap CreateProcessingTap(AudioQueueProcessingTapDelegate processingCallback, AudioQueueProcessingTapFlags flags, out AudioQueueStatus status)
	{
		AudioQueueProcessingTap audioQueueProcessingTap = new AudioQueueProcessingTap(processingCallback);
		status = AudioQueueProcessingTapNew(handle, AudioQueueProcessingTap.CreateTapCallback, GCHandle.ToIntPtr(audioQueueProcessingTap.Handle), flags, out var outMaxFrames, out var outProcessingFormat, out var outAQTap);
		if (status != 0)
		{
			audioQueueProcessingTap.Dispose();
			return null;
		}
		audioQueueProcessingTap.TapHandle = outAQTap;
		audioQueueProcessingTap.MaxFrames = outMaxFrames;
		audioQueueProcessingTap.ProcessingFormat = outProcessingFormat;
		return audioQueueProcessingTap;
	}
}
