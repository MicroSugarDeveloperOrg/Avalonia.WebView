using System;
using Foundation;
using ObjCRuntime;
using Security;

namespace MultipeerConnectivity;

public static class MCSessionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static bool DidReceiveCertificate(this IMCSessionDelegate This, MCSession session, SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> certificateHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (certificateHandler == null)
		{
			throw new ArgumentNullException("certificateHandler");
		}
		NSArray nSArray = ((certificate == null) ? null : NSArray.FromNSObjects(certificate));
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, certificateHandler);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didReceiveCertificate:fromPeer:certificateHandler:"), session.Handle, nSArray?.Handle ?? IntPtr.Zero, peerID.Handle, (IntPtr)ptr);
		nSArray?.Dispose();
		ptr->CleanupBlock();
		return result;
	}
}
