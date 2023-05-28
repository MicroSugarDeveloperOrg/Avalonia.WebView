using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSearchCallHistoryIntent", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSearchCallHistoryIntent : INIntent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallCapabilities = "callCapabilities";

	private static readonly IntPtr selCallCapabilitiesHandle = Selector.GetHandle("callCapabilities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallType = "callType";

	private static readonly IntPtr selCallTypeHandle = Selector.GetHandle("callType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallTypes = "callTypes";

	private static readonly IntPtr selCallTypesHandle = Selector.GetHandle("callTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateCreated = "dateCreated";

	private static readonly IntPtr selDateCreatedHandle = Selector.GetHandle("dateCreated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCallType_DateCreated_Recipient_CallCapabilities_ = "initWithCallType:dateCreated:recipient:callCapabilities:";

	private static readonly IntPtr selInitWithCallType_DateCreated_Recipient_CallCapabilities_Handle = Selector.GetHandle("initWithCallType:dateCreated:recipient:callCapabilities:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDateCreated_Recipient_CallCapabilities_CallTypes_Unseen_ = "initWithDateCreated:recipient:callCapabilities:callTypes:unseen:";

	private static readonly IntPtr selInitWithDateCreated_Recipient_CallCapabilities_CallTypes_Unseen_Handle = Selector.GetHandle("initWithDateCreated:recipient:callCapabilities:callTypes:unseen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipient = "recipient";

	private static readonly IntPtr selRecipientHandle = Selector.GetHandle("recipient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnseen = "unseen";

	private static readonly IntPtr selUnseenHandle = Selector.GetHandle("unseen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSearchCallHistoryIntent");

	public bool? Unseen => WeakUnseen?.BoolValue;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INCallCapabilityOptions CallCapabilities
	{
		[Export("callCapabilities", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallCapabilityOptions)Messaging.UInt64_objc_msgSend(base.Handle, selCallCapabilitiesHandle);
			}
			return (INCallCapabilityOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCallCapabilitiesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
	public virtual INCallRecordType CallType
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CallTypes' instead.")]
		[Export("callType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallRecordType)Messaging.Int64_objc_msgSend(base.Handle, selCallTypeHandle);
			}
			return (INCallRecordType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCallTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INCallRecordTypeOptions CallTypes
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("callTypes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallRecordTypeOptions)Messaging.UInt64_objc_msgSend(base.Handle, selCallTypesHandle);
			}
			return (INCallRecordTypeOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCallTypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INDateComponentsRange? DateCreated
	{
		[Export("dateCreated", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INDateComponentsRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateCreatedHandle));
			}
			return Runtime.GetNSObject<INDateComponentsRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateCreatedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson? Recipient
	{
		[Export("recipient", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecipientHandle));
			}
			return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecipientHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	protected virtual NSNumber? WeakUnseen
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public INSearchCallHistoryIntent()
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
	public INSearchCallHistoryIntent(NSCoder coder)
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
	protected INSearchCallHistoryIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSearchCallHistoryIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDateCreated:recipient:callCapabilities:callTypes:unseen:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchCallHistoryIntent(INDateComponentsRange? dateCreated, INPerson? recipient, INCallCapabilityOptions callCapabilities, INCallRecordTypeOptions callTypes, NSNumber? unseen)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_IntPtr(base.Handle, selInitWithDateCreated_Recipient_CallCapabilities_CallTypes_Unseen_Handle, dateCreated?.Handle ?? IntPtr.Zero, recipient?.Handle ?? IntPtr.Zero, (ulong)callCapabilities, (ulong)callTypes, unseen?.Handle ?? IntPtr.Zero), "initWithDateCreated:recipient:callCapabilities:callTypes:unseen:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_IntPtr(base.SuperHandle, selInitWithDateCreated_Recipient_CallCapabilities_CallTypes_Unseen_Handle, dateCreated?.Handle ?? IntPtr.Zero, recipient?.Handle ?? IntPtr.Zero, (ulong)callCapabilities, (ulong)callTypes, unseen?.Handle ?? IntPtr.Zero), "initWithDateCreated:recipient:callCapabilities:callTypes:unseen:");
		}
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchCallHistoryIntent(INDateComponentsRange? dateCreated, INPerson? recipient, INCallCapabilityOptions callCapabilities, INCallRecordTypeOptions callTypes, bool unseen)
		: this(dateCreated, recipient, callCapabilities, callTypes, new NSNumber(unseen))
	{
	}

	[Export("initWithCallType:dateCreated:recipient:callCapabilities:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use '.ctor (INDateComponentsRange, INPerson, INCallCapabilityOptions, INCallRecordTypeOptions, NSNumber)' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use '.ctor (INDateComponentsRange, INPerson, INCallCapabilityOptions, INCallRecordTypeOptions, NSNumber)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use '.ctor (INDateComponentsRange, INPerson, INCallCapabilityOptions, INCallRecordTypeOptions, NSNumber)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchCallHistoryIntent(INCallRecordType callType, INDateComponentsRange? dateCreated, INPerson? recipient, INCallCapabilityOptions callCapabilities)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr_IntPtr_UInt64(base.Handle, selInitWithCallType_DateCreated_Recipient_CallCapabilities_Handle, (long)callType, dateCreated?.Handle ?? IntPtr.Zero, recipient?.Handle ?? IntPtr.Zero, (ulong)callCapabilities), "initWithCallType:dateCreated:recipient:callCapabilities:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithCallType_DateCreated_Recipient_CallCapabilities_Handle, (long)callType, dateCreated?.Handle ?? IntPtr.Zero, recipient?.Handle ?? IntPtr.Zero, (ulong)callCapabilities), "initWithCallType:dateCreated:recipient:callCapabilities:");
		}
	}
}
