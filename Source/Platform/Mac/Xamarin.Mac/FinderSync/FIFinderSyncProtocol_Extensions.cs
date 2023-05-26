using System;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace FinderSync;

public static class FIFinderSyncProtocol_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu? GetMenu(this IFIFinderSyncProtocol This, FIMenuKind menuKind)
	{
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("menuForMenuKind:"), (ulong)menuKind));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BeginObservingDirectory(this IFIFinderSyncProtocol This, NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("beginObservingDirectoryAtURL:"), url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EndObservingDirectory(this IFIFinderSyncProtocol This, NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("endObservingDirectoryAtURL:"), url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestBadgeIdentifier(this IFIFinderSyncProtocol This, NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("requestBadgeIdentifierForURL:"), url.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] SupportedServiceNames(this IFIFinderSyncProtocol This, NSUrl itemUrl)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("supportedServiceNamesForItemWithURL:"), itemUrl.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetValues(this IFIFinderSyncProtocol This, string[] attributes, NSUrl itemUrl, [BlockProxy(typeof(Trampolines.NIDGetValuesCompletionHandler))] GetValuesCompletionHandler completion)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		NSArray nSArray = NSArray.FromStrings(attributes);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGetValuesCompletionHandler.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("valuesForAttributes:forItemWithURL:completion:"), nSArray.Handle, itemUrl.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSDictionary<NSString, NSObject>> GetValuesAsync(this IFIFinderSyncProtocol This, string[] attributes, NSUrl itemUrl)
	{
		TaskCompletionSource<NSDictionary<NSString, NSObject>> tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>>();
		This.GetValues(attributes, itemUrl, delegate(NSDictionary<NSString, NSObject> values_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(values_);
			}
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetToolbarItemName(this IFIFinderSyncProtocol This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("toolbarItemName")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage GetToolbarItemImage(this IFIFinderSyncProtocol This)
	{
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("toolbarItemImage")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetToolbarItemToolTip(this IFIFinderSyncProtocol This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("toolbarItemToolTip")));
	}
}
