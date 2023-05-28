using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class MusicEventUserData : MidiRawData
{
	public MusicEventUserData()
	{
	}

	internal MusicEventUserData(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		int num = Marshal.ReadInt32(handle);
		byte[] destination = new byte[num];
		Marshal.Copy(handle + 4, destination, 0, num);
		len = num;
		data = destination;
	}
}
