using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMSampleBuffer : ICMAttachmentBearer, INativeObject, IDisposable
{
	private delegate CMSampleBufferError CMSampleBufferCallForEachSampleCallback(IntPtr sampleBuffer, int index, IntPtr refcon);

	private delegate void CMSampleBufferInvalidateCallback(IntPtr sbuf, ulong invalidateRefCon);

	internal IntPtr handle;

	private GCHandle invalidate;

	public IntPtr Handle => handle;

	public bool DataIsReady => CMSampleBufferDataIsReady(handle);

	public CMTime DecodeTimeStamp => CMSampleBufferGetDecodeTimeStamp(handle);

	public CMTime Duration => CMSampleBufferGetDuration(handle);

	public nint NumSamples => CMSampleBufferGetNumSamples(handle);

	public CMTime OutputDecodeTimeStamp => CMSampleBufferGetOutputDecodeTimeStamp(handle);

	public CMTime OutputDuration => CMSampleBufferGetOutputDuration(handle);

	public CMTime OutputPresentationTimeStamp => CMSampleBufferGetOutputPresentationTimeStamp(handle);

	public CMTime PresentationTimeStamp
	{
		get
		{
			return CMSampleBufferGetPresentationTimeStamp(handle);
		}
		set
		{
			CMSampleBufferError cMSampleBufferError = CMSampleBufferSetOutputPresentationTimeStamp(handle, value);
			if (cMSampleBufferError != 0)
			{
				throw new ArgumentException(cMSampleBufferError.ToString());
			}
		}
	}

	public nuint TotalSampleSize => CMSampleBufferGetTotalSampleSize(handle);

	public bool IsValid => CMSampleBufferIsValid(handle);

	internal CMSampleBuffer(IntPtr handle)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CMSampleBuffer(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CMSampleBuffer()
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
		if (invalidate.IsAllocated)
		{
			invalidate.Free();
		}
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMAudioSampleBufferCreateWithPacketDescriptions(IntPtr allocator, IntPtr dataBuffer, bool dataReady, IntPtr makeDataReadyCallback, IntPtr makeDataReadyRefcon, IntPtr formatDescription, nint numSamples, CMTime sbufPTS, AudioStreamPacketDescription[] packetDescriptions, out IntPtr sBufOut);

	public static CMSampleBuffer CreateWithPacketDescriptions(CMBlockBuffer dataBuffer, CMFormatDescription formatDescription, int samplesCount, CMTime sampleTimestamp, AudioStreamPacketDescription[] packetDescriptions, out CMSampleBufferError error)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (samplesCount <= 0)
		{
			throw new ArgumentOutOfRangeException("samplesCount");
		}
		error = CMAudioSampleBufferCreateWithPacketDescriptions(IntPtr.Zero, dataBuffer?.handle ?? IntPtr.Zero, dataReady: true, IntPtr.Zero, IntPtr.Zero, formatDescription.handle, samplesCount, sampleTimestamp, packetDescriptions, out var sBufOut);
		if (error != 0)
		{
			return null;
		}
		return new CMSampleBuffer(sBufOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private unsafe static extern nint CMSampleBufferCreateCopyWithNewTiming(IntPtr allocator, IntPtr originalSBuf, nint numSampleTimingEntries, CMSampleTimingInfo* sampleTimingArray, out IntPtr sBufCopyOut);

	public static CMSampleBuffer CreateWithNewTiming(CMSampleBuffer original, CMSampleTimingInfo[] timing)
	{
		nint status;
		return CreateWithNewTiming(original, timing, out status);
	}

	public unsafe static CMSampleBuffer CreateWithNewTiming(CMSampleBuffer original, CMSampleTimingInfo[] timing, out nint status)
	{
		if (original == null)
		{
			throw new ArgumentNullException("original");
		}
		nint numSampleTimingEntries = ((timing != null) ? timing.Length : 0);
		IntPtr sBufCopyOut;
		fixed (CMSampleTimingInfo* sampleTimingArray = timing)
		{
			if ((status = CMSampleBufferCreateCopyWithNewTiming(IntPtr.Zero, original.Handle, numSampleTimingEntries, sampleTimingArray, out sBufCopyOut)) != 0)
			{
				return null;
			}
		}
		return new CMSampleBuffer(sBufCopyOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferCallForEachSample(IntPtr sbuf, CMSampleBufferCallForEachSampleCallback callback, IntPtr refcon);

	private static CMSampleBufferError ForEachSampleHandler(IntPtr sbuf, int index, IntPtr refCon)
	{
		if (!(GCHandle.FromIntPtr(refCon).Target is Tuple<Func<CMSampleBuffer, int, CMSampleBufferError>, CMSampleBuffer> tuple))
		{
			return CMSampleBufferError.RequiredParameterMissing;
		}
		return tuple.Item1(tuple.Item2, index);
	}

	public CMSampleBufferError CallForEachSample(Func<CMSampleBuffer, int, CMSampleBufferError> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		GCHandle gCHandle = GCHandle.Alloc(Tuple.Create(callback, this));
		CMSampleBufferError result = CMSampleBufferCallForEachSample(handle, ForEachSampleHandler, (IntPtr)gCHandle);
		gCHandle.Free();
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferCreateForImageBuffer(IntPtr allocator, IntPtr imageBuffer, bool dataReady, IntPtr makeDataReadyCallback, IntPtr makeDataReadyRefcon, IntPtr formatDescription, ref CMSampleTimingInfo sampleTiming, out IntPtr bufOut);

	public static CMSampleBuffer CreateForImageBuffer(CVImageBuffer imageBuffer, bool dataReady, CMVideoFormatDescription formatDescription, CMSampleTimingInfo sampleTiming, out CMSampleBufferError error)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		error = CMSampleBufferCreateForImageBuffer(IntPtr.Zero, imageBuffer.handle, dataReady, IntPtr.Zero, IntPtr.Zero, formatDescription.handle, ref sampleTiming, out var bufOut);
		if (error != 0)
		{
			return null;
		}
		return new CMSampleBuffer(bufOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern bool CMSampleBufferDataIsReady(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetDataBuffer(IntPtr sbuf);

	public CMBlockBuffer GetDataBuffer()
	{
		IntPtr intPtr = CMSampleBufferGetDataBuffer(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMBlockBuffer(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetDecodeTimeStamp(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetDuration(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetFormatDescription(IntPtr sbuf);

	public CMAudioFormatDescription GetAudioFormatDescription()
	{
		IntPtr intPtr = CMSampleBufferGetFormatDescription(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMAudioFormatDescription(intPtr, owns: false);
	}

	public CMVideoFormatDescription GetVideoFormatDescription()
	{
		IntPtr intPtr = CMSampleBufferGetFormatDescription(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMVideoFormatDescription(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetImageBuffer(IntPtr sbuf);

	public CVImageBuffer GetImageBuffer()
	{
		IntPtr intPtr = CMSampleBufferGetImageBuffer(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		nint typeID = CFType.GetTypeID(intPtr);
		if (typeID == CVPixelBuffer.GetTypeID())
		{
			return new CVPixelBuffer(intPtr, owns: false);
		}
		return new CVImageBuffer(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nint CMSampleBufferGetNumSamples(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputDecodeTimeStamp(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputDuration(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputPresentationTimeStamp(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetOutputPresentationTimeStamp(IntPtr sbuf, CMTime outputPresentationTimeStamp);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMSampleBufferGetPresentationTimeStamp(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetSampleAttachmentsArray(IntPtr sbuf, bool createIfNecessary);

	public CMSampleBufferAttachmentSettings[] GetSampleAttachments(bool createIfNecessary)
	{
		IntPtr intPtr = CMSampleBufferGetSampleAttachmentsArray(handle, createIfNecessary);
		if (intPtr == IntPtr.Zero)
		{
			return new CMSampleBufferAttachmentSettings[0];
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr h) => new CMSampleBufferAttachmentSettings((NSMutableDictionary)Runtime.GetNSObject(h)));
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nuint CMSampleBufferGetSampleSize(IntPtr sbuf, nint sampleIndex);

	public nuint GetSampleSize(nint sampleIndex)
	{
		return CMSampleBufferGetSampleSize(handle, sampleIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private unsafe static extern nint CMSampleBufferGetSampleTimingInfoArray(IntPtr sbuf, nint timingArrayEntries, CMSampleTimingInfo* timingArrayOut, out nint timingArrayEntriesNeededOut);

	public CMSampleTimingInfo[] GetSampleTimingInfo()
	{
		nint status;
		return GetSampleTimingInfo(out status);
	}

	public unsafe CMSampleTimingInfo[] GetSampleTimingInfo(out nint status)
	{
		status = 0;
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		if ((status = CMSampleBufferGetSampleTimingInfoArray(handle, 0, null, out var timingArrayEntriesNeededOut)) != 0)
		{
			return null;
		}
		CMSampleTimingInfo[] array = new CMSampleTimingInfo[(long)timingArrayEntriesNeededOut];
		if (timingArrayEntriesNeededOut == 0)
		{
			return array;
		}
		fixed (CMSampleTimingInfo* timingArrayOut = array)
		{
			if ((status = CMSampleBufferGetSampleTimingInfoArray(handle, timingArrayEntriesNeededOut, timingArrayOut, out timingArrayEntriesNeededOut)) != 0)
			{
				return null;
			}
		}
		return array;
	}

	private static string OSStatusToString(nint status)
	{
		return new NSError(NSError.OsStatusErrorDomain, status).LocalizedDescription;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nuint CMSampleBufferGetTotalSampleSize(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nint CMSampleBufferGetTypeID();

	public static nint GetTypeID()
	{
		return CMSampleBufferGetTypeID();
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferInvalidate(IntPtr sbuf);

	public CMSampleBufferError Invalidate()
	{
		return CMSampleBufferInvalidate(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern bool CMSampleBufferIsValid(IntPtr sbuf);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferMakeDataReady(IntPtr handle);

	public CMSampleBufferError MakeDataReady()
	{
		return CMSampleBufferMakeDataReady(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetDataBuffer(IntPtr handle, IntPtr dataBufferHandle);

	public CMSampleBufferError SetDataBuffer(CMBlockBuffer dataBuffer)
	{
		IntPtr dataBufferHandle = dataBuffer?.handle ?? IntPtr.Zero;
		return CMSampleBufferSetDataBuffer(handle, dataBufferHandle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetDataReady(IntPtr sbuf);

	public CMSampleBufferError SetDataReady()
	{
		return CMSampleBufferSetDataReady(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetInvalidateCallback(IntPtr sbuf, CMSampleBufferInvalidateCallback invalidateCallback, ulong invalidateRefCon);

	private static void InvalidateHandler(IntPtr sbuf, ulong invalidateRefCon)
	{
		if (GCHandle.FromIntPtr((IntPtr)(long)invalidateRefCon).Target is Tuple<Action<CMSampleBuffer>, CMSampleBuffer> tuple)
		{
			tuple.Item1(tuple.Item2);
		}
	}

	public CMSampleBufferError SetInvalidateCallback(Action<CMSampleBuffer> invalidateHandler)
	{
		if (invalidateHandler == null)
		{
			if (invalidate.IsAllocated)
			{
				invalidate.Free();
			}
			return CMSampleBufferSetInvalidateCallback(handle, null, 0uL);
		}
		if (invalidate.IsAllocated)
		{
			return CMSampleBufferError.RequiredParameterMissing;
		}
		invalidate = GCHandle.Alloc(Tuple.Create(invalidateHandler, this));
		return CMSampleBufferSetInvalidateCallback(handle, InvalidateHandler, (ulong)(long)(IntPtr)invalidate);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferTrackDataReadiness(IntPtr sbuf, IntPtr sbufToTrack);

	public CMSampleBufferError TrackDataReadiness(CMSampleBuffer bufferToTrack)
	{
		IntPtr sbufToTrack = bufferToTrack?.handle ?? IntPtr.Zero;
		return CMSampleBufferTrackDataReadiness(handle, sbufToTrack);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern CMSampleBufferError CMSampleBufferCopyPCMDataIntoAudioBufferList(IntPtr sbuf, int frameOffset, int numFrames, IntPtr bufferList);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public CMSampleBufferError CopyPCMDataIntoAudioBufferList(int frameOffset, int numFrames, AudioBuffers bufferList)
	{
		if (bufferList == null)
		{
			throw new ArgumentNullException("bufferList");
		}
		return CMSampleBufferCopyPCMDataIntoAudioBufferList(handle, frameOffset, numFrames, (IntPtr)bufferList);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern CMSampleBufferError CMAudioSampleBufferCreateReadyWithPacketDescriptions(IntPtr allocator, IntPtr dataBuffer, IntPtr formatDescription, nint numSamples, CMTime sbufPTS, AudioStreamPacketDescription[] packetDescriptions, out IntPtr sBufOut);

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static CMSampleBuffer CreateReadyWithPacketDescriptions(CMBlockBuffer dataBuffer, CMFormatDescription formatDescription, int samplesCount, CMTime sampleTimestamp, AudioStreamPacketDescription[] packetDescriptions, out CMSampleBufferError error)
	{
		if (dataBuffer == null)
		{
			throw new ArgumentNullException("dataBuffer");
		}
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (samplesCount <= 0)
		{
			throw new ArgumentOutOfRangeException("samplesCount");
		}
		error = CMAudioSampleBufferCreateReadyWithPacketDescriptions(IntPtr.Zero, dataBuffer.handle, formatDescription.handle, samplesCount, sampleTimestamp, packetDescriptions, out var sBufOut);
		if (error != 0)
		{
			return null;
		}
		return new CMSampleBuffer(sBufOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern CMSampleBufferError CMSampleBufferCreateReady(IntPtr allocator, IntPtr dataBuffer, IntPtr formatDescription, nint numSamples, nint numSampleTimingEntries, CMSampleTimingInfo[] sampleTimingArray, nint numSampleSizeEntries, nuint[] sampleSizeArray, out IntPtr sBufOut);

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static CMSampleBuffer CreateReady(CMBlockBuffer dataBuffer, CMFormatDescription formatDescription, int samplesCount, CMSampleTimingInfo[] sampleTimingArray, nuint[] sampleSizeArray, out CMSampleBufferError error)
	{
		if (dataBuffer == null)
		{
			throw new ArgumentNullException("dataBuffer");
		}
		if (samplesCount < 0)
		{
			throw new ArgumentOutOfRangeException("samplesCount");
		}
		IntPtr formatDescription2 = formatDescription?.Handle ?? IntPtr.Zero;
		int num = ((sampleTimingArray != null) ? sampleTimingArray.Length : 0);
		int num2 = ((sampleSizeArray != null) ? sampleSizeArray.Length : 0);
		error = CMSampleBufferCreateReady(IntPtr.Zero, dataBuffer.handle, formatDescription2, samplesCount, num, sampleTimingArray, num2, sampleSizeArray, out var sBufOut);
		if (error != 0)
		{
			return null;
		}
		return new CMSampleBuffer(sBufOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern CMSampleBufferError CMSampleBufferCreateReadyWithImageBuffer(IntPtr allocator, IntPtr imageBuffer, IntPtr formatDescription, ref CMSampleTimingInfo sampleTiming, out IntPtr sBufOut);

	[Obsolete("Use the 'CreateReadyWithImageBuffer' overload with a single ref, not array, 'CMSampleTimingInfo' parameter.")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	public static CMSampleBuffer CreateReadyWithImageBuffer(CVImageBuffer imageBuffer, CMFormatDescription formatDescription, CMSampleTimingInfo[] sampleTiming, out CMSampleBufferError error)
	{
		if (sampleTiming == null)
		{
			throw new ArgumentNullException("sampleTiming");
		}
		if (sampleTiming.Length != 1)
		{
			throw new ArgumentException("Only a single sample is allowed.", "sampleTiming");
		}
		return CreateReadyWithImageBuffer(imageBuffer, formatDescription, sampleTiming, out error);
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static CMSampleBuffer CreateReadyWithImageBuffer(CVImageBuffer imageBuffer, CMFormatDescription formatDescription, ref CMSampleTimingInfo sampleTiming, out CMSampleBufferError error)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		error = CMSampleBufferCreateReadyWithImageBuffer(IntPtr.Zero, imageBuffer.handle, formatDescription.Handle, ref sampleTiming, out var sBufOut);
		if (error != 0)
		{
			return null;
		}
		return new CMSampleBuffer(sBufOut, owns: true);
	}
}
