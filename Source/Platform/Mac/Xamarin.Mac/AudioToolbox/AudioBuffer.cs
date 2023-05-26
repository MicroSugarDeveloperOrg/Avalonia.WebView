using System;

namespace AudioToolbox;

public struct AudioBuffer
{
	public int NumberChannels;

	public int DataByteSize;

	public IntPtr Data;

	public override string ToString()
	{
		return $"[channels={NumberChannels},dataByteSize={DataByteSize},ptrData=0x{Data:x}]";
	}
}
