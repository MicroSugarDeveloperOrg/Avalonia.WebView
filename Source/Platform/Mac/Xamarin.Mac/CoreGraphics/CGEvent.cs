using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public sealed class CGEvent : IDisposable, INativeObject
{
	public delegate IntPtr CGEventTapCallback(IntPtr tapProxyEvent, CGEventType eventType, IntPtr eventRef, IntPtr userInfo);

	private IntPtr handle;

	public IntPtr Handle => handle;

	public CGPoint Location
	{
		get
		{
			return CGEventGetLocation(handle);
		}
		set
		{
			CGEventSetLocation(handle, value);
		}
	}

	public CGPoint UnflippedLocation => CGEventGetUnflippedLocation(handle);

	public CGEventFlags Flags
	{
		get
		{
			return GetFlags(handle);
		}
		set
		{
			CGEventSetFlags(handle, value);
		}
	}

	public long MouseEventNumber => GetLong(handle, CGEventField.MouseEventNumber);

	public long MouseEventClickState => GetLong(handle, CGEventField.MouseEventClickState);

	public double MouseEventPressure => GetDouble(handle, CGEventField.MouseEventPressure);

	public long MouseEventButtonNumber => GetLong(handle, CGEventField.MouseEventButtonNumber);

	public long MouseEventDeltaX => GetLong(handle, CGEventField.MouseEventDeltaX);

	public long MouseEventDeltaY => GetLong(handle, CGEventField.MouseEventDeltaY);

	public bool MouseEventInstantMouser => GetLong(handle, CGEventField.MouseEventButtonNumber) != 0;

	public long MouseEventSubtype => GetLong(handle, CGEventField.MouseEventSubtype);

	public CGEventType EventType
	{
		get
		{
			return CGEventGetType(handle);
		}
		set
		{
			CGEventSetType(handle, value);
		}
	}

	[Obsolete("Use 'Timestamp' instead.")]
	public ulong Timestampe
	{
		get
		{
			return CGEventGetTimestamp(handle);
		}
		set
		{
			CGEventSetTimestamp(handle, value);
		}
	}

	public ulong Timestamp
	{
		get
		{
			return CGEventGetTimestamp(handle);
		}
		set
		{
			CGEventSetTimestamp(handle, value);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventTapCreate(CGEventTapLocation location, CGEventTapPlacement place, CGEventTapOptions options, CGEventMask mask, CGEventTapCallback cback, IntPtr data);

	public static CFMachPort CreateTap(CGEventTapLocation location, CGEventTapPlacement place, CGEventTapOptions options, CGEventMask mask, CGEventTapCallback cback, IntPtr data)
	{
		IntPtr intPtr = CGEventTapCreate(location, place, options, mask, cback, data);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFMachPort(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventTapCreateForPSN(IntPtr processSerialNumer, CGEventTapLocation location, CGEventTapPlacement place, CGEventTapOptions options, CGEventMask mask, CGEventTapCallback cback, IntPtr data);

	public static CFMachPort CreateTap(IntPtr processSerialNumber, CGEventTapLocation location, CGEventTapPlacement place, CGEventTapOptions options, CGEventMask mask, CGEventTapCallback cback, IntPtr data)
	{
		IntPtr intPtr = CGEventTapCreateForPSN(processSerialNumber, location, place, options, mask, cback, data);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFMachPort(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateFromData(IntPtr allocator, IntPtr nsdataSource);

	public CGEvent(NSData source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		handle = CGEventCreateFromData(IntPtr.Zero, source.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreate(IntPtr eventSourceHandle);

	public CGEvent(CGEventSource eventSource)
	{
		handle = CGEventCreate(eventSource?.Handle ?? IntPtr.Zero);
	}

	public CGEvent(IntPtr handle)
		: this(handle, ownsHandle: false)
	{
	}

	internal CGEvent(IntPtr handle, bool ownsHandle)
	{
		if (!ownsHandle)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateMouseEvent(IntPtr source, CGEventType mouseType, CGPoint mouseCursorPosition, CGMouseButton mouseButton);

	public CGEvent(CGEventSource source, CGEventType mouseType, CGPoint mouseCursorPosition, CGMouseButton mouseButton)
	{
		handle = CGEventCreateMouseEvent(source?.Handle ?? IntPtr.Zero, mouseType, mouseCursorPosition, mouseButton);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateKeyboardEvent(IntPtr source, ushort virtualKey, bool keyDown);

	public CGEvent(CGEventSource source, ushort virtualKey, bool keyDown)
	{
		handle = CGEventCreateKeyboardEvent(source?.Handle ?? IntPtr.Zero, virtualKey, keyDown);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateScrollWheelEvent(IntPtr source, CGScrollEventUnit units, uint wheelCount, int wheel1);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateScrollWheelEvent(IntPtr source, CGScrollEventUnit units, uint wheelCount, int wheel1, int wheel2);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateScrollWheelEvent(IntPtr source, CGScrollEventUnit units, uint wheelCount, int wheel1, int wheel2, int wheel3);

	public CGEvent(CGEventSource source, CGScrollEventUnit units, params int[] wheel)
	{
		IntPtr source2 = source?.Handle ?? IntPtr.Zero;
		switch (wheel.Length)
		{
		case 0:
			throw new ArgumentException("At least one wheel must be provided");
		case 1:
			handle = CGEventCreateScrollWheelEvent(source2, units, 1u, wheel[0]);
			break;
		case 2:
			handle = CGEventCreateScrollWheelEvent(source2, units, 2u, wheel[0], wheel[1]);
			break;
		case 3:
			handle = CGEventCreateScrollWheelEvent(source2, units, 3u, wheel[0], wheel[1], wheel[2]);
			break;
		default:
			throw new ArgumentException("Only one to three wheels are supported on this constructor");
		}
	}

	~CGEvent()
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
	private static extern IntPtr CGEventCreateCopy(IntPtr handle);

	public CGEvent Copy()
	{
		return new CGEvent(CGEventCreateCopy(handle), ownsHandle: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateData(IntPtr allocator, IntPtr handle);

	public NSData ToData()
	{
		return new NSData(CGEventCreateData(IntPtr.Zero, handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventCreateSourceFromEvent(IntPtr evthandle);

	public CGEventSource CreateEventSource()
	{
		IntPtr intPtr = CGEventCreateSourceFromEvent(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGEventSource(intPtr, ownsHandle: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGEventGetLocation(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSetLocation(IntPtr handle, CGPoint location);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGEventGetUnflippedLocation(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventGetFlags")]
	public static extern CGEventFlags GetFlags(IntPtr eventHandle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern void CGEventSetFlags(IntPtr eventHandle, CGEventFlags flags);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventGetIntegerValueField")]
	internal static extern long GetLong(IntPtr eventHandle, CGEventField eventField);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics", EntryPoint = "CGEventGetDoubleValueField")]
	internal static extern double GetDouble(IntPtr eventHandle, CGEventField eventField);

	internal long GetLong(CGEventField eventField)
	{
		return GetLong(handle, eventField);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGEventSetSource(IntPtr handle, IntPtr source);

	public void SetEventSource(CGEventSource eventSource)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		CGEventSetSource(handle, eventSource.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGEventType CGEventGetType(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSetType(IntPtr handle, CGEventType evtType);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern ulong CGEventGetTimestamp(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventSetTimestamp(IntPtr handle, ulong timeStampp);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventTapEnable(IntPtr machPort, bool enable);

	public static void TapEnable(CFMachPort machPort)
	{
		if (machPort == null)
		{
			throw new ArgumentNullException("machPort");
		}
		CGEventTapEnable(machPort.Handle, enable: true);
	}

	public static void TapDisable(CFMachPort machPort)
	{
		if (machPort == null)
		{
			throw new ArgumentNullException("machPort");
		}
		CGEventTapEnable(machPort.Handle, enable: false);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGEventTapIsEnabled(IntPtr machPort);

	public static bool IsTapEnabled(CFMachPort machPort)
	{
		if (machPort == null)
		{
			throw new ArgumentNullException("machPort");
		}
		return CGEventTapIsEnabled(machPort.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern void CGEventKeyboardGetUnicodeString(IntPtr handle, nuint maxLen, out nuint actualLen, char* buffer);

	public unsafe string GetUnicodeString()
	{
		char* ptr = stackalloc char[40];
		CGEventKeyboardGetUnicodeString(handle, (byte)40, out var actualLen, ptr);
		return new string(ptr, 0, (int)actualLen);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventKeyboardSetUnicodeString(IntPtr handle, nuint len, [MarshalAs(UnmanagedType.LPWStr)] string buffer);

	public void SetUnicodeString(string value)
	{
		CGEventKeyboardSetUnicodeString(handle, (nuint)value.Length, value);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventTapPostEvent(IntPtr proxy, IntPtr evtHandle);

	public static void TapPostEven(IntPtr tapProxyEvent, CGEvent evt)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		CGEventTapPostEvent(tapProxyEvent, evt.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventPost(CGEventTapLocation location, IntPtr handle);

	public static void Post(CGEvent evt, CGEventTapLocation location)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		CGEventPost(location, evt.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGEventPostToPSN(IntPtr processSerialNumber, IntPtr handle);

	public static void PostToPSN(CGEvent evt, IntPtr processSerialNumber)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		CGEventPostToPSN(processSerialNumber, evt.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern int CGGetEventTapList(uint maxNumberOfTaps, CGEventTapInformation* tapList, out uint eventTapCount);

	public unsafe CGEventTapInformation[] GetEventTapList()
	{
		if (CGGetEventTapList(0u, null, out var eventTapCount) != 0)
		{
			return null;
		}
		CGEventTapInformation[] array = new CGEventTapInformation[eventTapCount];
		fixed (CGEventTapInformation* tapList = &array[0])
		{
			if (CGGetEventTapList(eventTapCount, tapList, out eventTapCount) != 0)
			{
				return null;
			}
		}
		return array;
	}
}
