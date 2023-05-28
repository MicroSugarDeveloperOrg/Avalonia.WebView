using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGDataConsumer : INativeObject, IDisposable
{
	internal IntPtr handle;

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
	private static extern void CGDataConsumerRelease(IntPtr consumer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataConsumerRetain(IntPtr consumer);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGDataConsumerRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataConsumerCreateWithCFData(IntPtr data);

	public CGDataConsumer(NSMutableData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		handle = CGDataConsumerCreateWithCFData(data.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataConsumerCreateWithURL(IntPtr url);

	public CGDataConsumer(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGDataConsumerCreateWithURL(url.Handle);
	}
}
