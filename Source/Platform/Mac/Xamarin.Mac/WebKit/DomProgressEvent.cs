using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMProgressEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomProgressEvent : DomEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthComputable = "lengthComputable";

	private static readonly IntPtr selLengthComputableHandle = Selector.GetHandle("lengthComputable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoaded = "loaded";

	private static readonly IntPtr selLoadedHandle = Selector.GetHandle("loaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotal = "total";

	private static readonly IntPtr selTotalHandle = Selector.GetHandle("total");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMProgressEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLengthComputable
	{
		[Export("lengthComputable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLengthComputableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLengthComputableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong Loaded
	{
		[Export("loaded")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLoadedHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong Total
	{
		[Export("total")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selTotalHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTotalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomProgressEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomProgressEvent(IntPtr handle)
		: base(handle)
	{
	}
}
