using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSIncrementalStoreNode", true)]
public class NSIncrementalStoreNode : NSObject
{
	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	private static readonly IntPtr selInitWithObjectIDWithValuesVersion_Handle = Selector.GetHandle("initWithObjectID:withValues:version:");

	private static readonly IntPtr selUpdateWithValuesVersion_Handle = Selector.GetHandle("updateWithValues:version:");

	private static readonly IntPtr selValueForPropertyDescription_Handle = Selector.GetHandle("valueForPropertyDescription:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSIncrementalStoreNode");

	private object __mt_ObjectId_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSManagedObjectID ObjectId
	{
		[Export("objectID")]
		get
		{
			return (NSManagedObjectID)(__mt_ObjectId_var = ((!IsDirectBinding) ? ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle))) : ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle)))));
		}
	}

	public virtual long Version
	{
		[Export("version")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIncrementalStoreNode()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSIncrementalStoreNode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSIncrementalStoreNode(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSIncrementalStoreNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObjectID:withValues:version:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithObjectIDWithValuesVersion_Handle, objectId.Handle, values.Handle, version);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithObjectIDWithValuesVersion_Handle, objectId.Handle, values.Handle, version);
		}
	}

	[Export("updateWithValues:version:")]
	public virtual void Update(NSDictionary values, ulong version)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selUpdateWithValuesVersion_Handle, values.Handle, version);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selUpdateWithValuesVersion_Handle, values.Handle, version);
		}
	}

	[Export("valueForPropertyDescription:")]
	public virtual NSObject ValueForPropertyDescription(NSPropertyDescription prop)
	{
		if (prop == null)
		{
			throw new ArgumentNullException("prop");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForPropertyDescription_Handle, prop.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForPropertyDescription_Handle, prop.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ObjectId_var = null;
		}
	}
}
