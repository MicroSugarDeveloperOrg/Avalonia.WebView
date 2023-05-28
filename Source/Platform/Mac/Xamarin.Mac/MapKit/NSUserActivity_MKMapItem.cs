using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

public static class NSUserActivity_MKMapItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapItem = "mapItem";

	private static readonly IntPtr selMapItemHandle = Selector.GetHandle("mapItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMapItem_ = "setMapItem:";

	private static readonly IntPtr selSetMapItem_Handle = Selector.GetHandle("setMapItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSUserActivity");

	[Export("mapItem")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKMapItem GetMapItem(this NSUserActivity This)
	{
		return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(This.Handle, selMapItemHandle));
	}

	[Export("setMapItem:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetMapItem(this NSUserActivity This, MKMapItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetMapItem_Handle, item.Handle);
	}
}
