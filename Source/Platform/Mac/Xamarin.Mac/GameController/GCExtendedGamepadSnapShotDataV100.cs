using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[iOS(7, 0)]
[Mac(10, 9)]
[Deprecated(PlatformName.iOS, 12, 2, PlatformArchitecture.None, "Use 'GCExtendedGamepadSnapshotData' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.None, "Use 'GCExtendedGamepadSnapshotData' instead.")]
[Deprecated(PlatformName.TvOS, 12, 2, PlatformArchitecture.None, "Use 'GCExtendedGamepadSnapshotData' instead.")]
public struct GCExtendedGamepadSnapShotDataV100
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

	public float LeftThumbstickX;

	public float LeftThumbstickY;

	public float RightThumbstickX;

	public float RightThumbstickY;

	public float LeftTrigger;

	public float RightTrigger;

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	private static extern IntPtr NSDataFromGCExtendedGamepadSnapShotDataV100(ref GCExtendedGamepadSnapShotDataV100 snapshotData);

	public NSData ToNSData()
	{
		IntPtr intPtr = NSDataFromGCExtendedGamepadSnapShotDataV100(ref this);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}
}
