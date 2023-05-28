using System;

namespace AudioUnit;

internal struct AudioUnitConnection
{
	public IntPtr SourceAudioUnit;

	public uint SourceOutputNumber;

	public uint DestInputNumber;
}
