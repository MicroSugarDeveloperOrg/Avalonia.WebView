using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Mac(10, 10)]
[iOS(8, 0)]
[TV(10, 2)]
public class VTMultiPassStorage : INativeObject, IDisposable
{
	private IntPtr handle;

	private bool closed;

	private VTStatus closedStatus;

	public IntPtr Handle => handle;

	protected internal VTMultiPassStorage(IntPtr handle)
	{
		this.handle = handle;
		CFObject.CFRetain(this.handle);
	}

	[Preserve(Conditional = true)]
	internal VTMultiPassStorage(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(this.handle);
		}
	}

	~VTMultiPassStorage()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			if (!closed)
			{
				Close();
			}
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTMultiPassStorageCreate(IntPtr allocator, IntPtr fileUrl, CMTimeRange timeRange, IntPtr options, out IntPtr multiPassStorageOut);

	public static VTMultiPassStorage Create(VTMultiPassStorageCreationOptions options, NSUrl fileUrl = null, CMTimeRange? timeRange = null)
	{
		return Create(fileUrl, timeRange, options?.Dictionary);
	}

	public static VTMultiPassStorage Create(NSUrl fileUrl = null, CMTimeRange? timeRange = null, NSDictionary options = null)
	{
		if (VTMultiPassStorageCreate(IntPtr.Zero, (fileUrl == null) ? IntPtr.Zero : fileUrl.Handle, timeRange ?? CMTimeRange.InvalidRange, options?.Handle ?? IntPtr.Zero, out var multiPassStorageOut) != 0)
		{
			return null;
		}
		return new VTMultiPassStorage(multiPassStorageOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTMultiPassStorageClose(IntPtr multiPassStorage);

	public VTStatus Close()
	{
		if (closed)
		{
			return closedStatus;
		}
		closedStatus = VTMultiPassStorageClose(handle);
		closed = true;
		return closedStatus;
	}
}
