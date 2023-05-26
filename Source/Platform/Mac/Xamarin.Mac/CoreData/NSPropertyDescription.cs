using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPropertyDescription", true)]
public class NSPropertyDescription : NSObject
{
	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selIsOptionalHandle = Selector.GetHandle("isOptional");

	private static readonly IntPtr selSetOptional_Handle = Selector.GetHandle("setOptional:");

	private static readonly IntPtr selIsTransientHandle = Selector.GetHandle("isTransient");

	private static readonly IntPtr selSetTransient_Handle = Selector.GetHandle("setTransient:");

	private static readonly IntPtr selValidationPredicatesHandle = Selector.GetHandle("validationPredicates");

	private static readonly IntPtr selValidationWarningsHandle = Selector.GetHandle("validationWarnings");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	private static readonly IntPtr selIsIndexedHandle = Selector.GetHandle("isIndexed");

	private static readonly IntPtr selSetIndexed_Handle = Selector.GetHandle("setIndexed:");

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	private static readonly IntPtr selVersionHashModifierHandle = Selector.GetHandle("versionHashModifier");

	private static readonly IntPtr selSetVersionHashModifier_Handle = Selector.GetHandle("setVersionHashModifier:");

	private static readonly IntPtr selIsIndexedBySpotlightHandle = Selector.GetHandle("isIndexedBySpotlight");

	private static readonly IntPtr selSetIndexedBySpotlight_Handle = Selector.GetHandle("setIndexedBySpotlight:");

	private static readonly IntPtr selIsStoredInExternalRecordHandle = Selector.GetHandle("isStoredInExternalRecord");

	private static readonly IntPtr selSetStoredInExternalRecord_Handle = Selector.GetHandle("setStoredInExternalRecord:");

	private static readonly IntPtr selSetValidationPredicatesWithValidationWarnings_Handle = Selector.GetHandle("setValidationPredicates:withValidationWarnings:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPropertyDescription");

	private object __mt_Entity_var;

	private object __mt_ValidationPredicates_var;

	private object __mt_UserInfo_var;

	private object __mt_VersionHash_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEntityDescription Entity
	{
		[Export("entity")]
		get
		{
			return (NSEntityDescription)(__mt_Entity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle)))));
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

	public virtual bool Optional
	{
		[Export("isOptional")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOptionalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOptionalHandle);
		}
		[Export("setOptional:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOptional_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOptional_Handle, value);
			}
		}
	}

	public virtual bool Transient
	{
		[Export("isTransient")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTransientHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTransientHandle);
		}
		[Export("setTransient:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTransient_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTransient_Handle, value);
			}
		}
	}

	public virtual NSPredicate[] ValidationPredicates
	{
		[Export("validationPredicates")]
		get
		{
			return (NSPredicate[])(__mt_ValidationPredicates_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValidationPredicatesHandle)) : NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selValidationPredicatesHandle))));
		}
	}

	public virtual string[] ValidationWarnings
	{
		[Export("validationWarnings")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValidationWarningsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValidationWarningsHandle));
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

	public virtual bool Indexed
	{
		[Export("isIndexed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIndexedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIndexedHandle);
		}
		[Export("setIndexed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndexed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndexed_Handle, value);
			}
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
	public virtual bool IndexedBySpotlight
	{
		[Export("isIndexedBySpotlight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIndexedBySpotlightHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIndexedBySpotlightHandle);
		}
		[Export("setIndexedBySpotlight:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndexedBySpotlight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndexedBySpotlight_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual bool StoredInExternalRecord
	{
		[Export("isStoredInExternalRecord")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStoredInExternalRecordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStoredInExternalRecordHandle);
		}
		[Export("setStoredInExternalRecord:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStoredInExternalRecord_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStoredInExternalRecord_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPropertyDescription()
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
	public NSPropertyDescription(NSCoder coder)
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
	public NSPropertyDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPropertyDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setValidationPredicates:withValidationWarnings:")]
	public virtual void SetValidationPredicates(NSPredicate[] validationPredicates, string[] validationWarnings)
	{
		if (validationPredicates == null)
		{
			throw new ArgumentNullException("validationPredicates");
		}
		if (validationWarnings == null)
		{
			throw new ArgumentNullException("validationWarnings");
		}
		NSArray nSArray = NSArray.FromNSObjects(validationPredicates);
		NSArray nSArray2 = NSArray.FromStrings(validationWarnings);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValidationPredicatesWithValidationWarnings_Handle, nSArray.Handle, nSArray2.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValidationPredicatesWithValidationWarnings_Handle, nSArray.Handle, nSArray2.Handle);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Entity_var = null;
			__mt_ValidationPredicates_var = null;
			__mt_UserInfo_var = null;
			__mt_VersionHash_var = null;
		}
	}
}
