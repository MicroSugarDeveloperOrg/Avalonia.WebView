using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityDescription", true)]
public class NSEntityDescription : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesByName = "attributesByName";

	private static readonly IntPtr selAttributesByNameHandle = Selector.GetHandle("attributesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompoundIndexes = "compoundIndexes";

	private static readonly IntPtr selCompoundIndexesHandle = Selector.GetHandle("compoundIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoreSpotlightDisplayNameExpression = "coreSpotlightDisplayNameExpression";

	private static readonly IntPtr selCoreSpotlightDisplayNameExpressionHandle = Selector.GetHandle("coreSpotlightDisplayNameExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityForName_InManagedObjectContext_ = "entityForName:inManagedObjectContext:";

	private static readonly IntPtr selEntityForName_InManagedObjectContext_Handle = Selector.GetHandle("entityForName:inManagedObjectContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexes = "indexes";

	private static readonly IntPtr selIndexesHandle = Selector.GetHandle("indexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertNewObjectForEntityForName_InManagedObjectContext_ = "insertNewObjectForEntityForName:inManagedObjectContext:";

	private static readonly IntPtr selInsertNewObjectForEntityForName_InManagedObjectContext_Handle = Selector.GetHandle("insertNewObjectForEntityForName:inManagedObjectContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAbstract = "isAbstract";

	private static readonly IntPtr selIsAbstractHandle = Selector.GetHandle("isAbstract");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsKindOfEntity_ = "isKindOfEntity:";

	private static readonly IntPtr selIsKindOfEntity_Handle = Selector.GetHandle("isKindOfEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectClassName = "managedObjectClassName";

	private static readonly IntPtr selManagedObjectClassNameHandle = Selector.GetHandle("managedObjectClassName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectModel = "managedObjectModel";

	private static readonly IntPtr selManagedObjectModelHandle = Selector.GetHandle("managedObjectModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperties = "properties";

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesByName = "propertiesByName";

	private static readonly IntPtr selPropertiesByNameHandle = Selector.GetHandle("propertiesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelationshipsByName = "relationshipsByName";

	private static readonly IntPtr selRelationshipsByNameHandle = Selector.GetHandle("relationshipsByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelationshipsWithDestinationEntity_ = "relationshipsWithDestinationEntity:";

	private static readonly IntPtr selRelationshipsWithDestinationEntity_Handle = Selector.GetHandle("relationshipsWithDestinationEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenamingIdentifier = "renamingIdentifier";

	private static readonly IntPtr selRenamingIdentifierHandle = Selector.GetHandle("renamingIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAbstract_ = "setAbstract:";

	private static readonly IntPtr selSetAbstract_Handle = Selector.GetHandle("setAbstract:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompoundIndexes_ = "setCompoundIndexes:";

	private static readonly IntPtr selSetCompoundIndexes_Handle = Selector.GetHandle("setCompoundIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCoreSpotlightDisplayNameExpression_ = "setCoreSpotlightDisplayNameExpression:";

	private static readonly IntPtr selSetCoreSpotlightDisplayNameExpression_Handle = Selector.GetHandle("setCoreSpotlightDisplayNameExpression:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndexes_ = "setIndexes:";

	private static readonly IntPtr selSetIndexes_Handle = Selector.GetHandle("setIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetManagedObjectClassName_ = "setManagedObjectClassName:";

	private static readonly IntPtr selSetManagedObjectClassName_Handle = Selector.GetHandle("setManagedObjectClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperties_ = "setProperties:";

	private static readonly IntPtr selSetProperties_Handle = Selector.GetHandle("setProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenamingIdentifier_ = "setRenamingIdentifier:";

	private static readonly IntPtr selSetRenamingIdentifier_Handle = Selector.GetHandle("setRenamingIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubentities_ = "setSubentities:";

	private static readonly IntPtr selSetSubentities_Handle = Selector.GetHandle("setSubentities:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUniquenessConstraints_ = "setUniquenessConstraints:";

	private static readonly IntPtr selSetUniquenessConstraints_Handle = Selector.GetHandle("setUniquenessConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInfo_ = "setUserInfo:";

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVersionHashModifier_ = "setVersionHashModifier:";

	private static readonly IntPtr selSetVersionHashModifier_Handle = Selector.GetHandle("setVersionHashModifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubentities = "subentities";

	private static readonly IntPtr selSubentitiesHandle = Selector.GetHandle("subentities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubentitiesByName = "subentitiesByName";

	private static readonly IntPtr selSubentitiesByNameHandle = Selector.GetHandle("subentitiesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperentity = "superentity";

	private static readonly IntPtr selSuperentityHandle = Selector.GetHandle("superentity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniquenessConstraints = "uniquenessConstraints";

	private static readonly IntPtr selUniquenessConstraintsHandle = Selector.GetHandle("uniquenessConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersionHash = "versionHash";

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersionHashModifier = "versionHashModifier";

	private static readonly IntPtr selVersionHashModifierHandle = Selector.GetHandle("versionHashModifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSEntityDescription");

	[iOS(9, 0)]
	[Mac(10, 11)]
	public NSObject[][] UniquenessConstraints
	{
		get
		{
			return NSArray.FromArrayOfArray(_UniquenessConstraints);
		}
		set
		{
			_UniquenessConstraints = NSArray.From(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Abstract
	{
		[Export("isAbstract")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAbstractHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbstractHandle);
		}
		[Export("setAbstract:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAbstract_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAbstract_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary AttributesByName
	{
		[Export("attributesByName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
	public virtual NSPropertyDescription[]? CompoundIndexes
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Export("compoundIndexes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompoundIndexesHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompoundIndexesHandle));
		}
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'NSEntityDescription.Indexes' instead.")]
		[Export("setCompoundIndexes:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompoundIndexes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompoundIndexes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSExpression CoreSpotlightDisplayNameExpression
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("coreSpotlightDisplayNameExpression", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selCoreSpotlightDisplayNameExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCoreSpotlightDisplayNameExpressionHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setCoreSpotlightDisplayNameExpression:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCoreSpotlightDisplayNameExpression_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCoreSpotlightDisplayNameExpression_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSFetchIndexDescription[]? Indexes
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("indexes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSFetchIndexDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexesHandle));
			}
			return NSArray.ArrayFromHandle<NSFetchIndexDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexesHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setIndexes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIndexes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIndexes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ManagedObjectClassName
	{
		[Export("managedObjectClassName")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectModel ManagedObjectModel
	{
		[Export("managedObjectModel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectModelHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyDescription[] Properties
	{
		[Export("properties", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle));
		}
		[Export("setProperties:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProperties_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProperties_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary PropertiesByName
	{
		[Export("propertiesByName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary RelationshipsByName
	{
		[Export("relationshipsByName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipsByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipsByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? RenamingIdentifier
	{
		[Export("renamingIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRenamingIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenamingIdentifierHandle));
		}
		[Export("setRenamingIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRenamingIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRenamingIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription[] Subentities
	{
		[Export("subentities", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubentitiesHandle));
			}
			return NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubentitiesHandle));
		}
		[Export("setSubentities:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubentities_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubentities_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary SubentitiesByName
	{
		[Export("subentitiesByName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubentitiesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubentitiesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? Superentity
	{
		[Export("superentity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperentityHandle));
			}
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperentityHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? UserInfo
	{
		[Export("userInfo", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
		[Export("setUserInfo:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData VersionHash
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
	public virtual string? VersionHashModifier
	{
		[Export("versionHashModifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashModifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashModifierHandle));
		}
		[Export("setVersionHashModifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	internal virtual NSArray _UniquenessConstraints
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("uniquenessConstraints", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selUniquenessConstraintsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniquenessConstraintsHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setUniquenessConstraints:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUniquenessConstraints_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUniquenessConstraints_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityDescription()
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
	public NSEntityDescription(NSCoder coder)
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
	protected NSEntityDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSEntityDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("entityForName:inManagedObjectContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEntityDescription? EntityForName(string entityName, NSManagedObjectContext context)
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
		NSEntityDescription nSObject = Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selEntityForName_InManagedObjectContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("insertNewObjectForEntityForName:inManagedObjectContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selInsertNewObjectForEntityForName_InManagedObjectContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("isKindOfEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsKindOfEntity(NSEntityDescription entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsKindOfEntity_Handle, entity.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsKindOfEntity_Handle, entity.Handle);
	}

	[Export("relationshipsWithDestinationEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRelationshipDescription[] RelationshipsWithDestinationEntity(NSEntityDescription entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRelationshipsWithDestinationEntity_Handle, entity.Handle));
		}
		return NSArray.ArrayFromHandle<NSRelationshipDescription>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRelationshipsWithDestinationEntity_Handle, entity.Handle));
	}
}
