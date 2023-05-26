using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
public struct GCExtendedGamepadSnapshotData
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

	[iOS(12, 2)]
	[Mac(10, 14, 4)]
	[TV(12, 2)]
	public bool SupportsClickableThumbsticks;

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private bool LeftThumbstickButton;

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private bool RightThumbstickButton;

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private static extern IntPtr NSDataFromGCExtendedGamepadSnapshotData(ref GCExtendedGamepadSnapshotData snapshotData);

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	public NSData ToNSData()
	{
		IntPtr intPtr = NSDataFromGCExtendedGamepadSnapshotData(ref this);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}
}
