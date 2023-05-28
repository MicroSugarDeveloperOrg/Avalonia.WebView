using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableMediaSelection", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMutableMediaSelection : AVMediaSelection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectMediaOption_InMediaSelectionGroup_ = "selectMediaOption:inMediaSelectionGroup:";

	private static readonly IntPtr selSelectMediaOption_InMediaSelectionGroup_Handle = Selector.GetHandle("selectMediaOption:inMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableMediaSelection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableMediaSelection()
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
	protected AVMutableMediaSelection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableMediaSelection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("selectMediaOption:inMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectMediaOption(AVMediaSelectionOption? mediaSelectionOption, AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectMediaOption_InMediaSelectionGroup_Handle, mediaSelectionOption?.Handle ?? IntPtr.Zero, mediaSelectionGroup.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectMediaOption_InMediaSelectionGroup_Handle, mediaSelectionOption?.Handle ?? IntPtr.Zero, mediaSelectionGroup.Handle);
		}
	}
}
