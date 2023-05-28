using System;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

public static class WebUIDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WebView UICreateWebView(this IWebUIDelegate This, WebView sender, NSUrlRequest request)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Runtime.GetNSObject<WebView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:createWebViewWithRequest:"), sender.Handle, request.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIShow(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewShow:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WebView UICreateModalDialog(this IWebUIDelegate This, WebView sender, NSUrlRequest request)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Runtime.GetNSObject<WebView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:createWebViewModalDialogWithRequest:"), sender.Handle, request.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIRunModal(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewRunModal:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIClose(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewClose:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIFocus(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewFocus:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIUnfocus(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewUnfocus:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSResponder UIGetFirstResponder(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewFirstResponder:"), sender.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIMakeFirstResponder(this IWebUIDelegate This, WebView sender, NSResponder newResponder)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (newResponder == null)
		{
			throw new ArgumentNullException("newResponder");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:makeFirstResponder:"), sender.Handle, newResponder.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetStatusText(this IWebUIDelegate This, WebView sender, string text)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr intPtr = NSString.CreateNative(text);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:setStatusText:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string UIGetStatusText(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewStatusText:"), sender.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIAreToolbarsVisible(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewAreToolbarsVisible:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetToolbarsVisible(this IWebUIDelegate This, WebView sender, bool visible)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("webView:setToolbarsVisible:"), sender.Handle, visible);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIIsStatusBarVisible(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewIsStatusBarVisible:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetStatusBarVisible(this IWebUIDelegate This, WebView sender, bool visible)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("webView:setStatusBarVisible:"), sender.Handle, visible);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIIsResizable(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewIsResizable:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetResizable(this IWebUIDelegate This, WebView sender, bool resizable)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("webView:setResizable:"), sender.Handle, resizable);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetFrame(this IWebUIDelegate This, WebView sender, CGRect newFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("webView:setFrame:"), sender.Handle, newFrame);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect UIGetFrame(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr(out var retval, This.Handle, Selector.GetHandle("webViewFrame:"), sender.Handle);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIRunJavaScriptAlertPanelMessage(this IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (withMessage == null)
		{
			throw new ArgumentNullException("withMessage");
		}
		if (initiatedByFrame == null)
		{
			throw new ArgumentNullException("initiatedByFrame");
		}
		IntPtr intPtr = NSString.CreateNative(withMessage);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:"), sender.Handle, intPtr, initiatedByFrame.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIRunJavaScriptConfirmationPanel(this IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (withMessage == null)
		{
			throw new ArgumentNullException("withMessage");
		}
		if (initiatedByFrame == null)
		{
			throw new ArgumentNullException("initiatedByFrame");
		}
		IntPtr intPtr = NSString.CreateNative(withMessage);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:"), sender.Handle, intPtr, initiatedByFrame.Handle);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string UIRunJavaScriptTextInputPanelWithFrame(this IWebUIDelegate This, WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (prompt == null)
		{
			throw new ArgumentNullException("prompt");
		}
		if (defaultText == null)
		{
			throw new ArgumentNullException("defaultText");
		}
		if (initiatedByFrame == null)
		{
			throw new ArgumentNullException("initiatedByFrame");
		}
		IntPtr intPtr = NSString.CreateNative(prompt);
		IntPtr intPtr2 = NSString.CreateNative(defaultText);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:"), sender.Handle, intPtr, intPtr2, initiatedByFrame.Handle));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIRunBeforeUnload(this IWebUIDelegate This, WebView sender, string message, WebFrame initiatedByFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (initiatedByFrame == null)
		{
			throw new ArgumentNullException("initiatedByFrame");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:"), sender.Handle, intPtr, initiatedByFrame.Handle);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIRunOpenPanelForFileButton(this IWebUIDelegate This, WebView sender, IWebOpenPanelResultListener resultListener)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (resultListener == null)
		{
			throw new ArgumentNullException("resultListener");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runOpenPanelForFileButtonWithResultListener:"), sender.Handle, resultListener.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIMouseDidMoveOverElement(this IWebUIDelegate This, WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (elementInformation == null)
		{
			throw new ArgumentNullException("elementInformation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(This.Handle, Selector.GetHandle("webView:mouseDidMoveOverElement:modifierFlags:"), sender.Handle, elementInformation.Handle, (ulong)modifierFlags);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenuItem[] UIGetContextMenuItems(this IWebUIDelegate This, WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forElement == null)
		{
			throw new ArgumentNullException("forElement");
		}
		if (defaultMenuItems == null)
		{
			throw new ArgumentNullException("defaultMenuItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(defaultMenuItems);
		NSMenuItem[] result = NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:contextMenuItemsForElement:defaultMenuItems:"), sender.Handle, forElement.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIValidateUserInterfaceItem(this IWebUIDelegate This, WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (validatedUserInterfaceItem == null)
		{
			throw new ArgumentNullException("validatedUserInterfaceItem");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("webView:validateUserInterfaceItem:defaultValidation:"), webView.Handle, validatedUserInterfaceItem.Handle, defaultValidation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIShouldPerformActionfromSender(this IWebUIDelegate This, WebView webView, Selector action, NSObject sender)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:shouldPerformAction:fromSender:"), webView.Handle, action.Handle, sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEventModifierMask UIGetDragDestinationActionMask(this IWebUIDelegate This, WebView webView, NSDraggingInfo draggingInfo)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		return (NSEventModifierMask)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:dragDestinationActionMaskForDraggingInfo:"), webView.Handle, draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIWillPerformDragDestination(this IWebUIDelegate This, WebView webView, WebDragDestinationAction action, NSDraggingInfo draggingInfo)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(This.Handle, Selector.GetHandle("webView:willPerformDragDestinationAction:forDraggingInfo:"), webView.Handle, (ulong)action, draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEventModifierMask UIDragSourceActionMask(this IWebUIDelegate This, WebView webView, CGPoint point)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		return (NSEventModifierMask)Messaging.UInt64_objc_msgSend_IntPtr_CGPoint(This.Handle, Selector.GetHandle("webView:dragSourceActionMaskForPoint:"), webView.Handle, point);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIWillPerformDragSource(this IWebUIDelegate This, WebView webView, WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64_CGPoint_IntPtr(This.Handle, Selector.GetHandle("webView:willPerformDragSourceAction:fromPoint:withPasteboard:"), webView.Handle, (ulong)action, sourcePoint, pasteboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIPrintFrameView(this IWebUIDelegate This, WebView sender, WebFrameView frameView)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (frameView == null)
		{
			throw new ArgumentNullException("frameView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:printFrameView:"), sender.Handle, frameView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static float UIGetHeaderHeight(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.float_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewHeaderHeight:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static float UIGetFooterHeight(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.float_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewFooterHeight:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIDrawHeaderInRect(this IWebUIDelegate This, WebView sender, CGRect rect)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("webView:drawHeaderInRect:"), sender.Handle, rect);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIDrawFooterInRect(this IWebUIDelegate This, WebView sender, CGRect rect)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("webView:drawFooterInRect:"), sender.Handle, rect);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UIRunJavaScriptAlertPanel(this IWebUIDelegate This, WebView sender, string message)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptAlertPanelWithMessage:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UIRunJavaScriptConfirmPanel(this IWebUIDelegate This, WebView sender, string message)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptConfirmPanelWithMessage:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string UIRunJavaScriptTextInputPanel(this IWebUIDelegate This, WebView sender, string prompt, string defaultText)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (prompt == null)
		{
			throw new ArgumentNullException("prompt");
		}
		if (defaultText == null)
		{
			throw new ArgumentNullException("defaultText");
		}
		IntPtr intPtr = NSString.CreateNative(prompt);
		IntPtr intPtr2 = NSString.CreateNative(defaultText);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:"), sender.Handle, intPtr, intPtr2));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UISetContentRect(this IWebUIDelegate This, WebView sender, CGRect frame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("webView:setContentRect:"), sender.Handle, frame);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect UIGetContentRect(this IWebUIDelegate This, WebView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr(out var retval, This.Handle, Selector.GetHandle("webViewContentRect:"), sender.Handle);
		return retval;
	}
}
