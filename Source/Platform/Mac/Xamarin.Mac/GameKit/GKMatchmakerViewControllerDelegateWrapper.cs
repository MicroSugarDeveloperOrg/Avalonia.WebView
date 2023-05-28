using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKMatchmakerViewControllerDelegateWrapper : BaseWrapper, IGKMatchmakerViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKMatchmakerViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("matchmakerViewControllerWasCancelled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WasCancelled(GKMatchmakerViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("matchmakerViewControllerWasCancelled:"), viewController.Handle);
	}

	[Export("matchmakerViewController:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFailWithError(GKMatchmakerViewController viewController, NSError error)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("matchmakerViewController:didFailWithError:"), viewController.Handle, error.Handle);
	}

	[Export("matchmakerViewController:didFindMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFindMatch(GKMatchmakerViewController viewController, GKMatch match)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("matchmakerViewController:didFindMatch:"), viewController.Handle, match.Handle);
	}

	[Export("matchmakerViewController:didFindPlayers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFindPlayers(GKMatchmakerViewController viewController, string[] playerIDs)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (playerIDs == null)
		{
			throw new ArgumentNullException("playerIDs");
		}
		NSArray nSArray = NSArray.FromStrings(playerIDs);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("matchmakerViewController:didFindPlayers:"), viewController.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("matchmakerViewController:didFindHostedPlayers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFindHostedPlayers(GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (playerIDs == null)
		{
			throw new ArgumentNullException("playerIDs");
		}
		NSArray nSArray = NSArray.FromNSObjects(playerIDs);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("matchmakerViewController:didFindHostedPlayers:"), viewController.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
