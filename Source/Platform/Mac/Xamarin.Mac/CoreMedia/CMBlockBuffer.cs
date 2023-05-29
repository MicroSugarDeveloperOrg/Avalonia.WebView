using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Since(4, 0)]
public class CMBlockBuffer : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public uint DataLength => CMBlockBufferGetDataLength(handle);

	internal CMBlockBuffer(IntPtr handle)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CMBlockBuffer(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CMBlockBuffer()
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
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateEmpty(IntPtr allocator, uint subBlockCapacity, CMBlockBufferFlags flags, out IntPtr output);

	public static CMBlockBuffer CreateEmpty(uint subBlockCapacity, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		error = CMBlockBufferCreateEmpty(IntPtr.Zero, subBlockCapacity, flags, out var output);
		if (error != 0)
		{
			return null;
		}
		return new CMBlockBuffer(output, owns: true);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCopyDataBytes(IntPtr handle, uint offsetToData, uint dataLength, IntPtr destination);

	public CMBlockBufferError CopyDataBytes(uint offsetToData, uint dataLength, IntPtr destination)
	{
		return CMBlockBufferCopyDataBytes(handle, offsetToData, dataLength, destination);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern uint CMBlockBufferGetDataLength(IntPtr handle);
}
