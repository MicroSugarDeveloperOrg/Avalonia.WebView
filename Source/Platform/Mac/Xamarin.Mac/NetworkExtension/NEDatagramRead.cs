using Foundation;

namespace NetworkExtension;

public delegate void NEDatagramRead(NSData[] datagrams, NWEndpoint[] remoteEndpoints, NSError error);
