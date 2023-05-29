using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class AudioPanningInfo
{
	private struct Layout
	{
		public PanningMode PanningMode;

		public AudioChannelFlags CoordinateFlags;

		public float Coord0;

		public float Coord1;

		public float Coord2;

		public float GainScale;

		public IntPtr OutputChannelMapWeak;
	}

	public PanningMode PanningMode { get; set; }

	public AudioChannelFlags CoordinateFlags { get; set; }

	public float[] Coordinates { get; private set; }

	public float GainScale { get; set; }

	public AudioChannelLayout OutputChannelMap { get; private set; }

	public AudioPanningInfo(AudioChannelLayout outputChannelMap)
	{
		if (outputChannelMap == null)
		{
			throw new ArgumentNullException("outputChannelMap");
		}
		OutputChannelMap = outputChannelMap;
	}

	public unsafe float[] GetPanningMatrix()
	{
		int num = sizeof(Layout);
		Layout layout = ToStruct();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		*(Layout*)(void*)intPtr = layout;
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.PanningMatrix, num, intPtr, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		float[] array = new float[outPropertyDataSize / 4];
		AudioFormatError num2;
		fixed (float* outPropertyData = array)
		{
			num2 = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.PanningMatrix, num, intPtr, ref outPropertyDataSize, outPropertyData);
		}
		Marshal.FreeHGlobal(layout.OutputChannelMapWeak);
		Marshal.FreeHGlobal(intPtr);
		if (num2 != 0)
		{
			return null;
		}
		return array;
	}

	private Layout ToStruct()
	{
		Layout layout = default(Layout);
		layout.PanningMode = PanningMode;
		layout.CoordinateFlags = CoordinateFlags;
		layout.Coord0 = Coordinates[0];
		layout.Coord1 = Coordinates[1];
		layout.Coord2 = Coordinates[2];
		layout.GainScale = GainScale;
		Layout result = layout;
		if (OutputChannelMap != null)
		{
			result.OutputChannelMapWeak = OutputChannelMap.ToBlock(out var _);
		}
		return result;
	}
}
