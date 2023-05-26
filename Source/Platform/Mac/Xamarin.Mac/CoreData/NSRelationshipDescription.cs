using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSRelationshipDescription", true)]
public class NSRelationshipDescription : NSPropertyDescription
{
	private static readonly IntPtr selDestinationEntityHandle = Selector.GetHandle("destinationEntity");

	private static readonly IntPtr selSetDestinationEntity_Handle = Selector.GetHandle("setDestinationEntity:");

	private static readonly IntPtr selInverseRelationshipHandle = Selector.GetHandle("inverseRelationship");

	private static readonly IntPtr selSetInverseRelationship_Handle = Selector.GetHandle("setInverseRelationship:");

	private static readonly IntPtr selMaxCountHandle = Selector.GetHandle("maxCount");

	private static readonly IntPtr selSetMaxCount_Handle = Selector.GetHandle("setMaxCount:");

	private static readonly IntPtr selMinCountHandle = Selector.GetHandle("minCount");

	private static readonly IntPtr selSetMinCount_Handle = Selector.GetHandle("setMinCount:");

	private static readonly IntPtr selDeleteRuleHandle = Selector.GetHandle("deleteRule");

	private static readonly IntPtr selSetDeleteRule_Handle = Selector.GetHandle("setDeleteRule:");

	private static readonly IntPtr selIsToManyHandle = Selector.GetHandle("isToMany");

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	private static readonly IntPtr selIsOrderedHandle = Selector.GetHandle("isOrdered");

	private static readonly IntPtr selSetOrdered_Handle = Selector.GetHandle("setOrdered:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRelationshipDescription");

	private object __mt_DestinationEntity_var;

	private object __mt_InverseRelationship_var;

	private object __mt_VersionHash_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEntityDescription DestinationEntity
	{
		[Export("destinationEntity")]
		get
		{
			return (NSEntityDescription)(__mt_DestinationEntity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityHandle)))));
		}
		[Export("setDestinationEntity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationEntity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationEntity_Handle, value.Handle);
			}
			__mt_DestinationEntity_var = value;
		}
	}

	public virtual NSRelationshipDescription InverseRelationship
	{
		[Export("inverseRelationship")]
		get
		{
			return (NSRelationshipDescription)(__mt_InverseRelationship_var = ((!IsDirectBinding) ? ((NSRelationshipDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInverseRelationshipHandle))) : ((NSRelationshipDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInverseRelationshipHandle)))));
		}
		[Export("setInverseRelationship:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInverseRelationship_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInverseRelationship_Handle, value.Handle);
			}
			__mt_InverseRelationship_var = value;
		}
	}

	public virtual uint MaxCount
	{
		[Export("maxCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMaxCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMaxCountHandle);
		}
		[Export("setMaxCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMaxCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMaxCount_Handle, value);
			}
		}
	}

	public virtual uint MinCount
	{
		[Export("minCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMinCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMinCountHandle);
		}
		[Export("setMinCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMinCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMinCount_Handle, value);
			}
		}
	}

	public virtual NSDeleteRule DeleteRule
	{
		[Export("deleteRule")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSDeleteRule)Messaging.UInt64_objc_msgSend(base.Handle, selDeleteRuleHandle);
			}
			return (NSDeleteRule)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDeleteRuleHandle);
		}
		[Export("setDeleteRule:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDeleteRule_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDeleteRule_Handle, (ulong)value);
			}
		}
	}

	public virtual bool IsToMany
	{
		[Export("isToMany")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsToManyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsToManyHandle);
		}
	}

	public new virtual NSData VersionHash
	{
		[Export("versionHash")]
		get
		{
			return (NSData)(__mt_VersionHash_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashHandle)))));
		}
	}

	[Since(5, 0)]
	public virtual bool Ordered
	{
		[Export("isOrdered")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOrderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOrderedHandle);
		}
		[Export("setOrdered:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOrdered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOrdered_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRelationshipDescription()
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
	public NSRelationshipDescription(NSCoder coder)
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
	public NSRelationshipDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRelationshipDescription(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DestinationEntity_var = null;
			__mt_InverseRelationship_var = null;
			__mt_VersionHash_var = null;
		}
	}
}
