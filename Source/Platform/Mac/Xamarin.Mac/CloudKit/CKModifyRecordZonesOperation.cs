using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKModifyRecordZonesOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKModifyRecordZonesOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordZonesToSave_RecordZoneIDsToDelete_ = "initWithRecordZonesToSave:recordZoneIDsToDelete:";

	private static readonly IntPtr selInitWithRecordZonesToSave_RecordZoneIDsToDelete_Handle = Selector.GetHandle("initWithRecordZonesToSave:recordZoneIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyRecordZonesCompletionBlock = "modifyRecordZonesCompletionBlock";

	private static readonly IntPtr selModifyRecordZonesCompletionBlockHandle = Selector.GetHandle("modifyRecordZonesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneIDsToDelete = "recordZoneIDsToDelete";

	private static readonly IntPtr selRecordZoneIDsToDeleteHandle = Selector.GetHandle("recordZoneIDsToDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZonesToSave = "recordZonesToSave";

	private static readonly IntPtr selRecordZonesToSaveHandle = Selector.GetHandle("recordZonesToSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModifyRecordZonesCompletionBlock_ = "setModifyRecordZonesCompletionBlock:";

	private static readonly IntPtr selSetModifyRecordZonesCompletionBlock_Handle = Selector.GetHandle("setModifyRecordZonesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneIDsToDelete_ = "setRecordZoneIDsToDelete:";

	private static readonly IntPtr selSetRecordZoneIDsToDelete_Handle = Selector.GetHandle("setRecordZoneIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZonesToSave_ = "setRecordZonesToSave:";

	private static readonly IntPtr selSetRecordZonesToSave_Handle = Selector.GetHandle("setRecordZonesToSave:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKModifyRecordZonesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKModifyRecordZonesHandler? Completed
	{
		[Export("modifyRecordZonesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKModifyRecordZonesHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModifyRecordZonesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selModifyRecordZonesCompletionBlockHandle));
			return Trampolines.NIDCKModifyRecordZonesHandler.Create(block);
		}
		[Export("setModifyRecordZonesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKModifyRecordZonesHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKModifyRecordZonesHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetModifyRecordZonesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetModifyRecordZonesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordZoneID[]? RecordZoneIdsToDelete
	{
		[Export("recordZoneIDsToDelete", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordZoneID>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneIDsToDeleteHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordZoneID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneIDsToDeleteHandle));
		}
		[Export("setRecordZoneIDsToDelete:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordZone[]? RecordZonesToSave
	{
		[Export("recordZonesToSave", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZonesToSaveHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZonesToSaveHandle));
		}
		[Export("setRecordZonesToSave:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZonesToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZonesToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CKModifyRecordZonesOperation()
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
	protected CKModifyRecordZonesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKModifyRecordZonesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordZonesToSave:recordZoneIDsToDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKModifyRecordZonesOperation(CKRecordZone[]? recordZonesToSave, CKRecordZoneID[]? recordZoneIdsToDelete)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recordZonesToSave == null) ? null : NSArray.FromNSObjects(recordZonesToSave));
		NSArray nSArray2 = ((recordZoneIdsToDelete == null) ? null : NSArray.FromNSObjects(recordZoneIdsToDelete));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRecordZonesToSave_RecordZoneIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithRecordZonesToSave:recordZoneIDsToDelete:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRecordZonesToSave_RecordZoneIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithRecordZonesToSave:recordZoneIDsToDelete:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}
}
