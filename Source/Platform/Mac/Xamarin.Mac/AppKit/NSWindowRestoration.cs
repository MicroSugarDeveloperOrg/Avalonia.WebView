using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSWindowRestoration", false)]
[Model]
public class NSWindowRestoration : NSObject, INSWindowRestoration, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWindowRestoration()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSWindowRestoration(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWindowRestoration(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("restoreWindowWithIdentifier:state:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RestoreWindow(string identifier, NSCoder state, [BlockProxy(typeof(Trampolines.NIDNSWindowCompletionHandler))] NSWindowCompletionHandler onCompletion)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
