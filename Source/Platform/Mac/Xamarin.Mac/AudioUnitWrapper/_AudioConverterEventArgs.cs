using System;
using AudioToolbox;

namespace AudioUnitWrapper;

[Obsolete("Use AudioConverter")]
public class _AudioConverterEventArgs : EventArgs
{
	public uint NumberDataPackets;

	public readonly AudioBufferList Data;

	public readonly AudioStreamPacketDescription[] DataPacketDescription;

	public _AudioConverterEventArgs(uint _NumberDataPackets, AudioBufferList _Data, AudioStreamPacketDescription[] _DataPacketDescription)
	{
		NumberDataPackets = _NumberDataPackets;
		Data = _Data;
		DataPacketDescription = _DataPacketDescription;
	}
}
