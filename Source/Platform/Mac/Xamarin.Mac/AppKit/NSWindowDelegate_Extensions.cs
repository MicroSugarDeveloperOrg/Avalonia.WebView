using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSWindowDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WindowShouldClose(this INSWindowDelegate This, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowShouldClose:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject WillReturnFieldEditor(this INSWindowDelegate This, NSWindow sender, NSObject client)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("windowWillReturnFieldEditor:toObject:"), sender.Handle, client.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize WillResize(this INSWindowDelegate This, NSWindow sender, CGSize toFrameSize)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_CGSize(This.Handle, Selector.GetHandle("windowWillResize:toSize:"), sender.Handle, toFrameSize);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect WillUseStandardFrame(this INSWindowDelegate This, NSWindow window, CGRect newFrame)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect(out var retval, This.Handle, Selector.GetHandle("windowWillUseStandardFrame:defaultFrame:"), window.Handle, newFrame);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldZoom(this INSWindowDelegate This, NSWindow window, CGRect newFrame)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Messaging.bool_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("windowShouldZoom:toFrame:"), window.Handle, newFrame);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUndoManager WillReturnUndoManager(this INSWindowDelegate This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillReturnUndoManager:"), window.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect WillPositionSheet(this INSWindowDelegate This, NSWindow window, NSWindow sheet, CGRect usingRect)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (sheet == null)
		{
			throw new ArgumentNullException("sheet");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr_CGRect(out var retval, This.Handle, Selector.GetHandle("window:willPositionSheet:usingRect:"), window.Handle, sheet.Handle, usingRect);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldPopUpDocumentPathMenu(this INSWindowDelegate This, NSWindow window, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("window:shouldPopUpDocumentPathMenu:"), window.Handle, menu.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldDragDocumentWithEvent(this INSWindowDelegate This, NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (withPasteboard == null)
		{
			throw new ArgumentNullException("withPasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(This.Handle, Selector.GetHandle("window:shouldDragDocumentWithEvent:from:withPasteboard:"), window.Handle, theEvent.Handle, dragImageLocation, withPasteboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidResize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidExpose(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidExpose:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillMove(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillMove:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidMove(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidMove:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeKey(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidBecomeKey:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResignKey(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidResignKey:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeMain(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidBecomeMain:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResignMain(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidResignMain:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillClose(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillClose:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillMiniaturize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillMiniaturize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidMiniaturize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidMiniaturize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDeminiaturize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidDeminiaturize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdate(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidUpdate:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeScreen(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidChangeScreen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeScreenProfile(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidChangeScreenProfile:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillBeginSheet(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillBeginSheet:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndSheet(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidEndSheet:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartLiveResize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillStartLiveResize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndLiveResize(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidEndLiveResize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillEnterFullScreen(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillEnterFullScreen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEnterFullScreen(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidEnterFullScreen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillExitFullScreen(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillExitFullScreen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidExitFullScreen(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidExitFullScreen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailToEnterFullScreen(this INSWindowDelegate This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidFailToEnterFullScreen:"), window.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailToExitFullScreen(this INSWindowDelegate This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidFailToExitFullScreen:"), window.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize WillUseFullScreenContentSize(this INSWindowDelegate This, NSWindow window, CGSize proposedSize)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_CGSize(This.Handle, Selector.GetHandle("window:willUseFullScreenContentSize:"), window.Handle, proposedSize);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSApplicationPresentationOptions WillUseFullScreenPresentationOptions(this INSWindowDelegate This, NSWindow window, NSApplicationPresentationOptions proposedOptions)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return (NSApplicationPresentationOptions)Messaging.UInt64_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("window:willUseFullScreenPresentationOptions:"), window.Handle, (ulong)proposedOptions);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow[] CustomWindowsToEnterFullScreen(this INSWindowDelegate This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("customWindowsToEnterFullScreenForWindow:"), window.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow[] CustomWindowsToExitFullScreen(this INSWindowDelegate This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("customWindowsToExitFullScreenForWindow:"), window.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StartCustomAnimationToEnterFullScreen(this INSWindowDelegate This, NSWindow window, double duration)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("window:startCustomAnimationToEnterFullScreenWithDuration:"), window.Handle, duration);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StartCustomAnimationToExitFullScreen(this INSWindowDelegate This, NSWindow window, double duration)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("window:startCustomAnimationToExitFullScreenWithDuration:"), window.Handle, duration);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillEncodeRestorableState(this INSWindowDelegate This, NSWindow window, NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("window:willEncodeRestorableState:"), window.Handle, coder.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDecodeRestorableState(this INSWindowDelegate This, NSWindow window, NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("window:didDecodeRestorableState:"), window.Handle, coder.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize WillResizeForVersionBrowser(this INSWindowDelegate This, NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_CGSize_CGSize(This.Handle, Selector.GetHandle("window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:"), window.Handle, maxPreferredSize, maxAllowedSize);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillEnterVersionBrowser(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillEnterVersionBrowser:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEnterVersionBrowser(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidEnterVersionBrowser:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillExitVersionBrowser(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowWillExitVersionBrowser:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidExitVersionBrowser(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidExitVersionBrowser:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeBackingProperties(this INSWindowDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("windowDidChangeBackingProperties:"), notification.Handle);
	}
}
