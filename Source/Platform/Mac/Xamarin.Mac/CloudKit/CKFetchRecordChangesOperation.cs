using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchRecordChangesOperation", true)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKFetchRecordZoneChangesOperation' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKFetchRecordZoneChangesOperation' instead.")]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class CKFetchRecordChangesOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesiredKeys = "desiredKeys";

	private static readonly IntPtr selDesiredKeysHandle = Selector.GetHandle("desiredKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordChangesCompletionBlock = "fetchRecordChangesCompletionBlock";

	private static readonly IntPtr selFetchRecordChangesCompletionBlockHandle = Selector.GetHandle("fetchRecordChangesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordZoneID_PreviousServerChangeToken_ = "initWithRecordZoneID:previousServerChangeToken:";

	private static readonly IntPtr selInitWithRecordZoneID_PreviousServerChangeToken_Handle = Selector.GetHandle("initWithRecordZoneID:previousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoreComing = "moreComing";

	private static readonly IntPtr selMoreComingHandle = Selector.GetHandle("moreComing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousServerChangeToken = "previousServerChangeToken";

	private static readonly IntPtr selPreviousServerChangeTokenHandle = Selector.GetHandle("previousServerChangeToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordChangedBlock = "recordChangedBlock";

	private static readonly IntPtr selRecordChangedBlockHandle = Selector.GetHandle("recordChangedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordWithIDWasDeletedBlock = "recordWithIDWasDeletedBlock";

	private static readonly IntPtr selRecordWithIDWasDeletedBlockHandle = Selector.GetHandle("recordWithIDWasDeletedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneID = "recordZoneID";

	private static readonly IntPtr selRecordZoneIDHandle = Selector.GetHandle("recordZoneID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultsLimit = "resultsLimit";

	private static readonly IntPtr selResultsLimitHandle = Selector.GetHandle("resultsLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesiredKeys_ = "setDesiredKeys:";

	private static readonly IntPtr selSetDesiredKeys_Handle = Selector.GetHandle("setDesiredKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRecordChangesCompletionBlock_ = "setFetchRecordChangesCompletionBlock:";

	private static readonly IntPtr selSetFetchRecordChangesCompletionBlock_Handle = Selector.GetHandle("setFetchRecordChangesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviousServerChangeToken_ = "setPreviousServerChangeToken:";

	private static readonly IntPtr selSetPreviousServerChangeToken_Handle = Selector.GetHandle("setPreviousServerChangeToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordChangedBlock_ = "setRecordChangedBlock:";

	private static readonly IntPtr selSetRecordChangedBlock_Handle = Selector.GetHandle("setRecordChangedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordWithIDWasDeletedBlock_ = "setRecordWithIDWasDeletedBlock:";

	private static readonly IntPtr selSetRecordWithIDWasDeletedBlock_Handle = Selector.GetHandle("setRecordWithIDWasDeletedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneID_ = "setRecordZoneID:";

	private static readonly IntPtr selSetRecordZoneID_Handle = Selector.GetHandle("setRecordZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultsLimit_ = "setResultsLimit:";

	private static readonly IntPtr selSetResultsLimit_Handle = Selector.GetHandle("setResultsLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchRecordChangesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKFetchRecordChangesHandler? AllChangesReported
	{
		[Export("fetchRecordChangesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchRecordChangesHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRecordChangesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRecordChangesCompletionBlockHandle));
			return Trampolines.NIDCKFetchRecordChangesHandler.Create(block);
		}
		[Export("setFetchRecordChangesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchRecordChangesHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchRecordChangesHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRecordChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRecordChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? DesiredKeys
	{
		[Export("desiredKeys", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDesiredKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDesiredKeysHandle));
		}
		[Export("setDesiredKeys:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDesiredKeys_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDesiredKeys_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
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
	public unsafe virtual Action<CKRecord>? RecordChanged
	{
		[Export("recordChangedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V19))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordChangedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordChangedBlockHandle));
			return Trampolines.NIDActionArity1V19.Create(block);
		}
		[Export("setRecordChangedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V19))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V19.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordChangedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordChangedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKRecordID>? RecordDeleted
	{
		[Export("recordWithIDWasDeletedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V20))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordWithIDWasDeletedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordWithIDWasDeletedBlockHandle));
			return Trampolines.NIDActionArity1V20.Create(block);
		}
		[Export("setRecordWithIDWasDeletedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V20))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V20.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordWithIDWasDeletedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordWithIDWasDeletedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordZoneID? RecordZoneId
	{
		[Export("recordZoneID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneIDHandle));
			}
			return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneIDHandle));
		}
		[Export("setRecordZoneID:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResultsLimit
	{
		[Export("resultsLimit", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResultsLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResultsLimitHandle);
		}
		[Export("setResultsLimit:", ArgumentSemantic.Assign)]
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
	protected CKFetchRecordChangesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchRecordChangesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordChangesOperation()
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

	[Export("initWithRecordZoneID:previousServerChangeToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordChangesOperation(CKRecordZoneID recordZoneID, CKServerChangeToken? previousServerChangeToken)
		: base(NSObjectFlag.Empty)
	{
		if (recordZoneID == null)
		{
			throw new ArgumentNullException("recordZoneID");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRecordZoneID_PreviousServerChangeToken_Handle, recordZoneID.Handle, previousServerChangeToken?.Handle ?? IntPtr.Zero), "initWithRecordZoneID:previousServerChangeToken:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRecordZoneID_PreviousServerChangeToken_Handle, recordZoneID.Handle, previousServerChangeToken?.Handle ?? IntPtr.Zero), "initWithRecordZoneID:previousServerChangeToken:");
		}
	}
}
