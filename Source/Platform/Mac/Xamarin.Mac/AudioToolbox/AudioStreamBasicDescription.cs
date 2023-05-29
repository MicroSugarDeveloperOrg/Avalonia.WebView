using System;
using System.Diagnostics;
using CoreFoundation;

namespace AudioToolbox;

[DebuggerDisplay("{FormatName}")]
public struct AudioStreamBasicDescription
{
	public double SampleRate;

	public AudioFormatType Format;

	public AudioFormatFlags FormatFlags;

	public int BytesPerPacket;

	public int FramesPerPacket;

	public int BytesPerFrame;

	public int ChannelsPerFrame;

	public int BitsPerChannel;

	public int Reserved;

	public const double AudioStreamAnyRate = 0.0;

	private const int AudioUnitSampleFractionBits = 24;

	private const AudioFormatFlags AudioFormatFlagIsBigEndian = (AudioFormatFlags)0u;

	public static readonly AudioFormatFlags AudioFormatFlagsAudioUnitCanonical = (AudioFormatFlags)3116u;

	public unsafe string FormatName
	{
		get
		{
			int ioPropertyDataSize = sizeof(IntPtr);
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatName, sizeof(AudioStreamBasicDescription), ref this, ref ioPropertyDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return new CFString(outPropertyData, owns: true);
		}
	}

	public unsafe bool IsEncrypted
	{
		get
		{
			int ioPropertyDataSize = 4;
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatIsEncrypted, sizeof(AudioStreamBasicDescription), ref this, ref ioPropertyDataSize, out uint outPropertyData) != 0)
			{
				return false;
			}
			return outPropertyData != 0;
		}
	}

	public unsafe bool IsExternallyFramed
	{
		get
		{
			int ioPropertyDataSize = 4;
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatIsExternallyFramed, sizeof(AudioStreamBasicDescription), ref this, ref ioPropertyDataSize, out uint outPropertyData) != 0)
			{
				return false;
			}
			return outPropertyData != 0;
		}
	}

	public unsafe bool IsVariableBitrate
	{
		get
		{
			int ioPropertyDataSize = 4;
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatName, sizeof(AudioStreamBasicDescription), ref this, ref ioPropertyDataSize, out uint outPropertyData) != 0)
			{
				return false;
			}
			return outPropertyData != 0;
		}
	}

	public AudioStreamBasicDescription(AudioFormatType formatType)
	{
		this = default(AudioStreamBasicDescription);
		Format = formatType;
	}

	public static AudioStreamBasicDescription CreateLinearPCM(double sampleRate = 44100.0, uint channelsPerFrame = 2u, uint bitsPerChannel = 16u, bool bigEndian = false)
	{
		AudioStreamBasicDescription result = new AudioStreamBasicDescription(AudioFormatType.LinearPCM);
		result.SampleRate = sampleRate;
		result.ChannelsPerFrame = (int)channelsPerFrame;
		result.BitsPerChannel = (int)bitsPerChannel;
		result.BytesPerPacket = (result.BytesPerFrame = (int)(channelsPerFrame * 2));
		result.FramesPerPacket = 1;
		result.FormatFlags = AudioFormatFlags.IsSignedInteger | AudioFormatFlags.IsPacked;
		if (bigEndian)
		{
			result.FormatFlags |= AudioFormatFlags.IsBigEndian;
		}
		return result;
	}

	public unsafe static AudioChannelLayoutTag[] GetAvailableEncodeChannelLayoutTags(AudioStreamBasicDescription format)
	{
		int inSpecifierSize = sizeof(AudioStreamBasicDescription);
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.AvailableEncodeChannelLayoutTags, inSpecifierSize, ref format, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		AudioChannelLayoutTag[] array = new AudioChannelLayoutTag[outPropertyDataSize / 4u];
		fixed (AudioChannelLayoutTag* outPropertyData = array)
		{
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.AvailableEncodeChannelLayoutTags, inSpecifierSize, ref format, ref outPropertyDataSize, (int*)outPropertyData) != 0)
			{
				return null;
			}
			return array;
		}
	}

	public unsafe static int[] GetAvailableEncodeNumberChannels(AudioStreamBasicDescription format)
	{
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.AvailableEncodeNumberChannels, sizeof(AudioStreamBasicDescription), ref format, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		int[] array = new int[outPropertyDataSize / 4u];
		fixed (int* outPropertyData = array)
		{
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.AvailableEncodeNumberChannels, sizeof(AudioStreamBasicDescription), ref format, ref outPropertyDataSize, outPropertyData) != 0)
			{
				return null;
			}
			return array;
		}
	}

	public unsafe AudioFormat[] GetOutputFormatList(byte[] magicCookie = null)
	{
		AudioFormatInfo inSpecifier = default(AudioFormatInfo);
		inSpecifier.AudioStreamBasicDescription = this;
		int num = sizeof(AudioFormat);
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.OutputFormatList, num, ref inSpecifier, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		AudioFormat[] array = new AudioFormat[(long)outPropertyDataSize / (long)num];
		fixed (AudioFormat* outPropertyData = &array[0])
		{
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.OutputFormatList, num, ref inSpecifier, ref outPropertyDataSize, outPropertyData) != 0)
			{
				return null;
			}
			Array.Resize(ref array, (int)outPropertyDataSize / num);
			return array;
		}
	}

	public unsafe AudioFormat[] GetFormatList(byte[] magicCookie)
	{
		if (magicCookie == null)
		{
			throw new ArgumentNullException("magicCookie");
		}
		AudioFormatInfo inSpecifier = default(AudioFormatInfo);
		inSpecifier.AudioStreamBasicDescription = this;
		fixed (byte* magicCookieWeak = magicCookie)
		{
			inSpecifier.MagicCookieWeak = magicCookieWeak;
			inSpecifier.MagicCookieSize = magicCookie.Length;
			int num = sizeof(AudioFormat);
			if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.FormatList, num, ref inSpecifier, out var outPropertyDataSize) != 0)
			{
				return null;
			}
			AudioFormat[] array = new AudioFormat[(long)outPropertyDataSize / (long)num];
			fixed (AudioFormat* outPropertyData = &array[0])
			{
				if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatList, num, ref inSpecifier, ref outPropertyDataSize, outPropertyData) != 0)
				{
					return null;
				}
				Array.Resize(ref array, (int)outPropertyDataSize / num);
				return array;
			}
		}
	}

	public unsafe static AudioFormatError GetFormatInfo(ref AudioStreamBasicDescription format)
	{
		int ioPropertyDataSize = sizeof(AudioStreamBasicDescription);
		return AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FormatInfo, 0, IntPtr.Zero, ref ioPropertyDataSize, ref format);
	}

	public override string ToString()
	{
		return $"[SampleRate={SampleRate} FormatID={Format} FormatFlags={FormatFlags} BytesPerPacket={BytesPerPacket} FramesPerPacket={FramesPerPacket} BytesPerFrame={BytesPerFrame} ChannelsPerFrame={ChannelsPerFrame} BitsPerChannel={BitsPerChannel}]";
	}
}
