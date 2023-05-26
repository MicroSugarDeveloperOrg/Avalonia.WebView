using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;

namespace AudioUnit;

public class ExtAudioFile : IDisposable
{
	private enum PropertyIDType
	{
		FileDataFormat = 1717988724,
		ClientDataFormat = 1667657076,
		CodecManufacturer = 1668112750,
		AudioConverter = 1633906294,
		AudioFile = 1634101612,
		FileMaxPacketSize = 1718448243,
		ClientMaxPacketSize = 1668116595,
		FileLengthFrames = 593916525,
		ConverterConfig = 1633903462
	}

	private IntPtr _extAudioFile;

	public uint? ClientMaxPacketSize
	{
		get
		{
			uint ioPropertyDataSize = 4u;
			if (ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.ClientMaxPacketSize, ref ioPropertyDataSize, out uint outPropertyData) != 0)
			{
				return null;
			}
			return outPropertyData;
		}
	}

	public uint? FileMaxPacketSize
	{
		get
		{
			uint ioPropertyDataSize = 4u;
			if (ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.FileMaxPacketSize, ref ioPropertyDataSize, out uint outPropertyData) != 0)
			{
				return null;
			}
			return outPropertyData;
		}
	}

	public IntPtr? AudioFile
	{
		get
		{
			uint ioPropertyDataSize = (uint)Marshal.SizeOf(typeof(IntPtr));
			if (ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.AudioFile, ref ioPropertyDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return outPropertyData;
		}
	}

	public AudioConverter AudioConverter
	{
		get
		{
			uint ioPropertyDataSize = 4u;
			if (ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.AudioConverter, ref ioPropertyDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return new AudioConverter(outPropertyData, owns: false);
		}
	}

	public long FileLengthFrames
	{
		get
		{
			uint ioPropertyDataSize = 8u;
			long outPropertyData;
			ExtAudioFileError extAudioFileError = ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.FileLengthFrames, ref ioPropertyDataSize, out outPropertyData);
			if (extAudioFileError != 0)
			{
				throw new InvalidOperationException($"Error code:{extAudioFileError}");
			}
			return outPropertyData;
		}
	}

	public AudioStreamBasicDescription FileDataFormat
	{
		get
		{
			AudioStreamBasicDescription outPropertyData = default(AudioStreamBasicDescription);
			uint ioPropertyDataSize = (uint)Marshal.SizeOf(typeof(AudioStreamBasicDescription));
			int num = ExtAudioFileGetProperty(_extAudioFile, PropertyIDType.FileDataFormat, ref ioPropertyDataSize, ref outPropertyData);
			if (num != 0)
			{
				throw new InvalidOperationException($"Error code:{num}");
			}
			return outPropertyData;
		}
	}

	public AudioStreamBasicDescription ClientDataFormat
	{
		set
		{
			int num = ExtAudioFileSetProperty(_extAudioFile, PropertyIDType.ClientDataFormat, (uint)Marshal.SizeOf(value), ref value);
			if (num != 0)
			{
				throw new InvalidOperationException($"Error code:{num}");
			}
		}
	}

	private ExtAudioFile(IntPtr ptr)
	{
		_extAudioFile = ptr;
	}

	~ExtAudioFile()
	{
		Dispose(disposing: false);
	}

	public unsafe static ExtAudioFile OpenUrl(CFUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = default(IntPtr);
		ExtAudioFileError extAudioFileError = ExtAudioFileOpenUrl(url.Handle, (IntPtr)(&intPtr));
		if (extAudioFileError != 0)
		{
			throw new ArgumentException($"Error code:{extAudioFileError}");
		}
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException("Can not get object instance");
		}
		return new ExtAudioFile(intPtr);
	}

	public unsafe static ExtAudioFile CreateWithUrl(CFUrl url, AudioFileType fileType, AudioStreamBasicDescription inStreamDesc, AudioFileFlags flag)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = default(IntPtr);
		int num = ExtAudioFileCreateWithUrl(url.Handle, fileType, ref inStreamDesc, IntPtr.Zero, (uint)flag, (IntPtr)(&intPtr));
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException("Can not get object instance");
		}
		return new ExtAudioFile(intPtr);
	}

	public unsafe static ExtAudioFileError WrapAudioFileID(IntPtr audioFileID, bool forWriting, out ExtAudioFile outAudioFile)
	{
		IntPtr ptr = default(IntPtr);
		ExtAudioFileError extAudioFileError = ExtAudioFileWrapAudioFileID(audioFileID, forWriting, (IntPtr)(&ptr));
		if (extAudioFileError != 0)
		{
			outAudioFile = null;
			return extAudioFileError;
		}
		outAudioFile = new ExtAudioFile(ptr);
		return extAudioFileError;
	}

	public void Seek(long frameOffset)
	{
		int num = ExtAudioFileSeek(_extAudioFile, frameOffset);
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
	}

	public long FileTell()
	{
		long outFrameOffset = 0L;
		int num = ExtAudioFileTell(_extAudioFile, ref outFrameOffset);
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
		return outFrameOffset;
	}

	[Obsolete("Use overload with AudioBuffers")]
	public int Read(int numberFrames, AudioBufferList data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		int num = ExtAudioFileRead(_extAudioFile, ref numberFrames, data);
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
		return numberFrames;
	}

	public uint Read(uint numberFrames, AudioBuffers audioBufferList, out ExtAudioFileError status)
	{
		if (audioBufferList == null)
		{
			throw new ArgumentNullException("audioBufferList");
		}
		status = ExtAudioFileRead(_extAudioFile, ref numberFrames, (IntPtr)audioBufferList);
		return numberFrames;
	}

	[Obsolete("Use overload with AudioBuffers")]
	public void WriteAsync(int numberFrames, AudioBufferList data)
	{
		int num = ExtAudioFileWriteAsync(_extAudioFile, numberFrames, data);
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
	}

	public ExtAudioFileError WriteAsync(uint numberFrames, AudioBuffers audioBufferList)
	{
		if (audioBufferList == null)
		{
			throw new ArgumentNullException("audioBufferList");
		}
		return ExtAudioFileWriteAsync(_extAudioFile, numberFrames, (IntPtr)audioBufferList);
	}

	public ExtAudioFileError Write(uint numberFrames, AudioBuffers audioBufferList)
	{
		if (audioBufferList == null)
		{
			throw new ArgumentNullException("audioBufferList");
		}
		return ExtAudioFileWrite(_extAudioFile, numberFrames, (IntPtr)audioBufferList);
	}

	public ExtAudioFileError SynchronizeAudioConverter()
	{
		IntPtr zero = IntPtr.Zero;
		return ExtAudioFileSetProperty(_extAudioFile, PropertyIDType.ConverterConfig, Marshal.SizeOf(zero), zero);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_extAudioFile != IntPtr.Zero)
		{
			ExtAudioFileDispose(_extAudioFile);
			_extAudioFile = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", EntryPoint = "ExtAudioFileOpenURL")]
	private static extern ExtAudioFileError ExtAudioFileOpenUrl(IntPtr inUrl, IntPtr outExtAudioFile);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileWrapAudioFileID(IntPtr inFileID, bool inForWriting, IntPtr outExtAudioFile);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[Obsolete]
	private static extern int ExtAudioFileRead(IntPtr inExtAudioFile, ref int ioNumberFrames, AudioBufferList ioData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileRead(IntPtr inExtAudioFile, ref uint ioNumberFrames, IntPtr ioData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileWrite(IntPtr inExtAudioFile, uint inNumberFrames, IntPtr ioData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[Obsolete]
	private static extern int ExtAudioFileWriteAsync(IntPtr inExtAudioFile, int inNumberFrames, AudioBufferList ioData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileWriteAsync(IntPtr inExtAudioFile, uint inNumberFrames, IntPtr ioData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileDispose(IntPtr inExtAudioFile);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileSeek(IntPtr inExtAudioFile, long inFrameOffset);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileTell(IntPtr inExtAudioFile, ref long outFrameOffset);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", EntryPoint = "ExtAudioFileCreateWithURL")]
	private static extern int ExtAudioFileCreateWithUrl(IntPtr inURL, [MarshalAs(UnmanagedType.U4)] AudioFileType inFileType, ref AudioStreamBasicDescription inStreamDesc, IntPtr inChannelLayout, uint flags, IntPtr outExtAudioFile);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileGetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, ref uint ioPropertyDataSize, IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileGetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, ref uint ioPropertyDataSize, ref AudioStreamBasicDescription outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileGetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, ref uint ioPropertyDataSize, out IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileGetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, ref uint ioPropertyDataSize, out long outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileGetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, ref uint ioPropertyDataSize, out uint outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern ExtAudioFileError ExtAudioFileSetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, int ioPropertyDataSize, IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int ExtAudioFileSetProperty(IntPtr inExtAudioFile, PropertyIDType inPropertyID, uint ioPropertyDataSize, ref AudioStreamBasicDescription outPropertyData);
}
