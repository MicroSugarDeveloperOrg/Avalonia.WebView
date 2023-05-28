using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityMapping", true)]
public class NSEntityMapping : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeMappings = "attributeMappings";

	private static readonly IntPtr selAttributeMappingsHandle = Selector.GetHandle("attributeMappings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationEntityName = "destinationEntityName";

	private static readonly IntPtr selDestinationEntityNameHandle = Selector.GetHandle("destinationEntityName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationEntityVersionHash = "destinationEntityVersionHash";

	private static readonly IntPtr selDestinationEntityVersionHashHandle = Selector.GetHandle("destinationEntityVersionHash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityMigrationPolicyClassName = "entityMigrationPolicyClassName";

	private static readonly IntPtr selEntityMigrationPolicyClassNameHandle = Selector.GetHandle("entityMigrationPolicyClassName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMappingType = "mappingType";

	private static readonly IntPtr selMappingTypeHandle = Selector.GetHandle("mappingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelationshipMappings = "relationshipMappings";

	private static readonly IntPtr selRelationshipMappingsHandle = Selector.GetHandle("relationshipMappings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeMappings_ = "setAttributeMappings:";

	private static readonly IntPtr selSetAttributeMappings_Handle = Selector.GetHandle("setAttributeMappings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationEntityName_ = "setDestinationEntityName:";

	private static readonly IntPtr selSetDestinationEntityName_Handle = Selector.GetHandle("setDestinationEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationEntityVersionHash_ = "setDestinationEntityVersionHash:";

	private static readonly IntPtr selSetDestinationEntityVersionHash_Handle = Selector.GetHandle("setDestinationEntityVersionHash:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntityMigrationPolicyClassName_ = "setEntityMigrationPolicyClassName:";

	private static readonly IntPtr selSetEntityMigrationPolicyClassName_Handle = Selector.GetHandle("setEntityMigrationPolicyClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMappingType_ = "setMappingType:";

	private static readonly IntPtr selSetMappingType_Handle = Selector.GetHandle("setMappingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRelationshipMappings_ = "setRelationshipMappings:";

	private static readonly IntPtr selSetRelationshipMappings_Handle = Selector.GetHandle("setRelationshipMappings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceEntityName_ = "setSourceEntityName:";

	private static readonly IntPtr selSetSourceEntityName_Handle = Selector.GetHandle("setSourceEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceEntityVersionHash_ = "setSourceEntityVersionHash:";

	private static readonly IntPtr selSetSourceEntityVersionHash_Handle = Selector.GetHandle("setSourceEntityVersionHash:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceExpression_ = "setSourceExpression:";

	private static readonly IntPtr selSetSourceExpression_Handle = Selector.GetHandle("setSourceExpression:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInfo_ = "setUserInfo:";

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceEntityName = "sourceEntityName";

	private static readonly IntPtr selSourceEntityNameHandle = Selector.GetHandle("sourceEntityName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceEntityVersionHash = "sourceEntityVersionHash";

	private static readonly IntPtr selSourceEntityVersionHashHandle = Selector.GetHandle("sourceEntityVersionHash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceExpression = "sourceExpression";

	private static readonly IntPtr selSourceExpressionHandle = Selector.GetHandle("sourceExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSEntityMapping");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyMapping[] AttributeMappings
	{
		[Export("attributeMappings", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeMappingsHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeMappingsHandle));
		}
		[Export("setAttributeMappings:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? DestinationEntityName
	{
		[Export("destinationEntityName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityNameHandle));
		}
		[Export("setDestinationEntityName:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationEntityName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationEntityName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? DestinationEntityVersionHash
	{
		[Export("destinationEntityVersionHash", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityVersionHashHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityVersionHashHandle));
		}
		[Export("setDestinationEntityVersionHash:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationEntityVersionHash_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationEntityVersionHash_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? EntityMigrationPolicyClassName
	{
		[Export("entityMigrationPolicyClassName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMigrationPolicyClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMigrationPolicyClassNameHandle));
		}
		[Export("setEntityMigrationPolicyClassName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntityMigrationPolicyClassName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntityMigrationPolicyClassName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityMappingType MappingType
	{
		[Export("mappingType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSEntityMappingType)Messaging.UInt64_objc_msgSend(base.Handle, selMappingTypeHandle);
			}
			return (NSEntityMappingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMappingTypeHandle);
		}
		[Export("setMappingType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMappingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMappingType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
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
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
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
	public virtual NSPropertyMapping[] RelationshipMappings
	{
		[Export("relationshipMappings", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipMappingsHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipMappingsHandle));
		}
		[Export("setRelationshipMappings:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRelationshipMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRelationshipMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SourceEntityName
	{
		[Export("sourceEntityName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceEntityNameHandle));
		}
		[Export("setSourceEntityName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceEntityName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceEntityName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? SourceEntityVersionHash
	{
		[Export("sourceEntityVersionHash", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceEntityVersionHashHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceEntityVersionHashHandle));
		}
		[Export("setSourceEntityVersionHash:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceEntityVersionHash_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceEntityVersionHash_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression? SourceExpression
	{
		[Export("sourceExpression", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceExpressionHandle));
		}
		[Export("setSourceExpression:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceExpression_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceExpression_Handle, value?.Handle ?? IntPtr.Zero);
			}
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityMapping()
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
	protected NSEntityMapping(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSEntityMapping(IntPtr handle)
		: base(handle)
	{
	}
}
