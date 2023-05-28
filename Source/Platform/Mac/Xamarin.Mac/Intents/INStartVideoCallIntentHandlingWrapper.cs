using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INStartVideoCallIntentHandlingWrapper : BaseWrapper, IINStartVideoCallIntentHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public INStartVideoCallIntentHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
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
