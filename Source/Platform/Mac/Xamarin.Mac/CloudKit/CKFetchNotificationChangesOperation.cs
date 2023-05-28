using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CloudKit;

[Register("CKFetchNotificationChangesOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKDatabaseSubscription', 'CKFetchDatabaseChangesOperation' and 'CKFetchRecordZoneChangesOperation' instead.")]
public class CKFetchNotificationChangesOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchNotificationChangesCompletionBlock = "fetchNotificationChangesCompletionBlock";

	private static readonly IntPtr selFetchNotificationChangesCompletionBlockHandle = Selector.GetHandle("fetchNotificationChangesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPreviousServerChangeToken_ = "initWithPreviousServerChangeToken:";

	private static readonly IntPtr selInitWithPreviousServerChangeToken_Handle = Selector.GetHandle("initWithPreviousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoreComing = "moreComing";

	private static readonly IntPtr selMoreComingHandle = Selector.GetHandle("moreComing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationChangedBlock = "notificationChangedBlock";

	private static readonly IntPtr selNotificationChangedBlockHandle = Selector.GetHandle("notificationChangedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousServerChangeToken = "previousServerChangeToken";

	private static readonly IntPtr selPreviousServerChangeTokenHandle = Selector.GetHandle("previousServerChangeToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultsLimit = "resultsLimit";

	private static readonly IntPtr selResultsLimitHandle = Selector.GetHandle("resultsLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchNotificationChangesCompletionBlock_ = "setFetchNotificationChangesCompletionBlock:";

	private static readonly IntPtr selSetFetchNotificationChangesCompletionBlock_Handle = Selector.GetHandle("setFetchNotificationChangesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotificationChangedBlock_ = "setNotificationChangedBlock:";

	private static readonly IntPtr selSetNotificationChangedBlock_Handle = Selector.GetHandle("setNotificationChangedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviousServerChangeToken_ = "setPreviousServerChangeToken:";

	private static readonly IntPtr selSetPreviousServerChangeToken_Handle = Selector.GetHandle("setPreviousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultsLimit_ = "setResultsLimit:";

	private static readonly IntPtr selSetResultsLimit_Handle = Selector.GetHandle("setResultsLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchNotificationChangesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKServerChangeToken, NSError>? Completed
	{
		[Export("fetchNotificationChangesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V33))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchNotificationChangesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchNotificationChangesCompletionBlockHandle));
			return Trampolines.NIDActionArity2V33.Create(block);
		}
		[Export("setFetchNotificationChangesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V33))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V33.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchNotificationChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchNotificationChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MoreComing
	{
		[Export("moreComing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMoreComingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMoreComingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKNotification>? NotificationChanged
	{
		[Export("notificationChangedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V18))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationChangedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationChangedBlockHandle));
			return Trampolines.NIDActionArity1V18.Create(block);
		}
		[Export("setNotificationChangedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V18))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V18.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNotificationChangedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNotificationChangedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKServerChangeToken? PreviousServerChangeToken
	{
		[Export("previousServerChangeToken", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKServerChangeToken>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousServerChangeTokenHandle));
			}
			return Runtime.GetNSObject<CKServerChangeToken>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousServerChangeTokenHandle));
		}
		[Export("setPreviousServerChangeToken:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreviousServerChangeToken_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreviousServerChangeToken_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResultsLimit
	{
		[Export("resultsLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResultsLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResultsLimitHandle);
		}
		[Export("setResultsLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetResultsLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetResultsLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchNotificationChangesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchNotificationChangesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchNotificationChangesOperation()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithPreviousServerChangeToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchNotificationChangesOperation(CKServerChangeToken? previousServerChangeToken)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPreviousServerChangeToken_Handle, previousServerChangeToken?.Handle ?? IntPtr.Zero), "initWithPreviousServerChangeToken:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPreviousServerChangeToken_Handle, previousServerChangeToken?.Handle ?? IntPtr.Zero), "initWithPreviousServerChangeToken:");
		}
	}
}
