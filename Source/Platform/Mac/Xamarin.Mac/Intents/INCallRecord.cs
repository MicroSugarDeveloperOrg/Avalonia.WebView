using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INCallRecord", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class INCallRecord : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallCapability = "callCapability";

	private static readonly IntPtr selCallCapabilityHandle = Selector.GetHandle("callCapability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallDuration = "callDuration";

	private static readonly IntPtr selCallDurationHandle = Selector.GetHandle("callDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallRecordType = "callRecordType";

	private static readonly IntPtr selCallRecordTypeHandle = Selector.GetHandle("callRecordType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCaller = "caller";

	private static readonly IntPtr selCallerHandle = Selector.GetHandle("caller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateCreated = "dateCreated";

	private static readonly IntPtr selDateCreatedHandle = Selector.GetHandle("dateCreated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_ = "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:";

	private static readonly IntPtr selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_Handle = Selector.GetHandle("initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_NumberOfCalls_ = "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:numberOfCalls:";

	private static readonly IntPtr selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_NumberOfCalls_Handle = Selector.GetHandle("initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:numberOfCalls:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnseen = "unseen";

	private static readonly IntPtr selUnseenHandle = Selector.GetHandle("unseen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INCallRecord");

	public double? CallDuration => WeakCallDuration?.DoubleValue;

	public bool? Unseen => WeakUnseen?.BoolValue;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INCallCapability CallCapability
	{
		[Export("callCapability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallCapability)Messaging.Int64_objc_msgSend(base.Handle, selCallCapabilityHandle);
			}
			return (INCallCapability)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCallCapabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INCallRecordType CallRecordType
	{
		[Export("callRecordType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallRecordType)Messaging.Int64_objc_msgSend(base.Handle, selCallRecordTypeHandle);
			}
			return (INCallRecordType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCallRecordTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson? Caller
	{
		[Export("caller", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selCallerHandle));
			}
			return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCallerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? DateCreated
	{
		[Export("dateCreated", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateCreatedHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateCreatedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSNumber? WeakCallDuration
	{
		[Export("callDuration", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selCallDurationHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCallDurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSNumber? WeakUnseen
	{
		[Export("unseen", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selUnseenHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnseenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INCallRecord(NSCoder coder)
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
	protected INCallRecord(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INCallRecord(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:numberOfCalls:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INCallRecord(string identifier, NSDate? dateCreated, INPerson? caller, INCallRecordType callRecordType, INCallCapability callCapability, [BindAs(typeof(double?), OriginalType = typeof(NSNumber))] double? callDuration, [BindAs(typeof(bool?), OriginalType = typeof(NSNumber))] bool? unseen, [BindAs(typeof(int?), OriginalType = typeof(NSNumber))] int? numberOfCalls)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSNumber nSNumber = ((!callDuration.HasValue) ? null : new NSNumber(callDuration.Value));
		NSNumber nSNumber2 = ((!unseen.HasValue) ? null : new NSNumber(unseen.Value));
		NSNumber nSNumber3 = ((!numberOfCalls.HasValue) ? null : new NSNumber(numberOfCalls.Value));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_NumberOfCalls_Handle, arg, dateCreated?.Handle ?? IntPtr.Zero, caller?.Handle ?? IntPtr.Zero, (long)callRecordType, (long)callCapability, nSNumber?.Handle ?? IntPtr.Zero, nSNumber2?.Handle ?? IntPtr.Zero, nSNumber3?.Handle ?? IntPtr.Zero), "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:numberOfCalls:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_NumberOfCalls_Handle, arg, dateCreated?.Handle ?? IntPtr.Zero, caller?.Handle ?? IntPtr.Zero, (long)callRecordType, (long)callCapability, nSNumber?.Handle ?? IntPtr.Zero, nSNumber2?.Handle ?? IntPtr.Zero, nSNumber3?.Handle ?? IntPtr.Zero), "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:numberOfCalls:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INCallRecord(string identifier, NSDate? dateCreated, INPerson? caller, INCallRecordType callRecordType, INCallCapability callCapability, NSNumber? callDuration, NSNumber? unseen)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64_Int64_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_Handle, arg, dateCreated?.Handle ?? IntPtr.Zero, caller?.Handle ?? IntPtr.Zero, (long)callRecordType, (long)callCapability, callDuration?.Handle ?? IntPtr.Zero, unseen?.Handle ?? IntPtr.Zero), "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64_Int64_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_DateCreated_Caller_CallRecordType_CallCapability_CallDuration_Unseen_Handle, arg, dateCreated?.Handle ?? IntPtr.Zero, caller?.Handle ?? IntPtr.Zero, (long)callRecordType, (long)callCapability, callDuration?.Handle ?? IntPtr.Zero, unseen?.Handle ?? IntPtr.Zero), "initWithIdentifier:dateCreated:caller:callRecordType:callCapability:callDuration:unseen:");
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
