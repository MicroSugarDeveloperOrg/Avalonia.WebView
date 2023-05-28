using ObjCRuntime;

namespace MapKit;

public static class MKOverlay_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Intersects(this IMKOverlay This, MKMapRect rect)
	{
		return Messaging.bool_objc_msgSend_MKMapRect(This.Handle, Selector.GetHandle("intersectsMapRect:"), rect);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetCanReplaceMapContent(this IMKOverlay This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("canReplaceMapContent"));
	}
}
