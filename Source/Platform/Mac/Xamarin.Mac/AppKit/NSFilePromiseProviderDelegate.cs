using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSFilePromiseProviderDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public abstract class NSFilePromiseProviderDelegate : NSObject, INSFilePromiseProviderDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSFilePromiseProviderDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFilePromiseProviderDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFilePromiseProviderDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("filePromiseProvider:fileNameForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string GetFileNameForDestination(NSFilePromiseProvider filePromiseProvider, string fileType);

	[Export("operationQueueForFilePromiseProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOperationQueue GetOperationQueue(NSFilePromiseProvider filePromiseProvider)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("filePromiseProvider:writePromiseToURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WritePromiseToUrl(NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
