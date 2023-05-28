using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

public static class NSFileProviderEnumerator_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EnumerateChanges(this INSFileProviderEnumerator This, INSFileProviderChangeObserver observer, NSData syncAnchor)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (syncAnchor == null)
		{
			throw new ArgumentNullException("syncAnchor");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("enumerateChangesForObserver:fromSyncAnchor:"), observer.Handle, syncAnchor.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void CurrentSyncAnchor(this INSFileProviderEnumerator This, [BlockProxy(typeof(Trampolines.NIDActionArity1V28))] Action<NSData> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V28.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("currentSyncAnchorWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
