using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreMedia;

public class CMBufferQueue : INativeObject, IDisposable
{
	private delegate CMTime BufferGetTimeCallback(IntPtr buf, IntPtr refcon);

	private delegate bool BufferGetBooleanCallback(IntPtr buf, IntPtr refcon);

	private delegate int BufferCompareCallback(IntPtr buf1, IntPtr buf2, IntPtr refcon);

	private delegate nint BufferGetSizeCallback(IntPtr buffer, IntPtr refcon);

	private struct CMBufferCallbacks
	{
		internal uint version;

		internal IntPtr refcon;

		internal BufferGetTimeCallback XgetDecodeTimeStamp;

		internal BufferGetTimeCallback XgetPresentationTimeStamp;

		internal BufferGetTimeCallback XgetDuration;

		internal BufferGetBooleanCallback XisDataReady;

		internal BufferCompareCallback Xcompare;

		internal IntPtr cfStringPtr_dataBecameReadyNotification;

		internal BufferGetSizeCallback XgetSize;
	}

	private struct CMBufferCallbacks2
	{
		internal uint version;

		internal IntPtr refcon;

		internal IntPtr XgetDecodeTimeStamp;

		internal IntPtr XgetPresentationTimeStamp;

		internal IntPtr XgetDuration;

		internal IntPtr XisDataReady;

		internal IntPtr Xcompare;

		internal IntPtr cfStringPtr_dataBecameReadyNotification;

		internal IntPtr XgetSize;
	}

	[Watch(6, 0)]
	public enum TriggerCondition
	{
		WhenDurationBecomesLessThan = 1,
		WhenDurationBecomesLessThanOrEqualTo,
		WhenDurationBecomesGreaterThan,
		WhenDurationBecomesGreaterThanOrEqualTo,
		WhenMinPresentationTimeStampChanges,
		WhenMaxPresentationTimeStampChanges,
		WhenDataBecomesReady,
		WhenEndOfDataReached,
		WhenReset,
		WhenBufferCountBecomesLessThan,
		WhenBufferCountBecomesGreaterThan,
		WhenDurationBecomesGreaterThanOrEqualToAndBufferCountBecomesGreaterThan
	}

	private GCHandle gch;

	private Dictionary<IntPtr, INativeObject> queueObjects;

	internal IntPtr handle;

	private CMBufferGetTime getDecodeTimeStamp;

	private CMBufferGetTime getPresentationTimeStamp;

	private CMBufferGetTime getDuration;

	private CMBufferGetBool isDataReady;

	private CMBufferCompare compare;

	private CMBufferGetSize getTotalSize;

	public IntPtr Handle => handle;

	public bool IsEmpty => CMBufferQueueIsEmpty(handle) != 0;

	public bool ContainsEndOfData => CMBufferQueueContainsEndOfData(handle) != 0;

	public bool IsAtEndOfData => CMBufferQueueIsAtEndOfData(handle) != 0;

	public nint BufferCount => CMBufferQueueGetBufferCount(handle);

	public CMTime Duration => CMBufferQueueGetDuration(handle);

	~CMBufferQueue()
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
		queueObjects = null;
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern int CMBufferQueueCreate(IntPtr allocator, nint capacity, CMBufferCallbacks cbacks, out IntPtr result);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern int CMBufferQueueCreate(IntPtr allocator, nint capacity, IntPtr cbacks, out IntPtr result);

	internal CMBufferQueue(int count)
	{
		queueObjects = new Dictionary<IntPtr, INativeObject>(count, Runtime.IntPtrEqualityComparer);
		gch = GCHandle.Alloc(this);
	}

	public static CMBufferQueue FromCallbacks(int count, CMBufferGetTime getDecodeTimeStamp, CMBufferGetTime getPresentationTimeStamp, CMBufferGetTime getDuration, CMBufferGetBool isDataReady, CMBufferCompare compare, NSString dataBecameReadyNotification)
	{
		return FromCallbacks(count, getDecodeTimeStamp, getPresentationTimeStamp, getDuration, isDataReady, compare, dataBecameReadyNotification, null);
	}

	public static CMBufferQueue FromCallbacks(int count, CMBufferGetTime getDecodeTimeStamp, CMBufferGetTime getPresentationTimeStamp, CMBufferGetTime getDuration, CMBufferGetBool isDataReady, CMBufferCompare compare, NSString dataBecameReadyNotification, CMBufferGetSize getTotalSize)
	{
		CMBufferQueue cMBufferQueue = new CMBufferQueue(count);
		CMBufferCallbacks cMBufferCallbacks = default(CMBufferCallbacks);
		cMBufferCallbacks.version = ((getTotalSize != null) ? 1u : 0u);
		cMBufferCallbacks.refcon = GCHandle.ToIntPtr(cMBufferQueue.gch);
		cMBufferCallbacks.XgetDecodeTimeStamp = ((getDecodeTimeStamp == null) ? null : new BufferGetTimeCallback(GetDecodeTimeStamp));
		cMBufferCallbacks.XgetPresentationTimeStamp = ((getPresentationTimeStamp == null) ? null : new BufferGetTimeCallback(GetPresentationTimeStamp));
		cMBufferCallbacks.XgetDuration = ((getDuration == null) ? null : new BufferGetTimeCallback(GetDuration));
		cMBufferCallbacks.XisDataReady = ((isDataReady == null) ? null : new BufferGetBooleanCallback(GetDataReady));
		cMBufferCallbacks.Xcompare = ((compare == null) ? null : new BufferCompareCallback(Compare));
		cMBufferCallbacks.cfStringPtr_dataBecameReadyNotification = ((dataBecameReadyNotification == null) ? IntPtr.Zero : dataBecameReadyNotification.Handle);
		cMBufferCallbacks.XgetSize = ((getTotalSize == null) ? null : new BufferGetSizeCallback(GetTotalSize));
		CMBufferCallbacks cbacks = cMBufferCallbacks;
		cMBufferQueue.getDecodeTimeStamp = getDecodeTimeStamp;
		cMBufferQueue.getPresentationTimeStamp = getPresentationTimeStamp;
		cMBufferQueue.getDuration = getDuration;
		cMBufferQueue.isDataReady = isDataReady;
		cMBufferQueue.compare = compare;
		cMBufferQueue.getTotalSize = getTotalSize;
		if (CMBufferQueueCreate(IntPtr.Zero, count, cbacks, out cMBufferQueue.handle) == 0)
		{
			return cMBufferQueue;
		}
		cMBufferQueue.Dispose();
		return null;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMBufferQueueGetCallbacksForUnsortedSampleBuffers();

	public static CMBufferQueue CreateUnsorted(int count)
	{
		CMBufferQueue cMBufferQueue = new CMBufferQueue(count);
		IntPtr cbacks = CMBufferQueueGetCallbacksForUnsortedSampleBuffers();
		if (CMBufferQueueCreate(IntPtr.Zero, count, cbacks, out cMBufferQueue.handle) == 0)
		{
			return cMBufferQueue;
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern int CMBufferQueueEnqueue(IntPtr queue, IntPtr buf);

	public void Enqueue(INativeObject cftypeBuffer)
	{
		if (cftypeBuffer == null)
		{
			throw new ArgumentNullException("cftypeBuffer");
		}
		lock (queueObjects)
		{
			IntPtr intPtr = cftypeBuffer.Handle;
			CMBufferQueueEnqueue(handle, intPtr);
			if (!queueObjects.ContainsKey(intPtr))
			{
				queueObjects[intPtr] = cftypeBuffer;
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMBufferQueueDequeueAndRetain(IntPtr queue);

	public INativeObject Dequeue()
	{
		IntPtr intPtr = CMBufferQueueDequeueAndRetain(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		CFObject.CFRelease(intPtr);
		lock (queueObjects)
		{
			INativeObject result = queueObjects[intPtr];
			queueObjects.Remove(intPtr);
			return result;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMBufferQueueDequeueIfDataReadyAndRetain(IntPtr queue);

	public INativeObject DequeueIfDataReady()
	{
		IntPtr intPtr = CMBufferQueueDequeueIfDataReadyAndRetain(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		CFObject.CFRelease(intPtr);
		lock (queueObjects)
		{
			INativeObject result = queueObjects[intPtr];
			queueObjects.Remove(intPtr);
			return result;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern byte CMBufferQueueIsEmpty(IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern int CMBufferQueueMarkEndOfData(IntPtr queue);

	public int MarkEndOfData()
	{
		return CMBufferQueueMarkEndOfData(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern byte CMBufferQueueContainsEndOfData(IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern byte CMBufferQueueIsAtEndOfData(IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern int CMBufferQueueReset(IntPtr queue);

	public int Reset()
	{
		return CMBufferQueueReset(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nint CMBufferQueueGetBufferCount(IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMBufferQueueGetDuration(IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(7, 1)]
	[Mac(10, 10)]
	private static extern nint CMBufferQueueGetTotalSize(IntPtr queue);

	[iOS(7, 1)]
	[Mac(10, 10)]
	public nint GetTotalSize()
	{
		return CMBufferQueueGetTotalSize(handle);
	}

	private INativeObject Surface(IntPtr v)
	{
		return queueObjects[v];
	}

	private static CMTime GetDecodeTimeStamp(IntPtr buffer, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.getDecodeTimeStamp(cMBufferQueue.Surface(buffer));
	}

	private static CMTime GetPresentationTimeStamp(IntPtr buffer, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.getPresentationTimeStamp(cMBufferQueue.Surface(buffer));
	}

	private static CMTime GetDuration(IntPtr buffer, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.getDuration(cMBufferQueue.Surface(buffer));
	}

	private static bool GetDataReady(IntPtr buffer, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.isDataReady(cMBufferQueue.Surface(buffer));
	}

	private static int Compare(IntPtr buffer1, IntPtr buffer2, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.compare(cMBufferQueue.Surface(buffer1), cMBufferQueue.Surface(buffer2));
	}

	private static nint GetTotalSize(IntPtr buffer, IntPtr refcon)
	{
		CMBufferQueue cMBufferQueue = (CMBufferQueue)GCHandle.FromIntPtr(refcon).Target;
		return cMBufferQueue.getTotalSize(cMBufferQueue.Surface(buffer));
	}
}
