using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Protocol]
[Register("QLPreviewPanelDelegate", false)]
[Model]
public class QLPreviewPanelDelegate : NSObject, IQLPreviewPanelDelegate, INativeObject, IDisposable, INSWindowDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLPreviewPanelDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QLPreviewPanelDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLPreviewPanelDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("customWindowsToEnterFullScreenForWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow[] CustomWindowsToEnterFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("customWindowsToExitFullScreenForWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow[] CustomWindowsToExitFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidBecomeKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeKey(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidBecomeMain:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeMain(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidChangeBackingProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeBackingProperties(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidChangeScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidChangeScreenProfile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeScreenProfile(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:didDecodeRestorableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDecodeRestorableState(NSWindow window, NSCoder coder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidDeminiaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDeminiaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEndLiveResize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndLiveResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEndSheet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndSheet(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEnterFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEnterFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEnterVersionBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEnterVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExitFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidExitFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExitVersionBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidExitVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExpose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidExpose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidFailToEnterFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailToEnterFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidFailToExitFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailToExitFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidMiniaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidMiniaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidMove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResignKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResignKey(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResignMain:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResignMain(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("previewPanel:handleEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandleEvent(QLPreviewPanel panel, NSEvent theEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:shouldDragDocumentWithEvent:from:withPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDragDocumentWithEvent(NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:shouldPopUpDocumentPathMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPopUpDocumentPathMenu(NSWindow window, NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowShouldZoom:toFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldZoom(NSWindow window, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("previewPanel:sourceFrameOnScreenForPreviewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SourceFrameOnScreenForPreviewItem(QLPreviewPanel panel, IQLPreviewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:startCustomAnimationToEnterFullScreenWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCustomAnimationToEnterFullScreen(NSWindow window, double duration)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:startCustomAnimationToExitFullScreenWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCustomAnimationToExitFullScreen(NSWindow window, double duration)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("previewPanel:transitionImageForPreviewItem:contentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject TransitionImageForPreviewItem(QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillBeginSheet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillBeginSheet(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willEncodeRestorableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillEncodeRestorableState(NSWindow window, NSCoder coder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillEnterFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillEnterFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillEnterVersionBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillEnterVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillExitFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillExitFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillExitVersionBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillExitVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillMiniaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillMiniaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillMove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willPositionSheet:usingRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect WillPositionSheet(NSWindow window, NSWindow sheet, CGRect usingRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillResize:toSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize WillResize(NSWindow sender, CGSize toFrameSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize WillResizeForVersionBrowser(NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillReturnFieldEditor:toObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject WillReturnFieldEditor(NSWindow sender, NSObject client)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillReturnUndoManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager WillReturnUndoManager(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillStartLiveResize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartLiveResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willUseFullScreenContentSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize WillUseFullScreenContentSize(NSWindow window, CGSize proposedSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willUseFullScreenPresentationOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSApplicationPresentationOptions WillUseFullScreenPresentationOptions(NSWindow window, NSApplicationPresentationOptions proposedOptions)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillUseStandardFrame:defaultFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect WillUseStandardFrame(NSWindow window, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowShouldClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WindowShouldClose(NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
