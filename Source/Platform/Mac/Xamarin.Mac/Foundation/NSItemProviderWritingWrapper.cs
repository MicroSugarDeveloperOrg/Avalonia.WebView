using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSItemProviderWritingWrapper : BaseWrapper, INSItemProviderWriting, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSItemProviderWritingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSProgress? LoadData(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		NSProgress nSObject = Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:"), intPtr, (IntPtr)ptr));
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
		return nSObject;
	}
}
