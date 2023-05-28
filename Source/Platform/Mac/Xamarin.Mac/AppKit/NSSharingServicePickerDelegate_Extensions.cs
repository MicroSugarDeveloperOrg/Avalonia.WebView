using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSharingServicePickerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSharingService[] SharingServicesForItems(this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
	{
		NSApplication.EnsureUIThread();
		if (sharingServicePicker == null)
		{
			throw new ArgumentNullException("sharingServicePicker");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (proposedServices == null)
		{
			throw new ArgumentNullException("proposedServices");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		NSArray nSArray2 = NSArray.FromNSObjects(proposedServices);
		NSSharingService[] result = NSArray.ArrayFromHandle<NSSharingService>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingServicePicker:sharingServicesForItems:proposedSharingServices:"), sharingServicePicker.Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSSharingServiceDelegate DelegateForSharingService(this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
	{
		NSApplication.EnsureUIThread();
		if (sharingServicePicker == null)
		{
			throw new ArgumentNullException("sharingServicePicker");
		}
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		return Runtime.GetINativeObject<INSSharingServiceDelegate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingServicePicker:delegateForSharingService:"), sharingServicePicker.Handle, sharingService.Handle), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChooseSharingService(this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService service)
	{
		NSApplication.EnsureUIThread();
		if (sharingServicePicker == null)
		{
			throw new ArgumentNullException("sharingServicePicker");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingServicePicker:didChooseSharingService:"), sharingServicePicker.Handle, service.Handle);
	}
}
