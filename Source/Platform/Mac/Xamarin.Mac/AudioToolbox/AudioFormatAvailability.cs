using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public static class AudioFormatAvailability
{
	public static AudioValueRange[] GetAvailableEncodeBitRates(AudioFormatType format)
	{
		return GetAvailable<AudioValueRange>(AudioFormatProperty.AvailableEncodeBitRates, format);
	}

	public static AudioValueRange[] GetAvailableEncodeSampleRates(AudioFormatType format)
	{
		return GetAvailable<AudioValueRange>(AudioFormatProperty.AvailableEncodeSampleRates, format);
	}

	public static AudioClassDescription[] GetDecoders(AudioFormatType format)
	{
		return GetAvailable<AudioClassDescription>(AudioFormatProperty.Decoders, format);
	}

	public static AudioClassDescription[] GetEncoders(AudioFormatType format)
	{
		return GetAvailable<AudioClassDescription>(AudioFormatProperty.Encoders, format);
	}

	private static T[] GetAvailable<T>(AudioFormatProperty prop, AudioFormatType format)
	{
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(prop, 4, ref format, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		T[] array = new T[(long)outPropertyDataSize / (long)Marshal.SizeOf(typeof(T))];
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		try
		{
			IntPtr outPropertyData = gCHandle.AddrOfPinnedObject();
			if (AudioFormatPropertyNative.AudioFormatGetProperty(prop, 4, ref format, ref outPropertyDataSize, outPropertyData) != 0)
			{
				return null;
			}
			Array.Resize(ref array, (int)outPropertyDataSize / Marshal.SizeOf(typeof(T)));
			return array;
		}
		finally
		{
			gCHandle.Free();
		}
	}
}
