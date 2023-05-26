using System;
using System.Runtime.InteropServices;
using AudioToolbox;

namespace AudioUnitWrapper;

[Obsolete("Use AudioConverter")]
public class _AudioConverter : IDisposable
{
	private delegate int AudioConverterComplexInputDataProc(IntPtr inAudioConverrter, ref uint ioNumberDataPackets, AudioBufferList ioData, ref AudioStreamPacketDescription[] outDataPacketDescription, IntPtr inUserData);

	private enum AudioConverterPropertyIDType
	{
		kAudioConverterDecompressionMagicCookie = 1684891491
	}

	private readonly GCHandle _handle;

	private IntPtr _audioConverter;

	public byte[] DecompressionMagicCookie
	{
		set
		{
			if (value != null)
			{
				AudioConverterSetProperty(_audioConverter, AudioConverterPropertyIDType.kAudioConverterDecompressionMagicCookie, (uint)value.Length, value);
			}
		}
	}

	public event EventHandler<_AudioConverterEventArgs> EncoderCallback;

	private _AudioConverter()
	{
		_handle = GCHandle.Alloc(this);
		_audioConverter = default(IntPtr);
	}

	[MonoPInvokeCallback(typeof(AudioConverterComplexInputDataProc))]
	private static int complexInputDataProc(IntPtr inAudioConverrter, ref uint ioNumberDataPackets, AudioBufferList ioData, ref AudioStreamPacketDescription[] outDataPacketDescription, IntPtr inUserData)
	{
		_AudioConverter audioConverter = (_AudioConverter)GCHandle.FromIntPtr(inUserData).Target;
		if (audioConverter.EncoderCallback != null)
		{
			_AudioConverterEventArgs e = new _AudioConverterEventArgs(ioNumberDataPackets, ioData, outDataPacketDescription);
			audioConverter.EncoderCallback(audioConverter, e);
		}
		return 0;
	}

	public unsafe static _AudioConverter CreateInstance(AudioStreamBasicDescription srcFormat, AudioStreamBasicDescription destFormat)
	{
		_AudioConverter audioConverter = new _AudioConverter();
		IntPtr audioConverter2 = audioConverter._audioConverter;
		IntPtr outAudioConverter = (IntPtr)(&audioConverter2);
		int num = AudioConverterNew(ref srcFormat, ref destFormat, outAudioConverter);
		if (num != 0)
		{
			throw new ArgumentException($"Error code:{num}");
		}
		return audioConverter;
	}

	public void FillBuffer(AudioBufferList data, uint numberFrames, AudioStreamPacketDescription[] packetDescs)
	{
		uint ioOutputDataPacketSize = numberFrames;
		int num = AudioConverterFillComplexBuffer(_audioConverter, complexInputDataProc, GCHandle.ToIntPtr(_handle), ref ioOutputDataPacketSize, data, packetDescs);
		if (num != 0 || ioOutputDataPacketSize == 0)
		{
			throw new InvalidOperationException($"Error code:{num}");
		}
	}

	public void Dispose()
	{
		_handle.Free();
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", EntryPoint = "AudioConverterNew")]
	private static extern int AudioConverterFillComplexBuffer(IntPtr inAudioConverter, AudioConverterComplexInputDataProc inInputDataProc, IntPtr inInputDataProcUserData, ref uint ioOutputDataPacketSize, AudioBufferList outOutputData, AudioStreamPacketDescription[] outPacketDescription);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioConverterNew(ref AudioStreamBasicDescription inSourceFormat, ref AudioStreamBasicDescription inDestinationFormat, IntPtr outAudioConverter);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioConverterSetProperty(IntPtr inAudioConverter, [MarshalAs(UnmanagedType.U4)] AudioConverterPropertyIDType inID, uint inDataSize, IntPtr inPrppertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioConverterSetProperty(IntPtr inAudioConverter, [MarshalAs(UnmanagedType.U4)] AudioConverterPropertyIDType inID, uint inDataSize, byte[] inPrppertyData);
}
