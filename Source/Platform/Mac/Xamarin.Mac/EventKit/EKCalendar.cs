using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKCalendar", true)]
public class EKCalendar : EKObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGColor = "CGColor";

	private static readonly IntPtr selCGColorHandle = Selector.GetHandle("CGColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedEntityTypes = "allowedEntityTypes";

	private static readonly IntPtr selAllowedEntityTypesHandle = Selector.GetHandle("allowedEntityTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsContentModifications = "allowsContentModifications";

	private static readonly IntPtr selAllowsContentModificationsHandle = Selector.GetHandle("allowsContentModifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarForEntityType_EventStore_ = "calendarForEntityType:eventStore:";

	private static readonly IntPtr selCalendarForEntityType_EventStore_Handle = Selector.GetHandle("calendarForEntityType:eventStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarIdentifier = "calendarIdentifier";

	private static readonly IntPtr selCalendarIdentifierHandle = Selector.GetHandle("calendarIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsImmutable = "isImmutable";

	private static readonly IntPtr selIsImmutableHandle = Selector.GetHandle("isImmutable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSubscribed = "isSubscribed";

	private static readonly IntPtr selIsSubscribedHandle = Selector.GetHandle("isSubscribed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCGColor_ = "setCGColor:";

	private static readonly IntPtr selSetCGColor_Handle = Selector.GetHandle("setCGColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSource_ = "setSource:";

	private static readonly IntPtr selSetSource_Handle = Selector.GetHandle("setSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedEventAvailabilities = "supportedEventAvailabilities";

	private static readonly IntPtr selSupportedEventAvailabilitiesHandle = Selector.GetHandle("supportedEventAvailabilities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKCalendar");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKEntityMask AllowedEntityTypes
	{
		[Export("allowedEntityTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKEntityMask)Messaging.UInt64_objc_msgSend(base.Handle, selAllowedEntityTypesHandle);
			}
			return (EKEntityMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAllowedEntityTypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsContentModifications
	{
		[Export("allowsContentModifications")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsContentModificationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsContentModificationsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual CGColor CGColor
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("CGColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setCGColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCGColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCGColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CalendarIdentifier
	{
		[Export("calendarIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor Color
	{
		[Export("color", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Immutable
	{
		[Export("isImmutable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsImmutableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsImmutableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKSource Source
	{
		[Export("source", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceHandle));
			}
			return Runtime.GetNSObject<EKSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceHandle));
		}
		[Export("setSource:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSource_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSource_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Subscribed
	{
		[Export("isSubscribed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSubscribedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSubscribedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendarEventAvailability SupportedEventAvailabilities
	{
		[Export("supportedEventAvailabilities")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKCalendarEventAvailability)Messaging.UInt64_objc_msgSend(base.Handle, selSupportedEventAvailabilitiesHandle);
			}
			return (EKCalendarEventAvailability)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSupportedEventAvailabilitiesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKCalendarType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKCalendarType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (EKCalendarType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKCalendar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKCalendar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("calendarForEntityType:eventStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKCalendar Create(EKEntityType entityType, EKEventStore eventStore)
	{
		if (eventStore == null)
		{
			throw new ArgumentNullException("eventStore");
		}
		return Runtime.GetNSObject<EKCalendar>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(class_ptr, selCalendarForEntityType_EventStore_Handle, (ulong)entityType, eventStore.Handle));
	}
}
