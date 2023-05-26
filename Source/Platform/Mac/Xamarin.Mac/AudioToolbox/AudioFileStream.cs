using System;
using System.Runtime.InteropServices;
using Foundation;

namespace AudioToolbox;

public class AudioFileStream : IDisposable
{
	private delegate void AudioFileStream_PropertyListenerProc(IntPtr clientData, IntPtr audioFileStream, AudioFileStreamProperty propertyID, ref AudioFileStreamPropertyFlag ioFlags);

	private delegate void AudioFileStream_PacketsProc(IntPtr clientData, int numberBytes, int numberPackets, IntPtr inputData, IntPtr packetDescriptions);

	private IntPtr handle;

	private GCHandle gch;

	private static readonly AudioFileStream_PacketsProc dInPackets = InPackets;

	private static readonly AudioFileStream_PropertyListenerProc dPropertyListener = PropertyListener;

	public EventHandler<PacketReceivedEventArgs> PacketDecoded;

	public EventHandler<PropertyFoundEventArgs> PropertyFound;

	public bool ReadyToProducePackets => GetInt(AudioFileStreamProperty.ReadyToProducePackets) == 1;

	public AudioFileType FileType => (AudioFileType)GetInt(AudioFileStreamProperty.FileFormat);

	[Advice("Use DataFormat")]
	public AudioStreamBasicDescription StreamBasicDescription => DataFormat;

	public AudioStreamBasicDescription DataFormat => GetProperty<AudioStreamBasicDescription>(AudioFileStreamProperty.DataFormat) ?? default(AudioStreamBasicDescription);

	public unsafe AudioFormat[] FormatList
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileStreamProperty.FormatList, out size);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			AudioFormat* ptr = (AudioFormat*)(void*)property;
			int num = sizeof(AudioFormat);
			int num2 = size / num;
			AudioFormat[] array = new AudioFormat[num2];
			for (int i = 0; i < num2; i++)
			{
				array[i] = ptr[i];
			}
			Marshal.FreeHGlobal(property);
			return array;
		}
	}

	public AudioFilePacketTableInfo? PacketTableInfo => GetProperty<AudioFilePacketTableInfo>(AudioFileStreamProperty.PacketTableInfo);

	public byte[] MagicCookie
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileStreamProperty.MagicCookieData, out size);
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
	}

	public long DataByteCount => GetLong(AudioFileStreamProperty.AudioDataByteCount);

	public long DataPacketCount => GetLong(AudioFileStreamProperty.AudioDataPacketCount);

	public int MaximumPacketSize => GetInt(AudioFileStreamProperty.MaximumPacketSize);

	public long DataOffset => GetLong(AudioFileStreamProperty.DataOffset);

	public AudioChannelLayout ChannelLayout
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileStreamProperty.ChannelLayout, out size);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			AudioChannelLayout result = AudioChannelLayout.FromHandle(property);
			Marshal.FreeHGlobal(property);
			return result;
		}
	}

	public int BitRate => GetInt(AudioFileStreamProperty.BitRate);

	public int PacketSizeUpperBound => GetInt(AudioFileStreamProperty.PacketSizeUpperBound);

	public double AverageBytesPerPacket => GetDouble(AudioFileStreamProperty.AverageBytesPerPacket);

	public AudioFileStreamStatus LastError { get; private set; }

	~AudioFileStream()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void Close()
	{
		Dispose();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && gch.IsAllocated)
		{
			gch.Free();
		}
		if (handle != IntPtr.Zero)
		{
			AudioFileStreamClose(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileStreamOpen(IntPtr clientData, AudioFileStream_PropertyListenerProc propertyListenerProc, AudioFileStream_PacketsProc packetsProc, AudioFileType fileTypeHint, out IntPtr file_id);

	[MonoPInvokeCallback(typeof(AudioFileStream_PacketsProc))]
	private static void InPackets(IntPtr clientData, int numberBytes, int numberPackets, IntPtr inputData, IntPtr packetDescriptions)
	{
		AudioFileStream obj = GCHandle.FromIntPtr(clientData).Target as AudioFileStream;
		AudioStreamPacketDescription[] packetDescriptions2 = AudioFile.PacketDescriptionFrom(numberPackets, packetDescriptions);
		obj.OnPacketDecoded(numberBytes, inputData, packetDescriptions2);
	}

	protected virtual void OnPacketDecoded(int numberOfBytes, IntPtr inputData, AudioStreamPacketDescription[] packetDescriptions)
	{
		PacketDecoded?.Invoke(this, new PacketReceivedEventArgs(numberOfBytes, inputData, packetDescriptions));
	}

	protected virtual void OnPropertyFound(AudioFileStreamProperty propertyID, ref AudioFileStreamPropertyFlag ioFlags)
	{
		EventHandler<PropertyFoundEventArgs> propertyFound = PropertyFound;
		if (propertyFound != null)
		{
			PropertyFoundEventArgs propertyFoundEventArgs = new PropertyFoundEventArgs(propertyID, ioFlags);
			propertyFound(this, propertyFoundEventArgs);
			ioFlags = propertyFoundEventArgs.Flags;
		}
	}

	[MonoPInvokeCallback(typeof(AudioFileStream_PropertyListenerProc))]
	private static void PropertyListener(IntPtr clientData, IntPtr audioFileStream, AudioFileStreamProperty propertyID, ref AudioFileStreamPropertyFlag ioFlags)
	{
		(GCHandle.FromIntPtr(clientData).Target as AudioFileStream).OnPropertyFound(propertyID, ref ioFlags);
	}

	public AudioFileStream(AudioFileType fileTypeHint)
	{
		gch = GCHandle.Alloc(this);
		IntPtr file_id;
		int num = AudioFileStreamOpen(GCHandle.ToIntPtr(gch), dPropertyListener, dInPackets, fileTypeHint, out file_id);
		if (num == 0)
		{
			handle = file_id;
			return;
		}
		throw new Exception($"Unable to create AudioFileStream, code: 0x{num:x}");
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamParseBytes(IntPtr inAudioFileStream, int inDataByteSize, IntPtr inData, uint inFlags);

	public AudioFileStreamStatus ParseBytes(int size, IntPtr data, bool discontinuity)
	{
		return LastError = AudioFileStreamParseBytes(handle, size, data, discontinuity ? 1u : 0u);
	}

	public unsafe AudioFileStreamStatus ParseBytes(byte[] bytes, bool discontinuity)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		fixed (byte* ptr = &bytes[0])
		{
			return LastError = AudioFileStreamParseBytes(handle, bytes.Length, (IntPtr)ptr, discontinuity ? 1u : 0u);
		}
	}

	public unsafe AudioFileStreamStatus ParseBytes(byte[] bytes, int offset, int count, bool discontinuity)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (offset < 0)
		{
			throw new ArgumentException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentException("count");
		}
		if (offset + count > bytes.Length)
		{
			throw new ArgumentException("offset+count");
		}
		fixed (byte* ptr = &bytes[0])
		{
			return LastError = AudioFileStreamParseBytes(handle, count, (IntPtr)(ptr + offset), discontinuity ? 1u : 0u);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamSeek(IntPtr inAudioFileStream, long inPacketOffset, out long outDataByteOffset, ref int ioFlags);

	public AudioFileStreamStatus Seek(long packetOffset, out long dataByteOffset, out bool isEstimate)
	{
		int ioFlags = 0;
		LastError = AudioFileStreamSeek(handle, packetOffset, out dataByteOffset, ref ioFlags);
		if (LastError != 0)
		{
			isEstimate = false;
		}
		else
		{
			isEstimate = (ioFlags & 1) == 1;
		}
		return LastError;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamGetPropertyInfo(IntPtr inAudioFileStream, AudioFileStreamProperty inPropertyID, out int outPropertyDataSize, out int isWritable);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamGetProperty(IntPtr inAudioFileStream, AudioFileStreamProperty inPropertyID, ref int ioPropertyDataSize, IntPtr outPropertyData);

	public bool GetProperty(AudioFileStreamProperty property, ref int dataSize, IntPtr outPropertyData)
	{
		return AudioFileStreamGetProperty(handle, property, ref dataSize, outPropertyData) == AudioFileStreamStatus.Ok;
	}

	public IntPtr GetProperty(AudioFileStreamProperty property, out int size)
	{
		LastError = AudioFileStreamGetPropertyInfo(handle, property, out size, out var _);
		if (LastError != 0)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		LastError = AudioFileStreamGetProperty(handle, property, ref size, intPtr);
		if (LastError == AudioFileStreamStatus.Ok)
		{
			return intPtr;
		}
		Marshal.FreeHGlobal(intPtr);
		return IntPtr.Zero;
	}

	private unsafe int GetInt(AudioFileStreamProperty property)
	{
		int result = 0;
		int ioPropertyDataSize = 4;
		LastError = AudioFileStreamGetProperty(handle, property, ref ioPropertyDataSize, (IntPtr)(&result));
		if (LastError == AudioFileStreamStatus.Ok)
		{
			return result;
		}
		return 0;
	}

	private unsafe double GetDouble(AudioFileStreamProperty property)
	{
		double result = 0.0;
		int ioPropertyDataSize = 8;
		LastError = AudioFileStreamGetProperty(handle, property, ref ioPropertyDataSize, (IntPtr)(&result));
		if (LastError == AudioFileStreamStatus.Ok)
		{
			return result;
		}
		return 0.0;
	}

	private unsafe long GetLong(AudioFileStreamProperty property)
	{
		long result = 0L;
		int ioPropertyDataSize = 8;
		LastError = AudioFileStreamGetProperty(handle, property, ref ioPropertyDataSize, (IntPtr)(&result));
		if (LastError == AudioFileStreamStatus.Ok)
		{
			return result;
		}
		return 0L;
	}

	private T? GetProperty<T>(AudioFileStreamProperty property) where T : struct
	{
		LastError = AudioFileStreamGetPropertyInfo(handle, property, out var outPropertyDataSize, out var _);
		if (LastError != 0)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(outPropertyDataSize);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			LastError = AudioFileStreamGetProperty(handle, property, ref outPropertyDataSize, intPtr);
			if (LastError == AudioFileStreamStatus.Ok)
			{
				return (T)Marshal.PtrToStructure(intPtr, typeof(T));
			}
			return null;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamSetProperty(IntPtr inAudioFileStream, AudioFileStreamProperty inPropertyID, int inPropertyDataSize, IntPtr inPropertyData);

	public bool SetProperty(AudioFileStreamProperty property, int dataSize, IntPtr propertyData)
	{
		LastError = AudioFileStreamSetProperty(handle, property, dataSize, propertyData);
		return LastError == AudioFileStreamStatus.Ok;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileStreamStatus AudioFileStreamClose(IntPtr inAudioFileStream);

	public unsafe long PacketToFrame(long packet)
	{
		AudioFramePacketTranslation audioFramePacketTranslation = default(AudioFramePacketTranslation);
		audioFramePacketTranslation.Packet = packet;
		AudioFramePacketTranslation* ptr = &audioFramePacketTranslation;
		int ioPropertyDataSize = sizeof(AudioFramePacketTranslation);
		LastError = AudioFileStreamGetProperty(handle, AudioFileStreamProperty.PacketToFrame, ref ioPropertyDataSize, (IntPtr)ptr);
		if (LastError == AudioFileStreamStatus.Ok)
		{
			return audioFramePacketTranslation.Frame;
		}
		return -1L;
	}

	public unsafe long FrameToPacket(long frame, out int frameOffsetInPacket)
	{
		AudioFramePacketTranslation audioFramePacketTranslation = default(AudioFramePacketTranslation);
		audioFramePacketTranslation.Frame = frame;
		AudioFramePacketTranslation* ptr = &audioFramePacketTranslation;
		int ioPropertyDataSize = sizeof(AudioFramePacketTranslation);
		LastError = AudioFileStreamGetProperty(handle, AudioFileStreamProperty.FrameToPacket, ref ioPropertyDataSize, (IntPtr)ptr);
		if (LastError == AudioFileStreamStatus.Ok)
		{
			frameOffsetInPacket = audioFramePacketTranslation.FrameOffsetInPacket;
			return audioFramePacketTranslation.Packet;
		}
		frameOffsetInPacket = 0;
		return -1L;
	}

	public unsafe long PacketToByte(long packet, out bool isEstimate)
	{
		AudioBytePacketTranslation audioBytePacketTranslation = default(AudioBytePacketTranslation);
		audioBytePacketTranslation.Packet = packet;
		AudioBytePacketTranslation* ptr = &audioBytePacketTranslation;
		int ioPropertyDataSize = sizeof(AudioBytePacketTranslation);
		LastError = AudioFileStreamGetProperty(handle, AudioFileStreamProperty.PacketToByte, ref ioPropertyDataSize, (IntPtr)ptr);
		if (LastError == AudioFileStreamStatus.Ok)
		{
			isEstimate = (audioBytePacketTranslation.Flags & BytePacketTranslationFlags.IsEstimate) != 0;
			return audioBytePacketTranslation.Byte;
		}
		isEstimate = false;
		return -1L;
	}

	public unsafe long ByteToPacket(long byteval, out int byteOffsetInPacket, out bool isEstimate)
	{
		AudioBytePacketTranslation audioBytePacketTranslation = default(AudioBytePacketTranslation);
		audioBytePacketTranslation.Byte = byteval;
		AudioBytePacketTranslation* ptr = &audioBytePacketTranslation;
		int ioPropertyDataSize = sizeof(AudioBytePacketTranslation);
		LastError = AudioFileStreamGetProperty(handle, AudioFileStreamProperty.ByteToPacket, ref ioPropertyDataSize, (IntPtr)ptr);
		if (LastError == AudioFileStreamStatus.Ok)
		{
			isEstimate = (audioBytePacketTranslation.Flags & BytePacketTranslationFlags.IsEstimate) != 0;
			byteOffsetInPacket = audioBytePacketTranslation.ByteOffsetInPacket;
			return audioBytePacketTranslation.Packet;
		}
		byteOffsetInPacket = 0;
		isEstimate = false;
		return -1L;
	}
}
