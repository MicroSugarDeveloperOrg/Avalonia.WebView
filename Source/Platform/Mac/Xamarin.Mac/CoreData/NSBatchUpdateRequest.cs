using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSBatchUpdateRequest", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSBatchUpdateRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchUpdateRequestWithEntityName_ = "batchUpdateRequestWithEntityName:";

	private static readonly IntPtr selBatchUpdateRequestWithEntityName_Handle = Selector.GetHandle("batchUpdateRequestWithEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityName = "entityName";

	private static readonly IntPtr selEntityNameHandle = Selector.GetHandle("entityName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesSubentities = "includesSubentities";

	private static readonly IntPtr selIncludesSubentitiesHandle = Selector.GetHandle("includesSubentities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntity_ = "initWithEntity:";

	private static readonly IntPtr selInitWithEntity_Handle = Selector.GetHandle("initWithEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntityName_ = "initWithEntityName:";

	private static readonly IntPtr selInitWithEntityName_Handle = Selector.GetHandle("initWithEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesToUpdate = "propertiesToUpdate";

	private static readonly IntPtr selPropertiesToUpdateHandle = Selector.GetHandle("propertiesToUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesSubentities_ = "setIncludesSubentities:";

	private static readonly IntPtr selSetIncludesSubentities_Handle = Selector.GetHandle("setIncludesSubentities:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertiesToUpdate_ = "setPropertiesToUpdate:";

	private static readonly IntPtr selSetPropertiesToUpdate_Handle = Selector.GetHandle("setPropertiesToUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultType_ = "setResultType:";

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBatchUpdateRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription Entity
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
	public virtual bool IncludesSubentities
	{
		[Export("includesSubentities")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesSubentitiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesSubentitiesHandle);
		}
		[Export("setIncludesSubentities:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesSubentities_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesSubentities_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? PropertiesToUpdate
	{
		[Export("propertiesToUpdate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesToUpdateHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesToUpdateHandle));
		}
		[Export("setPropertiesToUpdate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertiesToUpdate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertiesToUpdate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBatchUpdateRequestResultType ResultType
	{
		[Export("resultType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSBatchUpdateRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSBatchUpdateRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBatchUpdateRequest()
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
	protected NSBatchUpdateRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBatchUpdateRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithEntityName:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchUpdateRequest(string entityName)
		: base(NSObjectFlag.Empty)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEntityName_Handle, arg), "initWithEntityName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEntityName_Handle, arg), "initWithEntityName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithEntity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchUpdateRequest(NSEntityDescription entity)
		: base(NSObjectFlag.Empty)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEntity_Handle, entity.Handle), "initWithEntity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEntity_Handle, entity.Handle), "initWithEntity:");
		}
	}

	[Export("batchUpdateRequestWithEntityName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBatchUpdateRequest BatchUpdateRequestWithEntityName(string entityName)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSBatchUpdateRequest nSObject = Runtime.GetNSObject<NSBatchUpdateRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBatchUpdateRequestWithEntityName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
