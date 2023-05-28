using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AVFoundation;

[Mac(10, 10)]
[NoiOS]
[NoWatch]
[NoTV]
public struct AVSampleCursorSyncInfo
{
	[MarshalAs(UnmanagedType.I1)]
	public bool IsFullSync;

	[MarshalAs(UnmanagedType.I1)]
	public bool IsPartialSync;

	[MarshalAs(UnmanagedType.I1)]
	public bool IsDroppable;
}
