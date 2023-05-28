using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

internal sealed class QLPreviewingControllerWrapper : BaseWrapper, IQLPreviewingController, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QLPreviewingControllerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void PreparePreviewOfSearchableItem(string identifier, string queryString, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> ItemLoadingHandler)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (queryString == null)
		{
			throw new ArgumentNullException("queryString");
		}
		if (ItemLoadingHandler == null)
		{
			throw new ArgumentNullException("ItemLoadingHandler");
		}
		IntPtr intPtr = NSString.CreateNative(identifier);
		IntPtr intPtr2 = NSString.CreateNative(queryString);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, ItemLoadingHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:"), intPtr, intPtr2, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		ptr->CleanupBlock();
	}
}
