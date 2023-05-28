using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKGameCenterControllerDelegateWrapper : BaseWrapper, IGKGameCenterControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKGameCenterControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("gameCenterViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Finished(GKGameCenterViewController controller)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("gameCenterViewControllerDidFinish:"), controller.Handle);
	}
}
