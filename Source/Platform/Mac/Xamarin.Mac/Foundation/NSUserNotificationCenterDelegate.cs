using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSUserNotificationCenterDelegate", false)]
[Model]
public class NSUserNotificationCenterDelegate : NSObject, INSUserNotificationCenterDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserNotificationCenterDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUserNotificationCenterDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUserNotificationCenterDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("userNotificationCenter:didActivateNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidActivateNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:didDeliverNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDeliverNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:shouldPresentNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPresentNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
