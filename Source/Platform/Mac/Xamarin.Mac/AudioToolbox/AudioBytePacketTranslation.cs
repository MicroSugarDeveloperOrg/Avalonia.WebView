namespace AudioToolbox;

internal struct AudioBytePacketTranslation
{
	public long Byte;

	public long Packet;

	public int ByteOffsetInPacket;

	public BytePacketTranslationFlags Flags;
}
