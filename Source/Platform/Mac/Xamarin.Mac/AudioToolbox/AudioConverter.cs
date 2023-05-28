using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public class AudioConverter : IDisposable, INativeObject
{
	private delegate AudioConverterError AudioConverterComplexInputDataShared(IntPtr inAudioConverter, ref int ioNumberDataPackets, IntPtr ioData, IntPtr outDataPacketDescription, IntPtr inUserData);

	private IntPtr handle;

	private IntPtr packetDescriptions;

	private int packetDescriptionSize;

	private readonly bool owns;

	private static readonly AudioConverterComplexInputDataShared ComplexInputDataShared = FillComplexBufferShared;

	public IntPtr Handle => handle;

	public uint MinimumInputBufferSize => GetUIntProperty(AudioConverterPropertyID.MinimumInputBufferSize);

	public uint MinimumOutputBufferSize => GetUIntProperty(AudioConverterPropertyID.MinimumOutputBufferSize);

	public uint MaximumInputPacketSize => GetUIntProperty(AudioConverterPropertyID.MaximumInputPacketSize);

	public uint MaximumOutputPacketSize => GetUIntProperty(AudioConverterPropertyID.MaximumOutputPacketSize);

	public uint CalculateInputBufferSize => GetUIntProperty(AudioConverterPropertyID.CalculateInputBufferSize);

	public uint CalculateOutputBufferSize => GetUIntProperty(AudioConverterPropertyID.CalculateOutputBufferSize);

	public double SampleRateConverterInitialPhase
	{
		get
		{
			return GetDoubleProperty(AudioConverterPropertyID.SampleRateConverterInitialPhase);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.SampleRateConverterInitialPhase, value);
		}
	}

	public AudioConverterSampleRateConverterComplexity SampleRateConverterComplexity
	{
		get
		{
			return (AudioConverterSampleRateConverterComplexity)GetUIntProperty(AudioConverterPropertyID.SampleRateConverterComplexity);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.SampleRateConverterComplexity, (uint)value);
		}
	}

	public AudioConverterQuality SampleRateConverterQuality
	{
		get
		{
			return (AudioConverterQuality)GetUIntProperty(AudioConverterPropertyID.SampleRateConverterQuality);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.SampleRateConverterQuality, (uint)value);
		}
	}

	public AudioConverterQuality CodecQuality
	{
		get
		{
			return (AudioConverterQuality)GetUIntProperty(AudioConverterPropertyID.CodecQuality);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.CodecQuality, (uint)value);
		}
	}

	public AudioConverterPrimeMethod PrimeMethod
	{
		get
		{
			return (AudioConverterPrimeMethod)GetUIntProperty(AudioConverterPropertyID.PrimeMethod);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.PrimeMethod, (uint)value);
		}
	}

	public unsafe AudioConverterPrimeInfo PrimeInfo
	{
		get
		{
			int ioPropertyDataSize = sizeof(AudioConverterPrimeInfo);
			AudioConverterPrimeInfo outPropertyData;
			AudioConverterError audioConverterError = AudioConverterGetProperty(handle, AudioConverterPropertyID.PrimeInfo, ref ioPropertyDataSize, out outPropertyData);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
			return outPropertyData;
		}
	}

	public int[] ChannelMap => GetArray<int>(AudioConverterPropertyID.ChannelMap, 4);

	public byte[] CompressionMagicCookie
	{
		get
		{
			if (AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.CompressionMagicCookie, out var outSize, out var _) != 0)
			{
				return null;
			}
			byte[] array = new byte[outSize];
			if (AudioConverterGetProperty(handle, AudioConverterPropertyID.CompressionMagicCookie, ref outSize, array) != 0)
			{
				return null;
			}
			return array;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			AudioConverterError audioConverterError = AudioConverterSetProperty(handle, AudioConverterPropertyID.CompressionMagicCookie, value.Length, value);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
		}
	}

	public byte[] DecompressionMagicCookie
	{
		get
		{
			if (AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.DecompressionMagicCookie, out var outSize, out var _) != 0)
			{
				return null;
			}
			byte[] array = new byte[outSize];
			if (AudioConverterGetProperty(handle, AudioConverterPropertyID.DecompressionMagicCookie, ref outSize, array) != 0)
			{
				return null;
			}
			return array;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			AudioConverterError audioConverterError = AudioConverterSetProperty(handle, AudioConverterPropertyID.DecompressionMagicCookie, value.Length, value);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
		}
	}

	public uint EncodeBitRate
	{
		get
		{
			return GetUIntProperty(AudioConverterPropertyID.EncodeBitRate);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.EncodeBitRate, value);
		}
	}

	public double EncodeAdjustableSampleRate
	{
		get
		{
			return GetDoubleProperty(AudioConverterPropertyID.EncodeAdjustableSampleRate);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.EncodeAdjustableSampleRate, value);
		}
	}

	public AudioChannelLayout InputChannelLayout
	{
		get
		{
			if (AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.InputChannelLayout, out var outSize, out var _) != 0)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(outSize);
			AudioChannelLayout result = ((AudioConverterGetProperty(handle, AudioConverterPropertyID.InputChannelLayout, ref outSize, intPtr) == AudioConverterError.None) ? new AudioChannelLayout(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	public AudioChannelLayout OutputChannelLayout
	{
		get
		{
			if (AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.OutputChannelLayout, out var outSize, out var _) != 0)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(outSize);
			AudioChannelLayout result = ((AudioConverterGetProperty(handle, AudioConverterPropertyID.OutputChannelLayout, ref outSize, intPtr) == AudioConverterError.None) ? new AudioChannelLayout(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	public AudioValueRange[] ApplicableEncodeBitRates => GetAudioValueRange(AudioConverterPropertyID.ApplicableEncodeBitRates);

	public AudioValueRange[] AvailableEncodeBitRates => GetAudioValueRange(AudioConverterPropertyID.AvailableEncodeBitRates);

	public AudioValueRange[] ApplicableEncodeSampleRates => GetAudioValueRange(AudioConverterPropertyID.ApplicableEncodeSampleRates);

	public AudioValueRange[] AvailableEncodeSampleRates => GetAudioValueRange(AudioConverterPropertyID.AvailableEncodeSampleRates);

	public AudioChannelLayoutTag[] AvailableEncodeChannelLayoutTags => GetArray<AudioChannelLayoutTag>(AudioConverterPropertyID.AvailableEncodeChannelLayoutTags, 4);

	public unsafe AudioStreamBasicDescription CurrentOutputStreamDescription
	{
		get
		{
			AudioConverterError audioConverterError = AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.CurrentOutputStreamDescription, out var outSize, out var _);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
			IntPtr intPtr = Marshal.AllocHGlobal(outSize);
			audioConverterError = AudioConverterGetProperty(handle, AudioConverterPropertyID.CurrentOutputStreamDescription, ref outSize, intPtr);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
			AudioStreamBasicDescription result = *(AudioStreamBasicDescription*)(void*)intPtr;
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	public unsafe AudioStreamBasicDescription CurrentInputStreamDescription
	{
		get
		{
			AudioConverterError audioConverterError = AudioConverterGetPropertyInfo(handle, AudioConverterPropertyID.CurrentInputStreamDescription, out var outSize, out var _);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
			IntPtr intPtr = Marshal.AllocHGlobal(outSize);
			audioConverterError = AudioConverterGetProperty(handle, AudioConverterPropertyID.CurrentInputStreamDescription, ref outSize, intPtr);
			if (audioConverterError != 0)
			{
				throw new ArgumentException(audioConverterError.ToString());
			}
			AudioStreamBasicDescription result = *(AudioStreamBasicDescription*)(void*)intPtr;
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	public int BitDepthHint
	{
		get
		{
			return (int)GetUIntProperty(AudioConverterPropertyID.PropertyBitDepthHint);
		}
		set
		{
			SetProperty(AudioConverterPropertyID.PropertyBitDepthHint, value);
		}
	}

	public unsafe AudioFormat[] FormatList => GetArray<AudioFormat>(AudioConverterPropertyID.PropertyFormatList, sizeof(AudioFormat));

	public static AudioFormatType[] DecodeFormats => GetFormats(AudioFormatProperty.DecodeFormatIDs);

	public static AudioFormatType[] EncodeFormats => GetFormats(AudioFormatProperty.EncodeFormatIDs);

	public event AudioConverterComplexInputData InputData;

	private AudioConverter(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal AudioConverter(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("address");
		}
		this.handle = handle;
		this.owns = owns;
	}

	public static AudioConverter Create(AudioStreamBasicDescription sourceFormat, AudioStreamBasicDescription destinationFormat)
	{
		AudioConverterError error;
		return Create(sourceFormat, destinationFormat, out error);
	}

	public static AudioConverter Create(AudioStreamBasicDescription sourceFormat, AudioStreamBasicDescription destinationFormat, out AudioConverterError error)
	{
		IntPtr outAudioConverter = default(IntPtr);
		error = AudioConverterNew(ref sourceFormat, ref destinationFormat, ref outAudioConverter);
		if (error != 0)
		{
			return null;
		}
		return new AudioConverter(outAudioConverter, owns: true);
	}

	public static AudioConverter Create(AudioStreamBasicDescription sourceFormat, AudioStreamBasicDescription destinationFormat, AudioClassDescription[] descriptions)
	{
		if (descriptions == null)
		{
			throw new ArgumentNullException("descriptions");
		}
		IntPtr outAudioConverter = default(IntPtr);
		if (AudioConverterNewSpecific(ref sourceFormat, ref destinationFormat, descriptions.Length, ref descriptions, ref outAudioConverter) != 0)
		{
			return null;
		}
		return new AudioConverter(outAudioConverter, owns: true);
	}

	~AudioConverter()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			if (owns)
			{
				AudioConverterDispose(handle);
			}
			handle = IntPtr.Zero;
		}
		if (packetDescriptions != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(packetDescriptions);
			packetDescriptions = IntPtr.Zero;
		}
		GC.SuppressFinalize(this);
	}

	public AudioConverterError ConvertBuffer(byte[] input, byte[] output)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		int ioOutputDataSize = output.Length;
		return AudioConverterConvertBuffer(handle, input.Length, input, ref ioOutputDataSize, output);
	}

	public AudioConverterError ConvertComplexBuffer(int numberPCMFrames, AudioBuffers inputData, AudioBuffers outputData)
	{
		if (inputData == null)
		{
			throw new ArgumentNullException("inputData");
		}
		if (outputData == null)
		{
			throw new ArgumentNullException("outputData");
		}
		return AudioConverterConvertComplexBuffer(handle, numberPCMFrames, (IntPtr)inputData, (IntPtr)outputData);
	}

	public AudioConverterError FillComplexBuffer(ref int outputDataPacketSize, AudioBuffers outputData, AudioStreamPacketDescription[] packetDescription, AudioConverterComplexInputData newInputDataHandler)
	{
		if (outputData == null)
		{
			throw new ArgumentNullException("outputData");
		}
		if (newInputDataHandler == null)
		{
			throw new ArgumentNullException("newInputDataHandler");
		}
		return FillComplexBuffer(ref outputDataPacketSize, outputData, packetDescription, new Tuple<AudioConverter, AudioConverterComplexInputData>(this, newInputDataHandler));
	}

	public AudioConverterError FillComplexBuffer(ref int outputDataPacketSize, AudioBuffers outputData, AudioStreamPacketDescription[] packetDescription)
	{
		if (outputData == null)
		{
			throw new ArgumentNullException("outputData");
		}
		return FillComplexBuffer(ref outputDataPacketSize, outputData, packetDescription, new Tuple<AudioConverter, AudioConverterComplexInputData>(this, null));
	}

	private unsafe AudioConverterError FillComplexBuffer(ref int outputDataPacketSize, AudioBuffers outputData, AudioStreamPacketDescription[] packetDescription, Tuple<AudioConverter, AudioConverterComplexInputData> instanceData)
	{
		GCHandle value = GCHandle.Alloc(instanceData);
		try
		{
			IntPtr inInputDataProcUserData = GCHandle.ToIntPtr(value);
			if (packetDescription == null)
			{
				return AudioConverterFillComplexBuffer(handle, ComplexInputDataShared, inInputDataProcUserData, ref outputDataPacketSize, (IntPtr)outputData, IntPtr.Zero);
			}
			fixed (AudioStreamPacketDescription* ptr = &packetDescription[0])
			{
				return AudioConverterFillComplexBuffer(handle, ComplexInputDataShared, inInputDataProcUserData, ref outputDataPacketSize, (IntPtr)outputData, (IntPtr)ptr);
			}
		}
		finally
		{
			value.Free();
		}
	}

	[MonoPInvokeCallback(typeof(AudioConverterComplexInputDataShared))]
	private unsafe static AudioConverterError FillComplexBufferShared(IntPtr inAudioConverter, ref int ioNumberDataPackets, IntPtr ioData, IntPtr outDataPacketDescription, IntPtr inUserData)
	{
		Tuple<AudioConverter, AudioConverterComplexInputData> tuple = (Tuple<AudioConverter, AudioConverterComplexInputData>)GCHandle.FromIntPtr(inUserData).Target;
		AudioConverter item = tuple.Item1;
		AudioConverterComplexInputData item2 = tuple.Item2;
		if (item2 == null && item.InputData == null)
		{
			throw new ArgumentNullException("InputData");
		}
		if (item2 != null && item.InputData != null)
		{
			throw new InvalidOperationException("Please either only subscribe to InputData event or provide newInputDataHandler in FillComplexBuffer, using both is unsuported.");
		}
		using AudioBuffers data = new AudioBuffers(ioData);
		AudioStreamPacketDescription[] dataPacketDescription = ((outDataPacketDescription == IntPtr.Zero) ? null : new AudioStreamPacketDescription[0]);
		AudioConverterError result = ((item.InputData != null) ? item.InputData(ref ioNumberDataPackets, data, ref dataPacketDescription) : item2(ref ioNumberDataPackets, data, ref dataPacketDescription));
		if (outDataPacketDescription != IntPtr.Zero)
		{
			if (ioNumberDataPackets > 0)
			{
				if (dataPacketDescription == null || dataPacketDescription.Length == 0)
				{
					throw new ArgumentException("ref argument outDataPacketDescription has to be set");
				}
				int num = Marshal.SizeOf(dataPacketDescription[0]);
				if (item.packetDescriptionSize < dataPacketDescription.Length && item.packetDescriptions != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(item.packetDescriptions);
					item.packetDescriptions = IntPtr.Zero;
				}
				if (item.packetDescriptions == IntPtr.Zero)
				{
					item.packetDescriptionSize = dataPacketDescription.Length;
					item.packetDescriptions = Marshal.AllocHGlobal(dataPacketDescription.Length * num);
				}
				try
				{
					fixed (AudioStreamPacketDescription* source = dataPacketDescription)
					{
						Runtime.memcpy((byte*)(void*)item.packetDescriptions, (byte*)source, dataPacketDescription.Length * num);
					}
				}
				finally
				{
				}
				Marshal.WriteIntPtr(outDataPacketDescription, item.packetDescriptions);
			}
			else
			{
				Marshal.WriteIntPtr(outDataPacketDescription, IntPtr.Zero);
			}
		}
		return result;
	}

	public AudioConverterError Reset()
	{
		return AudioConverterReset(handle);
	}

	private unsafe static AudioFormatType[] GetFormats(AudioFormatProperty prop)
	{
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(prop, 0, IntPtr.Zero, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		int num = 4;
		AudioFormatType[] array = new AudioFormatType[outPropertyDataSize / num];
		fixed (AudioFormatType* ptr = array)
		{
			if (AudioFormatPropertyNative.AudioFormatGetProperty(prop, 0, IntPtr.Zero, ref outPropertyDataSize, (IntPtr)ptr) != 0)
			{
				return null;
			}
			Array.Resize(ref array, num);
			return array;
		}
	}

	private uint GetUIntProperty(AudioConverterPropertyID propertyID)
	{
		int ioPropertyDataSize = 4;
		uint outPropertyData;
		AudioConverterError audioConverterError = AudioConverterGetProperty(handle, propertyID, ref ioPropertyDataSize, out outPropertyData);
		if (audioConverterError != 0)
		{
			throw new ArgumentException(audioConverterError.ToString());
		}
		return outPropertyData;
	}

	private double GetDoubleProperty(AudioConverterPropertyID propertyID)
	{
		int ioPropertyDataSize = 8;
		double outPropertyData;
		AudioConverterError audioConverterError = AudioConverterGetProperty(handle, propertyID, ref ioPropertyDataSize, out outPropertyData);
		if (audioConverterError != 0)
		{
			throw new ArgumentException(audioConverterError.ToString());
		}
		return outPropertyData;
	}

	private unsafe AudioValueRange[] GetAudioValueRange(AudioConverterPropertyID prop)
	{
		return GetArray<AudioValueRange>(prop, sizeof(AudioValueRange));
	}

	private T[] GetArray<T>(AudioConverterPropertyID prop, int elementSize)
	{
		if (AudioConverterGetPropertyInfo(handle, prop, out var outSize, out var _) != 0)
		{
			return null;
		}
		T[] array = new T[outSize / elementSize];
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		try
		{
			IntPtr outPropertyData = gCHandle.AddrOfPinnedObject();
			if (AudioConverterGetProperty(handle, prop, ref outSize, outPropertyData) != 0)
			{
				return null;
			}
			Array.Resize(ref array, outSize / elementSize);
			return array;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	private void SetProperty(AudioConverterPropertyID propertyID, uint value)
	{
		AudioConverterError audioConverterError = AudioConverterSetProperty(handle, propertyID, 4, ref value);
		if (audioConverterError != 0)
		{
			throw new ArgumentException(audioConverterError.ToString());
		}
	}

	private void SetProperty(AudioConverterPropertyID propertyID, int value)
	{
		AudioConverterError audioConverterError = AudioConverterSetProperty(handle, propertyID, 4, ref value);
		if (audioConverterError != 0)
		{
			throw new ArgumentException(audioConverterError.ToString());
		}
	}

	private void SetProperty(AudioConverterPropertyID propertyID, double value)
	{
		AudioConverterError audioConverterError = AudioConverterSetProperty(handle, propertyID, 8, ref value);
		if (audioConverterError != 0)
		{
			throw new ArgumentException(audioConverterError.ToString());
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterNew(ref AudioStreamBasicDescription inSourceFormat, ref AudioStreamBasicDescription inDestinationFormat, ref IntPtr outAudioConverter);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterNewSpecific(ref AudioStreamBasicDescription inSourceFormat, ref AudioStreamBasicDescription inDestinationFormat, int inNumberClassDescriptions, ref AudioClassDescription[] inClassDescriptions, ref IntPtr outAudioConverter);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterDispose(IntPtr inAudioConverter);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterReset(IntPtr inAudioConverter);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterConvertComplexBuffer(IntPtr inAudioConverter, int inNumberPCMFrames, IntPtr inInputData, IntPtr outOutputData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, out uint outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, out int outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, out double outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, byte[] outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, out AudioConverterPrimeInfo outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, ref int ioPropertyDataSize, IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterGetPropertyInfo(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, out int outSize, out bool outWritable);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterSetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, int inPropertyDataSize, ref uint inPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterSetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, int inPropertyDataSize, ref int inPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterSetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, int inPropertyDataSize, ref double inPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterSetProperty(IntPtr inAudioConverter, AudioConverterPropertyID inPropertyID, int inPropertyDataSize, byte[] inPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterConvertBuffer(IntPtr inAudioConverter, int inInputDataSize, byte[] inInputData, ref int ioOutputDataSize, byte[] outOutputData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioConverterError AudioConverterFillComplexBuffer(IntPtr inAudioConverter, AudioConverterComplexInputDataShared inInputDataProc, IntPtr inInputDataProcUserData, ref int ioOutputDataPacketSize, IntPtr outOutputData, IntPtr outPacketDescription);
}
