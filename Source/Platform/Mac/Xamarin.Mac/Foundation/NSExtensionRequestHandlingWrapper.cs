using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSExtensionRequestHandlingWrapper : BaseWrapper, INSExtensionRequestHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSExtensionRequestHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginRequestWithExtensionContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("beginRequestWithExtensionContext:"), context.Handle);
	}
}
