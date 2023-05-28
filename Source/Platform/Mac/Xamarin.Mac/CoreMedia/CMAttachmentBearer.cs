using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public static class CMAttachmentBearer
{
	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMCopyDictionaryOfAttachments(IntPtr allocator, IntPtr target, CMAttachmentMode attachmentMode);

	public static NSDictionary GetAttachments(this ICMAttachmentBearer target, CMAttachmentMode attachmentMode)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		IntPtr intPtr = CMCopyDictionaryOfAttachments(IntPtr.Zero, target.Handle, attachmentMode);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject<NSDictionary>(intPtr, owns: true);
	}

	public static NSDictionary<TKey, TValue> GetAttachments<TKey, TValue>(this ICMAttachmentBearer target, CMAttachmentMode attachmentMode) where TKey : class, INativeObject where TValue : class, INativeObject
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		IntPtr intPtr = CMCopyDictionaryOfAttachments(IntPtr.Zero, target.Handle, attachmentMode);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject<NSDictionary<TKey, TValue>>(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMGetAttachment(IntPtr target, IntPtr key, out CMAttachmentMode attachmentModeOut);

	public static T GetAttachment<T>(this ICMAttachmentBearer target, string key, out CMAttachmentMode attachmentModeOut) where T : class, INativeObject
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		IntPtr intPtr2 = CMGetAttachment(target.Handle, intPtr, out attachmentModeOut);
		NSString.ReleaseNative(intPtr);
		if (intPtr2 != IntPtr.Zero)
		{
			return Runtime.GetINativeObject<T>(intPtr2, owns: false);
		}
		return null;
	}

	public static T GetAttachment<T>(this ICMAttachmentBearer target, CMSampleBufferAttachmentKey key, out CMAttachmentMode attachmentModeOut) where T : class, INativeObject
	{
		return target.GetAttachment<T>(key.GetConstant(), out attachmentModeOut);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMPropagateAttachments(IntPtr source, IntPtr destination);

	public static void PropagateAttachments(this ICMAttachmentBearer source, ICMAttachmentBearer destination)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		CMPropagateAttachments(source.Handle, destination.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMRemoveAllAttachments(IntPtr target);

	public static void RemoveAllAttachments(this ICMAttachmentBearer target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		CMRemoveAllAttachments(target.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMRemoveAttachment(IntPtr target, IntPtr key);

	public static void RemoveAttachment(this ICMAttachmentBearer target, string key)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		CMRemoveAttachment(target.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMSetAttachment(IntPtr target, IntPtr key, IntPtr value, CMAttachmentMode attachmentMode);

	public static void SetAttachment(this ICMAttachmentBearer target, string key, INativeObject value, CMAttachmentMode attachmentMode)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		CMSetAttachment(target.Handle, intPtr, value.Handle, attachmentMode);
		NSString.ReleaseNative(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMSetAttachments(IntPtr target, IntPtr theAttachments, CMAttachmentMode attachmentMode);

	public static void SetAttachments(this ICMAttachmentBearer target, NSDictionary theAttachments, CMAttachmentMode attachmentMode)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (theAttachments == null)
		{
			throw new ArgumentNullException("theAttachments");
		}
		CMSetAttachments(target.Handle, theAttachments.Handle, attachmentMode);
	}
}
