using System;

namespace ObjCRuntime;

internal class BlockStaticDispatchClass
{
	internal delegate void dispatch_block_t(IntPtr block);

	internal static dispatch_block_t static_dispatch_block = TrampolineDispatchBlock;

	[MonoPInvokeCallback(typeof(dispatch_block_t))]
	private static void TrampolineDispatchBlock(IntPtr block)
	{
		BlockLiteral.GetTarget<Action>(block)?.Invoke();
	}
}
