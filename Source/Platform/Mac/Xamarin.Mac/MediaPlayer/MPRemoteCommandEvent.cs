using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPRemoteCommandEvent", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPRemoteCommandEvent : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommand = "command";

	private static readonly IntPtr selCommandHandle = Selector.GetHandle("command");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimestamp = "timestamp";

	private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPRemoteCommandEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand Command
	{
		[Export("command")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Timestamp
	{
		[Export("timestamp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimestampHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimestampHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPRemoteCommandEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPRemoteCommandEvent(IntPtr handle)
		: base(handle)
	{
	}
}
