using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[iOS(7, 0)]
[Mac(10, 9)]
public struct GCGamepadSnapShotDataV100
{
	public ushort Version;

	public ushort Size;

	public float DPadX;

	public float DPadY;

	public float ButtonA;

	public float ButtonB;

	public float ButtonX;

	public float ButtonY;

	public float LeftShoulder;

	public float RightShoulder;

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	private static extern IntPtr NSDataFromGCGamepadSnapShotDataV100(ref GCGamepadSnapShotDataV100 snapshotData);

	public NSData ToNSData()
	{
		IntPtr intPtr = NSDataFromGCGamepadSnapShotDataV100(ref this);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}
}
