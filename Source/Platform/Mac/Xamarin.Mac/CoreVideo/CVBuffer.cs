using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Since(4, 0)]
public class CVBuffer : INativeObject, IDisposable
{
	public static readonly NSString MovieTimeKey;

	public static readonly NSString TimeValueKey;

	public static readonly NSString TimeScaleKey;

	public static readonly NSString PropagatedAttachmentsKey;

	public static readonly NSString NonPropagatedAttachmentsKey;

	internal IntPtr handle;

	public IntPtr Handle => handle;

	static CVBuffer()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			MovieTimeKey = Dlfcn.GetStringConstant(intPtr, "kCVBufferMovieTimeKey");
			TimeValueKey = Dlfcn.GetStringConstant(intPtr, "kCVBufferTimeValueKey");
			TimeScaleKey = Dlfcn.GetStringConstant(intPtr, "kCVBufferTimeScaleKey");
			PropagatedAttachmentsKey = Dlfcn.GetStringConstant(intPtr, "kCVBufferPropagatedAttachmentsKey");
			NonPropagatedAttachmentsKey = Dlfcn.GetStringConstant(intPtr, "kCVBufferNonPropagatedAttachmentsKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	internal CVBuffer()
	{
	}

	internal CVBuffer(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to context creation");
		}
		CVBufferRetain(handle);
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CVBuffer(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CVBufferRetain(handle);
		}
		this.handle = handle;
	}

	~CVBuffer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CVBufferRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferRemoveAllAttachments(IntPtr buffer);

	public void RemoveAllAttachments()
	{
		CVBufferRemoveAllAttachments(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferRemoveAttachment(IntPtr buffer, IntPtr key);

	public void RemoveAttachment(NSString key)
	{
		CVBufferRemoveAttachment(handle, key.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVBufferGetAttachment(IntPtr buffer, IntPtr key, out CVAttachmentMode attachmentMode);

	public NSObject GetAttachment(NSString key, out CVAttachmentMode attachmentMode)
	{
		return Runtime.GetNSObject(CVBufferGetAttachment(handle, key.Handle, out attachmentMode));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVBufferGetAttachments(IntPtr buffer, CVAttachmentMode attachmentMode);

	public NSDictionary GetAttachments(CVAttachmentMode attachmentMode)
	{
		return (NSDictionary)Runtime.GetNSObject(CVBufferGetAttachments(handle, attachmentMode));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferPropagateAttachments(IntPtr sourceBuffer, IntPtr destinationBuffer);

	public void PropogateAttachments(CVBuffer destinationBuffer)
	{
		CVBufferPropagateAttachments(handle, destinationBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferSetAttachment(IntPtr buffer, IntPtr key, IntPtr value, CVAttachmentMode attachmentMode);

	public void SetAttachment(NSString key, NSObject value, CVAttachmentMode attachmentMode)
	{
		CVBufferSetAttachment(handle, key.Handle, value.Handle, attachmentMode);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferSetAttachments(IntPtr buffer, IntPtr theAttachments, CVAttachmentMode attachmentMode);

	public void SetAttachments(NSDictionary theAttachments, CVAttachmentMode attachmentMode)
	{
		CVBufferSetAttachments(handle, theAttachments.Handle, attachmentMode);
	}
}
