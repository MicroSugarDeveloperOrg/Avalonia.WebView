using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKSource", true)]
public class EKSource : EKObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarsForEntityType_ = "calendarsForEntityType:";

	private static readonly IntPtr selCalendarsForEntityType_Handle = Selector.GetHandle("calendarsForEntityType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceIdentifier = "sourceIdentifier";

	private static readonly IntPtr selSourceIdentifierHandle = Selector.GetHandle("sourceIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceType = "sourceType";

	private static readonly IntPtr selSourceTypeHandle = Selector.GetHandle("sourceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SourceIdentifier
	{
		[Export("sourceIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKSourceType SourceType
	{
		[Export("sourceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKSourceType)Messaging.Int64_objc_msgSend(base.Handle, selSourceTypeHandle);
			}
			return (EKSourceType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSourceTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public EKSource()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("calendarsForEntityType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetCalendars(EKEntityType entityType)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selCalendarsForEntityType_Handle, (ulong)entityType));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selCalendarsForEntityType_Handle, (ulong)entityType));
	}
}
