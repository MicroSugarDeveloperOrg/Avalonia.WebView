using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLCache", true)]
public class NSUrlCache : NSObject
{
	private static readonly IntPtr selSharedURLCacheHandle = Selector.GetHandle("sharedURLCache");

	private static readonly IntPtr selSetSharedURLCache_Handle = Selector.GetHandle("setSharedURLCache:");

	private static readonly IntPtr selMemoryCapacityHandle = Selector.GetHandle("memoryCapacity");

	private static readonly IntPtr selSetMemoryCapacity_Handle = Selector.GetHandle("setMemoryCapacity:");

	private static readonly IntPtr selDiskCapacityHandle = Selector.GetHandle("diskCapacity");

	private static readonly IntPtr selSetDiskCapacity_Handle = Selector.GetHandle("setDiskCapacity:");

	private static readonly IntPtr selCurrentMemoryUsageHandle = Selector.GetHandle("currentMemoryUsage");

	private static readonly IntPtr selCurrentDiskUsageHandle = Selector.GetHandle("currentDiskUsage");

	private static readonly IntPtr selInitWithMemoryCapacityDiskCapacityDiskPath_Handle = Selector.GetHandle("initWithMemoryCapacity:diskCapacity:diskPath:");

	private static readonly IntPtr selCachedResponseForRequest_Handle = Selector.GetHandle("cachedResponseForRequest:");

	private static readonly IntPtr selStoreCachedResponseForRequest_Handle = Selector.GetHandle("storeCachedResponse:forRequest:");

	private static readonly IntPtr selRemoveCachedResponseForRequest_Handle = Selector.GetHandle("removeCachedResponseForRequest:");

	private static readonly IntPtr selRemoveAllCachedResponsesHandle = Selector.GetHandle("removeAllCachedResponses");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLCache");

	private static object __mt_SharedCache_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSUrlCache SharedCache
	{
		[Export("sharedURLCache")]
		get
		{
			return (NSUrlCache)(__mt_SharedCache_var_static = (NSUrlCache)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedURLCacheHandle)));
		}
		[Export("setSharedURLCache:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetSharedURLCache_Handle, value.Handle);
		}
	}

	public virtual ulong MemoryCapacity
	{
		[Export("memoryCapacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMemoryCapacityHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMemoryCapacityHandle);
		}
		[Export("setMemoryCapacity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMemoryCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMemoryCapacity_Handle, value);
			}
		}
	}

	public virtual ulong DiskCapacity
	{
		[Export("diskCapacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selDiskCapacityHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDiskCapacityHandle);
		}
		[Export("setDiskCapacity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDiskCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDiskCapacity_Handle, value);
			}
		}
	}

	public virtual ulong CurrentMemoryUsage
	{
		[Export("currentMemoryUsage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCurrentMemoryUsageHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCurrentMemoryUsageHandle);
		}
	}

	public virtual ulong CurrentDiskUsage
	{
		[Export("currentDiskUsage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCurrentDiskUsageHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCurrentDiskUsageHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlCache()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlCache(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlCache(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlCache(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMemoryCapacity:diskCapacity:diskPath:")]
	public NSUrlCache(ulong memoryCapacity, ulong diskCapacity, string diskPath)
		: base(NSObjectFlag.Empty)
	{
		if (diskPath == null)
		{
			throw new ArgumentNullException("diskPath");
		}
		IntPtr arg = NSString.CreateNative(diskPath);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64_UInt64_IntPtr(base.Handle, selInitWithMemoryCapacityDiskCapacityDiskPath_Handle, memoryCapacity, diskCapacity, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr(base.SuperHandle, selInitWithMemoryCapacityDiskCapacityDiskPath_Handle, memoryCapacity, diskCapacity, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cachedResponseForRequest:")]
	public virtual NSCachedUrlResponse CachedResponseForRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (IsDirectBinding)
		{
			return (NSCachedUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCachedResponseForRequest_Handle, request.Handle));
		}
		return (NSCachedUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCachedResponseForRequest_Handle, request.Handle));
	}

	[Export("storeCachedResponse:forRequest:")]
	public virtual void StoreCachedResponse(NSCachedUrlResponse cachedResponse, NSUrlRequest forRequest)
	{
		if (cachedResponse == null)
		{
			throw new ArgumentNullException("cachedResponse");
		}
		if (forRequest == null)
		{
			throw new ArgumentNullException("forRequest");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStoreCachedResponseForRequest_Handle, cachedResponse.Handle, forRequest.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStoreCachedResponseForRequest_Handle, cachedResponse.Handle, forRequest.Handle);
		}
	}

	[Export("removeCachedResponseForRequest:")]
	public virtual void RemoveCachedResponse(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCachedResponseForRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCachedResponseForRequest_Handle, request.Handle);
		}
	}

	[Export("removeAllCachedResponses")]
	public virtual void RemoveAllCachedResponses()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllCachedResponsesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllCachedResponsesHandle);
		}
	}
}
