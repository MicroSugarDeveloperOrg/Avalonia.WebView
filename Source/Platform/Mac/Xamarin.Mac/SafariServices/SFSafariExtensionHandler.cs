using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Register("SFSafariExtensionHandler", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class SFSafariExtensionHandler : NSObject, INSExtensionRequestHandling, INativeObject, IDisposable, ISFSafariExtensionHandling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdditionalRequestHeadersForURL_CompletionHandler_ = "additionalRequestHeadersForURL:completionHandler:";

	private static readonly IntPtr selAdditionalRequestHeadersForURL_CompletionHandler_Handle = Selector.GetHandle("additionalRequestHeadersForURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginRequestWithExtensionContext_ = "beginRequestWithExtensionContext:";

	private static readonly IntPtr selBeginRequestWithExtensionContext_Handle = Selector.GetHandle("beginRequestWithExtensionContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_ = "contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:";

	private static readonly IntPtr selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_Handle = Selector.GetHandle("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextMenuItemSelectedWithCommand_InPage_UserInfo_ = "contextMenuItemSelectedWithCommand:inPage:userInfo:";

	private static readonly IntPtr selContextMenuItemSelectedWithCommand_InPage_UserInfo_Handle = Selector.GetHandle("contextMenuItemSelectedWithCommand:inPage:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageReceivedFromContainingAppWithName_UserInfo_ = "messageReceivedFromContainingAppWithName:userInfo:";

	private static readonly IntPtr selMessageReceivedFromContainingAppWithName_UserInfo_Handle = Selector.GetHandle("messageReceivedFromContainingAppWithName:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageReceivedWithName_FromPage_UserInfo_ = "messageReceivedWithName:fromPage:userInfo:";

	private static readonly IntPtr selMessageReceivedWithName_FromPage_UserInfo_Handle = Selector.GetHandle("messageReceivedWithName:fromPage:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPage_WillNavigateToURL_ = "page:willNavigateToURL:";

	private static readonly IntPtr selPage_WillNavigateToURL_Handle = Selector.GetHandle("page:willNavigateToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopoverDidCloseInWindow_ = "popoverDidCloseInWindow:";

	private static readonly IntPtr selPopoverDidCloseInWindow_Handle = Selector.GetHandle("popoverDidCloseInWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopoverViewController = "popoverViewController";

	private static readonly IntPtr selPopoverViewControllerHandle = Selector.GetHandle("popoverViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopoverWillShowInWindow_ = "popoverWillShowInWindow:";

	private static readonly IntPtr selPopoverWillShowInWindow_Handle = Selector.GetHandle("popoverWillShowInWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarItemClickedInWindow_ = "toolbarItemClickedInWindow:";

	private static readonly IntPtr selToolbarItemClickedInWindow_Handle = Selector.GetHandle("toolbarItemClickedInWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_ = "validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:";

	private static readonly IntPtr selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_Handle = Selector.GetHandle("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateToolbarItemInWindow_ValidationHandler_ = "validateToolbarItemInWindow:validationHandler:";

	private static readonly IntPtr selValidateToolbarItemInWindow_ValidationHandler_Handle = Selector.GetHandle("validateToolbarItemInWindow:validationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSafariExtensionHandler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual SFSafariExtensionViewController PopoverViewController
	{
		[Export("popoverViewController")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SFSafariExtensionViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selPopoverViewControllerHandle));
			}
			return Runtime.GetNSObject<SFSafariExtensionViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPopoverViewControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SFSafariExtensionHandler()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SFSafariExtensionHandler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSafariExtensionHandler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("additionalRequestHeadersForURL:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AdditionalRequestHeaders(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V77))] Action<NSDictionary<NSString, NSString>> completionHandler)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAdditionalRequestHeadersForURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAdditionalRequestHeadersForURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginRequestWithExtensionContext:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
	}

	[Export("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContentBlocker(string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
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
		IntPtr arg = NSString.CreateNative(contentBlockerIdentifier);
		NSArray nSArray = NSArray.FromNSObjects(urls);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_Handle, arg, nSArray.Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_Handle, arg, nSArray.Handle, page.Handle);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}

	[Export("contextMenuItemSelectedWithCommand:inPage:userInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContextMenuItemSelected(string command, SFSafariPage page, NSDictionary? userInfo)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		IntPtr arg = NSString.CreateNative(command);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selContextMenuItemSelectedWithCommand_InPage_UserInfo_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selContextMenuItemSelectedWithCommand_InPage_UserInfo_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("messageReceivedWithName:fromPage:userInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MessageReceived(string messageName, SFSafariPage page, NSDictionary? userInfo)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		IntPtr arg = NSString.CreateNative(messageName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selMessageReceivedWithName_FromPage_UserInfo_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMessageReceivedWithName_FromPage_UserInfo_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("messageReceivedFromContainingAppWithName:userInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MessageReceivedFromContainingApp(string messageName, NSDictionary<NSString, NSObject>? userInfo)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		IntPtr arg = NSString.CreateNative(messageName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMessageReceivedFromContainingAppWithName_UserInfo_Handle, arg, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMessageReceivedFromContainingAppWithName_UserInfo_Handle, arg, userInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("popoverDidCloseInWindow:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PopoverDidClose(SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPopoverDidCloseInWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPopoverDidCloseInWindow_Handle, window.Handle);
		}
	}

	[Export("popoverWillShowInWindow:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PopoverWillShow(SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPopoverWillShowInWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPopoverWillShowInWindow_Handle, window.Handle);
		}
	}

	[Export("toolbarItemClickedInWindow:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToolbarItemClicked(SFSafariWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToolbarItemClickedInWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarItemClickedInWindow_Handle, window.Handle);
		}
	}

	[Export("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ValidateContextMenuItem(string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy(typeof(Trampolines.NIDSFExtensionValidationHandler))] SFExtensionValidationHandler validationHandler)
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
		IntPtr arg = NSString.CreateNative(command);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSFExtensionValidationHandler.Handler, validationHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_Handle, arg, page.Handle, userInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFExtensionValidationResult> ValidateContextMenuItemAsync(string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo)
	{
		TaskCompletionSource<SFExtensionValidationResult> tcs = new TaskCompletionSource<SFExtensionValidationResult>();
		ValidateContextMenuItem(command, page, userInfo, delegate(bool shouldHide_, NSString text_)
		{
			tcs.SetResult(new SFExtensionValidationResult(shouldHide_, text_));
		});
		return tcs.Task;
	}

	[Export("validateToolbarItemInWindow:validationHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ValidateToolbarItem(SFSafariWindow window, [BlockProxy(typeof(Trampolines.NIDActionArity2V82))] Action<bool, NSString> validationHandler)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidateToolbarItemInWindow_ValidationHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidateToolbarItemInWindow_ValidationHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFValidationResult> ValidateToolbarItemAsync(SFSafariWindow window)
	{
		TaskCompletionSource<SFValidationResult> tcs = new TaskCompletionSource<SFValidationResult>();
		ValidateToolbarItem(window, delegate(bool arg1_, NSString arg2_)
		{
			tcs.SetResult(new SFValidationResult(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("page:willNavigateToURL:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillNavigate(SFSafariPage page, NSUrl? url)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPage_WillNavigateToURL_Handle, page.Handle, (url == null) ? IntPtr.Zero : url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPage_WillNavigateToURL_Handle, page.Handle, (url == null) ? IntPtr.Zero : url.Handle);
		}
	}
}
