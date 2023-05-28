using System;
using System.ComponentModel;
using EventKit;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INDateComponentsRange", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INDateComponentsRange : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEKRecurrenceRule = "EKRecurrenceRule";

	private static readonly IntPtr selEKRecurrenceRuleHandle = Selector.GetHandle("EKRecurrenceRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDateComponents = "endDateComponents";

	private static readonly IntPtr selEndDateComponentsHandle = Selector.GetHandle("endDateComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEKRecurrenceRule_ = "initWithEKRecurrenceRule:";

	private static readonly IntPtr selInitWithEKRecurrenceRule_Handle = Selector.GetHandle("initWithEKRecurrenceRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartDateComponents_EndDateComponents_ = "initWithStartDateComponents:endDateComponents:";

	private static readonly IntPtr selInitWithStartDateComponents_EndDateComponents_Handle = Selector.GetHandle("initWithStartDateComponents:endDateComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartDateComponents_EndDateComponents_RecurrenceRule_ = "initWithStartDateComponents:endDateComponents:recurrenceRule:";

	private static readonly IntPtr selInitWithStartDateComponents_EndDateComponents_RecurrenceRule_Handle = Selector.GetHandle("initWithStartDateComponents:endDateComponents:recurrenceRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrenceRule = "recurrenceRule";

	private static readonly IntPtr selRecurrenceRuleHandle = Selector.GetHandle("recurrenceRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDateComponents = "startDateComponents";

	private static readonly IntPtr selStartDateComponentsHandle = Selector.GetHandle("startDateComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INDateComponentsRange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual EKRecurrenceRule? EKRecurrenceRule
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("EKRecurrenceRule")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKRecurrenceRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selEKRecurrenceRuleHandle));
			}
			return Runtime.GetNSObject<EKRecurrenceRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEKRecurrenceRuleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents? EndDateComponents
	{
		[Export("endDateComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndDateComponentsHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndDateComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INRecurrenceRule? RecurrenceRule
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("recurrenceRule", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INRecurrenceRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecurrenceRuleHandle));
			}
			return Runtime.GetNSObject<INRecurrenceRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecurrenceRuleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents? StartDateComponents
	{
		[Export("startDateComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartDateComponentsHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartDateComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INDateComponentsRange(NSCoder coder)
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
	protected INDateComponentsRange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INDateComponentsRange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStartDateComponents:endDateComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INDateComponentsRange(NSDateComponents? startDateComponents, NSDateComponents? endDateComponents)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStartDateComponents_EndDateComponents_Handle, startDateComponents?.Handle ?? IntPtr.Zero, endDateComponents?.Handle ?? IntPtr.Zero), "initWithStartDateComponents:endDateComponents:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStartDateComponents_EndDateComponents_Handle, startDateComponents?.Handle ?? IntPtr.Zero, endDateComponents?.Handle ?? IntPtr.Zero), "initWithStartDateComponents:endDateComponents:");
		}
	}

	[Export("initWithEKRecurrenceRule:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INDateComponentsRange(EKRecurrenceRule recurrenceRule)
		: base(NSObjectFlag.Empty)
	{
		if (recurrenceRule == null)
		{
			throw new ArgumentNullException("recurrenceRule");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEKRecurrenceRule_Handle, recurrenceRule.Handle), "initWithEKRecurrenceRule:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEKRecurrenceRule_Handle, recurrenceRule.Handle), "initWithEKRecurrenceRule:");
		}
	}

	[Export("initWithStartDateComponents:endDateComponents:recurrenceRule:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INDateComponentsRange(NSDateComponents? startDateComponents, NSDateComponents? endDateComponents, INRecurrenceRule? recurrenceRule)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithStartDateComponents_EndDateComponents_RecurrenceRule_Handle, startDateComponents?.Handle ?? IntPtr.Zero, endDateComponents?.Handle ?? IntPtr.Zero, recurrenceRule?.Handle ?? IntPtr.Zero), "initWithStartDateComponents:endDateComponents:recurrenceRule:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithStartDateComponents_EndDateComponents_RecurrenceRule_Handle, startDateComponents?.Handle ?? IntPtr.Zero, endDateComponents?.Handle ?? IntPtr.Zero, recurrenceRule?.Handle ?? IntPtr.Zero), "initWithStartDateComponents:endDateComponents:recurrenceRule:");
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
}
