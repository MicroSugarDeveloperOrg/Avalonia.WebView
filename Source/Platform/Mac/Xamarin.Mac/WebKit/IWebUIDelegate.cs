using System;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "WebUIDelegate", WrapperType = typeof(WebUIDelegateWrapper), FormalSince = "10.11")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UICreateWebView", Selector = "webView:createWebViewWithRequest:", ReturnType = typeof(WebView), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSUrlRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIShow", Selector = "webViewShow:", ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UICreateModalDialog", Selector = "webView:createWebViewModalDialogWithRequest:", ReturnType = typeof(WebView), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSUrlRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunModal", Selector = "webViewRunModal:", ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIClose", Selector = "webViewClose:", ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIFocus", Selector = "webViewFocus:", ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIUnfocus", Selector = "webViewUnfocus:", ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFirstResponder", Selector = "webViewFirstResponder:", ReturnType = typeof(NSResponder), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIMakeFirstResponder", Selector = "webView:makeFirstResponder:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSResponder)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetStatusText", Selector = "webView:setStatusText:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetStatusText", Selector = "webViewStatusText:", ReturnType = typeof(string), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIAreToolbarsVisible", Selector = "webViewAreToolbarsVisible:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetToolbarsVisible", Selector = "webView:setToolbarsVisible:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIIsStatusBarVisible", Selector = "webViewIsStatusBarVisible:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetStatusBarVisible", Selector = "webView:setStatusBarVisible:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIIsResizable", Selector = "webViewIsResizable:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetResizable", Selector = "webView:setResizable:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetFrame", Selector = "webView:setFrame:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFrame", Selector = "webViewFrame:", ReturnType = typeof(CGRect), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptAlertPanelMessage", Selector = "webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string),
	typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptConfirmationPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string),
	typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptTextInputPanelWithFrame", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string),
	typeof(string),
	typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunBeforeUnload", Selector = "webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string),
	typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunOpenPanelForFileButton", Selector = "webView:runOpenPanelForFileButtonWithResultListener:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(IWebOpenPanelResultListener)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIMouseDidMoveOverElement", Selector = "webView:mouseDidMoveOverElement:modifierFlags:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSDictionary),
	typeof(NSEventModifierMask)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetContextMenuItems", Selector = "webView:contextMenuItemsForElement:defaultMenuItems:", ReturnType = typeof(NSMenuItem[]), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSDictionary),
	typeof(NSMenuItem[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIValidateUserInterfaceItem", Selector = "webView:validateUserInterfaceItem:defaultValidation:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSObject),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIShouldPerformActionfromSender", Selector = "webView:shouldPerformAction:fromSender:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(Selector),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetDragDestinationActionMask", Selector = "webView:dragDestinationActionMaskForDraggingInfo:", ReturnType = typeof(NSEventModifierMask), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIWillPerformDragDestination", Selector = "webView:willPerformDragDestinationAction:forDraggingInfo:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(WebDragDestinationAction),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDragSourceActionMask", Selector = "webView:dragSourceActionMaskForPoint:", ReturnType = typeof(NSEventModifierMask), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIWillPerformDragSource", Selector = "webView:willPerformDragSourceAction:fromPoint:withPasteboard:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(WebDragSourceAction),
	typeof(CGPoint),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIPrintFrameView", Selector = "webView:printFrameView:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(WebFrameView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetHeaderHeight", Selector = "webViewHeaderHeight:", ReturnType = typeof(float), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFooterHeight", Selector = "webViewFooterHeight:", ReturnType = typeof(float), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDrawHeaderInRect", Selector = "webView:drawHeaderInRect:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDrawFooterInRect", Selector = "webView:drawFooterInRect:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptAlertPanel", Selector = "webView:runJavaScriptAlertPanelWithMessage:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptConfirmPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptTextInputPanel", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(WebView),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetContentRect", Selector = "webView:setContentRect:", ParameterType = new Type[]
{
	typeof(WebView),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetContentRect", Selector = "webViewContentRect:", ReturnType = typeof(CGRect), ParameterType = new Type[] { typeof(WebView) }, ParameterByRef = new bool[] { false })]
public interface IWebUIDelegate : INativeObject, IDisposable
{
}
