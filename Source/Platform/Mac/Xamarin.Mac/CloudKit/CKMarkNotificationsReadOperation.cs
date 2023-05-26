using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKMarkNotificationsReadOperation", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
public class CKMarkNotificationsReadOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNotificationIDsToMarkRead_ = "initWithNotificationIDsToMarkRead:";

	private static readonly IntPtr selInitWithNotificationIDsToMarkRead_Handle = Selector.GetHandle("initWithNotificationIDsToMarkRead:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkNotificationsReadCompletionBlock = "markNotificationsReadCompletionBlock";

	private static readonly IntPtr selMarkNotificationsReadCompletionBlockHandle = Selector.GetHandle("markNotificationsReadCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationIDs = "notificationIDs";

	private static readonly IntPtr selNotificationIDsHandle = Selector.GetHandle("notificationIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkNotificationsReadCompletionBlock_ = "setMarkNotificationsReadCompletionBlock:";

	private static readonly IntPtr selSetMarkNotificationsReadCompletionBlock_Handle = Selector.GetHandle("setMarkNotificationsReadCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotificationIDs_ = "setNotificationIDs:";

	private static readonly IntPtr selSetNotificationIDs_Handle = Selector.GetHandle("setNotificationIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKMarkNotificationsReadOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKMarkNotificationsReadHandler? Completed
	{
		[Export("markNotificationsReadCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKMarkNotificationsReadHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkNotificationsReadCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selMarkNotificationsReadCompletionBlockHandle));
			return Trampolines.NIDCKMarkNotificationsReadHandler.Create(block);
		}
		[Export("setMarkNotificationsReadCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKMarkNotificationsReadHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKMarkNotificationsReadHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarkNotificationsReadCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarkNotificationsReadCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKNotificationID[]? NotificationIds
	{
		[Export("notificationIDs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKNotificationID>(Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationIDsHandle));
			}
			return NSArray.ArrayFromHandle<CKNotificationID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationIDsHandle));
		}
		[Export("setNotificationIDs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNotificationIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNotificationIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKMarkNotificationsReadOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKMarkNotificationsReadOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNotificationIDsToMarkRead:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKMarkNotificationsReadOperation(CKNotificationID[] notificationIds)
		: base(NSObjectFlag.Empty)
	{
		if (notificationIds == null)
		{
			throw new ArgumentNullException("notificationIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(notificationIds);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNotificationIDsToMarkRead_Handle, nSArray.Handle), "initWithNotificationIDsToMarkRead:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNotificationIDsToMarkRead_Handle, nSArray.Handle), "initWithNotificationIDsToMarkRead:");
		}
		nSArray.Dispose();
	}
}
