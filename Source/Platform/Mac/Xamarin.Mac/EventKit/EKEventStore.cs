using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKEventStore", true)]
public class EKEventStore : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatusForEntityType_ = "authorizationStatusForEntityType:";

	private static readonly IntPtr selAuthorizationStatusForEntityType_Handle = Selector.GetHandle("authorizationStatusForEntityType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarItemWithIdentifier_ = "calendarItemWithIdentifier:";

	private static readonly IntPtr selCalendarItemWithIdentifier_Handle = Selector.GetHandle("calendarItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarItemsWithExternalIdentifier_ = "calendarItemsWithExternalIdentifier:";

	private static readonly IntPtr selCalendarItemsWithExternalIdentifier_Handle = Selector.GetHandle("calendarItemsWithExternalIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarWithIdentifier_ = "calendarWithIdentifier:";

	private static readonly IntPtr selCalendarWithIdentifier_Handle = Selector.GetHandle("calendarWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarsForEntityType_ = "calendarsForEntityType:";

	private static readonly IntPtr selCalendarsForEntityType_Handle = Selector.GetHandle("calendarsForEntityType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelFetchRequest_ = "cancelFetchRequest:";

	private static readonly IntPtr selCancelFetchRequest_Handle = Selector.GetHandle("cancelFetchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommit_ = "commit:";

	private static readonly IntPtr selCommit_Handle = Selector.GetHandle("commit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCalendarForNewEvents = "defaultCalendarForNewEvents";

	private static readonly IntPtr selDefaultCalendarForNewEventsHandle = Selector.GetHandle("defaultCalendarForNewEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCalendarForNewReminders = "defaultCalendarForNewReminders";

	private static readonly IntPtr selDefaultCalendarForNewRemindersHandle = Selector.GetHandle("defaultCalendarForNewReminders");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateSources = "delegateSources";

	private static readonly IntPtr selDelegateSourcesHandle = Selector.GetHandle("delegateSources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateEventsMatchingPredicate_UsingBlock_ = "enumerateEventsMatchingPredicate:usingBlock:";

	private static readonly IntPtr selEnumerateEventsMatchingPredicate_UsingBlock_Handle = Selector.GetHandle("enumerateEventsMatchingPredicate:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventStoreIdentifier = "eventStoreIdentifier";

	private static readonly IntPtr selEventStoreIdentifierHandle = Selector.GetHandle("eventStoreIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventWithIdentifier_ = "eventWithIdentifier:";

	private static readonly IntPtr selEventWithIdentifier_Handle = Selector.GetHandle("eventWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventsMatchingPredicate_ = "eventsMatchingPredicate:";

	private static readonly IntPtr selEventsMatchingPredicate_Handle = Selector.GetHandle("eventsMatchingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRemindersMatchingPredicate_Completion_ = "fetchRemindersMatchingPredicate:completion:";

	private static readonly IntPtr selFetchRemindersMatchingPredicate_Completion_Handle = Selector.GetHandle("fetchRemindersMatchingPredicate:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAccessToEntityTypes_ = "initWithAccessToEntityTypes:";

	private static readonly IntPtr selInitWithAccessToEntityTypes_Handle = Selector.GetHandle("initWithAccessToEntityTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_ = "initWithSources:";

	private static readonly IntPtr selInitWithSources_Handle = Selector.GetHandle("initWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_ = "predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:";

	private static readonly IntPtr selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_Handle = Selector.GetHandle("predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForEventsWithStartDate_EndDate_Calendars_ = "predicateForEventsWithStartDate:endDate:calendars:";

	private static readonly IntPtr selPredicateForEventsWithStartDate_EndDate_Calendars_Handle = Selector.GetHandle("predicateForEventsWithStartDate:endDate:calendars:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_ = "predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:";

	private static readonly IntPtr selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_Handle = Selector.GetHandle("predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForRemindersInCalendars_ = "predicateForRemindersInCalendars:";

	private static readonly IntPtr selPredicateForRemindersInCalendars_Handle = Selector.GetHandle("predicateForRemindersInCalendars:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefreshSourcesIfNecessary = "refreshSourcesIfNecessary";

	private static readonly IntPtr selRefreshSourcesIfNecessaryHandle = Selector.GetHandle("refreshSourcesIfNecessary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCalendar_Commit_Error_ = "removeCalendar:commit:error:";

	private static readonly IntPtr selRemoveCalendar_Commit_Error_Handle = Selector.GetHandle("removeCalendar:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEvent_Span_Commit_Error_ = "removeEvent:span:commit:error:";

	private static readonly IntPtr selRemoveEvent_Span_Commit_Error_Handle = Selector.GetHandle("removeEvent:span:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEvent_Span_Error_ = "removeEvent:span:error:";

	private static readonly IntPtr selRemoveEvent_Span_Error_Handle = Selector.GetHandle("removeEvent:span:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveReminder_Commit_Error_ = "removeReminder:commit:error:";

	private static readonly IntPtr selRemoveReminder_Commit_Error_Handle = Selector.GetHandle("removeReminder:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAccessToEntityType_Completion_ = "requestAccessToEntityType:completion:";

	private static readonly IntPtr selRequestAccessToEntityType_Completion_Handle = Selector.GetHandle("requestAccessToEntityType:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveCalendar_Commit_Error_ = "saveCalendar:commit:error:";

	private static readonly IntPtr selSaveCalendar_Commit_Error_Handle = Selector.GetHandle("saveCalendar:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveEvent_Span_Commit_Error_ = "saveEvent:span:commit:error:";

	private static readonly IntPtr selSaveEvent_Span_Commit_Error_Handle = Selector.GetHandle("saveEvent:span:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveEvent_Span_Error_ = "saveEvent:span:error:";

	private static readonly IntPtr selSaveEvent_Span_Error_Handle = Selector.GetHandle("saveEvent:span:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveReminder_Commit_Error_ = "saveReminder:commit:error:";

	private static readonly IntPtr selSaveReminder_Commit_Error_Handle = Selector.GetHandle("saveReminder:commit:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceWithIdentifier_ = "sourceWithIdentifier:";

	private static readonly IntPtr selSourceWithIdentifier_Handle = Selector.GetHandle("sourceWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSources = "sources";

	private static readonly IntPtr selSourcesHandle = Selector.GetHandle("sources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKEventStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendar? DefaultCalendarForNewEvents
	{
		[Export("defaultCalendarForNewEvents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultCalendarForNewEventsHandle));
			}
			return Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultCalendarForNewEventsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendar? DefaultCalendarForNewReminders
	{
		[Export("defaultCalendarForNewReminders")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultCalendarForNewRemindersHandle));
			}
			return Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultCalendarForNewRemindersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual EKSource[] DelegateSources
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("delegateSources")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<EKSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateSourcesHandle));
			}
			return NSArray.ArrayFromHandle<EKSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateSourcesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string EventStoreIdentifier
	{
		[Export("eventStoreIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEventStoreIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEventStoreIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKSource[] Sources
	{
		[Export("sources")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<EKSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourcesHandle));
			}
			return NSArray.ArrayFromHandle<EKSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourcesHandle));
		}
	}

	[Field("EKEventStoreChangedNotification", "EventKit")]
	[Advice("Use EKEventStore.Notifications.ObserveChanged helper method instead.")]
	public static NSString ChangedNotification
	{
		get
		{
			if (_ChangedNotification == null)
			{
				_ChangedNotification = Dlfcn.GetStringConstant(Libraries.EventKit.Handle, "EKEventStoreChangedNotification");
			}
			return _ChangedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public EKEventStore()
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
	protected EKEventStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKEventStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSources:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EKEventStore(EKSource[] sources)
		: base(NSObjectFlag.Empty)
	{
		if (sources == null)
		{
			throw new ArgumentNullException("sources");
		}
		NSArray nSArray = NSArray.FromNSObjects(sources);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		nSArray.Dispose();
	}

	[Export("initWithAccessToEntityTypes:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EKEventStore(EKEntityMask accessToEntityTypes)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithAccessToEntityTypes_Handle, (ulong)accessToEntityTypes), "initWithAccessToEntityTypes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithAccessToEntityTypes_Handle, (ulong)accessToEntityTypes), "initWithAccessToEntityTypes:");
		}
	}

	[Export("cancelFetchRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelFetchRequest(IntPtr fetchIdentifier)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelFetchRequest_Handle, fetchIdentifier);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelFetchRequest_Handle, fetchIdentifier);
		}
	}

	[Export("commit:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Commit(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCommit_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCommit_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enumerateEventsMatchingPredicate:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateEvents(NSPredicate predicate, [BlockProxy(typeof(Trampolines.NIDEKEventSearchCallback))] EKEventSearchCallback block)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDEKEventSearchCallback.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnumerateEventsMatchingPredicate_UsingBlock_Handle, predicate.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnumerateEventsMatchingPredicate_UsingBlock_Handle, predicate.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("eventWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKEvent? EventFromIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		EKEvent result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<EKEvent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEventWithIdentifier_Handle, arg)) : Runtime.GetNSObject<EKEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEventWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("eventsMatchingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKEvent[] EventsMatching(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<EKEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEventsMatchingPredicate_Handle, predicate.Handle));
		}
		return NSArray.ArrayFromHandle<EKEvent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEventsMatchingPredicate_Handle, predicate.Handle));
	}

	[Export("fetchRemindersMatchingPredicate:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual IntPtr FetchReminders(NSPredicate predicate, [BlockProxy(typeof(Trampolines.NIDActionArity1V27))] Action<EKReminder[]> completion)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V27.Handler, completion);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchRemindersMatchingPredicate_Completion_Handle, predicate.Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchRemindersMatchingPredicate_Completion_Handle, predicate.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<EKReminder[]> FetchRemindersAsync(NSPredicate predicate)
	{
		TaskCompletionSource<EKReminder[]> tcs = new TaskCompletionSource<EKReminder[]>();
		FetchReminders(predicate, delegate(EKReminder[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<EKReminder[]> FetchRemindersAsync(NSPredicate predicate, out IntPtr result)
	{
		TaskCompletionSource<EKReminder[]> tcs = new TaskCompletionSource<EKReminder[]>();
		result = FetchReminders(predicate, delegate(EKReminder[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("authorizationStatusForEntityType:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKAuthorizationStatus GetAuthorizationStatus(EKEntityType entityType)
	{
		return (EKAuthorizationStatus)Messaging.Int64_objc_msgSend_UInt64(class_ptr, selAuthorizationStatusForEntityType_Handle, (ulong)entityType);
	}

	[Export("calendarWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendar? GetCalendar(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		EKCalendar result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCalendarWithIdentifier_Handle, arg)) : Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCalendarWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("calendarItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendarItem? GetCalendarItem(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		EKCalendarItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<EKCalendarItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCalendarItemWithIdentifier_Handle, arg)) : Runtime.GetNSObject<EKCalendarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCalendarItemWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("calendarItemsWithExternalIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendarItem[] GetCalendarItems(string externalIdentifier)
	{
		if (externalIdentifier == null)
		{
			throw new ArgumentNullException("externalIdentifier");
		}
		IntPtr arg = NSString.CreateNative(externalIdentifier);
		EKCalendarItem[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<EKCalendarItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCalendarItemsWithExternalIdentifier_Handle, arg)) : NSArray.ArrayFromHandle<EKCalendarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCalendarItemsWithExternalIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("calendarsForEntityType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendar[] GetCalendars(EKEntityType entityType)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<EKCalendar>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selCalendarsForEntityType_Handle, (ulong)entityType));
		}
		return NSArray.ArrayFromHandle<EKCalendar>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selCalendarsForEntityType_Handle, (ulong)entityType));
	}

	[Export("sourceWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKSource? GetSource(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		EKSource result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<EKSource>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSourceWithIdentifier_Handle, arg)) : Runtime.GetNSObject<EKSource>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSourceWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateForCompleteReminders(NSDate? startDate, NSDate? endDate, EKCalendar[]? calendars)
	{
		NSArray nSArray = ((calendars == null) ? null : NSArray.FromNSObjects(calendars));
		NSPredicate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_Handle, startDate?.Handle ?? IntPtr.Zero, endDate?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_Handle, startDate?.Handle ?? IntPtr.Zero, endDate?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("predicateForEventsWithStartDate:endDate:calendars:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateForEvents(NSDate startDate, NSDate endDate, EKCalendar[]? calendars)
	{
		if (startDate == null)
		{
			throw new ArgumentNullException("startDate");
		}
		if (endDate == null)
		{
			throw new ArgumentNullException("endDate");
		}
		NSArray nSArray = ((calendars == null) ? null : NSArray.FromNSObjects(calendars));
		NSPredicate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPredicateForEventsWithStartDate_EndDate_Calendars_Handle, startDate.Handle, endDate.Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPredicateForEventsWithStartDate_EndDate_Calendars_Handle, startDate.Handle, endDate.Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateForIncompleteReminders(NSDate? startDate, NSDate? endDate, EKCalendar[]? calendars)
	{
		NSArray nSArray = ((calendars == null) ? null : NSArray.FromNSObjects(calendars));
		NSPredicate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_Handle, startDate?.Handle ?? IntPtr.Zero, endDate?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_Handle, startDate?.Handle ?? IntPtr.Zero, endDate?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("predicateForRemindersInCalendars:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateForReminders(EKCalendar[]? calendars)
	{
		NSArray nSArray = ((calendars == null) ? null : NSArray.FromNSObjects(calendars));
		NSPredicate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredicateForRemindersInCalendars_Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredicateForRemindersInCalendars_Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("refreshSourcesIfNecessary")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RefreshSourcesIfNecessary()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRefreshSourcesIfNecessaryHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRefreshSourcesIfNecessaryHandle);
		}
	}

	[Export("removeCalendar:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveCalendar(EKCalendar calendar, bool commit, out NSError error)
	{
		if (calendar == null)
		{
			throw new ArgumentNullException("calendar");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selRemoveCalendar_Commit_Error_Handle, calendar.Handle, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selRemoveCalendar_Commit_Error_Handle, calendar.Handle, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeEvent:span:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveEvent(EKEvent ekEvent, EKSpan span, bool commit, out NSError error)
	{
		if (ekEvent == null)
		{
			throw new ArgumentNullException("ekEvent");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64_bool_ref_IntPtr(base.SuperHandle, selRemoveEvent_Span_Commit_Error_Handle, ekEvent.Handle, (long)span, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_Int64_bool_ref_IntPtr(base.Handle, selRemoveEvent_Span_Commit_Error_Handle, ekEvent.Handle, (long)span, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeEvent:span:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveEvents(EKEvent theEvent, EKSpan span, out NSError error)
	{
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selRemoveEvent_Span_Error_Handle, theEvent.Handle, (long)span, ref arg) : Messaging.bool_objc_msgSend_IntPtr_Int64_ref_IntPtr(base.Handle, selRemoveEvent_Span_Error_Handle, theEvent.Handle, (long)span, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeReminder:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveReminder(EKReminder reminder, bool commit, out NSError error)
	{
		if (reminder == null)
		{
			throw new ArgumentNullException("reminder");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selRemoveReminder_Commit_Error_Handle, reminder.Handle, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selRemoveReminder_Commit_Error_Handle, reminder.Handle, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("requestAccessToEntityType:completion:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestAccess(EKEntityType entityType, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selRequestAccessToEntityType_Completion_Handle, (ulong)entityType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selRequestAccessToEntityType_Completion_Handle, (ulong)entityType, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> RequestAccessAsync(EKEntityType entityType)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAccess(entityType, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("saveCalendar:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveCalendar(EKCalendar calendar, bool commit, out NSError error)
	{
		if (calendar == null)
		{
			throw new ArgumentNullException("calendar");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selSaveCalendar_Commit_Error_Handle, calendar.Handle, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selSaveCalendar_Commit_Error_Handle, calendar.Handle, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("saveEvent:span:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveEvent(EKEvent theEvent, EKSpan span, out NSError error)
	{
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selSaveEvent_Span_Error_Handle, theEvent.Handle, (long)span, ref arg) : Messaging.bool_objc_msgSend_IntPtr_Int64_ref_IntPtr(base.Handle, selSaveEvent_Span_Error_Handle, theEvent.Handle, (long)span, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("saveEvent:span:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveEvent(EKEvent ekEvent, EKSpan span, bool commit, out NSError error)
	{
		if (ekEvent == null)
		{
			throw new ArgumentNullException("ekEvent");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64_bool_ref_IntPtr(base.SuperHandle, selSaveEvent_Span_Commit_Error_Handle, ekEvent.Handle, (long)span, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_Int64_bool_ref_IntPtr(base.Handle, selSaveEvent_Span_Commit_Error_Handle, ekEvent.Handle, (long)span, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("saveReminder:commit:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveReminder(EKReminder reminder, bool commit, out NSError error)
	{
		if (reminder == null)
		{
			throw new ArgumentNullException("reminder");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selSaveReminder_Commit_Error_Handle, reminder.Handle, commit, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selSaveReminder_Commit_Error_Handle, reminder.Handle, commit, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
