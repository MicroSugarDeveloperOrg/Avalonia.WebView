using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKAchievementViewControllerDelegateWrapper : BaseWrapper, IGKAchievementViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKAchievementViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("achievementViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish(GKAchievementViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("achievementViewControllerDidFinish:"), viewController.Handle);
	}
}
