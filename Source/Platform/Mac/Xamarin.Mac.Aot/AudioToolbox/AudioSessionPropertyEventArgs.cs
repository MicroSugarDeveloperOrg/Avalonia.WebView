using System;

namespace AudioToolbox;

public class AudioSessionPropertyEventArgs : EventArgs
{
	public AudioSessionProperty Property { get; set; }

	public int Size { get; set; }

	public IntPtr Data { get; set; }

	public AudioSessionPropertyEventArgs(AudioSessionProperty prop, int size, IntPtr data)
	{
		Property = prop;
		Size = size;
		Data = data;
	}
}
