using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebView", true)]
public class WebView : NSView
{
	[Register]
	private sealed class _WebFrameLoadDelegate : WebFrameLoadDelegate
	{
		internal EventHandler<WebFrameEventArgs> startedProvisionalLoad;

		internal EventHandler<WebFrameEventArgs> receivedServerRedirectForProvisionalLoad;

		internal EventHandler<WebFrameErrorEventArgs> failedProvisionalLoad;

		internal EventHandler<WebFrameEventArgs> commitedLoad;

		internal EventHandler<WebFrameTitleEventArgs> receivedTitle;

		internal EventHandler<WebFrameImageEventArgs> receivedIcon;

		internal EventHandler<WebFrameEventArgs> finishedLoad;

		internal EventHandler<WebFrameErrorEventArgs> failedLoadWithError;

		internal EventHandler<WebFrameEventArgs> changedLocationWithinPage;

		internal EventHandler<WebFrameClientRedirectEventArgs> willPerformClientRedirect;

		internal EventHandler<WebFrameEventArgs> canceledClientRedirect;

		internal EventHandler<WebFrameEventArgs> willCloseFrame;

		internal EventHandler<WebFrameScriptFrameEventArgs> clearedWindowObject;

		internal EventHandler<WebFrameScriptObjectEventArgs> windowScriptObjectAvailable;

		[Preserve(Conditional = true)]
		public override void StartedProvisionalLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = startedProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ReceivedServerRedirectForProvisionalLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = receivedServerRedirectForProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void FailedProvisionalLoad(WebView sender, NSError error, WebFrame forFrame)
		{
			EventHandler<WebFrameErrorEventArgs> eventHandler = failedProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameErrorEventArgs e = new WebFrameErrorEventArgs(error, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void CommitedLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = commitedLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ReceivedTitle(WebView sender, string title, WebFrame forFrame)
		{
			EventHandler<WebFrameTitleEventArgs> eventHandler = receivedTitle;
			if (eventHandler != null)
			{
				WebFrameTitleEventArgs e = new WebFrameTitleEventArgs(title, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ReceivedIcon(WebView sender, NSImage image, WebFrame forFrame)
		{
			EventHandler<WebFrameImageEventArgs> eventHandler = receivedIcon;
			if (eventHandler != null)
			{
				WebFrameImageEventArgs e = new WebFrameImageEventArgs(image, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void FinishedLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = finishedLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void FailedLoadWithError(WebView sender, NSError error, WebFrame forFrame)
		{
			EventHandler<WebFrameErrorEventArgs> eventHandler = failedLoadWithError;
			if (eventHandler != null)
			{
				WebFrameErrorEventArgs e = new WebFrameErrorEventArgs(error, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ChangedLocationWithinPage(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = changedLocationWithinPage;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillPerformClientRedirect(WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			EventHandler<WebFrameClientRedirectEventArgs> eventHandler = willPerformClientRedirect;
			if (eventHandler != null)
			{
				WebFrameClientRedirectEventArgs e = new WebFrameClientRedirectEventArgs(toUrl, secondsDelay, fireDate, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void CanceledClientRedirect(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = canceledClientRedirect;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillCloseFrame(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = willCloseFrame;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ClearedWindowObject(WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			EventHandler<WebFrameScriptFrameEventArgs> eventHandler = clearedWindowObject;
			if (eventHandler != null)
			{
				WebFrameScriptFrameEventArgs e = new WebFrameScriptFrameEventArgs(windowObject, forFrame);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WindowScriptObjectAvailable(WebView webView, WebScriptObject windowScriptObject)
		{
			EventHandler<WebFrameScriptObjectEventArgs> eventHandler = windowScriptObjectAvailable;
			if (eventHandler != null)
			{
				WebFrameScriptObjectEventArgs e = new WebFrameScriptObjectEventArgs(windowScriptObject);
				eventHandler(webView, e);
			}
		}
	}

	[Register]
	private sealed class _WebDownloadDelegate : WebDownloadDelegate
	{
		internal WebDownloadRequest onDownloadWindowForSheet;

		[Preserve(Conditional = true)]
		public override NSWindow OnDownloadWindowForSheet(WebDownload download)
		{
			return onDownloadWindowForSheet?.Invoke(download);
		}
	}

	[Register]
	private sealed class _WebResourceLoadDelegate : WebResourceLoadDelegate
	{
		internal WebResourceIdentifierRequest onIdentifierForInitialRequest;

		internal WebResourceOnRequestSend onSendRequest;

		internal EventHandler<WebResourceAuthenticationChallengeEventArgs> onReceivedAuthenticationChallenge;

		internal EventHandler<WebResourceCancelledChallengeEventArgs> onCancelledAuthenticationChallenge;

		internal EventHandler<WebResourceReceivedResponseEventArgs> onReceivedResponse;

		internal EventHandler<WebResourceReceivedContentLengthEventArgs> onReceivedContentLength;

		internal EventHandler<WebResourceCompletedEventArgs> onFinishedLoading;

		internal EventHandler<WebResourceErrorEventArgs> onFailedLoading;

		internal EventHandler<WebResourcePluginErrorEventArgs> onPlugInFailed;

		[Preserve(Conditional = true)]
		public override NSObject OnIdentifierForInitialRequest(WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			return onIdentifierForInitialRequest?.Invoke(sender, request, dataSource);
		}

		[Preserve(Conditional = true)]
		public override NSUrlRequest OnSendRequest(WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			WebResourceOnRequestSend webResourceOnRequestSend = onSendRequest;
			if (webResourceOnRequestSend != null)
			{
				return webResourceOnRequestSend(sender, identifier, request, redirectResponse, dataSource);
			}
			return request;
		}

		[Preserve(Conditional = true)]
		public override void OnReceivedAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			EventHandler<WebResourceAuthenticationChallengeEventArgs> eventHandler = onReceivedAuthenticationChallenge;
			if (eventHandler != null)
			{
				WebResourceAuthenticationChallengeEventArgs e = new WebResourceAuthenticationChallengeEventArgs(identifier, challenge, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnCancelledAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			EventHandler<WebResourceCancelledChallengeEventArgs> eventHandler = onCancelledAuthenticationChallenge;
			if (eventHandler != null)
			{
				WebResourceCancelledChallengeEventArgs e = new WebResourceCancelledChallengeEventArgs(identifier, challenge, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnReceivedResponse(WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			EventHandler<WebResourceReceivedResponseEventArgs> eventHandler = onReceivedResponse;
			if (eventHandler != null)
			{
				WebResourceReceivedResponseEventArgs e = new WebResourceReceivedResponseEventArgs(identifier, responseReceived, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnReceivedContentLength(WebView sender, NSObject identifier, int length, WebDataSource dataSource)
		{
			EventHandler<WebResourceReceivedContentLengthEventArgs> eventHandler = onReceivedContentLength;
			if (eventHandler != null)
			{
				WebResourceReceivedContentLengthEventArgs e = new WebResourceReceivedContentLengthEventArgs(identifier, length, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnFinishedLoading(WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			EventHandler<WebResourceCompletedEventArgs> eventHandler = onFinishedLoading;
			if (eventHandler != null)
			{
				WebResourceCompletedEventArgs e = new WebResourceCompletedEventArgs(identifier, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnFailedLoading(WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			EventHandler<WebResourceErrorEventArgs> eventHandler = onFailedLoading;
			if (eventHandler != null)
			{
				WebResourceErrorEventArgs e = new WebResourceErrorEventArgs(identifier, withError, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void OnPlugInFailed(WebView sender, NSError error, WebDataSource dataSource)
		{
			EventHandler<WebResourcePluginErrorEventArgs> eventHandler = onPlugInFailed;
			if (eventHandler != null)
			{
				WebResourcePluginErrorEventArgs e = new WebResourcePluginErrorEventArgs(error, dataSource);
				eventHandler(sender, e);
			}
		}
	}

	[Register]
	private sealed class _WebUIDelegate : WebUIDelegate
	{
		internal CreateWebViewFromRequest uICreateWebView;

		internal EventHandler uIShow;

		internal WebViewCreate uICreateModalDialog;

		internal EventHandler uIRunModal;

		internal EventHandler uIClose;

		internal EventHandler uIFocus;

		internal EventHandler uIUnfocus;

		internal WebViewGetResponder uIGetFirstResponder;

		internal EventHandler<WebViewResponderEventArgs> uIMakeFirstResponder;

		internal EventHandler<WebViewStatusTextEventArgs> uISetStatusText;

		internal WebViewGetString uIGetStatusText;

		internal WebViewGetBool uIAreToolbarsVisible;

		internal EventHandler<WebViewToolBarsEventArgs> uISetToolbarsVisible;

		internal WebViewGetBool uIIsStatusBarVisible;

		internal EventHandler<WebViewStatusBarEventArgs> uISetStatusBarVisible;

		internal WebViewGetBool uIIsResizable;

		internal EventHandler<WebViewResizableEventArgs> uISetResizable;

		internal EventHandler<WebViewFrameEventArgs> uISetFrame;

		internal WebViewGetRectangle uIGetFrame;

		internal EventHandler<WebViewJavaScriptFrameEventArgs> uIRunJavaScriptAlertPanelMessage;

		internal WebViewConfirmationPanel uIRunJavaScriptConfirmationPanel;

		internal WebViewPromptPanel uIRunJavaScriptTextInputPanelWithFrame;

		internal WebViewJavaScriptFrame uIRunBeforeUnload;

		internal EventHandler<WebViewRunOpenPanelEventArgs> uIRunOpenPanelForFileButton;

		internal EventHandler<WebViewMouseMovedEventArgs> uIMouseDidMoveOverElement;

		internal WebViewGetContextMenuItems uIGetContextMenuItems;

		internal WebViewValidateUserInterface uIValidateUserInterfaceItem;

		internal WebViewPerformAction uIShouldPerformActionfromSender;

		internal DragDestinationGetActionMask uIGetDragDestinationActionMask;

		internal EventHandler<WebViewDragEventArgs> uIWillPerformDragDestination;

		internal DragSourceGetActionMask uIDragSourceActionMask;

		internal EventHandler<WebViewPerformDragEventArgs> uIWillPerformDragSource;

		internal EventHandler<WebViewPrintEventArgs> uIPrintFrameView;

		internal WebViewGetFloat uIGetHeaderHeight;

		internal WebViewGetFloat uIGetFooterHeight;

		internal EventHandler<WebViewHeaderEventArgs> uIDrawHeaderInRect;

		internal EventHandler<WebViewFooterEventArgs> uIDrawFooterInRect;

		internal EventHandler<WebViewJavaScriptEventArgs> uIRunJavaScriptAlertPanel;

		internal WebViewPrompt uIRunJavaScriptConfirmPanel;

		internal WebViewJavaScriptInput uIRunJavaScriptTextInputPanel;

		internal EventHandler<WebViewContentEventArgs> uISetContentRect;

		internal WebViewGetRectangle uIGetContentRect;

		[Preserve(Conditional = true)]
		public override WebView UICreateWebView(WebView sender, NSUrlRequest request)
		{
			return uICreateWebView?.Invoke(sender, request);
		}

		[Preserve(Conditional = true)]
		public override void UIShow(WebView sender)
		{
			uIShow?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override WebView UICreateModalDialog(WebView sender, NSUrlRequest request)
		{
			return uICreateModalDialog?.Invoke(sender, request);
		}

		[Preserve(Conditional = true)]
		public override void UIRunModal(WebView sender)
		{
			uIRunModal?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void UIClose(WebView sender)
		{
			uIClose?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void UIFocus(WebView sender)
		{
			uIFocus?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void UIUnfocus(WebView sender)
		{
			uIUnfocus?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override NSResponder UIGetFirstResponder(WebView sender)
		{
			return uIGetFirstResponder?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		public override void UIMakeFirstResponder(WebView sender, NSResponder newResponder)
		{
			EventHandler<WebViewResponderEventArgs> eventHandler = uIMakeFirstResponder;
			if (eventHandler != null)
			{
				WebViewResponderEventArgs e = new WebViewResponderEventArgs(newResponder);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UISetStatusText(WebView sender, string text)
		{
			EventHandler<WebViewStatusTextEventArgs> eventHandler = uISetStatusText;
			if (eventHandler != null)
			{
				WebViewStatusTextEventArgs e = new WebViewStatusTextEventArgs(text);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override string UIGetStatusText(WebView sender)
		{
			return uIGetStatusText?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		public override bool UIAreToolbarsVisible(WebView sender)
		{
			WebViewGetBool webViewGetBool = uIAreToolbarsVisible;
			if (webViewGetBool != null)
			{
				return webViewGetBool(sender);
			}
			throw new Exception("No event handler has been added to the UIAreToolbarsVisible event.");
		}

		[Preserve(Conditional = true)]
		public override void UISetToolbarsVisible(WebView sender, bool visible)
		{
			EventHandler<WebViewToolBarsEventArgs> eventHandler = uISetToolbarsVisible;
			if (eventHandler != null)
			{
				WebViewToolBarsEventArgs e = new WebViewToolBarsEventArgs(visible);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool UIIsStatusBarVisible(WebView sender)
		{
			return uIIsStatusBarVisible?.Invoke(sender) ?? false;
		}

		[Preserve(Conditional = true)]
		public override void UISetStatusBarVisible(WebView sender, bool visible)
		{
			EventHandler<WebViewStatusBarEventArgs> eventHandler = uISetStatusBarVisible;
			if (eventHandler != null)
			{
				WebViewStatusBarEventArgs e = new WebViewStatusBarEventArgs(visible);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool UIIsResizable(WebView sender)
		{
			WebViewGetBool webViewGetBool = uIIsResizable;
			if (webViewGetBool != null)
			{
				return webViewGetBool(sender);
			}
			throw new Exception("No event handler has been added to the UIIsResizable event.");
		}

		[Preserve(Conditional = true)]
		public override void UISetResizable(WebView sender, bool resizable)
		{
			EventHandler<WebViewResizableEventArgs> eventHandler = uISetResizable;
			if (eventHandler != null)
			{
				WebViewResizableEventArgs e = new WebViewResizableEventArgs(resizable);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UISetFrame(WebView sender, CGRect newFrame)
		{
			EventHandler<WebViewFrameEventArgs> eventHandler = uISetFrame;
			if (eventHandler != null)
			{
				WebViewFrameEventArgs e = new WebViewFrameEventArgs(newFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override CGRect UIGetFrame(WebView sender)
		{
			WebViewGetRectangle webViewGetRectangle = uIGetFrame;
			if (webViewGetRectangle != null)
			{
				return webViewGetRectangle(sender);
			}
			throw new Exception("No event handler has been added to the UIGetFrame event.");
		}

		[Preserve(Conditional = true)]
		public override void UIRunJavaScriptAlertPanelMessage(WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			EventHandler<WebViewJavaScriptFrameEventArgs> eventHandler = uIRunJavaScriptAlertPanelMessage;
			if (eventHandler != null)
			{
				WebViewJavaScriptFrameEventArgs e = new WebViewJavaScriptFrameEventArgs(withMessage, initiatedByFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool UIRunJavaScriptConfirmationPanel(WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			WebViewConfirmationPanel webViewConfirmationPanel = uIRunJavaScriptConfirmationPanel;
			if (webViewConfirmationPanel != null)
			{
				return webViewConfirmationPanel(sender, withMessage, initiatedByFrame);
			}
			throw new Exception("No event handler has been added to the UIRunJavaScriptConfirmationPanel event.");
		}

		[Preserve(Conditional = true)]
		public override string UIRunJavaScriptTextInputPanelWithFrame(WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			return uIRunJavaScriptTextInputPanelWithFrame?.Invoke(sender, prompt, defaultText, initiatedByFrame);
		}

		[Preserve(Conditional = true)]
		public override bool UIRunBeforeUnload(WebView sender, string message, WebFrame initiatedByFrame)
		{
			WebViewJavaScriptFrame webViewJavaScriptFrame = uIRunBeforeUnload;
			if (webViewJavaScriptFrame != null)
			{
				return webViewJavaScriptFrame(sender, message, initiatedByFrame);
			}
			throw new Exception("No event handler has been added to the UIRunBeforeUnload event.");
		}

		[Preserve(Conditional = true)]
		public override void UIRunOpenPanelForFileButton(WebView sender, WebOpenPanelResultListener resultListener)
		{
			EventHandler<WebViewRunOpenPanelEventArgs> eventHandler = uIRunOpenPanelForFileButton;
			if (eventHandler != null)
			{
				WebViewRunOpenPanelEventArgs e = new WebViewRunOpenPanelEventArgs(resultListener);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UIMouseDidMoveOverElement(WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
		{
			EventHandler<WebViewMouseMovedEventArgs> eventHandler = uIMouseDidMoveOverElement;
			if (eventHandler != null)
			{
				WebViewMouseMovedEventArgs e = new WebViewMouseMovedEventArgs(elementInformation, modifierFlags);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override NSMenuItem[] UIGetContextMenuItems(WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
		{
			return uIGetContextMenuItems?.Invoke(sender, forElement, defaultMenuItems);
		}

		[Preserve(Conditional = true)]
		public override bool UIValidateUserInterfaceItem(WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			return uIValidateUserInterfaceItem?.Invoke(webView, validatedUserInterfaceItem, defaultValidation) ?? defaultValidation;
		}

		[Preserve(Conditional = true)]
		public override bool UIShouldPerformActionfromSender(WebView webView, Selector action, NSObject sender)
		{
			WebViewPerformAction webViewPerformAction = uIShouldPerformActionfromSender;
			if (webViewPerformAction != null)
			{
				return webViewPerformAction(webView, action, sender);
			}
			throw new Exception("No event handler has been added to the UIShouldPerformActionfromSender event.");
		}

		[Preserve(Conditional = true)]
		public override NSEventModifierMask UIGetDragDestinationActionMask(WebView webView, NSDraggingInfo draggingInfo)
		{
			return uIGetDragDestinationActionMask?.Invoke(webView, draggingInfo) ?? ((NSEventModifierMask)0uL);
		}

		[Preserve(Conditional = true)]
		public override void UIWillPerformDragDestination(WebView webView, WebDragDestinationAction action, NSDraggingInfo draggingInfo)
		{
			EventHandler<WebViewDragEventArgs> eventHandler = uIWillPerformDragDestination;
			if (eventHandler != null)
			{
				WebViewDragEventArgs e = new WebViewDragEventArgs(action, draggingInfo);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override NSEventModifierMask UIDragSourceActionMask(WebView webView, CGPoint point)
		{
			return uIDragSourceActionMask?.Invoke(webView, point) ?? ((NSEventModifierMask)0uL);
		}

		[Preserve(Conditional = true)]
		public override void UIWillPerformDragSource(WebView webView, WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
		{
			EventHandler<WebViewPerformDragEventArgs> eventHandler = uIWillPerformDragSource;
			if (eventHandler != null)
			{
				WebViewPerformDragEventArgs e = new WebViewPerformDragEventArgs(action, sourcePoint, pasteboard);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UIPrintFrameView(WebView sender, WebFrameView frameView)
		{
			EventHandler<WebViewPrintEventArgs> eventHandler = uIPrintFrameView;
			if (eventHandler != null)
			{
				WebViewPrintEventArgs e = new WebViewPrintEventArgs(frameView);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override float UIGetHeaderHeight(WebView sender)
		{
			WebViewGetFloat webViewGetFloat = uIGetHeaderHeight;
			if (webViewGetFloat != null)
			{
				return webViewGetFloat(sender);
			}
			throw new Exception("No event handler has been added to the UIGetHeaderHeight event.");
		}

		[Preserve(Conditional = true)]
		public override float UIGetFooterHeight(WebView sender)
		{
			WebViewGetFloat webViewGetFloat = uIGetFooterHeight;
			if (webViewGetFloat != null)
			{
				return webViewGetFloat(sender);
			}
			throw new Exception("No event handler has been added to the UIGetFooterHeight event.");
		}

		[Preserve(Conditional = true)]
		public override void UIDrawHeaderInRect(WebView sender, CGRect rect)
		{
			EventHandler<WebViewHeaderEventArgs> eventHandler = uIDrawHeaderInRect;
			if (eventHandler != null)
			{
				WebViewHeaderEventArgs e = new WebViewHeaderEventArgs(rect);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UIDrawFooterInRect(WebView sender, CGRect rect)
		{
			EventHandler<WebViewFooterEventArgs> eventHandler = uIDrawFooterInRect;
			if (eventHandler != null)
			{
				WebViewFooterEventArgs e = new WebViewFooterEventArgs(rect);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UIRunJavaScriptAlertPanel(WebView sender, string message)
		{
			EventHandler<WebViewJavaScriptEventArgs> eventHandler = uIRunJavaScriptAlertPanel;
			if (eventHandler != null)
			{
				WebViewJavaScriptEventArgs e = new WebViewJavaScriptEventArgs(message);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool UIRunJavaScriptConfirmPanel(WebView sender, string message)
		{
			WebViewPrompt webViewPrompt = uIRunJavaScriptConfirmPanel;
			if (webViewPrompt != null)
			{
				return webViewPrompt(sender, message);
			}
			throw new Exception("No event handler has been added to the UIRunJavaScriptConfirmPanel event.");
		}

		[Preserve(Conditional = true)]
		public override string UIRunJavaScriptTextInputPanel(WebView sender, string prompt, string defaultText)
		{
			return uIRunJavaScriptTextInputPanel?.Invoke(sender, prompt, defaultText);
		}

		[Preserve(Conditional = true)]
		public override void UISetContentRect(WebView sender, CGRect frame)
		{
			EventHandler<WebViewContentEventArgs> eventHandler = uISetContentRect;
			if (eventHandler != null)
			{
				WebViewContentEventArgs e = new WebViewContentEventArgs(frame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override CGRect UIGetContentRect(WebView sender)
		{
			WebViewGetRectangle webViewGetRectangle = uIGetContentRect;
			if (webViewGetRectangle != null)
			{
				return webViewGetRectangle(sender);
			}
			throw new Exception("No event handler has been added to the UIGetContentRect event.");
		}
	}

	[Register]
	private sealed class _WebPolicyDelegate : WebPolicyDelegate
	{
		internal EventHandler<WebNavigationPolicyEventArgs> decidePolicyForNavigation;

		internal EventHandler<WebNewWindowPolicyEventArgs> decidePolicyForNewWindow;

		internal EventHandler<WebMimeTypePolicyEventArgs> decidePolicyForMimeType;

		internal EventHandler<WebFailureToImplementPolicyEventArgs> unableToImplementPolicy;

		[Preserve(Conditional = true)]
		public override void DecidePolicyForNavigation(WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			EventHandler<WebNavigationPolicyEventArgs> eventHandler = decidePolicyForNavigation;
			if (eventHandler != null)
			{
				WebNavigationPolicyEventArgs e = new WebNavigationPolicyEventArgs(actionInformation, request, frame, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DecidePolicyForNewWindow(WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			EventHandler<WebNewWindowPolicyEventArgs> eventHandler = decidePolicyForNewWindow;
			if (eventHandler != null)
			{
				WebNewWindowPolicyEventArgs e = new WebNewWindowPolicyEventArgs(actionInformation, request, newFrameName, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DecidePolicyForMimeType(WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			EventHandler<WebMimeTypePolicyEventArgs> eventHandler = decidePolicyForMimeType;
			if (eventHandler != null)
			{
				WebMimeTypePolicyEventArgs e = new WebMimeTypePolicyEventArgs(mimeType, request, frame, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void UnableToImplementPolicy(WebView webView, NSError error, WebFrame frame)
		{
			EventHandler<WebFailureToImplementPolicyEventArgs> eventHandler = unableToImplementPolicy;
			if (eventHandler != null)
			{
				WebFailureToImplementPolicyEventArgs e = new WebFailureToImplementPolicyEventArgs(error, frame);
				eventHandler(webView, e);
			}
		}
	}

	private static IntPtr selUse = Selector.GetHandle("use");

	private static IntPtr selDownload = Selector.GetHandle("download");

	private static IntPtr selIgnore = Selector.GetHandle("ignore");

	private static readonly IntPtr selMIMETypesShownAsHTMLHandle = Selector.GetHandle("MIMETypesShownAsHTML");

	private static readonly IntPtr selSetMIMETypesShownAsHTML_Handle = Selector.GetHandle("setMIMETypesShownAsHTML:");

	private static readonly IntPtr selMainFrameHandle = Selector.GetHandle("mainFrame");

	private static readonly IntPtr selSelectedFrameHandle = Selector.GetHandle("selectedFrame");

	private static readonly IntPtr selBackForwardListHandle = Selector.GetHandle("backForwardList");

	private static readonly IntPtr selSupportsTextEncodingHandle = Selector.GetHandle("supportsTextEncoding");

	private static readonly IntPtr selWindowScriptObjectHandle = Selector.GetHandle("windowScriptObject");

	private static readonly IntPtr selEstimatedProgressHandle = Selector.GetHandle("estimatedProgress");

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	private static readonly IntPtr selPasteboardTypesForSelectionHandle = Selector.GetHandle("pasteboardTypesForSelection");

	private static readonly IntPtr selMainFrameDocumentHandle = Selector.GetHandle("mainFrameDocument");

	private static readonly IntPtr selMainFrameTitleHandle = Selector.GetHandle("mainFrameTitle");

	private static readonly IntPtr selMainFrameIconHandle = Selector.GetHandle("mainFrameIcon");

	private static readonly IntPtr selShouldCloseWithWindowHandle = Selector.GetHandle("shouldCloseWithWindow");

	private static readonly IntPtr selSetShouldCloseWithWindow_Handle = Selector.GetHandle("setShouldCloseWithWindow:");

	private static readonly IntPtr selResourceLoadDelegateHandle = Selector.GetHandle("resourceLoadDelegate");

	private static readonly IntPtr selSetResourceLoadDelegate_Handle = Selector.GetHandle("setResourceLoadDelegate:");

	private static readonly IntPtr selDownloadDelegateHandle = Selector.GetHandle("downloadDelegate");

	private static readonly IntPtr selSetDownloadDelegate_Handle = Selector.GetHandle("setDownloadDelegate:");

	private static readonly IntPtr selFrameLoadDelegateHandle = Selector.GetHandle("frameLoadDelegate");

	private static readonly IntPtr selSetFrameLoadDelegate_Handle = Selector.GetHandle("setFrameLoadDelegate:");

	private static readonly IntPtr selUIDelegateHandle = Selector.GetHandle("UIDelegate");

	private static readonly IntPtr selSetUIDelegate_Handle = Selector.GetHandle("setUIDelegate:");

	private static readonly IntPtr selPolicyDelegateHandle = Selector.GetHandle("policyDelegate");

	private static readonly IntPtr selSetPolicyDelegate_Handle = Selector.GetHandle("setPolicyDelegate:");

	private static readonly IntPtr selTextSizeMultiplierHandle = Selector.GetHandle("textSizeMultiplier");

	private static readonly IntPtr selSetTextSizeMultiplier_Handle = Selector.GetHandle("setTextSizeMultiplier:");

	private static readonly IntPtr selApplicationNameForUserAgentHandle = Selector.GetHandle("applicationNameForUserAgent");

	private static readonly IntPtr selSetApplicationNameForUserAgent_Handle = Selector.GetHandle("setApplicationNameForUserAgent:");

	private static readonly IntPtr selCustomUserAgentHandle = Selector.GetHandle("customUserAgent");

	private static readonly IntPtr selSetCustomUserAgent_Handle = Selector.GetHandle("setCustomUserAgent:");

	private static readonly IntPtr selCustomTextEncodingNameHandle = Selector.GetHandle("customTextEncodingName");

	private static readonly IntPtr selSetCustomTextEncodingName_Handle = Selector.GetHandle("setCustomTextEncodingName:");

	private static readonly IntPtr selMediaStyleHandle = Selector.GetHandle("mediaStyle");

	private static readonly IntPtr selSetMediaStyle_Handle = Selector.GetHandle("setMediaStyle:");

	private static readonly IntPtr selPreferencesHandle = Selector.GetHandle("preferences");

	private static readonly IntPtr selSetPreferences_Handle = Selector.GetHandle("setPreferences:");

	private static readonly IntPtr selPreferencesIdentifierHandle = Selector.GetHandle("preferencesIdentifier");

	private static readonly IntPtr selSetPreferencesIdentifier_Handle = Selector.GetHandle("setPreferencesIdentifier:");

	private static readonly IntPtr selHostWindowHandle = Selector.GetHandle("hostWindow");

	private static readonly IntPtr selSetHostWindow_Handle = Selector.GetHandle("setHostWindow:");

	private static readonly IntPtr selGroupNameHandle = Selector.GetHandle("groupName");

	private static readonly IntPtr selSetGroupName_Handle = Selector.GetHandle("setGroupName:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selShouldUpdateWhileOffscreenHandle = Selector.GetHandle("shouldUpdateWhileOffscreen");

	private static readonly IntPtr selSetShouldUpdateWhileOffscreen_Handle = Selector.GetHandle("setShouldUpdateWhileOffscreen:");

	private static readonly IntPtr selMainFrameURLHandle = Selector.GetHandle("mainFrameURL");

	private static readonly IntPtr selSetMainFrameURL_Handle = Selector.GetHandle("setMainFrameURL:");

	private static readonly IntPtr selSelectedDOMRangeHandle = Selector.GetHandle("selectedDOMRange");

	private static readonly IntPtr selSelectionAffinityHandle = Selector.GetHandle("selectionAffinity");

	private static readonly IntPtr selMaintainsInactiveSelectionHandle = Selector.GetHandle("maintainsInactiveSelection");

	private static readonly IntPtr selSpellCheckerDocumentTagHandle = Selector.GetHandle("spellCheckerDocumentTag");

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selTypingStyleHandle = Selector.GetHandle("typingStyle");

	private static readonly IntPtr selSetTypingStyle_Handle = Selector.GetHandle("setTypingStyle:");

	private static readonly IntPtr selSmartInsertDeleteEnabledHandle = Selector.GetHandle("smartInsertDeleteEnabled");

	private static readonly IntPtr selSetSmartInsertDeleteEnabled_Handle = Selector.GetHandle("setSmartInsertDeleteEnabled:");

	private static readonly IntPtr selIsContinuousSpellCheckingEnabledHandle = Selector.GetHandle("isContinuousSpellCheckingEnabled");

	private static readonly IntPtr selSetContinuousSpellCheckingEnabled_Handle = Selector.GetHandle("setContinuousSpellCheckingEnabled:");

	private static readonly IntPtr selEditingDelegateHandle = Selector.GetHandle("editingDelegate");

	private static readonly IntPtr selSetEditingDelegate_Handle = Selector.GetHandle("setEditingDelegate:");

	private static readonly IntPtr selCanShowMIMEType_Handle = Selector.GetHandle("canShowMIMEType:");

	private static readonly IntPtr selCanShowMIMETypeAsHTML_Handle = Selector.GetHandle("canShowMIMETypeAsHTML:");

	private static readonly IntPtr selURLFromPasteboard_Handle = Selector.GetHandle("URLFromPasteboard:");

	private static readonly IntPtr selURLTitleFromPasteboard_Handle = Selector.GetHandle("URLTitleFromPasteboard:");

	private static readonly IntPtr selRegisterURLSchemeAsLocal_Handle = Selector.GetHandle("registerURLSchemeAsLocal:");

	private static readonly IntPtr selInitWithFrameFrameNameGroupName_Handle = Selector.GetHandle("initWithFrame:frameName:groupName:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selSetMaintainsBackForwardList_Handle = Selector.GetHandle("setMaintainsBackForwardList:");

	private static readonly IntPtr selGoBackHandle = Selector.GetHandle("goBack");

	private static readonly IntPtr selGoForwardHandle = Selector.GetHandle("goForward");

	private static readonly IntPtr selGoToBackForwardItem_Handle = Selector.GetHandle("goToBackForwardItem:");

	private static readonly IntPtr selUserAgentForURL_Handle = Selector.GetHandle("userAgentForURL:");

	private static readonly IntPtr selStringByEvaluatingJavaScriptFromString_Handle = Selector.GetHandle("stringByEvaluatingJavaScriptFromString:");

	private static readonly IntPtr selSearchForDirectionCaseSensitiveWrap_Handle = Selector.GetHandle("searchFor:direction:caseSensitive:wrap:");

	private static readonly IntPtr selRegisterViewClassRepresentationClassForMIMEType_Handle = Selector.GetHandle("registerViewClass:representationClass:forMIMEType:");

	private static readonly IntPtr selElementAtPoint_Handle = Selector.GetHandle("elementAtPoint:");

	private static readonly IntPtr selWriteSelectionWithPasteboardTypesToPasteboard_Handle = Selector.GetHandle("writeSelectionWithPasteboardTypes:toPasteboard:");

	private static readonly IntPtr selPasteboardTypesForElement_Handle = Selector.GetHandle("pasteboardTypesForElement:");

	private static readonly IntPtr selWriteElementWithPasteboardTypesToPasteboard_Handle = Selector.GetHandle("writeElement:withPasteboardTypes:toPasteboard:");

	private static readonly IntPtr selMoveDragCaretToPoint_Handle = Selector.GetHandle("moveDragCaretToPoint:");

	private static readonly IntPtr selRemoveDragCaretHandle = Selector.GetHandle("removeDragCaret");

	private static readonly IntPtr selReload_Handle = Selector.GetHandle("reload:");

	private static readonly IntPtr selReloadFromOrigin_Handle = Selector.GetHandle("reloadFromOrigin:");

	private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle("canGoBack");

	private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle("canGoForward");

	private static readonly IntPtr selCanMakeTextLargerHandle = Selector.GetHandle("canMakeTextLarger");

	private static readonly IntPtr selMakeTextLarger_Handle = Selector.GetHandle("makeTextLarger:");

	private static readonly IntPtr selCanMakeTextSmallerHandle = Selector.GetHandle("canMakeTextSmaller");

	private static readonly IntPtr selMakeTextSmaller_Handle = Selector.GetHandle("makeTextSmaller:");

	private static readonly IntPtr selCanMakeTextStandardSizeHandle = Selector.GetHandle("canMakeTextStandardSize");

	private static readonly IntPtr selMakeTextStandardSize_Handle = Selector.GetHandle("makeTextStandardSize:");

	private static readonly IntPtr selToggleContinuousSpellChecking_Handle = Selector.GetHandle("toggleContinuousSpellChecking:");

	private static readonly IntPtr selToggleSmartInsertDelete_Handle = Selector.GetHandle("toggleSmartInsertDelete:");

	private static readonly IntPtr selStyleDeclarationWithText_Handle = Selector.GetHandle("styleDeclarationWithText:");

	private static readonly IntPtr selReplaceSelectionWithMarkupString_Handle = Selector.GetHandle("replaceSelectionWithMarkupString:");

	private static readonly IntPtr selReplaceSelectionWithArchive_Handle = Selector.GetHandle("replaceSelectionWithArchive:");

	private static readonly IntPtr selDeleteSelectionHandle = Selector.GetHandle("deleteSelection");

	private static readonly IntPtr selApplyStyle_Handle = Selector.GetHandle("applyStyle:");

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	private static readonly IntPtr selCopyFont_Handle = Selector.GetHandle("copyFont:");

	private static readonly IntPtr selPasteFont_Handle = Selector.GetHandle("pasteFont:");

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	private static readonly IntPtr selPasteAsPlainText_Handle = Selector.GetHandle("pasteAsPlainText:");

	private static readonly IntPtr selPasteAsRichText_Handle = Selector.GetHandle("pasteAsRichText:");

	private static readonly IntPtr selChangeFont_Handle = Selector.GetHandle("changeFont:");

	private static readonly IntPtr selChangeAttributes_Handle = Selector.GetHandle("changeAttributes:");

	private static readonly IntPtr selChangeDocumentBackgroundColor_Handle = Selector.GetHandle("changeDocumentBackgroundColor:");

	private static readonly IntPtr selChangeColor_Handle = Selector.GetHandle("changeColor:");

	private static readonly IntPtr selAlignCenter_Handle = Selector.GetHandle("alignCenter:");

	private static readonly IntPtr selAlignJustified_Handle = Selector.GetHandle("alignJustified:");

	private static readonly IntPtr selAlignLeft_Handle = Selector.GetHandle("alignLeft:");

	private static readonly IntPtr selAlignRight_Handle = Selector.GetHandle("alignRight:");

	private static readonly IntPtr selCheckSpelling_Handle = Selector.GetHandle("checkSpelling:");

	private static readonly IntPtr selShowGuessPanel_Handle = Selector.GetHandle("showGuessPanel:");

	private static readonly IntPtr selPerformFindPanelAction_Handle = Selector.GetHandle("performFindPanelAction:");

	private static readonly IntPtr selStartSpeaking_Handle = Selector.GetHandle("startSpeaking:");

	private static readonly IntPtr selStopSpeaking_Handle = Selector.GetHandle("stopSpeaking:");

	private static readonly IntPtr selMoveToBeginningOfSentence_Handle = Selector.GetHandle("moveToBeginningOfSentence:");

	private static readonly IntPtr selMoveToBeginningOfSentenceAndModifySelection_Handle = Selector.GetHandle("moveToBeginningOfSentenceAndModifySelection:");

	private static readonly IntPtr selMoveToEndOfSentence_Handle = Selector.GetHandle("moveToEndOfSentence:");

	private static readonly IntPtr selMoveToEndOfSentenceAndModifySelection_Handle = Selector.GetHandle("moveToEndOfSentenceAndModifySelection:");

	private static readonly IntPtr selSelectSentence_Handle = Selector.GetHandle("selectSentence:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebView");

	private object __mt_MainFrame_var;

	private object __mt_SelectedFrame_var;

	private object __mt_BackForwardList_var;

	private object __mt_WindowScriptObject_var;

	private object __mt_PasteboardTypesForSelection_var;

	private object __mt_MainFrameDocument_var;

	private object __mt_MainFrameIcon_var;

	private object __mt_WeakResourceLoadDelegate_var;

	private object __mt_WeakDownloadDelegate_var;

	private object __mt_WeakFrameLoadDelegate_var;

	private object __mt_WeakUIDelegate_var;

	private object __mt_WeakPolicyDelegate_var;

	private object __mt_Preferences_var;

	private object __mt_HostWindow_var;

	private object __mt_SelectedDomRange_var;

	private object __mt_UndoManager_var;

	private object __mt_TypingStyle_var;

	private object __mt_EditingDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public static string[] MimeTypesShownAsHtml
	{
		[Export("MIMETypesShownAsHTML")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMIMETypesShownAsHTMLHandle));
		}
		[Export("setMIMETypesShownAsHTML:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetMIMETypesShownAsHTML_Handle, nSArray.Handle);
			nSArray.Dispose();
		}
	}

	public virtual WebFrame MainFrame
	{
		[Export("mainFrame")]
		get
		{
			return (WebFrame)(__mt_MainFrame_var = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameHandle))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameHandle)))));
		}
	}

	public virtual WebFrame SelectedFrame
	{
		[Export("selectedFrame")]
		get
		{
			return (WebFrame)(__mt_SelectedFrame_var = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedFrameHandle))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedFrameHandle)))));
		}
	}

	public virtual WebBackForwardList BackForwardList
	{
		[Export("backForwardList")]
		get
		{
			return (WebBackForwardList)(__mt_BackForwardList_var = ((!IsDirectBinding) ? ((WebBackForwardList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackForwardListHandle))) : ((WebBackForwardList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackForwardListHandle)))));
		}
	}

	public virtual bool SupportsTextEncoding
	{
		[Export("supportsTextEncoding")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTextEncodingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTextEncodingHandle);
		}
	}

	public virtual WebScriptObject WindowScriptObject
	{
		[Export("windowScriptObject")]
		get
		{
			return (WebScriptObject)(__mt_WindowScriptObject_var = ((!IsDirectBinding) ? ((WebScriptObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowScriptObjectHandle))) : ((WebScriptObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowScriptObjectHandle)))));
		}
	}

	public virtual double EstimatedProgress
	{
		[Export("estimatedProgress")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEstimatedProgressHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEstimatedProgressHandle);
		}
	}

	public virtual bool IsLoading
	{
		[Export("isLoading")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	public virtual NSPasteboard[] PasteboardTypesForSelection
	{
		[Export("pasteboardTypesForSelection")]
		get
		{
			return (NSPasteboard[])(__mt_PasteboardTypesForSelection_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPasteboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasteboardTypesForSelectionHandle)) : NSArray.ArrayFromHandle<NSPasteboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selPasteboardTypesForSelectionHandle))));
		}
	}

	public virtual DomDocument MainFrameDocument
	{
		[Export("mainFrameDocument")]
		get
		{
			return (DomDocument)(__mt_MainFrameDocument_var = ((!IsDirectBinding) ? ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameDocumentHandle))) : ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameDocumentHandle)))));
		}
	}

	public virtual string MainFrameTitle
	{
		[Export("mainFrameTitle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameTitleHandle));
		}
	}

	public virtual NSImage MainFrameIcon
	{
		[Export("mainFrameIcon")]
		get
		{
			return (NSImage)(__mt_MainFrameIcon_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameIconHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameIconHandle)))));
		}
	}

	public virtual bool ShouldCloseWithWindow
	{
		[Export("shouldCloseWithWindow")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCloseWithWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCloseWithWindowHandle);
		}
		[Export("setShouldCloseWithWindow:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCloseWithWindow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCloseWithWindow_Handle, value);
			}
		}
	}

	public virtual NSObject WeakResourceLoadDelegate
	{
		[Export("resourceLoadDelegate")]
		get
		{
			return (NSObject)(__mt_WeakResourceLoadDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceLoadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceLoadDelegateHandle))));
		}
		[Export("setResourceLoadDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResourceLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResourceLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakResourceLoadDelegate_var = value;
		}
	}

	public WebResourceLoadDelegate ResourceLoadDelegate
	{
		get
		{
			return WeakResourceLoadDelegate as WebResourceLoadDelegate;
		}
		set
		{
			WeakResourceLoadDelegate = value;
		}
	}

	public virtual NSObject WeakDownloadDelegate
	{
		[Export("downloadDelegate")]
		get
		{
			return (NSObject)(__mt_WeakDownloadDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadDelegateHandle))));
		}
		[Export("setDownloadDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDownloadDelegate_var = value;
		}
	}

	public WebDownloadDelegate DownloadDelegate
	{
		get
		{
			return WeakDownloadDelegate as WebDownloadDelegate;
		}
		set
		{
			WeakDownloadDelegate = value;
		}
	}

	public virtual NSObject WeakFrameLoadDelegate
	{
		[Export("frameLoadDelegate")]
		get
		{
			return (NSObject)(__mt_WeakFrameLoadDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameLoadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameLoadDelegateHandle))));
		}
		[Export("setFrameLoadDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakFrameLoadDelegate_var = value;
		}
	}

	public WebFrameLoadDelegate FrameLoadDelegate
	{
		get
		{
			return WeakFrameLoadDelegate as WebFrameLoadDelegate;
		}
		set
		{
			WeakFrameLoadDelegate = value;
		}
	}

	public virtual NSObject WeakUIDelegate
	{
		[Export("UIDelegate")]
		get
		{
			return (NSObject)(__mt_WeakUIDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUIDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUIDelegateHandle))));
		}
		[Export("setUIDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakUIDelegate_var = value;
		}
	}

	public WebUIDelegate UIDelegate
	{
		get
		{
			return WeakUIDelegate as WebUIDelegate;
		}
		set
		{
			WeakUIDelegate = value;
		}
	}

	public virtual NSObject WeakPolicyDelegate
	{
		[Export("policyDelegate")]
		get
		{
			return (NSObject)(__mt_WeakPolicyDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolicyDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPolicyDelegateHandle))));
		}
		[Export("setPolicyDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPolicyDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPolicyDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakPolicyDelegate_var = value;
		}
	}

	public WebPolicyDelegate PolicyDelegate
	{
		get
		{
			return WeakPolicyDelegate as WebPolicyDelegate;
		}
		set
		{
			WeakPolicyDelegate = value;
		}
	}

	public virtual float TextSizeMultiplier
	{
		[Export("textSizeMultiplier")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTextSizeMultiplierHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTextSizeMultiplierHandle);
		}
		[Export("setTextSizeMultiplier:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetTextSizeMultiplier_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetTextSizeMultiplier_Handle, value);
			}
		}
	}

	public virtual string ApplicationNameForUserAgent
	{
		[Export("applicationNameForUserAgent")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicationNameForUserAgentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicationNameForUserAgentHandle));
		}
		[Export("setApplicationNameForUserAgent:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetApplicationNameForUserAgent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetApplicationNameForUserAgent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CustomUserAgent
	{
		[Export("customUserAgent")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomUserAgentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomUserAgentHandle));
		}
		[Export("setCustomUserAgent:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomUserAgent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomUserAgent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CustomTextEncodingName
	{
		[Export("customTextEncodingName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomTextEncodingNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomTextEncodingNameHandle));
		}
		[Export("setCustomTextEncodingName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomTextEncodingName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomTextEncodingName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string MediaStyle
	{
		[Export("mediaStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaStyleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaStyleHandle));
		}
		[Export("setMediaStyle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaStyle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaStyle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual WebPreferences Preferences
	{
		[Export("preferences")]
		get
		{
			return (WebPreferences)(__mt_Preferences_var = ((!IsDirectBinding) ? ((WebPreferences)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferencesHandle))) : ((WebPreferences)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferencesHandle)))));
		}
		[Export("setPreferences:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferences_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferences_Handle, value.Handle);
			}
			__mt_Preferences_var = value;
		}
	}

	public virtual string PreferencesIdentifier
	{
		[Export("preferencesIdentifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferencesIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferencesIdentifierHandle));
		}
		[Export("setPreferencesIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferencesIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferencesIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSWindow HostWindow
	{
		[Export("hostWindow")]
		get
		{
			return (NSWindow)(__mt_HostWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHostWindowHandle)))));
		}
		[Export("setHostWindow:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHostWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHostWindow_Handle, value.Handle);
			}
			__mt_HostWindow_var = value;
		}
	}

	public virtual string GroupName
	{
		[Export("groupName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupNameHandle));
		}
		[Export("setGroupName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	public virtual bool UpdateWhileOffscreen
	{
		[Export("shouldUpdateWhileOffscreen")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldUpdateWhileOffscreenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldUpdateWhileOffscreenHandle);
		}
		[Export("setShouldUpdateWhileOffscreen:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldUpdateWhileOffscreen_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldUpdateWhileOffscreen_Handle, value);
			}
		}
	}

	public virtual string MainFrameUrl
	{
		[Export("mainFrameURL")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameURLHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameURLHandle));
		}
		[Export("setMainFrameURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMainFrameURL_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMainFrameURL_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomRange SelectedDomRange
	{
		[Export("selectedDOMRange")]
		get
		{
			return (DomRange)(__mt_SelectedDomRange_var = ((!IsDirectBinding) ? ((DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedDOMRangeHandle))) : ((DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedDOMRangeHandle)))));
		}
	}

	public virtual NSSelectionAffinity SelectionAffinity
	{
		[Export("selectionAffinity")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSSelectionAffinity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionAffinityHandle);
			}
			return (NSSelectionAffinity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionAffinityHandle);
		}
	}

	public virtual bool MaintainsInactiveSelection
	{
		[Export("maintainsInactiveSelection")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMaintainsInactiveSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMaintainsInactiveSelectionHandle);
		}
	}

	public virtual int SpellCheckerDocumentTag
	{
		[Export("spellCheckerDocumentTag")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSpellCheckerDocumentTagHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSpellCheckerDocumentTagHandle);
		}
	}

	public virtual NSUndoManager UndoManager
	{
		[Export("undoManager")]
		get
		{
			return (NSUndoManager)(__mt_UndoManager_var = ((!IsDirectBinding) ? ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle))) : ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle)))));
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual DomCssStyleDeclaration TypingStyle
	{
		[Export("typingStyle")]
		get
		{
			return (DomCssStyleDeclaration)(__mt_TypingStyle_var = ((!IsDirectBinding) ? ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypingStyleHandle))) : ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTypingStyleHandle)))));
		}
		[Export("setTypingStyle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypingStyle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypingStyle_Handle, value.Handle);
			}
			__mt_TypingStyle_var = value;
		}
	}

	public virtual bool SmartInsertDeleteEnabled
	{
		[Export("smartInsertDeleteEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSmartInsertDeleteEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSmartInsertDeleteEnabledHandle);
		}
		[Export("setSmartInsertDeleteEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
		}
	}

	public virtual bool ContinuousSpellCheckingEnabled
	{
		[Export("isContinuousSpellCheckingEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousSpellCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousSpellCheckingEnabledHandle);
		}
		[Export("setContinuousSpellCheckingEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
		}
	}

	public virtual NSObject EditingDelegate
	{
		[Export("editingDelegate")]
		get
		{
			return (NSObject)(__mt_EditingDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEditingDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEditingDelegateHandle))));
		}
		[Export("setEditingDelegate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEditingDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEditingDelegate_Handle, value.Handle);
			}
			__mt_EditingDelegate_var = value;
		}
	}

	public WebDownloadRequest OnDownloadWindowForSheet
	{
		get
		{
			return EnsureWebDownloadDelegate().onDownloadWindowForSheet;
		}
		set
		{
			EnsureWebDownloadDelegate().onDownloadWindowForSheet = value;
		}
	}

	public WebResourceIdentifierRequest OnIdentifierForInitialRequest
	{
		get
		{
			return EnsureWebResourceLoadDelegate().onIdentifierForInitialRequest;
		}
		set
		{
			EnsureWebResourceLoadDelegate().onIdentifierForInitialRequest = value;
		}
	}

	public WebResourceOnRequestSend OnSendRequest
	{
		get
		{
			return EnsureWebResourceLoadDelegate().onSendRequest;
		}
		set
		{
			EnsureWebResourceLoadDelegate().onSendRequest = value;
		}
	}

	public CreateWebViewFromRequest UICreateWebView
	{
		get
		{
			return EnsureWebUIDelegate().uICreateWebView;
		}
		set
		{
			EnsureWebUIDelegate().uICreateWebView = value;
		}
	}

	public WebViewCreate UICreateModalDialog
	{
		get
		{
			return EnsureWebUIDelegate().uICreateModalDialog;
		}
		set
		{
			EnsureWebUIDelegate().uICreateModalDialog = value;
		}
	}

	public WebViewGetResponder UIGetFirstResponder
	{
		get
		{
			return EnsureWebUIDelegate().uIGetFirstResponder;
		}
		set
		{
			EnsureWebUIDelegate().uIGetFirstResponder = value;
		}
	}

	public WebViewGetString UIGetStatusText
	{
		get
		{
			return EnsureWebUIDelegate().uIGetStatusText;
		}
		set
		{
			EnsureWebUIDelegate().uIGetStatusText = value;
		}
	}

	public WebViewGetBool UIAreToolbarsVisible
	{
		get
		{
			return EnsureWebUIDelegate().uIAreToolbarsVisible;
		}
		set
		{
			EnsureWebUIDelegate().uIAreToolbarsVisible = value;
		}
	}

	public WebViewGetBool UIIsStatusBarVisible
	{
		get
		{
			return EnsureWebUIDelegate().uIIsStatusBarVisible;
		}
		set
		{
			EnsureWebUIDelegate().uIIsStatusBarVisible = value;
		}
	}

	public WebViewGetBool UIIsResizable
	{
		get
		{
			return EnsureWebUIDelegate().uIIsResizable;
		}
		set
		{
			EnsureWebUIDelegate().uIIsResizable = value;
		}
	}

	public WebViewGetRectangle UIGetFrame
	{
		get
		{
			return EnsureWebUIDelegate().uIGetFrame;
		}
		set
		{
			EnsureWebUIDelegate().uIGetFrame = value;
		}
	}

	public WebViewConfirmationPanel UIRunJavaScriptConfirmationPanel
	{
		get
		{
			return EnsureWebUIDelegate().uIRunJavaScriptConfirmationPanel;
		}
		set
		{
			EnsureWebUIDelegate().uIRunJavaScriptConfirmationPanel = value;
		}
	}

	public WebViewPromptPanel UIRunJavaScriptTextInputPanelWithFrame
	{
		get
		{
			return EnsureWebUIDelegate().uIRunJavaScriptTextInputPanelWithFrame;
		}
		set
		{
			EnsureWebUIDelegate().uIRunJavaScriptTextInputPanelWithFrame = value;
		}
	}

	public WebViewJavaScriptFrame UIRunBeforeUnload
	{
		get
		{
			return EnsureWebUIDelegate().uIRunBeforeUnload;
		}
		set
		{
			EnsureWebUIDelegate().uIRunBeforeUnload = value;
		}
	}

	public WebViewGetContextMenuItems UIGetContextMenuItems
	{
		get
		{
			return EnsureWebUIDelegate().uIGetContextMenuItems;
		}
		set
		{
			EnsureWebUIDelegate().uIGetContextMenuItems = value;
		}
	}

	public WebViewValidateUserInterface UIValidateUserInterfaceItem
	{
		get
		{
			return EnsureWebUIDelegate().uIValidateUserInterfaceItem;
		}
		set
		{
			EnsureWebUIDelegate().uIValidateUserInterfaceItem = value;
		}
	}

	public WebViewPerformAction UIShouldPerformActionfromSender
	{
		get
		{
			return EnsureWebUIDelegate().uIShouldPerformActionfromSender;
		}
		set
		{
			EnsureWebUIDelegate().uIShouldPerformActionfromSender = value;
		}
	}

	public DragDestinationGetActionMask UIGetDragDestinationActionMask
	{
		get
		{
			return EnsureWebUIDelegate().uIGetDragDestinationActionMask;
		}
		set
		{
			EnsureWebUIDelegate().uIGetDragDestinationActionMask = value;
		}
	}

	public DragSourceGetActionMask UIDragSourceActionMask
	{
		get
		{
			return EnsureWebUIDelegate().uIDragSourceActionMask;
		}
		set
		{
			EnsureWebUIDelegate().uIDragSourceActionMask = value;
		}
	}

	public WebViewGetFloat UIGetHeaderHeight
	{
		get
		{
			return EnsureWebUIDelegate().uIGetHeaderHeight;
		}
		set
		{
			EnsureWebUIDelegate().uIGetHeaderHeight = value;
		}
	}

	public WebViewGetFloat UIGetFooterHeight
	{
		get
		{
			return EnsureWebUIDelegate().uIGetFooterHeight;
		}
		set
		{
			EnsureWebUIDelegate().uIGetFooterHeight = value;
		}
	}

	public WebViewPrompt UIRunJavaScriptConfirmPanel
	{
		get
		{
			return EnsureWebUIDelegate().uIRunJavaScriptConfirmPanel;
		}
		set
		{
			EnsureWebUIDelegate().uIRunJavaScriptConfirmPanel = value;
		}
	}

	public WebViewJavaScriptInput UIRunJavaScriptTextInputPanel
	{
		get
		{
			return EnsureWebUIDelegate().uIRunJavaScriptTextInputPanel;
		}
		set
		{
			EnsureWebUIDelegate().uIRunJavaScriptTextInputPanel = value;
		}
	}

	public WebViewGetRectangle UIGetContentRect
	{
		get
		{
			return EnsureWebUIDelegate().uIGetContentRect;
		}
		set
		{
			EnsureWebUIDelegate().uIGetContentRect = value;
		}
	}

	public event EventHandler<WebFrameEventArgs> StartedProvisionalLoad
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.startedProvisionalLoad = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.startedProvisionalLoad, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.startedProvisionalLoad = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.startedProvisionalLoad, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> ReceivedServerRedirectForProvisionalLoad
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedServerRedirectForProvisionalLoad = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.receivedServerRedirectForProvisionalLoad, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedServerRedirectForProvisionalLoad = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.receivedServerRedirectForProvisionalLoad, value);
		}
	}

	public event EventHandler<WebFrameErrorEventArgs> FailedProvisionalLoad
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.failedProvisionalLoad = (EventHandler<WebFrameErrorEventArgs>)Delegate.Combine(webFrameLoadDelegate.failedProvisionalLoad, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.failedProvisionalLoad = (EventHandler<WebFrameErrorEventArgs>)Delegate.Remove(webFrameLoadDelegate.failedProvisionalLoad, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> CommitedLoad
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.commitedLoad = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.commitedLoad, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.commitedLoad = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.commitedLoad, value);
		}
	}

	public event EventHandler<WebFrameTitleEventArgs> ReceivedTitle
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedTitle = (EventHandler<WebFrameTitleEventArgs>)Delegate.Combine(webFrameLoadDelegate.receivedTitle, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedTitle = (EventHandler<WebFrameTitleEventArgs>)Delegate.Remove(webFrameLoadDelegate.receivedTitle, value);
		}
	}

	public event EventHandler<WebFrameImageEventArgs> ReceivedIcon
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedIcon = (EventHandler<WebFrameImageEventArgs>)Delegate.Combine(webFrameLoadDelegate.receivedIcon, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.receivedIcon = (EventHandler<WebFrameImageEventArgs>)Delegate.Remove(webFrameLoadDelegate.receivedIcon, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> FinishedLoad
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.finishedLoad = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.finishedLoad, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.finishedLoad = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.finishedLoad, value);
		}
	}

	public event EventHandler<WebFrameErrorEventArgs> FailedLoadWithError
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.failedLoadWithError = (EventHandler<WebFrameErrorEventArgs>)Delegate.Combine(webFrameLoadDelegate.failedLoadWithError, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.failedLoadWithError = (EventHandler<WebFrameErrorEventArgs>)Delegate.Remove(webFrameLoadDelegate.failedLoadWithError, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> ChangedLocationWithinPage
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.changedLocationWithinPage = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.changedLocationWithinPage, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.changedLocationWithinPage = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.changedLocationWithinPage, value);
		}
	}

	public event EventHandler<WebFrameClientRedirectEventArgs> WillPerformClientRedirect
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.willPerformClientRedirect = (EventHandler<WebFrameClientRedirectEventArgs>)Delegate.Combine(webFrameLoadDelegate.willPerformClientRedirect, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.willPerformClientRedirect = (EventHandler<WebFrameClientRedirectEventArgs>)Delegate.Remove(webFrameLoadDelegate.willPerformClientRedirect, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> CanceledClientRedirect
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.canceledClientRedirect = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.canceledClientRedirect, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.canceledClientRedirect = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.canceledClientRedirect, value);
		}
	}

	public event EventHandler<WebFrameEventArgs> WillCloseFrame
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.willCloseFrame = (EventHandler<WebFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.willCloseFrame, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.willCloseFrame = (EventHandler<WebFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.willCloseFrame, value);
		}
	}

	public event EventHandler<WebFrameScriptFrameEventArgs> ClearedWindowObject
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.clearedWindowObject = (EventHandler<WebFrameScriptFrameEventArgs>)Delegate.Combine(webFrameLoadDelegate.clearedWindowObject, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.clearedWindowObject = (EventHandler<WebFrameScriptFrameEventArgs>)Delegate.Remove(webFrameLoadDelegate.clearedWindowObject, value);
		}
	}

	public event EventHandler<WebFrameScriptObjectEventArgs> WindowScriptObjectAvailable
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.windowScriptObjectAvailable = (EventHandler<WebFrameScriptObjectEventArgs>)Delegate.Combine(webFrameLoadDelegate.windowScriptObjectAvailable, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.windowScriptObjectAvailable = (EventHandler<WebFrameScriptObjectEventArgs>)Delegate.Remove(webFrameLoadDelegate.windowScriptObjectAvailable, value);
		}
	}

	public event EventHandler<WebResourceAuthenticationChallengeEventArgs> OnReceivedAuthenticationChallenge
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedAuthenticationChallenge = (EventHandler<WebResourceAuthenticationChallengeEventArgs>)Delegate.Combine(webResourceLoadDelegate.onReceivedAuthenticationChallenge, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedAuthenticationChallenge = (EventHandler<WebResourceAuthenticationChallengeEventArgs>)Delegate.Remove(webResourceLoadDelegate.onReceivedAuthenticationChallenge, value);
		}
	}

	public event EventHandler<WebResourceCancelledChallengeEventArgs> OnCancelledAuthenticationChallenge
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onCancelledAuthenticationChallenge = (EventHandler<WebResourceCancelledChallengeEventArgs>)Delegate.Combine(webResourceLoadDelegate.onCancelledAuthenticationChallenge, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onCancelledAuthenticationChallenge = (EventHandler<WebResourceCancelledChallengeEventArgs>)Delegate.Remove(webResourceLoadDelegate.onCancelledAuthenticationChallenge, value);
		}
	}

	public event EventHandler<WebResourceReceivedResponseEventArgs> OnReceivedResponse
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedResponse = (EventHandler<WebResourceReceivedResponseEventArgs>)Delegate.Combine(webResourceLoadDelegate.onReceivedResponse, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedResponse = (EventHandler<WebResourceReceivedResponseEventArgs>)Delegate.Remove(webResourceLoadDelegate.onReceivedResponse, value);
		}
	}

	public event EventHandler<WebResourceReceivedContentLengthEventArgs> OnReceivedContentLength
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedContentLength = (EventHandler<WebResourceReceivedContentLengthEventArgs>)Delegate.Combine(webResourceLoadDelegate.onReceivedContentLength, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onReceivedContentLength = (EventHandler<WebResourceReceivedContentLengthEventArgs>)Delegate.Remove(webResourceLoadDelegate.onReceivedContentLength, value);
		}
	}

	public event EventHandler<WebResourceCompletedEventArgs> OnFinishedLoading
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onFinishedLoading = (EventHandler<WebResourceCompletedEventArgs>)Delegate.Combine(webResourceLoadDelegate.onFinishedLoading, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onFinishedLoading = (EventHandler<WebResourceCompletedEventArgs>)Delegate.Remove(webResourceLoadDelegate.onFinishedLoading, value);
		}
	}

	public event EventHandler<WebResourceErrorEventArgs> OnFailedLoading
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onFailedLoading = (EventHandler<WebResourceErrorEventArgs>)Delegate.Combine(webResourceLoadDelegate.onFailedLoading, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onFailedLoading = (EventHandler<WebResourceErrorEventArgs>)Delegate.Remove(webResourceLoadDelegate.onFailedLoading, value);
		}
	}

	public event EventHandler<WebResourcePluginErrorEventArgs> OnPlugInFailed
	{
		add
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onPlugInFailed = (EventHandler<WebResourcePluginErrorEventArgs>)Delegate.Combine(webResourceLoadDelegate.onPlugInFailed, value);
		}
		remove
		{
			_WebResourceLoadDelegate webResourceLoadDelegate = EnsureWebResourceLoadDelegate();
			webResourceLoadDelegate.onPlugInFailed = (EventHandler<WebResourcePluginErrorEventArgs>)Delegate.Remove(webResourceLoadDelegate.onPlugInFailed, value);
		}
	}

	public event EventHandler UIShow
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIShow = (EventHandler)Delegate.Combine(webUIDelegate.uIShow, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIShow = (EventHandler)Delegate.Remove(webUIDelegate.uIShow, value);
		}
	}

	public event EventHandler UIRunModal
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunModal = (EventHandler)Delegate.Combine(webUIDelegate.uIRunModal, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunModal = (EventHandler)Delegate.Remove(webUIDelegate.uIRunModal, value);
		}
	}

	public event EventHandler UIClose
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIClose = (EventHandler)Delegate.Combine(webUIDelegate.uIClose, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIClose = (EventHandler)Delegate.Remove(webUIDelegate.uIClose, value);
		}
	}

	public event EventHandler UIFocus
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIFocus = (EventHandler)Delegate.Combine(webUIDelegate.uIFocus, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIFocus = (EventHandler)Delegate.Remove(webUIDelegate.uIFocus, value);
		}
	}

	public event EventHandler UIUnfocus
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIUnfocus = (EventHandler)Delegate.Combine(webUIDelegate.uIUnfocus, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIUnfocus = (EventHandler)Delegate.Remove(webUIDelegate.uIUnfocus, value);
		}
	}

	public event EventHandler<WebViewResponderEventArgs> UIMakeFirstResponder
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIMakeFirstResponder = (EventHandler<WebViewResponderEventArgs>)Delegate.Combine(webUIDelegate.uIMakeFirstResponder, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIMakeFirstResponder = (EventHandler<WebViewResponderEventArgs>)Delegate.Remove(webUIDelegate.uIMakeFirstResponder, value);
		}
	}

	public event EventHandler<WebViewStatusTextEventArgs> UISetStatusText
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetStatusText = (EventHandler<WebViewStatusTextEventArgs>)Delegate.Combine(webUIDelegate.uISetStatusText, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetStatusText = (EventHandler<WebViewStatusTextEventArgs>)Delegate.Remove(webUIDelegate.uISetStatusText, value);
		}
	}

	public event EventHandler<WebViewToolBarsEventArgs> UISetToolbarsVisible
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetToolbarsVisible = (EventHandler<WebViewToolBarsEventArgs>)Delegate.Combine(webUIDelegate.uISetToolbarsVisible, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetToolbarsVisible = (EventHandler<WebViewToolBarsEventArgs>)Delegate.Remove(webUIDelegate.uISetToolbarsVisible, value);
		}
	}

	public event EventHandler<WebViewStatusBarEventArgs> UISetStatusBarVisible
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetStatusBarVisible = (EventHandler<WebViewStatusBarEventArgs>)Delegate.Combine(webUIDelegate.uISetStatusBarVisible, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetStatusBarVisible = (EventHandler<WebViewStatusBarEventArgs>)Delegate.Remove(webUIDelegate.uISetStatusBarVisible, value);
		}
	}

	public event EventHandler<WebViewResizableEventArgs> UISetResizable
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetResizable = (EventHandler<WebViewResizableEventArgs>)Delegate.Combine(webUIDelegate.uISetResizable, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetResizable = (EventHandler<WebViewResizableEventArgs>)Delegate.Remove(webUIDelegate.uISetResizable, value);
		}
	}

	public event EventHandler<WebViewFrameEventArgs> UISetFrame
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetFrame = (EventHandler<WebViewFrameEventArgs>)Delegate.Combine(webUIDelegate.uISetFrame, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetFrame = (EventHandler<WebViewFrameEventArgs>)Delegate.Remove(webUIDelegate.uISetFrame, value);
		}
	}

	public event EventHandler<WebViewJavaScriptFrameEventArgs> UIRunJavaScriptAlertPanelMessage
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunJavaScriptAlertPanelMessage = (EventHandler<WebViewJavaScriptFrameEventArgs>)Delegate.Combine(webUIDelegate.uIRunJavaScriptAlertPanelMessage, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunJavaScriptAlertPanelMessage = (EventHandler<WebViewJavaScriptFrameEventArgs>)Delegate.Remove(webUIDelegate.uIRunJavaScriptAlertPanelMessage, value);
		}
	}

	public event EventHandler<WebViewRunOpenPanelEventArgs> UIRunOpenPanelForFileButton
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunOpenPanelForFileButton = (EventHandler<WebViewRunOpenPanelEventArgs>)Delegate.Combine(webUIDelegate.uIRunOpenPanelForFileButton, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunOpenPanelForFileButton = (EventHandler<WebViewRunOpenPanelEventArgs>)Delegate.Remove(webUIDelegate.uIRunOpenPanelForFileButton, value);
		}
	}

	public event EventHandler<WebViewMouseMovedEventArgs> UIMouseDidMoveOverElement
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIMouseDidMoveOverElement = (EventHandler<WebViewMouseMovedEventArgs>)Delegate.Combine(webUIDelegate.uIMouseDidMoveOverElement, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIMouseDidMoveOverElement = (EventHandler<WebViewMouseMovedEventArgs>)Delegate.Remove(webUIDelegate.uIMouseDidMoveOverElement, value);
		}
	}

	public event EventHandler<WebViewDragEventArgs> UIWillPerformDragDestination
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIWillPerformDragDestination = (EventHandler<WebViewDragEventArgs>)Delegate.Combine(webUIDelegate.uIWillPerformDragDestination, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIWillPerformDragDestination = (EventHandler<WebViewDragEventArgs>)Delegate.Remove(webUIDelegate.uIWillPerformDragDestination, value);
		}
	}

	public event EventHandler<WebViewPerformDragEventArgs> UIWillPerformDragSource
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIWillPerformDragSource = (EventHandler<WebViewPerformDragEventArgs>)Delegate.Combine(webUIDelegate.uIWillPerformDragSource, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIWillPerformDragSource = (EventHandler<WebViewPerformDragEventArgs>)Delegate.Remove(webUIDelegate.uIWillPerformDragSource, value);
		}
	}

	public event EventHandler<WebViewPrintEventArgs> UIPrintFrameView
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIPrintFrameView = (EventHandler<WebViewPrintEventArgs>)Delegate.Combine(webUIDelegate.uIPrintFrameView, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIPrintFrameView = (EventHandler<WebViewPrintEventArgs>)Delegate.Remove(webUIDelegate.uIPrintFrameView, value);
		}
	}

	public event EventHandler<WebViewHeaderEventArgs> UIDrawHeaderInRect
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIDrawHeaderInRect = (EventHandler<WebViewHeaderEventArgs>)Delegate.Combine(webUIDelegate.uIDrawHeaderInRect, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIDrawHeaderInRect = (EventHandler<WebViewHeaderEventArgs>)Delegate.Remove(webUIDelegate.uIDrawHeaderInRect, value);
		}
	}

	public event EventHandler<WebViewFooterEventArgs> UIDrawFooterInRect
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIDrawFooterInRect = (EventHandler<WebViewFooterEventArgs>)Delegate.Combine(webUIDelegate.uIDrawFooterInRect, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIDrawFooterInRect = (EventHandler<WebViewFooterEventArgs>)Delegate.Remove(webUIDelegate.uIDrawFooterInRect, value);
		}
	}

	public event EventHandler<WebViewJavaScriptEventArgs> UIRunJavaScriptAlertPanel
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunJavaScriptAlertPanel = (EventHandler<WebViewJavaScriptEventArgs>)Delegate.Combine(webUIDelegate.uIRunJavaScriptAlertPanel, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uIRunJavaScriptAlertPanel = (EventHandler<WebViewJavaScriptEventArgs>)Delegate.Remove(webUIDelegate.uIRunJavaScriptAlertPanel, value);
		}
	}

	public event EventHandler<WebViewContentEventArgs> UISetContentRect
	{
		add
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetContentRect = (EventHandler<WebViewContentEventArgs>)Delegate.Combine(webUIDelegate.uISetContentRect, value);
		}
		remove
		{
			_WebUIDelegate webUIDelegate = EnsureWebUIDelegate();
			webUIDelegate.uISetContentRect = (EventHandler<WebViewContentEventArgs>)Delegate.Remove(webUIDelegate.uISetContentRect, value);
		}
	}

	public event EventHandler<WebNavigationPolicyEventArgs> DecidePolicyForNavigation
	{
		add
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForNavigation = (EventHandler<WebNavigationPolicyEventArgs>)Delegate.Combine(webPolicyDelegate.decidePolicyForNavigation, value);
		}
		remove
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForNavigation = (EventHandler<WebNavigationPolicyEventArgs>)Delegate.Remove(webPolicyDelegate.decidePolicyForNavigation, value);
		}
	}

	public event EventHandler<WebNewWindowPolicyEventArgs> DecidePolicyForNewWindow
	{
		add
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForNewWindow = (EventHandler<WebNewWindowPolicyEventArgs>)Delegate.Combine(webPolicyDelegate.decidePolicyForNewWindow, value);
		}
		remove
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForNewWindow = (EventHandler<WebNewWindowPolicyEventArgs>)Delegate.Remove(webPolicyDelegate.decidePolicyForNewWindow, value);
		}
	}

	public event EventHandler<WebMimeTypePolicyEventArgs> DecidePolicyForMimeType
	{
		add
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForMimeType = (EventHandler<WebMimeTypePolicyEventArgs>)Delegate.Combine(webPolicyDelegate.decidePolicyForMimeType, value);
		}
		remove
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.decidePolicyForMimeType = (EventHandler<WebMimeTypePolicyEventArgs>)Delegate.Remove(webPolicyDelegate.decidePolicyForMimeType, value);
		}
	}

	public event EventHandler<WebFailureToImplementPolicyEventArgs> UnableToImplementPolicy
	{
		add
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.unableToImplementPolicy = (EventHandler<WebFailureToImplementPolicyEventArgs>)Delegate.Combine(webPolicyDelegate.unableToImplementPolicy, value);
		}
		remove
		{
			_WebPolicyDelegate webPolicyDelegate = EnsureWebPolicyDelegate();
			webPolicyDelegate.unableToImplementPolicy = (EventHandler<WebFailureToImplementPolicyEventArgs>)Delegate.Remove(webPolicyDelegate.unableToImplementPolicy, value);
		}
	}

	public static void DecideUse(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("token");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selUse);
	}

	public static void DecideDownload(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selDownload);
	}

	public static void DecideIgnore(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selIgnore);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebView()
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
	public WebView(NSCoder coder)
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
	public WebView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canShowMIMEType:")]
	public static bool CanShowMimeType(string MimeType)
	{
		if (MimeType == null)
		{
			throw new ArgumentNullException("MimeType");
		}
		IntPtr arg = NSString.CreateNative(MimeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanShowMIMEType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("canShowMIMETypeAsHTML:")]
	public static bool CanShowMimeTypeAsHtml(string mimeType)
	{
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanShowMIMETypeAsHTML_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLFromPasteboard:")]
	public static NSUrl UrlFromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("URLTitleFromPasteboard:")]
	public static string UrlTitleFromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLTitleFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("registerURLSchemeAsLocal:")]
	public static void RegisterUrlSchemeAsLocal(string scheme)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = NSString.CreateNative(scheme);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRegisterURLSchemeAsLocal_Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("initWithFrame:frameName:groupName:")]
	public WebView(CGRect frame, string frameName, string groupName)
		: base(NSObjectFlag.Empty)
	{
		if (frameName == null)
		{
			throw new ArgumentNullException("frameName");
		}
		if (groupName == null)
		{
			throw new ArgumentNullException("groupName");
		}
		IntPtr arg = NSString.CreateNative(frameName);
		IntPtr arg2 = NSString.CreateNative(groupName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selInitWithFrameFrameNameGroupName_Handle, frame, arg, arg2);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selInitWithFrameFrameNameGroupName_Handle, frame, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("close")]
	public virtual void Close()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("setMaintainsBackForwardList:")]
	public virtual void SetMaintainsBackForwardList(bool flag)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetMaintainsBackForwardList_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMaintainsBackForwardList_Handle, flag);
		}
	}

	[Export("goBack")]
	public virtual bool GoBack()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selGoBackHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGoBackHandle);
	}

	[Export("goForward")]
	public virtual bool GoForward()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selGoForwardHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGoForwardHandle);
	}

	[Export("goToBackForwardItem:")]
	public virtual bool GoToBackForwardItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selGoToBackForwardItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToBackForwardItem_Handle, item.Handle);
	}

	[Export("userAgentForURL:")]
	public virtual string UserAgentForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUserAgentForURL_Handle, url.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUserAgentForURL_Handle, url.Handle));
	}

	[Export("stringByEvaluatingJavaScriptFromString:")]
	public virtual string StringByEvaluatingJavaScriptFromString(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByEvaluatingJavaScriptFromString_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByEvaluatingJavaScriptFromString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("searchFor:direction:caseSensitive:wrap:")]
	public virtual bool Search(string forString, bool forward, bool caseSensitive, bool wrap)
	{
		if (forString == null)
		{
			throw new ArgumentNullException("forString");
		}
		IntPtr arg = NSString.CreateNative(forString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool_bool(base.SuperHandle, selSearchForDirectionCaseSensitiveWrap_Handle, arg, forward, caseSensitive, wrap) : Messaging.bool_objc_msgSend_IntPtr_bool_bool_bool(base.Handle, selSearchForDirectionCaseSensitiveWrap_Handle, arg, forward, caseSensitive, wrap));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("registerViewClass:representationClass:forMIMEType:")]
	public static void RegisterViewClass(Class viewClass, Class representationClass, string mimeType)
	{
		if (viewClass == null)
		{
			throw new ArgumentNullException("viewClass");
		}
		if (representationClass == null)
		{
			throw new ArgumentNullException("representationClass");
		}
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRegisterViewClassRepresentationClassForMIMEType_Handle, viewClass.Handle, representationClass.Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("elementAtPoint:")]
	public virtual NSDictionary ElementAtPoint(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selElementAtPoint_Handle, point));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selElementAtPoint_Handle, point));
	}

	[Export("writeSelectionWithPasteboardTypes:toPasteboard:")]
	public virtual void WriteSelection(NSObject[] types, NSPasteboard pasteboard)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		NSArray nSArray = NSArray.FromNSObjects(types);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionWithPasteboardTypesToPasteboard_Handle, nSArray.Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionWithPasteboardTypesToPasteboard_Handle, nSArray.Handle, pasteboard.Handle);
		}
		nSArray.Dispose();
	}

	[Export("pasteboardTypesForElement:")]
	public virtual NSObject[] PasteboardTypesForElement(NSDictionary element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardTypesForElement_Handle, element.Handle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardTypesForElement_Handle, element.Handle));
	}

	[Export("writeElement:withPasteboardTypes:toPasteboard:")]
	public virtual void WriteElement(NSDictionary element, NSObject[] pasteboardTypes, NSPasteboard toPasteboard)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (pasteboardTypes == null)
		{
			throw new ArgumentNullException("pasteboardTypes");
		}
		if (toPasteboard == null)
		{
			throw new ArgumentNullException("toPasteboard");
		}
		NSArray nSArray = NSArray.FromNSObjects(pasteboardTypes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selWriteElementWithPasteboardTypesToPasteboard_Handle, element.Handle, nSArray.Handle, toPasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteElementWithPasteboardTypesToPasteboard_Handle, element.Handle, nSArray.Handle, toPasteboard.Handle);
		}
		nSArray.Dispose();
	}

	[Export("moveDragCaretToPoint:")]
	public virtual void MoveDragCaretToPoint(CGPoint point)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selMoveDragCaretToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selMoveDragCaretToPoint_Handle, point);
		}
	}

	[Export("removeDragCaret")]
	public virtual void RemoveDragCaret()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveDragCaretHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveDragCaretHandle);
		}
	}

	[Export("reload:")]
	public virtual void Reload(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReload_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReload_Handle, sender.Handle);
		}
	}

	[Export("reloadFromOrigin:")]
	public virtual void ReloadFromOrigin(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadFromOrigin_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadFromOrigin_Handle, sender.Handle);
		}
	}

	[Export("canGoBack")]
	public virtual bool CanGoBack()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanGoBackHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoBackHandle);
	}

	[Export("canGoForward")]
	public virtual bool CanGoForward()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanGoForwardHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoForwardHandle);
	}

	[Export("canMakeTextLarger")]
	public virtual bool CanMakeTextLarger()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextLargerHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextLargerHandle);
	}

	[Export("makeTextLarger:")]
	public virtual void MakeTextLarger(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextLarger_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextLarger_Handle, sender.Handle);
		}
	}

	[Export("canMakeTextSmaller")]
	public virtual bool CanMakeTextSmaller()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextSmallerHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextSmallerHandle);
	}

	[Export("makeTextSmaller:")]
	public virtual void MakeTextSmaller(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextSmaller_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextSmaller_Handle, sender.Handle);
		}
	}

	[Export("canMakeTextStandardSize")]
	public virtual bool CanMakeTextStandardSize()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextStandardSizeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextStandardSizeHandle);
	}

	[Export("makeTextStandardSize:")]
	public virtual void MakeTextStandardSize(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextStandardSize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextStandardSize_Handle, sender.Handle);
		}
	}

	[Export("toggleContinuousSpellChecking:")]
	public virtual void ToggleContinuousSpellChecking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
	}

	[Export("toggleSmartInsertDelete:")]
	public virtual void ToggleSmartInsertDelete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
	}

	[Export("styleDeclarationWithText:")]
	public virtual DomCssStyleDeclaration StyleDeclarationWithText(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		DomCssStyleDeclaration result = ((!IsDirectBinding) ? ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStyleDeclarationWithText_Handle, arg))) : ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStyleDeclarationWithText_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("replaceSelectionWithMarkupString:")]
	public virtual void ReplaceSelectionWithMarkupString(string markupString)
	{
		if (markupString == null)
		{
			throw new ArgumentNullException("markupString");
		}
		IntPtr arg = NSString.CreateNative(markupString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithMarkupString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithMarkupString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceSelectionWithArchive:")]
	public virtual void ReplaceSelectionWithArchive(WebArchive archive)
	{
		if (archive == null)
		{
			throw new ArgumentNullException("archive");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithArchive_Handle, archive.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithArchive_Handle, archive.Handle);
		}
	}

	[Export("deleteSelection")]
	public virtual void DeleteSelection()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeleteSelectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeleteSelectionHandle);
		}
	}

	[Export("applyStyle:")]
	public virtual void ApplyStyle(DomCssStyleDeclaration style)
	{
		if (style == null)
		{
			throw new ArgumentNullException("style");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selApplyStyle_Handle, style.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selApplyStyle_Handle, style.Handle);
		}
	}

	[Export("cut:")]
	public virtual void Cut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("paste:")]
	public virtual void Paste(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("copyFont:")]
	public virtual void CopyFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyFont_Handle, sender.Handle);
		}
	}

	[Export("pasteFont:")]
	public virtual void PasteFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteFont_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	public virtual void Delete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("pasteAsPlainText:")]
	public virtual void PasteAsPlainText(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsPlainText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsPlainText_Handle, sender.Handle);
		}
	}

	[Export("pasteAsRichText:")]
	public virtual void PasteAsRichText(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsRichText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsRichText_Handle, sender.Handle);
		}
	}

	[Export("changeFont:")]
	public virtual void ChangeFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeFont_Handle, sender.Handle);
		}
	}

	[Export("changeAttributes:")]
	public virtual void ChangeAttributes(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeAttributes_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeAttributes_Handle, sender.Handle);
		}
	}

	[Export("changeDocumentBackgroundColor:")]
	public virtual void ChangeDocumentBackgroundColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
	}

	[Export("changeColor:")]
	public virtual void ChangeColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeColor_Handle, sender.Handle);
		}
	}

	[Export("alignCenter:")]
	public virtual void AlignCenter(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignCenter_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignCenter_Handle, sender.Handle);
		}
	}

	[Export("alignJustified:")]
	public virtual void AlignJustified(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignJustified_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignJustified_Handle, sender.Handle);
		}
	}

	[Export("alignLeft:")]
	public virtual void AlignLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignLeft_Handle, sender.Handle);
		}
	}

	[Export("alignRight:")]
	public virtual void AlignRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignRight_Handle, sender.Handle);
		}
	}

	[Export("checkSpelling:")]
	public virtual void CheckSpelling(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckSpelling_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckSpelling_Handle, sender.Handle);
		}
	}

	[Export("showGuessPanel:")]
	public virtual void ShowGuessPanel(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowGuessPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowGuessPanel_Handle, sender.Handle);
		}
	}

	[Export("performFindPanelAction:")]
	public virtual void PerformFindPanelAction(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformFindPanelAction_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformFindPanelAction_Handle, sender.Handle);
		}
	}

	[Export("startSpeaking:")]
	public virtual void StartSpeaking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stopSpeaking:")]
	public virtual void StopSpeaking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSpeaking_Handle, sender.Handle);
		}
	}

	[Export("moveToBeginningOfSentence:")]
	public virtual void MoveToBeginningOfSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToBeginningOfSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToBeginningOfSentence_Handle, sender.Handle);
		}
	}

	[Export("moveToBeginningOfSentenceAndModifySelection:")]
	public virtual void MoveToBeginningOfSentenceAndModifySelection(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToBeginningOfSentenceAndModifySelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToBeginningOfSentenceAndModifySelection_Handle, sender.Handle);
		}
	}

	[Export("moveToEndOfSentence:")]
	public virtual void MoveToEndOfSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToEndOfSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToEndOfSentence_Handle, sender.Handle);
		}
	}

	[Export("moveToEndOfSentenceAndModifySelection:")]
	public virtual void MoveToEndOfSentenceAndModifySelection(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToEndOfSentenceAndModifySelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToEndOfSentenceAndModifySelection_Handle, sender.Handle);
		}
	}

	[Export("selectSentence:")]
	public virtual void SelectSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectSentence_Handle, sender.Handle);
		}
	}

	private _WebFrameLoadDelegate EnsureWebFrameLoadDelegate()
	{
		NSObject nSObject = WeakFrameLoadDelegate;
		if (nSObject == null || !(nSObject is _WebFrameLoadDelegate))
		{
			nSObject = (WeakFrameLoadDelegate = new _WebFrameLoadDelegate());
		}
		return (_WebFrameLoadDelegate)nSObject;
	}

	private _WebDownloadDelegate EnsureWebDownloadDelegate()
	{
		NSObject nSObject = WeakDownloadDelegate;
		if (nSObject == null || !(nSObject is _WebDownloadDelegate))
		{
			nSObject = (WeakDownloadDelegate = new _WebDownloadDelegate());
		}
		return (_WebDownloadDelegate)nSObject;
	}

	private _WebResourceLoadDelegate EnsureWebResourceLoadDelegate()
	{
		NSObject nSObject = WeakResourceLoadDelegate;
		if (nSObject == null || !(nSObject is _WebResourceLoadDelegate))
		{
			nSObject = (WeakResourceLoadDelegate = new _WebResourceLoadDelegate());
		}
		return (_WebResourceLoadDelegate)nSObject;
	}

	private _WebUIDelegate EnsureWebUIDelegate()
	{
		NSObject nSObject = WeakUIDelegate;
		if (nSObject == null || !(nSObject is _WebUIDelegate))
		{
			nSObject = (WeakUIDelegate = new _WebUIDelegate());
		}
		return (_WebUIDelegate)nSObject;
	}

	private _WebPolicyDelegate EnsureWebPolicyDelegate()
	{
		NSObject nSObject = WeakPolicyDelegate;
		if (nSObject == null || !(nSObject is _WebPolicyDelegate))
		{
			nSObject = (WeakPolicyDelegate = new _WebPolicyDelegate());
		}
		return (_WebPolicyDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MainFrame_var = null;
			__mt_SelectedFrame_var = null;
			__mt_BackForwardList_var = null;
			__mt_WindowScriptObject_var = null;
			__mt_PasteboardTypesForSelection_var = null;
			__mt_MainFrameDocument_var = null;
			__mt_MainFrameIcon_var = null;
			__mt_WeakResourceLoadDelegate_var = null;
			__mt_WeakDownloadDelegate_var = null;
			__mt_WeakFrameLoadDelegate_var = null;
			__mt_WeakUIDelegate_var = null;
			__mt_WeakPolicyDelegate_var = null;
			__mt_Preferences_var = null;
			__mt_HostWindow_var = null;
			__mt_SelectedDomRange_var = null;
			__mt_UndoManager_var = null;
			__mt_TypingStyle_var = null;
			__mt_EditingDelegate_var = null;
		}
	}
}
