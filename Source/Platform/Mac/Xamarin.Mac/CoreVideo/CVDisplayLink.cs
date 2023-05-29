using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace CoreVideo;

public class CVDisplayLink : INativeObject, IDisposable
{
	public delegate CVReturn DisplayLinkOutputCallback(CVDisplayLink displayLink, ref CVTimeStamp inNow, ref CVTimeStamp inOutputTime, CVOptionFlags flagsIn, ref CVOptionFlags flagsOut);

	private delegate CVReturn CVDisplayLinkOutputCallback(IntPtr displayLink, ref CVTimeStamp inNow, ref CVTimeStamp inOutputTime, CVOptionFlags flagsIn, ref CVOptionFlags flagsOut, IntPtr displayLinkContext);

	internal IntPtr handle;

	private GCHandle callbackHandle;

	private static CVDisplayLinkOutputCallback static_OutputCallback = OutputCallback;

	public IntPtr Handle => handle;

	public CVTime NominalOutputVideoRefreshPeriod => CVDisplayLinkGetNominalOutputVideoRefreshPeriod(handle);

	public CVTime OutputVideoLatency => CVDisplayLinkGetOutputVideoLatency(handle);

	public double ActualOutputVideoRefreshPeriod => CVDisplayLinkGetActualOutputVideoRefreshPeriod(handle);

	public bool IsRunning => CVDisplayLinkIsRunning(handle);

	public CVDisplayLink(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to display link creation");
		}
		CVDisplayLinkRetain(handle);
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CVDisplayLink(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CVDisplayLinkRetain(handle);
		}
		this.handle = handle;
	}

	~CVDisplayLink()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVDisplayLinkRetain(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVDisplayLinkRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (callbackHandle.IsAllocated)
		{
			callbackHandle.Free();
		}
		if (handle != IntPtr.Zero)
		{
			CVDisplayLinkRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkCreateWithActiveCGDisplays(IntPtr displayLinkOut);

	public CVDisplayLink()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		try
		{
			CVReturn cVReturn = CVDisplayLinkCreateWithActiveCGDisplays(intPtr);
			if (cVReturn != 0)
			{
				throw new Exception("CVDisplayLink returned: " + cVReturn);
			}
			handle = Marshal.ReadIntPtr(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkSetCurrentCGDisplay(IntPtr displayLink, int displayId);

	public CVReturn SetCurrentDisplay(int displayId)
	{
		return CVDisplayLinkSetCurrentCGDisplay(handle, displayId);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkSetCurrentCGDisplayFromOpenGLContext(IntPtr displayLink, IntPtr cglContext, IntPtr cglPixelFormat);

	public CVReturn SetCurrentDisplay(CGLContext cglContext, CGLPixelFormat cglPixelFormat)
	{
		return CVDisplayLinkSetCurrentCGDisplayFromOpenGLContext(handle, cglContext.Handle, cglPixelFormat.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern int CVDisplayLinkGetCurrentCGDisplay(IntPtr displayLink);

	public int GetCurrentDisplay()
	{
		return CVDisplayLinkGetCurrentCGDisplay(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkStart(IntPtr displayLink);

	public CVReturn Start()
	{
		return CVDisplayLinkStart(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkStop(IntPtr displayLink);

	public CVReturn Stop()
	{
		return CVDisplayLinkStop(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVTime CVDisplayLinkGetNominalOutputVideoRefreshPeriod(IntPtr displayLink);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVTime CVDisplayLinkGetOutputVideoLatency(IntPtr displayLink);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern double CVDisplayLinkGetActualOutputVideoRefreshPeriod(IntPtr displayLink);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern bool CVDisplayLinkIsRunning(IntPtr displayLink);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkGetCurrentTime(IntPtr displayLink, out CVTimeStamp outTime);

	public CVReturn GetCurrentTime(out CVTimeStamp outTime)
	{
		return CVDisplayLinkGetCurrentTime(Handle, out outTime);
	}

	private static CVReturn OutputCallback(IntPtr displayLink, ref CVTimeStamp inNow, ref CVTimeStamp inOutputTime, CVOptionFlags flagsIn, ref CVOptionFlags flagsOut, IntPtr displayLinkContext)
	{
		DisplayLinkOutputCallback obj = (DisplayLinkOutputCallback)GCHandle.FromIntPtr(displayLinkContext).Target;
		CVDisplayLink displayLink2 = new CVDisplayLink(displayLink, owns: false);
		return obj(displayLink2, ref inNow, ref inOutputTime, flagsIn, ref flagsOut);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVDisplayLinkSetOutputCallback(IntPtr displayLink, CVDisplayLinkOutputCallback function, IntPtr userInfo);

	public CVReturn SetOutputCallback(DisplayLinkOutputCallback callback)
	{
		callbackHandle = GCHandle.Alloc(callback);
		return CVDisplayLinkSetOutputCallback(Handle, static_OutputCallback, GCHandle.ToIntPtr(callbackHandle));
	}
}
