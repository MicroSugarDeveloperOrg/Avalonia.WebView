using System;
using CoreFoundation;

namespace AudioToolbox;

public struct AudioFileMarker
{
	public double FramePosition;

	internal IntPtr Name_cfstringref;

	public int MarkerID;

	public AudioFileSmpteTime SmpteTime;

	public AudioFileMarkerType Type;

	public ushort Reserved;

	public ushort Channel;

	public string Name => CFString.FetchString(Name_cfstringref);
}
