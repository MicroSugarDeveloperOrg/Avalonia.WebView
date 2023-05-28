using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentHistoryChangeRequest", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class NSPersistentHistoryChangeRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteHistoryBeforeDate_ = "deleteHistoryBeforeDate:";

	private static readonly IntPtr selDeleteHistoryBeforeDate_Handle = Selector.GetHandle("deleteHistoryBeforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteHistoryBeforeToken_ = "deleteHistoryBeforeToken:";

	private static readonly IntPtr selDeleteHistoryBeforeToken_Handle = Selector.GetHandle("deleteHistoryBeforeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteHistoryBeforeTransaction_ = "deleteHistoryBeforeTransaction:";

	private static readonly IntPtr selDeleteHistoryBeforeTransaction_Handle = Selector.GetHandle("deleteHistoryBeforeTransaction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchHistoryAfterDate_ = "fetchHistoryAfterDate:";

	private static readonly IntPtr selFetchHistoryAfterDate_Handle = Selector.GetHandle("fetchHistoryAfterDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchHistoryAfterToken_ = "fetchHistoryAfterToken:";

	private static readonly IntPtr selFetchHistoryAfterToken_Handle = Selector.GetHandle("fetchHistoryAfterToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchHistoryAfterTransaction_ = "fetchHistoryAfterTransaction:";

	private static readonly IntPtr selFetchHistoryAfterTransaction_Handle = Selector.GetHandle("fetchHistoryAfterTransaction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchHistoryWithFetchRequest_ = "fetchHistoryWithFetchRequest:";

	private static readonly IntPtr selFetchHistoryWithFetchRequest_Handle = Selector.GetHandle("fetchHistoryWithFetchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequest = "fetchRequest";

	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRequest_ = "setFetchRequest:";

	private static readonly IntPtr selSetFetchRequest_Handle = Selector.GetHandle("setFetchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultType_ = "setResultType:";

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToken = "token";

	private static readonly IntPtr selTokenHandle = Selector.GetHandle("token");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentHistoryChangeRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSFetchRequest? FetchRequest
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("fetchRequest", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestHandle));
			}
			return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestHandle));
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setFetchRequest:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRequest_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRequest_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentHistoryResultType ResultType
	{
		[Export("resultType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSPersistentHistoryResultType)Messaging.Int64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSPersistentHistoryResultType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
		[Export("setResultType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetResultType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetResultType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentHistoryToken? Token
	{
		[Export("token", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersistentHistoryToken>(Messaging.IntPtr_objc_msgSend(base.Handle, selTokenHandle));
			}
			return Runtime.GetNSObject<NSPersistentHistoryToken>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTokenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPersistentHistoryChangeRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentHistoryChangeRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("deleteHistoryBeforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest DeleteHistoryBefore(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeleteHistoryBeforeDate_Handle, date.Handle));
	}

	[Export("deleteHistoryBeforeToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest DeleteHistoryBefore(NSPersistentHistoryToken? token)
	{
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeleteHistoryBeforeToken_Handle, token?.Handle ?? IntPtr.Zero));
	}

	[Export("deleteHistoryBeforeTransaction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest DeleteHistoryBefore(NSPersistentHistoryTransaction? transaction)
	{
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeleteHistoryBeforeTransaction_Handle, transaction?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchHistoryWithFetchRequest:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest FetchHistory(NSFetchRequest fetchRequest)
	{
		if (fetchRequest == null)
		{
			throw new ArgumentNullException("fetchRequest");
		}
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchHistoryWithFetchRequest_Handle, fetchRequest.Handle));
	}

	[Export("fetchHistoryAfterDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest FetchHistoryAfter(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchHistoryAfterDate_Handle, date.Handle));
	}

	[Export("fetchHistoryAfterToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest FetchHistoryAfter(NSPersistentHistoryToken? token)
	{
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchHistoryAfterToken_Handle, token?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchHistoryAfterTransaction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentHistoryChangeRequest FetchHistoryAfter(NSPersistentHistoryTransaction? transaction)
	{
		return Runtime.GetNSObject<NSPersistentHistoryChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchHistoryAfterTransaction_Handle, transaction?.Handle ?? IntPtr.Zero));
	}
}
