using System.Runtime.InteropServices;

namespace AVFoundation;

[Mac(10, 10)]
[NoiOS]
[NoWatch]
[NoTV]
public struct AVSampleCursorChunkInfo
{
    public long SampleCount;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasUniformSampleSizes;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasUniformSampleDurations;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasUniformFormatDescriptions;
}
