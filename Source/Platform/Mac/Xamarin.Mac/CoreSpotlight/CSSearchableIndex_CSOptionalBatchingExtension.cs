using System;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class CSSearchableIndex_CSOptionalBatchingExtension
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginIndexBatch = "beginIndexBatch";

	private static readonly IntPtr selBeginIndexBatchHandle = Selector.GetHandle("beginIndexBatch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndIndexBatchWithClientState_CompletionHandler_ = "endIndexBatchWithClientState:completionHandler:";

	private static readonly IntPtr selEndIndexBatchWithClientState_CompletionHandler_Handle = Selector.GetHandle("endIndexBatchWithClientState:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchLastClientStateWithCompletionHandler_ = "fetchLastClientStateWithCompletionHandler:";

	private static readonly IntPtr selFetchLastClientStateWithCompletionHandler_Handle = Selector.GetHandle("fetchLastClientStateWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CSSearchableIndex");

	[Export("beginIndexBatch")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BeginIndexBatch(this CSSearchableIndex This)
	{
		Messaging.void_objc_msgSend(This.Handle, selBeginIndexBatchHandle);
	}

	[Export("endIndexBatchWithClientState:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void EndIndexBatch(this CSSearchableIndex This, NSData clientState, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (clientState == null)
		{
			throw new ArgumentNullException("clientState");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, selEndIndexBatchWithClientState_CompletionHandler_Handle, clientState.Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("fetchLastClientStateWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void FetchLastClientState(this CSSearchableIndex This, [BlockProxy(typeof(Trampolines.NIDCSSearchableIndexFetchHandler))] CSSearchableIndexFetchHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCSSearchableIndexFetchHandler.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selFetchLastClientStateWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
