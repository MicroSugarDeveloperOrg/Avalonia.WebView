using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVFragmentedAsset", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVFragmentedAsset : AVUrlAsset, IAVFragmentMinding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragmentedAssetWithURL_Options_ = "fragmentedAssetWithURL:options:";

	private static readonly IntPtr selFragmentedAssetWithURL_Options_Handle = Selector.GetHandle("fragmentedAssetWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAssociatedWithFragmentMinder = "isAssociatedWithFragmentMinder";

	private static readonly IntPtr selIsAssociatedWithFragmentMinderHandle = Selector.GetHandle("isAssociatedWithFragmentMinder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVFragmentedAsset");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVFragmentedAssetTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVFragmentedAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVFragmentedAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[Obsolete("Default constructor should not be used")]
	public AVFragmentedAsset()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVFragmentedAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVFragmentedAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVFragmentedAsset(NSUrl url, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
	}

	[Export("fragmentedAssetWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAsset FromUrl(NSUrl url, NSDictionary<NSString, NSObject>? options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<AVFragmentedAsset>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFragmentedAssetWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("isAssociatedWithFragmentMinder")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAssociatedWithFragmentMinder()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsAssociatedWithFragmentMinderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAssociatedWithFragmentMinderHandle);
	}
}
