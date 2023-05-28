using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKChallengesViewControllerDelegateWrapper : BaseWrapper, IGKChallengesViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKChallengesViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("challengesViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish(GKChallengesViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("challengesViewControllerDidFinish:"), viewController.Handle);
	}
}
