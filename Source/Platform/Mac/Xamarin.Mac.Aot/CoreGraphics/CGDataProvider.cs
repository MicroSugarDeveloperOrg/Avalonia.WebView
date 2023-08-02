using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGDataProvider : INativeObject, IDisposable
{
	internal IntPtr handle;

	private IntPtr buffer;

	private byte[] reference;

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCopyData(IntPtr handle);

	public NSData CopyData()
	{
		IntPtr intPtr = CGDataProviderCopyData(handle);
		NSData result = new NSData(intPtr);
		CGDataProviderRelease(intPtr);
		return result;
	}

	public CGDataProvider(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGDataProvider(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGDataProviderRetain(handle);
		}
	}

	~CGDataProvider()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGDataProviderRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGDataProviderRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
			buffer = IntPtr.Zero;
			CGDataProviderRelease(handle);
			handle = IntPtr.Zero;
		}
		reference = null;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCreateWithFilename(string filename);

	public static CGDataProvider FromFile(string file)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr intPtr = CGDataProviderCreateWithFilename(file);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGDataProvider(intPtr, owns: true);
	}

	public CGDataProvider(string file)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		handle = CGDataProviderCreateWithFilename(file);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("Could not create provider from the specified file");
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCreateWithData(IntPtr info, IntPtr data, IntPtr size, IntPtr releaseData);

	public CGDataProvider(IntPtr memoryBlock, int size)
	{
		handle = CGDataProviderCreateWithData(IntPtr.Zero, memoryBlock, new IntPtr(size), IntPtr.Zero);
	}

	public CGDataProvider(IntPtr memoryBlock, int size, bool ownBuffer)
	{
		handle = CGDataProviderCreateWithData(IntPtr.Zero, memoryBlock, new IntPtr(size), IntPtr.Zero);
		if (ownBuffer)
		{
			buffer = memoryBlock;
		}
	}

	public unsafe CGDataProvider(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentException("offset");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentException("offset");
		}
		reference = buffer;
		fixed (byte* ptr = &buffer[offset])
		{
			handle = CGDataProviderCreateWithData(IntPtr.Zero, (IntPtr)ptr, new IntPtr(count), IntPtr.Zero);
		}
	}
}
