using System;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindow", true)]
public class NSWindow : NSResponder, INSAccessibility, INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAppearanceCustomization, INSMenuItemValidation, INSUserInterfaceItemIdentification, INSUserInterfaceValidations
{
	[Register]
	internal class _NSWindowDelegate : NSObject, INSWindowDelegate, INativeObject, IDisposable
	{
		internal NSWindowWindows? customWindowsToEnterFullScreen;

		internal NSWindowWindows? customWindowsToExitFullScreen;

		internal EventHandler? didBecomeKey;

		internal EventHandler? didBecomeMain;

		internal EventHandler? didChangeBackingProperties;

		internal EventHandler? didChangeScreen;

		internal EventHandler? didChangeScreenProfile;

		internal EventHandler<NSWindowCoderEventArgs>? didDecodeRestorableState;

		internal EventHandler? didDeminiaturize;

		internal EventHandler? didEndLiveResize;

		internal EventHandler? didEndSheet;

		internal EventHandler? didEnterFullScreen;

		internal EventHandler? didEnterVersionBrowser;

		internal EventHandler? didExitFullScreen;

		internal EventHandler? didExitVersionBrowser;

		internal EventHandler? didExpose;

		internal EventHandler? didFailToEnterFullScreen;

		internal EventHandler? didFailToExitFullScreen;

		internal EventHandler? didMiniaturize;

		internal EventHandler? didMove;

		internal EventHandler? didResignKey;

		internal EventHandler? didResignMain;

		internal EventHandler? didResize;

		internal EventHandler? didUpdate;

		internal NSWindowDocumentDrag? shouldDragDocumentWithEvent;

		internal NSWindowMenu? shouldPopUpDocumentPathMenu;

		internal NSWindowFramePredicate? shouldZoom;

		internal EventHandler<NSWindowDurationEventArgs>? startCustomAnimationToEnterFullScreen;

		internal EventHandler<NSWindowDurationEventArgs>? startCustomAnimationToExitFullScreen;

		internal EventHandler? willBeginSheet;

		internal EventHandler? willClose;

		internal EventHandler<NSWindowCoderEventArgs>? willEncodeRestorableState;

		internal EventHandler? willEnterFullScreen;

		internal EventHandler? willEnterVersionBrowser;

		internal EventHandler? willExitFullScreen;

		internal EventHandler? willExitVersionBrowser;

		internal EventHandler? willMiniaturize;

		internal EventHandler? willMove;

		internal NSWindowSheetRect? willPositionSheet;

		internal NSWindowResize? willResize;

		internal NSWindowSizeSize? willResizeForVersionBrowser;

		internal NSWindowClient? willReturnFieldEditor;

		internal NSWindowUndoManager? willReturnUndoManager;

		internal EventHandler? willStartLiveResize;

		internal NSWindowSize? willUseFullScreenContentSize;

		internal NSWindowApplicationPresentationOptions? willUseFullScreenPresentationOptions;

		internal NSWindowFrame? willUseStandardFrame;

		internal NSObjectPredicate? windowShouldClose;

		public _NSWindowDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("customWindowsToEnterFullScreenForWindow:")]
		public NSWindow[] CustomWindowsToEnterFullScreen(NSWindow window)
		{
			return customWindowsToEnterFullScreen?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		[Export("customWindowsToExitFullScreenForWindow:")]
		public NSWindow[] CustomWindowsToExitFullScreen(NSWindow window)
		{
			return customWindowsToExitFullScreen?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidBecomeKey:")]
		public void DidBecomeKey(NSNotification notification)
		{
			didBecomeKey?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidBecomeMain:")]
		public void DidBecomeMain(NSNotification notification)
		{
			didBecomeMain?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidChangeBackingProperties:")]
		public void DidChangeBackingProperties(NSNotification notification)
		{
			didChangeBackingProperties?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidChangeScreen:")]
		public void DidChangeScreen(NSNotification notification)
		{
			didChangeScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidChangeScreenProfile:")]
		public void DidChangeScreenProfile(NSNotification notification)
		{
			didChangeScreenProfile?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("window:didDecodeRestorableState:")]
		public void DidDecodeRestorableState(NSWindow window, NSCoder coder)
		{
			EventHandler<NSWindowCoderEventArgs> eventHandler = didDecodeRestorableState;
			if (eventHandler != null)
			{
				NSWindowCoderEventArgs e = new NSWindowCoderEventArgs(coder);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("windowDidDeminiaturize:")]
		public void DidDeminiaturize(NSNotification notification)
		{
			didDeminiaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidEndLiveResize:")]
		public void DidEndLiveResize(NSNotification notification)
		{
			didEndLiveResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidEndSheet:")]
		public void DidEndSheet(NSNotification notification)
		{
			didEndSheet?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidEnterFullScreen:")]
		public void DidEnterFullScreen(NSNotification notification)
		{
			didEnterFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidEnterVersionBrowser:")]
		public void DidEnterVersionBrowser(NSNotification notification)
		{
			didEnterVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidExitFullScreen:")]
		public void DidExitFullScreen(NSNotification notification)
		{
			didExitFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidExitVersionBrowser:")]
		public void DidExitVersionBrowser(NSNotification notification)
		{
			didExitVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidExpose:")]
		public void DidExpose(NSNotification notification)
		{
			didExpose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidFailToEnterFullScreen:")]
		public void DidFailToEnterFullScreen(NSWindow window)
		{
			didFailToEnterFullScreen?.Invoke(window, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidFailToExitFullScreen:")]
		public void DidFailToExitFullScreen(NSWindow window)
		{
			didFailToExitFullScreen?.Invoke(window, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidMiniaturize:")]
		public void DidMiniaturize(NSNotification notification)
		{
			didMiniaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidMove:")]
		public void DidMove(NSNotification notification)
		{
			didMove?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidResignKey:")]
		public void DidResignKey(NSNotification notification)
		{
			didResignKey?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidResignMain:")]
		public void DidResignMain(NSNotification notification)
		{
			didResignMain?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidResize:")]
		public void DidResize(NSNotification notification)
		{
			didResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowDidUpdate:")]
		public void DidUpdate(NSNotification notification)
		{
			didUpdate?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("window:shouldDragDocumentWithEvent:from:withPasteboard:")]
		public bool ShouldDragDocumentWithEvent(NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard)
		{
			return shouldDragDocumentWithEvent?.Invoke(window, theEvent, dragImageLocation, withPasteboard) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("window:shouldPopUpDocumentPathMenu:")]
		public bool ShouldPopUpDocumentPathMenu(NSWindow window, NSMenu menu)
		{
			return shouldPopUpDocumentPathMenu?.Invoke(window, menu) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("windowShouldZoom:toFrame:")]
		public bool ShouldZoom(NSWindow window, CGRect newFrame)
		{
			return shouldZoom?.Invoke(window, newFrame) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("window:startCustomAnimationToEnterFullScreenWithDuration:")]
		public void StartCustomAnimationToEnterFullScreen(NSWindow window, double duration)
		{
			EventHandler<NSWindowDurationEventArgs> eventHandler = startCustomAnimationToEnterFullScreen;
			if (eventHandler != null)
			{
				NSWindowDurationEventArgs e = new NSWindowDurationEventArgs(duration);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("window:startCustomAnimationToExitFullScreenWithDuration:")]
		public void StartCustomAnimationToExitFullScreen(NSWindow window, double duration)
		{
			EventHandler<NSWindowDurationEventArgs> eventHandler = startCustomAnimationToExitFullScreen;
			if (eventHandler != null)
			{
				NSWindowDurationEventArgs e = new NSWindowDurationEventArgs(duration);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("windowWillBeginSheet:")]
		public void WillBeginSheet(NSNotification notification)
		{
			willBeginSheet?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillClose:")]
		public void WillClose(NSNotification notification)
		{
			willClose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("window:willEncodeRestorableState:")]
		public void WillEncodeRestorableState(NSWindow window, NSCoder coder)
		{
			EventHandler<NSWindowCoderEventArgs> eventHandler = willEncodeRestorableState;
			if (eventHandler != null)
			{
				NSWindowCoderEventArgs e = new NSWindowCoderEventArgs(coder);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("windowWillEnterFullScreen:")]
		public void WillEnterFullScreen(NSNotification notification)
		{
			willEnterFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillEnterVersionBrowser:")]
		public void WillEnterVersionBrowser(NSNotification notification)
		{
			willEnterVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillExitFullScreen:")]
		public void WillExitFullScreen(NSNotification notification)
		{
			willExitFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillExitVersionBrowser:")]
		public void WillExitVersionBrowser(NSNotification notification)
		{
			willExitVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillMiniaturize:")]
		public void WillMiniaturize(NSNotification notification)
		{
			willMiniaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillMove:")]
		public void WillMove(NSNotification notification)
		{
			willMove?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("window:willPositionSheet:usingRect:")]
		public CGRect WillPositionSheet(NSWindow window, NSWindow sheet, CGRect usingRect)
		{
			return willPositionSheet?.Invoke(window, sheet, usingRect) ?? usingRect;
		}

		[Preserve(Conditional = true)]
		[Export("windowWillResize:toSize:")]
		public CGSize WillResize(NSWindow sender, CGSize toFrameSize)
		{
			return willResize?.Invoke(sender, toFrameSize) ?? toFrameSize;
		}

		[Preserve(Conditional = true)]
		[Export("window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:")]
		public CGSize WillResizeForVersionBrowser(NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
		{
			return willResizeForVersionBrowser?.Invoke(window, maxPreferredSize, maxAllowedSize) ?? maxPreferredSize;
		}

		[Preserve(Conditional = true)]
		[Export("windowWillReturnFieldEditor:toObject:")]
		public NSObject WillReturnFieldEditor(NSWindow sender, NSObject client)
		{
			return willReturnFieldEditor?.Invoke(sender, client);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillReturnUndoManager:")]
		public NSUndoManager WillReturnUndoManager(NSWindow window)
		{
			return willReturnUndoManager?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		[Export("windowWillStartLiveResize:")]
		public void WillStartLiveResize(NSNotification notification)
		{
			willStartLiveResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("window:willUseFullScreenContentSize:")]
		public CGSize WillUseFullScreenContentSize(NSWindow window, CGSize proposedSize)
		{
			return willUseFullScreenContentSize?.Invoke(window, proposedSize) ?? proposedSize;
		}

		[Preserve(Conditional = true)]
		[Export("window:willUseFullScreenPresentationOptions:")]
		public NSApplicationPresentationOptions WillUseFullScreenPresentationOptions(NSWindow window, NSApplicationPresentationOptions proposedOptions)
		{
			return willUseFullScreenPresentationOptions?.Invoke(window, proposedOptions) ?? proposedOptions;
		}

		[Preserve(Conditional = true)]
		[Export("windowWillUseStandardFrame:defaultFrame:")]
		public CGRect WillUseStandardFrame(NSWindow window, CGRect newFrame)
		{
			return willUseStandardFrame?.Invoke(window, newFrame) ?? newFrame;
		}

		[Preserve(Conditional = true)]
		[Export("windowShouldClose:")]
		public bool WindowShouldClose(NSObject sender)
		{
			return windowShouldClose?.Invoke(sender) ?? true;
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveAnnouncementRequested(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnouncementRequestedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnouncementRequested(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnouncementRequestedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationActivated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationActivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationActivated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationActivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationDeactivated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationDeactivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationDeactivated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationDeactivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationHidden(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationHiddenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationHidden(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationHiddenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationShown(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationShownNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationShown(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationShownNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBecomeKey(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBecomeKeyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBecomeKey(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBecomeKeyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBecomeMain(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBecomeMainNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBecomeMain(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBecomeMainNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeBackingProperties(EventHandler<NSWindowBackingPropertiesEventArgs> handler)
		{
			EventHandler<NSWindowBackingPropertiesEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeBackingPropertiesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWindowBackingPropertiesEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeBackingProperties(NSObject objectToObserve, EventHandler<NSWindowBackingPropertiesEventArgs> handler)
		{
			EventHandler<NSWindowBackingPropertiesEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeBackingPropertiesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWindowBackingPropertiesEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeScreen(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeScreen(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeScreenProfile(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeScreenProfileNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeScreenProfile(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeScreenProfileNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidDeminiaturize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDeminiaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidDeminiaturize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDeminiaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndLiveResize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndLiveResize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndSheet(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndSheetNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndSheet(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndSheetNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEnterFullScreen(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEnterFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEnterFullScreen(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEnterFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEnterVersionBrowser(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEnterVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEnterVersionBrowser(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEnterVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidExitFullScreen(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExitFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidExitFullScreen(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExitFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidExitVersionBrowser(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExitVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidExitVersionBrowser(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExitVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidExpose(EventHandler<NSWindowExposeEventArgs> handler)
		{
			EventHandler<NSWindowExposeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExposeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWindowExposeEventArgs(notification));
			});
		}

		public static NSObject ObserveDidExpose(NSObject objectToObserve, EventHandler<NSWindowExposeEventArgs> handler)
		{
			EventHandler<NSWindowExposeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidExposeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWindowExposeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidMiniaturize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidMiniaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidMiniaturize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidMiniaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidMove(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidMove(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidResignKey(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResignKeyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidResignKey(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResignKeyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidResignMain(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResignMainNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidResignMain(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResignMainNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidResize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidResize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUpdate(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUpdate(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDrawerCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DrawerCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDrawerCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DrawerCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFocusedWindowChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusedWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFocusedWindowChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusedWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveHelpTagCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(HelpTagCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveHelpTagCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(HelpTagCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveLayoutChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LayoutChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveLayoutChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LayoutChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMainWindowChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MainWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMainWindowChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MainWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveResized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveResized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowCollapsed(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCollapsedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowCollapsed(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCollapsedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowCountChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowCountChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowExpanded(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowExpandedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowExpanded(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowExpandedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedCellsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedCellsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedCellsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedCellsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedChildrenChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedChildrenChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedChildrenMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedChildrenMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedColumnsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedColumnsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedColumnsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedColumnsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedRowsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedRowsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedRowsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedRowsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedTextChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedTextChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedTextChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedTextChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSheetCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SheetCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSheetCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SheetCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTitleChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TitleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTitleChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TitleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUIElementDestroyed(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementDestroyedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUIElementDestroyed(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementDestroyedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUIElementFocusedChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementFocusedChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUIElementFocusedChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementFocusedChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUnitsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UnitsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUnitsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UnitsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveValueChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ValueChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveValueChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ValueChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillBeginSheet(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillBeginSheetNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillBeginSheet(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillBeginSheetNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillClose(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillClose(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillEnterFullScreen(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillEnterFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillEnterFullScreen(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillEnterFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillEnterVersionBrowser(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillEnterVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillEnterVersionBrowser(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillEnterVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillExitFullScreen(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillExitFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillExitFullScreen(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillExitFullScreenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillExitVersionBrowser(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillExitVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillExitVersionBrowser(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillExitVersionBrowserNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillMiniaturize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillMiniaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillMiniaturize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillMiniaturizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillMove(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillMove(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillStartLiveResize(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillStartLiveResize(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowDeminiaturized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowDeminiaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowDeminiaturized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowDeminiaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowMiniaturized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMiniaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowMiniaturized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMiniaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowResized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowResized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	public static bool DisableReleasedWhenClosedInConstructor;

	private static IntPtr selInitWithWindowRef = Selector.GetHandle("initWithWindowRef:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsMouseMovedEvents = "acceptsMouseMovedEvents";

	private static readonly IntPtr selAcceptsMouseMovedEventsHandle = Selector.GetHandle("acceptsMouseMovedEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityActivationPoint = "accessibilityActivationPoint";

	private static readonly IntPtr selAccessibilityActivationPointHandle = Selector.GetHandle("accessibilityActivationPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAllowedValues = "accessibilityAllowedValues";

	private static readonly IntPtr selAccessibilityAllowedValuesHandle = Selector.GetHandle("accessibilityAllowedValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityApplicationFocusedUIElement = "accessibilityApplicationFocusedUIElement";

	private static readonly IntPtr selAccessibilityApplicationFocusedUIElementHandle = Selector.GetHandle("accessibilityApplicationFocusedUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributedStringForRange_ = "accessibilityAttributedStringForRange:";

	private static readonly IntPtr selAccessibilityAttributedStringForRange_Handle = Selector.GetHandle("accessibilityAttributedStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCancelButton = "accessibilityCancelButton";

	private static readonly IntPtr selAccessibilityCancelButtonHandle = Selector.GetHandle("accessibilityCancelButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCellForColumn_Row_ = "accessibilityCellForColumn:row:";

	private static readonly IntPtr selAccessibilityCellForColumn_Row_Handle = Selector.GetHandle("accessibilityCellForColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityChildren = "accessibilityChildren";

	private static readonly IntPtr selAccessibilityChildrenHandle = Selector.GetHandle("accessibilityChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityChildrenInNavigationOrder = "accessibilityChildrenInNavigationOrder";

	private static readonly IntPtr selAccessibilityChildrenInNavigationOrderHandle = Selector.GetHandle("accessibilityChildrenInNavigationOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityClearButton = "accessibilityClearButton";

	private static readonly IntPtr selAccessibilityClearButtonHandle = Selector.GetHandle("accessibilityClearButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCloseButton = "accessibilityCloseButton";

	private static readonly IntPtr selAccessibilityCloseButtonHandle = Selector.GetHandle("accessibilityCloseButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnCount = "accessibilityColumnCount";

	private static readonly IntPtr selAccessibilityColumnCountHandle = Selector.GetHandle("accessibilityColumnCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnHeaderUIElements = "accessibilityColumnHeaderUIElements";

	private static readonly IntPtr selAccessibilityColumnHeaderUIElementsHandle = Selector.GetHandle("accessibilityColumnHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnIndexRange = "accessibilityColumnIndexRange";

	private static readonly IntPtr selAccessibilityColumnIndexRangeHandle = Selector.GetHandle("accessibilityColumnIndexRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnTitles = "accessibilityColumnTitles";

	private static readonly IntPtr selAccessibilityColumnTitlesHandle = Selector.GetHandle("accessibilityColumnTitles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumns = "accessibilityColumns";

	private static readonly IntPtr selAccessibilityColumnsHandle = Selector.GetHandle("accessibilityColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityContents = "accessibilityContents";

	private static readonly IntPtr selAccessibilityContentsHandle = Selector.GetHandle("accessibilityContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCriticalValue = "accessibilityCriticalValue";

	private static readonly IntPtr selAccessibilityCriticalValueHandle = Selector.GetHandle("accessibilityCriticalValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCustomActions = "accessibilityCustomActions";

	private static readonly IntPtr selAccessibilityCustomActionsHandle = Selector.GetHandle("accessibilityCustomActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCustomRotors = "accessibilityCustomRotors";

	private static readonly IntPtr selAccessibilityCustomRotorsHandle = Selector.GetHandle("accessibilityCustomRotors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDecrementButton = "accessibilityDecrementButton";

	private static readonly IntPtr selAccessibilityDecrementButtonHandle = Selector.GetHandle("accessibilityDecrementButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDefaultButton = "accessibilityDefaultButton";

	private static readonly IntPtr selAccessibilityDefaultButtonHandle = Selector.GetHandle("accessibilityDefaultButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosedByRow = "accessibilityDisclosedByRow";

	private static readonly IntPtr selAccessibilityDisclosedByRowHandle = Selector.GetHandle("accessibilityDisclosedByRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosedRows = "accessibilityDisclosedRows";

	private static readonly IntPtr selAccessibilityDisclosedRowsHandle = Selector.GetHandle("accessibilityDisclosedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosureLevel = "accessibilityDisclosureLevel";

	private static readonly IntPtr selAccessibilityDisclosureLevelHandle = Selector.GetHandle("accessibilityDisclosureLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDocument = "accessibilityDocument";

	private static readonly IntPtr selAccessibilityDocumentHandle = Selector.GetHandle("accessibilityDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityExtrasMenuBar = "accessibilityExtrasMenuBar";

	private static readonly IntPtr selAccessibilityExtrasMenuBarHandle = Selector.GetHandle("accessibilityExtrasMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFilename = "accessibilityFilename";

	private static readonly IntPtr selAccessibilityFilenameHandle = Selector.GetHandle("accessibilityFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFocusedWindow = "accessibilityFocusedWindow";

	private static readonly IntPtr selAccessibilityFocusedWindowHandle = Selector.GetHandle("accessibilityFocusedWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrameForRange_ = "accessibilityFrameForRange:";

	private static readonly IntPtr selAccessibilityFrameForRange_Handle = Selector.GetHandle("accessibilityFrameForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFullScreenButton = "accessibilityFullScreenButton";

	private static readonly IntPtr selAccessibilityFullScreenButtonHandle = Selector.GetHandle("accessibilityFullScreenButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityGrowArea = "accessibilityGrowArea";

	private static readonly IntPtr selAccessibilityGrowAreaHandle = Selector.GetHandle("accessibilityGrowArea");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHandles = "accessibilityHandles";

	private static readonly IntPtr selAccessibilityHandlesHandle = Selector.GetHandle("accessibilityHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHeader = "accessibilityHeader";

	private static readonly IntPtr selAccessibilityHeaderHandle = Selector.GetHandle("accessibilityHeader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHelp = "accessibilityHelp";

	private static readonly IntPtr selAccessibilityHelpHandle = Selector.GetHandle("accessibilityHelp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalScrollBar = "accessibilityHorizontalScrollBar";

	private static readonly IntPtr selAccessibilityHorizontalScrollBarHandle = Selector.GetHandle("accessibilityHorizontalScrollBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalUnitDescription = "accessibilityHorizontalUnitDescription";

	private static readonly IntPtr selAccessibilityHorizontalUnitDescriptionHandle = Selector.GetHandle("accessibilityHorizontalUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalUnits = "accessibilityHorizontalUnits";

	private static readonly IntPtr selAccessibilityHorizontalUnitsHandle = Selector.GetHandle("accessibilityHorizontalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIncrementButton = "accessibilityIncrementButton";

	private static readonly IntPtr selAccessibilityIncrementButtonHandle = Selector.GetHandle("accessibilityIncrementButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIndex = "accessibilityIndex";

	private static readonly IntPtr selAccessibilityIndexHandle = Selector.GetHandle("accessibilityIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityInsertionPointLineNumber = "accessibilityInsertionPointLineNumber";

	private static readonly IntPtr selAccessibilityInsertionPointLineNumberHandle = Selector.GetHandle("accessibilityInsertionPointLineNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabelUIElements = "accessibilityLabelUIElements";

	private static readonly IntPtr selAccessibilityLabelUIElementsHandle = Selector.GetHandle("accessibilityLabelUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabelValue = "accessibilityLabelValue";

	private static readonly IntPtr selAccessibilityLabelValueHandle = Selector.GetHandle("accessibilityLabelValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLayoutPointForScreenPoint_ = "accessibilityLayoutPointForScreenPoint:";

	private static readonly IntPtr selAccessibilityLayoutPointForScreenPoint_Handle = Selector.GetHandle("accessibilityLayoutPointForScreenPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLayoutSizeForScreenSize_ = "accessibilityLayoutSizeForScreenSize:";

	private static readonly IntPtr selAccessibilityLayoutSizeForScreenSize_Handle = Selector.GetHandle("accessibilityLayoutSizeForScreenSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLineForIndex_ = "accessibilityLineForIndex:";

	private static readonly IntPtr selAccessibilityLineForIndex_Handle = Selector.GetHandle("accessibilityLineForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLinkedUIElements = "accessibilityLinkedUIElements";

	private static readonly IntPtr selAccessibilityLinkedUIElementsHandle = Selector.GetHandle("accessibilityLinkedUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMainWindow = "accessibilityMainWindow";

	private static readonly IntPtr selAccessibilityMainWindowHandle = Selector.GetHandle("accessibilityMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerGroupUIElement = "accessibilityMarkerGroupUIElement";

	private static readonly IntPtr selAccessibilityMarkerGroupUIElementHandle = Selector.GetHandle("accessibilityMarkerGroupUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerTypeDescription = "accessibilityMarkerTypeDescription";

	private static readonly IntPtr selAccessibilityMarkerTypeDescriptionHandle = Selector.GetHandle("accessibilityMarkerTypeDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerUIElements = "accessibilityMarkerUIElements";

	private static readonly IntPtr selAccessibilityMarkerUIElementsHandle = Selector.GetHandle("accessibilityMarkerUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerValues = "accessibilityMarkerValues";

	private static readonly IntPtr selAccessibilityMarkerValuesHandle = Selector.GetHandle("accessibilityMarkerValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMaxValue = "accessibilityMaxValue";

	private static readonly IntPtr selAccessibilityMaxValueHandle = Selector.GetHandle("accessibilityMaxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMenuBar = "accessibilityMenuBar";

	private static readonly IntPtr selAccessibilityMenuBarHandle = Selector.GetHandle("accessibilityMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMinValue = "accessibilityMinValue";

	private static readonly IntPtr selAccessibilityMinValueHandle = Selector.GetHandle("accessibilityMinValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMinimizeButton = "accessibilityMinimizeButton";

	private static readonly IntPtr selAccessibilityMinimizeButtonHandle = Selector.GetHandle("accessibilityMinimizeButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityNextContents = "accessibilityNextContents";

	private static readonly IntPtr selAccessibilityNextContentsHandle = Selector.GetHandle("accessibilityNextContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityNumberOfCharacters = "accessibilityNumberOfCharacters";

	private static readonly IntPtr selAccessibilityNumberOfCharactersHandle = Selector.GetHandle("accessibilityNumberOfCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOrientation = "accessibilityOrientation";

	private static readonly IntPtr selAccessibilityOrientationHandle = Selector.GetHandle("accessibilityOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOverflowButton = "accessibilityOverflowButton";

	private static readonly IntPtr selAccessibilityOverflowButtonHandle = Selector.GetHandle("accessibilityOverflowButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformCancel = "accessibilityPerformCancel";

	private static readonly IntPtr selAccessibilityPerformCancelHandle = Selector.GetHandle("accessibilityPerformCancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformConfirm = "accessibilityPerformConfirm";

	private static readonly IntPtr selAccessibilityPerformConfirmHandle = Selector.GetHandle("accessibilityPerformConfirm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformDecrement = "accessibilityPerformDecrement";

	private static readonly IntPtr selAccessibilityPerformDecrementHandle = Selector.GetHandle("accessibilityPerformDecrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformDelete = "accessibilityPerformDelete";

	private static readonly IntPtr selAccessibilityPerformDeleteHandle = Selector.GetHandle("accessibilityPerformDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformIncrement = "accessibilityPerformIncrement";

	private static readonly IntPtr selAccessibilityPerformIncrementHandle = Selector.GetHandle("accessibilityPerformIncrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformPick = "accessibilityPerformPick";

	private static readonly IntPtr selAccessibilityPerformPickHandle = Selector.GetHandle("accessibilityPerformPick");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformPress = "accessibilityPerformPress";

	private static readonly IntPtr selAccessibilityPerformPressHandle = Selector.GetHandle("accessibilityPerformPress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformRaise = "accessibilityPerformRaise";

	private static readonly IntPtr selAccessibilityPerformRaiseHandle = Selector.GetHandle("accessibilityPerformRaise");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowAlternateUI = "accessibilityPerformShowAlternateUI";

	private static readonly IntPtr selAccessibilityPerformShowAlternateUIHandle = Selector.GetHandle("accessibilityPerformShowAlternateUI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowDefaultUI = "accessibilityPerformShowDefaultUI";

	private static readonly IntPtr selAccessibilityPerformShowDefaultUIHandle = Selector.GetHandle("accessibilityPerformShowDefaultUI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowMenu = "accessibilityPerformShowMenu";

	private static readonly IntPtr selAccessibilityPerformShowMenuHandle = Selector.GetHandle("accessibilityPerformShowMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPlaceholderValue = "accessibilityPlaceholderValue";

	private static readonly IntPtr selAccessibilityPlaceholderValueHandle = Selector.GetHandle("accessibilityPlaceholderValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPreviousContents = "accessibilityPreviousContents";

	private static readonly IntPtr selAccessibilityPreviousContentsHandle = Selector.GetHandle("accessibilityPreviousContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityProxy = "accessibilityProxy";

	private static readonly IntPtr selAccessibilityProxyHandle = Selector.GetHandle("accessibilityProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRTFForRange_ = "accessibilityRTFForRange:";

	private static readonly IntPtr selAccessibilityRTFForRange_Handle = Selector.GetHandle("accessibilityRTFForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForIndex_ = "accessibilityRangeForIndex:";

	private static readonly IntPtr selAccessibilityRangeForIndex_Handle = Selector.GetHandle("accessibilityRangeForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForLine_ = "accessibilityRangeForLine:";

	private static readonly IntPtr selAccessibilityRangeForLine_Handle = Selector.GetHandle("accessibilityRangeForLine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForPosition_ = "accessibilityRangeForPosition:";

	private static readonly IntPtr selAccessibilityRangeForPosition_Handle = Selector.GetHandle("accessibilityRangeForPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRole = "accessibilityRole";

	private static readonly IntPtr selAccessibilityRoleHandle = Selector.GetHandle("accessibilityRole");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRoleDescription = "accessibilityRoleDescription";

	private static readonly IntPtr selAccessibilityRoleDescriptionHandle = Selector.GetHandle("accessibilityRoleDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowCount = "accessibilityRowCount";

	private static readonly IntPtr selAccessibilityRowCountHandle = Selector.GetHandle("accessibilityRowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowHeaderUIElements = "accessibilityRowHeaderUIElements";

	private static readonly IntPtr selAccessibilityRowHeaderUIElementsHandle = Selector.GetHandle("accessibilityRowHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowIndexRange = "accessibilityRowIndexRange";

	private static readonly IntPtr selAccessibilityRowIndexRangeHandle = Selector.GetHandle("accessibilityRowIndexRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRows = "accessibilityRows";

	private static readonly IntPtr selAccessibilityRowsHandle = Selector.GetHandle("accessibilityRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRulerMarkerType = "accessibilityRulerMarkerType";

	private static readonly IntPtr selAccessibilityRulerMarkerTypeHandle = Selector.GetHandle("accessibilityRulerMarkerType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityScreenPointForLayoutPoint_ = "accessibilityScreenPointForLayoutPoint:";

	private static readonly IntPtr selAccessibilityScreenPointForLayoutPoint_Handle = Selector.GetHandle("accessibilityScreenPointForLayoutPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityScreenSizeForLayoutSize_ = "accessibilityScreenSizeForLayoutSize:";

	private static readonly IntPtr selAccessibilityScreenSizeForLayoutSize_Handle = Selector.GetHandle("accessibilityScreenSizeForLayoutSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySearchButton = "accessibilitySearchButton";

	private static readonly IntPtr selAccessibilitySearchButtonHandle = Selector.GetHandle("accessibilitySearchButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySearchMenu = "accessibilitySearchMenu";

	private static readonly IntPtr selAccessibilitySearchMenuHandle = Selector.GetHandle("accessibilitySearchMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedCells = "accessibilitySelectedCells";

	private static readonly IntPtr selAccessibilitySelectedCellsHandle = Selector.GetHandle("accessibilitySelectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedChildren = "accessibilitySelectedChildren";

	private static readonly IntPtr selAccessibilitySelectedChildrenHandle = Selector.GetHandle("accessibilitySelectedChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedColumns = "accessibilitySelectedColumns";

	private static readonly IntPtr selAccessibilitySelectedColumnsHandle = Selector.GetHandle("accessibilitySelectedColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedRows = "accessibilitySelectedRows";

	private static readonly IntPtr selAccessibilitySelectedRowsHandle = Selector.GetHandle("accessibilitySelectedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedText = "accessibilitySelectedText";

	private static readonly IntPtr selAccessibilitySelectedTextHandle = Selector.GetHandle("accessibilitySelectedText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedTextRange = "accessibilitySelectedTextRange";

	private static readonly IntPtr selAccessibilitySelectedTextRangeHandle = Selector.GetHandle("accessibilitySelectedTextRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedTextRanges = "accessibilitySelectedTextRanges";

	private static readonly IntPtr selAccessibilitySelectedTextRangesHandle = Selector.GetHandle("accessibilitySelectedTextRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityServesAsTitleForUIElements = "accessibilityServesAsTitleForUIElements";

	private static readonly IntPtr selAccessibilityServesAsTitleForUIElementsHandle = Selector.GetHandle("accessibilityServesAsTitleForUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedCharacterRange = "accessibilitySharedCharacterRange";

	private static readonly IntPtr selAccessibilitySharedCharacterRangeHandle = Selector.GetHandle("accessibilitySharedCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedFocusElements = "accessibilitySharedFocusElements";

	private static readonly IntPtr selAccessibilitySharedFocusElementsHandle = Selector.GetHandle("accessibilitySharedFocusElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedTextUIElements = "accessibilitySharedTextUIElements";

	private static readonly IntPtr selAccessibilitySharedTextUIElementsHandle = Selector.GetHandle("accessibilitySharedTextUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityShownMenu = "accessibilityShownMenu";

	private static readonly IntPtr selAccessibilityShownMenuHandle = Selector.GetHandle("accessibilityShownMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySortDirection = "accessibilitySortDirection";

	private static readonly IntPtr selAccessibilitySortDirectionHandle = Selector.GetHandle("accessibilitySortDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySplitters = "accessibilitySplitters";

	private static readonly IntPtr selAccessibilitySplittersHandle = Selector.GetHandle("accessibilitySplitters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStringForRange_ = "accessibilityStringForRange:";

	private static readonly IntPtr selAccessibilityStringForRange_Handle = Selector.GetHandle("accessibilityStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStyleRangeForIndex_ = "accessibilityStyleRangeForIndex:";

	private static readonly IntPtr selAccessibilityStyleRangeForIndex_Handle = Selector.GetHandle("accessibilityStyleRangeForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySubrole = "accessibilitySubrole";

	private static readonly IntPtr selAccessibilitySubroleHandle = Selector.GetHandle("accessibilitySubrole");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTabs = "accessibilityTabs";

	private static readonly IntPtr selAccessibilityTabsHandle = Selector.GetHandle("accessibilityTabs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTitle = "accessibilityTitle";

	private static readonly IntPtr selAccessibilityTitleHandle = Selector.GetHandle("accessibilityTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTitleUIElement = "accessibilityTitleUIElement";

	private static readonly IntPtr selAccessibilityTitleUIElementHandle = Selector.GetHandle("accessibilityTitleUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityToolbarButton = "accessibilityToolbarButton";

	private static readonly IntPtr selAccessibilityToolbarButtonHandle = Selector.GetHandle("accessibilityToolbarButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTopLevelUIElement = "accessibilityTopLevelUIElement";

	private static readonly IntPtr selAccessibilityTopLevelUIElementHandle = Selector.GetHandle("accessibilityTopLevelUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityURL = "accessibilityURL";

	private static readonly IntPtr selAccessibilityURLHandle = Selector.GetHandle("accessibilityURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityUnitDescription = "accessibilityUnitDescription";

	private static readonly IntPtr selAccessibilityUnitDescriptionHandle = Selector.GetHandle("accessibilityUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityUnits = "accessibilityUnits";

	private static readonly IntPtr selAccessibilityUnitsHandle = Selector.GetHandle("accessibilityUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValueDescription = "accessibilityValueDescription";

	private static readonly IntPtr selAccessibilityValueDescriptionHandle = Selector.GetHandle("accessibilityValueDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalScrollBar = "accessibilityVerticalScrollBar";

	private static readonly IntPtr selAccessibilityVerticalScrollBarHandle = Selector.GetHandle("accessibilityVerticalScrollBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalUnitDescription = "accessibilityVerticalUnitDescription";

	private static readonly IntPtr selAccessibilityVerticalUnitDescriptionHandle = Selector.GetHandle("accessibilityVerticalUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalUnits = "accessibilityVerticalUnits";

	private static readonly IntPtr selAccessibilityVerticalUnitsHandle = Selector.GetHandle("accessibilityVerticalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCells = "accessibilityVisibleCells";

	private static readonly IntPtr selAccessibilityVisibleCellsHandle = Selector.GetHandle("accessibilityVisibleCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCharacterRange = "accessibilityVisibleCharacterRange";

	private static readonly IntPtr selAccessibilityVisibleCharacterRangeHandle = Selector.GetHandle("accessibilityVisibleCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleChildren = "accessibilityVisibleChildren";

	private static readonly IntPtr selAccessibilityVisibleChildrenHandle = Selector.GetHandle("accessibilityVisibleChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleColumns = "accessibilityVisibleColumns";

	private static readonly IntPtr selAccessibilityVisibleColumnsHandle = Selector.GetHandle("accessibilityVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleRows = "accessibilityVisibleRows";

	private static readonly IntPtr selAccessibilityVisibleRowsHandle = Selector.GetHandle("accessibilityVisibleRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWarningValue = "accessibilityWarningValue";

	private static readonly IntPtr selAccessibilityWarningValueHandle = Selector.GetHandle("accessibilityWarningValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWindow = "accessibilityWindow";

	private static readonly IntPtr selAccessibilityWindowHandle = Selector.GetHandle("accessibilityWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWindows = "accessibilityWindows";

	private static readonly IntPtr selAccessibilityWindowsHandle = Selector.GetHandle("accessibilityWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityZoomButton = "accessibilityZoomButton";

	private static readonly IntPtr selAccessibilityZoomButtonHandle = Selector.GetHandle("accessibilityZoomButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChildWindow_Ordered_ = "addChildWindow:ordered:";

	private static readonly IntPtr selAddChildWindow_Ordered_Handle = Selector.GetHandle("addChildWindow:ordered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTabbedWindow_Ordered_ = "addTabbedWindow:ordered:";

	private static readonly IntPtr selAddTabbedWindow_Ordered_Handle = Selector.GetHandle("addTabbedWindow:ordered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTitlebarAccessoryViewController_ = "addTitlebarAccessoryViewController:";

	private static readonly IntPtr selAddTitlebarAccessoryViewController_Handle = Selector.GetHandle("addTitlebarAccessoryViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsAutomaticWindowTabbing = "allowsAutomaticWindowTabbing";

	private static readonly IntPtr selAllowsAutomaticWindowTabbingHandle = Selector.GetHandle("allowsAutomaticWindowTabbing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsConcurrentViewDrawing = "allowsConcurrentViewDrawing";

	private static readonly IntPtr selAllowsConcurrentViewDrawingHandle = Selector.GetHandle("allowsConcurrentViewDrawing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsToolTipsWhenApplicationIsInactive = "allowsToolTipsWhenApplicationIsInactive";

	private static readonly IntPtr selAllowsToolTipsWhenApplicationIsInactiveHandle = Selector.GetHandle("allowsToolTipsWhenApplicationIsInactive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphaValue = "alphaValue";

	private static readonly IntPtr selAlphaValueHandle = Selector.GetHandle("alphaValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationBehavior = "animationBehavior";

	private static readonly IntPtr selAnimationBehaviorHandle = Selector.GetHandle("animationBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationResizeTime_ = "animationResizeTime:";

	private static readonly IntPtr selAnimationResizeTime_Handle = Selector.GetHandle("animationResizeTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimator = "animator";

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearance = "appearance";

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearanceSource = "appearanceSource";

	private static readonly IntPtr selAppearanceSourceHandle = Selector.GetHandle("appearanceSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreCursorRectsEnabled = "areCursorRectsEnabled";

	private static readonly IntPtr selAreCursorRectsEnabledHandle = Selector.GetHandle("areCursorRectsEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAspectRatio = "aspectRatio";

	private static readonly IntPtr selAspectRatioHandle = Selector.GetHandle("aspectRatio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachedSheet = "attachedSheet";

	private static readonly IntPtr selAttachedSheetHandle = Selector.GetHandle("attachedSheet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutorecalculatesContentBorderThicknessForEdge_ = "autorecalculatesContentBorderThicknessForEdge:";

	private static readonly IntPtr selAutorecalculatesContentBorderThicknessForEdge_Handle = Selector.GetHandle("autorecalculatesContentBorderThicknessForEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutorecalculatesKeyViewLoop = "autorecalculatesKeyViewLoop";

	private static readonly IntPtr selAutorecalculatesKeyViewLoopHandle = Selector.GetHandle("autorecalculatesKeyViewLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingAlignedRect_Options_ = "backingAlignedRect:options:";

	private static readonly IntPtr selBackingAlignedRect_Options_Handle = Selector.GetHandle("backingAlignedRect:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingLocation = "backingLocation";

	private static readonly IntPtr selBackingLocationHandle = Selector.GetHandle("backingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingScaleFactor = "backingScaleFactor";

	private static readonly IntPtr selBackingScaleFactorHandle = Selector.GetHandle("backingScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingType = "backingType";

	private static readonly IntPtr selBackingTypeHandle = Selector.GetHandle("backingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomeKeyWindow = "becomeKeyWindow";

	private static readonly IntPtr selBecomeKeyWindowHandle = Selector.GetHandle("becomeKeyWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomeMainWindow = "becomeMainWindow";

	private static readonly IntPtr selBecomeMainWindowHandle = Selector.GetHandle("becomeMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginCriticalSheet_CompletionHandler_ = "beginCriticalSheet:completionHandler:";

	private static readonly IntPtr selBeginCriticalSheet_CompletionHandler_Handle = Selector.GetHandle("beginCriticalSheet:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheet_CompletionHandler_ = "beginSheet:completionHandler:";

	private static readonly IntPtr selBeginSheet_CompletionHandler_Handle = Selector.GetHandle("beginSheet:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheImageInRect_ = "cacheImageInRect:";

	private static readonly IntPtr selCacheImageInRect_Handle = Selector.GetHandle("cacheImageInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBecomeKeyWindow = "canBecomeKeyWindow";

	private static readonly IntPtr selCanBecomeKeyWindowHandle = Selector.GetHandle("canBecomeKeyWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBecomeMainWindow = "canBecomeMainWindow";

	private static readonly IntPtr selCanBecomeMainWindowHandle = Selector.GetHandle("canBecomeMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBecomeVisibleWithoutLogin = "canBecomeVisibleWithoutLogin";

	private static readonly IntPtr selCanBecomeVisibleWithoutLoginHandle = Selector.GetHandle("canBecomeVisibleWithoutLogin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanHide = "canHide";

	private static readonly IntPtr selCanHideHandle = Selector.GetHandle("canHide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRepresentDisplayGamut_ = "canRepresentDisplayGamut:";

	private static readonly IntPtr selCanRepresentDisplayGamut_Handle = Selector.GetHandle("canRepresentDisplayGamut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanStoreColor = "canStoreColor";

	private static readonly IntPtr selCanStoreColorHandle = Selector.GetHandle("canStoreColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCascadeTopLeftFromPoint_ = "cascadeTopLeftFromPoint:";

	private static readonly IntPtr selCascadeTopLeftFromPoint_Handle = Selector.GetHandle("cascadeTopLeftFromPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenter = "center";

	private static readonly IntPtr selCenterHandle = Selector.GetHandle("center");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildWindows = "childWindows";

	private static readonly IntPtr selChildWindowsHandle = Selector.GetHandle("childWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionBehavior = "collectionBehavior";

	private static readonly IntPtr selCollectionBehaviorHandle = Selector.GetHandle("collectionBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstrainFrameRect_ToScreen_ = "constrainFrameRect:toScreen:";

	private static readonly IntPtr selConstrainFrameRect_ToScreen_Handle = Selector.GetHandle("constrainFrameRect:toScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentAspectRatio = "contentAspectRatio";

	private static readonly IntPtr selContentAspectRatioHandle = Selector.GetHandle("contentAspectRatio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentBorderThicknessForEdge_ = "contentBorderThicknessForEdge:";

	private static readonly IntPtr selContentBorderThicknessForEdge_Handle = Selector.GetHandle("contentBorderThicknessForEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentLayoutGuide = "contentLayoutGuide";

	private static readonly IntPtr selContentLayoutGuideHandle = Selector.GetHandle("contentLayoutGuide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentLayoutRect = "contentLayoutRect";

	private static readonly IntPtr selContentLayoutRectHandle = Selector.GetHandle("contentLayoutRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentMaxSize = "contentMaxSize";

	private static readonly IntPtr selContentMaxSizeHandle = Selector.GetHandle("contentMaxSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentMinSize = "contentMinSize";

	private static readonly IntPtr selContentMinSizeHandle = Selector.GetHandle("contentMinSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentRectForFrameRect_ = "contentRectForFrameRect:";

	private static readonly IntPtr selContentRectForFrameRect_Handle = Selector.GetHandle("contentRectForFrameRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentRectForFrameRect_StyleMask_ = "contentRectForFrameRect:styleMask:";

	private static readonly IntPtr selContentRectForFrameRect_StyleMask_Handle = Selector.GetHandle("contentRectForFrameRect:styleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentResizeIncrements = "contentResizeIncrements";

	private static readonly IntPtr selContentResizeIncrementsHandle = Selector.GetHandle("contentResizeIncrements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentView = "contentView";

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentViewController = "contentViewController";

	private static readonly IntPtr selContentViewControllerHandle = Selector.GetHandle("contentViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertBaseToScreen_ = "convertBaseToScreen:";

	private static readonly IntPtr selConvertBaseToScreen_Handle = Selector.GetHandle("convertBaseToScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromBacking_ = "convertPointFromBacking:";

	private static readonly IntPtr selConvertPointFromBacking_Handle = Selector.GetHandle("convertPointFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromScreen_ = "convertPointFromScreen:";

	private static readonly IntPtr selConvertPointFromScreen_Handle = Selector.GetHandle("convertPointFromScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToBacking_ = "convertPointToBacking:";

	private static readonly IntPtr selConvertPointToBacking_Handle = Selector.GetHandle("convertPointToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToScreen_ = "convertPointToScreen:";

	private static readonly IntPtr selConvertPointToScreen_Handle = Selector.GetHandle("convertPointToScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromBacking_ = "convertRectFromBacking:";

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromScreen_ = "convertRectFromScreen:";

	private static readonly IntPtr selConvertRectFromScreen_Handle = Selector.GetHandle("convertRectFromScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToBacking_ = "convertRectToBacking:";

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToScreen_ = "convertRectToScreen:";

	private static readonly IntPtr selConvertRectToScreen_Handle = Selector.GetHandle("convertRectToScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertScreenToBase_ = "convertScreenToBase:";

	private static readonly IntPtr selConvertScreenToBase_Handle = Selector.GetHandle("convertScreenToBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentEvent = "currentEvent";

	private static readonly IntPtr selCurrentEventHandle = Selector.GetHandle("currentEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithEPSInsideRect_ = "dataWithEPSInsideRect:";

	private static readonly IntPtr selDataWithEPSInsideRect_Handle = Selector.GetHandle("dataWithEPSInsideRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithPDFInsideRect_ = "dataWithPDFInsideRect:";

	private static readonly IntPtr selDataWithPDFInsideRect_Handle = Selector.GetHandle("dataWithPDFInsideRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeepestScreen = "deepestScreen";

	private static readonly IntPtr selDeepestScreenHandle = Selector.GetHandle("deepestScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultButtonCell = "defaultButtonCell";

	private static readonly IntPtr selDefaultButtonCellHandle = Selector.GetHandle("defaultButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDepthLimit = "defaultDepthLimit";

	private static readonly IntPtr selDefaultDepthLimitHandle = Selector.GetHandle("defaultDepthLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeminiaturize_ = "deminiaturize:";

	private static readonly IntPtr selDeminiaturize_Handle = Selector.GetHandle("deminiaturize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthLimit = "depthLimit";

	private static readonly IntPtr selDepthLimitHandle = Selector.GetHandle("depthLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceDescription = "deviceDescription";

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableCursorRects = "disableCursorRects";

	private static readonly IntPtr selDisableCursorRectsHandle = Selector.GetHandle("disableCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableFlushWindow = "disableFlushWindow";

	private static readonly IntPtr selDisableFlushWindowHandle = Selector.GetHandle("disableFlushWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableKeyEquivalentForDefaultButtonCell = "disableKeyEquivalentForDefaultButtonCell";

	private static readonly IntPtr selDisableKeyEquivalentForDefaultButtonCellHandle = Selector.GetHandle("disableKeyEquivalentForDefaultButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableScreenUpdatesUntilFlush = "disableScreenUpdatesUntilFlush";

	private static readonly IntPtr selDisableScreenUpdatesUntilFlushHandle = Selector.GetHandle("disableScreenUpdatesUntilFlush");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableSnapshotRestoration = "disableSnapshotRestoration";

	private static readonly IntPtr selDisableSnapshotRestorationHandle = Selector.GetHandle("disableSnapshotRestoration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardCachedImage = "discardCachedImage";

	private static readonly IntPtr selDiscardCachedImageHandle = Selector.GetHandle("discardCachedImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardCursorRects = "discardCursorRects";

	private static readonly IntPtr selDiscardCursorRectsHandle = Selector.GetHandle("discardCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardEventsMatchingMask_BeforeEvent_ = "discardEventsMatchingMask:beforeEvent:";

	private static readonly IntPtr selDiscardEventsMatchingMask_BeforeEvent_Handle = Selector.GetHandle("discardEventsMatchingMask:beforeEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplay = "display";

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeeded = "displayIfNeeded";

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysWhenScreenProfileChanges = "displaysWhenScreenProfileChanges";

	private static readonly IntPtr selDisplaysWhenScreenProfileChangesHandle = Selector.GetHandle("displaysWhenScreenProfileChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDockTile = "dockTile";

	private static readonly IntPtr selDockTileHandle = Selector.GetHandle("dockTile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveAppearance = "effectiveAppearance";

	private static readonly IntPtr selEffectiveAppearanceHandle = Selector.GetHandle("effectiveAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableCursorRects = "enableCursorRects";

	private static readonly IntPtr selEnableCursorRectsHandle = Selector.GetHandle("enableCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableFlushWindow = "enableFlushWindow";

	private static readonly IntPtr selEnableFlushWindowHandle = Selector.GetHandle("enableFlushWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableKeyEquivalentForDefaultButtonCell = "enableKeyEquivalentForDefaultButtonCell";

	private static readonly IntPtr selEnableKeyEquivalentForDefaultButtonCellHandle = Selector.GetHandle("enableKeyEquivalentForDefaultButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableSnapshotRestoration = "enableSnapshotRestoration";

	private static readonly IntPtr selEnableSnapshotRestorationHandle = Selector.GetHandle("enableSnapshotRestoration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndEditingFor_ = "endEditingFor:";

	private static readonly IntPtr selEndEditingFor_Handle = Selector.GetHandle("endEditingFor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndSheet_ = "endSheet:";

	private static readonly IntPtr selEndSheet_Handle = Selector.GetHandle("endSheet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndSheet_ReturnCode_ = "endSheet:returnCode:";

	private static readonly IntPtr selEndSheet_ReturnCode_Handle = Selector.GetHandle("endSheet:returnCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldEditor_ForObject_ = "fieldEditor:forObject:";

	private static readonly IntPtr selFieldEditor_ForObject_Handle = Selector.GetHandle("fieldEditor:forObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstResponder = "firstResponder";

	private static readonly IntPtr selFirstResponderHandle = Selector.GetHandle("firstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushWindow = "flushWindow";

	private static readonly IntPtr selFlushWindowHandle = Selector.GetHandle("flushWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushWindowIfNeeded = "flushWindowIfNeeded";

	private static readonly IntPtr selFlushWindowIfNeededHandle = Selector.GetHandle("flushWindowIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameAutosaveName = "frameAutosaveName";

	private static readonly IntPtr selFrameAutosaveNameHandle = Selector.GetHandle("frameAutosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameRectForContentRect_ = "frameRectForContentRect:";

	private static readonly IntPtr selFrameRectForContentRect_Handle = Selector.GetHandle("frameRectForContentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameRectForContentRect_StyleMask_ = "frameRectForContentRect:styleMask:";

	private static readonly IntPtr selFrameRectForContentRect_StyleMask_Handle = Selector.GetHandle("frameRectForContentRect:styleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGState = "gState";

	private static readonly IntPtr selGStateHandle = Selector.GetHandle("gState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContext = "graphicsContext";

	private static readonly IntPtr selGraphicsContextHandle = Selector.GetHandle("graphicsContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDynamicDepthLimit = "hasDynamicDepthLimit";

	private static readonly IntPtr selHasDynamicDepthLimitHandle = Selector.GetHandle("hasDynamicDepthLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasShadow = "hasShadow";

	private static readonly IntPtr selHasShadowHandle = Selector.GetHandle("hasShadow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHidesOnDeactivate = "hidesOnDeactivate";

	private static readonly IntPtr selHidesOnDeactivateHandle = Selector.GetHandle("hidesOnDeactivate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoresMouseEvents = "ignoresMouseEvents";

	private static readonly IntPtr selIgnoresMouseEventsHandle = Selector.GetHandle("ignoresMouseEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInLiveResize = "inLiveResize";

	private static readonly IntPtr selInLiveResizeHandle = Selector.GetHandle("inLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentRect_StyleMask_Backing_Defer_ = "initWithContentRect:styleMask:backing:defer:";

	private static readonly IntPtr selInitWithContentRect_StyleMask_Backing_Defer_Handle = Selector.GetHandle("initWithContentRect:styleMask:backing:defer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentRect_StyleMask_Backing_Defer_Screen_ = "initWithContentRect:styleMask:backing:defer:screen:";

	private static readonly IntPtr selInitWithContentRect_StyleMask_Backing_Defer_Screen_Handle = Selector.GetHandle("initWithContentRect:styleMask:backing:defer:screen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialFirstResponder = "initialFirstResponder";

	private static readonly IntPtr selInitialFirstResponderHandle = Selector.GetHandle("initialFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTitlebarAccessoryViewController_AtIndex_ = "insertTitlebarAccessoryViewController:atIndex:";

	private static readonly IntPtr selInsertTitlebarAccessoryViewController_AtIndex_Handle = Selector.GetHandle("insertTitlebarAccessoryViewController:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateCursorRectsForView_ = "invalidateCursorRectsForView:";

	private static readonly IntPtr selInvalidateCursorRectsForView_Handle = Selector.GetHandle("invalidateCursorRectsForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateShadow = "invalidateShadow";

	private static readonly IntPtr selInvalidateShadowHandle = Selector.GetHandle("invalidateShadow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityAlternateUIVisible = "isAccessibilityAlternateUIVisible";

	private static readonly IntPtr selIsAccessibilityAlternateUIVisibleHandle = Selector.GetHandle("isAccessibilityAlternateUIVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityDisclosed = "isAccessibilityDisclosed";

	private static readonly IntPtr selIsAccessibilityDisclosedHandle = Selector.GetHandle("isAccessibilityDisclosed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityEdited = "isAccessibilityEdited";

	private static readonly IntPtr selIsAccessibilityEditedHandle = Selector.GetHandle("isAccessibilityEdited");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityElement = "isAccessibilityElement";

	private static readonly IntPtr selIsAccessibilityElementHandle = Selector.GetHandle("isAccessibilityElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityEnabled = "isAccessibilityEnabled";

	private static readonly IntPtr selIsAccessibilityEnabledHandle = Selector.GetHandle("isAccessibilityEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityExpanded = "isAccessibilityExpanded";

	private static readonly IntPtr selIsAccessibilityExpandedHandle = Selector.GetHandle("isAccessibilityExpanded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFrontmost = "isAccessibilityFrontmost";

	private static readonly IntPtr selIsAccessibilityFrontmostHandle = Selector.GetHandle("isAccessibilityFrontmost");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityHidden = "isAccessibilityHidden";

	private static readonly IntPtr selIsAccessibilityHiddenHandle = Selector.GetHandle("isAccessibilityHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityMain = "isAccessibilityMain";

	private static readonly IntPtr selIsAccessibilityMainHandle = Selector.GetHandle("isAccessibilityMain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityMinimized = "isAccessibilityMinimized";

	private static readonly IntPtr selIsAccessibilityMinimizedHandle = Selector.GetHandle("isAccessibilityMinimized");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityModal = "isAccessibilityModal";

	private static readonly IntPtr selIsAccessibilityModalHandle = Selector.GetHandle("isAccessibilityModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityOrderedByRow = "isAccessibilityOrderedByRow";

	private static readonly IntPtr selIsAccessibilityOrderedByRowHandle = Selector.GetHandle("isAccessibilityOrderedByRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityProtectedContent = "isAccessibilityProtectedContent";

	private static readonly IntPtr selIsAccessibilityProtectedContentHandle = Selector.GetHandle("isAccessibilityProtectedContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityRequired = "isAccessibilityRequired";

	private static readonly IntPtr selIsAccessibilityRequiredHandle = Selector.GetHandle("isAccessibilityRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilitySelected = "isAccessibilitySelected";

	private static readonly IntPtr selIsAccessibilitySelectedHandle = Selector.GetHandle("isAccessibilitySelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilitySelectorAllowed_ = "isAccessibilitySelectorAllowed:";

	private static readonly IntPtr selIsAccessibilitySelectorAllowed_Handle = Selector.GetHandle("isAccessibilitySelectorAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutodisplay = "isAutodisplay";

	private static readonly IntPtr selIsAutodisplayHandle = Selector.GetHandle("isAutodisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDocumentEdited = "isDocumentEdited";

	private static readonly IntPtr selIsDocumentEditedHandle = Selector.GetHandle("isDocumentEdited");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExcludedFromWindowsMenu = "isExcludedFromWindowsMenu";

	private static readonly IntPtr selIsExcludedFromWindowsMenuHandle = Selector.GetHandle("isExcludedFromWindowsMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlushWindowDisabled = "isFlushWindowDisabled";

	private static readonly IntPtr selIsFlushWindowDisabledHandle = Selector.GetHandle("isFlushWindowDisabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsKeyWindow = "isKeyWindow";

	private static readonly IntPtr selIsKeyWindowHandle = Selector.GetHandle("isKeyWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMainWindow = "isMainWindow";

	private static readonly IntPtr selIsMainWindowHandle = Selector.GetHandle("isMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMiniaturized = "isMiniaturized";

	private static readonly IntPtr selIsMiniaturizedHandle = Selector.GetHandle("isMiniaturized");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMovable = "isMovable";

	private static readonly IntPtr selIsMovableHandle = Selector.GetHandle("isMovable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMovableByWindowBackground = "isMovableByWindowBackground";

	private static readonly IntPtr selIsMovableByWindowBackgroundHandle = Selector.GetHandle("isMovableByWindowBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOnActiveSpace = "isOnActiveSpace";

	private static readonly IntPtr selIsOnActiveSpaceHandle = Selector.GetHandle("isOnActiveSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOneShot = "isOneShot";

	private static readonly IntPtr selIsOneShotHandle = Selector.GetHandle("isOneShot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReleasedWhenClosed = "isReleasedWhenClosed";

	private static readonly IntPtr selIsReleasedWhenClosedHandle = Selector.GetHandle("isReleasedWhenClosed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRestorable = "isRestorable";

	private static readonly IntPtr selIsRestorableHandle = Selector.GetHandle("isRestorable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSheet = "isSheet";

	private static readonly IntPtr selIsSheetHandle = Selector.GetHandle("isSheet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVisible = "isVisible";

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsZoomed = "isZoomed";

	private static readonly IntPtr selIsZoomedHandle = Selector.GetHandle("isZoomed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyDown_ = "keyDown:";

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyViewSelectionDirection = "keyViewSelectionDirection";

	private static readonly IntPtr selKeyViewSelectionDirectionHandle = Selector.GetHandle("keyViewSelectionDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutIfNeeded = "layoutIfNeeded";

	private static readonly IntPtr selLayoutIfNeededHandle = Selector.GetHandle("layoutIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevel = "level";

	private static readonly IntPtr selLevelHandle = Selector.GetHandle("level");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeFirstResponder_ = "makeFirstResponder:";

	private static readonly IntPtr selMakeFirstResponder_Handle = Selector.GetHandle("makeFirstResponder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeKeyAndOrderFront_ = "makeKeyAndOrderFront:";

	private static readonly IntPtr selMakeKeyAndOrderFront_Handle = Selector.GetHandle("makeKeyAndOrderFront:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeKeyWindow = "makeKeyWindow";

	private static readonly IntPtr selMakeKeyWindowHandle = Selector.GetHandle("makeKeyWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeMainWindow = "makeMainWindow";

	private static readonly IntPtr selMakeMainWindowHandle = Selector.GetHandle("makeMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxFullScreenContentSize = "maxFullScreenContentSize";

	private static readonly IntPtr selMaxFullScreenContentSizeHandle = Selector.GetHandle("maxFullScreenContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxSize = "maxSize";

	private static readonly IntPtr selMaxSizeHandle = Selector.GetHandle("maxSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuChanged_ = "menuChanged:";

	private static readonly IntPtr selMenuChanged_Handle = Selector.GetHandle("menuChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeAllWindows_ = "mergeAllWindows:";

	private static readonly IntPtr selMergeAllWindows_Handle = Selector.GetHandle("mergeAllWindows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFrameWidthWithTitle_StyleMask_ = "minFrameWidthWithTitle:styleMask:";

	private static readonly IntPtr selMinFrameWidthWithTitle_StyleMask_Handle = Selector.GetHandle("minFrameWidthWithTitle:styleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFullScreenContentSize = "minFullScreenContentSize";

	private static readonly IntPtr selMinFullScreenContentSizeHandle = Selector.GetHandle("minFullScreenContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinSize = "minSize";

	private static readonly IntPtr selMinSizeHandle = Selector.GetHandle("minSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiniaturize_ = "miniaturize:";

	private static readonly IntPtr selMiniaturize_Handle = Selector.GetHandle("miniaturize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiniwindowImage = "miniwindowImage";

	private static readonly IntPtr selMiniwindowImageHandle = Selector.GetHandle("miniwindowImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiniwindowTitle = "miniwindowTitle";

	private static readonly IntPtr selMiniwindowTitleHandle = Selector.GetHandle("miniwindowTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseLocationOutsideOfEventStream = "mouseLocationOutsideOfEventStream";

	private static readonly IntPtr selMouseLocationOutsideOfEventStreamHandle = Selector.GetHandle("mouseLocationOutsideOfEventStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveTabToNewWindow_ = "moveTabToNewWindow:";

	private static readonly IntPtr selMoveTabToNewWindow_Handle = Selector.GetHandle("moveTabToNewWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextEventMatchingMask_ = "nextEventMatchingMask:";

	private static readonly IntPtr selNextEventMatchingMask_Handle = Selector.GetHandle("nextEventMatchingMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextEventMatchingMask_UntilDate_InMode_Dequeue_ = "nextEventMatchingMask:untilDate:inMode:dequeue:";

	private static readonly IntPtr selNextEventMatchingMask_UntilDate_InMode_Dequeue_Handle = Selector.GetHandle("nextEventMatchingMask:untilDate:inMode:dequeue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOcclusionState = "occlusionState";

	private static readonly IntPtr selOcclusionStateHandle = Selector.GetHandle("occlusionState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderBack_ = "orderBack:";

	private static readonly IntPtr selOrderBack_Handle = Selector.GetHandle("orderBack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFront_ = "orderFront:";

	private static readonly IntPtr selOrderFront_Handle = Selector.GetHandle("orderFront:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontRegardless = "orderFrontRegardless";

	private static readonly IntPtr selOrderFrontRegardlessHandle = Selector.GetHandle("orderFrontRegardless");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderOut_ = "orderOut:";

	private static readonly IntPtr selOrderOut_Handle = Selector.GetHandle("orderOut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderWindow_RelativeTo_ = "orderWindow:relativeTo:";

	private static readonly IntPtr selOrderWindow_RelativeTo_Handle = Selector.GetHandle("orderWindow:relativeTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentWindow = "parentWindow";

	private static readonly IntPtr selParentWindowHandle = Selector.GetHandle("parentWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformClose_ = "performClose:";

	private static readonly IntPtr selPerformClose_Handle = Selector.GetHandle("performClose:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformMiniaturize_ = "performMiniaturize:";

	private static readonly IntPtr selPerformMiniaturize_Handle = Selector.GetHandle("performMiniaturize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformWindowDragWithEvent_ = "performWindowDragWithEvent:";

	private static readonly IntPtr selPerformWindowDragWithEvent_Handle = Selector.GetHandle("performWindowDragWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformZoom_ = "performZoom:";

	private static readonly IntPtr selPerformZoom_Handle = Selector.GetHandle("performZoom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostEvent_AtStart_ = "postEvent:atStart:";

	private static readonly IntPtr selPostEvent_AtStart_Handle = Selector.GetHandle("postEvent:atStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredBackingLocation = "preferredBackingLocation";

	private static readonly IntPtr selPreferredBackingLocationHandle = Selector.GetHandle("preferredBackingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesContentDuringLiveResize = "preservesContentDuringLiveResize";

	private static readonly IntPtr selPreservesContentDuringLiveResizeHandle = Selector.GetHandle("preservesContentDuringLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventsApplicationTerminationWhenModal = "preventsApplicationTerminationWhenModal";

	private static readonly IntPtr selPreventsApplicationTerminationWhenModalHandle = Selector.GetHandle("preventsApplicationTerminationWhenModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrint_ = "print:";

	private static readonly IntPtr selPrint_Handle = Selector.GetHandle("print:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecalculateKeyViewLoop = "recalculateKeyViewLoop";

	private static readonly IntPtr selRecalculateKeyViewLoopHandle = Selector.GetHandle("recalculateKeyViewLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterForDraggedTypes_ = "registerForDraggedTypes:";

	private static readonly IntPtr selRegisterForDraggedTypes_Handle = Selector.GetHandle("registerForDraggedTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChildWindow_ = "removeChildWindow:";

	private static readonly IntPtr selRemoveChildWindow_Handle = Selector.GetHandle("removeChildWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFrameUsingName_ = "removeFrameUsingName:";

	private static readonly IntPtr selRemoveFrameUsingName_Handle = Selector.GetHandle("removeFrameUsingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTitlebarAccessoryViewControllerAtIndex_ = "removeTitlebarAccessoryViewControllerAtIndex:";

	private static readonly IntPtr selRemoveTitlebarAccessoryViewControllerAtIndex_Handle = Selector.GetHandle("removeTitlebarAccessoryViewControllerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedFilename = "representedFilename";

	private static readonly IntPtr selRepresentedFilenameHandle = Selector.GetHandle("representedFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedURL = "representedURL";

	private static readonly IntPtr selRepresentedURLHandle = Selector.GetHandle("representedURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetCursorRects = "resetCursorRects";

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResignKeyWindow = "resignKeyWindow";

	private static readonly IntPtr selResignKeyWindowHandle = Selector.GetHandle("resignKeyWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResignMainWindow = "resignMainWindow";

	private static readonly IntPtr selResignMainWindowHandle = Selector.GetHandle("resignMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeFlags = "resizeFlags";

	private static readonly IntPtr selResizeFlagsHandle = Selector.GetHandle("resizeFlags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeIncrements = "resizeIncrements";

	private static readonly IntPtr selResizeIncrementsHandle = Selector.GetHandle("resizeIncrements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestorationClass = "restorationClass";

	private static readonly IntPtr selRestorationClassHandle = Selector.GetHandle("restorationClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreCachedImage = "restoreCachedImage";

	private static readonly IntPtr selRestoreCachedImageHandle = Selector.GetHandle("restoreCachedImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunToolbarCustomizationPalette_ = "runToolbarCustomizationPalette:";

	private static readonly IntPtr selRunToolbarCustomizationPalette_Handle = Selector.GetHandle("runToolbarCustomizationPalette:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveFrameUsingName_ = "saveFrameUsingName:";

	private static readonly IntPtr selSaveFrameUsingName_Handle = Selector.GetHandle("saveFrameUsingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreen = "screen";

	private static readonly IntPtr selScreenHandle = Selector.GetHandle("screen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectKeyViewFollowingView_ = "selectKeyViewFollowingView:";

	private static readonly IntPtr selSelectKeyViewFollowingView_Handle = Selector.GetHandle("selectKeyViewFollowingView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectKeyViewPrecedingView_ = "selectKeyViewPrecedingView:";

	private static readonly IntPtr selSelectKeyViewPrecedingView_Handle = Selector.GetHandle("selectKeyViewPrecedingView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNextKeyView_ = "selectNextKeyView:";

	private static readonly IntPtr selSelectNextKeyView_Handle = Selector.GetHandle("selectNextKeyView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNextTab_ = "selectNextTab:";

	private static readonly IntPtr selSelectNextTab_Handle = Selector.GetHandle("selectNextTab:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectPreviousKeyView_ = "selectPreviousKeyView:";

	private static readonly IntPtr selSelectPreviousKeyView_Handle = Selector.GetHandle("selectPreviousKeyView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectPreviousTab_ = "selectPreviousTab:";

	private static readonly IntPtr selSelectPreviousTab_Handle = Selector.GetHandle("selectPreviousTab:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendEvent_ = "sendEvent:";

	private static readonly IntPtr selSendEvent_Handle = Selector.GetHandle("sendEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptsMouseMovedEvents_ = "setAcceptsMouseMovedEvents:";

	private static readonly IntPtr selSetAcceptsMouseMovedEvents_Handle = Selector.GetHandle("setAcceptsMouseMovedEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityActivationPoint_ = "setAccessibilityActivationPoint:";

	private static readonly IntPtr selSetAccessibilityActivationPoint_Handle = Selector.GetHandle("setAccessibilityActivationPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityAllowedValues_ = "setAccessibilityAllowedValues:";

	private static readonly IntPtr selSetAccessibilityAllowedValues_Handle = Selector.GetHandle("setAccessibilityAllowedValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityAlternateUIVisible_ = "setAccessibilityAlternateUIVisible:";

	private static readonly IntPtr selSetAccessibilityAlternateUIVisible_Handle = Selector.GetHandle("setAccessibilityAlternateUIVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityApplicationFocusedUIElement_ = "setAccessibilityApplicationFocusedUIElement:";

	private static readonly IntPtr selSetAccessibilityApplicationFocusedUIElement_Handle = Selector.GetHandle("setAccessibilityApplicationFocusedUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCancelButton_ = "setAccessibilityCancelButton:";

	private static readonly IntPtr selSetAccessibilityCancelButton_Handle = Selector.GetHandle("setAccessibilityCancelButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityChildren_ = "setAccessibilityChildren:";

	private static readonly IntPtr selSetAccessibilityChildren_Handle = Selector.GetHandle("setAccessibilityChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityChildrenInNavigationOrder_ = "setAccessibilityChildrenInNavigationOrder:";

	private static readonly IntPtr selSetAccessibilityChildrenInNavigationOrder_Handle = Selector.GetHandle("setAccessibilityChildrenInNavigationOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityClearButton_ = "setAccessibilityClearButton:";

	private static readonly IntPtr selSetAccessibilityClearButton_Handle = Selector.GetHandle("setAccessibilityClearButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCloseButton_ = "setAccessibilityCloseButton:";

	private static readonly IntPtr selSetAccessibilityCloseButton_Handle = Selector.GetHandle("setAccessibilityCloseButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnCount_ = "setAccessibilityColumnCount:";

	private static readonly IntPtr selSetAccessibilityColumnCount_Handle = Selector.GetHandle("setAccessibilityColumnCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnHeaderUIElements_ = "setAccessibilityColumnHeaderUIElements:";

	private static readonly IntPtr selSetAccessibilityColumnHeaderUIElements_Handle = Selector.GetHandle("setAccessibilityColumnHeaderUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnIndexRange_ = "setAccessibilityColumnIndexRange:";

	private static readonly IntPtr selSetAccessibilityColumnIndexRange_Handle = Selector.GetHandle("setAccessibilityColumnIndexRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnTitles_ = "setAccessibilityColumnTitles:";

	private static readonly IntPtr selSetAccessibilityColumnTitles_Handle = Selector.GetHandle("setAccessibilityColumnTitles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumns_ = "setAccessibilityColumns:";

	private static readonly IntPtr selSetAccessibilityColumns_Handle = Selector.GetHandle("setAccessibilityColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityContents_ = "setAccessibilityContents:";

	private static readonly IntPtr selSetAccessibilityContents_Handle = Selector.GetHandle("setAccessibilityContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCriticalValue_ = "setAccessibilityCriticalValue:";

	private static readonly IntPtr selSetAccessibilityCriticalValue_Handle = Selector.GetHandle("setAccessibilityCriticalValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCustomActions_ = "setAccessibilityCustomActions:";

	private static readonly IntPtr selSetAccessibilityCustomActions_Handle = Selector.GetHandle("setAccessibilityCustomActions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCustomRotors_ = "setAccessibilityCustomRotors:";

	private static readonly IntPtr selSetAccessibilityCustomRotors_Handle = Selector.GetHandle("setAccessibilityCustomRotors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDecrementButton_ = "setAccessibilityDecrementButton:";

	private static readonly IntPtr selSetAccessibilityDecrementButton_Handle = Selector.GetHandle("setAccessibilityDecrementButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDefaultButton_ = "setAccessibilityDefaultButton:";

	private static readonly IntPtr selSetAccessibilityDefaultButton_Handle = Selector.GetHandle("setAccessibilityDefaultButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosed_ = "setAccessibilityDisclosed:";

	private static readonly IntPtr selSetAccessibilityDisclosed_Handle = Selector.GetHandle("setAccessibilityDisclosed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosedByRow_ = "setAccessibilityDisclosedByRow:";

	private static readonly IntPtr selSetAccessibilityDisclosedByRow_Handle = Selector.GetHandle("setAccessibilityDisclosedByRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosedRows_ = "setAccessibilityDisclosedRows:";

	private static readonly IntPtr selSetAccessibilityDisclosedRows_Handle = Selector.GetHandle("setAccessibilityDisclosedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosureLevel_ = "setAccessibilityDisclosureLevel:";

	private static readonly IntPtr selSetAccessibilityDisclosureLevel_Handle = Selector.GetHandle("setAccessibilityDisclosureLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDocument_ = "setAccessibilityDocument:";

	private static readonly IntPtr selSetAccessibilityDocument_Handle = Selector.GetHandle("setAccessibilityDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityEdited_ = "setAccessibilityEdited:";

	private static readonly IntPtr selSetAccessibilityEdited_Handle = Selector.GetHandle("setAccessibilityEdited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityElement_ = "setAccessibilityElement:";

	private static readonly IntPtr selSetAccessibilityElement_Handle = Selector.GetHandle("setAccessibilityElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityEnabled_ = "setAccessibilityEnabled:";

	private static readonly IntPtr selSetAccessibilityEnabled_Handle = Selector.GetHandle("setAccessibilityEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityExpanded_ = "setAccessibilityExpanded:";

	private static readonly IntPtr selSetAccessibilityExpanded_Handle = Selector.GetHandle("setAccessibilityExpanded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityExtrasMenuBar_ = "setAccessibilityExtrasMenuBar:";

	private static readonly IntPtr selSetAccessibilityExtrasMenuBar_Handle = Selector.GetHandle("setAccessibilityExtrasMenuBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFilename_ = "setAccessibilityFilename:";

	private static readonly IntPtr selSetAccessibilityFilename_Handle = Selector.GetHandle("setAccessibilityFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFocused_ = "setAccessibilityFocused:";

	private static readonly IntPtr selSetAccessibilityFocused_Handle = Selector.GetHandle("setAccessibilityFocused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFocusedWindow_ = "setAccessibilityFocusedWindow:";

	private static readonly IntPtr selSetAccessibilityFocusedWindow_Handle = Selector.GetHandle("setAccessibilityFocusedWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFrame_ = "setAccessibilityFrame:";

	private static readonly IntPtr selSetAccessibilityFrame_Handle = Selector.GetHandle("setAccessibilityFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFrontmost_ = "setAccessibilityFrontmost:";

	private static readonly IntPtr selSetAccessibilityFrontmost_Handle = Selector.GetHandle("setAccessibilityFrontmost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFullScreenButton_ = "setAccessibilityFullScreenButton:";

	private static readonly IntPtr selSetAccessibilityFullScreenButton_Handle = Selector.GetHandle("setAccessibilityFullScreenButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityGrowArea_ = "setAccessibilityGrowArea:";

	private static readonly IntPtr selSetAccessibilityGrowArea_Handle = Selector.GetHandle("setAccessibilityGrowArea:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHandles_ = "setAccessibilityHandles:";

	private static readonly IntPtr selSetAccessibilityHandles_Handle = Selector.GetHandle("setAccessibilityHandles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHeader_ = "setAccessibilityHeader:";

	private static readonly IntPtr selSetAccessibilityHeader_Handle = Selector.GetHandle("setAccessibilityHeader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHelp_ = "setAccessibilityHelp:";

	private static readonly IntPtr selSetAccessibilityHelp_Handle = Selector.GetHandle("setAccessibilityHelp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHidden_ = "setAccessibilityHidden:";

	private static readonly IntPtr selSetAccessibilityHidden_Handle = Selector.GetHandle("setAccessibilityHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalScrollBar_ = "setAccessibilityHorizontalScrollBar:";

	private static readonly IntPtr selSetAccessibilityHorizontalScrollBar_Handle = Selector.GetHandle("setAccessibilityHorizontalScrollBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalUnitDescription_ = "setAccessibilityHorizontalUnitDescription:";

	private static readonly IntPtr selSetAccessibilityHorizontalUnitDescription_Handle = Selector.GetHandle("setAccessibilityHorizontalUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalUnits_ = "setAccessibilityHorizontalUnits:";

	private static readonly IntPtr selSetAccessibilityHorizontalUnits_Handle = Selector.GetHandle("setAccessibilityHorizontalUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIdentifier_ = "setAccessibilityIdentifier:";

	private static readonly IntPtr selSetAccessibilityIdentifier_Handle = Selector.GetHandle("setAccessibilityIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIncrementButton_ = "setAccessibilityIncrementButton:";

	private static readonly IntPtr selSetAccessibilityIncrementButton_Handle = Selector.GetHandle("setAccessibilityIncrementButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIndex_ = "setAccessibilityIndex:";

	private static readonly IntPtr selSetAccessibilityIndex_Handle = Selector.GetHandle("setAccessibilityIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityInsertionPointLineNumber_ = "setAccessibilityInsertionPointLineNumber:";

	private static readonly IntPtr selSetAccessibilityInsertionPointLineNumber_Handle = Selector.GetHandle("setAccessibilityInsertionPointLineNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabel_ = "setAccessibilityLabel:";

	private static readonly IntPtr selSetAccessibilityLabel_Handle = Selector.GetHandle("setAccessibilityLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabelUIElements_ = "setAccessibilityLabelUIElements:";

	private static readonly IntPtr selSetAccessibilityLabelUIElements_Handle = Selector.GetHandle("setAccessibilityLabelUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabelValue_ = "setAccessibilityLabelValue:";

	private static readonly IntPtr selSetAccessibilityLabelValue_Handle = Selector.GetHandle("setAccessibilityLabelValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLinkedUIElements_ = "setAccessibilityLinkedUIElements:";

	private static readonly IntPtr selSetAccessibilityLinkedUIElements_Handle = Selector.GetHandle("setAccessibilityLinkedUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMain_ = "setAccessibilityMain:";

	private static readonly IntPtr selSetAccessibilityMain_Handle = Selector.GetHandle("setAccessibilityMain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMainWindow_ = "setAccessibilityMainWindow:";

	private static readonly IntPtr selSetAccessibilityMainWindow_Handle = Selector.GetHandle("setAccessibilityMainWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerGroupUIElement_ = "setAccessibilityMarkerGroupUIElement:";

	private static readonly IntPtr selSetAccessibilityMarkerGroupUIElement_Handle = Selector.GetHandle("setAccessibilityMarkerGroupUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerTypeDescription_ = "setAccessibilityMarkerTypeDescription:";

	private static readonly IntPtr selSetAccessibilityMarkerTypeDescription_Handle = Selector.GetHandle("setAccessibilityMarkerTypeDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerUIElements_ = "setAccessibilityMarkerUIElements:";

	private static readonly IntPtr selSetAccessibilityMarkerUIElements_Handle = Selector.GetHandle("setAccessibilityMarkerUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerValues_ = "setAccessibilityMarkerValues:";

	private static readonly IntPtr selSetAccessibilityMarkerValues_Handle = Selector.GetHandle("setAccessibilityMarkerValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMaxValue_ = "setAccessibilityMaxValue:";

	private static readonly IntPtr selSetAccessibilityMaxValue_Handle = Selector.GetHandle("setAccessibilityMaxValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMenuBar_ = "setAccessibilityMenuBar:";

	private static readonly IntPtr selSetAccessibilityMenuBar_Handle = Selector.GetHandle("setAccessibilityMenuBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinValue_ = "setAccessibilityMinValue:";

	private static readonly IntPtr selSetAccessibilityMinValue_Handle = Selector.GetHandle("setAccessibilityMinValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinimizeButton_ = "setAccessibilityMinimizeButton:";

	private static readonly IntPtr selSetAccessibilityMinimizeButton_Handle = Selector.GetHandle("setAccessibilityMinimizeButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinimized_ = "setAccessibilityMinimized:";

	private static readonly IntPtr selSetAccessibilityMinimized_Handle = Selector.GetHandle("setAccessibilityMinimized:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityModal_ = "setAccessibilityModal:";

	private static readonly IntPtr selSetAccessibilityModal_Handle = Selector.GetHandle("setAccessibilityModal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityNextContents_ = "setAccessibilityNextContents:";

	private static readonly IntPtr selSetAccessibilityNextContents_Handle = Selector.GetHandle("setAccessibilityNextContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityNumberOfCharacters_ = "setAccessibilityNumberOfCharacters:";

	private static readonly IntPtr selSetAccessibilityNumberOfCharacters_Handle = Selector.GetHandle("setAccessibilityNumberOfCharacters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOrderedByRow_ = "setAccessibilityOrderedByRow:";

	private static readonly IntPtr selSetAccessibilityOrderedByRow_Handle = Selector.GetHandle("setAccessibilityOrderedByRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOrientation_ = "setAccessibilityOrientation:";

	private static readonly IntPtr selSetAccessibilityOrientation_Handle = Selector.GetHandle("setAccessibilityOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOverflowButton_ = "setAccessibilityOverflowButton:";

	private static readonly IntPtr selSetAccessibilityOverflowButton_Handle = Selector.GetHandle("setAccessibilityOverflowButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityParent_ = "setAccessibilityParent:";

	private static readonly IntPtr selSetAccessibilityParent_Handle = Selector.GetHandle("setAccessibilityParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityPlaceholderValue_ = "setAccessibilityPlaceholderValue:";

	private static readonly IntPtr selSetAccessibilityPlaceholderValue_Handle = Selector.GetHandle("setAccessibilityPlaceholderValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityPreviousContents_ = "setAccessibilityPreviousContents:";

	private static readonly IntPtr selSetAccessibilityPreviousContents_Handle = Selector.GetHandle("setAccessibilityPreviousContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityProtectedContent_ = "setAccessibilityProtectedContent:";

	private static readonly IntPtr selSetAccessibilityProtectedContent_Handle = Selector.GetHandle("setAccessibilityProtectedContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityProxy_ = "setAccessibilityProxy:";

	private static readonly IntPtr selSetAccessibilityProxy_Handle = Selector.GetHandle("setAccessibilityProxy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRequired_ = "setAccessibilityRequired:";

	private static readonly IntPtr selSetAccessibilityRequired_Handle = Selector.GetHandle("setAccessibilityRequired:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRole_ = "setAccessibilityRole:";

	private static readonly IntPtr selSetAccessibilityRole_Handle = Selector.GetHandle("setAccessibilityRole:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRoleDescription_ = "setAccessibilityRoleDescription:";

	private static readonly IntPtr selSetAccessibilityRoleDescription_Handle = Selector.GetHandle("setAccessibilityRoleDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowCount_ = "setAccessibilityRowCount:";

	private static readonly IntPtr selSetAccessibilityRowCount_Handle = Selector.GetHandle("setAccessibilityRowCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowHeaderUIElements_ = "setAccessibilityRowHeaderUIElements:";

	private static readonly IntPtr selSetAccessibilityRowHeaderUIElements_Handle = Selector.GetHandle("setAccessibilityRowHeaderUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowIndexRange_ = "setAccessibilityRowIndexRange:";

	private static readonly IntPtr selSetAccessibilityRowIndexRange_Handle = Selector.GetHandle("setAccessibilityRowIndexRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRows_ = "setAccessibilityRows:";

	private static readonly IntPtr selSetAccessibilityRows_Handle = Selector.GetHandle("setAccessibilityRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRulerMarkerType_ = "setAccessibilityRulerMarkerType:";

	private static readonly IntPtr selSetAccessibilityRulerMarkerType_Handle = Selector.GetHandle("setAccessibilityRulerMarkerType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySearchButton_ = "setAccessibilitySearchButton:";

	private static readonly IntPtr selSetAccessibilitySearchButton_Handle = Selector.GetHandle("setAccessibilitySearchButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySearchMenu_ = "setAccessibilitySearchMenu:";

	private static readonly IntPtr selSetAccessibilitySearchMenu_Handle = Selector.GetHandle("setAccessibilitySearchMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelected_ = "setAccessibilitySelected:";

	private static readonly IntPtr selSetAccessibilitySelected_Handle = Selector.GetHandle("setAccessibilitySelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedCells_ = "setAccessibilitySelectedCells:";

	private static readonly IntPtr selSetAccessibilitySelectedCells_Handle = Selector.GetHandle("setAccessibilitySelectedCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedChildren_ = "setAccessibilitySelectedChildren:";

	private static readonly IntPtr selSetAccessibilitySelectedChildren_Handle = Selector.GetHandle("setAccessibilitySelectedChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedColumns_ = "setAccessibilitySelectedColumns:";

	private static readonly IntPtr selSetAccessibilitySelectedColumns_Handle = Selector.GetHandle("setAccessibilitySelectedColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedRows_ = "setAccessibilitySelectedRows:";

	private static readonly IntPtr selSetAccessibilitySelectedRows_Handle = Selector.GetHandle("setAccessibilitySelectedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedText_ = "setAccessibilitySelectedText:";

	private static readonly IntPtr selSetAccessibilitySelectedText_Handle = Selector.GetHandle("setAccessibilitySelectedText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedTextRange_ = "setAccessibilitySelectedTextRange:";

	private static readonly IntPtr selSetAccessibilitySelectedTextRange_Handle = Selector.GetHandle("setAccessibilitySelectedTextRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedTextRanges_ = "setAccessibilitySelectedTextRanges:";

	private static readonly IntPtr selSetAccessibilitySelectedTextRanges_Handle = Selector.GetHandle("setAccessibilitySelectedTextRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityServesAsTitleForUIElements_ = "setAccessibilityServesAsTitleForUIElements:";

	private static readonly IntPtr selSetAccessibilityServesAsTitleForUIElements_Handle = Selector.GetHandle("setAccessibilityServesAsTitleForUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedCharacterRange_ = "setAccessibilitySharedCharacterRange:";

	private static readonly IntPtr selSetAccessibilitySharedCharacterRange_Handle = Selector.GetHandle("setAccessibilitySharedCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedFocusElements_ = "setAccessibilitySharedFocusElements:";

	private static readonly IntPtr selSetAccessibilitySharedFocusElements_Handle = Selector.GetHandle("setAccessibilitySharedFocusElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedTextUIElements_ = "setAccessibilitySharedTextUIElements:";

	private static readonly IntPtr selSetAccessibilitySharedTextUIElements_Handle = Selector.GetHandle("setAccessibilitySharedTextUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityShownMenu_ = "setAccessibilityShownMenu:";

	private static readonly IntPtr selSetAccessibilityShownMenu_Handle = Selector.GetHandle("setAccessibilityShownMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySortDirection_ = "setAccessibilitySortDirection:";

	private static readonly IntPtr selSetAccessibilitySortDirection_Handle = Selector.GetHandle("setAccessibilitySortDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySplitters_ = "setAccessibilitySplitters:";

	private static readonly IntPtr selSetAccessibilitySplitters_Handle = Selector.GetHandle("setAccessibilitySplitters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySubrole_ = "setAccessibilitySubrole:";

	private static readonly IntPtr selSetAccessibilitySubrole_Handle = Selector.GetHandle("setAccessibilitySubrole:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTabs_ = "setAccessibilityTabs:";

	private static readonly IntPtr selSetAccessibilityTabs_Handle = Selector.GetHandle("setAccessibilityTabs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTitle_ = "setAccessibilityTitle:";

	private static readonly IntPtr selSetAccessibilityTitle_Handle = Selector.GetHandle("setAccessibilityTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTitleUIElement_ = "setAccessibilityTitleUIElement:";

	private static readonly IntPtr selSetAccessibilityTitleUIElement_Handle = Selector.GetHandle("setAccessibilityTitleUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityToolbarButton_ = "setAccessibilityToolbarButton:";

	private static readonly IntPtr selSetAccessibilityToolbarButton_Handle = Selector.GetHandle("setAccessibilityToolbarButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTopLevelUIElement_ = "setAccessibilityTopLevelUIElement:";

	private static readonly IntPtr selSetAccessibilityTopLevelUIElement_Handle = Selector.GetHandle("setAccessibilityTopLevelUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityURL_ = "setAccessibilityURL:";

	private static readonly IntPtr selSetAccessibilityURL_Handle = Selector.GetHandle("setAccessibilityURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityUnitDescription_ = "setAccessibilityUnitDescription:";

	private static readonly IntPtr selSetAccessibilityUnitDescription_Handle = Selector.GetHandle("setAccessibilityUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityUnits_ = "setAccessibilityUnits:";

	private static readonly IntPtr selSetAccessibilityUnits_Handle = Selector.GetHandle("setAccessibilityUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityValue_ = "setAccessibilityValue:";

	private static readonly IntPtr selSetAccessibilityValue_Handle = Selector.GetHandle("setAccessibilityValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityValueDescription_ = "setAccessibilityValueDescription:";

	private static readonly IntPtr selSetAccessibilityValueDescription_Handle = Selector.GetHandle("setAccessibilityValueDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalScrollBar_ = "setAccessibilityVerticalScrollBar:";

	private static readonly IntPtr selSetAccessibilityVerticalScrollBar_Handle = Selector.GetHandle("setAccessibilityVerticalScrollBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalUnitDescription_ = "setAccessibilityVerticalUnitDescription:";

	private static readonly IntPtr selSetAccessibilityVerticalUnitDescription_Handle = Selector.GetHandle("setAccessibilityVerticalUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalUnits_ = "setAccessibilityVerticalUnits:";

	private static readonly IntPtr selSetAccessibilityVerticalUnits_Handle = Selector.GetHandle("setAccessibilityVerticalUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleCells_ = "setAccessibilityVisibleCells:";

	private static readonly IntPtr selSetAccessibilityVisibleCells_Handle = Selector.GetHandle("setAccessibilityVisibleCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleCharacterRange_ = "setAccessibilityVisibleCharacterRange:";

	private static readonly IntPtr selSetAccessibilityVisibleCharacterRange_Handle = Selector.GetHandle("setAccessibilityVisibleCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleChildren_ = "setAccessibilityVisibleChildren:";

	private static readonly IntPtr selSetAccessibilityVisibleChildren_Handle = Selector.GetHandle("setAccessibilityVisibleChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleColumns_ = "setAccessibilityVisibleColumns:";

	private static readonly IntPtr selSetAccessibilityVisibleColumns_Handle = Selector.GetHandle("setAccessibilityVisibleColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleRows_ = "setAccessibilityVisibleRows:";

	private static readonly IntPtr selSetAccessibilityVisibleRows_Handle = Selector.GetHandle("setAccessibilityVisibleRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWarningValue_ = "setAccessibilityWarningValue:";

	private static readonly IntPtr selSetAccessibilityWarningValue_Handle = Selector.GetHandle("setAccessibilityWarningValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWindow_ = "setAccessibilityWindow:";

	private static readonly IntPtr selSetAccessibilityWindow_Handle = Selector.GetHandle("setAccessibilityWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWindows_ = "setAccessibilityWindows:";

	private static readonly IntPtr selSetAccessibilityWindows_Handle = Selector.GetHandle("setAccessibilityWindows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityZoomButton_ = "setAccessibilityZoomButton:";

	private static readonly IntPtr selSetAccessibilityZoomButton_Handle = Selector.GetHandle("setAccessibilityZoomButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsAutomaticWindowTabbing_ = "setAllowsAutomaticWindowTabbing:";

	private static readonly IntPtr selSetAllowsAutomaticWindowTabbing_Handle = Selector.GetHandle("setAllowsAutomaticWindowTabbing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsConcurrentViewDrawing_ = "setAllowsConcurrentViewDrawing:";

	private static readonly IntPtr selSetAllowsConcurrentViewDrawing_Handle = Selector.GetHandle("setAllowsConcurrentViewDrawing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsToolTipsWhenApplicationIsInactive_ = "setAllowsToolTipsWhenApplicationIsInactive:";

	private static readonly IntPtr selSetAllowsToolTipsWhenApplicationIsInactive_Handle = Selector.GetHandle("setAllowsToolTipsWhenApplicationIsInactive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlphaValue_ = "setAlphaValue:";

	private static readonly IntPtr selSetAlphaValue_Handle = Selector.GetHandle("setAlphaValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorAttribute_ForOrientation_ = "setAnchorAttribute:forOrientation:";

	private static readonly IntPtr selSetAnchorAttribute_ForOrientation_Handle = Selector.GetHandle("setAnchorAttribute:forOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationBehavior_ = "setAnimationBehavior:";

	private static readonly IntPtr selSetAnimationBehavior_Handle = Selector.GetHandle("setAnimationBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppearance_ = "setAppearance:";

	private static readonly IntPtr selSetAppearance_Handle = Selector.GetHandle("setAppearance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppearanceSource_ = "setAppearanceSource:";

	private static readonly IntPtr selSetAppearanceSource_Handle = Selector.GetHandle("setAppearanceSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAspectRatio_ = "setAspectRatio:";

	private static readonly IntPtr selSetAspectRatio_Handle = Selector.GetHandle("setAspectRatio:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutodisplay_ = "setAutodisplay:";

	private static readonly IntPtr selSetAutodisplay_Handle = Selector.GetHandle("setAutodisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutorecalculatesContentBorderThickness_ForEdge_ = "setAutorecalculatesContentBorderThickness:forEdge:";

	private static readonly IntPtr selSetAutorecalculatesContentBorderThickness_ForEdge_Handle = Selector.GetHandle("setAutorecalculatesContentBorderThickness:forEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutorecalculatesKeyViewLoop_ = "setAutorecalculatesKeyViewLoop:";

	private static readonly IntPtr selSetAutorecalculatesKeyViewLoop_Handle = Selector.GetHandle("setAutorecalculatesKeyViewLoop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackingType_ = "setBackingType:";

	private static readonly IntPtr selSetBackingType_Handle = Selector.GetHandle("setBackingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanBecomeVisibleWithoutLogin_ = "setCanBecomeVisibleWithoutLogin:";

	private static readonly IntPtr selSetCanBecomeVisibleWithoutLogin_Handle = Selector.GetHandle("setCanBecomeVisibleWithoutLogin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanHide_ = "setCanHide:";

	private static readonly IntPtr selSetCanHide_Handle = Selector.GetHandle("setCanHide:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollectionBehavior_ = "setCollectionBehavior:";

	private static readonly IntPtr selSetCollectionBehavior_Handle = Selector.GetHandle("setCollectionBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorSpace_ = "setColorSpace:";

	private static readonly IntPtr selSetColorSpace_Handle = Selector.GetHandle("setColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentAspectRatio_ = "setContentAspectRatio:";

	private static readonly IntPtr selSetContentAspectRatio_Handle = Selector.GetHandle("setContentAspectRatio:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentBorderThickness_ForEdge_ = "setContentBorderThickness:forEdge:";

	private static readonly IntPtr selSetContentBorderThickness_ForEdge_Handle = Selector.GetHandle("setContentBorderThickness:forEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentMaxSize_ = "setContentMaxSize:";

	private static readonly IntPtr selSetContentMaxSize_Handle = Selector.GetHandle("setContentMaxSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentMinSize_ = "setContentMinSize:";

	private static readonly IntPtr selSetContentMinSize_Handle = Selector.GetHandle("setContentMinSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentResizeIncrements_ = "setContentResizeIncrements:";

	private static readonly IntPtr selSetContentResizeIncrements_Handle = Selector.GetHandle("setContentResizeIncrements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentSize_ = "setContentSize:";

	private static readonly IntPtr selSetContentSize_Handle = Selector.GetHandle("setContentSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentView_ = "setContentView:";

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentViewController_ = "setContentViewController:";

	private static readonly IntPtr selSetContentViewController_Handle = Selector.GetHandle("setContentViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultButtonCell_ = "setDefaultButtonCell:";

	private static readonly IntPtr selSetDefaultButtonCell_Handle = Selector.GetHandle("setDefaultButtonCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthLimit_ = "setDepthLimit:";

	private static readonly IntPtr selSetDepthLimit_Handle = Selector.GetHandle("setDepthLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysWhenScreenProfileChanges_ = "setDisplaysWhenScreenProfileChanges:";

	private static readonly IntPtr selSetDisplaysWhenScreenProfileChanges_Handle = Selector.GetHandle("setDisplaysWhenScreenProfileChanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentEdited_ = "setDocumentEdited:";

	private static readonly IntPtr selSetDocumentEdited_Handle = Selector.GetHandle("setDocumentEdited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDynamicDepthLimit_ = "setDynamicDepthLimit:";

	private static readonly IntPtr selSetDynamicDepthLimit_Handle = Selector.GetHandle("setDynamicDepthLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExcludedFromWindowsMenu_ = "setExcludedFromWindowsMenu:";

	private static readonly IntPtr selSetExcludedFromWindowsMenu_Handle = Selector.GetHandle("setExcludedFromWindowsMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrame_Display_ = "setFrame:display:";

	private static readonly IntPtr selSetFrame_Display_Handle = Selector.GetHandle("setFrame:display:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrame_Display_Animate_ = "setFrame:display:animate:";

	private static readonly IntPtr selSetFrame_Display_Animate_Handle = Selector.GetHandle("setFrame:display:animate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameAutosaveName_ = "setFrameAutosaveName:";

	private static readonly IntPtr selSetFrameAutosaveName_Handle = Selector.GetHandle("setFrameAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameFromString_ = "setFrameFromString:";

	private static readonly IntPtr selSetFrameFromString_Handle = Selector.GetHandle("setFrameFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameOrigin_ = "setFrameOrigin:";

	private static readonly IntPtr selSetFrameOrigin_Handle = Selector.GetHandle("setFrameOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameTopLeftPoint_ = "setFrameTopLeftPoint:";

	private static readonly IntPtr selSetFrameTopLeftPoint_Handle = Selector.GetHandle("setFrameTopLeftPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameUsingName_ = "setFrameUsingName:";

	private static readonly IntPtr selSetFrameUsingName_Handle = Selector.GetHandle("setFrameUsingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameUsingName_Force_ = "setFrameUsingName:force:";

	private static readonly IntPtr selSetFrameUsingName_Force_Handle = Selector.GetHandle("setFrameUsingName:force:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasShadow_ = "setHasShadow:";

	private static readonly IntPtr selSetHasShadow_Handle = Selector.GetHandle("setHasShadow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidesOnDeactivate_ = "setHidesOnDeactivate:";

	private static readonly IntPtr selSetHidesOnDeactivate_Handle = Selector.GetHandle("setHidesOnDeactivate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoresMouseEvents_ = "setIgnoresMouseEvents:";

	private static readonly IntPtr selSetIgnoresMouseEvents_Handle = Selector.GetHandle("setIgnoresMouseEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInitialFirstResponder_ = "setInitialFirstResponder:";

	private static readonly IntPtr selSetInitialFirstResponder_Handle = Selector.GetHandle("setInitialFirstResponder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIsMiniaturized_ = "setIsMiniaturized:";

	private static readonly IntPtr selSetIsMiniaturized_Handle = Selector.GetHandle("setIsMiniaturized:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIsVisible_ = "setIsVisible:";

	private static readonly IntPtr selSetIsVisible_Handle = Selector.GetHandle("setIsVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIsZoomed_ = "setIsZoomed:";

	private static readonly IntPtr selSetIsZoomed_Handle = Selector.GetHandle("setIsZoomed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLevel_ = "setLevel:";

	private static readonly IntPtr selSetLevel_Handle = Selector.GetHandle("setLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxFullScreenContentSize_ = "setMaxFullScreenContentSize:";

	private static readonly IntPtr selSetMaxFullScreenContentSize_Handle = Selector.GetHandle("setMaxFullScreenContentSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxSize_ = "setMaxSize:";

	private static readonly IntPtr selSetMaxSize_Handle = Selector.GetHandle("setMaxSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFullScreenContentSize_ = "setMinFullScreenContentSize:";

	private static readonly IntPtr selSetMinFullScreenContentSize_Handle = Selector.GetHandle("setMinFullScreenContentSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinSize_ = "setMinSize:";

	private static readonly IntPtr selSetMinSize_Handle = Selector.GetHandle("setMinSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiniwindowImage_ = "setMiniwindowImage:";

	private static readonly IntPtr selSetMiniwindowImage_Handle = Selector.GetHandle("setMiniwindowImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiniwindowTitle_ = "setMiniwindowTitle:";

	private static readonly IntPtr selSetMiniwindowTitle_Handle = Selector.GetHandle("setMiniwindowTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovable_ = "setMovable:";

	private static readonly IntPtr selSetMovable_Handle = Selector.GetHandle("setMovable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovableByWindowBackground_ = "setMovableByWindowBackground:";

	private static readonly IntPtr selSetMovableByWindowBackground_Handle = Selector.GetHandle("setMovableByWindowBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOneShot_ = "setOneShot:";

	private static readonly IntPtr selSetOneShot_Handle = Selector.GetHandle("setOneShot:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpaque_ = "setOpaque:";

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParentWindow_ = "setParentWindow:";

	private static readonly IntPtr selSetParentWindow_Handle = Selector.GetHandle("setParentWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredBackingLocation_ = "setPreferredBackingLocation:";

	private static readonly IntPtr selSetPreferredBackingLocation_Handle = Selector.GetHandle("setPreferredBackingLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesContentDuringLiveResize_ = "setPreservesContentDuringLiveResize:";

	private static readonly IntPtr selSetPreservesContentDuringLiveResize_Handle = Selector.GetHandle("setPreservesContentDuringLiveResize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreventsApplicationTerminationWhenModal_ = "setPreventsApplicationTerminationWhenModal:";

	private static readonly IntPtr selSetPreventsApplicationTerminationWhenModal_Handle = Selector.GetHandle("setPreventsApplicationTerminationWhenModal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReleasedWhenClosed_ = "setReleasedWhenClosed:";

	private static readonly IntPtr selSetReleasedWhenClosed_Handle = Selector.GetHandle("setReleasedWhenClosed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepresentedFilename_ = "setRepresentedFilename:";

	private static readonly IntPtr selSetRepresentedFilename_Handle = Selector.GetHandle("setRepresentedFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepresentedURL_ = "setRepresentedURL:";

	private static readonly IntPtr selSetRepresentedURL_Handle = Selector.GetHandle("setRepresentedURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResizeIncrements_ = "setResizeIncrements:";

	private static readonly IntPtr selSetResizeIncrements_Handle = Selector.GetHandle("setResizeIncrements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRestorable_ = "setRestorable:";

	private static readonly IntPtr selSetRestorable_Handle = Selector.GetHandle("setRestorable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRestorationClass_ = "setRestorationClass:";

	private static readonly IntPtr selSetRestorationClass_Handle = Selector.GetHandle("setRestorationClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSharingType_ = "setSharingType:";

	private static readonly IntPtr selSetSharingType_Handle = Selector.GetHandle("setSharingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsResizeIndicator_ = "setShowsResizeIndicator:";

	private static readonly IntPtr selSetShowsResizeIndicator_Handle = Selector.GetHandle("setShowsResizeIndicator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsToolbarButton_ = "setShowsToolbarButton:";

	private static readonly IntPtr selSetShowsToolbarButton_Handle = Selector.GetHandle("setShowsToolbarButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyleMask_ = "setStyleMask:";

	private static readonly IntPtr selSetStyleMask_Handle = Selector.GetHandle("setStyleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabbingIdentifier_ = "setTabbingIdentifier:";

	private static readonly IntPtr selSetTabbingIdentifier_Handle = Selector.GetHandle("setTabbingIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabbingMode_ = "setTabbingMode:";

	private static readonly IntPtr selSetTabbingMode_Handle = Selector.GetHandle("setTabbingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleVisibility_ = "setTitleVisibility:";

	private static readonly IntPtr selSetTitleVisibility_Handle = Selector.GetHandle("setTitleVisibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleWithRepresentedFilename_ = "setTitleWithRepresentedFilename:";

	private static readonly IntPtr selSetTitleWithRepresentedFilename_Handle = Selector.GetHandle("setTitleWithRepresentedFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitlebarAppearsTransparent_ = "setTitlebarAppearsTransparent:";

	private static readonly IntPtr selSetTitlebarAppearsTransparent_Handle = Selector.GetHandle("setTitlebarAppearsTransparent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolbar_ = "setToolbar:";

	private static readonly IntPtr selSetToolbar_Handle = Selector.GetHandle("setToolbar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViewsNeedDisplay_ = "setViewsNeedDisplay:";

	private static readonly IntPtr selSetViewsNeedDisplay_Handle = Selector.GetHandle("setViewsNeedDisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindowController_ = "setWindowController:";

	private static readonly IntPtr selSetWindowController_Handle = Selector.GetHandle("setWindowController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharingType = "sharingType";

	private static readonly IntPtr selSharingTypeHandle = Selector.GetHandle("sharingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSheetParent = "sheetParent";

	private static readonly IntPtr selSheetParentHandle = Selector.GetHandle("sheetParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSheets = "sheets";

	private static readonly IntPtr selSheetsHandle = Selector.GetHandle("sheets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsResizeIndicator = "showsResizeIndicator";

	private static readonly IntPtr selShowsResizeIndicatorHandle = Selector.GetHandle("showsResizeIndicator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsToolbarButton = "showsToolbarButton";

	private static readonly IntPtr selShowsToolbarButtonHandle = Selector.GetHandle("showsToolbarButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardWindowButton_ = "standardWindowButton:";

	private static readonly IntPtr selStandardWindowButton_Handle = Selector.GetHandle("standardWindowButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardWindowButton_ForStyleMask_ = "standardWindowButton:forStyleMask:";

	private static readonly IntPtr selStandardWindowButton_ForStyleMask_Handle = Selector.GetHandle("standardWindowButton:forStyleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringWithSavedFrame = "stringWithSavedFrame";

	private static readonly IntPtr selStringWithSavedFrameHandle = Selector.GetHandle("stringWithSavedFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyleMask = "styleMask";

	private static readonly IntPtr selStyleMaskHandle = Selector.GetHandle("styleMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTab = "tab";

	private static readonly IntPtr selTabHandle = Selector.GetHandle("tab");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabGroup = "tabGroup";

	private static readonly IntPtr selTabGroupHandle = Selector.GetHandle("tabGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabbedWindows = "tabbedWindows";

	private static readonly IntPtr selTabbedWindowsHandle = Selector.GetHandle("tabbedWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabbingIdentifier = "tabbingIdentifier";

	private static readonly IntPtr selTabbingIdentifierHandle = Selector.GetHandle("tabbingIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabbingMode = "tabbingMode";

	private static readonly IntPtr selTabbingModeHandle = Selector.GetHandle("tabbingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleVisibility = "titleVisibility";

	private static readonly IntPtr selTitleVisibilityHandle = Selector.GetHandle("titleVisibility");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitlebarAccessoryViewControllers = "titlebarAccessoryViewControllers";

	private static readonly IntPtr selTitlebarAccessoryViewControllersHandle = Selector.GetHandle("titlebarAccessoryViewControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitlebarAppearsTransparent = "titlebarAppearsTransparent";

	private static readonly IntPtr selTitlebarAppearsTransparentHandle = Selector.GetHandle("titlebarAppearsTransparent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleFullScreen_ = "toggleFullScreen:";

	private static readonly IntPtr selToggleFullScreen_Handle = Selector.GetHandle("toggleFullScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleTabBar_ = "toggleTabBar:";

	private static readonly IntPtr selToggleTabBar_Handle = Selector.GetHandle("toggleTabBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleTabOverview_ = "toggleTabOverview:";

	private static readonly IntPtr selToggleTabOverview_Handle = Selector.GetHandle("toggleTabOverview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleToolbarShown_ = "toggleToolbarShown:";

	private static readonly IntPtr selToggleToolbarShown_Handle = Selector.GetHandle("toggleToolbarShown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbar = "toolbar";

	private static readonly IntPtr selToolbarHandle = Selector.GetHandle("toolbar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackEventsMatchingMask_Timeout_Mode_Handler_ = "trackEventsMatchingMask:timeout:mode:handler:";

	private static readonly IntPtr selTrackEventsMatchingMask_Timeout_Mode_Handler_Handle = Selector.GetHandle("trackEventsMatchingMask:timeout:mode:handler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryToPerform_With_ = "tryToPerform:with:";

	private static readonly IntPtr selTryToPerform_With_Handle = Selector.GetHandle("tryToPerform:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterDraggedTypes = "unregisterDraggedTypes";

	private static readonly IntPtr selUnregisterDraggedTypesHandle = Selector.GetHandle("unregisterDraggedTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate = "update";

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateConstraintsIfNeeded = "updateConstraintsIfNeeded";

	private static readonly IntPtr selUpdateConstraintsIfNeededHandle = Selector.GetHandle("updateConstraintsIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseOptimizedDrawing_ = "useOptimizedDrawing:";

	private static readonly IntPtr selUseOptimizedDrawing_Handle = Selector.GetHandle("useOptimizedDrawing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserSpaceScaleFactor = "userSpaceScaleFactor";

	private static readonly IntPtr selUserSpaceScaleFactorHandle = Selector.GetHandle("userSpaceScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserTabbingPreference = "userTabbingPreference";

	private static readonly IntPtr selUserTabbingPreferenceHandle = Selector.GetHandle("userTabbingPreference");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidRequestorForSendType_ReturnType_ = "validRequestorForSendType:returnType:";

	private static readonly IntPtr selValidRequestorForSendType_ReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewsNeedDisplay = "viewsNeedDisplay";

	private static readonly IntPtr selViewsNeedDisplayHandle = Selector.GetHandle("viewsNeedDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisualizeConstraints_ = "visualizeConstraints:";

	private static readonly IntPtr selVisualizeConstraints_Handle = Selector.GetHandle("visualizeConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowController = "windowController";

	private static readonly IntPtr selWindowControllerHandle = Selector.GetHandle("windowController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNumber = "windowNumber";

	private static readonly IntPtr selWindowNumberHandle = Selector.GetHandle("windowNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNumberAtPoint_BelowWindowWithWindowNumber_ = "windowNumberAtPoint:belowWindowWithWindowNumber:";

	private static readonly IntPtr selWindowNumberAtPoint_BelowWindowWithWindowNumber_Handle = Selector.GetHandle("windowNumberAtPoint:belowWindowWithWindowNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNumbersWithOptions_ = "windowNumbersWithOptions:";

	private static readonly IntPtr selWindowNumbersWithOptions_Handle = Selector.GetHandle("windowNumbersWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowRef = "windowRef";

	private static readonly IntPtr selWindowRefHandle = Selector.GetHandle("windowRef");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowTitlebarLayoutDirection = "windowTitlebarLayoutDirection";

	private static readonly IntPtr selWindowTitlebarLayoutDirectionHandle = Selector.GetHandle("windowTitlebarLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowWithContentViewController_ = "windowWithContentViewController:";

	private static readonly IntPtr selWindowWithContentViewController_Handle = Selector.GetHandle("windowWithContentViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorksWhenModal = "worksWhenModal";

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoom_ = "zoom:";

	private static readonly IntPtr selZoom_Handle = Selector.GetHandle("zoom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityDisclosedByRow_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityExtrasMenuBar_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityMenuBar_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityParent_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityTitleUIElement_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityTopLevelUIElement_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityWindow_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AppearanceSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TabGroup_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnouncementRequestedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationActivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationDeactivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationHiddenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationShownNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBecomeKeyNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBecomeMainNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeBackingPropertiesNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeScreenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeScreenProfileNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidDeminiaturizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndLiveResizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndSheetNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEnterFullScreenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEnterVersionBrowserNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidExitFullScreenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidExitVersionBrowserNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidExposeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidMiniaturizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidMoveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidResignKeyNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidResignMainNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidResizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUpdateNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DrawerCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HelpTagCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCollapsedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCountChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowExpandedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedCellsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedColumnsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedRowsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SheetCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementDestroyedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementFocusedChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnitsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillBeginSheetNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillCloseNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillEnterFullScreenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillEnterVersionBrowserNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillExitFullScreenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillExitVersionBrowserNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillMiniaturizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillMoveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillStartLiveResizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowDeminiaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMiniaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowResizedNotification;

	public string FrameAutosaveName
	{
		get
		{
			return GetFrameAutosaveName();
		}
		set
		{
			SetFrameAutosaveName(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsMouseMovedEvents
	{
		[Export("acceptsMouseMovedEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsMouseMovedEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsMouseMovedEventsHandle);
		}
		[Export("setAcceptsMouseMovedEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsMouseMovedEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsMouseMovedEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGPoint AccessibilityActivationPoint
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAccessibilityActivationPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAccessibilityActivationPointHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAccessibilityActivationPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAccessibilityActivationPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSNumber[]? AccessibilityAllowedValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityAllowedValues", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityAllowedValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityAllowedValuesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityAllowedValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityAllowedValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityAlternateUIVisible
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityAlternateUIVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityAlternateUIVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityAlternateUIVisibleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAlternateUIVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityAlternateUIVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityAlternateUIVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityApplicationFocusedUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityApplicationFocusedUIElementHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityApplicationFocusedUIElementHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityApplicationFocusedUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityApplicationFocusedUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCancelButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCancelButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCancelButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCancelButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCancelButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCancelButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityElement[]? AccessibilityChildrenInNavigationOrder
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityChildrenInNavigationOrder", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityChildrenInNavigationOrderHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityChildrenInNavigationOrderHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityChildrenInNavigationOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityChildrenInNavigationOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityClearButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityClearButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityClearButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityClearButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityClearButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityClearButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCloseButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCloseButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCloseButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCloseButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCloseButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCloseButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityColumnCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityColumnCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnCountHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityColumnCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityColumnCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumnHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnHeaderUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumnHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumnHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityColumnIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityColumnIndexRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnIndexRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityColumnIndexRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityColumnIndexRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumnTitles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnTitles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnTitlesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnTitlesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumnTitles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumnTitles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCriticalValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCriticalValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCriticalValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCriticalValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCriticalValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCriticalValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityCustomAction[]? AccessibilityCustomActions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityCustomActions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityCustomAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCustomActionsHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityCustomAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCustomActionsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCustomActions:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCustomActions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCustomActions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityCustomRotor[] AccessibilityCustomRotors
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityCustomRotors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityCustomRotor>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCustomRotorsHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityCustomRotor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCustomRotorsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCustomRotors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCustomRotors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCustomRotors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDecrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDecrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDecrementButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDecrementButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDecrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDecrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDefaultButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDefaultButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDefaultButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDefaultButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDefaultButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDefaultButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisclosed
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityDisclosed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityDisclosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityDisclosedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityDisclosed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityDisclosed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDisclosedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosedByRowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDisclosedByRowHandle)));
			MarkDirty();
			__mt_AccessibilityDisclosedByRow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDisclosedByRow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDisclosedByRow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityDisclosedByRow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDisclosedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDisclosedRowsHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosedRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDisclosedRows_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDisclosedRows_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityDisclosureLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosureLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityDisclosureLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosureLevelHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosureLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityDisclosureLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityDisclosureLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityDocument
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDocumentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDocumentHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDocument_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDocument_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityEdited
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityEditedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEdited:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityEdited_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityEdited_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityElement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityElementHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityElementHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityElement:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityElement_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityElement_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityEnabledHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityExpanded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityExpanded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityExpandedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityExpandedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExpanded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityExpanded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityExpanded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityExtrasMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityExtrasMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityExtrasMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityExtrasMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityExtrasMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityExtrasMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityExtrasMenuBar_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityFilename
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFilenameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFilename:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityFocused
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocused:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityFocused_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityFocused_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityFocusedWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFocusedWindowHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFocusedWindowHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFocusedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFocusedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGRect AccessibilityFrame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFrame", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrame:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetAccessibilityFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetAccessibilityFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityFrontmost
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFrontmost")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFrontmostHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFrontmostHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrontmost:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityFrontmost_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityFrontmost_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityFullScreenButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFullScreenButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFullScreenButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFullScreenButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFullScreenButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityGrowArea
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityGrowArea", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityGrowAreaHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityGrowAreaHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityGrowArea_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityGrowArea_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityHandles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHandles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHandlesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHandlesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHandles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHandles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHandles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityHeader
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHeader", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHeaderHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHeaderHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHeader:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHeader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHeader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityHelp
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHelp")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHelpHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHelpHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHelp:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHelp_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHelp_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityHidden
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityHiddenHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityHorizontalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHorizontalScrollBarHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalScrollBarHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHorizontalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHorizontalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityHorizontalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHorizontalUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHorizontalUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHorizontalUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityHorizontalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityHorizontalUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityHorizontalUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityHorizontalUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityIncrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIncrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIncrementButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIncrementButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityIncrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityIncrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityIndex
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityIndexHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityInsertionPointLineNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityInsertionPointLineNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityInsertionPointLineNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityInsertionPointLineNumberHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityInsertionPointLineNumber:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityInsertionPointLineNumber_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityInsertionPointLineNumber_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityLabel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityLabelUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLabelUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLabelUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual float AccessibilityLabelValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAccessibilityLabelValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelValueHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAccessibilityLabelValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAccessibilityLabelValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityLinkedUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLinkedUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLinkedUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLinkedUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLinkedUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityMain
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMain")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityMainHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityMainHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMain:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityMain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityMain_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMainWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMainWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMainWindowHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMainWindowHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMainWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMainWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMarkerGroupUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerGroupUIElementHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerGroupUIElementHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerGroupUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerGroupUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityMarkerTypeDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerTypeDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerTypeDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerTypeDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerTypeDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerTypeDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerTypeDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityMarkerUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMarkerValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerValues", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerValuesHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerValuesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMaxValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMaxValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMaxValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMaxValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMaxValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMaxValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityMenuBar_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMinValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMinValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMinValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMinValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMinValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMinimizeButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMinimizeButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMinimizeButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMinimizeButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMinimizeButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityMinimized
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMinimized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityMinimizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityMinimizedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityMinimized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityMinimized_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityModal
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityModalHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityModal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityNextContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNextContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityNextContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityNextContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityNextContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityNextContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityNumberOfCharacters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNumberOfCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityNumberOfCharactersHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityNumberOfCharactersHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNumberOfCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityNumberOfCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityNumberOfCharacters_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityOrderedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityOrderedByRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityOrderedByRowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityOrderedByRowHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrderedByRow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityOrderedByRow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityOrderedByRow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityOrientation AccessibilityOrientation
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOrientation", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityOrientation)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityOrientationHandle);
			}
			return (NSAccessibilityOrientation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityOrientationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityOrientation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityOrientation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityOverflowButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOverflowButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityOverflowButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityOverflowButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityOverflowButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityOverflowButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityParent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityParent", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle)));
			MarkDirty();
			__mt_AccessibilityParent_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityParent:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityParent_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityPlaceholderValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPlaceholderValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityPlaceholderValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityPlaceholderValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPlaceholderValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityPlaceholderValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityPlaceholderValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityPreviousContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPreviousContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityPreviousContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityPreviousContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityPreviousContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityPreviousContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityProtectedContent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityProtectedContent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityProtectedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityProtectedContentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProtectedContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityProtectedContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityProtectedContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityProxy
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityProxy", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityProxyHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityProxyHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProxy:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityProxy_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityProxy_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityRequired
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isAccessibilityRequired")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityRequiredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityRequiredHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRequired:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityRequired_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityRequired_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityRole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRole")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRoleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRoleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRole_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRole_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityRoleDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRoleDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRoleDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRoleDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRoleDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRoleDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRoleDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityRowCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityRowCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowCountHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityRowCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityRowCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityRowHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowHeaderUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRowHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRowHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityRowIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityRowIndexRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowIndexRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityRowIndexRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityRowIndexRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityRulerMarkerType)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityRulerMarkerTypeHandle);
			}
			return (NSAccessibilityRulerMarkerType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityRulerMarkerTypeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityRulerMarkerType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityRulerMarkerType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilitySearchButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySearchButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySearchButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySearchButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySearchButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilitySearchMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySearchMenuHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySearchMenuHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySearchMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySearchMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilitySelected
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilitySelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilitySelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilitySelectedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilitySelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilitySelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedCellsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilitySelectedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedText:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilitySelectedTextRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilitySelectedTextRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilitySelectedTextRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilitySelectedTextRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSValue[]? AccessibilitySelectedTextRanges
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedTextRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextRangesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedTextRanges_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedTextRanges_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityServesAsTitleForUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityServesAsTitleForUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityServesAsTitleForUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityServesAsTitleForUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityServesAsTitleForUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilitySharedCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilitySharedCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedCharacterRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilitySharedCharacterRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilitySharedCharacterRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySharedFocusElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySharedFocusElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedFocusElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySharedFocusElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySharedFocusElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySharedTextUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySharedTextUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedTextUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySharedTextUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySharedTextUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityShownMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityShownMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityShownMenuHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityShownMenuHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityShownMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityShownMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilitySortDirection AccessibilitySortDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySortDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilitySortDirection)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilitySortDirectionHandle);
			}
			return (NSAccessibilitySortDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilitySortDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilitySortDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilitySortDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySplitters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySplitters", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySplittersHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySplittersHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySplitters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySplitters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilitySubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySubrole")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySubroleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySubroleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySubrole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySubrole_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySubrole_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityTabs
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTabs", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTabsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTabsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTabs:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTabs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTabs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTitleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityTitleUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTitleUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTitleUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTitleUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTitleUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTitleUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityTitleUIElement_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityToolbarButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityToolbarButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityToolbarButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityToolbarButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityToolbarButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityToolbarButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityTopLevelUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTopLevelUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTopLevelUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTopLevelUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTopLevelUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTopLevelUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityTopLevelUIElement_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSUrl? AccessibilityUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityURLHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityValueDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValueDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValueDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityValueDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityValueDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityVerticalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVerticalScrollBarHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalScrollBarHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVerticalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVerticalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityVerticalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVerticalUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVerticalUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVerticalUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityVerticalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityVerticalUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityVerticalUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityVerticalUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCellsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityVisibleCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityVisibleCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCharacterRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityVisibleCharacterRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityVisibleCharacterRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityWarningValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWarningValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWarningValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWarningValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWarningValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWarningValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWindowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWindowHandle)));
			MarkDirty();
			__mt_AccessibilityWindow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityWindow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityWindows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWindowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWindowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWindows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWindows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityZoomButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityZoomButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityZoomButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityZoomButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityZoomButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityZoomButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static bool AllowsAutomaticWindowTabbing
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("allowsAutomaticWindowTabbing")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selAllowsAutomaticWindowTabbingHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAllowsAutomaticWindowTabbing:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetAllowsAutomaticWindowTabbing_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsConcurrentViewDrawing
	{
		[Export("allowsConcurrentViewDrawing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsConcurrentViewDrawingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsConcurrentViewDrawingHandle);
		}
		[Export("setAllowsConcurrentViewDrawing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsConcurrentViewDrawing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsConcurrentViewDrawing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsToolTipsWhenApplicationIsInactive
	{
		[Export("allowsToolTipsWhenApplicationIsInactive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsToolTipsWhenApplicationIsInactiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsToolTipsWhenApplicationIsInactiveHandle);
		}
		[Export("setAllowsToolTipsWhenApplicationIsInactive:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsToolTipsWhenApplicationIsInactive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsToolTipsWhenApplicationIsInactive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AlphaValue
	{
		[Export("alphaValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaValueHandle);
		}
		[Export("setAlphaValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAlphaValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAlphaValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowAnimationBehavior AnimationBehavior
	{
		[Export("animationBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowAnimationBehavior)Messaging.Int64_objc_msgSend(base.Handle, selAnimationBehaviorHandle);
			}
			return (NSWindowAnimationBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAnimationBehaviorHandle);
		}
		[Export("setAnimationBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAnimationBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAnimationBehavior_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle)));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSAppearance? Appearance
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("appearance", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAppearance:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual INSAppearanceCustomization AppearanceSource
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("appearanceSource", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSAppearanceCustomization iNSAppearanceCustomization = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSAppearanceCustomization>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceSourceHandle), owns: false) : Runtime.GetINativeObject<INSAppearanceCustomization>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceSourceHandle), owns: false));
			MarkDirty();
			__mt_AppearanceSource_var = iNSAppearanceCustomization;
			return iNSAppearanceCustomization;
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setAppearanceSource:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppearanceSource_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppearanceSource_Handle, value.Handle);
			}
			MarkDirty();
			__mt_AppearanceSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AreCursorRectsEnabled
	{
		[Export("areCursorRectsEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreCursorRectsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreCursorRectsEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize AspectRatio
	{
		[Export("aspectRatio")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selAspectRatioHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selAspectRatioHandle);
		}
		[Export("setAspectRatio:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetAspectRatio_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow AttachedSheet
	{
		[Export("attachedSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedSheetHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedSheetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
	public virtual bool Autodisplay
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
		[Export("isAutodisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutodisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutodisplayHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
		[Export("setAutodisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutodisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutodisplay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutorecalculatesKeyViewLoop
	{
		[Export("autorecalculatesKeyViewLoop")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutorecalculatesKeyViewLoopHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutorecalculatesKeyViewLoopHandle);
		}
		[Export("setAutorecalculatesKeyViewLoop:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutorecalculatesKeyViewLoop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutorecalculatesKeyViewLoop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	public virtual NSWindowBackingLocation BackingLocation
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("backingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSend(base.Handle, selBackingLocationHandle);
			}
			return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBackingLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BackingScaleFactor
	{
		[Export("backingScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBackingScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBackingScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	public virtual NSBackingStore BackingType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("backingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBackingStore)Messaging.UInt64_objc_msgSend(base.Handle, selBackingTypeHandle);
			}
			return (NSBackingStore)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBackingTypeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("setBackingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBackingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBackingType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBecomeKeyWindow
	{
		[Export("canBecomeKeyWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeKeyWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeKeyWindowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBecomeMainWindow
	{
		[Export("canBecomeMainWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeMainWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeMainWindowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBecomeVisibleWithoutLogin
	{
		[Export("canBecomeVisibleWithoutLogin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeVisibleWithoutLoginHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeVisibleWithoutLoginHandle);
		}
		[Export("setCanBecomeVisibleWithoutLogin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanBecomeVisibleWithoutLogin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanBecomeVisibleWithoutLogin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanHide
	{
		[Export("canHide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanHideHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanHideHandle);
		}
		[Export("setCanHide:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanHide_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanHide_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool CanStoreColor
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("canStoreColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStoreColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStoreColorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow[] ChildWindows
	{
		[Export("childWindows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildWindowsHandle));
			}
			return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildWindowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowCollectionBehavior CollectionBehavior
	{
		[Export("collectionBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowCollectionBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selCollectionBehaviorHandle);
			}
			return (NSWindowCollectionBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCollectionBehaviorHandle);
		}
		[Export("setCollectionBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCollectionBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCollectionBehavior_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
		[Export("setColorSpace:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorSpace_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorSpace_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentAspectRatio
	{
		[Export("contentAspectRatio")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentAspectRatioHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentAspectRatioHandle);
		}
		[Export("setContentAspectRatio:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentAspectRatio_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject ContentLayoutGuide
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contentLayoutGuide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentLayoutGuideHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentLayoutGuideHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGRect ContentLayoutRect
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contentLayoutRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContentLayoutRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentLayoutRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentMaxSize
	{
		[Export("contentMaxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentMaxSizeHandle);
		}
		[Export("setContentMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentMaxSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentMinSize
	{
		[Export("contentMinSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentMinSizeHandle);
		}
		[Export("setContentMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentMinSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentResizeIncrements
	{
		[Export("contentResizeIncrements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentResizeIncrementsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentResizeIncrementsHandle);
		}
		[Export("setContentResizeIncrements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentResizeIncrements_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentResizeIncrements_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView ContentView
	{
		[Export("contentView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle));
		}
		[Export("setContentView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController ContentViewController
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contentViewController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewControllerHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setContentViewController:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentViewController_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScreen DeepestScreen
	{
		[Export("deepestScreen")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeepestScreenHandle));
			}
			return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeepestScreenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButtonCell? DefaultButtonCell
	{
		[Export("defaultButtonCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultButtonCellHandle));
			}
			return Runtime.GetNSObject<NSButtonCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultButtonCellHandle));
		}
		[Export("setDefaultButtonCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultButtonCell_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultButtonCell_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindowDepth DefaultDepthLimit
	{
		[Export("defaultDepthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindowDepth)Messaging.int_objc_msgSend(class_ptr, selDefaultDepthLimitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSWindowDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSWindowDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowDepth DepthLimit
	{
		[Export("depthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowDepth)Messaging.int_objc_msgSend(base.Handle, selDepthLimitHandle);
			}
			return (NSWindowDepth)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDepthLimitHandle);
		}
		[Export("setDepthLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDepthLimit_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDepthLimit_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysWhenScreenProfileChanges
	{
		[Export("displaysWhenScreenProfileChanges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysWhenScreenProfileChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysWhenScreenProfileChangesHandle);
		}
		[Export("setDisplaysWhenScreenProfileChanges:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysWhenScreenProfileChanges_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysWhenScreenProfileChanges_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDockTile DockTile
	{
		[Export("dockTile")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDockTile>(Messaging.IntPtr_objc_msgSend(base.Handle, selDockTileHandle));
			}
			return Runtime.GetNSObject<NSDockTile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDockTileHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DocumentEdited
	{
		[Export("isDocumentEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDocumentEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDocumentEditedHandle);
		}
		[Export("setDocumentEdited:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDocumentEdited_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDocumentEdited_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSAppearance EffectiveAppearance
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("effectiveAppearance", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selEffectiveAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEffectiveAppearanceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExcludedFromWindowsMenu
	{
		[Export("isExcludedFromWindowsMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExcludedFromWindowsMenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExcludedFromWindowsMenuHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSResponder FirstResponder
	{
		[Export("firstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstResponderHandle));
			}
			return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstResponderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
	public virtual bool FlushWindowDisabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
		[Export("isFlushWindowDisabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlushWindowDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlushWindowDisabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Add instances of NSView to display content in a window.")]
	public virtual NSGraphicsContext GraphicsContext
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Add instances of NSView to display content in a window.")]
		[Export("graphicsContext")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selGraphicsContextHandle));
			}
			return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGraphicsContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDynamicDepthLimit
	{
		[Export("hasDynamicDepthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDynamicDepthLimitHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDynamicDepthLimitHandle);
		}
		[Export("setDynamicDepthLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDynamicDepthLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDynamicDepthLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasShadow
	{
		[Export("hasShadow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasShadowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasShadowHandle);
		}
		[Export("setHasShadow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasShadow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasShadow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HidesOnDeactivate
	{
		[Export("hidesOnDeactivate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesOnDeactivateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesOnDeactivateHandle);
		}
		[Export("setHidesOnDeactivate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidesOnDeactivate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidesOnDeactivate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoresMouseEvents
	{
		[Export("ignoresMouseEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoresMouseEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoresMouseEventsHandle);
		}
		[Export("setIgnoresMouseEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIgnoresMouseEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIgnoresMouseEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InLiveResize
	{
		[Export("inLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInLiveResizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView InitialFirstResponder
	{
		[Export("initialFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialFirstResponderHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialFirstResponderHandle));
		}
		[Export("setInitialFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInitialFirstResponder_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInitialFirstResponder_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsKeyWindow
	{
		[Export("isKeyWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsKeyWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsKeyWindowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMainWindow
	{
		[Export("isMainWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMainWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMainWindowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMiniaturized
	{
		[Export("isMiniaturized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMiniaturizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMiniaturizedHandle);
		}
		[Export("setIsMiniaturized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsMiniaturized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsMiniaturized_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMovable
	{
		[Export("isMovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableHandle);
		}
		[Export("setMovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOnActiveSpace
	{
		[Export("isOnActiveSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOnActiveSpaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOnActiveSpaceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	public virtual bool IsOneShot
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("isOneShot")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOneShotHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOneShotHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOpaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Export("setOpaque:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSheet
	{
		[Export("isSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSheetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSheetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsVisible
	{
		[Export("isVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
		[Export("setIsVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsZoomed
	{
		[Export("isZoomed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsZoomedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsZoomedHandle);
		}
		[Export("setIsZoomed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsZoomed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsZoomed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowLevel Level
	{
		[Export("level")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowLevel)Messaging.Int64_objc_msgSend(base.Handle, selLevelHandle);
			}
			return (NSWindowLevel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLevelHandle);
		}
		[Export("setLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLevel_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLevel_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CGSize MaxFullScreenContentSize
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("maxFullScreenContentSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxFullScreenContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxFullScreenContentSizeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMaxFullScreenContentSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxFullScreenContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxFullScreenContentSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaxSize
	{
		[Export("maxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxSizeHandle);
		}
		[Export("setMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CGSize MinFullScreenContentSize
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("minFullScreenContentSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinFullScreenContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinFullScreenContentSizeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMinFullScreenContentSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinFullScreenContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinFullScreenContentSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinSize
	{
		[Export("minSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinSizeHandle);
		}
		[Export("setMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage MiniWindowImage
	{
		[Export("miniwindowImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selMiniwindowImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiniwindowImageHandle));
		}
		[Export("setMiniwindowImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiniwindowImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiniwindowImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MiniWindowTitle
	{
		[Export("miniwindowTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMiniwindowTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiniwindowTitleHandle));
		}
		[Export("setMiniwindowTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiniwindowTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiniwindowTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint MouseLocationOutsideOfEventStream
	{
		[Export("mouseLocationOutsideOfEventStream")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selMouseLocationOutsideOfEventStreamHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selMouseLocationOutsideOfEventStreamHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MovableByWindowBackground
	{
		[Export("isMovableByWindowBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableByWindowBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableByWindowBackgroundHandle);
		}
		[Export("setMovableByWindowBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovableByWindowBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovableByWindowBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSWindowOcclusionState OcclusionState
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("occlusionState")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowOcclusionState)Messaging.UInt64_objc_msgSend(base.Handle, selOcclusionStateHandle);
			}
			return (NSWindowOcclusionState)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOcclusionStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow ParentWindow
	{
		[Export("parentWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentWindowHandle));
		}
		[Export("setParentWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentWindow_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	public virtual NSWindowBackingLocation PreferredBackingLocation
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("preferredBackingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSend(base.Handle, selPreferredBackingLocationHandle);
			}
			return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPreferredBackingLocationHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
		[Export("setPreferredBackingLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPreferredBackingLocation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPreferredBackingLocation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesContentDuringLiveResize
	{
		[Export("preservesContentDuringLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesContentDuringLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesContentDuringLiveResizeHandle);
		}
		[Export("setPreservesContentDuringLiveResize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesContentDuringLiveResize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesContentDuringLiveResize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreventsApplicationTerminationWhenModal
	{
		[Export("preventsApplicationTerminationWhenModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreventsApplicationTerminationWhenModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreventsApplicationTerminationWhenModalHandle);
		}
		[Export("setPreventsApplicationTerminationWhenModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreventsApplicationTerminationWhenModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreventsApplicationTerminationWhenModal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReleasedWhenClosed
	{
		[Export("isReleasedWhenClosed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReleasedWhenClosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReleasedWhenClosedHandle);
		}
		[Export("setReleasedWhenClosed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReleasedWhenClosed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReleasedWhenClosed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RepresentedFilename
	{
		[Export("representedFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedFilenameHandle));
		}
		[Export("setRepresentedFilename:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl RepresentedUrl
	{
		[Export("representedURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedURLHandle));
		}
		[Export("setRepresentedURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedURL_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ResizeFlags
	{
		[Export("resizeFlags")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selResizeFlagsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selResizeFlagsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ResizeIncrements
	{
		[Export("resizeIncrements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selResizeIncrementsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selResizeIncrementsHandle);
		}
		[Export("setResizeIncrements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetResizeIncrements_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetResizeIncrements_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Restorable
	{
		[Export("isRestorable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRestorableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRestorableHandle);
		}
		[Export("setRestorable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRestorable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRestorable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class RestorationClass
	{
		[Export("restorationClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRestorationClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRestorationClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Export("setRestorationClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRestorationClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRestorationClass_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScreen Screen
	{
		[Export("screen")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSend(base.Handle, selScreenHandle));
			}
			return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScreenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowSharingType SharingType
	{
		[Export("sharingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowSharingType)Messaging.UInt64_objc_msgSend(base.Handle, selSharingTypeHandle);
			}
			return (NSWindowSharingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSharingTypeHandle);
		}
		[Export("setSharingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSharingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSharingType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSWindow SheetParent
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("sheetParent", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selSheetParentHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSheetParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSWindow[] Sheets
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("sheets", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selSheetsHandle));
			}
			return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSheetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsResizeIndicator
	{
		[Export("showsResizeIndicator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsResizeIndicatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsResizeIndicatorHandle);
		}
		[Export("setShowsResizeIndicator:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsResizeIndicator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsResizeIndicator_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsToolbarButton
	{
		[Export("showsToolbarButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsToolbarButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsToolbarButtonHandle);
		}
		[Export("setShowsToolbarButton:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsToolbarButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsToolbarButton_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowStyle StyleMask
	{
		[Export("styleMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowStyle)Messaging.UInt64_objc_msgSend(base.Handle, selStyleMaskHandle);
			}
			return (NSWindowStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStyleMaskHandle);
		}
		[Export("setStyleMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStyleMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStyleMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSWindowTab Tab
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("tab", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindowTab>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabHandle));
			}
			return Runtime.GetNSObject<NSWindowTab>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSWindowTabGroup? TabGroup
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("tabGroup", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSWindowTabGroup nSWindowTabGroup = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSWindowTabGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabGroupHandle)) : Runtime.GetNSObject<NSWindowTabGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabGroupHandle)));
			MarkDirty();
			__mt_TabGroup_var = nSWindowTabGroup;
			return nSWindowTabGroup;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSWindow[]? TabbedWindows
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("tabbedWindows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabbedWindowsHandle));
			}
			return NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabbedWindowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string TabbingIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("tabbingIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTabbingIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabbingIdentifierHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setTabbingIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTabbingIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTabbingIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSWindowTabbingMode TabbingMode
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("tabbingMode", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowTabbingMode)Messaging.Int64_objc_msgSend(base.Handle, selTabbingModeHandle);
			}
			return (NSWindowTabbingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTabbingModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setTabbingMode:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTabbingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTabbingMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSWindowTitleVisibility TitleVisibility
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("titleVisibility")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowTitleVisibility)Messaging.Int64_objc_msgSend(base.Handle, selTitleVisibilityHandle);
			}
			return (NSWindowTitleVisibility)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTitleVisibilityHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setTitleVisibility:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTitleVisibility_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTitleVisibility_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSTitlebarAccessoryViewController[] TitlebarAccessoryViewControllers
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("titlebarAccessoryViewControllers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTitlebarAccessoryViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selTitlebarAccessoryViewControllersHandle));
			}
			return NSArray.ArrayFromHandle<NSTitlebarAccessoryViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitlebarAccessoryViewControllersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool TitlebarAppearsTransparent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("titlebarAppearsTransparent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTitlebarAppearsTransparentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTitlebarAppearsTransparentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setTitlebarAppearsTransparent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTitlebarAppearsTransparent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTitlebarAppearsTransparent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbar? Toolbar
	{
		[Export("toolbar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSToolbar>(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarHandle));
			}
			return Runtime.GetNSObject<NSToolbar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarHandle));
		}
		[Export("setToolbar:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToolbar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToolbar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual nfloat UserSpaceScaleFactor
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("userSpaceScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUserSpaceScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUserSpaceScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSWindowUserTabbingPreference UserTabbingPreference
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("userTabbingPreference")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindowUserTabbingPreference)Messaging.Int64_objc_msgSend(class_ptr, selUserTabbingPreferenceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ViewsNeedDisplay
	{
		[Export("viewsNeedDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selViewsNeedDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selViewsNeedDisplayHandle);
		}
		[Export("setViewsNeedDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetViewsNeedDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetViewsNeedDisplay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WindowController
	{
		[Export("windowController")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowControllerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowControllerHandle));
		}
		[Export("setWindowController:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindowController_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindowController_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WindowNumber
	{
		[Export("windowNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWindowNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWindowNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr WindowRef
	{
		[Export("windowRef")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selWindowRefHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowRefHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceLayoutDirection WindowTitlebarLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("windowTitlebarLayoutDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selWindowTitlebarLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWindowTitlebarLayoutDirectionHandle);
		}
	}

	[Field("NSAccessibilityAnnouncementRequestedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveAnnouncementRequested helper method instead.")]
	public static NSString AnnouncementRequestedNotification
	{
		get
		{
			if (_AnnouncementRequestedNotification == null)
			{
				_AnnouncementRequestedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnouncementRequestedNotification");
			}
			return _AnnouncementRequestedNotification;
		}
	}

	[Field("NSAccessibilityApplicationActivatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveApplicationActivated helper method instead.")]
	public static NSString ApplicationActivatedNotification
	{
		get
		{
			if (_ApplicationActivatedNotification == null)
			{
				_ApplicationActivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationActivatedNotification");
			}
			return _ApplicationActivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationDeactivatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveApplicationDeactivated helper method instead.")]
	public static NSString ApplicationDeactivatedNotification
	{
		get
		{
			if (_ApplicationDeactivatedNotification == null)
			{
				_ApplicationDeactivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationDeactivatedNotification");
			}
			return _ApplicationDeactivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationHiddenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveApplicationHidden helper method instead.")]
	public static NSString ApplicationHiddenNotification
	{
		get
		{
			if (_ApplicationHiddenNotification == null)
			{
				_ApplicationHiddenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationHiddenNotification");
			}
			return _ApplicationHiddenNotification;
		}
	}

	[Field("NSAccessibilityApplicationShownNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveApplicationShown helper method instead.")]
	public static NSString ApplicationShownNotification
	{
		get
		{
			if (_ApplicationShownNotification == null)
			{
				_ApplicationShownNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationShownNotification");
			}
			return _ApplicationShownNotification;
		}
	}

	[Field("NSAccessibilityCreatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveCreated helper method instead.")]
	public static NSString CreatedNotification
	{
		get
		{
			if (_CreatedNotification == null)
			{
				_CreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCreatedNotification");
			}
			return _CreatedNotification;
		}
	}

	[Field("NSWindowDidBecomeKeyNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidBecomeKey helper method instead.")]
	public static NSString DidBecomeKeyNotification
	{
		get
		{
			if (_DidBecomeKeyNotification == null)
			{
				_DidBecomeKeyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidBecomeKeyNotification");
			}
			return _DidBecomeKeyNotification;
		}
	}

	[Field("NSWindowDidBecomeMainNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidBecomeMain helper method instead.")]
	public static NSString DidBecomeMainNotification
	{
		get
		{
			if (_DidBecomeMainNotification == null)
			{
				_DidBecomeMainNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidBecomeMainNotification");
			}
			return _DidBecomeMainNotification;
		}
	}

	[Field("NSWindowDidChangeBackingPropertiesNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidChangeBackingProperties helper method instead.")]
	public static NSString DidChangeBackingPropertiesNotification
	{
		get
		{
			if (_DidChangeBackingPropertiesNotification == null)
			{
				_DidChangeBackingPropertiesNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidChangeBackingPropertiesNotification");
			}
			return _DidChangeBackingPropertiesNotification;
		}
	}

	[Field("NSWindowDidChangeScreenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidChangeScreen helper method instead.")]
	public static NSString DidChangeScreenNotification
	{
		get
		{
			if (_DidChangeScreenNotification == null)
			{
				_DidChangeScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidChangeScreenNotification");
			}
			return _DidChangeScreenNotification;
		}
	}

	[Field("NSWindowDidChangeScreenProfileNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidChangeScreenProfile helper method instead.")]
	public static NSString DidChangeScreenProfileNotification
	{
		get
		{
			if (_DidChangeScreenProfileNotification == null)
			{
				_DidChangeScreenProfileNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidChangeScreenProfileNotification");
			}
			return _DidChangeScreenProfileNotification;
		}
	}

	[Field("NSWindowDidDeminiaturizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidDeminiaturize helper method instead.")]
	public static NSString DidDeminiaturizeNotification
	{
		get
		{
			if (_DidDeminiaturizeNotification == null)
			{
				_DidDeminiaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidDeminiaturizeNotification");
			}
			return _DidDeminiaturizeNotification;
		}
	}

	[Field("NSWindowDidEndLiveResizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidEndLiveResize helper method instead.")]
	public static NSString DidEndLiveResizeNotification
	{
		get
		{
			if (_DidEndLiveResizeNotification == null)
			{
				_DidEndLiveResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEndLiveResizeNotification");
			}
			return _DidEndLiveResizeNotification;
		}
	}

	[Field("NSWindowDidEndSheetNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidEndSheet helper method instead.")]
	public static NSString DidEndSheetNotification
	{
		get
		{
			if (_DidEndSheetNotification == null)
			{
				_DidEndSheetNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEndSheetNotification");
			}
			return _DidEndSheetNotification;
		}
	}

	[Field("NSWindowDidEnterFullScreenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidEnterFullScreen helper method instead.")]
	public static NSString DidEnterFullScreenNotification
	{
		get
		{
			if (_DidEnterFullScreenNotification == null)
			{
				_DidEnterFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEnterFullScreenNotification");
			}
			return _DidEnterFullScreenNotification;
		}
	}

	[Field("NSWindowDidEnterVersionBrowserNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidEnterVersionBrowser helper method instead.")]
	public static NSString DidEnterVersionBrowserNotification
	{
		get
		{
			if (_DidEnterVersionBrowserNotification == null)
			{
				_DidEnterVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEnterVersionBrowserNotification");
			}
			return _DidEnterVersionBrowserNotification;
		}
	}

	[Field("NSWindowDidExitFullScreenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidExitFullScreen helper method instead.")]
	public static NSString DidExitFullScreenNotification
	{
		get
		{
			if (_DidExitFullScreenNotification == null)
			{
				_DidExitFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExitFullScreenNotification");
			}
			return _DidExitFullScreenNotification;
		}
	}

	[Field("NSWindowDidExitVersionBrowserNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidExitVersionBrowser helper method instead.")]
	public static NSString DidExitVersionBrowserNotification
	{
		get
		{
			if (_DidExitVersionBrowserNotification == null)
			{
				_DidExitVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExitVersionBrowserNotification");
			}
			return _DidExitVersionBrowserNotification;
		}
	}

	[Field("NSWindowDidExposeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidExpose helper method instead.")]
	public static NSString DidExposeNotification
	{
		get
		{
			if (_DidExposeNotification == null)
			{
				_DidExposeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExposeNotification");
			}
			return _DidExposeNotification;
		}
	}

	[Field("NSWindowDidMiniaturizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidMiniaturize helper method instead.")]
	public static NSString DidMiniaturizeNotification
	{
		get
		{
			if (_DidMiniaturizeNotification == null)
			{
				_DidMiniaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidMiniaturizeNotification");
			}
			return _DidMiniaturizeNotification;
		}
	}

	[Field("NSWindowDidMoveNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidMove helper method instead.")]
	public static NSString DidMoveNotification
	{
		get
		{
			if (_DidMoveNotification == null)
			{
				_DidMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidMoveNotification");
			}
			return _DidMoveNotification;
		}
	}

	[Field("NSWindowDidResignKeyNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidResignKey helper method instead.")]
	public static NSString DidResignKeyNotification
	{
		get
		{
			if (_DidResignKeyNotification == null)
			{
				_DidResignKeyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResignKeyNotification");
			}
			return _DidResignKeyNotification;
		}
	}

	[Field("NSWindowDidResignMainNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidResignMain helper method instead.")]
	public static NSString DidResignMainNotification
	{
		get
		{
			if (_DidResignMainNotification == null)
			{
				_DidResignMainNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResignMainNotification");
			}
			return _DidResignMainNotification;
		}
	}

	[Field("NSWindowDidResizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidResize helper method instead.")]
	public static NSString DidResizeNotification
	{
		get
		{
			if (_DidResizeNotification == null)
			{
				_DidResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResizeNotification");
			}
			return _DidResizeNotification;
		}
	}

	[Field("NSWindowDidUpdateNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDidUpdate helper method instead.")]
	public static NSString DidUpdateNotification
	{
		get
		{
			if (_DidUpdateNotification == null)
			{
				_DidUpdateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidUpdateNotification");
			}
			return _DidUpdateNotification;
		}
	}

	[Field("NSAccessibilityDrawerCreatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveDrawerCreated helper method instead.")]
	public static NSString DrawerCreatedNotification
	{
		get
		{
			if (_DrawerCreatedNotification == null)
			{
				_DrawerCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDrawerCreatedNotification");
			}
			return _DrawerCreatedNotification;
		}
	}

	[Field("NSAccessibilityFocusedWindowChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveFocusedWindowChanged helper method instead.")]
	public static NSString FocusedWindowChangedNotification
	{
		get
		{
			if (_FocusedWindowChangedNotification == null)
			{
				_FocusedWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowChangedNotification");
			}
			return _FocusedWindowChangedNotification;
		}
	}

	[Field("NSAccessibilityHelpTagCreatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveHelpTagCreated helper method instead.")]
	public static NSString HelpTagCreatedNotification
	{
		get
		{
			if (_HelpTagCreatedNotification == null)
			{
				_HelpTagCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHelpTagCreatedNotification");
			}
			return _HelpTagCreatedNotification;
		}
	}

	[Field("NSAccessibilityLayoutChangedNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use NSWindow.Notifications.ObserveLayoutChanged helper method instead.")]
	public static NSString LayoutChangedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LayoutChangedNotification == null)
			{
				_LayoutChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLayoutChangedNotification");
			}
			return _LayoutChangedNotification;
		}
	}

	[Field("NSAccessibilityMainWindowChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveMainWindowChanged helper method instead.")]
	public static NSString MainWindowChangedNotification
	{
		get
		{
			if (_MainWindowChangedNotification == null)
			{
				_MainWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMainWindowChangedNotification");
			}
			return _MainWindowChangedNotification;
		}
	}

	[Field("NSAccessibilityMovedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveMoved helper method instead.")]
	public static NSString MovedNotification
	{
		get
		{
			if (_MovedNotification == null)
			{
				_MovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMovedNotification");
			}
			return _MovedNotification;
		}
	}

	[Field("NSAccessibilityResizedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveResized helper method instead.")]
	public static NSString ResizedNotification
	{
		get
		{
			if (_ResizedNotification == null)
			{
				_ResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityResizedNotification");
			}
			return _ResizedNotification;
		}
	}

	[Field("NSAccessibilityRowCollapsedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveRowCollapsed helper method instead.")]
	public static NSString RowCollapsedNotification
	{
		get
		{
			if (_RowCollapsedNotification == null)
			{
				_RowCollapsedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCollapsedNotification");
			}
			return _RowCollapsedNotification;
		}
	}

	[Field("NSAccessibilityRowCountChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveRowCountChanged helper method instead.")]
	public static NSString RowCountChangedNotification
	{
		get
		{
			if (_RowCountChangedNotification == null)
			{
				_RowCountChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCountChangedNotification");
			}
			return _RowCountChangedNotification;
		}
	}

	[Field("NSAccessibilityRowExpandedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveRowExpanded helper method instead.")]
	public static NSString RowExpandedNotification
	{
		get
		{
			if (_RowExpandedNotification == null)
			{
				_RowExpandedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowExpandedNotification");
			}
			return _RowExpandedNotification;
		}
	}

	[Field("NSAccessibilitySelectedCellsChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedCellsChanged helper method instead.")]
	public static NSString SelectedCellsChangedNotification
	{
		get
		{
			if (_SelectedCellsChangedNotification == null)
			{
				_SelectedCellsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsChangedNotification");
			}
			return _SelectedCellsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedChildrenChanged helper method instead.")]
	public static NSString SelectedChildrenChangedNotification
	{
		get
		{
			if (_SelectedChildrenChangedNotification == null)
			{
				_SelectedChildrenChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenChangedNotification");
			}
			return _SelectedChildrenChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenMovedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedChildrenMoved helper method instead.")]
	public static NSString SelectedChildrenMovedNotification
	{
		get
		{
			if (_SelectedChildrenMovedNotification == null)
			{
				_SelectedChildrenMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenMovedNotification");
			}
			return _SelectedChildrenMovedNotification;
		}
	}

	[Field("NSAccessibilitySelectedColumnsChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedColumnsChanged helper method instead.")]
	public static NSString SelectedColumnsChangedNotification
	{
		get
		{
			if (_SelectedColumnsChangedNotification == null)
			{
				_SelectedColumnsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsChangedNotification");
			}
			return _SelectedColumnsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedRowsChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedRowsChanged helper method instead.")]
	public static NSString SelectedRowsChangedNotification
	{
		get
		{
			if (_SelectedRowsChangedNotification == null)
			{
				_SelectedRowsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsChangedNotification");
			}
			return _SelectedRowsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedTextChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSelectedTextChanged helper method instead.")]
	public static NSString SelectedTextChangedNotification
	{
		get
		{
			if (_SelectedTextChangedNotification == null)
			{
				_SelectedTextChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextChangedNotification");
			}
			return _SelectedTextChangedNotification;
		}
	}

	[Field("NSAccessibilitySheetCreatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveSheetCreated helper method instead.")]
	public static NSString SheetCreatedNotification
	{
		get
		{
			if (_SheetCreatedNotification == null)
			{
				_SheetCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySheetCreatedNotification");
			}
			return _SheetCreatedNotification;
		}
	}

	[Field("NSAccessibilityTitleChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveTitleChanged helper method instead.")]
	public static NSString TitleChangedNotification
	{
		get
		{
			if (_TitleChangedNotification == null)
			{
				_TitleChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTitleChangedNotification");
			}
			return _TitleChangedNotification;
		}
	}

	[Field("NSAccessibilityUIElementDestroyedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveUIElementDestroyed helper method instead.")]
	public static NSString UIElementDestroyedNotification
	{
		get
		{
			if (_UIElementDestroyedNotification == null)
			{
				_UIElementDestroyedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUIElementDestroyedNotification");
			}
			return _UIElementDestroyedNotification;
		}
	}

	[Field("NSAccessibilityFocusedUIElementChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveUIElementFocusedChanged helper method instead.")]
	public static NSString UIElementFocusedChangedNotification
	{
		get
		{
			if (_UIElementFocusedChangedNotification == null)
			{
				_UIElementFocusedChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementChangedNotification");
			}
			return _UIElementFocusedChangedNotification;
		}
	}

	[Field("NSAccessibilityUnitsChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveUnitsChanged helper method instead.")]
	public static NSString UnitsChangedNotification
	{
		get
		{
			if (_UnitsChangedNotification == null)
			{
				_UnitsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnitsChangedNotification");
			}
			return _UnitsChangedNotification;
		}
	}

	[Field("NSAccessibilityValueChangedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveValueChanged helper method instead.")]
	public static NSString ValueChangedNotification
	{
		get
		{
			if (_ValueChangedNotification == null)
			{
				_ValueChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityValueChangedNotification");
			}
			return _ValueChangedNotification;
		}
	}

	[Field("NSWindowWillBeginSheetNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillBeginSheet helper method instead.")]
	public static NSString WillBeginSheetNotification
	{
		get
		{
			if (_WillBeginSheetNotification == null)
			{
				_WillBeginSheetNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillBeginSheetNotification");
			}
			return _WillBeginSheetNotification;
		}
	}

	[Field("NSWindowWillCloseNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillClose helper method instead.")]
	public static NSString WillCloseNotification
	{
		get
		{
			if (_WillCloseNotification == null)
			{
				_WillCloseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillCloseNotification");
			}
			return _WillCloseNotification;
		}
	}

	[Field("NSWindowWillEnterFullScreenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillEnterFullScreen helper method instead.")]
	public static NSString WillEnterFullScreenNotification
	{
		get
		{
			if (_WillEnterFullScreenNotification == null)
			{
				_WillEnterFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillEnterFullScreenNotification");
			}
			return _WillEnterFullScreenNotification;
		}
	}

	[Field("NSWindowWillEnterVersionBrowserNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillEnterVersionBrowser helper method instead.")]
	public static NSString WillEnterVersionBrowserNotification
	{
		get
		{
			if (_WillEnterVersionBrowserNotification == null)
			{
				_WillEnterVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillEnterVersionBrowserNotification");
			}
			return _WillEnterVersionBrowserNotification;
		}
	}

	[Field("NSWindowWillExitFullScreenNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillExitFullScreen helper method instead.")]
	public static NSString WillExitFullScreenNotification
	{
		get
		{
			if (_WillExitFullScreenNotification == null)
			{
				_WillExitFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillExitFullScreenNotification");
			}
			return _WillExitFullScreenNotification;
		}
	}

	[Field("NSWindowWillExitVersionBrowserNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillExitVersionBrowser helper method instead.")]
	public static NSString WillExitVersionBrowserNotification
	{
		get
		{
			if (_WillExitVersionBrowserNotification == null)
			{
				_WillExitVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillExitVersionBrowserNotification");
			}
			return _WillExitVersionBrowserNotification;
		}
	}

	[Field("NSWindowWillMiniaturizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillMiniaturize helper method instead.")]
	public static NSString WillMiniaturizeNotification
	{
		get
		{
			if (_WillMiniaturizeNotification == null)
			{
				_WillMiniaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillMiniaturizeNotification");
			}
			return _WillMiniaturizeNotification;
		}
	}

	[Field("NSWindowWillMoveNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillMove helper method instead.")]
	public static NSString WillMoveNotification
	{
		get
		{
			if (_WillMoveNotification == null)
			{
				_WillMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillMoveNotification");
			}
			return _WillMoveNotification;
		}
	}

	[Field("NSWindowWillStartLiveResizeNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWillStartLiveResize helper method instead.")]
	public static NSString WillStartLiveResizeNotification
	{
		get
		{
			if (_WillStartLiveResizeNotification == null)
			{
				_WillStartLiveResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillStartLiveResizeNotification");
			}
			return _WillStartLiveResizeNotification;
		}
	}

	[Field("NSAccessibilityWindowCreatedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWindowCreated helper method instead.")]
	public static NSString WindowCreatedNotification
	{
		get
		{
			if (_WindowCreatedNotification == null)
			{
				_WindowCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowCreatedNotification");
			}
			return _WindowCreatedNotification;
		}
	}

	[Field("NSAccessibilityWindowDeminiaturizedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWindowDeminiaturized helper method instead.")]
	public static NSString WindowDeminiaturizedNotification
	{
		get
		{
			if (_WindowDeminiaturizedNotification == null)
			{
				_WindowDeminiaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowDeminiaturizedNotification");
			}
			return _WindowDeminiaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMiniaturizedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWindowMiniaturized helper method instead.")]
	public static NSString WindowMiniaturizedNotification
	{
		get
		{
			if (_WindowMiniaturizedNotification == null)
			{
				_WindowMiniaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMiniaturizedNotification");
			}
			return _WindowMiniaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMovedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWindowMoved helper method instead.")]
	public static NSString WindowMovedNotification
	{
		get
		{
			if (_WindowMovedNotification == null)
			{
				_WindowMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMovedNotification");
			}
			return _WindowMovedNotification;
		}
	}

	[Field("NSAccessibilityWindowResizedNotification", "AppKit")]
	[Advice("Use NSWindow.Notifications.ObserveWindowResized helper method instead.")]
	public static NSString WindowResizedNotification
	{
		get
		{
			if (_WindowResizedNotification == null)
			{
				_WindowResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowResizedNotification");
			}
			return _WindowResizedNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSWindowDelegate);

	public NSWindowWindows? CustomWindowsToEnterFullScreen
	{
		get
		{
			return EnsureNSWindowDelegate().customWindowsToEnterFullScreen;
		}
		set
		{
			EnsureNSWindowDelegate().customWindowsToEnterFullScreen = value;
		}
	}

	public NSWindowWindows? CustomWindowsToExitFullScreen
	{
		get
		{
			return EnsureNSWindowDelegate().customWindowsToExitFullScreen;
		}
		set
		{
			EnsureNSWindowDelegate().customWindowsToExitFullScreen = value;
		}
	}

	public NSWindowDocumentDrag? ShouldDragDocumentWithEvent
	{
		get
		{
			return EnsureNSWindowDelegate().shouldDragDocumentWithEvent;
		}
		set
		{
			EnsureNSWindowDelegate().shouldDragDocumentWithEvent = value;
		}
	}

	public NSWindowMenu? ShouldPopUpDocumentPathMenu
	{
		get
		{
			return EnsureNSWindowDelegate().shouldPopUpDocumentPathMenu;
		}
		set
		{
			EnsureNSWindowDelegate().shouldPopUpDocumentPathMenu = value;
		}
	}

	public NSWindowFramePredicate? ShouldZoom
	{
		get
		{
			return EnsureNSWindowDelegate().shouldZoom;
		}
		set
		{
			EnsureNSWindowDelegate().shouldZoom = value;
		}
	}

	public NSWindowSheetRect? WillPositionSheet
	{
		get
		{
			return EnsureNSWindowDelegate().willPositionSheet;
		}
		set
		{
			EnsureNSWindowDelegate().willPositionSheet = value;
		}
	}

	public NSWindowResize? WillResize
	{
		get
		{
			return EnsureNSWindowDelegate().willResize;
		}
		set
		{
			EnsureNSWindowDelegate().willResize = value;
		}
	}

	public NSWindowSizeSize? WillResizeForVersionBrowser
	{
		get
		{
			return EnsureNSWindowDelegate().willResizeForVersionBrowser;
		}
		set
		{
			EnsureNSWindowDelegate().willResizeForVersionBrowser = value;
		}
	}

	public NSWindowClient? WillReturnFieldEditor
	{
		get
		{
			return EnsureNSWindowDelegate().willReturnFieldEditor;
		}
		set
		{
			EnsureNSWindowDelegate().willReturnFieldEditor = value;
		}
	}

	public NSWindowUndoManager? WillReturnUndoManager
	{
		get
		{
			return EnsureNSWindowDelegate().willReturnUndoManager;
		}
		set
		{
			EnsureNSWindowDelegate().willReturnUndoManager = value;
		}
	}

	public NSWindowSize? WillUseFullScreenContentSize
	{
		get
		{
			return EnsureNSWindowDelegate().willUseFullScreenContentSize;
		}
		set
		{
			EnsureNSWindowDelegate().willUseFullScreenContentSize = value;
		}
	}

	public NSWindowApplicationPresentationOptions? WillUseFullScreenPresentationOptions
	{
		get
		{
			return EnsureNSWindowDelegate().willUseFullScreenPresentationOptions;
		}
		set
		{
			EnsureNSWindowDelegate().willUseFullScreenPresentationOptions = value;
		}
	}

	public NSWindowFrame? WillUseStandardFrame
	{
		get
		{
			return EnsureNSWindowDelegate().willUseStandardFrame;
		}
		set
		{
			EnsureNSWindowDelegate().willUseStandardFrame = value;
		}
	}

	public NSObjectPredicate? WindowShouldClose
	{
		get
		{
			return EnsureNSWindowDelegate().windowShouldClose;
		}
		set
		{
			EnsureNSWindowDelegate().windowShouldClose = value;
		}
	}

	public event EventHandler DidBecomeKey
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeKey = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didBecomeKey, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeKey = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didBecomeKey, value);
		}
	}

	public event EventHandler DidBecomeMain
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeMain = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didBecomeMain, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeMain = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didBecomeMain, value);
		}
	}

	public event EventHandler DidChangeBackingProperties
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeBackingProperties = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didChangeBackingProperties, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeBackingProperties = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didChangeBackingProperties, value);
		}
	}

	public event EventHandler DidChangeScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didChangeScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didChangeScreen, value);
		}
	}

	public event EventHandler DidChangeScreenProfile
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreenProfile = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didChangeScreenProfile, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreenProfile = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didChangeScreenProfile, value);
		}
	}

	public event EventHandler<NSWindowCoderEventArgs> DidDecodeRestorableState
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDecodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Combine(nSWindowDelegate.didDecodeRestorableState, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDecodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Remove(nSWindowDelegate.didDecodeRestorableState, value);
		}
	}

	public event EventHandler DidDeminiaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDeminiaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didDeminiaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDeminiaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didDeminiaturize, value);
		}
	}

	public event EventHandler DidEndLiveResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndLiveResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEndLiveResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndLiveResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEndLiveResize, value);
		}
	}

	public event EventHandler DidEndSheet
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndSheet = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEndSheet, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndSheet = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEndSheet, value);
		}
	}

	public event EventHandler DidEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEnterFullScreen, value);
		}
	}

	public event EventHandler DidEnterVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEnterVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEnterVersionBrowser, value);
		}
	}

	public event EventHandler DidExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExitFullScreen, value);
		}
	}

	public event EventHandler DidExitVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExitVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExitVersionBrowser, value);
		}
	}

	public event EventHandler DidExpose
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExpose = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExpose, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExpose = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExpose, value);
		}
	}

	public event EventHandler DidFailToEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didFailToEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didFailToEnterFullScreen, value);
		}
	}

	public event EventHandler DidFailToExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didFailToExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didFailToExitFullScreen, value);
		}
	}

	public event EventHandler DidMiniaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMiniaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didMiniaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMiniaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didMiniaturize, value);
		}
	}

	public event EventHandler DidMove
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMove = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didMove, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMove = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didMove, value);
		}
	}

	public event EventHandler DidResignKey
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignKey = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResignKey, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignKey = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResignKey, value);
		}
	}

	public event EventHandler DidResignMain
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignMain = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResignMain, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignMain = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResignMain, value);
		}
	}

	public event EventHandler DidResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResize, value);
		}
	}

	public event EventHandler DidUpdate
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didUpdate = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didUpdate, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didUpdate = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didUpdate, value);
		}
	}

	public event EventHandler<NSWindowDurationEventArgs> StartCustomAnimationToEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToEnterFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Combine(nSWindowDelegate.startCustomAnimationToEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToEnterFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Remove(nSWindowDelegate.startCustomAnimationToEnterFullScreen, value);
		}
	}

	public event EventHandler<NSWindowDurationEventArgs> StartCustomAnimationToExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToExitFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Combine(nSWindowDelegate.startCustomAnimationToExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToExitFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Remove(nSWindowDelegate.startCustomAnimationToExitFullScreen, value);
		}
	}

	public event EventHandler WillBeginSheet
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willBeginSheet = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willBeginSheet, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willBeginSheet = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willBeginSheet, value);
		}
	}

	public event EventHandler WillClose
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willClose = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willClose, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willClose = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willClose, value);
		}
	}

	public event EventHandler<NSWindowCoderEventArgs> WillEncodeRestorableState
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEncodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Combine(nSWindowDelegate.willEncodeRestorableState, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEncodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Remove(nSWindowDelegate.willEncodeRestorableState, value);
		}
	}

	public event EventHandler WillEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willEnterFullScreen, value);
		}
	}

	public event EventHandler WillEnterVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willEnterVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willEnterVersionBrowser, value);
		}
	}

	public event EventHandler WillExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willExitFullScreen, value);
		}
	}

	public event EventHandler WillExitVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willExitVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willExitVersionBrowser, value);
		}
	}

	public event EventHandler WillMiniaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMiniaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willMiniaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMiniaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willMiniaturize, value);
		}
	}

	public event EventHandler WillMove
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMove = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willMove, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMove = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willMove, value);
		}
	}

	public event EventHandler WillStartLiveResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willStartLiveResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willStartLiveResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willStartLiveResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willStartLiveResize, value);
		}
	}

	private NSWindow(IntPtr windowRef, NSObjectFlag x)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, selInitWithWindowRef);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitWithWindowRef);
		}
		if (!DisableReleasedWhenClosedInConstructor)
		{
			ReleasedWhenClosed = false;
		}
	}

	public static NSWindow FromWindowRef(IntPtr windowRef)
	{
		return new NSWindow(windowRef, NSObjectFlag.Empty);
	}

	public void Close()
	{
		if (WindowController == null)
		{
			bool releasedWhenClosed = ReleasedWhenClosed;
			if (releasedWhenClosed)
			{
				CFObject.CFRetain(base.Handle);
			}
			_Close();
			if (releasedWhenClosed)
			{
				Dispose();
			}
		}
		else
		{
			_Close();
		}
	}

	public NSEvent NextEventMatchingMask(NSEventMask mask)
	{
		return NextEventMatchingMask((uint)mask);
	}

	public NSEvent NextEventMatchingMask(NSEventMask mask, NSDate expiration, string mode, bool deqFlag)
	{
		return NextEventMatchingMask((uint)mask, expiration, mode, deqFlag);
	}

	public void DiscardEventsMatchingMask(NSEventMask mask, NSEvent beforeLastEvent)
	{
		DiscardEventsMatchingMask((uint)mask, beforeLastEvent);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSWindow(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSWindow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWindow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindow()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
		if (!DisableReleasedWhenClosedInConstructor)
		{
			ReleasedWhenClosed = false;
		}
	}

	[Export("initWithContentRect:styleMask:backing:defer:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindow(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool(base.Handle, selInitWithContentRect_StyleMask_Backing_Defer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation), "initWithContentRect:styleMask:backing:defer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool(base.SuperHandle, selInitWithContentRect_StyleMask_Backing_Defer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation), "initWithContentRect:styleMask:backing:defer:");
		}
		if (!DisableReleasedWhenClosedInConstructor)
		{
			ReleasedWhenClosed = false;
		}
	}

	[Export("initWithContentRect:styleMask:backing:defer:screen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindow(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation, NSScreen screen)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool_IntPtr(base.Handle, selInitWithContentRect_StyleMask_Backing_Defer_Screen_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation, screen.Handle), "initWithContentRect:styleMask:backing:defer:screen:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool_IntPtr(base.SuperHandle, selInitWithContentRect_StyleMask_Backing_Defer_Screen_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation, screen.Handle), "initWithContentRect:styleMask:backing:defer:screen:");
		}
		if (!DisableReleasedWhenClosedInConstructor)
		{
			ReleasedWhenClosed = false;
		}
	}

	[Export("accessibilityPerformCancel")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformCancel()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformCancelHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformCancelHandle);
	}

	[Export("accessibilityPerformConfirm")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformConfirm()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformConfirmHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformConfirmHandle);
	}

	[Export("accessibilityPerformDecrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformDecrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformDecrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformDecrementHandle);
	}

	[Export("accessibilityPerformDelete")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformDelete()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformDeleteHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformDeleteHandle);
	}

	[Export("accessibilityPerformIncrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformIncrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformIncrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformIncrementHandle);
	}

	[Export("accessibilityPerformPick")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformPick()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPickHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPickHandle);
	}

	[Export("accessibilityPerformPress")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformPress()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPressHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPressHandle);
	}

	[Export("accessibilityPerformRaise")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformRaise()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformRaiseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformRaiseHandle);
	}

	[Export("accessibilityPerformShowAlternateUI")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowAlternateUI()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowAlternateUIHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowAlternateUIHandle);
	}

	[Export("accessibilityPerformShowDefaultUI")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowDefaultUI()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowDefaultUIHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowDefaultUIHandle);
	}

	[Export("accessibilityPerformShowMenu")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowMenu()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowMenuHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowMenuHandle);
	}

	[Export("addChildWindow:ordered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChildWindow(NSWindow childWin, NSWindowOrderingMode place)
	{
		NSApplication.EnsureUIThread();
		if (childWin == null)
		{
			throw new ArgumentNullException("childWin");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddChildWindow_Ordered_Handle, childWin.Handle, (long)place);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddChildWindow_Ordered_Handle, childWin.Handle, (long)place);
		}
	}

	[Export("addTabbedWindow:ordered:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTabbedWindow(NSWindow window, NSWindowOrderingMode ordered)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddTabbedWindow_Ordered_Handle, window.Handle, (long)ordered);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddTabbedWindow_Ordered_Handle, window.Handle, (long)ordered);
		}
	}

	[Export("addTitlebarAccessoryViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTitlebarAccessoryViewController(NSTitlebarAccessoryViewController childViewController)
	{
		NSApplication.EnsureUIThread();
		if (childViewController == null)
		{
			throw new ArgumentNullException("childViewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTitlebarAccessoryViewController_Handle, childViewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTitlebarAccessoryViewController_Handle, childViewController.Handle);
		}
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("animationResizeTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double AnimationResizeTime(CGRect newFrame)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_CGRect(base.Handle, selAnimationResizeTime_Handle, newFrame);
		}
		return Messaging.Double_objc_msgSendSuper_CGRect(base.SuperHandle, selAnimationResizeTime_Handle, newFrame);
	}

	[Export("autorecalculatesContentBorderThicknessForEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutorecalculatesContentBorderThickness(NSRectEdge forEdgeedge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selAutorecalculatesContentBorderThicknessForEdge_Handle, (ulong)forEdgeedge);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selAutorecalculatesContentBorderThicknessForEdge_Handle, (ulong)forEdgeedge);
	}

	[Export("backingAlignedRect:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BackingAlignedRect(CGRect aRect, NSAlignmentOptions options)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_Int64(out retval, base.Handle, selBackingAlignedRect_Options_Handle, aRect, (long)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_Int64(out retval, base.SuperHandle, selBackingAlignedRect_Options_Handle, aRect, (long)options);
		}
		return retval;
	}

	[Export("becomeKeyWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BecomeKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBecomeKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBecomeKeyWindowHandle);
		}
	}

	[Export("becomeMainWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BecomeMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBecomeMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBecomeMainWindowHandle);
		}
	}

	[Export("beginCriticalSheet:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginCriticalSheet(NSWindow sheetWindow, [BlockProxy(typeof(Trampolines.NIDActionArity1V13))] Action<nint> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (sheetWindow == null)
		{
			throw new ArgumentNullException("sheetWindow");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V13.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBeginCriticalSheet_CompletionHandler_Handle, sheetWindow.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBeginCriticalSheet_CompletionHandler_Handle, sheetWindow.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginSheet:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginSheet(NSWindow sheetWindow, [BlockProxy(typeof(Trampolines.NIDActionArity1V13))] Action<nint> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (sheetWindow == null)
		{
			throw new ArgumentNullException("sheetWindow");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V13.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBeginSheet_CompletionHandler_Handle, sheetWindow.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBeginSheet_CompletionHandler_Handle, sheetWindow.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("cacheImageInRect:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "This method shouldn’t be used as it doesn’t work in all drawing situations; instead, a subview should be used that implements the desired drawing behavior.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CacheImageInRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selCacheImageInRect_Handle, aRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selCacheImageInRect_Handle, aRect);
		}
	}

	[Export("canRepresentDisplayGamut:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRepresentDisplayGamut(NSDisplayGamut displayGamut)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selCanRepresentDisplayGamut_Handle, (long)displayGamut);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selCanRepresentDisplayGamut_Handle, (long)displayGamut);
	}

	[Export("cascadeTopLeftFromPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CascadeTopLeftFromPoint(CGPoint topLeftPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selCascadeTopLeftFromPoint_Handle, topLeftPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCascadeTopLeftFromPoint_Handle, topLeftPoint);
	}

	[Export("center")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Center()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCenterHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCenterHandle);
		}
	}

	[Export("constrainFrameRect:toScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConstrainFrameRect(CGRect frameRect, NSScreen? screen)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConstrainFrameRect_ToScreen_Handle, frameRect, screen?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConstrainFrameRect_ToScreen_Handle, frameRect, screen?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("contentBorderThicknessForEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ContentBorderThicknessForEdge(NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_UInt64(base.Handle, selContentBorderThicknessForEdge_Handle, (ulong)edge);
		}
		return Messaging.nfloat_objc_msgSendSuper_UInt64(base.SuperHandle, selContentBorderThicknessForEdge_Handle, (ulong)edge);
	}

	[Export("contentRectForFrameRect:styleMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect ContentRectFor(CGRect forFrameRect, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out var retval, class_ptr, selContentRectForFrameRect_StyleMask_Handle, forFrameRect, (ulong)styleMask);
		return retval;
	}

	[Export("contentRectForFrameRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ContentRectFor(CGRect frameRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selContentRectForFrameRect_Handle, frameRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selContentRectForFrameRect_Handle, frameRect);
		}
		return retval;
	}

	[Export("convertBaseToScreen:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use ConvertRectToScreen instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertBaseToScreen(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertBaseToScreen_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertBaseToScreen_Handle, aPoint);
	}

	[Export("convertPointFromBacking:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromBacking(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromBacking_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromBacking_Handle, point);
	}

	[Export("convertPointFromScreen:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromScreen(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromScreen_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromScreen_Handle, point);
	}

	[Export("convertPointToBacking:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToBacking(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToBacking_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToBacking_Handle, point);
	}

	[Export("convertPointToScreen:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToScreen(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToScreen_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToScreen_Handle, point);
	}

	[Export("convertRectFromBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromScreen(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromScreen_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromScreen_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToScreen(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToScreen_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToScreen_Handle, aRect);
		}
		return retval;
	}

	[Export("convertScreenToBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use ConvertRectFromScreen instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertScreenToBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertScreenToBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertScreenToBase_Handle, aPoint);
	}

	[Export("currentEvent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEvent CurrentEvent()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEventHandle));
		}
		return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEventHandle));
	}

	[Export("dataWithEPSInsideRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData DataWithEpsInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithEPSInsideRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithEPSInsideRect_Handle, rect));
	}

	[Export("dataWithPDFInsideRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData DataWithPdfInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithPDFInsideRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithPDFInsideRect_Handle, rect));
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	[Export("deminiaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Deminiaturize(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeminiaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeminiaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("disableCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableCursorRectsHandle);
		}
	}

	[Export("disableFlushWindow")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableFlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableFlushWindowHandle);
		}
	}

	[Export("disableKeyEquivalentForDefaultButtonCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableKeyEquivalentForDefaultButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableKeyEquivalentForDefaultButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableKeyEquivalentForDefaultButtonCellHandle);
		}
	}

	[Export("disableScreenUpdatesUntilFlush")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableScreenUpdatesUntilFlush()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableScreenUpdatesUntilFlushHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableScreenUpdatesUntilFlushHandle);
		}
	}

	[Export("disableSnapshotRestoration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableSnapshotRestoration()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableSnapshotRestorationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableSnapshotRestorationHandle);
		}
	}

	[Export("discardCachedImage")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "This method shouldn’t be used as it doesn’t work in all drawing situations; instead, a subview should be used that implements the desired drawing behavior.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardCachedImage()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardCachedImageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardCachedImageHandle);
		}
	}

	[Export("discardCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardCursorRectsHandle);
		}
	}

	[Export("discardEventsMatchingMask:beforeEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual void DiscardEventsMatchingMask(nuint mask, NSEvent beforeLastEvent)
	{
		NSApplication.EnsureUIThread();
		if (beforeLastEvent == null)
		{
			throw new ArgumentNullException("beforeLastEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_IntPtr(base.Handle, selDiscardEventsMatchingMask_BeforeEvent_Handle, mask, beforeLastEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selDiscardEventsMatchingMask_BeforeEvent_Handle, mask, beforeLastEvent.Handle);
		}
	}

	[Export("display")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Display()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	[Export("displayIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededHandle);
		}
	}

	[Export("enableCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableCursorRectsHandle);
		}
	}

	[Export("enableFlushWindow")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSAnimationContext.RunAnimation'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableFlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableFlushWindowHandle);
		}
	}

	[Export("enableKeyEquivalentForDefaultButtonCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableKeyEquivalentForDefaultButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableKeyEquivalentForDefaultButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableKeyEquivalentForDefaultButtonCellHandle);
		}
	}

	[Export("enableSnapshotRestoration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableSnapshotRestoration()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableSnapshotRestorationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableSnapshotRestorationHandle);
		}
	}

	[Export("endEditingFor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndEditingFor(NSObject? anObject)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndEditingFor_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndEditingFor_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("endSheet:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSheet(NSWindow sheetWindow)
	{
		NSApplication.EnsureUIThread();
		if (sheetWindow == null)
		{
			throw new ArgumentNullException("sheetWindow");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndSheet_Handle, sheetWindow.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndSheet_Handle, sheetWindow.Handle);
		}
	}

	[Export("endSheet:returnCode:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSheet(NSWindow sheetWindow, NSModalResponse returnCode)
	{
		NSApplication.EnsureUIThread();
		if (sheetWindow == null)
		{
			throw new ArgumentNullException("sheetWindow");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selEndSheet_ReturnCode_Handle, sheetWindow.Handle, (long)returnCode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selEndSheet_ReturnCode_Handle, sheetWindow.Handle, (long)returnCode);
		}
	}

	[Obsolete("Use the EndSheet(NSWindow,NSModalResponse) overload.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSheet(NSWindow sheetWindow, nint returnCode)
	{
		EndSheet(sheetWindow, (NSModalResponse)(long)returnCode);
	}

	[Export("fieldEditor:forObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSText FieldEditor(bool createFlag, NSObject? forObject)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSText>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(base.Handle, selFieldEditor_ForObject_Handle, createFlag, forObject?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSText>(Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selFieldEditor_ForObject_Handle, createFlag, forObject?.Handle ?? IntPtr.Zero));
	}

	[Export("flushWindow")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushWindowHandle);
		}
	}

	[Export("flushWindowIfNeeded")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushWindowIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushWindowIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushWindowIfNeededHandle);
		}
	}

	[Export("frameRectForContentRect:styleMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect FrameRectFor(CGRect contectRect, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out var retval, class_ptr, selFrameRectForContentRect_StyleMask_Handle, contectRect, (ulong)styleMask);
		return retval;
	}

	[Export("frameRectForContentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect FrameRectFor(CGRect contentRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selFrameRectForContentRect_Handle, contentRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selFrameRectForContentRect_Handle, contentRect);
		}
		return retval;
	}

	[Export("gState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selGStateHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selGStateHandle);
	}

	[Export("accessibilityAttributedStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityAttributedStringForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityAttributedStringForRange_Handle, range));
	}

	[Export("accessibilityCellForColumn:row:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetAccessibilityCellForColumn(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selAccessibilityCellForColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selAccessibilityCellForColumn_Row_Handle, column, row));
	}

	[Export("accessibilityFrameForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetAccessibilityFrame(NSRange range)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange(out retval, base.Handle, selAccessibilityFrameForRange_Handle, range);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange(out retval, base.SuperHandle, selAccessibilityFrameForRange_Handle, range);
		}
		return retval;
	}

	[Export("accessibilityLayoutPointForScreenPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetAccessibilityLayoutForScreen(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selAccessibilityLayoutPointForScreenPoint_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityLayoutPointForScreenPoint_Handle, point);
	}

	[Export("accessibilityLayoutSizeForScreenSize:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetAccessibilityLayoutForScreen(CGSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selAccessibilityLayoutSizeForScreenSize_Handle, size);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selAccessibilityLayoutSizeForScreenSize_Handle, size);
	}

	[Export("accessibilityLineForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selAccessibilityLineForIndex_Handle, index);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityLineForIndex_Handle, index);
	}

	[Export("accessibilityRangeForPosition:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRange(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGPoint(base.Handle, selAccessibilityRangeForPosition_Handle, point);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityRangeForPosition_Handle, point);
	}

	[Export("accessibilityRangeForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRange(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForIndex_Handle, index);
	}

	[Export("accessibilityRangeForLine:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRangeForLine(nint line)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForLine_Handle, line);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForLine_Handle, line);
	}

	[Export("accessibilityRTFForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetAccessibilityRtf(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityRTFForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityRTFForRange_Handle, range));
	}

	[Export("accessibilityScreenPointForLayoutPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetAccessibilityScreenForLayout(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selAccessibilityScreenPointForLayoutPoint_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityScreenPointForLayoutPoint_Handle, point);
	}

	[Export("accessibilityScreenSizeForLayoutSize:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetAccessibilityScreenForLayout(CGSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selAccessibilityScreenSizeForLayoutSize_Handle, size);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selAccessibilityScreenSizeForLayoutSize_Handle, size);
	}

	[Export("accessibilityStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityStringForRange_Handle, range));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityStringForRange_Handle, range));
	}

	[Export("accessibilityStyleRangeForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityStyleRange(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityStyleRangeForIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityStyleRangeForIndex_Handle, index);
	}

	[Export("frameAutosaveName")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual string GetFrameAutosaveName()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameAutosaveNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameAutosaveNameHandle));
	}

	[Export("windowWithContentViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow GetWindowWithContentViewController(NSViewController contentViewController)
	{
		NSApplication.EnsureUIThread();
		if (contentViewController == null)
		{
			throw new ArgumentNullException("contentViewController");
		}
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selWindowWithContentViewController_Handle, contentViewController.Handle));
	}

	[Export("insertTitlebarAccessoryViewController:atIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertTitlebarAccessoryViewController(NSTitlebarAccessoryViewController childViewController, nint index)
	{
		NSApplication.EnsureUIThread();
		if (childViewController == null)
		{
			throw new ArgumentNullException("childViewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertTitlebarAccessoryViewController_AtIndex_Handle, childViewController.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertTitlebarAccessoryViewController_AtIndex_Handle, childViewController.Handle, index);
		}
	}

	[Export("invalidateCursorRectsForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateCursorRectsForView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateCursorRectsForView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateCursorRectsForView_Handle, aView.Handle);
		}
	}

	[Export("invalidateShadow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateShadow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateShadowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateShadowHandle);
		}
	}

	[Export("isAccessibilitySelectorAllowed:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAccessibilitySelectorAllowed(Selector selector)
	{
		NSApplication.EnsureUIThread();
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAccessibilitySelectorAllowed_Handle, selector.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAccessibilitySelectorAllowed_Handle, selector.Handle);
	}

	[Export("keyDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void KeyDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, theEvent.Handle);
		}
	}

	[Export("keyViewSelectionDirection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSelectionDirection KeyViewSelectionDirection()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSSelectionDirection)Messaging.UInt64_objc_msgSend(base.Handle, selKeyViewSelectionDirectionHandle);
		}
		return (NSSelectionDirection)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyViewSelectionDirectionHandle);
	}

	[Export("layoutIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutIfNeededHandle);
		}
	}

	[Export("makeFirstResponder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MakeFirstResponder(NSResponder? aResponder)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selMakeFirstResponder_Handle, aResponder?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeFirstResponder_Handle, aResponder?.Handle ?? IntPtr.Zero);
	}

	[Export("makeKeyAndOrderFront:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeKeyAndOrderFront(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeKeyAndOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeKeyAndOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("makeKeyWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeKeyWindowHandle);
		}
	}

	[Export("makeMainWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeMainWindowHandle);
		}
	}

	[Export("menuChanged:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "This method does not do anything and should not be called.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MenuChanged(NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selMenuChanged_Handle, menu.Handle);
	}

	[Export("mergeAllWindows:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MergeAllWindows(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMergeAllWindows_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMergeAllWindows_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("minFrameWidthWithTitle:styleMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat MinFrameWidthWithTitle(string aTitle, NSWindowStyle aStyle)
	{
		NSApplication.EnsureUIThread();
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		nfloat result = Messaging.nfloat_objc_msgSend_IntPtr_UInt64(class_ptr, selMinFrameWidthWithTitle_StyleMask_Handle, arg, (ulong)aStyle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("miniaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Miniaturize(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMiniaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMiniaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("moveTabToNewWindow:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveTabToNewWindow(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveTabToNewWindow_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveTabToNewWindow_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("nextEventMatchingMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSEvent NextEventMatchingMask(nuint mask)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selNextEventMatchingMask_Handle, mask));
		}
		return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selNextEventMatchingMask_Handle, mask));
	}

	[Export("nextEventMatchingMask:untilDate:inMode:dequeue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSEvent NextEventMatchingMask(nuint mask, NSDate expiration, string mode, bool deqFlag)
	{
		NSApplication.EnsureUIThread();
		if (expiration == null)
		{
			throw new ArgumentNullException("expiration");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		NSEvent result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr_IntPtr_bool(base.SuperHandle, selNextEventMatchingMask_UntilDate_InMode_Dequeue_Handle, mask, expiration.Handle, arg, deqFlag)) : Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr_IntPtr_bool(base.Handle, selNextEventMatchingMask_UntilDate_InMode_Dequeue_Handle, mask, expiration.Handle, arg, deqFlag)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("orderBack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderBack(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderBack_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderBack_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderFront:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFront(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderFrontRegardless")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontRegardless()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selOrderFrontRegardlessHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selOrderFrontRegardlessHandle);
		}
	}

	[Export("orderOut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderOut(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderOut_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderOut_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderWindow:relativeTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderWindow(NSWindowOrderingMode place, nint relativeTo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_nint(base.Handle, selOrderWindow_RelativeTo_Handle, (long)place, relativeTo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_nint(base.SuperHandle, selOrderWindow_RelativeTo_Handle, (long)place, relativeTo);
		}
	}

	[Export("performClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformClose(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClose_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClose_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("performMiniaturize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformMiniaturize(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformMiniaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformMiniaturize_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("performWindowDragWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformWindowDrag(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformWindowDragWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformWindowDragWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("performZoom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformZoom(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformZoom_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformZoom_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("postEvent:atStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostEvent(NSEvent theEvent, bool atStart)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selPostEvent_AtStart_Handle, theEvent.Handle, atStart);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selPostEvent_AtStart_Handle, theEvent.Handle, atStart);
		}
	}

	[Export("print:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Print(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrint_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrint_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("recalculateKeyViewLoop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RecalculateKeyViewLoop()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRecalculateKeyViewLoopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRecalculateKeyViewLoopHandle);
		}
	}

	[Export("registerForDraggedTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterForDraggedTypes(string[] newTypes)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeChildWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveChildWindow(NSWindow childWin)
	{
		NSApplication.EnsureUIThread();
		if (childWin == null)
		{
			throw new ArgumentNullException("childWin");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveChildWindow_Handle, childWin.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChildWindow_Handle, childWin.Handle);
		}
	}

	[Export("removeFrameUsingName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveFrameUsingName_Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("removeTitlebarAccessoryViewControllerAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTitlebarAccessoryViewControllerAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveTitlebarAccessoryViewControllerAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveTitlebarAccessoryViewControllerAtIndex_Handle, index);
		}
	}

	[Export("resetCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCursorRectsHandle);
		}
	}

	[Export("resignKeyWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResignKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResignKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResignKeyWindowHandle);
		}
	}

	[Export("resignMainWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResignMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResignMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResignMainWindowHandle);
		}
	}

	[Export("restoreCachedImage")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "This method shouldn’t be used as it doesn’t work in all drawing situations; instead, a subview should be used that implements the desired drawing behavior.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreCachedImage()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRestoreCachedImageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRestoreCachedImageHandle);
		}
	}

	[Export("runToolbarCustomizationPalette:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunToolbarCustomizationPalette(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunToolbarCustomizationPalette_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunToolbarCustomizationPalette_Handle, sender.Handle);
		}
	}

	[Export("saveFrameUsingName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveFrameUsingName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveFrameUsingName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("selectKeyViewFollowingView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectKeyViewFollowingView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectKeyViewFollowingView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectKeyViewFollowingView_Handle, aView.Handle);
		}
	}

	[Export("selectKeyViewPrecedingView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectKeyViewPrecedingView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectKeyViewPrecedingView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectKeyViewPrecedingView_Handle, aView.Handle);
		}
	}

	[Export("selectNextKeyView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNextKeyView(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNextKeyView_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNextKeyView_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectNextTab:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNextTab(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNextTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNextTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectPreviousKeyView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectPreviousKeyView(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPreviousKeyView_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPreviousKeyView_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectPreviousTab:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectPreviousTab(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPreviousTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPreviousTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("sendEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSendEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendEvent_Handle, theEvent.Handle);
		}
	}

	[Export("setAnchorAttribute:forOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAnchorAttribute(NSLayoutAttribute layoutAttribute, NSLayoutConstraintOrientation forOrientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSetAnchorAttribute_ForOrientation_Handle, (long)layoutAttribute, (long)forOrientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSetAnchorAttribute_ForOrientation_Handle, (long)layoutAttribute, (long)forOrientation);
		}
	}

	[Export("setAutorecalculatesContentBorderThickness:forEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAutorecalculatesContentBorderThickness(bool flag, NSRectEdge forEdge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_UInt64(base.Handle, selSetAutorecalculatesContentBorderThickness_ForEdge_Handle, flag, (ulong)forEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_UInt64(base.SuperHandle, selSetAutorecalculatesContentBorderThickness_ForEdge_Handle, flag, (ulong)forEdge);
		}
	}

	[Export("setContentBorderThickness:forEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContentBorderThickness(nfloat thickness, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_UInt64(base.Handle, selSetContentBorderThickness_ForEdge_Handle, thickness, (ulong)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_UInt64(base.SuperHandle, selSetContentBorderThickness_ForEdge_Handle, thickness, (ulong)edge);
		}
	}

	[Export("setContentSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContentSize(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentSize_Handle, aSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentSize_Handle, aSize);
		}
	}

	[Export("setExcludedFromWindowsMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetExcludedFromWindowsMenu(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetExcludedFromWindowsMenu_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExcludedFromWindowsMenu_Handle, flag);
		}
	}

	[Export("setFrame:display:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrame(CGRect frameRect, bool display)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selSetFrame_Display_Handle, frameRect, display);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selSetFrame_Display_Handle, frameRect, display);
		}
	}

	[Export("setFrame:display:animate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrame(CGRect frameRect, bool display, bool animate)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool_bool(base.Handle, selSetFrame_Display_Animate_Handle, frameRect, display, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool_bool(base.SuperHandle, selSetFrame_Display_Animate_Handle, frameRect, display, animate);
		}
	}

	[Export("setFrameAutosaveName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetFrameAutosaveName(string frameName)
	{
		NSApplication.EnsureUIThread();
		if (frameName == null)
		{
			throw new ArgumentNullException("frameName");
		}
		IntPtr arg = NSString.CreateNative(frameName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameAutosaveName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetFrameAutosaveName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setFrameFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrameFrom(string str)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameFromString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameFromString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setFrameOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrameOrigin(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameOrigin_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameOrigin_Handle, aPoint);
		}
	}

	[Export("setFrameTopLeftPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrameTopLeftPoint(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameTopLeftPoint_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameTopLeftPoint_Handle, aPoint);
		}
	}

	[Export("setFrameUsingName:force:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetFrameUsingName(string name, bool force)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetFrameUsingName_Force_Handle, arg, force) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selSetFrameUsingName_Force_Handle, arg, force));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setFrameUsingName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameUsingName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetFrameUsingName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setOneShot:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOneShot(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOneShot_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOneShot_Handle, flag);
		}
	}

	[Export("setTitleWithRepresentedFilename:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitleWithRepresentedFilename(string filename)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithRepresentedFilename_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithRepresentedFilename_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("standardWindowButton:forStyleMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSButton StandardWindowButton(NSWindowButton b, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64(class_ptr, selStandardWindowButton_ForStyleMask_Handle, (ulong)b, (ulong)styleMask));
	}

	[Export("standardWindowButton:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButton StandardWindowButton(NSWindowButton b)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selStandardWindowButton_Handle, (ulong)b));
		}
		return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selStandardWindowButton_Handle, (ulong)b));
	}

	[Export("stringWithSavedFrame")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringWithSavedFrame()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringWithSavedFrameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringWithSavedFrameHandle));
	}

	[Export("toggleFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleFullScreen(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleFullScreen_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleFullScreen_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("toggleTabBar:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleTabBar(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleTabBar_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleTabBar_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("toggleTabOverview:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleTabOverview(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleTabOverview_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleTabOverview_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("toggleToolbarShown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleToolbarShown(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleToolbarShown_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleToolbarShown_Handle, sender.Handle);
		}
	}

	[Export("trackEventsMatchingMask:timeout:mode:handler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void TrackEventsMatching(NSEventMask mask, double timeout, string mode, [BlockProxy(typeof(Trampolines.NIDNSWindowTrackEventsMatchingCompletionHandler))] NSWindowTrackEventsMatchingCompletionHandler trackingHandler)
	{
		NSApplication.EnsureUIThread();
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (trackingHandler == null)
		{
			throw new ArgumentNullException("trackingHandler");
		}
		IntPtr arg = NSString.CreateNative(mode);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSWindowTrackEventsMatchingCompletionHandler.Handler, trackingHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Double_IntPtr_IntPtr(base.Handle, selTrackEventsMatchingMask_Timeout_Mode_Handler_Handle, (ulong)mask, timeout, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Double_IntPtr_IntPtr(base.SuperHandle, selTrackEventsMatchingMask_Timeout_Mode_Handler_Handle, (ulong)mask, timeout, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("tryToPerform:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TryToPerform(Selector anAction, NSObject anObject)
	{
		NSApplication.EnsureUIThread();
		if (anAction == null)
		{
			throw new ArgumentNullException("anAction");
		}
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTryToPerform_With_Handle, anAction.Handle, anObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTryToPerform_With_Handle, anAction.Handle, anObject.Handle);
	}

	[Export("unregisterDraggedTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterDraggedTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnregisterDraggedTypesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnregisterDraggedTypesHandle);
		}
	}

	[Export("update")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}

	[Export("updateConstraintsIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateConstraintsIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsIfNeededHandle);
		}
	}

	[Export("useOptimizedDrawing:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UseOptimizedDrawing(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selUseOptimizedDrawing_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selUseOptimizedDrawing_Handle, flag);
		}
	}

	[Export("validRequestorForSendType:returnType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject ValidRequestorForSendType(string sendType, string returnType)
	{
		NSApplication.EnsureUIThread();
		if (sendType == null)
		{
			throw new ArgumentNullException("sendType");
		}
		if (returnType == null)
		{
			throw new ArgumentNullException("returnType");
		}
		IntPtr arg = NSString.CreateNative(sendType);
		IntPtr arg2 = NSString.CreateNative(returnType);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("validateMenuItem:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateMenuItem_Handle, menuItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateMenuItem_Handle, menuItem.Handle);
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
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

	[Export("visualizeConstraints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void VisualizeConstraints(NSLayoutConstraint[]? constraints)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((constraints == null) ? null : NSArray.FromNSObjects(constraints));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selVisualizeConstraints_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selVisualizeConstraints_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		nSArray?.Dispose();
	}

	[Export("windowNumberAtPoint:belowWindowWithWindowNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint WindowNumberAtPoint(CGPoint point, nint windowNumber)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend_CGPoint_nint(class_ptr, selWindowNumberAtPoint_BelowWindowWithWindowNumber_Handle, point, windowNumber);
	}

	[Export("windowNumbersWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray WindowNumbersWithOptions(NSWindowNumberListOptions options)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selWindowNumbersWithOptions_Handle, (ulong)options));
	}

	[Export("worksWhenModal")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WorksWhenModal()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selWorksWhenModalHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWorksWhenModalHandle);
	}

	[Export("zoom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Zoom(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoom_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoom_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _Close()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	internal virtual _NSWindowDelegate CreateInternalEventDelegateType()
	{
		return new _NSWindowDelegate();
	}

	internal _NSWindowDelegate EnsureNSWindowDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSWindowDelegate nSWindowDelegate = Delegate as _NSWindowDelegate;
		if (nSWindowDelegate == null)
		{
			nSWindowDelegate = (_NSWindowDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSWindowDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AccessibilityDisclosedByRow_var = null;
			__mt_AccessibilityExtrasMenuBar_var = null;
			__mt_AccessibilityMenuBar_var = null;
			__mt_AccessibilityParent_var = null;
			__mt_AccessibilityTitleUIElement_var = null;
			__mt_AccessibilityTopLevelUIElement_var = null;
			__mt_AccessibilityWindow_var = null;
			__mt_AppearanceSource_var = null;
			__mt_TabGroup_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
