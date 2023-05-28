using System;
using ObjCRuntime;

namespace Intents;

public static class INStartVideoCallIntentHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ConfirmStartVideoCall(this IINStartVideoCallIntentHandling This, INStartVideoCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V49))] Action<INStartVideoCallIntentResponse> completion)
	{
		if (intent == null)
		{
			throw new ArgumentNullException("intent");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V49.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("confirmStartVideoCall:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveContacts(this IINStartVideoCallIntentHandling This, INStartVideoCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V55))] Action<INPersonResolutionResult[]> completion)
	{
		if (intent == null)
		{
			throw new ArgumentNullException("intent");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V55.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveContactsForStartVideoCall:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
