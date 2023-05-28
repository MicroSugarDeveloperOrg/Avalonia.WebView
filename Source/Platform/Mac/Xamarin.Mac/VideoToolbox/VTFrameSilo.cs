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
public class VTFrameSilo : INativeObject, IDisposable
{
	private delegate VTStatus EachSampleBufferCallback(IntPtr callbackInfo, IntPtr sampleBufferPtr);

	private IntPtr handle;

	private GCHandle callbackHandle;

	private static EachSampleBufferCallback static_EachSampleBufferCallback = BufferCallback;

	public IntPtr Handle => handle;

	protected internal VTFrameSilo(IntPtr handle)
	{
		this.handle = handle;
		CFObject.CFRetain(this.handle);
	}

	[Preserve(Conditional = true)]
	internal VTFrameSilo(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(this.handle);
		}
	}

	~VTFrameSilo()
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
		if (callbackHandle.IsAllocated)
		{
			callbackHandle.Free();
		}
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTFrameSiloCreate(IntPtr allocator, IntPtr fileUrl, CMTimeRange timeRange, IntPtr options, out IntPtr siloOut);

	public static VTFrameSilo Create(NSUrl fileUrl = null, CMTimeRange? timeRange = null)
	{
		if (VTFrameSiloCreate(IntPtr.Zero, (fileUrl == null) ? IntPtr.Zero : fileUrl.Handle, timeRange ?? CMTimeRange.InvalidRange, IntPtr.Zero, out var siloOut) != 0)
		{
			return null;
		}
		return new VTFrameSilo(siloOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTFrameSiloAddSampleBuffer(IntPtr silo, IntPtr sampleBuffer);

	public VTStatus AddSampleBuffer(CMSampleBuffer sampleBuffer)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		return VTFrameSiloAddSampleBuffer(handle, sampleBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTFrameSiloSetTimeRangesForNextPass(IntPtr silo, nint timeRangeCount, IntPtr timeRangeArray);

	public unsafe VTStatus SetTimeRangesForNextPass(CMTimeRange[] ranges)
	{
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (ranges.Length != 0)
		{
			fixed (CMTimeRange* ptr = &ranges[0])
			{
				return VTFrameSiloSetTimeRangesForNextPass(handle, ranges.Length, (IntPtr)ptr);
			}
		}
		return VTFrameSiloSetTimeRangesForNextPass(handle, ranges.Length, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTFrameSiloGetProgressOfCurrentPass(IntPtr silo, out float progressOut);

	public VTStatus GetProgressOfCurrentPass(out float progress)
	{
		return VTFrameSiloGetProgressOfCurrentPass(handle, out progress);
	}

	private static VTStatus BufferCallback(IntPtr callbackInfo, IntPtr sampleBufferPtr)
	{
		Func<CMSampleBuffer, VTStatus> func = (Func<CMSampleBuffer, VTStatus>)GCHandle.FromIntPtr(callbackInfo).Target;
		CMSampleBuffer arg = new CMSampleBuffer(sampleBufferPtr, owns: false);
		return func(arg);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTFrameSiloCallFunctionForEachSampleBuffer(IntPtr silo, CMTimeRange timeRange, IntPtr callbackInfo, EachSampleBufferCallback callback);

	public VTStatus ForEach(Func<CMSampleBuffer, VTStatus> callback, CMTimeRange? range = null)
	{
		callbackHandle = GCHandle.Alloc(callback);
		VTStatus result = VTFrameSiloCallFunctionForEachSampleBuffer(handle, range ?? CMTimeRange.InvalidRange, GCHandle.ToIntPtr(callbackHandle), static_EachSampleBufferCallback);
		callbackHandle.Free();
		return result;
	}
}
