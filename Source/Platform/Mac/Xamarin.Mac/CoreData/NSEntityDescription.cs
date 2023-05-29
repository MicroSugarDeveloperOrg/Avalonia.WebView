using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityDescription", true)]
public class NSEntityDescription : NSObject
{
	private static readonly IntPtr selManagedObjectModelHandle = Selector.GetHandle("managedObjectModel");

	private static readonly IntPtr selManagedObjectClassNameHandle = Selector.GetHandle("managedObjectClassName");

	private static readonly IntPtr selSetManagedObjectClassName_Handle = Selector.GetHandle("setManagedObjectClassName:");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selIsAbstractHandle = Selector.GetHandle("isAbstract");

	private static readonly IntPtr selSetAbstract_Handle = Selector.GetHandle("setAbstract:");

	private static readonly IntPtr selSubentitiesByNameHandle = Selector.GetHandle("subentitiesByName");

	private static readonly IntPtr selSubentitiesHandle = Selector.GetHandle("subentities");

	private static readonly IntPtr selSetSubentities_Handle = Selector.GetHandle("setSubentities:");

	private static readonly IntPtr selSuperentityHandle = Selector.GetHandle("superentity");

	private static readonly IntPtr selPropertiesByNameHandle = Selector.GetHandle("propertiesByName");

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	private static readonly IntPtr selSetProperties_Handle = Selector.GetHandle("setProperties:");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	private static readonly IntPtr selAttributesByNameHandle = Selector.GetHandle("attributesByName");

	private static readonly IntPtr selRelationshipsByNameHandle = Selector.GetHandle("relationshipsByName");

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	private static readonly IntPtr selVersionHashModifierHandle = Selector.GetHandle("versionHashModifier");

	private static readonly IntPtr selSetVersionHashModifier_Handle = Selector.GetHandle("setVersionHashModifier:");

	private static readonly IntPtr selCompoundIndexesHandle = Selector.GetHandle("compoundIndexes");

	private static readonly IntPtr selSetCompoundIndexes_Handle = Selector.GetHandle("setCompoundIndexes:");

	private static readonly IntPtr selEntityForNameInManagedObjectContext_Handle = Selector.GetHandle("entityForName:inManagedObjectContext:");

	private static readonly IntPtr selInsertNewObjectForEntityForNameInManagedObjectContext_Handle = Selector.GetHandle("insertNewObjectForEntityForName:inManagedObjectContext:");

	private static readonly IntPtr selRelationshipsWithDestinationEntity_Handle = Selector.GetHandle("relationshipsWithDestinationEntity:");

	private static readonly IntPtr selIsKindOfEntity_Handle = Selector.GetHandle("isKindOfEntity:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSEntityDescription");

	private object __mt_ManagedObjectModel_var;

	private object __mt_SubentitiesByName_var;

	private object __mt_Subentities_var;

	private object __mt_Superentity_var;

	private object __mt_PropertiesByName_var;

	private object __mt_Properties_var;

	private object __mt_UserInfo_var;

	private object __mt_AttributesByName_var;

	private object __mt_RelationshipsByName_var;

	private object __mt_VersionHash_var;

	private object __mt_CompoundIndexes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSManagedObjectModel ManagedObjectModel
	{
		[Export("managedObjectModel")]
		get
		{
			return (NSManagedObjectModel)(__mt_ManagedObjectModel_var = ((!IsDirectBinding) ? ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectModelHandle))) : ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectModelHandle)))));
		}
	}

	public virtual string ManagedObjectClassName
	{
		[Export("managedObjectClassName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectClassNameHandle));
		}
		[Export("setManagedObjectClassName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetManagedObjectClassName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetManagedObjectClassName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Abstract
	{
		[Export("isAbstract")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAbstractHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbstractHandle);
		}
		[Export("setAbstract:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAbstract_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAbstract_Handle, value);
			}
		}
	}

	public virtual NSDictionary SubentitiesByName
	{
		[Export("subentitiesByName")]
		get
		{
			return (NSDictionary)(__mt_SubentitiesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubentitiesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSubentitiesByNameHandle)))));
		}
	}

	public virtual NSEntityDescription[] Subentities
	{
		[Export("subentities")]
		get
		{
			return (NSEntityDescription[])(__mt_Subentities_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubentitiesHandle)) : NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubentitiesHandle))));
		}
		[Export("setSubentities:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubentities_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubentities_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Subentities_var = value;
		}
	}

	public virtual NSEntityDescription Superentity
	{
		[Export("superentity")]
		get
		{
			return (NSEntityDescription)(__mt_Superentity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperentityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperentityHandle)))));
		}
	}

	public virtual NSDictionary PropertiesByName
	{
		[Export("propertiesByName")]
		get
		{
			return (NSDictionary)(__mt_PropertiesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesByNameHandle)))));
		}
	}

	public virtual NSPropertyDescription[] Properties
	{
		[Export("properties")]
		get
		{
			return (NSPropertyDescription[])(__mt_Properties_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle)) : NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle))));
		}
		[Export("setProperties:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProperties_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProperties_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Properties_var = value;
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
		[Export("setUserInfo:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserInfo_Handle, value.Handle);
			}
			__mt_UserInfo_var = value;
		}
	}

	public virtual NSDictionary AttributesByName
	{
		[Export("attributesByName")]
		get
		{
			return (NSDictionary)(__mt_AttributesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesByNameHandle)))));
		}
	}

	public virtual NSDictionary RelationshipsByName
	{
		[Export("relationshipsByName")]
		get
		{
			return (NSDictionary)(__mt_RelationshipsByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipsByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipsByNameHandle)))));
		}
	}

	public virtual NSData VersionHash
	{
		[Export("versionHash")]
		get
		{
			return (NSData)(__mt_VersionHash_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashHandle)))));
		}
	}

	public virtual string VersionHashModifier
	{
		[Export("versionHashModifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashModifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashModifierHandle));
		}
		[Export("setVersionHashModifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVersionHashModifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVersionHashModifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Since(5, 0)]
	public virtual NSPropertyDescription[] CompoundIndexes
	{
		[Export("compoundIndexes")]
		get
		{
			return (NSPropertyDescription[])(__mt_CompoundIndexes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompoundIndexesHandle)) : NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompoundIndexesHandle))));
		}
		[Export("setCompoundIndexes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompoundIndexes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompoundIndexes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_CompoundIndexes_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityDescription()
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
	public NSEntityDescription(NSCoder coder)
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
	public NSEntityDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEntityDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("entityForName:inManagedObjectContext:")]
	public static NSEntityDescription EntityForName(string entityName, NSManagedObjectContext context)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSEntityDescription result = (NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selEntityForNameInManagedObjectContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("insertNewObjectForEntityForName:inManagedObjectContext:")]
	public static NSObject InsertNewObjectForEntityForName(string entityName, NSManagedObjectContext context)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selInsertNewObjectForEntityForNameInManagedObjectContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("relationshipsWithDestinationEntity:")]
	public virtual NSRelationshipDescription[] RelationshipsWithDestinationEntity(NSEntityDescription entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRelationshipsWithDestinationEntity_Handle, entity.Handle));
		}
		return NSArray.ArrayFromHandle<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRelationshipsWithDestinationEntity_Handle, entity.Handle));
	}

	[Export("isKindOfEntity:")]
	public virtual bool IsKindOfEntity(NSEntityDescription entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsKindOfEntity_Handle, entity.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsKindOfEntity_Handle, entity.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ManagedObjectModel_var = null;
			__mt_SubentitiesByName_var = null;
			__mt_Subentities_var = null;
			__mt_Superentity_var = null;
			__mt_PropertiesByName_var = null;
			__mt_Properties_var = null;
			__mt_UserInfo_var = null;
			__mt_AttributesByName_var = null;
			__mt_RelationshipsByName_var = null;
			__mt_VersionHash_var = null;
			__mt_CompoundIndexes_var = null;
		}
	}
}
