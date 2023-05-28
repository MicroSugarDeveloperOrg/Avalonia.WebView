using System;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

public static class SFSafariExtensionHandling_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MessageReceived(this ISFSafariExtensionHandling This, string messageName, SFSafariPage page, NSDictionary? userInfo)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		IntPtr intPtr = NSString.CreateNative(messageName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("messageReceivedWithName:fromPage:userInfo:"), intPtr, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ToolbarItemClicked(this ISFSafariExtensionHandling This, SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarItemClickedInWindow:"), window.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ValidateToolbarItem(this ISFSafariExtensionHandling This, SFSafariWindow window, [BlockProxy(typeof(Trampolines.NIDActionArity2V82))] Action<bool, NSString> validationHandler)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (validationHandler == null)
		{
			throw new ArgumentNullException("validationHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V82.Handler, validationHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("validateToolbarItemInWindow:validationHandler:"), window.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFValidationResult> ValidateToolbarItemAsync(this ISFSafariExtensionHandling This, SFSafariWindow window)
	{
		TaskCompletionSource<SFValidationResult> tcs = new TaskCompletionSource<SFValidationResult>();
		This.ValidateToolbarItem(window, delegate(bool arg1_, NSString arg2_)
		{
			tcs.SetResult(new SFValidationResult(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ContextMenuItemSelected(this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary? userInfo)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		IntPtr intPtr = NSString.CreateNative(command);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contextMenuItemSelectedWithCommand:inPage:userInfo:"), intPtr, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PopoverWillShow(this ISFSafariExtensionHandling This, SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverWillShowInWindow:"), window.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PopoverDidClose(this ISFSafariExtensionHandling This, SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverDidCloseInWindow:"), window.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ValidateContextMenuItem(this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy(typeof(Trampolines.NIDSFExtensionValidationHandler))] SFExtensionValidationHandler validationHandler)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (validationHandler == null)
		{
			throw new ArgumentNullException("validationHandler");
		}
		IntPtr intPtr = NSString.CreateNative(command);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSFExtensionValidationHandler.Handler, validationHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:"), intPtr, page.Handle, userInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFExtensionValidationResult> ValidateContextMenuItemAsync(this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo)
	{
		TaskCompletionSource<SFExtensionValidationResult> tcs = new TaskCompletionSource<SFExtensionValidationResult>();
		This.ValidateContextMenuItem(command, page, userInfo, delegate(bool shouldHide_, NSString text_)
		{
			tcs.SetResult(new SFExtensionValidationResult(shouldHide_, text_));
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MessageReceivedFromContainingApp(this ISFSafariExtensionHandling This, string messageName, NSDictionary<NSString, NSObject>? userInfo)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		IntPtr intPtr = NSString.CreateNative(messageName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("messageReceivedFromContainingAppWithName:userInfo:"), intPtr, userInfo?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void AdditionalRequestHeaders(this ISFSafariExtensionHandling This, NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V77))] Action<NSDictionary<NSString, NSString>> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V77.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("additionalRequestHeadersForURL:completionHandler:"), url.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ContentBlocker(this ISFSafariExtensionHandling This, string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
	{
		if (contentBlockerIdentifier == null)
		{
			throw new ArgumentNullException("contentBlockerIdentifier");
		}
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		IntPtr intPtr = NSString.CreateNative(contentBlockerIdentifier);
		NSArray nSArray = NSArray.FromNSObjects(urls);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:"), intPtr, nSArray.Handle, page.Handle);
		NSString.ReleaseNative(intPtr);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillNavigate(this ISFSafariExtensionHandling This, SFSafariPage page, NSUrl? url)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("page:willNavigateToURL:"), page.Handle, (url == null) ? IntPtr.Zero : url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SFSafariExtensionViewController GetPopoverViewController(this ISFSafariExtensionHandling This)
	{
		return Runtime.GetNSObject<SFSafariExtensionViewController>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("popoverViewController")));
	}
}
