using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSBatchDeleteRequest", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSBatchDeleteRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequest = "fetchRequest";

	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFetchRequest_ = "initWithFetchRequest:";

	private static readonly IntPtr selInitWithFetchRequest_Handle = Selector.GetHandle("initWithFetchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObjectIDs_ = "initWithObjectIDs:";

	private static readonly IntPtr selInitWithObjectIDs_Handle = Selector.GetHandle("initWithObjectIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultType_ = "setResultType:";

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBatchDeleteRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchRequest FetchRequest
	{
		[Export("fetchRequest", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestHandle));
			}
			return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBatchDeleteRequestResultType ResultType
	{
		[Export("resultType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSBatchDeleteRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSBatchDeleteRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
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
	protected NSBatchDeleteRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBatchDeleteRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFetchRequest:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchDeleteRequest(NSFetchRequest fetch)
		: base(NSObjectFlag.Empty)
	{
		if (fetch == null)
		{
			throw new ArgumentNullException("fetch");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFetchRequest_Handle, fetch.Handle), "initWithFetchRequest:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFetchRequest_Handle, fetch.Handle), "initWithFetchRequest:");
		}
	}

	[Export("initWithObjectIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBatchDeleteRequest(NSManagedObjectID[] objects)
		: base(NSObjectFlag.Empty)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObjectIDs_Handle, nSArray.Handle), "initWithObjectIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObjectIDs_Handle, nSArray.Handle), "initWithObjectIDs:");
		}
		nSArray.Dispose();
	}
}
