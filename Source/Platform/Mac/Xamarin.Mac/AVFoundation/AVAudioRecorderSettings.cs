using System;
using AudioToolbox;
using CoreFoundation;
using Foundation;

namespace AVFoundation;

[Advice("Use AudioSettings instead")]
public class AVAudioRecorderSettings
{
	public AudioFormatType AudioFormat = AudioFormatType.LinearPCM;

	public float SampleRate = 44100f;

	public int NumberChannels = 1;

	public int LinearPcmBitDepth;

	public bool LinearPcmBigEndian;

	public bool LinearPcmFloat;

	public bool LinearPcmNonInterleaved;

	public AVAudioQuality AudioQuality = AVAudioQuality.High;

	public AVAudioQuality? SampleRateConverterAudioQuality;

	public int? EncoderBitRate;

	public int? EncoderBitRatePerChannel;

	public int? EncoderBitDepthHint;

	internal NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		nSMutableDictionary.SetObject(new NSNumber((int)AudioFormat), AVAudioSettings.AVFormatIDKey);
		nSMutableDictionary.SetObject(new NSNumber(SampleRate), AVAudioSettings.AVSampleRateKey);
		nSMutableDictionary.SetObject(new NSNumber(NumberChannels), AVAudioSettings.AVNumberOfChannelsKey);
		if (AudioFormat == AudioFormatType.LinearPCM)
		{
			IntPtr handle = CFBoolean.True.Handle;
			IntPtr handle2 = CFBoolean.False.Handle;
			if (LinearPcmBitDepth != 0)
			{
				if (LinearPcmBitDepth != 8 && LinearPcmBitDepth != 16 && LinearPcmBitDepth != 32 && LinearPcmBitDepth != 24)
				{
					throw new Exception("Invalid value for LinearPcmBitDepth, must be one of 8, 16, 24 or 32");
				}
				nSMutableDictionary.SetObject(new NSNumber(LinearPcmBitDepth), AVAudioSettings.AVLinearPCMBitDepthKey);
			}
			nSMutableDictionary.LowlevelSetObject(LinearPcmBigEndian ? handle : handle2, AVAudioSettings.AVLinearPCMIsBigEndianKey.Handle);
			nSMutableDictionary.LowlevelSetObject(LinearPcmFloat ? handle : handle2, AVAudioSettings.AVLinearPCMIsFloatKey.Handle);
			nSMutableDictionary.LowlevelSetObject(LinearPcmNonInterleaved ? handle : handle2, AVAudioSettings.AVLinearPCMIsNonInterleaved.Handle);
		}
		nSMutableDictionary.SetObject(new NSNumber((int)AudioQuality), AVAudioSettings.AVEncoderAudioQualityKey);
		if (EncoderBitRate.HasValue)
		{
			nSMutableDictionary.SetObject(new NSNumber(EncoderBitRate.Value), AVAudioSettings.AVEncoderBitRateKey);
		}
		if (EncoderBitRatePerChannel.HasValue)
		{
			nSMutableDictionary.SetObject(new NSNumber(EncoderBitRatePerChannel.Value), AVAudioSettings.AVEncoderBitRatePerChannelKey);
		}
		if (EncoderBitDepthHint.HasValue)
		{
			int value = EncoderBitDepthHint.Value;
			if (value < 8 || value > 32)
			{
				throw new Exception("EncoderBitDepthHint should be a value between 8 and 32");
			}
			nSMutableDictionary.SetObject(new NSNumber(EncoderBitDepthHint.Value), AVAudioSettings.AVEncoderBitDepthHintKey);
		}
		if (SampleRateConverterAudioQuality.HasValue)
		{
			nSMutableDictionary.SetObject(new NSNumber((int)SampleRateConverterAudioQuality.Value), AVAudioSettings.AVSampleRateConverterAudioQualityKey);
		}
		return nSMutableDictionary;
	}
}
