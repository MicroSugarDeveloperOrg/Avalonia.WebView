using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchRecordsOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKFetchRecordsOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesiredKeys = "desiredKeys";

	private static readonly IntPtr selDesiredKeysHandle = Selector.GetHandle("desiredKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchCurrentUserRecordOperation = "fetchCurrentUserRecordOperation";

	private static readonly IntPtr selFetchCurrentUserRecordOperationHandle = Selector.GetHandle("fetchCurrentUserRecordOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordsCompletionBlock = "fetchRecordsCompletionBlock";

	private static readonly IntPtr selFetchRecordsCompletionBlockHandle = Selector.GetHandle("fetchRecordsCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordIDs_ = "initWithRecordIDs:";

	private static readonly IntPtr selInitWithRecordIDs_Handle = Selector.GetHandle("initWithRecordIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerRecordCompletionBlock = "perRecordCompletionBlock";

	private static readonly IntPtr selPerRecordCompletionBlockHandle = Selector.GetHandle("perRecordCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerRecordProgressBlock = "perRecordProgressBlock";

	private static readonly IntPtr selPerRecordProgressBlockHandle = Selector.GetHandle("perRecordProgressBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordIDs = "recordIDs";

	private static readonly IntPtr selRecordIDsHandle = Selector.GetHandle("recordIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesiredKeys_ = "setDesiredKeys:";

	private static readonly IntPtr selSetDesiredKeys_Handle = Selector.GetHandle("setDesiredKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRecordsCompletionBlock_ = "setFetchRecordsCompletionBlock:";

	private static readonly IntPtr selSetFetchRecordsCompletionBlock_Handle = Selector.GetHandle("setFetchRecordsCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerRecordCompletionBlock_ = "setPerRecordCompletionBlock:";

	private static readonly IntPtr selSetPerRecordCompletionBlock_Handle = Selector.GetHandle("setPerRecordCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerRecordProgressBlock_ = "setPerRecordProgressBlock:";

	private static readonly IntPtr selSetPerRecordProgressBlock_Handle = Selector.GetHandle("setPerRecordProgressBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordIDs_ = "setRecordIDs:";

	private static readonly IntPtr selSetRecordIDs_Handle = Selector.GetHandle("setRecordIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchRecordsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKFetchRecordsCompletedHandler? Completed
	{
		[Export("fetchRecordsCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchRecordsCompletedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRecordsCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRecordsCompletionBlockHandle));
			return Trampolines.NIDCKFetchRecordsCompletedHandler.Create(block);
		}
		[Export("setFetchRecordsCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchRecordsCompletedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchRecordsCompletedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRecordsCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRecordsCompletionBlock_Handle, (IntPtr)ptr);
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
	public unsafe virtual Action<CKRecord, CKRecordID, NSError>? PerRecordCompletion
	{
		[Export("perRecordCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity3V0))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerRecordCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerRecordCompletionBlockHandle));
			return Trampolines.NIDActionArity3V0.Create(block);
		}
		[Export("setPerRecordCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity3V0))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V0.Handler, value);
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
	public unsafe virtual Action<CKRecordID, double>? PerRecordProgress
	{
		[Export("perRecordProgressBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V34))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerRecordProgressBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerRecordProgressBlockHandle));
			return Trampolines.NIDActionArity2V34.Create(block);
		}
		[Export("setPerRecordProgressBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V34))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V34.Handler, value);
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
	public virtual CKRecordID[]? RecordIds
	{
		[Export("recordIDs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordIDsHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordIDsHandle));
		}
		[Export("setRecordIDs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CKFetchRecordsOperation()
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
	protected CKFetchRecordsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchRecordsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordsOperation(CKRecordID[] recordIds)
		: base(NSObjectFlag.Empty)
	{
		if (recordIds == null)
		{
			throw new ArgumentNullException("recordIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(recordIds);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRecordIDs_Handle, nSArray.Handle), "initWithRecordIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRecordIDs_Handle, nSArray.Handle), "initWithRecordIDs:");
		}
		nSArray.Dispose();
	}

	[Export("fetchCurrentUserRecordOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKFetchRecordsOperation FetchCurrentUserRecordOperation()
	{
		return Runtime.GetNSObject<CKFetchRecordsOperation>(Messaging.IntPtr_objc_msgSend(class_ptr, selFetchCurrentUserRecordOperationHandle));
	}
}
