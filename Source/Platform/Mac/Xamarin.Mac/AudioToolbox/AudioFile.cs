using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AudioToolbox;

public class AudioFile : IDisposable
{
	protected internal IntPtr handle;

	public IntPtr Handle => handle;

	public long Length => GetLong(AudioFileProperty.AudioDataByteCount);

	public AudioFileType FileType => (AudioFileType)GetInt(AudioFileProperty.FileFormat);

	[Advice("Use DataFormat instead")]
	public AudioStreamBasicDescription StreamBasicDescription => GetProperty<AudioStreamBasicDescription>(AudioFileProperty.DataFormat) ?? default(AudioStreamBasicDescription);

	public AudioStreamBasicDescription? DataFormat => GetProperty<AudioStreamBasicDescription>(AudioFileProperty.DataFormat);

	public unsafe AudioFormat[] AudioFormats
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileProperty.FormatList, out size);
			AudioFormat* ptr = (AudioFormat*)(void*)property;
			if (property == IntPtr.Zero)
			{
				return null;
			}
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

	public bool IsOptimized => GetInt(AudioFileProperty.IsOptimized) == 1;

	public unsafe byte[] MagicCookie
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileProperty.MagicCookieData, out size);
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
			fixed (byte* ptr = &value[0])
			{
				SetProperty(AudioFileProperty.MagicCookieData, value.Length, (IntPtr)ptr);
			}
		}
	}

	public long DataPacketCount => GetLong(AudioFileProperty.AudioDataPacketCount);

	public int MaximumPacketSize => GetInt(AudioFileProperty.MaximumPacketSize);

	public long DataOffset => GetLong(AudioFileProperty.DataOffset);

	public NSData AlbumArtwork => (NSData)Runtime.GetNSObject(GetIntPtr(AudioFileProperty.AlbumArtwork));

	public AudioChannelLayout ChannelLayout
	{
		get
		{
			int size;
			IntPtr property = GetProperty(AudioFileProperty.ChannelLayout, out size);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			AudioChannelLayout result = AudioChannelLayout.FromHandle(property);
			Marshal.FreeHGlobal(property);
			return result;
		}
	}

	public bool DeferSizeUpdates
	{
		get
		{
			return GetInt(AudioFileProperty.DeferSizeUpdates) == 1;
		}
		set
		{
			SetInt(AudioFileProperty.DeferSizeUpdates, value ? 1 : 0);
		}
	}

	public int BitRate => GetInt(AudioFileProperty.BitRate);

	public double EstimatedDuration => GetDouble(AudioFileProperty.EstimatedDuration);

	public int PacketSizeUpperBound => GetInt(AudioFileProperty.PacketSizeUpperBound);

	public double ReserveDuration => GetDouble(AudioFileProperty.ReserveDuration);

	public AudioFileMarkerList MarkerList
	{
		get
		{
			GetPropertyInfo(AudioFileProperty.MarkerList, out var size, out var _);
			if (size == 0)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(size);
			if (AudioFileGetProperty(handle, AudioFileProperty.MarkerList, ref size, intPtr) != 0)
			{
				Marshal.FreeHGlobal(intPtr);
				return null;
			}
			return new AudioFileMarkerList(intPtr, owns: true);
		}
	}

	public AudioFileRegionList RegionList
	{
		get
		{
			GetPropertyInfo(AudioFileProperty.RegionList, out var size, out var _);
			if (size == 0)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(size);
			if (AudioFileGetProperty(handle, AudioFileProperty.RegionList, ref size, intPtr) != 0)
			{
				Marshal.FreeHGlobal(intPtr);
				return null;
			}
			return new AudioFileRegionList(intPtr, owns: true);
		}
	}

	public unsafe AudioFilePacketTableInfo? PacketTableInfo
	{
		get
		{
			return GetProperty<AudioFilePacketTableInfo>(AudioFileProperty.PacketTableInfo);
		}
		set
		{
			if (!value.HasValue)
			{
				throw new ArgumentNullException("value");
			}
			AudioFilePacketTableInfo propertyData = value.Value;
			AudioFileError audioFileError = AudioFileSetProperty(handle, AudioFileProperty.PacketTableInfo, sizeof(AudioFilePacketTableInfo), ref propertyData);
			if (audioFileError != 0)
			{
				throw new ArgumentException(audioFileError.ToString());
			}
		}
	}

	public unsafe AudioFileChunkType[] ChunkIDs
	{
		get
		{
			GetPropertyInfo(AudioFileProperty.ChunkIDs, out var size, out var _);
			if (size == 0)
			{
				return null;
			}
			AudioFileChunkType[] array = new AudioFileChunkType[size / 4];
			fixed (AudioFileChunkType* ptr = array)
			{
				if (AudioFileGetProperty(handle, AudioFileProperty.ChunkIDs, ref size, (IntPtr)ptr) != 0)
				{
					return null;
				}
				return array;
			}
		}
	}

	public unsafe byte[] ID3Tag
	{
		get
		{
			GetPropertyInfo(AudioFileProperty.ID3Tag, out var size, out var _);
			if (size == 0)
			{
				return null;
			}
			byte[] array = new byte[size];
			fixed (byte* ptr = array)
			{
				if (AudioFileGetProperty(handle, AudioFileProperty.ID3Tag, ref size, (IntPtr)ptr) != 0)
				{
					return null;
				}
				return array;
			}
		}
	}

	public AudioFileInfoDictionary InfoDictionary
	{
		get
		{
			IntPtr intPtr = GetIntPtr(AudioFileProperty.InfoDictionary);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new AudioFileInfoDictionary(new NSMutableDictionary(intPtr, owns: true));
		}
	}

	protected internal AudioFile(bool x)
	{
	}

	internal AudioFile(IntPtr handle)
	{
		this.handle = handle;
	}

	~AudioFile()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileClose(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			AudioFileClose(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileCreateWithURL(IntPtr cfurlref_infile, AudioFileType inFileType, ref AudioStreamBasicDescription inFormat, AudioFileFlags inFlags, out IntPtr file_id);

	public static AudioFile Create(string url, AudioFileType fileType, AudioStreamBasicDescription format, AudioFileFlags inFlags)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		using CFUrl url2 = CFUrl.FromUrlString(url, null);
		return Create(url2, fileType, format, inFlags);
	}

	public static AudioFile Create(CFUrl url, AudioFileType fileType, AudioStreamBasicDescription format, AudioFileFlags inFlags)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (AudioFileCreateWithURL(url.Handle, fileType, ref format, inFlags, out var file_id) == 0)
		{
			return new AudioFile(file_id);
		}
		return null;
	}

	public static AudioFile Create(NSUrl url, AudioFileType fileType, AudioStreamBasicDescription format, AudioFileFlags inFlags)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (AudioFileCreateWithURL(url.Handle, fileType, ref format, inFlags, out var file_id) == 0)
		{
			return new AudioFile(file_id);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileOpenURL(IntPtr cfurlref_infile, byte permissions, AudioFileType fileTypeHint, out IntPtr file_id);

	public static AudioFile OpenRead(string url, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		return Open(url, AudioFilePermission.Read, fileTypeHint);
	}

	public static AudioFile OpenRead(CFUrl url, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		return Open(url, AudioFilePermission.Read, fileTypeHint);
	}

	public static AudioFile OpenRead(NSUrl url, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		return Open(url, AudioFilePermission.Read, fileTypeHint);
	}

	public static AudioFile Open(string url, AudioFilePermission permissions, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		using CFUrl url2 = CFUrl.FromUrlString(url, null);
		return Open(url2, permissions, fileTypeHint);
	}

	public static AudioFile Open(CFUrl url, AudioFilePermission permissions, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (AudioFileOpenURL(url.Handle, (byte)permissions, fileTypeHint, out var file_id) == 0)
		{
			return new AudioFile(file_id);
		}
		return null;
	}

	public static AudioFile Open(NSUrl url, AudioFilePermission permissions, AudioFileType fileTypeHint = (AudioFileType)0)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (AudioFileOpenURL(url.Handle, (byte)permissions, fileTypeHint, out var file_id) == 0)
		{
			return new AudioFile(file_id);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileOptimize(IntPtr handle);

	public bool Optimize()
	{
		return AudioFileOptimize(handle) == 0;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileReadBytes(IntPtr inAudioFile, bool useCache, long startingByte, ref int numBytes, IntPtr outBuffer);

	public unsafe int Read(long startingByte, byte[] buffer, int offset, int count, bool useCache)
	{
		if (offset < 0)
		{
			throw new ArgumentException("offset", "<0");
		}
		if (count < 0)
		{
			throw new ArgumentException("count", "<0");
		}
		if (startingByte < 0)
		{
			throw new ArgumentException("startingByte", "<0");
		}
		int num = buffer.Length;
		if (offset > num)
		{
			throw new ArgumentException("destination offset is beyond array size");
		}
		if (offset > num - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		fixed (byte* ptr = &buffer[offset])
		{
			switch (AudioFileReadBytes(handle, useCache, startingByte, ref count, (IntPtr)ptr))
			{
			case -39:
				if (count > 0)
				{
					return count;
				}
				return -1;
			case 0:
				return count;
			default:
				return -1;
			}
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileWriteBytes(IntPtr audioFile, bool useCache, long startingByte, ref int numBytes, IntPtr buffer);

	public unsafe int Write(long startingByte, byte[] buffer, int offset, int count, bool useCache)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "< 0");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "< 0");
		}
		if (offset > buffer.Length - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		fixed (byte* ptr = &buffer[offset])
		{
			if (AudioFileWriteBytes(handle, useCache, startingByte, ref count, (IntPtr)ptr) == 0)
			{
				return count;
			}
			return -1;
		}
	}

	public unsafe int Write(long startingByte, byte[] buffer, int offset, int count, bool useCache, out int errorCode)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "< 0");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "< 0");
		}
		if (offset > buffer.Length - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		fixed (byte* ptr = &buffer[offset])
		{
			errorCode = AudioFileWriteBytes(handle, useCache, startingByte, ref count, (IntPtr)ptr);
			if (errorCode == 0)
			{
				return count;
			}
			return -1;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileReadPacketData(IntPtr audioFile, bool useCache, ref int numBytes, AudioStreamPacketDescription[] packetDescriptions, long inStartingPacket, ref int numPackets, IntPtr outBuffer);

	public AudioStreamPacketDescription[] ReadPacketData(long inStartingPacket, int nPackets, byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int count = buffer.Length;
		return RealReadPacketData(useCache: false, inStartingPacket, ref nPackets, buffer, 0, ref count);
	}

	public AudioStreamPacketDescription[] ReadPacketData(bool useCache, long inStartingPacket, int nPackets, byte[] buffer, int offset, int count)
	{
		return ReadPacketData(useCache, inStartingPacket, ref nPackets, buffer, offset, ref count);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileError AudioFileReadPackets(IntPtr inAudioFile, bool inUseCache, out int numBytes, [MarshalAs(UnmanagedType.LPArray)] AudioStreamPacketDescription[] packetDescriptions, long startingPacket, ref int numPackets, IntPtr buffer);

	public AudioFileError ReadPackets(bool useCache, out int numBytes, AudioStreamPacketDescription[] packetDescriptions, long startingPacket, ref int numPackets, IntPtr buffer)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentException("buffer");
		}
		return AudioFileReadPackets(handle, useCache, out numBytes, packetDescriptions, startingPacket, ref numPackets, buffer);
	}

	internal static AudioStreamPacketDescription[] PacketDescriptionFrom(int nPackets, IntPtr b)
	{
		if (b == IntPtr.Zero)
		{
			return new AudioStreamPacketDescription[0];
		}
		AudioStreamPacketDescription[] array = new AudioStreamPacketDescription[nPackets];
		int num = 0;
		for (int i = 0; i < nPackets; i++)
		{
			array[i].StartOffset = Marshal.ReadInt64(b, num);
			array[i].VariableFramesInPacket = Marshal.ReadInt32(b, num + 8);
			array[i].DataByteSize = Marshal.ReadInt32(b, num + 12);
			num += 16;
		}
		return array;
	}

	public AudioStreamPacketDescription[] ReadPacketData(bool useCache, long inStartingPacket, ref int nPackets, byte[] buffer, int offset, ref int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentException("offset", "<0");
		}
		if (count < 0)
		{
			throw new ArgumentException("count", "<0");
		}
		int num = buffer.Length;
		if (offset > num)
		{
			throw new ArgumentException("destination offset is beyond array size");
		}
		if (offset > num - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		return RealReadPacketData(useCache, inStartingPacket, ref nPackets, buffer, offset, ref count);
	}

	public AudioStreamPacketDescription[] ReadPacketData(bool useCache, long inStartingPacket, ref int nPackets, IntPtr buffer, ref int count)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count < 0)
		{
			throw new ArgumentException("count", "<0");
		}
		return RealReadPacketData(useCache, inStartingPacket, ref nPackets, buffer, ref count);
	}

	private unsafe AudioStreamPacketDescription[] RealReadPacketData(bool useCache, long inStartingPacket, ref int nPackets, byte[] buffer, int offset, ref int count)
	{
		fixed (byte* ptr = &buffer[offset])
		{
			return RealReadPacketData(useCache, inStartingPacket, ref nPackets, (IntPtr)ptr, ref count);
		}
	}

	private AudioStreamPacketDescription[] RealReadPacketData(bool useCache, long inStartingPacket, ref int nPackets, IntPtr buffer, ref int count)
	{
		AudioStreamPacketDescription[] array = new AudioStreamPacketDescription[nPackets];
		switch (AudioFileReadPacketData(handle, useCache, ref count, array, inStartingPacket, ref nPackets, buffer))
		{
		case -39:
			if (count == 0)
			{
				return null;
			}
			break;
		default:
			return null;
		case 0:
			break;
		}
		return array;
	}

	public AudioStreamPacketDescription[] ReadFixedPackets(long inStartingPacket, int nPackets, byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return RealReadFixedPackets(useCache: false, inStartingPacket, nPackets, buffer, 0, buffer.Length);
	}

	public AudioStreamPacketDescription[] ReadFixedPackets(bool useCache, long inStartingPacket, int nPackets, byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentException("offset", "<0");
		}
		if (count < 0)
		{
			throw new ArgumentException("count", "<0");
		}
		int num = buffer.Length;
		if (offset > num)
		{
			throw new ArgumentException("destination offset is beyond array size");
		}
		if (offset > num - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		return RealReadFixedPackets(useCache, inStartingPacket, nPackets, buffer, offset, count);
	}

	private unsafe AudioStreamPacketDescription[] RealReadFixedPackets(bool useCache, long inStartingPacket, int nPackets, byte[] buffer, int offset, int count)
	{
		AudioStreamPacketDescription[] array = new AudioStreamPacketDescription[nPackets];
		fixed (byte* ptr = &buffer[offset])
		{
			switch (AudioFileReadPacketData(handle, useCache, ref count, array, inStartingPacket, ref nPackets, (IntPtr)ptr))
			{
			case 0:
				break;
			case -39:
				if (count == 0)
				{
					return null;
				}
				break;
			default:
				return null;
			}
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileError AudioFileWritePackets(IntPtr audioFile, bool useCache, int inNumBytes, AudioStreamPacketDescription[] inPacketDescriptions, long inStartingPacket, ref int numPackets, IntPtr buffer);

	public int WritePackets(bool useCache, long startingPacket, int numPackets, IntPtr buffer, int count)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		if (AudioFileWritePackets(handle, useCache, count, null, startingPacket, ref numPackets, buffer) == (AudioFileError)0)
		{
			return numPackets;
		}
		return -1;
	}

	public int WritePackets(bool useCache, long startingPacket, AudioStreamPacketDescription[] packetDescriptions, IntPtr buffer, int count)
	{
		if (packetDescriptions == null)
		{
			throw new ArgumentNullException("packetDescriptions");
		}
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		int numPackets = packetDescriptions.Length;
		if (AudioFileWritePackets(handle, useCache, count, packetDescriptions, startingPacket, ref numPackets, buffer) == (AudioFileError)0)
		{
			return numPackets;
		}
		return -1;
	}

	public unsafe int WritePackets(bool useCache, long startingPacket, AudioStreamPacketDescription[] packetDescriptions, byte[] buffer, int offset, int count)
	{
		if (packetDescriptions == null)
		{
			throw new ArgumentNullException("inPacketDescriptions");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "< 0");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "< 0");
		}
		if (offset > buffer.Length - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		int numPackets = packetDescriptions.Length;
		fixed (byte* ptr = &buffer[offset])
		{
			if (AudioFileWritePackets(handle, useCache, count, packetDescriptions, startingPacket, ref numPackets, (IntPtr)ptr) == (AudioFileError)0)
			{
				return numPackets;
			}
			return -1;
		}
	}

	public int WritePackets(bool useCache, long startingPacket, AudioStreamPacketDescription[] packetDescriptions, IntPtr buffer, int count, out int errorCode)
	{
		if (packetDescriptions == null)
		{
			throw new ArgumentNullException("packetDescriptions");
		}
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentException("buffer");
		}
		int numPackets = packetDescriptions.Length;
		errorCode = (int)AudioFileWritePackets(handle, useCache, count, packetDescriptions, startingPacket, ref numPackets, buffer);
		if (errorCode == 0)
		{
			return numPackets;
		}
		return -1;
	}

	public unsafe int WritePackets(bool useCache, long startingPacket, AudioStreamPacketDescription[] packetDescriptions, byte[] buffer, int offset, int count, out int errorCode)
	{
		if (packetDescriptions == null)
		{
			throw new ArgumentNullException("inPacketDescriptions");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "< 0");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "< 0");
		}
		if (offset > buffer.Length - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		int numPackets = packetDescriptions.Length;
		fixed (byte* ptr = &buffer[offset])
		{
			errorCode = (int)AudioFileWritePackets(handle, useCache, count, packetDescriptions, startingPacket, ref numPackets, (IntPtr)ptr);
			if (errorCode == 0)
			{
				return numPackets;
			}
			return -1;
		}
	}

	public AudioFileError WritePackets(bool useCache, int numBytes, AudioStreamPacketDescription[] packetDescriptions, long startingPacket, ref int numPackets, IntPtr buffer)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentException("buffer");
		}
		return AudioFileWritePackets(handle, useCache, numBytes, packetDescriptions, startingPacket, ref numPackets, buffer);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileCountUserData(IntPtr handle, uint userData, out int count);

	public int CountUserData(uint userData)
	{
		if (AudioFileCountUserData(handle, userData, out var count) == 0)
		{
			return count;
		}
		return -1;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetUserDataSize(IntPtr audioFile, uint userDataID, int index, out int userDataSize);

	public int GetUserDataSize(uint userDataId, int index)
	{
		if (AudioFileGetUserDataSize(handle, userDataId, index, out var userDataSize) == 0)
		{
			return -1;
		}
		return userDataSize;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetUserData(IntPtr audioFile, int userDataID, int index, ref int userDataSize, IntPtr userData);

	public int GetUserData(int userDataID, int index, ref int size, IntPtr userData)
	{
		return AudioFileGetUserData(handle, userDataID, index, ref size, userData);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileSetUserData(IntPtr inAudioFile, int userDataID, int index, int userDataSize, IntPtr userData);

	public int SetUserData(int userDataId, int index, int userDataSize, IntPtr userData)
	{
		return AudioFileSetUserData(handle, userDataId, index, userDataSize, userData);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileRemoveUserData(IntPtr audioFile, int userDataID, int index);

	public int RemoveUserData(int userDataId, int index)
	{
		return AudioFileRemoveUserData(handle, userDataId, index);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetPropertyInfo(IntPtr audioFile, AudioFileProperty propertyID, out int outDataSize, out int isWritable);

	public bool GetPropertyInfo(AudioFileProperty property, out int size, out int writable)
	{
		return AudioFileGetPropertyInfo(handle, property, out size, out writable) == 0;
	}

	public bool IsPropertyWritable(AudioFileProperty property)
	{
		if (AudioFileGetPropertyInfo(handle, property, out var _, out var isWritable) == 0)
		{
			return isWritable != 0;
		}
		return false;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetProperty(IntPtr audioFile, AudioFileProperty property, ref int dataSize, IntPtr outdata);

	public bool GetProperty(AudioFileProperty property, ref int dataSize, IntPtr outdata)
	{
		return AudioFileGetProperty(handle, property, ref dataSize, outdata) == 0;
	}

	public IntPtr GetProperty(AudioFileProperty property, out int size)
	{
		if (AudioFileGetPropertyInfo(handle, property, out size, out var _) != 0)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (AudioFileGetProperty(handle, property, ref size, intPtr) == 0)
		{
			return intPtr;
		}
		Marshal.FreeHGlobal(intPtr);
		return IntPtr.Zero;
	}

	private T? GetProperty<T>(AudioFileProperty property) where T : struct
	{
		if (AudioFileGetPropertyInfo(handle, property, out var outDataSize, out var _) != 0)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(outDataSize);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			if (AudioFileGetProperty(handle, property, ref outDataSize, intPtr) == 0)
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

	private unsafe int GetInt(AudioFileProperty property)
	{
		int result = 0;
		int dataSize = 4;
		if (AudioFileGetProperty(handle, property, ref dataSize, (IntPtr)(&result)) == 0)
		{
			return result;
		}
		return 0;
	}

	private unsafe IntPtr GetIntPtr(AudioFileProperty property)
	{
		IntPtr zero = IntPtr.Zero;
		int dataSize = sizeof(IntPtr);
		if (AudioFileGetProperty(handle, property, ref dataSize, (IntPtr)(&zero)) == 0)
		{
			return zero;
		}
		return IntPtr.Zero;
	}

	private unsafe double GetDouble(AudioFileProperty property)
	{
		double result = 0.0;
		int dataSize = 8;
		if (AudioFileGetProperty(handle, property, ref dataSize, (IntPtr)(&result)) == 0)
		{
			return result;
		}
		return 0.0;
	}

	private unsafe long GetLong(AudioFileProperty property)
	{
		long result = 0L;
		int dataSize = 8;
		if (AudioFileGetProperty(handle, property, ref dataSize, (IntPtr)(&result)) == 0)
		{
			return result;
		}
		return 0L;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileError AudioFileSetProperty(IntPtr audioFile, AudioFileProperty property, int dataSize, IntPtr propertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioFileError AudioFileSetProperty(IntPtr audioFile, AudioFileProperty property, int dataSize, ref AudioFilePacketTableInfo propertyData);

	public bool SetProperty(AudioFileProperty property, int dataSize, IntPtr propertyData)
	{
		return AudioFileSetProperty(handle, property, dataSize, propertyData) == (AudioFileError)0;
	}

	private unsafe void SetInt(AudioFileProperty property, int value)
	{
		AudioFileSetProperty(handle, property, 4, (IntPtr)(&value));
	}

	private unsafe AudioFileError SetDouble(AudioFileProperty property, double value)
	{
		return AudioFileSetProperty(handle, property, 8, (IntPtr)(&value));
	}

	public unsafe long PacketToFrame(long packet)
	{
		AudioFramePacketTranslation audioFramePacketTranslation = default(AudioFramePacketTranslation);
		audioFramePacketTranslation.Packet = packet;
		AudioFramePacketTranslation* ptr = &audioFramePacketTranslation;
		int dataSize = sizeof(AudioFramePacketTranslation);
		if (AudioFileGetProperty(handle, AudioFileProperty.PacketToFrame, ref dataSize, (IntPtr)ptr) == 0)
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
		int dataSize = sizeof(AudioFramePacketTranslation);
		if (AudioFileGetProperty(handle, AudioFileProperty.FrameToPacket, ref dataSize, (IntPtr)ptr) == 0)
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
		int dataSize = sizeof(AudioBytePacketTranslation);
		if (AudioFileGetProperty(handle, AudioFileProperty.PacketToByte, ref dataSize, (IntPtr)ptr) == 0)
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
		int dataSize = sizeof(AudioBytePacketTranslation);
		if (AudioFileGetProperty(handle, AudioFileProperty.ByteToPacket, ref dataSize, (IntPtr)ptr) == 0)
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
