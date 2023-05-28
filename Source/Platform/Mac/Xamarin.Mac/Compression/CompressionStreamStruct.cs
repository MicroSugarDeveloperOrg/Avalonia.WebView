using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace Compression;

[iOS(9, 0)]
[Mac(10, 11)]
internal struct CompressionStreamStruct
{
	public IntPtr Destination;

	public nint DestinationSize;

	public IntPtr Source;

	public nint SourceSize;

	public IntPtr State;

	[DllImport("/usr/lib/libcompression.dylib")]
	public static extern CompressionStatus compression_stream_init(ref CompressionStreamStruct stream, StreamOperation operation, CompressionAlgorithm algorithm);

	[DllImport("/usr/lib/libcompression.dylib")]
	public static extern CompressionStatus compression_stream_process(ref CompressionStreamStruct stream, StreamFlag flags);

	[DllImport("/usr/lib/libcompression.dylib")]
	public static extern CompressionStatus compression_stream_destroy(ref CompressionStreamStruct stream);
}
