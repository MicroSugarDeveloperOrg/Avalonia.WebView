using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchRecordZonesOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKFetchRecordZonesOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllRecordZonesOperation = "fetchAllRecordZonesOperation";

	private static readonly IntPtr selFetchAllRecordZonesOperationHandle = Selector.GetHandle("fetchAllRecordZonesOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordZonesCompletionBlock = "fetchRecordZonesCompletionBlock";

	private static readonly IntPtr selFetchRecordZonesCompletionBlockHandle = Selector.GetHandle("fetchRecordZonesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordZoneIDs_ = "initWithRecordZoneIDs:";

	private static readonly IntPtr selInitWithRecordZoneIDs_Handle = Selector.GetHandle("initWithRecordZoneIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneIDs = "recordZoneIDs";

	private static readonly IntPtr selRecordZoneIDsHandle = Selector.GetHandle("recordZoneIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRecordZonesCompletionBlock_ = "setFetchRecordZonesCompletionBlock:";

	private static readonly IntPtr selSetFetchRecordZonesCompletionBlock_Handle = Selector.GetHandle("setFetchRecordZonesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneIDs_ = "setRecordZoneIDs:";

	private static readonly IntPtr selSetRecordZoneIDs_Handle = Selector.GetHandle("setRecordZoneIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchRecordZonesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKRecordZoneCompleteHandler? Completed
	{
		[Export("fetchRecordZonesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKRecordZoneCompleteHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRecordZonesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRecordZonesCompletionBlockHandle));
			return Trampolines.NIDCKRecordZoneCompleteHandler.Create(block);
		}
		[Export("setFetchRecordZonesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKRecordZoneCompleteHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKRecordZoneCompleteHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRecordZonesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRecordZonesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordZoneID[]? RecordZoneIds
	{
		[Export("recordZoneIDs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordZoneID>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneIDsHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordZoneID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneIDsHandle));
		}
		[Export("setRecordZoneIDs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CKFetchRecordZonesOperation()
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
	protected CKFetchRecordZonesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchRecordZonesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordZoneIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordZonesOperation(CKRecordZoneID[] zoneIds)
		: base(NSObjectFlag.Empty)
	{
		if (zoneIds == null)
		{
			throw new ArgumentNullException("zoneIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(zoneIds);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRecordZoneIDs_Handle, nSArray.Handle), "initWithRecordZoneIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRecordZoneIDs_Handle, nSArray.Handle), "initWithRecordZoneIDs:");
		}
		nSArray.Dispose();
	}

	[Export("fetchAllRecordZonesOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKFetchRecordZonesOperation FetchAllRecordZonesOperation()
	{
		return Runtime.GetNSObject<CKFetchRecordZonesOperation>(Messaging.IntPtr_objc_msgSend(class_ptr, selFetchAllRecordZonesOperationHandle));
	}
}
