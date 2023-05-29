using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using Foundation;

namespace AudioUnit;

public static class AudioUnitUtils
{
	public const int SampleFractionBits = 24;

	[Advice("Use AudioStreamBasicDescription::CreateLinearPCM instead")]
	public static AudioStreamBasicDescription AUCanonicalASBD(double sampleRate, int channel)
	{
		int num = 4;
		AudioStreamBasicDescription result = default(AudioStreamBasicDescription);
		result.SampleRate = sampleRate;
		result.Format = AudioFormatType.LinearPCM;
		result.FormatFlags = (AudioFormatFlags)3116u;
		result.ChannelsPerFrame = channel;
		result.BytesPerPacket = num;
		result.BytesPerFrame = num;
		result.FramesPerPacket = 1;
		result.BitsPerChannel = 8 * num;
		result.Reserved = 0;
		return result;
	}

	[Advice("Use AudioSession::OverrideCategoryDefaultToSpeaker instead")]
	public static void SetOverrideCategoryDefaultToSpeaker(bool isSpeaker)
	{
		int inData = (isSpeaker ? 1 : 0);
		if (AudioSessionSetProperty(1668509803u, 4u, ref inData) != 0)
		{
			throw new ArgumentException();
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionSetProperty(uint inID, uint inDataSize, ref int inData);
}
