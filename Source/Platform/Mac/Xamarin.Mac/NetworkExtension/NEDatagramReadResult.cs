using Foundation;

namespace NetworkExtension;

public class NEDatagramReadResult
{
	public NSData[] Datagrams { get; set; }

	public NWEndpoint[] RemoteEndpoints { get; set; }

	public NEDatagramReadResult(NSData[] datagrams, NWEndpoint[] remoteEndpoints)
	{
		Datagrams = datagrams;
		RemoteEndpoints = remoteEndpoints;
	}
}
