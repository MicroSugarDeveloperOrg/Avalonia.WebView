using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLSessionStreamDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class NSUrlSessionStreamDelegate : NSUrlSessionTaskDelegate, INSUrlSessionStreamDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlSessionStreamDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionStreamDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionStreamDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("URLSession:betterRouteDiscoveredForStreamTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BetterRouteDiscovered(NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:streamTask:didBecomeInputStream:outputStream:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CompletedTaskCaptureStreams(NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:readClosedForStreamTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadClosed(NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:writeClosedForStreamTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteClosed(NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
