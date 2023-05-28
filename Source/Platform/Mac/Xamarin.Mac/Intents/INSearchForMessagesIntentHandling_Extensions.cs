using System;
using ObjCRuntime;

namespace Intents;

public static class INSearchForMessagesIntentHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ConfirmSearchForMessages(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V54))] Action<INSearchForMessagesIntentResponse> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V54.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("confirmSearchForMessages:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveRecipients(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V55))] Action<INPersonResolutionResult[]> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveRecipientsForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveSenders(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V55))] Action<INPersonResolutionResult[]> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveSendersForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveAttributes(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V56))] Action<INMessageAttributeOptionsResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V56.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveAttributesForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveDateTimeRange(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V51))] Action<INDateComponentsRangeResolutionResult> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveDateTimeRangeForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupNames' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveGroupNames(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V57))] Action<INStringResolutionResult[]> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V57.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveGroupNamesForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveSpeakableGroupNames(this IINSearchForMessagesIntentHandling This, INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V58))] Action<INSpeakableStringResolutionResult[]> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V58.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveSpeakableGroupNamesForSearchForMessages:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
