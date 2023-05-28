using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVFragmentedAssetMinder", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVFragmentedAssetMinder : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFragmentedAsset_ = "addFragmentedAsset:";

	private static readonly IntPtr selAddFragmentedAsset_Handle = Selector.GetHandle("addFragmentedAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssets = "assets";

	private static readonly IntPtr selAssetsHandle = Selector.GetHandle("assets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragmentedAssetMinderWithAsset_MindingInterval_ = "fragmentedAssetMinderWithAsset:mindingInterval:";

	private static readonly IntPtr selFragmentedAssetMinderWithAsset_MindingInterval_Handle = Selector.GetHandle("fragmentedAssetMinderWithAsset:mindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_MindingInterval_ = "initWithAsset:mindingInterval:";

	private static readonly IntPtr selInitWithAsset_MindingInterval_Handle = Selector.GetHandle("initWithAsset:mindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMindingInterval = "mindingInterval";

	private static readonly IntPtr selMindingIntervalHandle = Selector.GetHandle("mindingInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFragmentedAsset_ = "removeFragmentedAsset:";

	private static readonly IntPtr selRemoveFragmentedAsset_Handle = Selector.GetHandle("removeFragmentedAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMindingInterval_ = "setMindingInterval:";

	private static readonly IntPtr selSetMindingInterval_Handle = Selector.GetHandle("setMindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVFragmentedAssetMinder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset[] Assets
	{
		[Export("assets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetsHandle));
			}
			return NSArray.ArrayFromHandle<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MindingInterval
	{
		[Export("mindingInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMindingIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMindingIntervalHandle);
		}
		[Export("setMindingInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMindingInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMindingInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVFragmentedAssetMinder()
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
	protected AVFragmentedAssetMinder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVFragmentedAssetMinder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:mindingInterval:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVFragmentedAssetMinder(IAVFragmentMinding asset, double mindingInterval)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double(base.Handle, selInitWithAsset_MindingInterval_Handle, asset.Handle, mindingInterval), "initWithAsset:mindingInterval:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selInitWithAsset_MindingInterval_Handle, asset.Handle, mindingInterval), "initWithAsset:mindingInterval:");
		}
	}

	[Export("addFragmentedAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddFragmentedAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddFragmentedAsset_Handle, asset.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFragmentedAsset_Handle, asset.Handle);
		}
	}

	[Export("fragmentedAssetMinderWithAsset:mindingInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetMinder FromAsset(AVAsset asset, double mindingInterval)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<AVFragmentedAssetMinder>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFragmentedAssetMinderWithAsset_MindingInterval_Handle, asset.Handle, mindingInterval));
	}

	[Export("removeFragmentedAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFragmentedAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFragmentedAsset_Handle, asset.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFragmentedAsset_Handle, asset.Handle);
		}
	}
}
