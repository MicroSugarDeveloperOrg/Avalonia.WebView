using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKTurnBasedEventHandlerDelegateWrapper : BaseWrapper, IGKTurnBasedEventHandlerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKTurnBasedEventHandlerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("handleInviteFromGameCenter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void HandleInviteFromGameCenter(NSString[] playersToInvite)
	{
		if (playersToInvite == null)
		{
			throw new ArgumentNullException("playersToInvite");
		}
		NSArray nSArray = NSArray.FromNSObjects(playersToInvite);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("handleInviteFromGameCenter:"), nSArray.Handle);
		nSArray.Dispose();
	}
}
