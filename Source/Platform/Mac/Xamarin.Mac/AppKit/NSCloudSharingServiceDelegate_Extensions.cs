using System;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSCloudSharingServiceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Completed(this INSCloudSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError? error)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:didCompleteForItems:error:"), sharingService.Handle, nSArray.Handle, error?.Handle ?? IntPtr.Zero);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCloudKitSharingServiceOptions Options(this INSCloudSharingServiceDelegate This, NSSharingService cloudKitSharingService, NSItemProvider provider)
	{
		NSApplication.EnsureUIThread();
		if (cloudKitSharingService == null)
		{
			throw new ArgumentNullException("cloudKitSharingService");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		return (NSCloudKitSharingServiceOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("optionsForSharingService:shareProvider:"), cloudKitSharingService.Handle, provider.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Saved(this INSCloudSharingServiceDelegate This, NSSharingService sharingService, CKShare share)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		if (share == null)
		{
			throw new ArgumentNullException("share");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:didSaveShare:"), sharingService.Handle, share.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Stopped(this INSCloudSharingServiceDelegate This, NSSharingService sharingService, CKShare share)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		if (share == null)
		{
			throw new ArgumentNullException("share");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:didStopSharing:"), sharingService.Handle, share.Handle);
	}
}
