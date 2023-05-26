using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityMapping", true)]
public class NSEntityMapping : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selMappingTypeHandle = Selector.GetHandle("mappingType");

	private static readonly IntPtr selSetMappingType_Handle = Selector.GetHandle("setMappingType:");

	private static readonly IntPtr selSourceEntityNameHandle = Selector.GetHandle("sourceEntityName");

	private static readonly IntPtr selSetSourceEntityName_Handle = Selector.GetHandle("setSourceEntityName:");

	private static readonly IntPtr selSourceEntityVersionHashHandle = Selector.GetHandle("sourceEntityVersionHash");

	private static readonly IntPtr selSetSourceEntityVersionHash_Handle = Selector.GetHandle("setSourceEntityVersionHash:");

	private static readonly IntPtr selDestinationEntityNameHandle = Selector.GetHandle("destinationEntityName");

	private static readonly IntPtr selSetDestinationEntityName_Handle = Selector.GetHandle("setDestinationEntityName:");

	private static readonly IntPtr selDestinationEntityVersionHashHandle = Selector.GetHandle("destinationEntityVersionHash");

	private static readonly IntPtr selSetDestinationEntityVersionHash_Handle = Selector.GetHandle("setDestinationEntityVersionHash:");

	private static readonly IntPtr selAttributeMappingsHandle = Selector.GetHandle("attributeMappings");

	private static readonly IntPtr selSetAttributeMappings_Handle = Selector.GetHandle("setAttributeMappings:");

	private static readonly IntPtr selRelationshipMappingsHandle = Selector.GetHandle("relationshipMappings");

	private static readonly IntPtr selSetRelationshipMappings_Handle = Selector.GetHandle("setRelationshipMappings:");

	private static readonly IntPtr selSourceExpressionHandle = Selector.GetHandle("sourceExpression");

	private static readonly IntPtr selSetSourceExpression_Handle = Selector.GetHandle("setSourceExpression:");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	private static readonly IntPtr selEntityMigrationPolicyClassNameHandle = Selector.GetHandle("entityMigrationPolicyClassName");

	private static readonly IntPtr selSetEntityMigrationPolicyClassName_Handle = Selector.GetHandle("setEntityMigrationPolicyClassName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSEntityMapping");

	private object __mt_SourceEntityVersionHash_var;

	private object __mt_DestinationEntityVersionHash_var;

	private object __mt_AttributeMappings_var;

	private object __mt_RelationshipMappings_var;

	private object __mt_SourceExpression_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual NSEntityMappingType MappingType
	{
		[Export("mappingType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSEntityMappingType)Messaging.UInt64_objc_msgSend(base.Handle, selMappingTypeHandle);
			}
			return (NSEntityMappingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMappingTypeHandle);
		}
		[Export("setMappingType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMappingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMappingType_Handle, (ulong)value);
			}
		}
	}

	public virtual string SourceEntityName
	{
		[Export("sourceEntityName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceEntityNameHandle));
		}
		[Export("setSourceEntityName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual NSData SourceEntityVersionHash
	{
		[Export("sourceEntityVersionHash")]
		get
		{
			return (NSData)(__mt_SourceEntityVersionHash_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceEntityVersionHashHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceEntityVersionHashHandle)))));
		}
		[Export("setSourceEntityVersionHash:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceEntityVersionHash_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceEntityVersionHash_Handle, value.Handle);
			}
			__mt_SourceEntityVersionHash_var = value;
		}
	}

	public virtual string DestinationEntityName
	{
		[Export("destinationEntityName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityNameHandle));
		}
		[Export("setDestinationEntityName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual NSData DestinationEntityVersionHash
	{
		[Export("destinationEntityVersionHash")]
		get
		{
			return (NSData)(__mt_DestinationEntityVersionHash_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationEntityVersionHashHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationEntityVersionHashHandle)))));
		}
		[Export("setDestinationEntityVersionHash:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationEntityVersionHash_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationEntityVersionHash_Handle, value.Handle);
			}
			__mt_DestinationEntityVersionHash_var = value;
		}
	}

	public virtual NSPropertyMapping[] AttributeMappings
	{
		[Export("attributeMappings")]
		get
		{
			return (NSPropertyMapping[])(__mt_AttributeMappings_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeMappingsHandle)) : NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeMappingsHandle))));
		}
		[Export("setAttributeMappings:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_AttributeMappings_var = value;
		}
	}

	public virtual NSPropertyMapping[] RelationshipMappings
	{
		[Export("relationshipMappings")]
		get
		{
			return (NSPropertyMapping[])(__mt_RelationshipMappings_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipMappingsHandle)) : NSArray.ArrayFromHandle<NSPropertyMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipMappingsHandle))));
		}
		[Export("setRelationshipMappings:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRelationshipMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRelationshipMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_RelationshipMappings_var = value;
		}
	}

	public virtual NSExpression SourceExpression
	{
		[Export("sourceExpression")]
		get
		{
			return (NSExpression)(__mt_SourceExpression_var = ((!IsDirectBinding) ? ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceExpressionHandle))) : ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceExpressionHandle)))));
		}
		[Export("setSourceExpression:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceExpression_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceExpression_Handle, value.Handle);
			}
			__mt_SourceExpression_var = value;
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

	public virtual string EntityMigrationPolicyClassName
	{
		[Export("entityMigrationPolicyClassName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMigrationPolicyClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMigrationPolicyClassNameHandle));
		}
		[Export("setEntityMigrationPolicyClassName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityMapping()
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
	public NSEntityMapping(NSCoder coder)
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
	public NSEntityMapping(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEntityMapping(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SourceEntityVersionHash_var = null;
			__mt_DestinationEntityVersionHash_var = null;
			__mt_AttributeMappings_var = null;
			__mt_RelationshipMappings_var = null;
			__mt_SourceExpression_var = null;
			__mt_UserInfo_var = null;
		}
	}
}
