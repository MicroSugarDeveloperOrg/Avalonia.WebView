using System.Runtime.InteropServices;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[StructLayout(LayoutKind.Explicit)]
[Mac(10, 13)]
public struct MPSImageHistogramInfo
{
	[FieldOffset(0)]
	public nuint NumberOfHistogramEntries;

	[FieldOffset(8)]
	public bool HistogramForAlpha;

	[FieldOffset(16)]
	public Vector4 MinPixelValue;

	[FieldOffset(32)]
	public Vector4 MaxPixelValue;
}
