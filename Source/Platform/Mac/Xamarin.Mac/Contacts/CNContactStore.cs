using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContactStore", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactStore : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveNotificationDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NotificationDidChange, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveNotificationDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NotificationDidChange, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatusForEntityType_ = "authorizationStatusForEntityType:";

	private static readonly IntPtr selAuthorizationStatusForEntityType_Handle = Selector.GetHandle("authorizationStatusForEntityType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainersMatchingPredicate_Error_ = "containersMatchingPredicate:error:";

	private static readonly IntPtr selContainersMatchingPredicate_Error_Handle = Selector.GetHandle("containersMatchingPredicate:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentHistoryToken = "currentHistoryToken";

	private static readonly IntPtr selCurrentHistoryTokenHandle = Selector.GetHandle("currentHistoryToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultContainerIdentifier = "defaultContainerIdentifier";

	private static readonly IntPtr selDefaultContainerIdentifierHandle = Selector.GetHandle("defaultContainerIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateContactsWithFetchRequest_Error_UsingBlock_ = "enumerateContactsWithFetchRequest:error:usingBlock:";

	private static readonly IntPtr selEnumerateContactsWithFetchRequest_Error_UsingBlock_Handle = Selector.GetHandle("enumerateContactsWithFetchRequest:error:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumeratorForChangeHistoryFetchRequest_Error_ = "enumeratorForChangeHistoryFetchRequest:error:";

	private static readonly IntPtr selEnumeratorForChangeHistoryFetchRequest_Error_Handle = Selector.GetHandle("enumeratorForChangeHistoryFetchRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumeratorForContactFetchRequest_Error_ = "enumeratorForContactFetchRequest:error:";

	private static readonly IntPtr selEnumeratorForContactFetchRequest_Error_Handle = Selector.GetHandle("enumeratorForContactFetchRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteSaveRequest_Error_ = "executeSaveRequest:error:";

	private static readonly IntPtr selExecuteSaveRequest_Error_Handle = Selector.GetHandle("executeSaveRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupsMatchingPredicate_Error_ = "groupsMatchingPredicate:error:";

	private static readonly IntPtr selGroupsMatchingPredicate_Error_Handle = Selector.GetHandle("groupsMatchingPredicate:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAccessForEntityType_CompletionHandler_ = "requestAccessForEntityType:completionHandler:";

	private static readonly IntPtr selRequestAccessForEntityType_CompletionHandler_Handle = Selector.GetHandle("requestAccessForEntityType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnifiedContactWithIdentifier_KeysToFetch_Error_ = "unifiedContactWithIdentifier:keysToFetch:error:";

	private static readonly IntPtr selUnifiedContactWithIdentifier_KeysToFetch_Error_Handle = Selector.GetHandle("unifiedContactWithIdentifier:keysToFetch:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnifiedContactsMatchingPredicate_KeysToFetch_Error_ = "unifiedContactsMatchingPredicate:keysToFetch:error:";

	private static readonly IntPtr selUnifiedContactsMatchingPredicate_KeysToFetch_Error_Handle = Selector.GetHandle("unifiedContactsMatchingPredicate:keysToFetch:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnifiedMeContactWithKeysToFetch_Error_ = "unifiedMeContactWithKeysToFetch:error:";

	private static readonly IntPtr selUnifiedMeContactWithKeysToFetch_Error_Handle = Selector.GetHandle("unifiedMeContactWithKeysToFetch:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotificationDidChange;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSData? CurrentHistoryToken
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("currentHistoryToken", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentHistoryTokenHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentHistoryTokenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? DefaultContainerIdentifier
	{
		[Export("defaultContainerIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultContainerIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultContainerIdentifierHandle));
		}
	}

	[Field("CNContactStoreDidChangeNotification", "Contacts")]
	[Advice("Use CNContactStore.Notifications.ObserveNotificationDidChange helper method instead.")]
	public static NSString NotificationDidChange
	{
		get
		{
			if (_NotificationDidChange == null)
			{
				_NotificationDidChange = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactStoreDidChangeNotification");
			}
			return _NotificationDidChange;
		}
	}

	public CNContact GetUnifiedContact<T>(string identifier, T[] keys, out NSError error) where T : INSObjectProtocol, INSSecureCoding, INSCopying
	{
		using NSArray keys2 = NSArray.From(keys, -1L);
		return GetUnifiedContact(identifier, keys2, out error);
	}

	public CNContact[] GetUnifiedContacts<T>(NSPredicate predicate, T[] keys, out NSError error) where T : INSObjectProtocol, INSSecureCoding, INSCopying
	{
		using NSArray keys2 = NSArray.From(keys, -1L);
		return GetUnifiedContacts(predicate, keys2, out error);
	}

	public NSObject GetUnifiedMeContact<T>(T[] keys, out NSError error) where T : INSObjectProtocol, INSSecureCoding, INSCopying
	{
		using NSArray keys2 = NSArray.From(keys, -1L);
		return GetUnifiedMeContact(keys2, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactStore()
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
	protected CNContactStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enumerateContactsWithFetchRequest:error:usingBlock:")]
	[Obsolete("Use the overload that takes 'CNContactStoreListContactsHandler' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool EnumerateContacts(CNContactFetchRequest fetchRequest, out NSError error, [BlockProxy(typeof(Trampolines.NIDCNContactStoreEnumerateContactsHandler))] CNContactStoreEnumerateContactsHandler handler)
	{
		if (fetchRequest == null)
		{
			throw new ArgumentNullException("fetchRequest");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCNContactStoreEnumerateContactsHandler.Handler, handler);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr(base.SuperHandle, selEnumerateContactsWithFetchRequest_Error_UsingBlock_Handle, fetchRequest.Handle, ref arg, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr(base.Handle, selEnumerateContactsWithFetchRequest_Error_UsingBlock_Handle, fetchRequest.Handle, ref arg, (IntPtr)ptr));
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe bool EnumerateContacts(CNContactFetchRequest fetchRequest, out NSError? error, [BlockProxy(typeof(Trampolines.NIDCNContactStoreListContactsHandler))] CNContactStoreListContactsHandler handler)
	{
		if (fetchRequest == null)
		{
			throw new ArgumentNullException("fetchRequest");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCNContactStoreListContactsHandler.Handler, handler);
		bool result = Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr(base.Handle, selEnumerateContactsWithFetchRequest_Error_UsingBlock_Handle, fetchRequest.Handle, ref arg, (IntPtr)ptr);
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("executeSaveRequest:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExecuteSaveRequest(CNSaveRequest saveRequest, out NSError? error)
	{
		if (saveRequest == null)
		{
			throw new ArgumentNullException("saveRequest");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteSaveRequest_Error_Handle, saveRequest.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExecuteSaveRequest_Error_Handle, saveRequest.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("authorizationStatusForEntityType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CNAuthorizationStatus GetAuthorizationStatus(CNEntityType entityType)
	{
		return (CNAuthorizationStatus)Messaging.Int64_objc_msgSend_Int64(class_ptr, selAuthorizationStatusForEntityType_Handle, (long)entityType);
	}

	[Export("containersMatchingPredicate:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNContainer[]? GetContainers(NSPredicate? predicate, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		CNContainer[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CNContainer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selContainersMatchingPredicate_Error_Handle, predicate?.Handle ?? IntPtr.Zero, ref arg)) : NSArray.ArrayFromHandle<CNContainer>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selContainersMatchingPredicate_Error_Handle, predicate?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enumeratorForChangeHistoryFetchRequest:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>? GetEnumeratorForChangeHistory(CNChangeHistoryFetchRequest request, out NSError? error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		CNFetchResult<NSEnumerator<CNChangeHistoryEvent>> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selEnumeratorForChangeHistoryFetchRequest_Error_Handle, request.Handle, ref arg)) : Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selEnumeratorForChangeHistoryFetchRequest_Error_Handle, request.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enumeratorForContactFetchRequest:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNFetchResult<NSEnumerator<CNContact>>? GetEnumeratorForContact(CNContactFetchRequest request, out NSError? error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		CNFetchResult<NSEnumerator<CNContact>> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNContact>>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selEnumeratorForContactFetchRequest_Error_Handle, request.Handle, ref arg)) : Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNContact>>>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selEnumeratorForContactFetchRequest_Error_Handle, request.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("groupsMatchingPredicate:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNGroup[]? GetGroups(NSPredicate? predicate, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		CNGroup[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CNGroup>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selGroupsMatchingPredicate_Error_Handle, predicate?.Handle ?? IntPtr.Zero, ref arg)) : NSArray.ArrayFromHandle<CNGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selGroupsMatchingPredicate_Error_Handle, predicate?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("unifiedContactWithIdentifier:keysToFetch:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CNContact? GetUnifiedContact(string identifier, NSArray keys, out NSError? error)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(identifier);
		CNContact result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CNContact>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selUnifiedContactWithIdentifier_KeysToFetch_Error_Handle, arg2, keys.Handle, ref arg)) : Runtime.GetNSObject<CNContact>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selUnifiedContactWithIdentifier_KeysToFetch_Error_Handle, arg2, keys.Handle, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("unifiedContactsMatchingPredicate:keysToFetch:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CNContact[]? GetUnifiedContacts(NSPredicate predicate, NSArray keys, out NSError? error)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr arg = IntPtr.Zero;
		CNContact[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CNContact>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selUnifiedContactsMatchingPredicate_KeysToFetch_Error_Handle, predicate.Handle, keys.Handle, ref arg)) : NSArray.ArrayFromHandle<CNContact>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selUnifiedContactsMatchingPredicate_KeysToFetch_Error_Handle, predicate.Handle, keys.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("unifiedMeContactWithKeysToFetch:error:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSObject? GetUnifiedMeContact(NSArray keys, out NSError? error)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selUnifiedMeContactWithKeysToFetch_Error_Handle, keys.Handle, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selUnifiedMeContactWithKeysToFetch_Error_Handle, keys.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("requestAccessForEntityType:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestAccess(CNEntityType entityType, [BlockProxy(typeof(Trampolines.NIDCNContactStoreRequestAccessHandler))] CNContactStoreRequestAccessHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCNContactStoreRequestAccessHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selRequestAccessForEntityType_CompletionHandler_Handle, (long)entityType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selRequestAccessForEntityType_CompletionHandler_Handle, (long)entityType, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> RequestAccessAsync(CNEntityType entityType)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAccess(entityType, delegate(bool granted_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(granted_, error_));
		});
		return tcs.Task;
	}
}
