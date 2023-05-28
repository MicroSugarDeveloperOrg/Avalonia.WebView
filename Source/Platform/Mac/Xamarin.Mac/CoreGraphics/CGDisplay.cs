using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

public static class CGDisplay
{
	public static int MainDisplayID => (int)CGMainDisplayID();

	public static int ShieldingWindowLevel => CGShieldingWindowLevel();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGMainDisplayID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGDisplayModeGetTypeID")]
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGDisplayBounds(uint display);

	public static CGRect GetBounds(int display)
	{
		return CGDisplayBounds((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nuint CGDisplayPixelsWide(uint display);

	public static nint GetWidth(int display)
	{
		return (nint)CGDisplayPixelsWide((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nuint CGDisplayPixelsHigh(uint display);

	public static nint GetHeight(int display)
	{
		return (nint)CGDisplayPixelsHigh((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGSetDisplayTransferByFormula(uint display, float redMin, float redMax, float redGamma, float greenMin, float greenMax, float greenGamma, float blueMin, float blueMax, float blueGamma);

	public static int SetDisplayTransfer(int display, float redMin, float redMax, float redGamma, float greenMin, float greenMax, float greenGamma, float blueMin, float blueMax, float blueGamma)
	{
		return CGSetDisplayTransferByFormula((uint)display, redMin, redMax, redGamma, greenMin, greenMax, greenGamma, blueMin, blueMax, blueGamma);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGDisplayGammaTableCapacity(uint display);

	public static int GetGammaTableCapacity(int display)
	{
		return (int)CGDisplayGammaTableCapacity((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGDisplayRestoreColorSyncSettings")]
	public static extern void RestoreColorSyncSettings();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	private static extern bool CGDisplayIsCaptured(uint display);

	public static bool IsCaptured(int display)
	{
		return CGDisplayIsCaptured((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayCapture(uint display);

	public static int Capture(int display)
	{
		return CGDisplayCapture((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayCaptureWithOptions(uint display, CGCaptureOptions options);

	public static int Capture(int display, CGCaptureOptions options)
	{
		return CGDisplayCaptureWithOptions((uint)display, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayRelease(uint display);

	public static int Release(int display)
	{
		return CGDisplayRelease((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGCaptureAllDisplays")]
	public static extern int CaptureAllDisplays();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGCaptureAllDisplaysWithOptions")]
	private static extern int CaptureAllDisplays(CGCaptureOptions options);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGReleaseAllDisplays")]
	public static extern int ReleaseAllDisplays();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayHideCursor(uint display);

	public static int HideCursor(int display)
	{
		return CGDisplayHideCursor((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayShowCursor(uint display);

	public static int ShowCursor(int display)
	{
		return CGDisplayShowCursor((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGDisplayMoveCursorToPoint(uint display, CGPoint point);

	public static int MoveCursor(int display, CGPoint point)
	{
		return CGDisplayMoveCursorToPoint((uint)display, point);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGDisplayIDToOpenGLDisplayMask(uint display);

	public static int GetOpenGLDisplayMask(int display)
	{
		return (int)CGDisplayIDToOpenGLDisplayMask((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGOpenGLDisplayMaskToDisplayID(uint mask);

	public static int GetDisplayID(int displayMask)
	{
		return (int)CGOpenGLDisplayMaskToDisplayID((uint)displayMask);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGShieldingWindowID(uint display);

	public static int GetShieldingWindowID(int display)
	{
		return (int)CGShieldingWindowID((uint)display);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGShieldingWindowLevel();
}
