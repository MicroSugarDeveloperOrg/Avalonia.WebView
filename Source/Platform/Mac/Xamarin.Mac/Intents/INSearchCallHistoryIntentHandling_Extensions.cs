using System;
using ObjCRuntime;

namespace Intents;

public static class INSearchCallHistoryIntentHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ConfirmSearchCallHistory(this IINSearchCallHistoryIntentHandling This, INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V47))] Action<INSearchCallHistoryIntentResponse> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V47.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("confirmSearchCallHistory:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'ResolveCallTypes' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'ResolveCallTypes' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'ResolveCallTypes' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveCallType(this IINSearchCallHistoryIntentHandling This, INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V50))] Action<INCallRecordTypeResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V50.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveCallTypeForSearchCallHistory:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveDateCreated(this IINSearchCallHistoryIntentHandling This, INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V51))] Action<INDateComponentsRangeResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V51.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveDateCreatedForSearchCallHistory:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveRecipient(this IINSearchCallHistoryIntentHandling This, INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V52))] Action<INPersonResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V52.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveRecipientForSearchCallHistory:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveCallTypes(this IINSearchCallHistoryIntentHandling This, INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V53))] Action<INCallRecordTypeOptionsResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V53.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveCallTypesForSearchCallHistory:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
