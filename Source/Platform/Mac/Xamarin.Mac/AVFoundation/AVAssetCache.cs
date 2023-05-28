using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetCache", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class AVAssetCache : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayableOffline = "isPlayableOffline";

	private static readonly IntPtr selIsPlayableOfflineHandle = Selector.GetHandle("isPlayableOffline");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionsInMediaSelectionGroup_ = "mediaSelectionOptionsInMediaSelectionGroup:";

	private static readonly IntPtr selMediaSelectionOptionsInMediaSelectionGroup_Handle = Selector.GetHandle("mediaSelectionOptionsInMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetCache");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPlayableOffline
	{
		[Export("isPlayableOffline")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableOfflineHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableOfflineHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetCache(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetCache(IntPtr handle)
		: base(handle)
	{
	}

	[Export("mediaSelectionOptionsInMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption[] GetMediaSelectionOptions(AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaSelectionOptionsInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
		}
		return NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaSelectionOptionsInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
	}
}
