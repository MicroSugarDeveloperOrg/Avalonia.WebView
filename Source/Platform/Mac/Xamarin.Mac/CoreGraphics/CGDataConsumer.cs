using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGDataConsumer : INativeObject, IDisposable
{
	internal IntPtr handle;

	private IntPtr buffer;

	private byte[] reference;

	public IntPtr Handle => handle;

	public CGDataConsumer(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGDataConsumer(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGDataConsumerRetain(handle);
		}
	}

	~CGDataConsumer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGDataConsumerRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGDataConsumerRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
			buffer = IntPtr.Zero;
			CGDataConsumerRelease(handle);
			handle = IntPtr.Zero;
		}
		reference = null;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataConsumerCreateWithCFData(IntPtr data);

	public CGDataConsumer(NSMutableData data)
	{
		handle = CGDataConsumerCreateWithCFData(data.Handle);
	}
}
