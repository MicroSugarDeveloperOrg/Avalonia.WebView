using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

public static class IKImageBrowserDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveItems(this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("imageBrowser:removeItemsAtIndexes:"), aBrowser.Handle, indexes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool MoveItems(this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("imageBrowser:moveItemsAtIndexes:toIndex:"), aBrowser.Handle, indexes.Handle, destinationIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint WriteItemsToPasteboard(this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet itemIndexes, NSPasteboard pasteboard)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		if (itemIndexes == null)
		{
			throw new ArgumentNullException("itemIndexes");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.nint_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("imageBrowser:writeItemsAtIndexes:toPasteboard:"), aBrowser.Handle, itemIndexes.Handle, pasteboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GroupCount(this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfGroupsInImageBrowser:"), aBrowser.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary GetGroup(this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, nint index)
	{
		if (aBrowser == null)
		{
			throw new ArgumentNullException("aBrowser");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("imageBrowser:groupAtIndex:"), aBrowser.Handle, index));
	}
}
