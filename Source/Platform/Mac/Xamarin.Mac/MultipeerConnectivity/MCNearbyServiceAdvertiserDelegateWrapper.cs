using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

internal sealed class MCNearbyServiceAdvertiserDelegateWrapper : BaseWrapper, IMCNearbyServiceAdvertiserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MCNearbyServiceAdvertiserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy(typeof(Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))] MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
	{
		if (advertiser == null)
		{
			throw new ArgumentNullException("advertiser");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (invitationHandler == null)
		{
			throw new ArgumentNullException("invitationHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMCNearbyServiceAdvertiserInvitationHandler.Handler, invitationHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:"), advertiser.Handle, peerID.Handle, context?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
