using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKGameModelWrapper : BaseWrapper, IGKGameModel, INativeObject, IDisposable, INSCopying
{
	[Preserve(Conditional = true)]
	public GKGameModelWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("players")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameModelPlayer[]? GetPlayers()
	{
		return NSArray.ArrayFromHandle<IGKGameModelPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("players")));
	}

	[Export("activePlayer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameModelPlayer? GetActivePlayer()
	{
		return Runtime.GetINativeObject<IGKGameModelPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("activePlayer")), owns: false);
	}

	[Export("setGameModel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetGameModel(IGKGameModel gameModel)
	{
		if (gameModel == null)
		{
			throw new ArgumentNullException("gameModel");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setGameModel:"), gameModel.Handle);
	}

	[Export("gameModelUpdatesForPlayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameModelUpdate[]? GetGameModelUpdates(IGKGameModelPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return NSArray.ArrayFromHandle<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("gameModelUpdatesForPlayer:"), player.Handle));
	}

	[Export("applyGameModelUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ApplyGameModelUpdate(IGKGameModelUpdate gameModelUpdate)
	{
		if (gameModelUpdate == null)
		{
			throw new ArgumentNullException("gameModelUpdate");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("applyGameModelUpdate:"), gameModelUpdate.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
