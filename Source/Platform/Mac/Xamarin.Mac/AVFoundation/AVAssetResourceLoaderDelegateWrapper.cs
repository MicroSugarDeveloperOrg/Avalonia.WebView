using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVAssetResourceLoaderDelegateWrapper : BaseWrapper, IAVAssetResourceLoaderDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVAssetResourceLoaderDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("resourceLoader:shouldWaitForLoadingOfRequestedResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ShouldWaitForLoadingOfRequestedResource(AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
	{
		if (resourceLoader == null)
		{
			throw new ArgumentNullException("resourceLoader");
		}
		if (loadingRequest == null)
		{
			throw new ArgumentNullException("loadingRequest");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("resourceLoader:shouldWaitForLoadingOfRequestedResource:"), resourceLoader.Handle, loadingRequest.Handle);
	}
}
