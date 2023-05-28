using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INCallsDomainHandlingWrapper : BaseWrapper, IINCallsDomainHandling, INativeObject, IDisposable, IINSearchCallHistoryIntentHandling, IINStartAudioCallIntentHandling, IINStartVideoCallIntentHandling
{
	[Preserve(Conditional = true)]
	public INCallsDomainHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("handleSearchCallHistory:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleSearchCallHistory(INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V47))] Action<INSearchCallHistoryIntentResponse> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("handleSearchCallHistory:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("handleStartAudioCall:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleStartAudioCall(INStartAudioCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V48))] Action<INStartAudioCallIntentResponse> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("handleStartAudioCall:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("handleStartVideoCall:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleStartVideoCall(INStartVideoCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V49))] Action<INStartVideoCallIntentResponse> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("handleStartVideoCall:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
