using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CloudKit;

[Register("CKFetchDatabaseChangesOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKFetchDatabaseChangesOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeTokenUpdatedBlock = "changeTokenUpdatedBlock";

	private static readonly IntPtr selChangeTokenUpdatedBlockHandle = Selector.GetHandle("changeTokenUpdatedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllChanges = "fetchAllChanges";

	private static readonly IntPtr selFetchAllChangesHandle = Selector.GetHandle("fetchAllChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchDatabaseChangesCompletionBlock = "fetchDatabaseChangesCompletionBlock";

	private static readonly IntPtr selFetchDatabaseChangesCompletionBlockHandle = Selector.GetHandle("fetchDatabaseChangesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPreviousServerChangeToken_ = "initWithPreviousServerChangeToken:";

	private static readonly IntPtr selInitWithPreviousServerChangeToken_Handle = Selector.GetHandle("initWithPreviousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousServerChangeToken = "previousServerChangeToken";

	private static readonly IntPtr selPreviousServerChangeTokenHandle = Selector.GetHandle("previousServerChangeToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneWithIDChangedBlock = "recordZoneWithIDChangedBlock";

	private static readonly IntPtr selRecordZoneWithIDChangedBlockHandle = Selector.GetHandle("recordZoneWithIDChangedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneWithIDWasDeletedBlock = "recordZoneWithIDWasDeletedBlock";

	private static readonly IntPtr selRecordZoneWithIDWasDeletedBlockHandle = Selector.GetHandle("recordZoneWithIDWasDeletedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneWithIDWasPurgedBlock = "recordZoneWithIDWasPurgedBlock";

	private static readonly IntPtr selRecordZoneWithIDWasPurgedBlockHandle = Selector.GetHandle("recordZoneWithIDWasPurgedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultsLimit = "resultsLimit";

	private static readonly IntPtr selResultsLimitHandle = Selector.GetHandle("resultsLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChangeTokenUpdatedBlock_ = "setChangeTokenUpdatedBlock:";

	private static readonly IntPtr selSetChangeTokenUpdatedBlock_Handle = Selector.GetHandle("setChangeTokenUpdatedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchAllChanges_ = "setFetchAllChanges:";

	private static readonly IntPtr selSetFetchAllChanges_Handle = Selector.GetHandle("setFetchAllChanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchDatabaseChangesCompletionBlock_ = "setFetchDatabaseChangesCompletionBlock:";

	private static readonly IntPtr selSetFetchDatabaseChangesCompletionBlock_Handle = Selector.GetHandle("setFetchDatabaseChangesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviousServerChangeToken_ = "setPreviousServerChangeToken:";

	private static readonly IntPtr selSetPreviousServerChangeToken_Handle = Selector.GetHandle("setPreviousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneWithIDChangedBlock_ = "setRecordZoneWithIDChangedBlock:";

	private static readonly IntPtr selSetRecordZoneWithIDChangedBlock_Handle = Selector.GetHandle("setRecordZoneWithIDChangedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneWithIDWasDeletedBlock_ = "setRecordZoneWithIDWasDeletedBlock:";

	private static readonly IntPtr selSetRecordZoneWithIDWasDeletedBlock_Handle = Selector.GetHandle("setRecordZoneWithIDWasDeletedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneWithIDWasPurgedBlock_ = "setRecordZoneWithIDWasPurgedBlock:";

	private static readonly IntPtr selSetRecordZoneWithIDWasPurgedBlock_Handle = Selector.GetHandle("setRecordZoneWithIDWasPurgedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultsLimit_ = "setResultsLimit:";

	private static readonly IntPtr selSetResultsLimit_Handle = Selector.GetHandle("setResultsLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchDatabaseChangesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKServerChangeToken>? ChangeTokenUpdated
	{
		[Export("changeTokenUpdatedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V16))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangeTokenUpdatedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selChangeTokenUpdatedBlockHandle));
			return Trampolines.NIDActionArity1V16.Create(block);
		}
		[Export("setChangeTokenUpdatedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V16))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V16.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChangeTokenUpdatedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChangeTokenUpdatedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKRecordZoneID>? Changed
	{
		[Export("recordZoneWithIDChangedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V17))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneWithIDChangedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneWithIDChangedBlockHandle));
			return Trampolines.NIDActionArity1V17.Create(block);
		}
		[Export("setRecordZoneWithIDChangedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V17))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V17.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneWithIDChangedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneWithIDChangedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKFetchDatabaseChangesCompletionHandler? ChangesCompleted
	{
		[Export("fetchDatabaseChangesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchDatabaseChangesCompletionHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchDatabaseChangesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchDatabaseChangesCompletionBlockHandle));
			return Trampolines.NIDCKFetchDatabaseChangesCompletionHandler.Create(block);
		}
		[Export("setFetchDatabaseChangesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchDatabaseChangesCompletionHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchDatabaseChangesCompletionHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchDatabaseChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchDatabaseChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FetchAllChanges
	{
		[Export("fetchAllChanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFetchAllChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFetchAllChangesHandle);
		}
		[Export("setFetchAllChanges:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFetchAllChanges_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFetchAllChanges_Handle, value);
			}
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
	public unsafe virtual Action<CKRecordZoneID>? WasDeleted
	{
		[Export("recordZoneWithIDWasDeletedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V17))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneWithIDWasDeletedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneWithIDWasDeletedBlockHandle));
			return Trampolines.NIDActionArity1V17.Create(block);
		}
		[Export("setRecordZoneWithIDWasDeletedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V17))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V17.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneWithIDWasDeletedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneWithIDWasDeletedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public unsafe virtual Action<CKRecordZoneID>? WasPurged
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("recordZoneWithIDWasPurgedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V17))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneWithIDWasPurgedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneWithIDWasPurgedBlockHandle));
			return Trampolines.NIDActionArity1V17.Create(block);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setRecordZoneWithIDWasPurgedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V17))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V17.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneWithIDWasPurgedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneWithIDWasPurgedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchDatabaseChangesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchDatabaseChangesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchDatabaseChangesOperation()
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
	public CKFetchDatabaseChangesOperation(CKServerChangeToken? previousServerChangeToken)
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
