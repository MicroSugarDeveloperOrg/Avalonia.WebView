using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreData;

[Register("NSRelationshipDescription", true)]
public class NSRelationshipDescription : NSPropertyDescription
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteRule = "deleteRule";

	private static readonly IntPtr selDeleteRuleHandle = Selector.GetHandle("deleteRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationEntity = "destinationEntity";

	private static readonly IntPtr selDestinationEntityHandle = Selector.GetHandle("destinationEntity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInverseRelationship = "inverseRelationship";

	private static readonly IntPtr selInverseRelationshipHandle = Selector.GetHandle("inverseRelationship");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOrdered = "isOrdered";

	private static readonly IntPtr selIsOrderedHandle = Selector.GetHandle("isOrdered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsToMany = "isToMany";

	private static readonly IntPtr selIsToManyHandle = Selector.GetHandle("isToMany");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxCount = "maxCount";

	private static readonly IntPtr selMaxCountHandle = Selector.GetHandle("maxCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinCount = "minCount";

	private static readonly IntPtr selMinCountHandle = Selector.GetHandle("minCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeleteRule_ = "setDeleteRule:";

	private static readonly IntPtr selSetDeleteRule_Handle = Selector.GetHandle("setDeleteRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationEntity_ = "setDestinationEntity:";

	private static readonly IntPtr selSetDestinationEntity_Handle = Selector.GetHandle("setDestinationEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInverseRelationship_ = "setInverseRelationship:";

	private static readonly IntPtr selSetInverseRelationship_Handle = Selector.GetHandle("setInverseRelationship:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxCount_ = "setMaxCount:";

	private static readonly IntPtr selSetMaxCount_Handle = Selector.GetHandle("setMaxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinCount_ = "setMinCount:";

	private static readonly IntPtr selSetMinCount_Handle = Selector.GetHandle("setMinCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrdered_ = "setOrdered:";

	private static readonly IntPtr selSetOrdered_Handle = Selector.GetHandle("setOrdered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersionHash = "versionHash";

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRelationshipDescription");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDeleteRule DeleteRule
	{
		[Export("deleteRule")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDeleteRule)Messaging.UInt64_objc_msgSend(base.Handle, selDeleteRuleHandle);
			}
			return (NSDeleteRule)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDeleteRuleHandle);
		}
		[Export("setDeleteRule:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDeleteRule_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDeleteRule_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? DestinationEntity
	{
		[Export("destinationEntity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityHandle));
			}
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityHandle));
		}
		[Export("setDestinationEntity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationEntity_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationEntity_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRelationshipDescription? InverseRelationship
	{
		[Export("inverseRelationship")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selInverseRelationshipHandle));
			}
			return Runtime.GetNSObject<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInverseRelationshipHandle));
		}
		[Export("setInverseRelationship:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInverseRelationship_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInverseRelationship_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsToMany
	{
		[Export("isToMany")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsToManyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsToManyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaxCount
	{
		[Export("maxCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaxCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaxCountHandle);
		}
		[Export("setMaxCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaxCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaxCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinCount
	{
		[Export("minCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinCountHandle);
		}
		[Export("setMinCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Ordered
	{
		[Export("isOrdered")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOrderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOrderedHandle);
		}
		[Export("setOrdered:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOrdered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOrdered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSData VersionHash
	{
		[Export("versionHash")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRelationshipDescription()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSRelationshipDescription(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSRelationshipDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRelationshipDescription(IntPtr handle)
		: base(handle)
	{
	}
}
