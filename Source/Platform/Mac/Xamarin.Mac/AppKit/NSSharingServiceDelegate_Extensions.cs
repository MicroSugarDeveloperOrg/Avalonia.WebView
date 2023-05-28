using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSharingServiceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillShareItems(this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:willShareItems:"), sharingService.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailToShareItems(this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError error)
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
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:didFailToShareItems:error:"), sharingService.Handle, nSArray.Handle, error.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidShareItems(this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("sharingService:didShareItems:"), sharingService.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect SourceFrameOnScreenForShareItem(this INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out var retval, This.Handle, Selector.GetHandle("sharingService:sourceFrameOnScreenForShareItem:"), sharingService.Handle, item.Handle);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage TransitionImageForShareItem(this INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect(This.Handle, Selector.GetHandle("sharingService:transitionImageForShareItem:contentRect:"), sharingService.Handle, item.Handle, contentRect));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow SourceWindowForShareItems(this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
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
		NSWindow nSObject = Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("sharingService:sourceWindowForShareItems:sharingContentScope:"), sharingService.Handle, nSArray.Handle, (long)sharingContentScope));
		nSArray.Dispose();
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView? CreateAnchoringView(this INSSharingServiceDelegate This, NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_CGRect_ref_NSRectEdge(This.Handle, Selector.GetHandle("anchoringViewForSharingService:showRelativeToRect:preferredEdge:"), sharingService.Handle, ref positioningRect, ref preferredEdge));
	}
}
