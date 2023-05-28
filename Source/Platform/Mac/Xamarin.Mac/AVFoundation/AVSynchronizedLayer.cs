using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSynchronizedLayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVSynchronizedLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerItem = "playerItem";

	private static readonly IntPtr selPlayerItemHandle = Selector.GetHandle("playerItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayerItem_ = "setPlayerItem:";

	private static readonly IntPtr selSetPlayerItem_Handle = Selector.GetHandle("setPlayerItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizedLayerWithPlayerItem_ = "synchronizedLayerWithPlayerItem:";

	private static readonly IntPtr selSynchronizedLayerWithPlayerItem_Handle = Selector.GetHandle("synchronizedLayerWithPlayerItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSynchronizedLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItem? PlayerItem
	{
		[Export("playerItem", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerItemHandle));
			}
			return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerItemHandle));
		}
		[Export("setPlayerItem:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlayerItem_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlayerItem_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSynchronizedLayer()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVSynchronizedLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSynchronizedLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSynchronizedLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("synchronizedLayerWithPlayerItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVSynchronizedLayer FromPlayerItem(AVPlayerItem playerItem)
	{
		if (playerItem == null)
		{
			throw new ArgumentNullException("playerItem");
		}
		return Runtime.GetNSObject<AVSynchronizedLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSynchronizedLayerWithPlayerItem_Handle, playerItem.Handle));
	}
}
