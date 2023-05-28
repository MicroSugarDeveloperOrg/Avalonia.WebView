using ObjCRuntime;

namespace Security;

[Watch(6, 0)]
[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
public enum TlsProtocolVersion : ushort
{
	Tls10 = 769,
	Tls11 = 770,
	Tls12 = 771,
	Tls13 = 772,
	Dtls10 = 65279,
	Dtls12 = 65277
}
