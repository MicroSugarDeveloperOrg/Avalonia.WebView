using System;
using System.Runtime.InteropServices;
using Metal;

namespace ModelIO;

public static class MDLVertexFormatExtensions
{
	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern nuint MTKMetalVertexFormatFromModelIO(nuint vertexFormat);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static MTLVertexFormat ToMetalVertexFormat(this MDLVertexFormat vertexFormat)
	{
		nuint nuint = MTKMetalVertexFormatFromModelIO((nuint)(ulong)vertexFormat);
		return (MTLVertexFormat)(ulong)nuint;
	}
}
