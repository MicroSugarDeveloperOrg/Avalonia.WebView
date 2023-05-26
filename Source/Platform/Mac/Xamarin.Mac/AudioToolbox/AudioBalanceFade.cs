using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class AudioBalanceFade
{
	private struct Layout
	{
		public float LeftRightBalance;

		public float BackFrontFade;

		public AudioBalanceFadeType Type;

		public IntPtr ChannelLayoutWeak;
	}

	public float LeftRightBalance { get; set; }

	public float BackFrontFade { get; set; }

	public AudioBalanceFadeType Type { get; set; }

	public AudioChannelLayout ChannelLayout { get; private set; }

	public AudioBalanceFade(AudioChannelLayout channelLayout)
	{
		if (channelLayout == null)
		{
			throw new ArgumentNullException("channelLayout");
		}
		ChannelLayout = channelLayout;
	}

	public unsafe float[] GetBalanceFade()
	{
		int num = sizeof(Layout);
		Layout layout = ToStruct();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		*(Layout*)(void*)intPtr = layout;
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.BalanceFade, num, intPtr, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		float[] array = new float[outPropertyDataSize / 4];
		AudioFormatError num2;
		fixed (float* outPropertyData = array)
		{
			num2 = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.BalanceFade, num, intPtr, ref outPropertyDataSize, outPropertyData);
		}
		Marshal.FreeHGlobal(layout.ChannelLayoutWeak);
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
		layout.LeftRightBalance = LeftRightBalance;
		layout.BackFrontFade = BackFrontFade;
		layout.Type = Type;
		Layout result = layout;
		if (ChannelLayout != null)
		{
			result.ChannelLayoutWeak = ChannelLayout.ToBlock(out var _);
		}
		return result;
	}
}
