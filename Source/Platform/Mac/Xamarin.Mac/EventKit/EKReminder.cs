using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace EventKit;

[Register("EKReminder", true)]
public class EKReminder : EKCalendarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionDate = "completionDate";

	private static readonly IntPtr selCompletionDateHandle = Selector.GetHandle("completionDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDueDateComponents = "dueDateComponents";

	private static readonly IntPtr selDueDateComponentsHandle = Selector.GetHandle("dueDateComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompleted = "isCompleted";

	private static readonly IntPtr selIsCompletedHandle = Selector.GetHandle("isCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPriority = "priority";

	private static readonly IntPtr selPriorityHandle = Selector.GetHandle("priority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReminderWithEventStore_ = "reminderWithEventStore:";

	private static readonly IntPtr selReminderWithEventStore_Handle = Selector.GetHandle("reminderWithEventStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompleted_ = "setCompleted:";

	private static readonly IntPtr selSetCompleted_Handle = Selector.GetHandle("setCompleted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletionDate_ = "setCompletionDate:";

	private static readonly IntPtr selSetCompletionDate_Handle = Selector.GetHandle("setCompletionDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDueDateComponents_ = "setDueDateComponents:";

	private static readonly IntPtr selSetDueDateComponents_Handle = Selector.GetHandle("setDueDateComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPriority_ = "setPriority:";

	private static readonly IntPtr selSetPriority_Handle = Selector.GetHandle("setPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartDateComponents_ = "setStartDateComponents:";

	private static readonly IntPtr selSetStartDateComponents_Handle = Selector.GetHandle("setStartDateComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDateComponents = "startDateComponents";

	private static readonly IntPtr selStartDateComponentsHandle = Selector.GetHandle("startDateComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKReminder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Completed
	{
		[Export("isCompleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompletedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompletedHandle);
		}
		[Export("setCompleted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCompleted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCompleted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? CompletionDate
	{
		[Export("completionDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompletionDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletionDateHandle));
		}
		[Export("setCompletionDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompletionDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompletionDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents? DueDateComponents
	{
		[Export("dueDateComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selDueDateComponentsHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDueDateComponentsHandle));
		}
		[Export("setDueDateComponents:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDueDateComponents_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDueDateComponents_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual nint Priority
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("priority")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPriorityHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPriorityHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setPriority:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPriority_Handle, value);
			}
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
		[Export("setStartDateComponents:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartDateComponents_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartDateComponents_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Obsolete("Use 'Create' instead.")]
	public EKReminder()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKReminder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKReminder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reminderWithEventStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKReminder Create(EKEventStore eventStore)
	{
		if (eventStore == null)
		{
			throw new ArgumentNullException("eventStore");
		}
		return Runtime.GetNSObject<EKReminder>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReminderWithEventStore_Handle, eventStore.Handle));
	}
}
