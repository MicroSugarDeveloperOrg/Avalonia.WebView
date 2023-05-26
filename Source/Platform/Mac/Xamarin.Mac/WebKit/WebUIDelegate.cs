using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebUIDelegate", true)]
[Model]
public class WebUIDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebUIDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebUIDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebUIDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebUIDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("webView:createWebViewWithRequest:")]
	public virtual WebView UICreateWebView(WebView sender, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewShow:")]
	public virtual void UIShow(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:createWebViewModalDialogWithRequest:")]
	public virtual WebView UICreateModalDialog(WebView sender, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewRunModal:")]
	public virtual void UIRunModal(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewClose:")]
	public virtual void UIClose(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFocus:")]
	public virtual void UIFocus(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewUnfocus:")]
	public virtual void UIUnfocus(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFirstResponder:")]
	public virtual NSResponder UIGetFirstResponder(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:makeFirstResponder:")]
	public virtual void UIMakeFirstResponder(WebView sender, NSResponder newResponder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setStatusText:")]
	public virtual void UISetStatusText(WebView sender, string text)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewStatusText:")]
	public virtual string UIGetStatusText(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewAreToolbarsVisible:")]
	public virtual bool UIAreToolbarsVisible(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setToolbarsVisible:")]
	public virtual void UISetToolbarsVisible(WebView sender, bool visible)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewIsStatusBarVisible:")]
	public virtual bool UIIsStatusBarVisible(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setStatusBarVisible:")]
	public virtual void UISetStatusBarVisible(WebView sender, bool visible)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewIsResizable:")]
	public virtual bool UIIsResizable(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setResizable:")]
	public virtual void UISetResizable(WebView sender, bool resizable)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setFrame:")]
	public virtual void UISetFrame(WebView sender, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFrame:")]
	public virtual CGRect UIGetFrame(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
	public virtual void UIRunJavaScriptAlertPanelMessage(WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
	public virtual bool UIRunJavaScriptConfirmationPanel(WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
	public virtual string UIRunJavaScriptTextInputPanelWithFrame(WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
	public virtual bool UIRunBeforeUnload(WebView sender, string message, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runOpenPanelForFileButtonWithResultListener:")]
	public virtual void UIRunOpenPanelForFileButton(WebView sender, WebOpenPanelResultListener resultListener)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:mouseDidMoveOverElement:modifierFlags:")]
	public virtual void UIMouseDidMoveOverElement(WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:contextMenuItemsForElement:defaultMenuItems:")]
	public virtual NSMenuItem[] UIGetContextMenuItems(WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:validateUserInterfaceItem:defaultValidation:")]
	public virtual bool UIValidateUserInterfaceItem(WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:shouldPerformAction:fromSender:")]
	public virtual bool UIShouldPerformActionfromSender(WebView webView, Selector action, NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:dragDestinationActionMaskForDraggingInfo:")]
	public virtual NSEventModifierMask UIGetDragDestinationActionMask(WebView webView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformDragDestinationAction:forDraggingInfo:")]
	public virtual void UIWillPerformDragDestination(WebView webView, WebDragDestinationAction action, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:dragSourceActionMaskForPoint:")]
	public virtual NSEventModifierMask UIDragSourceActionMask(WebView webView, CGPoint point)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
	public virtual void UIWillPerformDragSource(WebView webView, WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:printFrameView:")]
	public virtual void UIPrintFrameView(WebView sender, WebFrameView frameView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewHeaderHeight:")]
	public virtual float UIGetHeaderHeight(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFooterHeight:")]
	public virtual float UIGetFooterHeight(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:drawHeaderInRect:")]
	public virtual void UIDrawHeaderInRect(WebView sender, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:drawFooterInRect:")]
	public virtual void UIDrawFooterInRect(WebView sender, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptAlertPanelWithMessage:")]
	public virtual void UIRunJavaScriptAlertPanel(WebView sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptConfirmPanelWithMessage:")]
	public virtual bool UIRunJavaScriptConfirmPanel(WebView sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
	public virtual string UIRunJavaScriptTextInputPanel(WebView sender, string prompt, string defaultText)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setContentRect:")]
	public virtual void UISetContentRect(WebView sender, CGRect frame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewContentRect:")]
	public virtual CGRect UIGetContentRect(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
