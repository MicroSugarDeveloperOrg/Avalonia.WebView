using ObjCRuntime;

namespace AudioToolbox;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[NoWatch]
[iOS(13, 0)]
[Mac(10, 15)]
[TV(13, 0)]
public struct AudioPacketRangeByteCountTranslation
{
	public long Packet;

	public long PacketCount;

	public long ByteCountUpperBound;
}
