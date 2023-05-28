using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PushKit;

[Protocol]
[Register("PKPushRegistryDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public abstract class PKPushRegistryDelegate : NSObject, IPKPushRegistryDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected PKPushRegistryDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PKPushRegistryDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PKPushRegistryDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pushRegistry:didInvalidatePushTokenForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidInvalidatePushToken(PKPushRegistry registry, string type)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveIncomingPush(PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pushRegistry:didUpdatePushCredentials:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidUpdatePushCredentials(PKPushRegistry registry, PKPushCredentials credentials, string type);
}
