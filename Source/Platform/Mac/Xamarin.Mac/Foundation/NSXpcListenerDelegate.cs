using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("Xamarin_Mac__Foundation_NSXpcListenerDelegate", false)]
[Model]
public class NSXpcListenerDelegate : NSObject, INSXpcListenerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSXpcListenerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSXpcListenerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSXpcListenerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("listener:shouldAcceptNewConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAcceptConnection(NSXpcListener listener, NSXpcConnection newConnection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
