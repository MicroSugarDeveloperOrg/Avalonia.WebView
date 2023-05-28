using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSBatchInsertRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSBatchInsertRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchInsertRequestWithEntityName_Objects_ = "batchInsertRequestWithEntityName:objects:";

	private static readonly IntPtr selBatchInsertRequestWithEntityName_Objects_Handle = Selector.GetHandle("batchInsertRequestWithEntityName:objects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityName = "entityName";

	private static readonly IntPtr selEntityNameHandle = Selector.GetHandle("entityName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntity_Objects_ = "initWithEntity:objects:";

	private static readonly IntPtr selInitWithEntity_Objects_Handle = Selector.GetHandle("initWithEntity:objects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntityName_Objects_ = "initWithEntityName:objects:";

	private static readonly IntPtr selInitWithEntityName_Objects_Handle = Selector.GetHandle("initWithEntityName:objects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectsToInsert = "objectsToInsert";

	private static readonly IntPtr selObjectsToInsertHandle = Selector.GetHandle("objectsToInsert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObjectsToInsert_ = "setObjectsToInsert:";

	private static readonly IntPtr selSetObjectsToInsert_Handle = Selector.GetHandle("setObjectsToInsert:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultType_ = "setResultType:";

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBatchInsertRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? Entity
	{
		[Export("entity", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle));
			}
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string EntityName
	{
		[Export("entityName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>[]? ObjectsToInsert
	{
		[Export("objectsToInsert", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectsToInsertHandle));
			}
			return NSArray.ArrayFromHandle<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectsToInsertHandle));
		}
		[Export("setObjectsToInsert:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectsToInsert_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectsToInsert_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBatchInsertRequestResultType ResultType
	{
		[Export("resultType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSBatchInsertRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSBatchInsertRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
		[Export("setResultType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResultType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResultType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBatchInsertRequest()
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
	protected NSBatchInsertRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBatchInsertRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithEntityName:objects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchInsertRequest(string entityName, NSDictionary<NSString, NSObject>[] dictionaries)
		: base(NSObjectFlag.Empty)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		if (dictionaries == null)
		{
			throw new ArgumentNullException("dictionaries");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSArray nSArray = NSArray.FromNSObjects(dictionaries);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEntityName_Objects_Handle, arg, nSArray.Handle), "initWithEntityName:objects:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEntityName_Objects_Handle, arg, nSArray.Handle), "initWithEntityName:objects:");
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}

	[Export("initWithEntity:objects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchInsertRequest(NSEntityDescription entity, NSDictionary<NSString, NSObject>[] dictionaries)
		: base(NSObjectFlag.Empty)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (dictionaries == null)
		{
			throw new ArgumentNullException("dictionaries");
		}
		NSArray nSArray = NSArray.FromNSObjects(dictionaries);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEntity_Objects_Handle, entity.Handle, nSArray.Handle), "initWithEntity:objects:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEntity_Objects_Handle, entity.Handle, nSArray.Handle), "initWithEntity:objects:");
		}
		nSArray.Dispose();
	}

	[Export("batchInsertRequestWithEntityName:objects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBatchInsertRequest BatchInsertRequest(string entityName, NSDictionary<NSString, NSObject>[] dictionaries)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		if (dictionaries == null)
		{
			throw new ArgumentNullException("dictionaries");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSArray nSArray = NSArray.FromNSObjects(dictionaries);
		NSBatchInsertRequest nSObject = Runtime.GetNSObject<NSBatchInsertRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selBatchInsertRequestWithEntityName_Objects_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}
}
