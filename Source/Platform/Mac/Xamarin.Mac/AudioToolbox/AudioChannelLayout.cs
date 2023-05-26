using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace AudioToolbox;

[DebuggerDisplay("{Name}")]
public class AudioChannelLayout
{
	public AudioChannelLayoutTag AudioTag;

	public AudioChannelBit ChannelUsage;

	public AudioChannelDescription[] Channels;

	[Advice("Use the strongly typed AudioTag instead")]
	public int Tag
	{
		get
		{
			return (int)AudioTag;
		}
		set
		{
			AudioTag = (AudioChannelLayoutTag)value;
		}
	}

	[Advice("Use ChannelUsage instead")]
	public int Bitmap
	{
		get
		{
			return (int)ChannelUsage;
		}
		set
		{
			ChannelUsage = (AudioChannelBit)value;
		}
	}

	public unsafe string Name
	{
		get
		{
			int ioDataSize = sizeof(IntPtr);
			int size;
			IntPtr intPtr = ToBlock(out size);
			IntPtr outPropertyData;
			AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ChannelLayoutName, size, intPtr, ref ioDataSize, out outPropertyData);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				return null;
			}
			return new CFString(outPropertyData, owns: true);
		}
	}

	public unsafe string SimpleName
	{
		get
		{
			int ioDataSize = sizeof(IntPtr);
			int size;
			IntPtr intPtr = ToBlock(out size);
			IntPtr outPropertyData;
			AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ChannelLayoutName, size, intPtr, ref ioDataSize, out outPropertyData);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				return null;
			}
			return new CFString(outPropertyData, owns: true);
		}
	}

	public AudioChannelLayout()
	{
	}

	internal unsafe AudioChannelLayout(IntPtr h)
	{
		AudioTag = (AudioChannelLayoutTag)Marshal.ReadInt32(h, 0);
		ChannelUsage = (AudioChannelBit)Marshal.ReadInt32(h, 4);
		Channels = new AudioChannelDescription[Marshal.ReadInt32(h, 8)];
		int num = 12;
		int num2 = sizeof(AudioChannelDescription);
		for (int i = 0; i < Channels.Length; i++)
		{
			Channels[i] = *(AudioChannelDescription*)((byte*)(void*)h + num);
			num += num2;
		}
	}

	public static AudioChannelLayout FromAudioChannelBitmap(AudioChannelBit channelBitmap)
	{
		return GetChannelLayout(AudioFormatProperty.ChannelLayoutForBitmap, (int)channelBitmap);
	}

	public static AudioChannelLayout FromAudioChannelLayoutTag(AudioChannelLayoutTag channelLayoutTag)
	{
		return GetChannelLayout(AudioFormatProperty.ChannelLayoutForTag, (int)channelLayoutTag);
	}

	private static AudioChannelLayout GetChannelLayout(AudioFormatProperty property, int value)
	{
		AudioFormatPropertyNative.AudioFormatGetPropertyInfo(property, 4, ref value, out var outPropertyDataSize);
		IntPtr intPtr = Marshal.AllocHGlobal(outPropertyDataSize);
		AudioChannelLayout result = ((AudioFormatPropertyNative.AudioFormatGetProperty(property, 4, ref value, ref outPropertyDataSize, intPtr) != 0) ? null : new AudioChannelLayout(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	internal static AudioChannelLayout FromHandle(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		return new AudioChannelLayout(handle);
	}

	public override string ToString()
	{
		return $"AudioChannelLayout: Tag={AudioTag} Bitmap={ChannelUsage} Channels={Channels.Length}";
	}

	internal unsafe IntPtr ToBlock(out int size)
	{
		if (Channels == null)
		{
			throw new ArgumentNullException("Channels");
		}
		int num = sizeof(AudioChannelDescription);
		size = 12 + Channels.Length * num;
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		Marshal.WriteInt32(intPtr, (int)AudioTag);
		Marshal.WriteInt32(intPtr, 4, (int)ChannelUsage);
		Marshal.WriteInt32(intPtr, 8, Channels.Length);
		AudioChannelDescription* ptr = (AudioChannelDescription*)((byte*)(void*)intPtr + 12);
		AudioChannelDescription[] channels = Channels;
		foreach (AudioChannelDescription audioChannelDescription in channels)
		{
			*ptr = audioChannelDescription;
			ptr++;
		}
		return intPtr;
	}

	public static AudioFormatError Validate(AudioChannelLayout layout)
	{
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		int size;
		IntPtr intPtr = layout.ToBlock(out size);
		AudioFormatError result = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ValidateChannelLayout, size, intPtr, IntPtr.Zero, IntPtr.Zero);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public unsafe static int[] GetChannelMap(AudioChannelLayout inputLayout, AudioChannelLayout outputLayout)
	{
		if (inputLayout == null)
		{
			throw new ArgumentNullException("inputLayout");
		}
		if (outputLayout == null)
		{
			throw new ArgumentNullException("outputLayout");
		}
		int? numberOfChannels = GetNumberOfChannels(outputLayout);
		if (!numberOfChannels.HasValue)
		{
			throw new ArgumentException("outputLayout");
		}
		int size;
		IntPtr intPtr = inputLayout.ToBlock(out size);
		IntPtr intPtr2 = outputLayout.ToBlock(out size);
		IntPtr[] array = new IntPtr[2] { intPtr, intPtr2 };
		size = sizeof(IntPtr) * array.Length;
		int[] array2;
		AudioFormatError num;
		fixed (IntPtr* inSpecifier = &array[0])
		{
			array2 = new int[numberOfChannels.Value];
			int ioDataSize = 4 * array2.Length;
			fixed (int* outPropertyData = &array2[0])
			{
				num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ChannelMap, size, inSpecifier, ref ioDataSize, outPropertyData);
			}
		}
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		if (num != 0)
		{
			return null;
		}
		return array2;
	}

	public unsafe static float[,] GetMatrixMixMap(AudioChannelLayout inputLayout, AudioChannelLayout outputLayout)
	{
		if (inputLayout == null)
		{
			throw new ArgumentNullException("inputLayout");
		}
		if (outputLayout == null)
		{
			throw new ArgumentNullException("outputLayout");
		}
		int? numberOfChannels = GetNumberOfChannels(outputLayout);
		if (!numberOfChannels.HasValue)
		{
			throw new ArgumentException("outputLayout");
		}
		int? numberOfChannels2 = GetNumberOfChannels(inputLayout);
		if (!numberOfChannels2.HasValue)
		{
			throw new ArgumentException("inputLayout");
		}
		int size;
		IntPtr intPtr = inputLayout.ToBlock(out size);
		IntPtr intPtr2 = outputLayout.ToBlock(out size);
		IntPtr[] array = new IntPtr[2] { intPtr, intPtr2 };
		size = sizeof(IntPtr) * array.Length;
		float[,] array2;
		AudioFormatError num;
		fixed (IntPtr* inSpecifier = &array[0])
		{
			array2 = new float[numberOfChannels2.Value, numberOfChannels.Value];
			int ioDataSize = 4 * numberOfChannels2.Value * numberOfChannels.Value;
			fixed (float* outPropertyData = &array2[0, 0])
			{
				num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.MatrixMixMap, size, inSpecifier, ref ioDataSize, outPropertyData);
			}
		}
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		if (num != 0)
		{
			return null;
		}
		return array2;
	}

	public static int? GetNumberOfChannels(AudioChannelLayout layout)
	{
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		int size;
		IntPtr intPtr = layout.ToBlock(out size);
		int ioDataSize = 4;
		int outPropertyData;
		AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.NumberOfChannelsForLayout, size, intPtr, ref ioDataSize, out outPropertyData);
		Marshal.FreeHGlobal(intPtr);
		if (num == AudioFormatError.None)
		{
			return outPropertyData;
		}
		return null;
	}

	public static AudioChannelLayoutTag? GetTagForChannelLayout(AudioChannelLayout layout)
	{
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		int size;
		IntPtr intPtr = layout.ToBlock(out size);
		int ioDataSize = 4;
		int outPropertyData;
		AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.TagForChannelLayout, size, intPtr, ref ioDataSize, out outPropertyData);
		Marshal.FreeHGlobal(intPtr);
		if (num == AudioFormatError.None)
		{
			return (AudioChannelLayoutTag)outPropertyData;
		}
		return null;
	}

	public unsafe static AudioChannelLayoutTag[] GetTagsForNumberOfChannels(int count)
	{
		if (AudioFormatPropertyNative.AudioFormatGetPropertyInfo(AudioFormatProperty.TagsForNumberOfChannels, 4, ref count, out var outPropertyDataSize) != 0)
		{
			return null;
		}
		AudioChannelLayoutTag[] array = new AudioChannelLayoutTag[outPropertyDataSize / 4];
		fixed (AudioChannelLayoutTag* outPropertyData = array)
		{
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.TagsForNumberOfChannels, 4, ref count, ref outPropertyDataSize, (int*)outPropertyData) != 0)
			{
				return null;
			}
			return array;
		}
	}

	public NSData AsData()
	{
		int size;
		IntPtr intPtr = ToBlock(out size);
		NSData result = NSData.FromBytes(intPtr, (uint)size);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}
