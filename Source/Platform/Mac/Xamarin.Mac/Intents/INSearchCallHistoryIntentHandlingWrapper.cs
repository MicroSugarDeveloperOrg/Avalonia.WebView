using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INSearchCallHistoryIntentHandlingWrapper : BaseWrapper, IINSearchCallHistoryIntentHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public INSearchCallHistoryIntentHandlingWrapper(IntPtr handle, bool owns)
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
}
