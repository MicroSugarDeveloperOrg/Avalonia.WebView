using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangePlaybackRateCommandEvent", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangePlaybackRateCommandEvent : MPRemoteCommandEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackRate = "playbackRate";

	private static readonly IntPtr selPlaybackRateHandle = Selector.GetHandle("playbackRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangePlaybackRateCommandEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PlaybackRate
	{
		[Export("playbackRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPlaybackRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPlaybackRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangePlaybackRateCommandEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangePlaybackRateCommandEvent(IntPtr handle)
		: base(handle)
	{
	}
}
