using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLTextureChannelEncoding : long
{
	UInt8 = 1L,
	UInt16 = 2L,
	UInt24 = 3L,
	UInt32 = 4L,
	Float16 = 258L,
	Float16SR = 770L,
	Float32 = 260L
}
