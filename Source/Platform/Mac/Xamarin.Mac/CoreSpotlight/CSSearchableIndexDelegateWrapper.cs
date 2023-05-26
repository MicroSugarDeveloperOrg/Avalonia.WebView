using System;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

internal sealed class CSSearchableIndexDelegateWrapper : BaseWrapper, ICSSearchableIndexDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CSSearchableIndexDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void ReindexAllSearchableItems(CSSearchableIndex searchableIndex, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (acknowledgementHandler == null)
		{
			throw new ArgumentNullException("acknowledgementHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, acknowledgementHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:"), searchableIndex.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void ReindexSearchableItems(CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		if (acknowledgementHandler == null)
		{
			throw new ArgumentNullException("acknowledgementHandler");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, acknowledgementHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:"), searchableIndex.Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		ptr->CleanupBlock();
	}
}
