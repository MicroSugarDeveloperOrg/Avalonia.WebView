using System;
using ObjCRuntime;

namespace Intents;

public static class INSendMessageIntentHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ConfirmSendMessage(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V59))] Action<INSendMessageIntentResponse> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V59.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("confirmSendMessage:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'ResolveRecipients (INSendMessageIntent, Action<INSendMessageRecipientResolutionResult []>)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'ResolveRecipients (INSendMessageIntent, Action<INSendMessageRecipientResolutionResult []>)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'ResolveRecipients (INSendMessageIntent, Action<INSendMessageRecipientResolutionResult []>)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveRecipients(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V55))] Action<INPersonResolutionResult[]> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveRecipientsForSendMessage:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveRecipients(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V60))] Action<INSendMessageRecipientResolutionResult[]> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V60.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveRecipientsForSendMessage:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveContent(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V61))] Action<INStringResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V61.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveContentForSendMessage:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupName' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupName' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'ResolveSpeakableGroupName' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveGroupName(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V61))] Action<INStringResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V61.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveGroupNameForSendMessage:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResolveSpeakableGroupName(this IINSendMessageIntentHandling This, INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V62))] Action<INSpeakableStringResolutionResult> completion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V62.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resolveSpeakableGroupNameForSendMessage:withCompletion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
