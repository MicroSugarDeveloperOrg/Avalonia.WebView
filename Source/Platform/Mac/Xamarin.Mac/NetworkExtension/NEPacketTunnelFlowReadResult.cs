using Foundation;

namespace NetworkExtension;

public class NEPacketTunnelFlowReadResult
{
	public NSData[] Packets { get; set; }

	public NSNumber[] Protocols { get; set; }

	public NEPacketTunnelFlowReadResult(NSData[] packets, NSNumber[] protocols)
	{
		Packets = packets;
		Protocols = protocols;
	}
}
