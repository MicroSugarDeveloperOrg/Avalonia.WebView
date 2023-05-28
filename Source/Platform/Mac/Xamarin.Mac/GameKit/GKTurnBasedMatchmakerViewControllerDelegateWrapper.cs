using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKTurnBasedMatchmakerViewControllerDelegateWrapper : BaseWrapper, IGKTurnBasedMatchmakerViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKTurnBasedMatchmakerViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("turnBasedMatchmakerViewControllerWasCancelled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WasCancelled(GKTurnBasedMatchmakerViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("turnBasedMatchmakerViewControllerWasCancelled:"), viewController.Handle);
	}

	[Export("turnBasedMatchmakerViewController:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FailedWithError(GKTurnBasedMatchmakerViewController viewController, NSError error)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("turnBasedMatchmakerViewController:didFailWithError:"), viewController.Handle, error.Handle);
	}

	[Export("turnBasedMatchmakerViewController:didFindMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FoundMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("turnBasedMatchmakerViewController:didFindMatch:"), viewController.Handle, match.Handle);
	}

	[Export("turnBasedMatchmakerViewController:playerQuitForMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PlayerQuitForMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("turnBasedMatchmakerViewController:playerQuitForMatch:"), viewController.Handle, match.Handle);
	}
}
