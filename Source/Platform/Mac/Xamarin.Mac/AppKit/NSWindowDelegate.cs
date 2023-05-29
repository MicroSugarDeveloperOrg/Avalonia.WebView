using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindowDelegate", true)]
[Model]
public class NSWindowDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWindowDelegate()
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
	public NSWindowDelegate(NSCoder coder)
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
	public NSWindowDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSWindowDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("windowShouldClose:")]
	public virtual bool WindowShouldClose(NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillReturnFieldEditor:toObject:")]
	public virtual NSObject WillReturnFieldEditor(NSWindow sender, NSObject client)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillResize:toSize:")]
	public virtual CGSize WillResize(NSWindow sender, CGSize toFrameSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillUseStandardFrame:defaultFrame:")]
	public virtual CGRect WillUseStandardFrame(NSWindow window, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowShouldZoom:toFrame:")]
	public virtual bool ShouldZoom(NSWindow window, CGRect newFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillReturnUndoManager:")]
	public virtual NSUndoManager WillReturnUndoManager(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willPositionSheet:usingRect:")]
	public virtual CGRect WillPositionSheet(NSWindow window, NSWindow sheet, CGRect usingRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:shouldPopUpDocumentPathMenu:")]
	public virtual bool ShouldPopUpDocumentPathMenu(NSWindow window, NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:shouldDragDocumentWithEvent:from:withPasteboard:")]
	public virtual bool ShouldDragDocumentWithEvent(NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResize:")]
	public virtual void DidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExpose:")]
	public virtual void DidExpose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillMove:")]
	public virtual void WillMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidMove:")]
	public virtual void DidMoved(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidBecomeKey:")]
	public virtual void DidBecomeKey(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResignKey:")]
	public virtual void DidResignKey(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidBecomeMain:")]
	public virtual void DidBecomeMain(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidResignMain:")]
	public virtual void DidResignMain(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillClose:")]
	public virtual void WillClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillMiniaturize:")]
	public virtual void WillMiniaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidMiniaturize:")]
	public virtual void DidMiniaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidDeminiaturize:")]
	public virtual void DidDeminiaturize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidUpdate:")]
	public virtual void DidUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidChangeScreen:")]
	public virtual void DidChangeScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidChangeScreenProfile:")]
	public virtual void DidChangeScreenProfile(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillBeginSheet:")]
	public virtual void WillBeginSheet(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEndSheet:")]
	public virtual void DidEndSheet(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillStartLiveResize:")]
	public virtual void WillStartLiveResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEndLiveResize:")]
	public virtual void DidEndLiveResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillEnterFullScreen:")]
	public virtual void WillEnterFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEnterFullScreen:")]
	public virtual void DidEnterFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillExitFullScreen:")]
	public virtual void WillExitFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExitFullScreen:")]
	public virtual void DidExitFullScreen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidFailToEnterFullScreen:")]
	public virtual void DidFailToEnterFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidFailToExitFullScreen:")]
	public virtual void DidFailToExitFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willUseFullScreenContentSize:")]
	public virtual CGSize WillUseFullScreenContentSize(NSWindow window, CGSize proposedSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willUseFullScreenPresentationOptions:")]
	public virtual NSApplicationPresentationOptions WillUseFullScreenPresentationOptions(NSWindow window, NSApplicationPresentationOptions proposedOptions)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("customWindowsToEnterFullScreenForWindow:")]
	public virtual NSWindow[] CustomWindowsToEnterFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("customWindowsToExitFullScreenForWindow:")]
	public virtual NSWindow[] CustomWindowsToExitFullScreen(NSWindow window)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:startCustomAnimationToEnterFullScreenWithDuration:")]
	public virtual void StartCustomAnimationToEnterFullScreen(NSWindow window, double duration)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:startCustomAnimationToExitFullScreenWithDuration:")]
	public virtual void StartCustomAnimationToExitFullScreen(NSWindow window, double duration)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willEncodeRestorableState:")]
	public virtual void WillEncodeRestorableState(NSWindow window, NSCoder coder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:didDecodeRestorableState:")]
	public virtual void DidDecodeRestorableState(NSWindow window, NSCoder coder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:")]
	public virtual CGSize WillResizeForVersionBrowser(NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillEnterVersionBrowser:")]
	public virtual void WillEnterVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidEnterVersionBrowser:")]
	public virtual void DidEnterVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowWillExitVersionBrowser:")]
	public virtual void WillExitVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("windowDidExitVersionBrowser:")]
	public virtual void DidExitVersionBrowser(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
