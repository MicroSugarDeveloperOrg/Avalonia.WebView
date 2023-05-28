using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INStartAudioCallIntentHandlingWrapper : BaseWrapper, IINStartAudioCallIntentHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public INStartAudioCallIntentHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
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
}
