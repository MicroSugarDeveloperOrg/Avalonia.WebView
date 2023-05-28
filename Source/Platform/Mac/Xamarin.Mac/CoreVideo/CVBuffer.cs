using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public class CVBuffer : INativeObject, IDisposable
{
	internal IntPtr handle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovieTimeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NonPropagatedAttachmentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropagatedAttachmentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeScaleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeValueKey;

	public IntPtr Handle => handle;

	[Field("kCVBufferMovieTimeKey", "CoreVideo")]
	public static NSString MovieTimeKey
	{
		get
		{
			if (_MovieTimeKey == null)
			{
				_MovieTimeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferMovieTimeKey");
			}
			return _MovieTimeKey;
		}
	}

	[Field("kCVBufferNonPropagatedAttachmentsKey", "CoreVideo")]
	public static NSString NonPropagatedAttachmentsKey
	{
		get
		{
			if (_NonPropagatedAttachmentsKey == null)
			{
				_NonPropagatedAttachmentsKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferNonPropagatedAttachmentsKey");
			}
			return _NonPropagatedAttachmentsKey;
		}
	}

	[Field("kCVBufferPropagatedAttachmentsKey", "CoreVideo")]
	public static NSString PropagatedAttachmentsKey
	{
		get
		{
			if (_PropagatedAttachmentsKey == null)
			{
				_PropagatedAttachmentsKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferPropagatedAttachmentsKey");
			}
			return _PropagatedAttachmentsKey;
		}
	}

	[Field("kCVBufferTimeScaleKey", "CoreVideo")]
	public static NSString TimeScaleKey
	{
		get
		{
			if (_TimeScaleKey == null)
			{
				_TimeScaleKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferTimeScaleKey");
			}
			return _TimeScaleKey;
		}
	}

	[Field("kCVBufferTimeValueKey", "CoreVideo")]
	public static NSString TimeValueKey
	{
		get
		{
			if (_TimeValueKey == null)
			{
				_TimeValueKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferTimeValueKey");
			}
			return _TimeValueKey;
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
	private static extern void CVBufferRelease(IntPtr buffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVBufferRetain(IntPtr buffer);

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
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		CVBufferRemoveAttachment(handle, key.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVBufferGetAttachment(IntPtr buffer, IntPtr key, out CVAttachmentMode attachmentMode);

	public NSObject GetAttachment(NSString key, out CVAttachmentMode attachmentMode)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(CVBufferGetAttachment(handle, key.Handle, out attachmentMode));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVBufferGetAttachments(IntPtr buffer, CVAttachmentMode attachmentMode);

	public NSDictionary GetAttachments(CVAttachmentMode attachmentMode)
	{
		return (NSDictionary)Runtime.GetNSObject(CVBufferGetAttachments(handle, attachmentMode));
	}

	public NSDictionary<TKey, TValue> GetAttachments<TKey, TValue>(CVAttachmentMode attachmentMode) where TKey : class, INativeObject where TValue : class, INativeObject
	{
		return Runtime.GetNSObject<NSDictionary<TKey, TValue>>(CVBufferGetAttachments(handle, attachmentMode));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferPropagateAttachments(IntPtr sourceBuffer, IntPtr destinationBuffer);

	public void PropogateAttachments(CVBuffer destinationBuffer)
	{
		if (destinationBuffer == null)
		{
			throw new ArgumentNullException("destinationBuffer");
		}
		CVBufferPropagateAttachments(handle, destinationBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferSetAttachment(IntPtr buffer, IntPtr key, IntPtr value, CVAttachmentMode attachmentMode);

	public void SetAttachment(NSString key, INativeObject value, CVAttachmentMode attachmentMode)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CVBufferSetAttachment(handle, key.Handle, value.Handle, attachmentMode);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVBufferSetAttachments(IntPtr buffer, IntPtr theAttachments, CVAttachmentMode attachmentMode);

	public void SetAttachments(NSDictionary theAttachments, CVAttachmentMode attachmentMode)
	{
		if (theAttachments == null)
		{
			throw new ArgumentNullException("theAttachments");
		}
		CVBufferSetAttachments(handle, theAttachments.Handle, attachmentMode);
	}
}
