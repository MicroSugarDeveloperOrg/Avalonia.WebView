using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Register("VSSubscriptionRegistrationCenter", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public class VSSubscriptionRegistrationCenter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultSubscriptionRegistrationCenter = "defaultSubscriptionRegistrationCenter";

	private static readonly IntPtr selDefaultSubscriptionRegistrationCenterHandle = Selector.GetHandle("defaultSubscriptionRegistrationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentSubscription_ = "setCurrentSubscription:";

	private static readonly IntPtr selSetCurrentSubscription_Handle = Selector.GetHandle("setCurrentSubscription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VSSubscriptionRegistrationCenter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VSSubscriptionRegistrationCenter Default
	{
		[Export("defaultSubscriptionRegistrationCenter")]
		get
		{
			return Runtime.GetNSObject<VSSubscriptionRegistrationCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultSubscriptionRegistrationCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VSSubscriptionRegistrationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VSSubscriptionRegistrationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setCurrentSubscription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCurrentSubscription(VSSubscription? currentSubscription)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentSubscription_Handle, currentSubscription?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentSubscription_Handle, currentSubscription?.Handle ?? IntPtr.Zero);
		}
	}
}
