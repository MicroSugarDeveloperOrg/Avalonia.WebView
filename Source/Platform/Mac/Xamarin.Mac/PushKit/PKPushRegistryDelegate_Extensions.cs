using System;
using Foundation;
using ObjCRuntime;

namespace PushKit;

public static class PKPushRegistryDelegate_Extensions
{
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveIncomingPush(this IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		if (payload == null)
		{
			throw new ArgumentNullException("payload");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:"), registry.Handle, payload.Handle, intPtr, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidInvalidatePushToken(this IPKPushRegistryDelegate This, PKPushRegistry registry, string type)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pushRegistry:didInvalidatePushTokenForType:"), registry.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
