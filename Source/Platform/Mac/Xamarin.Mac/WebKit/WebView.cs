using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

[Register("WebView", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebView : NSView, INSUserInterfaceValidations, INativeObject, IDisposable
{
	[Register]
	internal class _WebFrameLoadDelegate : NSObject, IWebFrameLoadDelegate, INativeObject, IDisposable
	{
		internal EventHandler<WebFrameEventArgs>? canceledClientRedirect;

		internal EventHandler<WebFrameEventArgs>? changedLocationWithinPage;

		internal EventHandler<WebFrameScriptFrameEventArgs>? clearedWindowObject;

		internal EventHandler<WebFrameEventArgs>? commitedLoad;

		internal EventHandler<WebFrameJavaScriptContextEventArgs>? didCreateJavaScriptContext;

		internal EventHandler<WebFrameErrorEventArgs>? failedLoadWithError;

		internal EventHandler<WebFrameErrorEventArgs>? failedProvisionalLoad;

		internal EventHandler<WebFrameEventArgs>? finishedLoad;

		internal EventHandler<WebFrameImageEventArgs>? receivedIcon;

		internal EventHandler<WebFrameEventArgs>? receivedServerRedirectForProvisionalLoad;

		internal EventHandler<WebFrameTitleEventArgs>? receivedTitle;

		internal EventHandler<WebFrameEventArgs>? startedProvisionalLoad;

		internal EventHandler<WebFrameEventArgs>? willCloseFrame;

		internal EventHandler<WebFrameClientRedirectEventArgs>? willPerformClientRedirect;

		internal EventHandler<WebFrameScriptObjectEventArgs>? windowScriptObjectAvailable;

		public _WebFrameLoadDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("webView:didCancelClientRedirectForFrame:")]
		public void CanceledClientRedirect(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = canceledClientRedirect;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didChangeLocationWithinPageForFrame:")]
		public void ChangedLocationWithinPage(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = changedLocationWithinPage;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didClearWindowObject:forFrame:")]
		public void ClearedWindowObject(WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			EventHandler<WebFrameScriptFrameEventArgs> eventHandler = clearedWindowObject;
			if (eventHandler != null)
			{
				WebFrameScriptFrameEventArgs e = new WebFrameScriptFrameEventArgs(windowObject, forFrame);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didCommitLoadForFrame:")]
		public void CommitedLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = commitedLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didCreateJavaScriptContext:forFrame:")]
		public void DidCreateJavaScriptContext(WebView webView, JSContext context, WebFrame frame)
		{
			EventHandler<WebFrameJavaScriptContextEventArgs> eventHandler = didCreateJavaScriptContext;
			if (eventHandler != null)
			{
				WebFrameJavaScriptContextEventArgs e = new WebFrameJavaScriptContextEventArgs(context, frame);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didFailLoadWithError:forFrame:")]
		public void FailedLoadWithError(WebView sender, NSError error, WebFrame forFrame)
		{
			EventHandler<WebFrameErrorEventArgs> eventHandler = failedLoadWithError;
			if (eventHandler != null)
			{
				WebFrameErrorEventArgs e = new WebFrameErrorEventArgs(error, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didFailProvisionalLoadWithError:forFrame:")]
		public void FailedProvisionalLoad(WebView sender, NSError error, WebFrame forFrame)
		{
			EventHandler<WebFrameErrorEventArgs> eventHandler = failedProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameErrorEventArgs e = new WebFrameErrorEventArgs(error, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didFinishLoadForFrame:")]
		public void FinishedLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = finishedLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didReceiveIcon:forFrame:")]
		public void ReceivedIcon(WebView sender, NSImage image, WebFrame forFrame)
		{
			EventHandler<WebFrameImageEventArgs> eventHandler = receivedIcon;
			if (eventHandler != null)
			{
				WebFrameImageEventArgs e = new WebFrameImageEventArgs(image, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
		public void ReceivedServerRedirectForProvisionalLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = receivedServerRedirectForProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didReceiveTitle:forFrame:")]
		public void ReceivedTitle(WebView sender, string title, WebFrame forFrame)
		{
			EventHandler<WebFrameTitleEventArgs> eventHandler = receivedTitle;
			if (eventHandler != null)
			{
				WebFrameTitleEventArgs e = new WebFrameTitleEventArgs(title, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:didStartProvisionalLoadForFrame:")]
		public void StartedProvisionalLoad(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = startedProvisionalLoad;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:willCloseFrame:")]
		public void WillCloseFrame(WebView sender, WebFrame forFrame)
		{
			EventHandler<WebFrameEventArgs> eventHandler = willCloseFrame;
			if (eventHandler != null)
			{
				WebFrameEventArgs e = new WebFrameEventArgs(forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
		public void WillPerformClientRedirect(WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			EventHandler<WebFrameClientRedirectEventArgs> eventHandler = willPerformClientRedirect;
			if (eventHandler != null)
			{
				WebFrameClientRedirectEventArgs e = new WebFrameClientRedirectEventArgs(toUrl, secondsDelay, fireDate, forFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:windowScriptObjectAvailable:")]
		public void WindowScriptObjectAvailable(WebView webView, WebScriptObject windowScriptObject)
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
	internal class _WebDownloadDelegate : NSObject, IWebDownloadDelegate, INativeObject, IDisposable
	{
		internal WebDownloadRequest? onDownloadWindowForSheet;

		public _WebDownloadDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("downloadWindowForAuthenticationSheet:")]
		public NSWindow OnDownloadWindowForSheet(WebDownload download)
		{
			return onDownloadWindowForSheet?.Invoke(download);
		}
	}

	[Register]
	internal class _WebResourceLoadDelegate : NSObject, IWebResourceLoadDelegate, INativeObject, IDisposable
	{
		internal EventHandler<WebResourceCancelledChallengeEventArgs>? onCancelledAuthenticationChallenge;

		internal EventHandler<WebResourceErrorEventArgs>? onFailedLoading;

		internal EventHandler<WebResourceCompletedEventArgs>? onFinishedLoading;

		internal WebResourceIdentifierRequest? onIdentifierForInitialRequest;

		internal EventHandler<WebResourcePluginErrorEventArgs>? onPlugInFailed;

		internal EventHandler<WebResourceAuthenticationChallengeEventArgs>? onReceivedAuthenticationChallenge;

		internal EventHandler<WebResourceReceivedContentLengthEventArgs>? onReceivedContentLength;

		internal EventHandler<WebResourceReceivedResponseEventArgs>? onReceivedResponse;

		internal WebResourceOnRequestSend? onSendRequest;

		public _WebResourceLoadDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
		public void OnCancelledAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			EventHandler<WebResourceCancelledChallengeEventArgs> eventHandler = onCancelledAuthenticationChallenge;
			if (eventHandler != null)
			{
				WebResourceCancelledChallengeEventArgs e = new WebResourceCancelledChallengeEventArgs(identifier, challenge, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didFailLoadingWithError:fromDataSource:")]
		public void OnFailedLoading(WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			EventHandler<WebResourceErrorEventArgs> eventHandler = onFailedLoading;
			if (eventHandler != null)
			{
				WebResourceErrorEventArgs e = new WebResourceErrorEventArgs(identifier, withError, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didFinishLoadingFromDataSource:")]
		public void OnFinishedLoading(WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			EventHandler<WebResourceCompletedEventArgs> eventHandler = onFinishedLoading;
			if (eventHandler != null)
			{
				WebResourceCompletedEventArgs e = new WebResourceCompletedEventArgs(identifier, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:identifierForInitialRequest:fromDataSource:")]
		public NSObject OnIdentifierForInitialRequest(WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			return onIdentifierForInitialRequest?.Invoke(sender, request, dataSource);
		}

		[Preserve(Conditional = true)]
		[Export("webView:plugInFailedWithError:dataSource:")]
		public void OnPlugInFailed(WebView sender, NSError error, WebDataSource dataSource)
		{
			EventHandler<WebResourcePluginErrorEventArgs> eventHandler = onPlugInFailed;
			if (eventHandler != null)
			{
				WebResourcePluginErrorEventArgs e = new WebResourcePluginErrorEventArgs(error, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
		public void OnReceivedAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			EventHandler<WebResourceAuthenticationChallengeEventArgs> eventHandler = onReceivedAuthenticationChallenge;
			if (eventHandler != null)
			{
				WebResourceAuthenticationChallengeEventArgs e = new WebResourceAuthenticationChallengeEventArgs(identifier, challenge, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didReceiveContentLength:fromDataSource:")]
		public void OnReceivedContentLength(WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
		{
			EventHandler<WebResourceReceivedContentLengthEventArgs> eventHandler = onReceivedContentLength;
			if (eventHandler != null)
			{
				WebResourceReceivedContentLengthEventArgs e = new WebResourceReceivedContentLengthEventArgs(identifier, length, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:didReceiveResponse:fromDataSource:")]
		public void OnReceivedResponse(WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			EventHandler<WebResourceReceivedResponseEventArgs> eventHandler = onReceivedResponse;
			if (eventHandler != null)
			{
				WebResourceReceivedResponseEventArgs e = new WebResourceReceivedResponseEventArgs(identifier, responseReceived, dataSource);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
		public NSUrlRequest OnSendRequest(WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			WebResourceOnRequestSend webResourceOnRequestSend = onSendRequest;
			if (webResourceOnRequestSend != null)
			{
				return webResourceOnRequestSend(sender, identifier, request, redirectResponse, dataSource);
			}
			return request;
		}
	}

	[Register]
	internal class _WebUIDelegate : NSObject, IWebUIDelegate, INativeObject, IDisposable
	{
		internal WebViewGetBool? uIAreToolbarsVisible;

		internal EventHandler? uIClose;

		internal WebViewCreate? uICreateModalDialog;

		internal CreateWebViewFromRequest? uICreateWebView;

		internal DragSourceGetActionMask? uIDragSourceActionMask;

		internal EventHandler<WebViewFooterEventArgs>? uIDrawFooterInRect;

		internal EventHandler<WebViewHeaderEventArgs>? uIDrawHeaderInRect;

		internal EventHandler? uIFocus;

		internal WebViewGetRectangle? uIGetContentRect;

		internal WebViewGetContextMenuItems? uIGetContextMenuItems;

		internal DragDestinationGetActionMask? uIGetDragDestinationActionMask;

		internal WebViewGetResponder? uIGetFirstResponder;

		internal WebViewGetFloat? uIGetFooterHeight;

		internal WebViewGetRectangle? uIGetFrame;

		internal WebViewGetFloat? uIGetHeaderHeight;

		internal WebViewGetString? uIGetStatusText;

		internal WebViewGetBool? uIIsResizable;

		internal WebViewGetBool? uIIsStatusBarVisible;

		internal EventHandler<WebViewResponderEventArgs>? uIMakeFirstResponder;

		internal EventHandler<WebViewMouseMovedEventArgs>? uIMouseDidMoveOverElement;

		internal EventHandler<WebViewPrintEventArgs>? uIPrintFrameView;

		internal WebViewJavaScriptFrame? uIRunBeforeUnload;

		internal EventHandler<WebViewJavaScriptEventArgs>? uIRunJavaScriptAlertPanel;

		internal EventHandler<WebViewJavaScriptFrameEventArgs>? uIRunJavaScriptAlertPanelMessage;

		internal WebViewPrompt? uIRunJavaScriptConfirmPanel;

		internal WebViewConfirmationPanel? uIRunJavaScriptConfirmationPanel;

		internal WebViewJavaScriptInput? uIRunJavaScriptTextInputPanel;

		internal WebViewPromptPanel? uIRunJavaScriptTextInputPanelWithFrame;

		internal EventHandler? uIRunModal;

		internal EventHandler<WebViewRunOpenPanelEventArgs>? uIRunOpenPanelForFileButton;

		internal EventHandler<WebViewContentEventArgs>? uISetContentRect;

		internal EventHandler<WebViewFrameEventArgs>? uISetFrame;

		internal EventHandler<WebViewResizableEventArgs>? uISetResizable;

		internal EventHandler<WebViewStatusBarEventArgs>? uISetStatusBarVisible;

		internal EventHandler<WebViewStatusTextEventArgs>? uISetStatusText;

		internal EventHandler<WebViewToolBarsEventArgs>? uISetToolbarsVisible;

		internal WebViewPerformAction? uIShouldPerformActionfromSender;

		internal EventHandler? uIShow;

		internal EventHandler? uIUnfocus;

		internal WebViewValidateUserInterface? uIValidateUserInterfaceItem;

		internal EventHandler<WebViewDragEventArgs>? uIWillPerformDragDestination;

		internal EventHandler<WebViewPerformDragEventArgs>? uIWillPerformDragSource;

		public _WebUIDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("webViewAreToolbarsVisible:")]
		public bool UIAreToolbarsVisible(WebView sender)
		{
			WebViewGetBool webViewGetBool = uIAreToolbarsVisible;
			if (webViewGetBool != null)
			{
				return webViewGetBool(sender);
			}
			throw new Exception("No event handler has been added to the UIAreToolbarsVisible event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewClose:")]
		public void UIClose(WebView sender)
		{
			uIClose?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("webView:createWebViewModalDialogWithRequest:")]
		public WebView UICreateModalDialog(WebView sender, NSUrlRequest request)
		{
			return uICreateModalDialog?.Invoke(sender, request);
		}

		[Preserve(Conditional = true)]
		[Export("webView:createWebViewWithRequest:")]
		public WebView UICreateWebView(WebView sender, NSUrlRequest request)
		{
			return uICreateWebView?.Invoke(sender, request);
		}

		[Preserve(Conditional = true)]
		[Export("webView:dragSourceActionMaskForPoint:")]
		public NSEventModifierMask UIDragSourceActionMask(WebView webView, CGPoint point)
		{
			return uIDragSourceActionMask?.Invoke(webView, point) ?? ((NSEventModifierMask)0uL);
		}

		[Preserve(Conditional = true)]
		[Export("webView:drawFooterInRect:")]
		public void UIDrawFooterInRect(WebView sender, CGRect rect)
		{
			EventHandler<WebViewFooterEventArgs> eventHandler = uIDrawFooterInRect;
			if (eventHandler != null)
			{
				WebViewFooterEventArgs e = new WebViewFooterEventArgs(rect);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:drawHeaderInRect:")]
		public void UIDrawHeaderInRect(WebView sender, CGRect rect)
		{
			EventHandler<WebViewHeaderEventArgs> eventHandler = uIDrawHeaderInRect;
			if (eventHandler != null)
			{
				WebViewHeaderEventArgs e = new WebViewHeaderEventArgs(rect);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webViewFocus:")]
		public void UIFocus(WebView sender)
		{
			uIFocus?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("webViewContentRect:")]
		public CGRect UIGetContentRect(WebView sender)
		{
			WebViewGetRectangle webViewGetRectangle = uIGetContentRect;
			if (webViewGetRectangle != null)
			{
				return webViewGetRectangle(sender);
			}
			throw new Exception("No event handler has been added to the UIGetContentRect event.");
		}

		[Preserve(Conditional = true)]
		[Export("webView:contextMenuItemsForElement:defaultMenuItems:")]
		public NSMenuItem[] UIGetContextMenuItems(WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
		{
			return uIGetContextMenuItems?.Invoke(sender, forElement, defaultMenuItems);
		}

		[Preserve(Conditional = true)]
		[Export("webView:dragDestinationActionMaskForDraggingInfo:")]
		public NSEventModifierMask UIGetDragDestinationActionMask(WebView webView, NSDraggingInfo draggingInfo)
		{
			return uIGetDragDestinationActionMask?.Invoke(webView, draggingInfo) ?? ((NSEventModifierMask)0uL);
		}

		[Preserve(Conditional = true)]
		[Export("webViewFirstResponder:")]
		public NSResponder UIGetFirstResponder(WebView sender)
		{
			return uIGetFirstResponder?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		[Export("webViewFooterHeight:")]
		public float UIGetFooterHeight(WebView sender)
		{
			WebViewGetFloat webViewGetFloat = uIGetFooterHeight;
			if (webViewGetFloat != null)
			{
				return webViewGetFloat(sender);
			}
			throw new Exception("No event handler has been added to the UIGetFooterHeight event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewFrame:")]
		public CGRect UIGetFrame(WebView sender)
		{
			WebViewGetRectangle webViewGetRectangle = uIGetFrame;
			if (webViewGetRectangle != null)
			{
				return webViewGetRectangle(sender);
			}
			throw new Exception("No event handler has been added to the UIGetFrame event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewHeaderHeight:")]
		public float UIGetHeaderHeight(WebView sender)
		{
			WebViewGetFloat webViewGetFloat = uIGetHeaderHeight;
			if (webViewGetFloat != null)
			{
				return webViewGetFloat(sender);
			}
			throw new Exception("No event handler has been added to the UIGetHeaderHeight event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewStatusText:")]
		public string UIGetStatusText(WebView sender)
		{
			return uIGetStatusText?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		[Export("webViewIsResizable:")]
		public bool UIIsResizable(WebView sender)
		{
			WebViewGetBool webViewGetBool = uIIsResizable;
			if (webViewGetBool != null)
			{
				return webViewGetBool(sender);
			}
			throw new Exception("No event handler has been added to the UIIsResizable event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewIsStatusBarVisible:")]
		public bool UIIsStatusBarVisible(WebView sender)
		{
			return uIIsStatusBarVisible?.Invoke(sender) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("webView:makeFirstResponder:")]
		public void UIMakeFirstResponder(WebView sender, NSResponder newResponder)
		{
			EventHandler<WebViewResponderEventArgs> eventHandler = uIMakeFirstResponder;
			if (eventHandler != null)
			{
				WebViewResponderEventArgs e = new WebViewResponderEventArgs(newResponder);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:mouseDidMoveOverElement:modifierFlags:")]
		public void UIMouseDidMoveOverElement(WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
		{
			EventHandler<WebViewMouseMovedEventArgs> eventHandler = uIMouseDidMoveOverElement;
			if (eventHandler != null)
			{
				WebViewMouseMovedEventArgs e = new WebViewMouseMovedEventArgs(elementInformation, modifierFlags);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:printFrameView:")]
		public void UIPrintFrameView(WebView sender, WebFrameView frameView)
		{
			EventHandler<WebViewPrintEventArgs> eventHandler = uIPrintFrameView;
			if (eventHandler != null)
			{
				WebViewPrintEventArgs e = new WebViewPrintEventArgs(frameView);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
		public bool UIRunBeforeUnload(WebView sender, string message, WebFrame initiatedByFrame)
		{
			WebViewJavaScriptFrame webViewJavaScriptFrame = uIRunBeforeUnload;
			if (webViewJavaScriptFrame != null)
			{
				return webViewJavaScriptFrame(sender, message, initiatedByFrame);
			}
			throw new Exception("No event handler has been added to the UIRunBeforeUnload event.");
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptAlertPanelWithMessage:")]
		public void UIRunJavaScriptAlertPanel(WebView sender, string message)
		{
			EventHandler<WebViewJavaScriptEventArgs> eventHandler = uIRunJavaScriptAlertPanel;
			if (eventHandler != null)
			{
				WebViewJavaScriptEventArgs e = new WebViewJavaScriptEventArgs(message);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
		public void UIRunJavaScriptAlertPanelMessage(WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			EventHandler<WebViewJavaScriptFrameEventArgs> eventHandler = uIRunJavaScriptAlertPanelMessage;
			if (eventHandler != null)
			{
				WebViewJavaScriptFrameEventArgs e = new WebViewJavaScriptFrameEventArgs(withMessage, initiatedByFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptConfirmPanelWithMessage:")]
		public bool UIRunJavaScriptConfirmPanel(WebView sender, string message)
		{
			WebViewPrompt webViewPrompt = uIRunJavaScriptConfirmPanel;
			if (webViewPrompt != null)
			{
				return webViewPrompt(sender, message);
			}
			throw new Exception("No event handler has been added to the UIRunJavaScriptConfirmPanel event.");
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
		public bool UIRunJavaScriptConfirmationPanel(WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			WebViewConfirmationPanel webViewConfirmationPanel = uIRunJavaScriptConfirmationPanel;
			if (webViewConfirmationPanel != null)
			{
				return webViewConfirmationPanel(sender, withMessage, initiatedByFrame);
			}
			throw new Exception("No event handler has been added to the UIRunJavaScriptConfirmationPanel event.");
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
		public string UIRunJavaScriptTextInputPanel(WebView sender, string prompt, string defaultText)
		{
			return uIRunJavaScriptTextInputPanel?.Invoke(sender, prompt, defaultText);
		}

		[Preserve(Conditional = true)]
		[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
		public string UIRunJavaScriptTextInputPanelWithFrame(WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			return uIRunJavaScriptTextInputPanelWithFrame?.Invoke(sender, prompt, defaultText, initiatedByFrame);
		}

		[Preserve(Conditional = true)]
		[Export("webViewRunModal:")]
		public void UIRunModal(WebView sender)
		{
			uIRunModal?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("webView:runOpenPanelForFileButtonWithResultListener:")]
		public void UIRunOpenPanelForFileButton(WebView sender, IWebOpenPanelResultListener resultListener)
		{
			EventHandler<WebViewRunOpenPanelEventArgs> eventHandler = uIRunOpenPanelForFileButton;
			if (eventHandler != null)
			{
				WebViewRunOpenPanelEventArgs e = new WebViewRunOpenPanelEventArgs(resultListener);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setContentRect:")]
		public void UISetContentRect(WebView sender, CGRect frame)
		{
			EventHandler<WebViewContentEventArgs> eventHandler = uISetContentRect;
			if (eventHandler != null)
			{
				WebViewContentEventArgs e = new WebViewContentEventArgs(frame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setFrame:")]
		public void UISetFrame(WebView sender, CGRect newFrame)
		{
			EventHandler<WebViewFrameEventArgs> eventHandler = uISetFrame;
			if (eventHandler != null)
			{
				WebViewFrameEventArgs e = new WebViewFrameEventArgs(newFrame);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setResizable:")]
		public void UISetResizable(WebView sender, bool resizable)
		{
			EventHandler<WebViewResizableEventArgs> eventHandler = uISetResizable;
			if (eventHandler != null)
			{
				WebViewResizableEventArgs e = new WebViewResizableEventArgs(resizable);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setStatusBarVisible:")]
		public void UISetStatusBarVisible(WebView sender, bool visible)
		{
			EventHandler<WebViewStatusBarEventArgs> eventHandler = uISetStatusBarVisible;
			if (eventHandler != null)
			{
				WebViewStatusBarEventArgs e = new WebViewStatusBarEventArgs(visible);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setStatusText:")]
		public void UISetStatusText(WebView sender, string text)
		{
			EventHandler<WebViewStatusTextEventArgs> eventHandler = uISetStatusText;
			if (eventHandler != null)
			{
				WebViewStatusTextEventArgs e = new WebViewStatusTextEventArgs(text);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:setToolbarsVisible:")]
		public void UISetToolbarsVisible(WebView sender, bool visible)
		{
			EventHandler<WebViewToolBarsEventArgs> eventHandler = uISetToolbarsVisible;
			if (eventHandler != null)
			{
				WebViewToolBarsEventArgs e = new WebViewToolBarsEventArgs(visible);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:shouldPerformAction:fromSender:")]
		public bool UIShouldPerformActionfromSender(WebView webView, Selector action, NSObject sender)
		{
			WebViewPerformAction webViewPerformAction = uIShouldPerformActionfromSender;
			if (webViewPerformAction != null)
			{
				return webViewPerformAction(webView, action, sender);
			}
			throw new Exception("No event handler has been added to the UIShouldPerformActionfromSender event.");
		}

		[Preserve(Conditional = true)]
		[Export("webViewShow:")]
		public void UIShow(WebView sender)
		{
			uIShow?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("webViewUnfocus:")]
		public void UIUnfocus(WebView sender)
		{
			uIUnfocus?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("webView:validateUserInterfaceItem:defaultValidation:")]
		public bool UIValidateUserInterfaceItem(WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			return uIValidateUserInterfaceItem?.Invoke(webView, validatedUserInterfaceItem, defaultValidation) ?? defaultValidation;
		}

		[Preserve(Conditional = true)]
		[Export("webView:willPerformDragDestinationAction:forDraggingInfo:")]
		public void UIWillPerformDragDestination(WebView webView, WebDragDestinationAction action, NSDraggingInfo draggingInfo)
		{
			EventHandler<WebViewDragEventArgs> eventHandler = uIWillPerformDragDestination;
			if (eventHandler != null)
			{
				WebViewDragEventArgs e = new WebViewDragEventArgs(action, draggingInfo);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
		public void UIWillPerformDragSource(WebView webView, WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
		{
			EventHandler<WebViewPerformDragEventArgs> eventHandler = uIWillPerformDragSource;
			if (eventHandler != null)
			{
				WebViewPerformDragEventArgs e = new WebViewPerformDragEventArgs(action, sourcePoint, pasteboard);
				eventHandler(webView, e);
			}
		}
	}

	[Register]
	internal class _WebPolicyDelegate : NSObject, IWebPolicyDelegate, INativeObject, IDisposable
	{
		internal EventHandler<WebMimeTypePolicyEventArgs>? decidePolicyForMimeType;

		internal EventHandler<WebNavigationPolicyEventArgs>? decidePolicyForNavigation;

		internal EventHandler<WebNewWindowPolicyEventArgs>? decidePolicyForNewWindow;

		internal EventHandler<WebFailureToImplementPolicyEventArgs>? unableToImplementPolicy;

		public _WebPolicyDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("webView:decidePolicyForMIMEType:request:frame:decisionListener:")]
		public void DecidePolicyForMimeType(WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			EventHandler<WebMimeTypePolicyEventArgs> eventHandler = decidePolicyForMimeType;
			if (eventHandler != null)
			{
				WebMimeTypePolicyEventArgs e = new WebMimeTypePolicyEventArgs(mimeType, request, frame, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
		public void DecidePolicyForNavigation(WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			EventHandler<WebNavigationPolicyEventArgs> eventHandler = decidePolicyForNavigation;
			if (eventHandler != null)
			{
				WebNavigationPolicyEventArgs e = new WebNavigationPolicyEventArgs(actionInformation, request, frame, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
		public void DecidePolicyForNewWindow(WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			EventHandler<WebNewWindowPolicyEventArgs> eventHandler = decidePolicyForNewWindow;
			if (eventHandler != null)
			{
				WebNewWindowPolicyEventArgs e = new WebNewWindowPolicyEventArgs(actionInformation, request, newFrameName, decisionToken);
				eventHandler(webView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("webView:unableToImplementPolicyWithError:frame:")]
		public void UnableToImplementPolicy(WebView webView, NSError error, WebFrame frame)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMIMETypesShownAsHTML = "MIMETypesShownAsHTML";

	private static readonly IntPtr selMIMETypesShownAsHTMLHandle = Selector.GetHandle("MIMETypesShownAsHTML");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUIDelegate = "UIDelegate";

	private static readonly IntPtr selUIDelegateHandle = Selector.GetHandle("UIDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLFromPasteboard_ = "URLFromPasteboard:";

	private static readonly IntPtr selURLFromPasteboard_Handle = Selector.GetHandle("URLFromPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLTitleFromPasteboard_ = "URLTitleFromPasteboard:";

	private static readonly IntPtr selURLTitleFromPasteboard_Handle = Selector.GetHandle("URLTitleFromPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignCenter_ = "alignCenter:";

	private static readonly IntPtr selAlignCenter_Handle = Selector.GetHandle("alignCenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignJustified_ = "alignJustified:";

	private static readonly IntPtr selAlignJustified_Handle = Selector.GetHandle("alignJustified:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignLeft_ = "alignLeft:";

	private static readonly IntPtr selAlignLeft_Handle = Selector.GetHandle("alignLeft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignRight_ = "alignRight:";

	private static readonly IntPtr selAlignRight_Handle = Selector.GetHandle("alignRight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationNameForUserAgent = "applicationNameForUserAgent";

	private static readonly IntPtr selApplicationNameForUserAgentHandle = Selector.GetHandle("applicationNameForUserAgent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyStyle_ = "applyStyle:";

	private static readonly IntPtr selApplyStyle_Handle = Selector.GetHandle("applyStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackForwardList = "backForwardList";

	private static readonly IntPtr selBackForwardListHandle = Selector.GetHandle("backForwardList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoBack = "canGoBack";

	private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle("canGoBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoForward = "canGoForward";

	private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle("canGoForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanMakeTextLarger = "canMakeTextLarger";

	private static readonly IntPtr selCanMakeTextLargerHandle = Selector.GetHandle("canMakeTextLarger");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanMakeTextSmaller = "canMakeTextSmaller";

	private static readonly IntPtr selCanMakeTextSmallerHandle = Selector.GetHandle("canMakeTextSmaller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanMakeTextStandardSize = "canMakeTextStandardSize";

	private static readonly IntPtr selCanMakeTextStandardSizeHandle = Selector.GetHandle("canMakeTextStandardSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanShowMIMEType_ = "canShowMIMEType:";

	private static readonly IntPtr selCanShowMIMEType_Handle = Selector.GetHandle("canShowMIMEType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanShowMIMETypeAsHTML_ = "canShowMIMETypeAsHTML:";

	private static readonly IntPtr selCanShowMIMETypeAsHTML_Handle = Selector.GetHandle("canShowMIMETypeAsHTML:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeAttributes_ = "changeAttributes:";

	private static readonly IntPtr selChangeAttributes_Handle = Selector.GetHandle("changeAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeColor_ = "changeColor:";

	private static readonly IntPtr selChangeColor_Handle = Selector.GetHandle("changeColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeDocumentBackgroundColor_ = "changeDocumentBackgroundColor:";

	private static readonly IntPtr selChangeDocumentBackgroundColor_Handle = Selector.GetHandle("changeDocumentBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeFont_ = "changeFont:";

	private static readonly IntPtr selChangeFont_Handle = Selector.GetHandle("changeFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpelling_ = "checkSpelling:";

	private static readonly IntPtr selCheckSpelling_Handle = Selector.GetHandle("checkSpelling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyFont_ = "copyFont:";

	private static readonly IntPtr selCopyFont_Handle = Selector.GetHandle("copyFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomTextEncodingName = "customTextEncodingName";

	private static readonly IntPtr selCustomTextEncodingNameHandle = Selector.GetHandle("customTextEncodingName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomUserAgent = "customUserAgent";

	private static readonly IntPtr selCustomUserAgentHandle = Selector.GetHandle("customUserAgent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCut_ = "cut:";

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelete_ = "delete:";

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSelection = "deleteSelection";

	private static readonly IntPtr selDeleteSelectionHandle = Selector.GetHandle("deleteSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadDelegate = "downloadDelegate";

	private static readonly IntPtr selDownloadDelegateHandle = Selector.GetHandle("downloadDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditingDelegate = "editingDelegate";

	private static readonly IntPtr selEditingDelegateHandle = Selector.GetHandle("editingDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementAtPoint_ = "elementAtPoint:";

	private static readonly IntPtr selElementAtPoint_Handle = Selector.GetHandle("elementAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedProgress = "estimatedProgress";

	private static readonly IntPtr selEstimatedProgressHandle = Selector.GetHandle("estimatedProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameLoadDelegate = "frameLoadDelegate";

	private static readonly IntPtr selFrameLoadDelegateHandle = Selector.GetHandle("frameLoadDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoBack = "goBack";

	private static readonly IntPtr selGoBackHandle = Selector.GetHandle("goBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoForward = "goForward";

	private static readonly IntPtr selGoForwardHandle = Selector.GetHandle("goForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToBackForwardItem_ = "goToBackForwardItem:";

	private static readonly IntPtr selGoToBackForwardItem_Handle = Selector.GetHandle("goToBackForwardItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupName = "groupName";

	private static readonly IntPtr selGroupNameHandle = Selector.GetHandle("groupName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostWindow = "hostWindow";

	private static readonly IntPtr selHostWindowHandle = Selector.GetHandle("hostWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_FrameName_GroupName_ = "initWithFrame:frameName:groupName:";

	private static readonly IntPtr selInitWithFrame_FrameName_GroupName_Handle = Selector.GetHandle("initWithFrame:frameName:groupName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContinuousSpellCheckingEnabled = "isContinuousSpellCheckingEnabled";

	private static readonly IntPtr selIsContinuousSpellCheckingEnabledHandle = Selector.GetHandle("isContinuousSpellCheckingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoading = "isLoading";

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainFrame = "mainFrame";

	private static readonly IntPtr selMainFrameHandle = Selector.GetHandle("mainFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainFrameDocument = "mainFrameDocument";

	private static readonly IntPtr selMainFrameDocumentHandle = Selector.GetHandle("mainFrameDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainFrameIcon = "mainFrameIcon";

	private static readonly IntPtr selMainFrameIconHandle = Selector.GetHandle("mainFrameIcon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainFrameTitle = "mainFrameTitle";

	private static readonly IntPtr selMainFrameTitleHandle = Selector.GetHandle("mainFrameTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainFrameURL = "mainFrameURL";

	private static readonly IntPtr selMainFrameURLHandle = Selector.GetHandle("mainFrameURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaintainsInactiveSelection = "maintainsInactiveSelection";

	private static readonly IntPtr selMaintainsInactiveSelectionHandle = Selector.GetHandle("maintainsInactiveSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeTextLarger_ = "makeTextLarger:";

	private static readonly IntPtr selMakeTextLarger_Handle = Selector.GetHandle("makeTextLarger:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeTextSmaller_ = "makeTextSmaller:";

	private static readonly IntPtr selMakeTextSmaller_Handle = Selector.GetHandle("makeTextSmaller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeTextStandardSize_ = "makeTextStandardSize:";

	private static readonly IntPtr selMakeTextStandardSize_Handle = Selector.GetHandle("makeTextStandardSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaStyle = "mediaStyle";

	private static readonly IntPtr selMediaStyleHandle = Selector.GetHandle("mediaStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveDragCaretToPoint_ = "moveDragCaretToPoint:";

	private static readonly IntPtr selMoveDragCaretToPoint_Handle = Selector.GetHandle("moveDragCaretToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToBeginningOfSentence_ = "moveToBeginningOfSentence:";

	private static readonly IntPtr selMoveToBeginningOfSentence_Handle = Selector.GetHandle("moveToBeginningOfSentence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToBeginningOfSentenceAndModifySelection_ = "moveToBeginningOfSentenceAndModifySelection:";

	private static readonly IntPtr selMoveToBeginningOfSentenceAndModifySelection_Handle = Selector.GetHandle("moveToBeginningOfSentenceAndModifySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToEndOfSentence_ = "moveToEndOfSentence:";

	private static readonly IntPtr selMoveToEndOfSentence_Handle = Selector.GetHandle("moveToEndOfSentence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToEndOfSentenceAndModifySelection_ = "moveToEndOfSentenceAndModifySelection:";

	private static readonly IntPtr selMoveToEndOfSentenceAndModifySelection_Handle = Selector.GetHandle("moveToEndOfSentenceAndModifySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaste_ = "paste:";

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteAsPlainText_ = "pasteAsPlainText:";

	private static readonly IntPtr selPasteAsPlainText_Handle = Selector.GetHandle("pasteAsPlainText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteAsRichText_ = "pasteAsRichText:";

	private static readonly IntPtr selPasteAsRichText_Handle = Selector.GetHandle("pasteAsRichText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteFont_ = "pasteFont:";

	private static readonly IntPtr selPasteFont_Handle = Selector.GetHandle("pasteFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardTypesForElement_ = "pasteboardTypesForElement:";

	private static readonly IntPtr selPasteboardTypesForElement_Handle = Selector.GetHandle("pasteboardTypesForElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardTypesForSelection = "pasteboardTypesForSelection";

	private static readonly IntPtr selPasteboardTypesForSelectionHandle = Selector.GetHandle("pasteboardTypesForSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformFindPanelAction_ = "performFindPanelAction:";

	private static readonly IntPtr selPerformFindPanelAction_Handle = Selector.GetHandle("performFindPanelAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolicyDelegate = "policyDelegate";

	private static readonly IntPtr selPolicyDelegateHandle = Selector.GetHandle("policyDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferences = "preferences";

	private static readonly IntPtr selPreferencesHandle = Selector.GetHandle("preferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferencesIdentifier = "preferencesIdentifier";

	private static readonly IntPtr selPreferencesIdentifierHandle = Selector.GetHandle("preferencesIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterURLSchemeAsLocal_ = "registerURLSchemeAsLocal:";

	private static readonly IntPtr selRegisterURLSchemeAsLocal_Handle = Selector.GetHandle("registerURLSchemeAsLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterViewClass_RepresentationClass_ForMIMEType_ = "registerViewClass:representationClass:forMIMEType:";

	private static readonly IntPtr selRegisterViewClass_RepresentationClass_ForMIMEType_Handle = Selector.GetHandle("registerViewClass:representationClass:forMIMEType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReload_ = "reload:";

	private static readonly IntPtr selReload_Handle = Selector.GetHandle("reload:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadFromOrigin_ = "reloadFromOrigin:";

	private static readonly IntPtr selReloadFromOrigin_Handle = Selector.GetHandle("reloadFromOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDragCaret = "removeDragCaret";

	private static readonly IntPtr selRemoveDragCaretHandle = Selector.GetHandle("removeDragCaret");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceSelectionWithArchive_ = "replaceSelectionWithArchive:";

	private static readonly IntPtr selReplaceSelectionWithArchive_Handle = Selector.GetHandle("replaceSelectionWithArchive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceSelectionWithMarkupString_ = "replaceSelectionWithMarkupString:";

	private static readonly IntPtr selReplaceSelectionWithMarkupString_Handle = Selector.GetHandle("replaceSelectionWithMarkupString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceLoadDelegate = "resourceLoadDelegate";

	private static readonly IntPtr selResourceLoadDelegateHandle = Selector.GetHandle("resourceLoadDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchFor_Direction_CaseSensitive_Wrap_ = "searchFor:direction:caseSensitive:wrap:";

	private static readonly IntPtr selSearchFor_Direction_CaseSensitive_Wrap_Handle = Selector.GetHandle("searchFor:direction:caseSensitive:wrap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectSentence_ = "selectSentence:";

	private static readonly IntPtr selSelectSentence_Handle = Selector.GetHandle("selectSentence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedDOMRange = "selectedDOMRange";

	private static readonly IntPtr selSelectedDOMRangeHandle = Selector.GetHandle("selectedDOMRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedFrame = "selectedFrame";

	private static readonly IntPtr selSelectedFrameHandle = Selector.GetHandle("selectedFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionAffinity = "selectionAffinity";

	private static readonly IntPtr selSelectionAffinityHandle = Selector.GetHandle("selectionAffinity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApplicationNameForUserAgent_ = "setApplicationNameForUserAgent:";

	private static readonly IntPtr selSetApplicationNameForUserAgent_Handle = Selector.GetHandle("setApplicationNameForUserAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuousSpellCheckingEnabled_ = "setContinuousSpellCheckingEnabled:";

	private static readonly IntPtr selSetContinuousSpellCheckingEnabled_Handle = Selector.GetHandle("setContinuousSpellCheckingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomTextEncodingName_ = "setCustomTextEncodingName:";

	private static readonly IntPtr selSetCustomTextEncodingName_Handle = Selector.GetHandle("setCustomTextEncodingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomUserAgent_ = "setCustomUserAgent:";

	private static readonly IntPtr selSetCustomUserAgent_Handle = Selector.GetHandle("setCustomUserAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownloadDelegate_ = "setDownloadDelegate:";

	private static readonly IntPtr selSetDownloadDelegate_Handle = Selector.GetHandle("setDownloadDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditingDelegate_ = "setEditingDelegate:";

	private static readonly IntPtr selSetEditingDelegate_Handle = Selector.GetHandle("setEditingDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameLoadDelegate_ = "setFrameLoadDelegate:";

	private static readonly IntPtr selSetFrameLoadDelegate_Handle = Selector.GetHandle("setFrameLoadDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupName_ = "setGroupName:";

	private static readonly IntPtr selSetGroupName_Handle = Selector.GetHandle("setGroupName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHostWindow_ = "setHostWindow:";

	private static readonly IntPtr selSetHostWindow_Handle = Selector.GetHandle("setHostWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMIMETypesShownAsHTML_ = "setMIMETypesShownAsHTML:";

	private static readonly IntPtr selSetMIMETypesShownAsHTML_Handle = Selector.GetHandle("setMIMETypesShownAsHTML:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMainFrameURL_ = "setMainFrameURL:";

	private static readonly IntPtr selSetMainFrameURL_Handle = Selector.GetHandle("setMainFrameURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaintainsBackForwardList_ = "setMaintainsBackForwardList:";

	private static readonly IntPtr selSetMaintainsBackForwardList_Handle = Selector.GetHandle("setMaintainsBackForwardList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaStyle_ = "setMediaStyle:";

	private static readonly IntPtr selSetMediaStyle_Handle = Selector.GetHandle("setMediaStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPolicyDelegate_ = "setPolicyDelegate:";

	private static readonly IntPtr selSetPolicyDelegate_Handle = Selector.GetHandle("setPolicyDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferences_ = "setPreferences:";

	private static readonly IntPtr selSetPreferences_Handle = Selector.GetHandle("setPreferences:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferencesIdentifier_ = "setPreferencesIdentifier:";

	private static readonly IntPtr selSetPreferencesIdentifier_Handle = Selector.GetHandle("setPreferencesIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResourceLoadDelegate_ = "setResourceLoadDelegate:";

	private static readonly IntPtr selSetResourceLoadDelegate_Handle = Selector.GetHandle("setResourceLoadDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedDOMRange_Affinity_ = "setSelectedDOMRange:affinity:";

	private static readonly IntPtr selSetSelectedDOMRange_Affinity_Handle = Selector.GetHandle("setSelectedDOMRange:affinity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCloseWithWindow_ = "setShouldCloseWithWindow:";

	private static readonly IntPtr selSetShouldCloseWithWindow_Handle = Selector.GetHandle("setShouldCloseWithWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldUpdateWhileOffscreen_ = "setShouldUpdateWhileOffscreen:";

	private static readonly IntPtr selSetShouldUpdateWhileOffscreen_Handle = Selector.GetHandle("setShouldUpdateWhileOffscreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSmartInsertDeleteEnabled_ = "setSmartInsertDeleteEnabled:";

	private static readonly IntPtr selSetSmartInsertDeleteEnabled_Handle = Selector.GetHandle("setSmartInsertDeleteEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextSizeMultiplier_ = "setTextSizeMultiplier:";

	private static readonly IntPtr selSetTextSizeMultiplier_Handle = Selector.GetHandle("setTextSizeMultiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTypingStyle_ = "setTypingStyle:";

	private static readonly IntPtr selSetTypingStyle_Handle = Selector.GetHandle("setTypingStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUIDelegate_ = "setUIDelegate:";

	private static readonly IntPtr selSetUIDelegate_Handle = Selector.GetHandle("setUIDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCloseWithWindow = "shouldCloseWithWindow";

	private static readonly IntPtr selShouldCloseWithWindowHandle = Selector.GetHandle("shouldCloseWithWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldUpdateWhileOffscreen = "shouldUpdateWhileOffscreen";

	private static readonly IntPtr selShouldUpdateWhileOffscreenHandle = Selector.GetHandle("shouldUpdateWhileOffscreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowGuessPanel_ = "showGuessPanel:";

	private static readonly IntPtr selShowGuessPanel_Handle = Selector.GetHandle("showGuessPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartInsertDeleteEnabled = "smartInsertDeleteEnabled";

	private static readonly IntPtr selSmartInsertDeleteEnabledHandle = Selector.GetHandle("smartInsertDeleteEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpellCheckerDocumentTag = "spellCheckerDocumentTag";

	private static readonly IntPtr selSpellCheckerDocumentTagHandle = Selector.GetHandle("spellCheckerDocumentTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSpeaking_ = "startSpeaking:";

	private static readonly IntPtr selStartSpeaking_Handle = Selector.GetHandle("startSpeaking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSpeaking_ = "stopSpeaking:";

	private static readonly IntPtr selStopSpeaking_Handle = Selector.GetHandle("stopSpeaking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByEvaluatingJavaScriptFromString_ = "stringByEvaluatingJavaScriptFromString:";

	private static readonly IntPtr selStringByEvaluatingJavaScriptFromString_Handle = Selector.GetHandle("stringByEvaluatingJavaScriptFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyleDeclarationWithText_ = "styleDeclarationWithText:";

	private static readonly IntPtr selStyleDeclarationWithText_Handle = Selector.GetHandle("styleDeclarationWithText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsTextEncoding = "supportsTextEncoding";

	private static readonly IntPtr selSupportsTextEncodingHandle = Selector.GetHandle("supportsTextEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextSizeMultiplier = "textSizeMultiplier";

	private static readonly IntPtr selTextSizeMultiplierHandle = Selector.GetHandle("textSizeMultiplier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleContinuousSpellChecking_ = "toggleContinuousSpellChecking:";

	private static readonly IntPtr selToggleContinuousSpellChecking_Handle = Selector.GetHandle("toggleContinuousSpellChecking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleSmartInsertDelete_ = "toggleSmartInsertDelete:";

	private static readonly IntPtr selToggleSmartInsertDelete_Handle = Selector.GetHandle("toggleSmartInsertDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypingStyle = "typingStyle";

	private static readonly IntPtr selTypingStyleHandle = Selector.GetHandle("typingStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoManager = "undoManager";

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserAgentForURL_ = "userAgentForURL:";

	private static readonly IntPtr selUserAgentForURL_Handle = Selector.GetHandle("userAgentForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowScriptObject = "windowScriptObject";

	private static readonly IntPtr selWindowScriptObjectHandle = Selector.GetHandle("windowScriptObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteElement_WithPasteboardTypes_ToPasteboard_ = "writeElement:withPasteboardTypes:toPasteboard:";

	private static readonly IntPtr selWriteElement_WithPasteboardTypes_ToPasteboard_Handle = Selector.GetHandle("writeElement:withPasteboardTypes:toPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteSelectionWithPasteboardTypes_ToPasteboard_ = "writeSelectionWithPasteboardTypes:toPasteboard:";

	private static readonly IntPtr selWriteSelectionWithPasteboardTypes_ToPasteboard_Handle = Selector.GetHandle("writeSelectionWithPasteboardTypes:toPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_EditingDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDownloadDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakFrameLoadDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakPolicyDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakResourceLoadDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakUIDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ApplicationNameForUserAgent
	{
		[Export("applicationNameForUserAgent")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebBackForwardList BackForwardList
	{
		[Export("backForwardList")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebBackForwardList>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackForwardListHandle));
			}
			return Runtime.GetNSObject<WebBackForwardList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackForwardListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContinuousSpellCheckingEnabled
	{
		[Export("isContinuousSpellCheckingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousSpellCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousSpellCheckingEnabledHandle);
		}
		[Export("setContinuousSpellCheckingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CustomTextEncodingName
	{
		[Export("customTextEncodingName")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CustomUserAgent
	{
		[Export("customUserAgent")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWebDownloadDelegate DownloadDelegate
	{
		get
		{
			return WeakDownloadDelegate as IWebDownloadDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDownloadDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject EditingDelegate
	{
		[Export("editingDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEditingDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEditingDelegateHandle)));
			MarkDirty();
			__mt_EditingDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setEditingDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEditingDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEditingDelegate_Handle, value.Handle);
			}
			MarkDirty();
			__mt_EditingDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double EstimatedProgress
	{
		[Export("estimatedProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEstimatedProgressHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEstimatedProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWebFrameLoadDelegate FrameLoadDelegate
	{
		get
		{
			return WeakFrameLoadDelegate as IWebFrameLoadDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakFrameLoadDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GroupName
	{
		[Export("groupName")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow? HostWindow
	{
		[Export("hostWindow", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selHostWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostWindowHandle));
		}
		[Export("setHostWindow:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHostWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHostWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLoading
	{
		[Export("isLoading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame MainFrame
	{
		[Export("mainFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameHandle));
			}
			return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocument MainFrameDocument
	{
		[Export("mainFrameDocument")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameDocumentHandle));
			}
			return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage MainFrameIcon
	{
		[Export("mainFrameIcon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameIconHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameIconHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MainFrameTitle
	{
		[Export("mainFrameTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMainFrameTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainFrameTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MainFrameUrl
	{
		[Export("mainFrameURL")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MaintainsInactiveSelection
	{
		[Export("maintainsInactiveSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMaintainsInactiveSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMaintainsInactiveSelectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaStyle
	{
		[Export("mediaStyle")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboard[] PasteboardTypesForSelection
	{
		[Export("pasteboardTypesForSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPasteboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selPasteboardTypesForSelectionHandle));
			}
			return NSArray.ArrayFromHandle<NSPasteboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasteboardTypesForSelectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWebPolicyDelegate PolicyDelegate
	{
		get
		{
			return WeakPolicyDelegate as IWebPolicyDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakPolicyDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebPreferences Preferences
	{
		[Export("preferences", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebPreferences>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferencesHandle));
			}
			return Runtime.GetNSObject<WebPreferences>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferencesHandle));
		}
		[Export("setPreferences:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferences_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferences_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreferencesIdentifier
	{
		[Export("preferencesIdentifier")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWebResourceLoadDelegate ResourceLoadDelegate
	{
		get
		{
			return WeakResourceLoadDelegate as IWebResourceLoadDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakResourceLoadDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomRange SelectedDomRange
	{
		[Export("selectedDOMRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedDOMRangeHandle));
			}
			return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedDOMRangeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame SelectedFrame
	{
		[Export("selectedFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedFrameHandle));
			}
			return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSelectionAffinity SelectionAffinity
	{
		[Export("selectionAffinity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSSelectionAffinity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionAffinityHandle);
			}
			return (NSSelectionAffinity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionAffinityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCloseWithWindow
	{
		[Export("shouldCloseWithWindow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCloseWithWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCloseWithWindowHandle);
		}
		[Export("setShouldCloseWithWindow:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCloseWithWindow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCloseWithWindow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SmartInsertDeleteEnabled
	{
		[Export("smartInsertDeleteEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSmartInsertDeleteEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSmartInsertDeleteEnabledHandle);
		}
		[Export("setSmartInsertDeleteEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SpellCheckerDocumentTag
	{
		[Export("spellCheckerDocumentTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSpellCheckerDocumentTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSpellCheckerDocumentTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsTextEncoding
	{
		[Export("supportsTextEncoding")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTextEncodingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTextEncodingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float TextSizeMultiplier
	{
		[Export("textSizeMultiplier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTextSizeMultiplierHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTextSizeMultiplierHandle);
		}
		[Export("setTextSizeMultiplier:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetTextSizeMultiplier_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetTextSizeMultiplier_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssStyleDeclaration TypingStyle
	{
		[Export("typingStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend(base.Handle, selTypingStyleHandle));
			}
			return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypingStyleHandle));
		}
		[Export("setTypingStyle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypingStyle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypingStyle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWebUIDelegate UIDelegate
	{
		get
		{
			return WeakUIDelegate as IWebUIDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakUIDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager UndoManager
	{
		[Export("undoManager")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle));
			}
			return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateWhileOffscreen
	{
		[Export("shouldUpdateWhileOffscreen")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldUpdateWhileOffscreenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldUpdateWhileOffscreenHandle);
		}
		[Export("setShouldUpdateWhileOffscreen:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldUpdateWhileOffscreen_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldUpdateWhileOffscreen_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDownloadDelegate
	{
		[Export("downloadDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadDelegateHandle)));
			MarkDirty();
			__mt_WeakDownloadDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDownloadDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDownloadDelegate_var, value, GetInternalEventDownloadDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDownloadDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakFrameLoadDelegate
	{
		[Export("frameLoadDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameLoadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameLoadDelegateHandle)));
			MarkDirty();
			__mt_WeakFrameLoadDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setFrameLoadDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakFrameLoadDelegate_var, value, GetInternalEventFrameLoadDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakFrameLoadDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakPolicyDelegate
	{
		[Export("policyDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolicyDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPolicyDelegateHandle)));
			MarkDirty();
			__mt_WeakPolicyDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setPolicyDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakPolicyDelegate_var, value, GetInternalEventPolicyDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPolicyDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPolicyDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakPolicyDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakResourceLoadDelegate
	{
		[Export("resourceLoadDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceLoadDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceLoadDelegateHandle)));
			MarkDirty();
			__mt_WeakResourceLoadDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setResourceLoadDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakResourceLoadDelegate_var, value, GetInternalEventResourceLoadDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResourceLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResourceLoadDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakResourceLoadDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakUIDelegate
	{
		[Export("UIDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUIDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUIDelegateHandle)));
			MarkDirty();
			__mt_WeakUIDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setUIDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakUIDelegate_var, value, GetInternalEventUIDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakUIDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebScriptObject WindowScriptObject
	{
		[Export("windowScriptObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebScriptObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowScriptObjectHandle));
			}
			return Runtime.GetNSObject<WebScriptObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowScriptObjectHandle));
		}
	}

	internal virtual Type GetInternalEventFrameLoadDelegateType => typeof(_WebFrameLoadDelegate);

	internal virtual Type GetInternalEventDownloadDelegateType => typeof(_WebDownloadDelegate);

	internal virtual Type GetInternalEventResourceLoadDelegateType => typeof(_WebResourceLoadDelegate);

	internal virtual Type GetInternalEventUIDelegateType => typeof(_WebUIDelegate);

	internal virtual Type GetInternalEventPolicyDelegateType => typeof(_WebPolicyDelegate);

	public WebDownloadRequest? OnDownloadWindowForSheet
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

	public WebResourceIdentifierRequest? OnIdentifierForInitialRequest
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

	public WebResourceOnRequestSend? OnSendRequest
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

	public WebViewGetBool? UIAreToolbarsVisible
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

	public WebViewCreate? UICreateModalDialog
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

	public CreateWebViewFromRequest? UICreateWebView
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

	public DragSourceGetActionMask? UIDragSourceActionMask
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

	public WebViewGetRectangle? UIGetContentRect
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

	public WebViewGetContextMenuItems? UIGetContextMenuItems
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

	public DragDestinationGetActionMask? UIGetDragDestinationActionMask
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

	public WebViewGetResponder? UIGetFirstResponder
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

	public WebViewGetFloat? UIGetFooterHeight
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

	public WebViewGetRectangle? UIGetFrame
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

	public WebViewGetFloat? UIGetHeaderHeight
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

	public WebViewGetString? UIGetStatusText
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

	public WebViewGetBool? UIIsResizable
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

	public WebViewGetBool? UIIsStatusBarVisible
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

	public WebViewJavaScriptFrame? UIRunBeforeUnload
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

	public WebViewPrompt? UIRunJavaScriptConfirmPanel
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

	public WebViewConfirmationPanel? UIRunJavaScriptConfirmationPanel
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

	public WebViewJavaScriptInput? UIRunJavaScriptTextInputPanel
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

	public WebViewPromptPanel? UIRunJavaScriptTextInputPanelWithFrame
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

	public WebViewPerformAction? UIShouldPerformActionfromSender
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

	public WebViewValidateUserInterface? UIValidateUserInterfaceItem
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

	public event EventHandler<WebFrameJavaScriptContextEventArgs> DidCreateJavaScriptContext
	{
		add
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.didCreateJavaScriptContext = (EventHandler<WebFrameJavaScriptContextEventArgs>)Delegate.Combine(webFrameLoadDelegate.didCreateJavaScriptContext, value);
		}
		remove
		{
			_WebFrameLoadDelegate webFrameLoadDelegate = EnsureWebFrameLoadDelegate();
			webFrameLoadDelegate.didCreateJavaScriptContext = (EventHandler<WebFrameJavaScriptContextEventArgs>)Delegate.Remove(webFrameLoadDelegate.didCreateJavaScriptContext, value);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebView()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:frameName:groupName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WebView(CGRect frame, string? frameName, string? groupName)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(frameName);
		IntPtr arg2 = NSString.CreateNative(groupName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selInitWithFrame_FrameName_GroupName_Handle, frame, arg, arg2), "initWithFrame:frameName:groupName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selInitWithFrame_FrameName_GroupName_Handle, frame, arg, arg2), "initWithFrame:frameName:groupName:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WebView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("alignCenter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignCenter(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignCenter_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignCenter_Handle, sender.Handle);
		}
	}

	[Export("alignJustified:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignJustified(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignJustified_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignJustified_Handle, sender.Handle);
		}
	}

	[Export("alignLeft:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignLeft_Handle, sender.Handle);
		}
	}

	[Export("alignRight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignRight_Handle, sender.Handle);
		}
	}

	[Export("applyStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyStyle(DomCssStyleDeclaration style)
	{
		if (style == null)
		{
			throw new ArgumentNullException("style");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selApplyStyle_Handle, style.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selApplyStyle_Handle, style.Handle);
		}
	}

	[Export("canGoBack")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoBack()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanGoBackHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoBackHandle);
	}

	[Export("canGoForward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoForward()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanGoForwardHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoForwardHandle);
	}

	[Export("canMakeTextLarger")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanMakeTextLarger()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextLargerHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextLargerHandle);
	}

	[Export("canMakeTextSmaller")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanMakeTextSmaller()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextSmallerHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextSmallerHandle);
	}

	[Export("canMakeTextStandardSize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanMakeTextStandardSize()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanMakeTextStandardSizeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanMakeTextStandardSizeHandle);
	}

	[Export("canShowMIMEType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("changeAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeAttributes(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeAttributes_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeAttributes_Handle, sender.Handle);
		}
	}

	[Export("changeColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeColor_Handle, sender.Handle);
		}
	}

	[Export("changeDocumentBackgroundColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeDocumentBackgroundColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
	}

	[Export("changeFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeFont_Handle, sender.Handle);
		}
	}

	[Export("checkSpelling:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckSpelling(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckSpelling_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckSpelling_Handle, sender.Handle);
		}
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("copyFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CopyFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyFont_Handle, sender.Handle);
		}
	}

	[Export("cut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Delete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("deleteSelection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteSelection()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeleteSelectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeleteSelectionHandle);
		}
	}

	[Export("elementAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ElementAtPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selElementAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selElementAtPoint_Handle, point));
	}

	[Export("goBack")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GoBack()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selGoBackHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGoBackHandle);
	}

	[Export("goForward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GoForward()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selGoForwardHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGoForwardHandle);
	}

	[Export("goToBackForwardItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GoToBackForwardItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selGoToBackForwardItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToBackForwardItem_Handle, item.Handle);
	}

	[Export("makeTextLarger:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeTextLarger(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextLarger_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextLarger_Handle, sender.Handle);
		}
	}

	[Export("makeTextSmaller:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeTextSmaller(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextSmaller_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextSmaller_Handle, sender.Handle);
		}
	}

	[Export("makeTextStandardSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeTextStandardSize(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeTextStandardSize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeTextStandardSize_Handle, sender.Handle);
		}
	}

	[Export("moveDragCaretToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveDragCaretToPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selMoveDragCaretToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selMoveDragCaretToPoint_Handle, point);
		}
	}

	[Export("moveToBeginningOfSentence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveToBeginningOfSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToBeginningOfSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToBeginningOfSentence_Handle, sender.Handle);
		}
	}

	[Export("moveToBeginningOfSentenceAndModifySelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveToBeginningOfSentenceAndModifySelection(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToBeginningOfSentenceAndModifySelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToBeginningOfSentenceAndModifySelection_Handle, sender.Handle);
		}
	}

	[Export("moveToEndOfSentence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveToEndOfSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToEndOfSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToEndOfSentence_Handle, sender.Handle);
		}
	}

	[Export("moveToEndOfSentenceAndModifySelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveToEndOfSentenceAndModifySelection(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToEndOfSentenceAndModifySelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToEndOfSentenceAndModifySelection_Handle, sender.Handle);
		}
	}

	[Export("paste:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Paste(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("pasteAsPlainText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteAsPlainText(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsPlainText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsPlainText_Handle, sender.Handle);
		}
	}

	[Export("pasteAsRichText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteAsRichText(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsRichText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsRichText_Handle, sender.Handle);
		}
	}

	[Export("pasteFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteFont(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteFont_Handle, sender.Handle);
		}
	}

	[Export("pasteboardTypesForElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] PasteboardTypesForElement(NSDictionary element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardTypesForElement_Handle, element.Handle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardTypesForElement_Handle, element.Handle));
	}

	[Export("performFindPanelAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformFindPanelAction(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformFindPanelAction_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformFindPanelAction_Handle, sender.Handle);
		}
	}

	[Export("registerURLSchemeAsLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("registerViewClass:representationClass:forMIMEType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRegisterViewClass_RepresentationClass_ForMIMEType_Handle, viewClass.Handle, representationClass.Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("reload:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reload(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReload_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReload_Handle, sender.Handle);
		}
	}

	[Export("reloadFromOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadFromOrigin(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadFromOrigin_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadFromOrigin_Handle, sender.Handle);
		}
	}

	[Export("removeDragCaret")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDragCaret()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveDragCaretHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveDragCaretHandle);
		}
	}

	[Export("replaceSelectionWithArchive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceSelectionWithArchive(WebArchive archive)
	{
		if (archive == null)
		{
			throw new ArgumentNullException("archive");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithArchive_Handle, archive.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithArchive_Handle, archive.Handle);
		}
	}

	[Export("replaceSelectionWithMarkupString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceSelectionWithMarkupString(string markupString)
	{
		if (markupString == null)
		{
			throw new ArgumentNullException("markupString");
		}
		IntPtr arg = NSString.CreateNative(markupString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithMarkupString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithMarkupString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("searchFor:direction:caseSensitive:wrap:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Search(string forString, bool forward, bool caseSensitive, bool wrap)
	{
		if (forString == null)
		{
			throw new ArgumentNullException("forString");
		}
		IntPtr arg = NSString.CreateNative(forString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool_bool(base.SuperHandle, selSearchFor_Direction_CaseSensitive_Wrap_Handle, arg, forward, caseSensitive, wrap) : Messaging.bool_objc_msgSend_IntPtr_bool_bool_bool(base.Handle, selSearchFor_Direction_CaseSensitive_Wrap_Handle, arg, forward, caseSensitive, wrap));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("selectSentence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectSentence(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectSentence_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectSentence_Handle, sender.Handle);
		}
	}

	[Export("setMaintainsBackForwardList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMaintainsBackForwardList(bool flag)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetMaintainsBackForwardList_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMaintainsBackForwardList_Handle, flag);
		}
	}

	[Export("setSelectedDOMRange:affinity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedDomRange(DomRange? range, NSSelectionAffinity selectionAffinity)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selSetSelectedDOMRange_Affinity_Handle, range?.Handle ?? IntPtr.Zero, (ulong)selectionAffinity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selSetSelectedDOMRange_Affinity_Handle, range?.Handle ?? IntPtr.Zero, (ulong)selectionAffinity);
		}
	}

	[Export("showGuessPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowGuessPanel(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowGuessPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowGuessPanel_Handle, sender.Handle);
		}
	}

	[Export("startSpeaking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartSpeaking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stopSpeaking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSpeaking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stringByEvaluatingJavaScriptFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringByEvaluatingJavaScriptFromString(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByEvaluatingJavaScriptFromString_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByEvaluatingJavaScriptFromString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("styleDeclarationWithText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssStyleDeclaration StyleDeclarationWithText(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		DomCssStyleDeclaration result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStyleDeclarationWithText_Handle, arg)) : Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStyleDeclarationWithText_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("toggleContinuousSpellChecking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleContinuousSpellChecking(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
	}

	[Export("toggleSmartInsertDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleSmartInsertDelete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
	}

	[Export("URLFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl UrlFromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("URLTitleFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string UrlTitleFromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLTitleFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("userAgentForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UserAgentForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUserAgentForURL_Handle, url.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUserAgentForURL_Handle, url.Handle));
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	[Export("writeElement:withPasteboardTypes:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selWriteElement_WithPasteboardTypes_ToPasteboard_Handle, element.Handle, nSArray.Handle, toPasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteElement_WithPasteboardTypes_ToPasteboard_Handle, element.Handle, nSArray.Handle, toPasteboard.Handle);
		}
		nSArray.Dispose();
	}

	[Export("writeSelectionWithPasteboardTypes:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionWithPasteboardTypes_ToPasteboard_Handle, nSArray.Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionWithPasteboardTypes_ToPasteboard_Handle, nSArray.Handle, pasteboard.Handle);
		}
		nSArray.Dispose();
	}

	internal virtual _WebFrameLoadDelegate CreateInternalEventFrameLoadDelegateType()
	{
		return new _WebFrameLoadDelegate();
	}

	internal _WebFrameLoadDelegate EnsureWebFrameLoadDelegate()
	{
		if (WeakFrameLoadDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakFrameLoadDelegate, GetInternalEventFrameLoadDelegateType);
		}
		_WebFrameLoadDelegate webFrameLoadDelegate = FrameLoadDelegate as _WebFrameLoadDelegate;
		if (webFrameLoadDelegate == null)
		{
			webFrameLoadDelegate = (_WebFrameLoadDelegate)(FrameLoadDelegate = CreateInternalEventFrameLoadDelegateType());
		}
		return webFrameLoadDelegate;
	}

	internal virtual _WebDownloadDelegate CreateInternalEventDownloadDelegateType()
	{
		return new _WebDownloadDelegate();
	}

	internal _WebDownloadDelegate EnsureWebDownloadDelegate()
	{
		if (WeakDownloadDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDownloadDelegate, GetInternalEventDownloadDelegateType);
		}
		_WebDownloadDelegate webDownloadDelegate = DownloadDelegate as _WebDownloadDelegate;
		if (webDownloadDelegate == null)
		{
			webDownloadDelegate = (_WebDownloadDelegate)(DownloadDelegate = CreateInternalEventDownloadDelegateType());
		}
		return webDownloadDelegate;
	}

	internal virtual _WebResourceLoadDelegate CreateInternalEventResourceLoadDelegateType()
	{
		return new _WebResourceLoadDelegate();
	}

	internal _WebResourceLoadDelegate EnsureWebResourceLoadDelegate()
	{
		if (WeakResourceLoadDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakResourceLoadDelegate, GetInternalEventResourceLoadDelegateType);
		}
		_WebResourceLoadDelegate webResourceLoadDelegate = ResourceLoadDelegate as _WebResourceLoadDelegate;
		if (webResourceLoadDelegate == null)
		{
			webResourceLoadDelegate = (_WebResourceLoadDelegate)(ResourceLoadDelegate = CreateInternalEventResourceLoadDelegateType());
		}
		return webResourceLoadDelegate;
	}

	internal virtual _WebUIDelegate CreateInternalEventUIDelegateType()
	{
		return new _WebUIDelegate();
	}

	internal _WebUIDelegate EnsureWebUIDelegate()
	{
		if (WeakUIDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakUIDelegate, GetInternalEventUIDelegateType);
		}
		_WebUIDelegate webUIDelegate = UIDelegate as _WebUIDelegate;
		if (webUIDelegate == null)
		{
			webUIDelegate = (_WebUIDelegate)(UIDelegate = CreateInternalEventUIDelegateType());
		}
		return webUIDelegate;
	}

	internal virtual _WebPolicyDelegate CreateInternalEventPolicyDelegateType()
	{
		return new _WebPolicyDelegate();
	}

	internal _WebPolicyDelegate EnsureWebPolicyDelegate()
	{
		if (WeakPolicyDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakPolicyDelegate, GetInternalEventPolicyDelegateType);
		}
		_WebPolicyDelegate webPolicyDelegate = PolicyDelegate as _WebPolicyDelegate;
		if (webPolicyDelegate == null)
		{
			webPolicyDelegate = (_WebPolicyDelegate)(PolicyDelegate = CreateInternalEventPolicyDelegateType());
		}
		return webPolicyDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_EditingDelegate_var = null;
			__mt_WeakDownloadDelegate_var = null;
			__mt_WeakFrameLoadDelegate_var = null;
			__mt_WeakPolicyDelegate_var = null;
			__mt_WeakResourceLoadDelegate_var = null;
			__mt_WeakUIDelegate_var = null;
		}
	}
}
