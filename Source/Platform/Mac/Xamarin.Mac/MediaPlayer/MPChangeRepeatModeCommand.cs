using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangeRepeatModeCommand", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangeRepeatModeCommand : MPRemoteCommand
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRepeatType = "currentRepeatType";

	private static readonly IntPtr selCurrentRepeatTypeHandle = Selector.GetHandle("currentRepeatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentRepeatType_ = "setCurrentRepeatType:";

	private static readonly IntPtr selSetCurrentRepeatType_Handle = Selector.GetHandle("setCurrentRepeatType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangeRepeatModeCommand");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRepeatType CurrentRepeatType
	{
		[Export("currentRepeatType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPRepeatType)Messaging.Int64_objc_msgSend(base.Handle, selCurrentRepeatTypeHandle);
			}
			return (MPRepeatType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentRepeatTypeHandle);
		}
		[Export("setCurrentRepeatType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCurrentRepeatType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCurrentRepeatType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangeRepeatModeCommand(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangeRepeatModeCommand(IntPtr handle)
		: base(handle)
	{
	}
}
