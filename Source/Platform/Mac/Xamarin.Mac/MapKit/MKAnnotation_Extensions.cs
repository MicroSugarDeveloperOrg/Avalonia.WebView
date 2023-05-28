using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

public static class MKAnnotation_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetCoordinate(this IMKAnnotation This, CLLocationCoordinate2D value)
	{
		Messaging.void_objc_msgSend_CLLocationCoordinate2D(This.Handle, Selector.GetHandle("setCoordinate:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetTitle(this IMKAnnotation This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("title")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetSubtitle(this IMKAnnotation This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("subtitle")));
	}
}
