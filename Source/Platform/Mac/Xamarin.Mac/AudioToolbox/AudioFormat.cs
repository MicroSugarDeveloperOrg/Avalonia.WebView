using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct AudioFormat
{
	public AudioStreamBasicDescription AudioStreamBasicDescription;

	public AudioChannelLayoutTag AudioChannelLayoutTag;

	public unsafe static AudioFormat? GetFirstPlayableFormat(AudioFormat[] formatList)
	{
		if (formatList == null)
		{
			throw new ArgumentNullException("formatList");
		}
		if (formatList.Length < 2)
		{
			throw new ArgumentException("formatList");
		}
		fixed (AudioFormat* inSpecifier = &formatList[0])
		{
			int ioPropertyDataSize = 4;
			int inSpecifierSize = sizeof(AudioFormat) * formatList.Length;
			if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.FirstPlayableFormatFromList, inSpecifierSize, inSpecifier, ref ioPropertyDataSize, out var outPropertyData) != 0)
			{
				return null;
			}
			return formatList[outPropertyData];
		}
	}

	public override string ToString()
	{
		return string.Concat(AudioChannelLayoutTag, ":", AudioStreamBasicDescription.ToString());
	}
}
