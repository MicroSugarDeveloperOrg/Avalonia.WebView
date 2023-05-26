using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKModifyRecordsOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKModifyRecordsOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAtomic = "atomic";

	private static readonly IntPtr selAtomicHandle = Selector.GetHandle("atomic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientChangeTokenData = "clientChangeTokenData";

	private static readonly IntPtr selClientChangeTokenDataHandle = Selector.GetHandle("clientChangeTokenData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordsToSave_RecordIDsToDelete_ = "initWithRecordsToSave:recordIDsToDelete:";

	private static readonly IntPtr selInitWithRecordsToSave_RecordIDsToDelete_Handle = Selector.GetHandle("initWithRecordsToSave:recordIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyRecordsCompletionBlock = "modifyRecordsCompletionBlock";

	private static readonly IntPtr selModifyRecordsCompletionBlockHandle = Selector.GetHandle("modifyRecordsCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerRecordCompletionBlock = "perRecordCompletionBlock";

	private static readonly IntPtr selPerRecordCompletionBlockHandle = Selector.GetHandle("perRecordCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerRecordProgressBlock = "perRecordProgressBlock";

	private static readonly IntPtr selPerRecordProgressBlockHandle = Selector.GetHandle("perRecordProgressBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordIDsToDelete = "recordIDsToDelete";

	private static readonly IntPtr selRecordIDsToDeleteHandle = Selector.GetHandle("recordIDsToDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordsToSave = "recordsToSave";

	private static readonly IntPtr selRecordsToSaveHandle = Selector.GetHandle("recordsToSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSavePolicy = "savePolicy";

	private static readonly IntPtr selSavePolicyHandle = Selector.GetHandle("savePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAtomic_ = "setAtomic:";

	private static readonly IntPtr selSetAtomic_Handle = Selector.GetHandle("setAtomic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClientChangeTokenData_ = "setClientChangeTokenData:";

	private static readonly IntPtr selSetClientChangeTokenData_Handle = Selector.GetHandle("setClientChangeTokenData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModifyRecordsCompletionBlock_ = "setModifyRecordsCompletionBlock:";

	private static readonly IntPtr selSetModifyRecordsCompletionBlock_Handle = Selector.GetHandle("setModifyRecordsCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerRecordCompletionBlock_ = "setPerRecordCompletionBlock:";

	private static readonly IntPtr selSetPerRecordCompletionBlock_Handle = Selector.GetHandle("setPerRecordCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerRecordProgressBlock_ = "setPerRecordProgressBlock:";

	private static readonly IntPtr selSetPerRecordProgressBlock_Handle = Selector.GetHandle("setPerRecordProgressBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordIDsToDelete_ = "setRecordIDsToDelete:";

	private static readonly IntPtr selSetRecordIDsToDelete_Handle = Selector.GetHandle("setRecordIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordsToSave_ = "setRecordsToSave:";

	private static readonly IntPtr selSetRecordsToSave_Handle = Selector.GetHandle("setRecordsToSave:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSavePolicy_ = "setSavePolicy:";

	private static readonly IntPtr selSetSavePolicy_Handle = Selector.GetHandle("setSavePolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKModifyRecordsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Atomic
	{
		[Export("atomic")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAtomicHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAtomicHandle);
		}
		[Export("setAtomic:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAtomic_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAtomic_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? ClientChangeTokenData
	{
		[Export("clientChangeTokenData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientChangeTokenDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientChangeTokenDataHandle));
		}
		[Export("setClientChangeTokenData:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClientChangeTokenData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClientChangeTokenData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKModifyRecordsOperationHandler? Completed
	{
		[Export("modifyRecordsCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKModifyRecordsOperationHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModifyRecordsCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selModifyRecordsCompletionBlockHandle));
			return Trampolines.NIDCKModifyRecordsOperationHandler.Create(block);
		}
		[Export("setModifyRecordsCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKModifyRecordsOperationHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKModifyRecordsOperationHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetModifyRecordsCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetModifyRecordsCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKRecord, NSError>? PerRecordCompletion
	{
		[Export("perRecordCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V28))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerRecordCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerRecordCompletionBlockHandle));
			return Trampolines.NIDActionArity2V28.Create(block);
		}
		[Export("setPerRecordCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V28))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V28.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPerRecordCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPerRecordCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKRecord, double>? PerRecordProgress
	{
		[Export("perRecordProgressBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V35))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerRecordProgressBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerRecordProgressBlockHandle));
			return Trampolines.NIDActionArity2V35.Create(block);
		}
		[Export("setPerRecordProgressBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V35))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V35.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPerRecordProgressBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPerRecordProgressBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordID[]? RecordIdsToDelete
	{
		[Export("recordIDsToDelete", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordIDsToDeleteHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordIDsToDeleteHandle));
		}
		[Export("setRecordIDsToDelete:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecord[]? RecordsToSave
	{
		[Export("recordsToSave", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecord>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordsToSaveHandle));
			}
			return NSArray.ArrayFromHandle<CKRecord>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordsToSaveHandle));
		}
		[Export("setRecordsToSave:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordsToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordsToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordSavePolicy SavePolicy
	{
		[Export("savePolicy", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKRecordSavePolicy)Messaging.Int64_objc_msgSend(base.Handle, selSavePolicyHandle);
			}
			return (CKRecordSavePolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSavePolicyHandle);
		}
		[Export("setSavePolicy:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSavePolicy_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSavePolicy_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CKModifyRecordsOperation()
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
	protected CKModifyRecordsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKModifyRecordsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordsToSave:recordIDsToDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKModifyRecordsOperation(CKRecord[]? recordsToSave, CKRecordID[]? recordsToDelete)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recordsToSave == null) ? null : NSArray.FromNSObjects(recordsToSave));
		NSArray nSArray2 = ((recordsToDelete == null) ? null : NSArray.FromNSObjects(recordsToDelete));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRecordsToSave_RecordIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithRecordsToSave:recordIDsToDelete:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRecordsToSave_RecordIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithRecordsToSave:recordIDsToDelete:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}
}
