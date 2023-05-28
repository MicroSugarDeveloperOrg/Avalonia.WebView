using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGDataProvider : INativeObject, IDisposable
{
	private delegate void CGDataProviderReleaseDataCallback(IntPtr info, IntPtr data, nint size);

	private IntPtr handle;

	private static CGDataProviderReleaseDataCallback release_gchandle_callback = ReleaseGCHandle;

	private static CGDataProviderReleaseDataCallback release_buffer_callback = ReleaseBuffer;

	private static CGDataProviderReleaseDataCallback release_func_callback = ReleaseFunc;

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCopyData(IntPtr provider);

	public NSData CopyData()
	{
		return Runtime.GetNSObject<NSData>(CGDataProviderCopyData(handle), owns: true);
	}

	public CGDataProvider(IntPtr handle)
		: this(handle, owns: false)
	{
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
	private static extern void CGDataProviderRelease(IntPtr provider);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderRetain(IntPtr provider);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGDataProviderRelease(handle);
			handle = IntPtr.Zero;
		}
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
	private static extern IntPtr CGDataProviderCreateWithURL(IntPtr url);

	public CGDataProvider(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGDataProviderCreateWithURL(url.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCreateWithCFData(IntPtr data);

	public CGDataProvider(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		handle = CGDataProviderCreateWithCFData(data.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGDataProviderCreateWithData(IntPtr info, IntPtr data, nint size, CGDataProviderReleaseDataCallback releaseData);

	[MonoPInvokeCallback(typeof(CGDataProviderReleaseDataCallback))]
	private static void ReleaseGCHandle(IntPtr info, IntPtr data, nint size)
	{
		GCHandle.FromIntPtr(info).Free();
	}

	[MonoPInvokeCallback(typeof(CGDataProviderReleaseDataCallback))]
	private static void ReleaseBuffer(IntPtr info, IntPtr data, nint size)
	{
		if (data != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(data);
		}
	}

	[MonoPInvokeCallback(typeof(CGDataProviderReleaseDataCallback))]
	private static void ReleaseFunc(IntPtr info, IntPtr data, nint size)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(info);
		Action<IntPtr> action = (Action<IntPtr>)gCHandle.Target;
		try
		{
			action(data);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public CGDataProvider(IntPtr memoryBlock, int size)
		: this(memoryBlock, size, ownBuffer: false)
	{
	}

	public CGDataProvider(IntPtr memoryBlock, int size, bool ownBuffer)
	{
		if (!ownBuffer)
		{
			memoryBlock = Runtime.CloneMemory(memoryBlock, size);
		}
		handle = CGDataProviderCreateWithData(IntPtr.Zero, memoryBlock, size, release_buffer_callback);
	}

	public CGDataProvider(IntPtr memoryBlock, int size, Action<IntPtr> releaseMemoryBlockCallback)
	{
		if (releaseMemoryBlockCallback == null)
		{
			throw new ArgumentNullException("releaseMemoryBlockCallback");
		}
		GCHandle value = GCHandle.Alloc(releaseMemoryBlockCallback);
		handle = CGDataProviderCreateWithData(GCHandle.ToIntPtr(value), memoryBlock, size, release_func_callback);
	}

	public CGDataProvider(byte[] buffer, int offset, int count)
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
		GCHandle value = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		IntPtr data = value.AddrOfPinnedObject() + offset;
		handle = CGDataProviderCreateWithData(GCHandle.ToIntPtr(value), data, count, release_gchandle_callback);
	}

	public CGDataProvider(byte[] buffer)
		: this(buffer, 0, buffer.Length)
	{
	}
}
