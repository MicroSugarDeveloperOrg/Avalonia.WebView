using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangeShuffleModeCommandEvent", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangeShuffleModeCommandEvent : MPRemoteCommandEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesShuffleMode = "preservesShuffleMode";

	private static readonly IntPtr selPreservesShuffleModeHandle = Selector.GetHandle("preservesShuffleMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShuffleType = "shuffleType";

	private static readonly IntPtr selShuffleTypeHandle = Selector.GetHandle("shuffleType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangeShuffleModeCommandEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool PreservesShuffleMode
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("preservesShuffleMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesShuffleModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesShuffleModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPShuffleType ShuffleType
	{
		[Export("shuffleType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPShuffleType)Messaging.Int64_objc_msgSend(base.Handle, selShuffleTypeHandle);
			}
			return (MPShuffleType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selShuffleTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangeShuffleModeCommandEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangeShuffleModeCommandEvent(IntPtr handle)
		: base(handle)
	{
	}
}
