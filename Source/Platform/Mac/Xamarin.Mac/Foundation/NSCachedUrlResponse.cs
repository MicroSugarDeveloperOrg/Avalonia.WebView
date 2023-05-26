using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCachedURLResponse", true)]
public class NSCachedUrlResponse : NSObject
{
	private static readonly IntPtr selResponseHandle = Selector.GetHandle("response");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selStoragePolicyHandle = Selector.GetHandle("storagePolicy");

	private static readonly IntPtr selInitWithResponseDataUserInfoStoragePolicy_Handle = Selector.GetHandle("initWithResponse:data:userInfo:storagePolicy:");

	private static readonly IntPtr selInitWithResponseData_Handle = Selector.GetHandle("initWithResponse:data:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCachedURLResponse");

	private object __mt_Response_var;

	private object __mt_Data_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrlResponse Response
	{
		[Export("response")]
		get
		{
			return (NSUrlResponse)(__mt_Response_var = ((!IsDirectBinding) ? ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResponseHandle))) : ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResponseHandle)))));
		}
	}

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
	}

	public virtual NSUrlCacheStoragePolicy StoragePolicy
	{
		[Export("storagePolicy")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSUrlCacheStoragePolicy)Messaging.UInt64_objc_msgSend(base.Handle, selStoragePolicyHandle);
			}
			return (NSUrlCacheStoragePolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStoragePolicyHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCachedUrlResponse(NSCoder coder)
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
	public NSCachedUrlResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCachedUrlResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithResponse:data:userInfo:storagePolicy:")]
	public NSCachedUrlResponse(NSUrlResponse response, NSData data, NSDictionary userInfo, NSUrlCacheStoragePolicy storagePolicy)
		: base(NSObjectFlag.Empty)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selInitWithResponseDataUserInfoStoragePolicy_Handle, response.Handle, data.Handle, userInfo?.Handle ?? IntPtr.Zero, (ulong)storagePolicy);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithResponseDataUserInfoStoragePolicy_Handle, response.Handle, data.Handle, userInfo?.Handle ?? IntPtr.Zero, (ulong)storagePolicy);
		}
	}

	[Export("initWithResponse:data:")]
	public NSCachedUrlResponse(NSUrlResponse response, NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithResponseData_Handle, response.Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithResponseData_Handle, response.Handle, data.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Response_var = null;
			__mt_Data_var = null;
			__mt_UserInfo_var = null;
		}
	}
}
