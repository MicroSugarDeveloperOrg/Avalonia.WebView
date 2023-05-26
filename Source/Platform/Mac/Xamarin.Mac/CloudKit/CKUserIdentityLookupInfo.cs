using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKUserIdentityLookupInfo", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKUserIdentityLookupInfo : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmailAddress = "emailAddress";

	private static readonly IntPtr selEmailAddressHandle = Selector.GetHandle("emailAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEmailAddress_ = "initWithEmailAddress:";

	private static readonly IntPtr selInitWithEmailAddress_Handle = Selector.GetHandle("initWithEmailAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPhoneNumber_ = "initWithPhoneNumber:";

	private static readonly IntPtr selInitWithPhoneNumber_Handle = Selector.GetHandle("initWithPhoneNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUserRecordID_ = "initWithUserRecordID:";

	private static readonly IntPtr selInitWithUserRecordID_Handle = Selector.GetHandle("initWithUserRecordID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookupInfosWithEmails_ = "lookupInfosWithEmails:";

	private static readonly IntPtr selLookupInfosWithEmails_Handle = Selector.GetHandle("lookupInfosWithEmails:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookupInfosWithPhoneNumbers_ = "lookupInfosWithPhoneNumbers:";

	private static readonly IntPtr selLookupInfosWithPhoneNumbers_Handle = Selector.GetHandle("lookupInfosWithPhoneNumbers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookupInfosWithRecordIDs_ = "lookupInfosWithRecordIDs:";

	private static readonly IntPtr selLookupInfosWithRecordIDs_Handle = Selector.GetHandle("lookupInfosWithRecordIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneNumber = "phoneNumber";

	private static readonly IntPtr selPhoneNumberHandle = Selector.GetHandle("phoneNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserRecordID = "userRecordID";

	private static readonly IntPtr selUserRecordIDHandle = Selector.GetHandle("userRecordID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKUserIdentityLookupInfo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? EmailAddress
	{
		[Export("emailAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmailAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmailAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PhoneNumber
	{
		[Export("phoneNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneNumberHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneNumberHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordID? UserRecordID
	{
		[Export("userRecordID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKRecordID>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserRecordIDHandle));
			}
			return Runtime.GetNSObject<CKRecordID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserRecordIDHandle));
		}
	}

	private CKUserIdentityLookupInfo(string id, int type)
	{
		InitializeHandle((type == 0) ? _FromEmail(id) : _FromPhoneNumber(id));
	}

	public static CKUserIdentityLookupInfo FromEmail(string email)
	{
		if (string.IsNullOrEmpty(email))
		{
			throw new ArgumentNullException("email");
		}
		return new CKUserIdentityLookupInfo(email, 0);
	}

	public static CKUserIdentityLookupInfo FromPhoneNumber(string phoneNumber)
	{
		if (string.IsNullOrEmpty(phoneNumber))
		{
			throw new ArgumentNullException("phoneNumber");
		}
		return new CKUserIdentityLookupInfo(phoneNumber, 1);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CKUserIdentityLookupInfo(NSCoder coder)
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
	protected CKUserIdentityLookupInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKUserIdentityLookupInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUserRecordID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKUserIdentityLookupInfo(CKRecordID userRecordID)
		: base(NSObjectFlag.Empty)
	{
		if (userRecordID == null)
		{
			throw new ArgumentNullException("userRecordID");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUserRecordID_Handle, userRecordID.Handle), "initWithUserRecordID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUserRecordID_Handle, userRecordID.Handle), "initWithUserRecordID:");
		}
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

	[Export("lookupInfosWithRecordIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKUserIdentityLookupInfo[] GetLookupInfos(CKRecordID[] recordIDs)
	{
		if (recordIDs == null)
		{
			throw new ArgumentNullException("recordIDs");
		}
		NSArray nSArray = NSArray.FromNSObjects(recordIDs);
		CKUserIdentityLookupInfo[] result = NSArray.ArrayFromHandle<CKUserIdentityLookupInfo>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLookupInfosWithRecordIDs_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("lookupInfosWithEmails:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKUserIdentityLookupInfo[] GetLookupInfosWithEmails(string[] emails)
	{
		if (emails == null)
		{
			throw new ArgumentNullException("emails");
		}
		NSArray nSArray = NSArray.FromStrings(emails);
		CKUserIdentityLookupInfo[] result = NSArray.ArrayFromHandle<CKUserIdentityLookupInfo>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLookupInfosWithEmails_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("lookupInfosWithPhoneNumbers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKUserIdentityLookupInfo[] GetLookupInfosWithPhoneNumbers(string[] phoneNumbers)
	{
		if (phoneNumbers == null)
		{
			throw new ArgumentNullException("phoneNumbers");
		}
		NSArray nSArray = NSArray.FromStrings(phoneNumbers);
		CKUserIdentityLookupInfo[] result = NSArray.ArrayFromHandle<CKUserIdentityLookupInfo>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLookupInfosWithPhoneNumbers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("initWithEmailAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _FromEmail(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		IntPtr arg = NSString.CreateNative(emailAddress);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEmailAddress_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEmailAddress_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithPhoneNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _FromPhoneNumber(string phoneNumber)
	{
		if (phoneNumber == null)
		{
			throw new ArgumentNullException("phoneNumber");
		}
		IntPtr arg = NSString.CreateNative(phoneNumber);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPhoneNumber_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPhoneNumber_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}
