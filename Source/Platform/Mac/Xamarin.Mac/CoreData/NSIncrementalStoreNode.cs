using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSIncrementalStoreNode", true)]
public class NSIncrementalStoreNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObjectID_WithValues_Version_ = "initWithObjectID:withValues:version:";

	private static readonly IntPtr selInitWithObjectID_WithValues_Version_Handle = Selector.GetHandle("initWithObjectID:withValues:version:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectID = "objectID";

	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithValues_Version_ = "updateWithValues:version:";

	private static readonly IntPtr selUpdateWithValues_Version_Handle = Selector.GetHandle("updateWithValues:version:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForPropertyDescription_ = "valueForPropertyDescription:";

	private static readonly IntPtr selValueForPropertyDescription_Handle = Selector.GetHandle("valueForPropertyDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSIncrementalStoreNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID ObjectId
	{
		[Export("objectID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long Version
	{
		[Export("version")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIncrementalStoreNode()
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
	protected NSIncrementalStoreNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSIncrementalStoreNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObjectID:withValues:version:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSIncrementalStoreNode(NSManagedObjectID objectId, NSDictionary values, ulong version)
		: base(NSObjectFlag.Empty)
	{
		if (objectId == null)
		{
			throw new ArgumentNullException("objectId");
		}
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithObjectID_WithValues_Version_Handle, objectId.Handle, values.Handle, version), "initWithObjectID:withValues:version:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithObjectID_WithValues_Version_Handle, objectId.Handle, values.Handle, version), "initWithObjectID:withValues:version:");
		}
	}

	[Export("updateWithValues:version:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(NSDictionary values, ulong version)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selUpdateWithValues_Version_Handle, values.Handle, version);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selUpdateWithValues_Version_Handle, values.Handle, version);
		}
	}

	[Export("valueForPropertyDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ValueForPropertyDescription(NSPropertyDescription prop)
	{
		if (prop == null)
		{
			throw new ArgumentNullException("prop");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForPropertyDescription_Handle, prop.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForPropertyDescription_Handle, prop.Handle));
	}
}
