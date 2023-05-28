using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangeRepeatModeCommandEvent", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangeRepeatModeCommandEvent : MPRemoteCommandEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesRepeatMode = "preservesRepeatMode";

	private static readonly IntPtr selPreservesRepeatModeHandle = Selector.GetHandle("preservesRepeatMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatType = "repeatType";

	private static readonly IntPtr selRepeatTypeHandle = Selector.GetHandle("repeatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangeRepeatModeCommandEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool PreservesRepeatMode
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("preservesRepeatMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesRepeatModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesRepeatModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRepeatType RepeatType
	{
		[Export("repeatType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPRepeatType)Messaging.Int64_objc_msgSend(base.Handle, selRepeatTypeHandle);
			}
			return (MPRepeatType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRepeatTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangeRepeatModeCommandEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangeRepeatModeCommandEvent(IntPtr handle)
		: base(handle)
	{
	}
}
