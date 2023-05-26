using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKQuerySubscription", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKQuerySubscription : CKSubscription, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
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
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuerySubscriptionOptions = "querySubscriptionOptions";

	private static readonly IntPtr selQuerySubscriptionOptionsHandle = Selector.GetHandle("querySubscriptionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordType = "recordType";

	private static readonly IntPtr selRecordTypeHandle = Selector.GetHandle("recordType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoneID_ = "setZoneID:";

	private static readonly IntPtr selSetZoneID_Handle = Selector.GetHandle("setZoneID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoneID = "zoneID";

	private static readonly IntPtr selZoneIDHandle = Selector.GetHandle("zoneID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKQuerySubscription");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSPredicate Predicate
	{
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
	public new virtual string RecordType
	{
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
	public new virtual CKQuerySubscriptionOptions SubscriptionOptions
	{
		[Export("querySubscriptionOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKQuerySubscriptionOptions)Messaging.UInt64_objc_msgSend(base.Handle, selQuerySubscriptionOptionsHandle);
			}
			return (CKQuerySubscriptionOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selQuerySubscriptionOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CKRecordZoneID? ZoneID
	{
		[Export("zoneID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSend(base.Handle, selZoneIDHandle));
			}
			return Runtime.GetNSObject<CKRecordZoneID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selZoneIDHandle));
		}
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
	public CKQuerySubscription(NSCoder coder)
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
	protected CKQuerySubscription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKQuerySubscription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecordType:predicate:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKQuerySubscription(string recordType, NSPredicate predicate, CKQuerySubscriptionOptions querySubscriptionOptions)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithRecordType_Predicate_Options_Handle, arg, predicate.Handle, (ulong)querySubscriptionOptions), "initWithRecordType:predicate:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithRecordType_Predicate_Options_Handle, arg, predicate.Handle, (ulong)querySubscriptionOptions), "initWithRecordType:predicate:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithRecordType:predicate:subscriptionID:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKQuerySubscription(string recordType, NSPredicate predicate, string subscriptionID, CKQuerySubscriptionOptions querySubscriptionOptions)
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
		if (subscriptionID == null)
		{
			throw new ArgumentNullException("subscriptionID");
		}
		IntPtr arg = NSString.CreateNative(recordType);
		IntPtr arg2 = NSString.CreateNative(subscriptionID);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selInitWithRecordType_Predicate_SubscriptionID_Options_Handle, arg, predicate.Handle, arg2, (ulong)querySubscriptionOptions), "initWithRecordType:predicate:subscriptionID:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithRecordType_Predicate_SubscriptionID_Options_Handle, arg, predicate.Handle, arg2, (ulong)querySubscriptionOptions), "initWithRecordType:predicate:subscriptionID:options:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
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
	public new virtual void EncodeTo(NSCoder encoder)
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
