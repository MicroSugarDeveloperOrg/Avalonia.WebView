using System;
using ObjCRuntime;

namespace Intents;

public static class INStartAudioCallIntentHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ConfirmStartAudioCall(this IINStartAudioCallIntentHandling This, INStartAudioCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V48))] Action<INStartAudioCallIntentResponse> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V48.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("confirmStartAudioCall:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveDestinationType(this IINStartAudioCallIntentHandling This, INStartAudioCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V63))] Action<INCallDestinationTypeResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V63.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveDestinationTypeForStartAudioCall:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveContacts(this IINStartAudioCallIntentHandling This, INStartAudioCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V55))] Action<INPersonResolutionResult[]> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveContactsForStartAudioCall:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
