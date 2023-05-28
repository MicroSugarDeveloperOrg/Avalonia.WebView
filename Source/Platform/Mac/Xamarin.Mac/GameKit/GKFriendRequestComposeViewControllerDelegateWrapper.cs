using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKFriendRequestComposeViewControllerDelegateWrapper : BaseWrapper, IGKFriendRequestComposeViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKFriendRequestComposeViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("friendRequestComposeViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish(GKFriendRequestComposeViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("friendRequestComposeViewControllerDidFinish:"), viewController.Handle);
	}
}
