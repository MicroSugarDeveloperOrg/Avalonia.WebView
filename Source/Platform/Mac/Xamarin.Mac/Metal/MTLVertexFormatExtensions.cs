using System;
using System.Runtime.InteropServices;
using ModelIO;

namespace Metal;

public static class MTLVertexFormatExtensions
{
	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern nuint MTKModelIOVertexFormatFromMetal(nuint modelIODescriptor);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static MDLVertexFormat ToModelVertexFormat(this MTLVertexFormat vertexFormat)
	{
		nuint nuint = MTKModelIOVertexFormatFromMetal((nuint)(ulong)vertexFormat);
		return (MDLVertexFormat)(ulong)nuint;
	}
}
