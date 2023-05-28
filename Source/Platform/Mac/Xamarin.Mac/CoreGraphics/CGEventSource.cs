using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace CoreGraphics;

public sealed class CGEventSource : IDisposable, INativeObject
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public int KeyboardType
	{
		get
		{
			return CGEventSourceGetKeyboardType(handle);
		}
		set
		{
			CGEventSourceSetKeyboardType(handle, value);
		}
	}

	public CGEventSourceStateID StateID => CGEventSourceGetSourceStateID(handle);

	public double PixelsPerLine
	{
		get
		{
			return CGEventSourceGetPixelsPerLine(handle);
		}
		set
		{
			CGEventSourceSetPixelsPerLine(handle, value);
		}
	}

	public long UserData
	{
		get
		{
			return CGEventSourceGetUserData(handle);
		}
		set
		{
			CGEventSourceSetUserData(handle, value);
		}
	}

	public double LocalEventsSupressionInterval
	{
		get
		{
			return CGEventSourceGetLocalEventsSuppressionInterval(handle);
		}
		set
		{
			CGEventSourceSetLocalEventsSuppressionInterval(handle, value);
		}
	}

	public CGEventSource(IntPtr handle)
		: this(handle, ownsHandle: false)
	{
	}

	public CGEventSource(IntPtr handle, bool ownsHandle)
	{
		if (!ownsHandle)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CGEventSource()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventSourceCreate(CGEventSourceStateID stateID);

	public CGEventSource(CGEventSourceStateID stateID)
	{
		handle = CGEventSourceCreate(stateID);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGEventSourceGetKeyboardType(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSourceSetKeyboardType(IntPtr handle, int keyboardType);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGEventSourceStateID CGEventSourceGetSourceStateID(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGEventSourceGetPixelsPerLine(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSourceSetPixelsPerLine(IntPtr handle, double value);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventSourceButtonState")]
	public static extern bool GetButtonState(CGEventSourceStateID stateID, CGMouseButton button);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventSourceKeyState")]
	public static extern bool GetKeyState(CGEventSourceStateID stateID, ushort keycode);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventSourceFlagsState")]
	public static extern CGEventFlags GetFlagsState(CGEventSourceStateID stateID);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventSourceSecondsSinceLastEventType")]
	public static extern double GetSecondsSinceLastEventType(CGEventSourceStateID stateID, CGEventType eventType);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventSourceCounterForEventType")]
	public static extern uint GetCounterForEventType(CGEventSourceStateID stateID, CGEventType eventType);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSourceSetUserData(IntPtr handle, long data);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern long CGEventSourceGetUserData(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSourceSetLocalEventsFilterDuringSuppressionState(IntPtr handle, CGEventFilterMask filter, CGEventSuppressionState state);

	public void SetLocalEventsFilterDuringSupressionState(CGEventFilterMask filter, CGEventSuppressionState state)
	{
		CGEventSourceSetLocalEventsFilterDuringSuppressionState(handle, filter, state);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGEventFilterMask CGEventSourceGetLocalEventsFilterDuringSuppressionState(IntPtr handle, CGEventSuppressionState state);

	public CGEventFilterMask GetLocalEventsFilterDuringSupressionState(CGEventSuppressionState state)
	{
		return CGEventSourceGetLocalEventsFilterDuringSuppressionState(handle, state);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSourceSetLocalEventsSuppressionInterval(IntPtr handle, double seconds);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGEventSourceGetLocalEventsSuppressionInterval(IntPtr handle);
}
