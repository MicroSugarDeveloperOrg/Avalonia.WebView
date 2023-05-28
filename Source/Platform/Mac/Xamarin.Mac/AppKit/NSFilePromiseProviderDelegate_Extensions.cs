using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSFilePromiseProviderDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WritePromiseToUrl(this INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (filePromiseProvider == null)
		{
			throw new ArgumentNullException("filePromiseProvider");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("filePromiseProvider:writePromiseToURL:completionHandler:"), filePromiseProvider.Handle, url.Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOperationQueue GetOperationQueue(this INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider)
	{
		NSApplication.EnsureUIThread();
		if (filePromiseProvider == null)
		{
			throw new ArgumentNullException("filePromiseProvider");
		}
		return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("operationQueueForFilePromiseProvider:"), filePromiseProvider.Handle));
	}
}
