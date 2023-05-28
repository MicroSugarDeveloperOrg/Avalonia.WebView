using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol]
[Register("WebUIDelegate", false)]
[Model]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebUIDelegate : NSObject, IWebUIDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebUIDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebUIDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebUIDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webViewAreToolbarsVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIAreToolbarsVisible(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIClose(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:createWebViewModalDialogWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebView UICreateModalDialog(WebView sender, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:createWebViewWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebView UICreateWebView(WebView sender, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:dragSourceActionMaskForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEventModifierMask UIDragSourceActionMask(WebView webView, CGPoint point)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:drawFooterInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIDrawFooterInRect(WebView sender, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:drawHeaderInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIDrawHeaderInRect(WebView sender, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFocus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIFocus(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewContentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect UIGetContentRect(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:contextMenuItemsForElement:defaultMenuItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem[] UIGetContextMenuItems(WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:dragDestinationActionMaskForDraggingInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEventModifierMask UIGetDragDestinationActionMask(WebView webView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFirstResponder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSResponder UIGetFirstResponder(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFooterHeight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float UIGetFooterHeight(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect UIGetFrame(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewHeaderHeight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float UIGetHeaderHeight(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewStatusText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UIGetStatusText(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewIsResizable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIIsResizable(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewIsStatusBarVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIIsStatusBarVisible(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:makeFirstResponder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIMakeFirstResponder(WebView sender, NSResponder newResponder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:mouseDidMoveOverElement:modifierFlags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIMouseDidMoveOverElement(WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:printFrameView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIPrintFrameView(WebView sender, WebFrameView frameView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIRunBeforeUnload(WebView sender, string message, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptAlertPanelWithMessage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIRunJavaScriptAlertPanel(WebView sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIRunJavaScriptAlertPanelMessage(WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptConfirmPanelWithMessage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIRunJavaScriptConfirmPanel(WebView sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIRunJavaScriptConfirmationPanel(WebView sender, string withMessage, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UIRunJavaScriptTextInputPanel(WebView sender, string prompt, string defaultText)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UIRunJavaScriptTextInputPanelWithFrame(WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewRunModal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIRunModal(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runOpenPanelForFileButtonWithResultListener:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIRunOpenPanelForFileButton(WebView sender, IWebOpenPanelResultListener resultListener)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setContentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetContentRect(WebView sender, CGRect frame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetFrame(WebView sender, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setResizable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetResizable(WebView sender, bool resizable)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setStatusBarVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetStatusBarVisible(WebView sender, bool visible)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setStatusText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetStatusText(WebView sender, string text)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:setToolbarsVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UISetToolbarsVisible(WebView sender, bool visible)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:shouldPerformAction:fromSender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIShouldPerformActionfromSender(WebView webView, Selector action, NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewShow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIShow(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewUnfocus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIUnfocus(WebView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:validateUserInterfaceItem:defaultValidation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UIValidateUserInterfaceItem(WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformDragDestinationAction:forDraggingInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIWillPerformDragDestination(WebView webView, WebDragDestinationAction action, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UIWillPerformDragSource(WebView webView, WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
