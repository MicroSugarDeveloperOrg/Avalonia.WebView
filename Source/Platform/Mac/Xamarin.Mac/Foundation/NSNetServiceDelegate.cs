using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSNetServiceDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class NSNetServiceDelegate : NSObject, INSNetServiceDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNetServiceDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNetServiceDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("netServiceDidResolveAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddressResolved(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didAcceptConnectionWithInputStream:outputStream:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAcceptConnection(NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didNotPublish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PublishFailure(NSNetService sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceDidPublish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Published(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didNotResolve:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResolveFailure(NSNetService sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceDidStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stopped(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didUpdateTXTRecordData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedTxtRecordData(NSNetService sender, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceWillPublish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillPublish(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceWillResolve:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillResolve(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
