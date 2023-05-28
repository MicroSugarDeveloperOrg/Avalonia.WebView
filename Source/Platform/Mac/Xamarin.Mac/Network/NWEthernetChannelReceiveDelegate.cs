using CoreFoundation;
using ObjCRuntime;

namespace Network;

[NoWatch]
[NoTV]
[NoiOS]
[Mac(10, 15)]
public delegate void NWEthernetChannelReceiveDelegate(DispatchData content, ushort vlanTag, string localAddress, string remoteAddress);
