using ObjCRuntime;

namespace AudioToolbox;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[NoWatch]
[iOS(13, 0)]
[Mac(10, 15)]
[TV(13, 0)]
public struct AudioPacketDependencyInfoTranslation
{
	public long Packet;

	private uint isIndependentlyDecodable;

	public uint NumberPrerollPackets;

	public bool IsIndependentlyDecodable
	{
		get
		{
			return isIndependentlyDecodable != 0;
		}
		set
		{
			isIndependentlyDecodable = (value ? 1u : 0u);
		}
	}
}
