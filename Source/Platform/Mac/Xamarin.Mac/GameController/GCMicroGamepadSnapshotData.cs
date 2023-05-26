using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
public struct GCMicroGamepadSnapshotData
{
	public ushort Version;

	public ushort Size;

	public float DPadX;

	public float DPadY;

	public float ButtonA;

	public float ButtonX;

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private static extern IntPtr NSDataFromGCMicroGamepadSnapshotData(ref GCMicroGamepadSnapshotData snapshotData);

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	public NSData ToNSData()
	{
		IntPtr intPtr = NSDataFromGCMicroGamepadSnapshotData(ref this);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}
}
