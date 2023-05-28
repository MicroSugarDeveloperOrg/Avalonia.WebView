using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLCache", true)]
public class NSUrlCache : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCachedResponseForRequest_ = "cachedResponseForRequest:";

	private static readonly IntPtr selCachedResponseForRequest_Handle = Selector.GetHandle("cachedResponseForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDiskUsage = "currentDiskUsage";

	private static readonly IntPtr selCurrentDiskUsageHandle = Selector.GetHandle("currentDiskUsage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentMemoryUsage = "currentMemoryUsage";

	private static readonly IntPtr selCurrentMemoryUsageHandle = Selector.GetHandle("currentMemoryUsage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiskCapacity = "diskCapacity";

	private static readonly IntPtr selDiskCapacityHandle = Selector.GetHandle("diskCapacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCachedResponseForDataTask_CompletionHandler_ = "getCachedResponseForDataTask:completionHandler:";

	private static readonly IntPtr selGetCachedResponseForDataTask_CompletionHandler_Handle = Selector.GetHandle("getCachedResponseForDataTask:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_ = "initWithMemoryCapacity:diskCapacity:directoryURL:";

	private static readonly IntPtr selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_Handle = Selector.GetHandle("initWithMemoryCapacity:diskCapacity:directoryURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMemoryCapacity_DiskCapacity_DiskPath_ = "initWithMemoryCapacity:diskCapacity:diskPath:";

	private static readonly IntPtr selInitWithMemoryCapacity_DiskCapacity_DiskPath_Handle = Selector.GetHandle("initWithMemoryCapacity:diskCapacity:diskPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMemoryCapacity = "memoryCapacity";

	private static readonly IntPtr selMemoryCapacityHandle = Selector.GetHandle("memoryCapacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllCachedResponses = "removeAllCachedResponses";

	private static readonly IntPtr selRemoveAllCachedResponsesHandle = Selector.GetHandle("removeAllCachedResponses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCachedResponseForDataTask_ = "removeCachedResponseForDataTask:";

	private static readonly IntPtr selRemoveCachedResponseForDataTask_Handle = Selector.GetHandle("removeCachedResponseForDataTask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCachedResponseForRequest_ = "removeCachedResponseForRequest:";

	private static readonly IntPtr selRemoveCachedResponseForRequest_Handle = Selector.GetHandle("removeCachedResponseForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCachedResponsesSinceDate_ = "removeCachedResponsesSinceDate:";

	private static readonly IntPtr selRemoveCachedResponsesSinceDate_Handle = Selector.GetHandle("removeCachedResponsesSinceDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiskCapacity_ = "setDiskCapacity:";

	private static readonly IntPtr selSetDiskCapacity_Handle = Selector.GetHandle("setDiskCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMemoryCapacity_ = "setMemoryCapacity:";

	private static readonly IntPtr selSetMemoryCapacity_Handle = Selector.GetHandle("setMemoryCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSharedURLCache_ = "setSharedURLCache:";

	private static readonly IntPtr selSetSharedURLCache_Handle = Selector.GetHandle("setSharedURLCache:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedURLCache = "sharedURLCache";

	private static readonly IntPtr selSharedURLCacheHandle = Selector.GetHandle("sharedURLCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreCachedResponse_ForDataTask_ = "storeCachedResponse:forDataTask:";

	private static readonly IntPtr selStoreCachedResponse_ForDataTask_Handle = Selector.GetHandle("storeCachedResponse:forDataTask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreCachedResponse_ForRequest_ = "storeCachedResponse:forRequest:";

	private static readonly IntPtr selStoreCachedResponse_ForRequest_Handle = Selector.GetHandle("storeCachedResponse:forRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLCache");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CurrentDiskUsage
	{
		[Export("currentDiskUsage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCurrentDiskUsageHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCurrentDiskUsageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CurrentMemoryUsage
	{
		[Export("currentMemoryUsage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCurrentMemoryUsageHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCurrentMemoryUsageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DiskCapacity
	{
		[Export("diskCapacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDiskCapacityHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDiskCapacityHandle);
		}
		[Export("setDiskCapacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDiskCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDiskCapacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MemoryCapacity
	{
		[Export("memoryCapacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMemoryCapacityHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMemoryCapacityHandle);
		}
		[Export("setMemoryCapacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMemoryCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMemoryCapacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlCache SharedCache
	{
		[Export("sharedURLCache", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrlCache>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedURLCacheHandle));
		}
		[Export("setSharedURLCache:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetSharedURLCache_Handle, value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlCache()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlCache(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlCache(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMemoryCapacity:diskCapacity:diskPath:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the overload that accepts an 'NSUrl' parameter instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the overload that accepts an 'NSUrl' parameter instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use the overload that accepts an 'NSUrl' parameter instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the overload that accepts an 'NSUrl' parameter instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public NSUrlCache(nuint memoryCapacity, nuint diskCapacity, string diskPath)
		: base(NSObjectFlag.Empty)
	{
		if (diskPath == null)
		{
			throw new ArgumentNullException("diskPath");
		}
		IntPtr arg = NSString.CreateNative(diskPath);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint_nuint_IntPtr(base.Handle, selInitWithMemoryCapacity_DiskCapacity_DiskPath_Handle, memoryCapacity, diskCapacity, arg), "initWithMemoryCapacity:diskCapacity:diskPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_IntPtr(base.SuperHandle, selInitWithMemoryCapacity_DiskCapacity_DiskPath_Handle, memoryCapacity, diskCapacity, arg), "initWithMemoryCapacity:diskCapacity:diskPath:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithMemoryCapacity:diskCapacity:directoryURL:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlCache(nuint memoryCapacity, nuint diskCapacity, NSUrl? directoryUrl)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint_nuint_IntPtr(base.Handle, selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_Handle, memoryCapacity, diskCapacity, (directoryUrl == null) ? IntPtr.Zero : directoryUrl.Handle), "initWithMemoryCapacity:diskCapacity:directoryURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_IntPtr(base.SuperHandle, selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_Handle, memoryCapacity, diskCapacity, (directoryUrl == null) ? IntPtr.Zero : directoryUrl.Handle), "initWithMemoryCapacity:diskCapacity:directoryURL:");
		}
	}

	[Export("cachedResponseForRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCachedUrlResponse CachedResponseForRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCachedUrlResponse>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCachedResponseForRequest_Handle, request.Handle));
		}
		return Runtime.GetNSObject<NSCachedUrlResponse>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCachedResponseForRequest_Handle, request.Handle));
	}

	[Export("getCachedResponseForDataTask:completionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetCachedResponse(NSUrlSessionDataTask dataTask, [BlockProxy(typeof(Trampolines.NIDActionArity1V36))] Action<NSCachedUrlResponse> completionHandler)
	{
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V36.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetCachedResponseForDataTask_CompletionHandler_Handle, dataTask.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetCachedResponseForDataTask_CompletionHandler_Handle, dataTask.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSCachedUrlResponse> GetCachedResponseAsync(NSUrlSessionDataTask dataTask)
	{
		TaskCompletionSource<NSCachedUrlResponse> tcs = new TaskCompletionSource<NSCachedUrlResponse>();
		GetCachedResponse(dataTask, delegate(NSCachedUrlResponse obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeAllCachedResponses")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllCachedResponses()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllCachedResponsesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllCachedResponsesHandle);
		}
	}

	[Export("removeCachedResponseForRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCachedResponse(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCachedResponseForRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCachedResponseForRequest_Handle, request.Handle);
		}
	}

	[Export("removeCachedResponseForDataTask:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCachedResponse(NSUrlSessionDataTask dataTask)
	{
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCachedResponseForDataTask_Handle, dataTask.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCachedResponseForDataTask_Handle, dataTask.Handle);
		}
	}

	[Export("removeCachedResponsesSinceDate:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCachedResponsesSinceDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCachedResponsesSinceDate_Handle, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCachedResponsesSinceDate_Handle, date.Handle);
		}
	}

	[Export("storeCachedResponse:forRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStoreCachedResponse_ForRequest_Handle, cachedResponse.Handle, forRequest.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStoreCachedResponse_ForRequest_Handle, cachedResponse.Handle, forRequest.Handle);
		}
	}

	[Export("storeCachedResponse:forDataTask:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StoreCachedResponse(NSCachedUrlResponse cachedResponse, NSUrlSessionDataTask dataTask)
	{
		if (cachedResponse == null)
		{
			throw new ArgumentNullException("cachedResponse");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStoreCachedResponse_ForDataTask_Handle, cachedResponse.Handle, dataTask.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStoreCachedResponse_ForDataTask_Handle, cachedResponse.Handle, dataTask.Handle);
		}
	}
}
