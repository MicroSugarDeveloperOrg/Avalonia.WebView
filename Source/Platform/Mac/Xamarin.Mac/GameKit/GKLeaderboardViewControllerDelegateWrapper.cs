using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKLeaderboardViewControllerDelegateWrapper : BaseWrapper, IGKLeaderboardViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKLeaderboardViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("leaderboardViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish(GKLeaderboardViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("leaderboardViewControllerDidFinish:"), viewController.Handle);
	}
}
