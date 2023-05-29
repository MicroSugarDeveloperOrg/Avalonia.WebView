using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace AudioToolbox;

public struct AudioChannelDescription
{
	public AudioChannelLabel Label;

	public AudioChannelFlags Flags;

	private float Coord0;

	private float Coord1;

	private float Coord2;

	public float[] Coords
	{
		get
		{
			return new float[3] { Coord0, Coord1, Coord2 };
		}
		set
		{
			if (value.Length != 3)
			{
				throw new ArgumentException("Must contain three floats");
			}
			Coord0 = value[0];
			Coord1 = value[1];
			Coord2 = value[2];
		}
	}

	public unsafe string Name
	{
		get
		{
			int ioDataSize = sizeof(IntPtr);
			int inSpecifierSize = sizeof(AudioChannelDescription);
			IntPtr intPtr = ToPointer();
			IntPtr outPropertyData;
			AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ChannelName, inSpecifierSize, intPtr, ref ioDataSize, out outPropertyData);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				return null;
			}
			return new CFString(outPropertyData, owns: true);
		}
	}

	public unsafe string ShortName
	{
		get
		{
			int ioDataSize = sizeof(IntPtr);
			int inSpecifierSize = sizeof(AudioChannelDescription);
			IntPtr intPtr = ToPointer();
			IntPtr outPropertyData;
			AudioFormatError num = AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.ChannelShortName, inSpecifierSize, intPtr, ref ioDataSize, out outPropertyData);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				return null;
			}
			return new CFString(outPropertyData, owns: true);
		}
	}

	internal unsafe IntPtr ToPointer()
	{
		AudioChannelDescription* ptr = (AudioChannelDescription*)(void*)Marshal.AllocHGlobal(20);
		*ptr = this;
		return (IntPtr)ptr;
	}

	public override string ToString()
	{
		return $"[id={Label} {Flags} - {Coords[0]},{Coords[1]},{Coords[2]}";
	}
}
