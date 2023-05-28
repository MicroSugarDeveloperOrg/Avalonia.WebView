using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangeShuffleModeCommand", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangeShuffleModeCommand : MPRemoteCommand
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentShuffleType = "currentShuffleType";

	private static readonly IntPtr selCurrentShuffleTypeHandle = Selector.GetHandle("currentShuffleType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentShuffleType_ = "setCurrentShuffleType:";

	private static readonly IntPtr selSetCurrentShuffleType_Handle = Selector.GetHandle("setCurrentShuffleType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangeShuffleModeCommand");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPShuffleType CurrentShuffleType
	{
		[Export("currentShuffleType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPShuffleType)Messaging.Int64_objc_msgSend(base.Handle, selCurrentShuffleTypeHandle);
			}
			return (MPShuffleType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentShuffleTypeHandle);
		}
		[Export("setCurrentShuffleType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCurrentShuffleType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCurrentShuffleType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangeShuffleModeCommand(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangeShuffleModeCommand(IntPtr handle)
		: base(handle)
	{
	}
}
