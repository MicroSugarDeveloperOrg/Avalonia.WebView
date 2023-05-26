using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[iOS(10, 0)]
[TV(9, 0)]
[Mac(10, 12)]
[Deprecated(PlatformName.iOS, 12, 2, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.TvOS, 12, 2, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
public struct GCMicroGamepadSnapShotDataV100
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
	private static extern IntPtr NSDataFromGCMicroGamepadSnapShotDataV100(ref GCMicroGamepadSnapShotDataV100 snapshotData);

	public NSData ToNSData()
	{
		IntPtr intPtr = NSDataFromGCMicroGamepadSnapShotDataV100(ref this);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}
}
