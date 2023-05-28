using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INSendMessageIntentHandlingWrapper : BaseWrapper, IINSendMessageIntentHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public INSendMessageIntentHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("handleSendMessage:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleSendMessage(INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V59))] Action<INSendMessageIntentResponse> completion)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("handleSendMessage:completion:"), intent.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
