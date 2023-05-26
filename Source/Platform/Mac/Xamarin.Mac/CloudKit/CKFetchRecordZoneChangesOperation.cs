using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchRecordZoneChangesOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKFetchRecordZoneChangesOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfigurationsByRecordZoneID = "configurationsByRecordZoneID";

	private static readonly IntPtr selConfigurationsByRecordZoneIDHandle = Selector.GetHandle("configurationsByRecordZoneID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllChanges = "fetchAllChanges";

	private static readonly IntPtr selFetchAllChangesHandle = Selector.GetHandle("fetchAllChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordZoneChangesCompletionBlock = "fetchRecordZoneChangesCompletionBlock";

	private static readonly IntPtr selFetchRecordZoneChangesCompletionBlockHandle = Selector.GetHandle("fetchRecordZoneChangesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordZoneIDs_ConfigurationsByRecordZoneID_ = "initWithRecordZoneIDs:configurationsByRecordZoneID:";

	private static readonly IntPtr selInitWithRecordZoneIDs_ConfigurationsByRecordZoneID_Handle = Selector.GetHandle("initWithRecordZoneIDs:configurationsByRecordZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordZoneIDs_OptionsByRecordZoneID_ = "initWithRecordZoneIDs:optionsByRecordZoneID:";

	private static readonly IntPtr selInitWithRecordZoneIDs_OptionsByRecordZoneID_Handle = Selector.GetHandle("initWithRecordZoneIDs:optionsByRecordZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptionsByRecordZoneID = "optionsByRecordZoneID";

	private static readonly IntPtr selOptionsByRecordZoneIDHandle = Selector.GetHandle("optionsByRecordZoneID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordChangedBlock = "recordChangedBlock";

	private static readonly IntPtr selRecordChangedBlockHandle = Selector.GetHandle("recordChangedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordWithIDWasDeletedBlock = "recordWithIDWasDeletedBlock";

	private static readonly IntPtr selRecordWithIDWasDeletedBlockHandle = Selector.GetHandle("recordWithIDWasDeletedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneChangeTokensUpdatedBlock = "recordZoneChangeTokensUpdatedBlock";

	private static readonly IntPtr selRecordZoneChangeTokensUpdatedBlockHandle = Selector.GetHandle("recordZoneChangeTokensUpdatedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneFetchCompletionBlock = "recordZoneFetchCompletionBlock";

	private static readonly IntPtr selRecordZoneFetchCompletionBlockHandle = Selector.GetHandle("recordZoneFetchCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordZoneIDs = "recordZoneIDs";

	private static readonly IntPtr selRecordZoneIDsHandle = Selector.GetHandle("recordZoneIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfigurationsByRecordZoneID_ = "setConfigurationsByRecordZoneID:";

	private static readonly IntPtr selSetConfigurationsByRecordZoneID_Handle = Selector.GetHandle("setConfigurationsByRecordZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchAllChanges_ = "setFetchAllChanges:";

	private static readonly IntPtr selSetFetchAllChanges_Handle = Selector.GetHandle("setFetchAllChanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRecordZoneChangesCompletionBlock_ = "setFetchRecordZoneChangesCompletionBlock:";

	private static readonly IntPtr selSetFetchRecordZoneChangesCompletionBlock_Handle = Selector.GetHandle("setFetchRecordZoneChangesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOptionsByRecordZoneID_ = "setOptionsByRecordZoneID:";

	private static readonly IntPtr selSetOptionsByRecordZoneID_Handle = Selector.GetHandle("setOptionsByRecordZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordChangedBlock_ = "setRecordChangedBlock:";

	private static readonly IntPtr selSetRecordChangedBlock_Handle = Selector.GetHandle("setRecordChangedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordWithIDWasDeletedBlock_ = "setRecordWithIDWasDeletedBlock:";

	private static readonly IntPtr selSetRecordWithIDWasDeletedBlock_Handle = Selector.GetHandle("setRecordWithIDWasDeletedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneChangeTokensUpdatedBlock_ = "setRecordZoneChangeTokensUpdatedBlock:";

	private static readonly IntPtr selSetRecordZoneChangeTokensUpdatedBlock_Handle = Selector.GetHandle("setRecordZoneChangeTokensUpdatedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneFetchCompletionBlock_ = "setRecordZoneFetchCompletionBlock:";

	private static readonly IntPtr selSetRecordZoneFetchCompletionBlock_Handle = Selector.GetHandle("setRecordZoneFetchCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecordZoneIDs_ = "setRecordZoneIDs:";

	private static readonly IntPtr selSetRecordZoneIDs_Handle = Selector.GetHandle("setRecordZoneIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchRecordZoneChangesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? ChangesCompleted
	{
		[Export("fetchRecordZoneChangesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRecordZoneChangesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRecordZoneChangesCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setFetchRecordZoneChangesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRecordZoneChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRecordZoneChangesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>? ConfigurationsByRecordZoneID
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("configurationsByRecordZoneID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationsByRecordZoneIDHandle));
			}
			return Runtime.GetNSObject<NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationsByRecordZoneIDHandle));
		}
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setConfigurationsByRecordZoneID:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfigurationsByRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfigurationsByRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
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
	public unsafe virtual CKFetchRecordZoneChangesFetchCompletedHandler? FetchCompleted
	{
		[Export("recordZoneFetchCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchRecordZoneChangesFetchCompletedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneFetchCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneFetchCompletionBlockHandle));
			return Trampolines.NIDCKFetchRecordZoneChangesFetchCompletedHandler.Create(block);
		}
		[Export("setRecordZoneFetchCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchRecordZoneChangesFetchCompletedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchRecordZoneChangesFetchCompletedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneFetchCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneFetchCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
	public virtual NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesOptions>? OptionsByRecordZoneID
	{
		[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Export("optionsByRecordZoneID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesOptions>>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsByRecordZoneIDHandle));
			}
			return Runtime.GetNSObject<NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesOptions>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsByRecordZoneIDHandle));
		}
		[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ConfigurationsByRecordZoneID' instead.")]
		[Export("setOptionsByRecordZoneID:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOptionsByRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOptionsByRecordZoneID_Handle, value?.Handle ?? IntPtr.Zero);
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
	public unsafe virtual CKFetchRecordZoneChangesWithIDWasDeletedHandler? RecordWithIDWasDeleted
	{
		[Export("recordWithIDWasDeletedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchRecordZoneChangesWithIDWasDeletedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordWithIDWasDeletedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordWithIDWasDeletedBlockHandle));
			return Trampolines.NIDCKFetchRecordZoneChangesWithIDWasDeletedHandler.Create(block);
		}
		[Export("setRecordWithIDWasDeletedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchRecordZoneChangesWithIDWasDeletedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchRecordZoneChangesWithIDWasDeletedHandler.Handler, value);
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
	public unsafe virtual CKFetchRecordZoneChangesTokensUpdatedHandler? RecordZoneChangeTokensUpdated
	{
		[Export("recordZoneChangeTokensUpdatedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchRecordZoneChangesTokensUpdatedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordZoneChangeTokensUpdatedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRecordZoneChangeTokensUpdatedBlockHandle));
			return Trampolines.NIDCKFetchRecordZoneChangesTokensUpdatedHandler.Create(block);
		}
		[Export("setRecordZoneChangeTokensUpdatedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchRecordZoneChangesTokensUpdatedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchRecordZoneChangesTokensUpdatedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecordZoneChangeTokensUpdatedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecordZoneChangeTokensUpdatedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordZoneID[]? RecordZoneIDs
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchRecordZoneChangesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchRecordZoneChangesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordZoneChangesOperation()
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

	[Export("initWithRecordZoneIDs:optionsByRecordZoneID:")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use the overload with the 'NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>' parameter instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use the overload with the 'NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>' parameter instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use the overload with the 'NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>' parameter instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the overload with the 'NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>' parameter instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordZoneChangesOperation(CKRecordZoneID[] recordZoneIDs, NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesOptions>? optionsByRecordZoneID)
		: base(NSObjectFlag.Empty)
	{
		if (recordZoneIDs == null)
		{
			throw new ArgumentNullException("recordZoneIDs");
		}
		NSArray nSArray = NSArray.FromNSObjects(recordZoneIDs);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRecordZoneIDs_OptionsByRecordZoneID_Handle, nSArray.Handle, optionsByRecordZoneID?.Handle ?? IntPtr.Zero), "initWithRecordZoneIDs:optionsByRecordZoneID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRecordZoneIDs_OptionsByRecordZoneID_Handle, nSArray.Handle, optionsByRecordZoneID?.Handle ?? IntPtr.Zero), "initWithRecordZoneIDs:optionsByRecordZoneID:");
		}
		nSArray.Dispose();
	}

	[Export("initWithRecordZoneIDs:configurationsByRecordZoneID:")]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchRecordZoneChangesOperation(CKRecordZoneID[] recordZoneIDs, NSDictionary<CKRecordZoneID, CKFetchRecordZoneChangesConfiguration>? configurationsByRecordZoneID)
		: base(NSObjectFlag.Empty)
	{
		if (recordZoneIDs == null)
		{
			throw new ArgumentNullException("recordZoneIDs");
		}
		NSArray nSArray = NSArray.FromNSObjects(recordZoneIDs);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRecordZoneIDs_ConfigurationsByRecordZoneID_Handle, nSArray.Handle, configurationsByRecordZoneID?.Handle ?? IntPtr.Zero), "initWithRecordZoneIDs:configurationsByRecordZoneID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRecordZoneIDs_ConfigurationsByRecordZoneID_Handle, nSArray.Handle, configurationsByRecordZoneID?.Handle ?? IntPtr.Zero), "initWithRecordZoneIDs:configurationsByRecordZoneID:");
		}
		nSArray.Dispose();
	}
}
