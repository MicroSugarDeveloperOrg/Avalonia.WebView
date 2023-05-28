using ObjCRuntime;

namespace Compression;

[iOS(9, 0)]
[TV(9, 0)]
[Mac(10, 11)]
public enum CompressionAlgorithm
{
	LZ4 = 256,
	LZ4Raw = 257,
	Lzfse = 2049,
	Lzma = 774,
	Zlib = 517
}
