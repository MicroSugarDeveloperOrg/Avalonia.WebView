using System.Runtime.InteropServices;

namespace AVFoundation;

[Mac(10, 15)]
public struct AVSampleCursorAudioDependencyInfo
{
    [MarshalAs(UnmanagedType.I1)]
    public bool IsIndependentlyDecodable;

    public nint PacketRefreshCount;
}
