using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKSubscription", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKSubscription : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordType_Predicate_Options_ = "initWithRecordType:predicate:options:";

	private static readonly IntPtr selInitWithRecordType_Predicate_Options_Handle = Selector.GetHandle("initWithRecordType:predicate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecordType_Predicate_SubscriptionID_Options_ = "initWithRecordType:predicate:subscriptionID:options:";

	private static readonly IntPtr selInitWithRecordType_Predicate_SubscriptionID_Options_Handle = Selector.GetHandle("initWithRecordType:predicate:subscriptionID:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithZoneID_Options_ = "initWithZoneID:options:";

	private static readonly IntPtr selInitWithZoneID_Options_Handle = Selector.GetHandle("initWithZoneID:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithZoneID_SubscriptionID_Options_ = "initWithZoneID:subscriptionID:options:";

	private static readonly IntPtr selInitWithZoneID_SubscriptionID_Options_Handle = Selector.GetHandle("initWithZoneID:subscriptionID:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationInfo = "notificationInfo";

	private static readonly IntPtr selNotificationInfoHandle = Selector.GetHandle("notificationInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordType = "recordType";

	private static readonly IntPtr selRecordTypeHandle = Selector.GetHandle("recordType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotificationInfo_ = "setNotificationInfo:";

	private static readonly IntPtr selSetNotificationInfo_Handle = Selector.GetHandle("setNotificationInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoneID_ = "setZoneID:";

	private static readonly IntPtr selSetZoneID_Handle = Selector.GetHandle("setZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionID = "subscriptionID";

	private static readonly IntPtr selSubscriptionIDHandle = Selector.GetHandle("subscriptionID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionOptions = "subscriptionOptions";

	private static readonly IntPtr selSubscriptionOptionsHandle = Selector.GetHandle("subscriptionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionType = "subscriptionType";

	private static readonly IntPtr selSubscriptionTypeHandle = Selector.GetHandle("subscriptionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoneID = "zoneID";

	private static readonly IntPtr selZoneIDHandle = Selector.GetHandle("zoneID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKSubscription");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual CKNotificationInfo? NotificationInfo
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("notificationInfo", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKNotificationInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationInfoHandle));
			}
			return Runtime.GetNSObject<CKNotificationInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationInfoHandle));
		}
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("setNotificationInfo:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNotificationInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNotificationInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	public virtual NSPredicate? Predicate
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
		[Export("predicate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	public virtual string? RecordType
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
		[Export("recordType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRecordTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecordTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SubscriptionId
	{
		[Export("subscriptionID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions'.")]
	public virtual CKSubscriptionOptions SubscriptionOptions
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions'.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions'.")]
		[Export("subscriptionOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKSubscriptionOptions)Messaging.UInt64_objc_msgSend(base.Handle, selSubscriptionOptionsHandle);
			}
			return (CKSubscriptionOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSubscriptionOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKSubscriptionType SubscriptionType
	{
		[Export("subscriptionType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKSubscriptionType)Messaging.Int64_objc_msgSend(base.Handle, selSubscriptionTypeHandle);
			}
			return (CKSubscriptionType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSubscriptionTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	public virtual CKRecordZoneID? ZoneID
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
		[Export("zoneID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSend(base.Handle, selZoneIDHandle));
			}
			return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selZoneIDHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
		[Export("setZoneID:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetZoneID_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CKSubscription(NSCoder coder)
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
	protected CKSubscription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKSubscription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordType:predicate:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKSubscription(string recordType, NSPredicate predicate, CKSubscriptionOptions subscriptionOptions)
		: base(NSObjectFlag.Empty)
	{
		if (recordType == null)
		{
			throw new ArgumentNullException("recordType");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		IntPtr arg = NSString.CreateNative(recordType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithRecordType_Predicate_Options_Handle, arg, predicate.Handle, (ulong)subscriptionOptions), "initWithRecordType:predicate:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithRecordType_Predicate_Options_Handle, arg, predicate.Handle, (ulong)subscriptionOptions), "initWithRecordType:predicate:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithRecordType:predicate:subscriptionID:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscription'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKSubscription(string recordType, NSPredicate predicate, string subscriptionId, CKSubscriptionOptions subscriptionOptions)
		: base(NSObjectFlag.Empty)
	{
		if (recordType == null)
		{
			throw new ArgumentNullException("recordType");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (subscriptionId == null)
		{
			throw new ArgumentNullException("subscriptionId");
		}
		IntPtr arg = NSString.CreateNative(recordType);
		IntPtr arg2 = NSString.CreateNative(subscriptionId);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selInitWithRecordType_Predicate_SubscriptionID_Options_Handle, arg, predicate.Handle, arg2, (ulong)subscriptionOptions), "initWithRecordType:predicate:subscriptionID:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithRecordType_Predicate_SubscriptionID_Options_Handle, arg, predicate.Handle, arg2, (ulong)subscriptionOptions), "initWithRecordType:predicate:subscriptionID:options:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithZoneID:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKSubscription(CKRecordZoneID zoneId, CKSubscriptionOptions subscriptionOptions)
		: base(NSObjectFlag.Empty)
	{
		if (zoneId == null)
		{
			throw new ArgumentNullException("zoneId");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithZoneID_Options_Handle, zoneId.Handle, (ulong)subscriptionOptions), "initWithZoneID:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithZoneID_Options_Handle, zoneId.Handle, (ulong)subscriptionOptions), "initWithZoneID:options:");
		}
	}

	[Export("initWithZoneID:subscriptionID:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKRecordZoneSubscription'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKSubscription(CKRecordZoneID zoneId, string subscriptionId, CKSubscriptionOptions subscriptionOptions)
		: base(NSObjectFlag.Empty)
	{
		if (zoneId == null)
		{
			throw new ArgumentNullException("zoneId");
		}
		if (subscriptionId == null)
		{
			throw new ArgumentNullException("subscriptionId");
		}
		IntPtr arg = NSString.CreateNative(subscriptionId);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithZoneID_SubscriptionID_Options_Handle, zoneId.Handle, arg, (ulong)subscriptionOptions), "initWithZoneID:subscriptionID:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithZoneID_SubscriptionID_Options_Handle, zoneId.Handle, arg, (ulong)subscriptionOptions), "initWithZoneID:subscriptionID:options:");
		}
		NSString.ReleaseNative(arg);
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
}
