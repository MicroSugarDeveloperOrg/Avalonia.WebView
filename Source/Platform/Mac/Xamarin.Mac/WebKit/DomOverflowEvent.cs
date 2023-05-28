using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMOverflowEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomOverflowEvent : DomEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalOverflow = "horizontalOverflow";

	private static readonly IntPtr selHorizontalOverflowHandle = Selector.GetHandle("horizontalOverflow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_ = "initOverflowEvent:horizontalOverflow:verticalOverflow:";

	private static readonly IntPtr selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_Handle = Selector.GetHandle("initOverflowEvent:horizontalOverflow:verticalOverflow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrient = "orient";

	private static readonly IntPtr selOrientHandle = Selector.GetHandle("orient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalOverflow = "verticalOverflow";

	private static readonly IntPtr selVerticalOverflowHandle = Selector.GetHandle("verticalOverflow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMOverflowEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasHorizontalOverflow
	{
		[Export("horizontalOverflow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHorizontalOverflowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHorizontalOverflowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasVerticalOverflow
	{
		[Export("verticalOverflow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selVerticalOverflowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selVerticalOverflowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ushort Orient
	{
		[Export("orient")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selOrientHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selOrientHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomOverflowEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomOverflowEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomOverflowEvent(ushort orient, bool hasHorizontalOverflow, bool hasVerticalOverflow)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt16_bool_bool(base.Handle, selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_Handle, orient, hasHorizontalOverflow, hasVerticalOverflow), "initOverflowEvent:horizontalOverflow:verticalOverflow:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt16_bool_bool(base.SuperHandle, selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_Handle, orient, hasHorizontalOverflow, hasVerticalOverflow), "initOverflowEvent:horizontalOverflow:verticalOverflow:");
		}
	}

	[Export("initOverflowEvent:horizontalOverflow:verticalOverflow:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(ushort orient, bool hasHorizontalOverflow, bool hasVerticalOverflow)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16_bool_bool(base.Handle, selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_Handle, orient, hasHorizontalOverflow, hasVerticalOverflow);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16_bool_bool(base.SuperHandle, selInitOverflowEvent_HorizontalOverflow_VerticalOverflow_Handle, orient, hasHorizontalOverflow, hasVerticalOverflow);
		}
	}
}
