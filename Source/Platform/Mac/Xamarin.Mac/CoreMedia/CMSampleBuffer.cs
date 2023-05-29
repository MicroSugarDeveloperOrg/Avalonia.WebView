using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Since(4, 0)]
public class CMSampleBuffer : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public bool DataIsReady => CMSampleBufferDataIsReady(handle);

	public CMTime DecodeTimeStamp => CMSampleBufferGetDecodeTimeStamp(handle);

	public CMTime Duration => CMSampleBufferGetDuration(handle);

	public int NumSamples => CMSampleBufferGetNumSamples(handle);

	public CMTime OutputDecodeTimeStamp => CMSampleBufferGetOutputDecodeTimeStamp(handle);

	public CMTime OutputDuration => CMSampleBufferGetOutputDuration(handle);

	public CMTime OutputPresentationTimeStamp => CMSampleBufferGetOutputPresentationTimeStamp(handle);

	public CMTime PresentationTimeStamp => CMSampleBufferGetPresentationTimeStamp(handle);

	public uint TotalSampleSize => CMSampleBufferGetTotalSampleSize(handle);

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
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMAudioSampleBufferCreateWithPacketDescriptions(IntPtr allocator, IntPtr dataBuffer, bool dataReady, IntPtr makeDataReadyCallback, IntPtr makeDataReadyRefcon, IntPtr formatDescription, int numSamples, CMTime sbufPTS, AudioStreamPacketDescription[] packetDescriptions, out IntPtr sBufOut);

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

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private unsafe static extern int CMSampleBufferCreateCopyWithNewTiming(IntPtr allocator, IntPtr originalSBuf, int numSampleTimingEntries, CMSampleTimingInfo* sampleTimingArray, out IntPtr sBufCopyOut);

	public static CMSampleBuffer CreateWithNewTiming(CMSampleBuffer original, CMSampleTimingInfo[] timing)
	{
		int status;
		return CreateWithNewTiming(original, timing, out status);
	}

	public unsafe static CMSampleBuffer CreateWithNewTiming(CMSampleBuffer original, CMSampleTimingInfo[] timing, out int status)
	{
		IntPtr sBufCopyOut;
		fixed (CMSampleTimingInfo* sampleTimingArray = timing)
		{
			if ((status = CMSampleBufferCreateCopyWithNewTiming(IntPtr.Zero, original.Handle, timing.Length, sampleTimingArray, out sBufCopyOut)) != 0)
			{
				return null;
			}
		}
		return new CMSampleBuffer(sBufCopyOut, owns: true);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
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

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern bool CMSampleBufferDataIsReady(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetDataBuffer(IntPtr handle);

	public CMBlockBuffer GetDataBuffer()
	{
		IntPtr intPtr = CMSampleBufferGetDataBuffer(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMBlockBuffer(intPtr, owns: false);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetDecodeTimeStamp(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetDuration(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetFormatDescription(IntPtr handle);

	[Advice("Use GetAudioFormatDescription or GetVideoFormatDescription")]
	public CMFormatDescription GetFormatDescription()
	{
		CMFormatDescription result = null;
		IntPtr intPtr = CMSampleBufferGetFormatDescription(handle);
		if (intPtr != IntPtr.Zero)
		{
			result = new CMFormatDescription(intPtr, owns: false);
		}
		return result;
	}

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

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetImageBuffer(IntPtr handle);

	public CVImageBuffer GetImageBuffer()
	{
		IntPtr intPtr = CMSampleBufferGetImageBuffer(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		if (CFType.GetTypeID(intPtr) == CVPixelBuffer.CVImageBufferType)
		{
			return new CVPixelBuffer(intPtr, owns: false);
		}
		return new CVImageBuffer(intPtr, owns: false);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern int CMSampleBufferGetNumSamples(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputDecodeTimeStamp(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputDuration(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetOutputPresentationTimeStamp(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetOutputPresentationTimeStamp(IntPtr handle, CMTime outputPresentationTimeStamp);

	public int SetOutputPresentationTimeStamp(CMTime outputPresentationTimeStamp)
	{
		return (int)CMSampleBufferSetOutputPresentationTimeStamp(handle, outputPresentationTimeStamp);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSampleBufferGetPresentationTimeStamp(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMSampleBufferGetSampleAttachmentsArray(IntPtr handle, bool createIfNecessary);

	public CMSampleBufferAttachmentSettings[] GetSampleAttachments(bool createIfNecessary)
	{
		IntPtr intPtr = CMSampleBufferGetSampleAttachmentsArray(handle, createIfNecessary);
		if (intPtr == IntPtr.Zero)
		{
			return new CMSampleBufferAttachmentSettings[0];
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr h) => new CMSampleBufferAttachmentSettings((NSMutableDictionary)Runtime.GetNSObject(h)));
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern uint CMSampleBufferGetSampleSize(IntPtr handle, int sampleIndex);

	public uint GetSampleSize(int sampleIndex)
	{
		return CMSampleBufferGetSampleSize(handle, sampleIndex);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private unsafe static extern int CMSampleBufferGetSampleTimingInfoArray(IntPtr sbuf, int timingArrayEntries, CMSampleTimingInfo* timingArrayOut, out int timingArrayEntriesNeededOut);

	public CMSampleTimingInfo[] GetSampleTimingInfo()
	{
		int status;
		return GetSampleTimingInfo(out status);
	}

	public unsafe CMSampleTimingInfo[] GetSampleTimingInfo(out int status)
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
		CMSampleTimingInfo[] array = new CMSampleTimingInfo[timingArrayEntriesNeededOut];
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

	private static string OSStatusToString(int status)
	{
		return new NSError(NSError.OsStatusErrorDomain, status).LocalizedDescription;
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern uint CMSampleBufferGetTotalSampleSize(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern int CMSampleBufferGetTypeID();

	public static int GetTypeID()
	{
		return CMSampleBufferGetTypeID();
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferInvalidate(IntPtr handle);

	public int Invalidate()
	{
		return (int)CMSampleBufferInvalidate(handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern bool CMSampleBufferIsValid(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferMakeDataReady(IntPtr handle);

	public int MakeDataReady()
	{
		return (int)CMSampleBufferMakeDataReady(handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetDataBuffer(IntPtr handle, IntPtr dataBufferHandle);

	public int SetDataBuffer(CMBlockBuffer dataBuffer)
	{
		IntPtr zero = IntPtr.Zero;
		if (dataBuffer != null)
		{
			zero = dataBuffer.handle;
		}
		return (int)CMSampleBufferSetDataBuffer(handle, zero);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferSetDataReady(IntPtr handle);

	public int SetDataReady()
	{
		return (int)CMSampleBufferSetDataReady(handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSampleBufferError CMSampleBufferTrackDataReadiness(IntPtr handle, IntPtr handleToTrack);

	public int TrackDataReadiness(CMSampleBuffer bufferToTrack)
	{
		IntPtr zero = IntPtr.Zero;
		if (bufferToTrack != null)
		{
			zero = bufferToTrack.handle;
		}
		return (int)CMSampleBufferTrackDataReadiness(handle, zero);
	}
}
