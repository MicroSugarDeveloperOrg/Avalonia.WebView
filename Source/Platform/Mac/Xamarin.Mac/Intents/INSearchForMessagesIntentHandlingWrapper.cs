using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INSearchForMessagesIntentHandlingWrapper : BaseWrapper, IINSearchForMessagesIntentHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public INSearchForMessagesIntentHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("handleSearchForMessages:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleSearchForMessages(INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V54))] Action<INSearchForMessagesIntentResponse> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("handleSearchForMessages:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
