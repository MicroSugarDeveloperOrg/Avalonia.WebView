using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFView", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfView : NSView, INSAnimationDelegate, INativeObject, IDisposable, INSMenuDelegate
{
	[Register]
	internal class _PdfViewDelegate : NSObject, IPdfViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<PdfViewActionEventArgs>? openPdf;

		internal EventHandler? performFind;

		internal EventHandler? performGoToPage;

		internal EventHandler? performPrint;

		internal PdfViewTitle? titleOfPrintJob;

		internal PdfViewScale? willChangeScaleFactor;

		internal EventHandler<PdfViewUrlEventArgs>? willClickOnLink;

		public _PdfViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewOpenPDF:forRemoteGoToAction:")]
		public void OpenPdf(PdfView sender, PdfActionRemoteGoTo action)
		{
			EventHandler<PdfViewActionEventArgs> eventHandler = openPdf;
			if (eventHandler != null)
			{
				PdfViewActionEventArgs e = new PdfViewActionEventArgs(action);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewPerformFind:")]
		public void PerformFind(PdfView sender)
		{
			performFind?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewPerformGoToPage:")]
		public void PerformGoToPage(PdfView sender)
		{
			performGoToPage?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewPerformPrint:")]
		public void PerformPrint(PdfView sender)
		{
			performPrint?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewPrintJobTitle:")]
		public string TitleOfPrintJob(PdfView sender)
		{
			PdfViewTitle pdfViewTitle = titleOfPrintJob;
			if (pdfViewTitle != null)
			{
				return pdfViewTitle(sender);
			}
			return string.Empty;
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewWillChangeScaleFactor:toScale:")]
		public nfloat WillChangeScaleFactor(PdfView sender, nfloat scale)
		{
			return willChangeScaleFactor?.Invoke(sender, scale) ?? scale;
		}

		[Preserve(Conditional = true)]
		[Export("PDFViewWillClickOnLink:withURL:")]
		public void WillClickOnLink(PdfView sender, NSUrl url)
		{
			EventHandler<PdfViewUrlEventArgs> eventHandler = willClickOnLink;
			if (eventHandler != null)
			{
				PdfViewUrlEventArgs e = new PdfViewUrlEventArgs(url);
				eventHandler(sender, e);
			}
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveAnnotationHit(EventHandler<PdfViewAnnotationHitEventArgs> handler)
		{
			EventHandler<PdfViewAnnotationHitEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationHitNotification, delegate(NSNotification notification)
			{
				handler2(null, new PdfViewAnnotationHitEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnotationHit(NSObject objectToObserve, EventHandler<PdfViewAnnotationHitEventArgs> handler)
		{
			EventHandler<PdfViewAnnotationHitEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationHitNotification, delegate(NSNotification notification)
			{
				handler2(null, new PdfViewAnnotationHitEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveAnnotationWillHit(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationWillHitNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnotationWillHit(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationWillHitNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveChangedHistory(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedHistoryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChangedHistory(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedHistoryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveCopyPermission(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CopyPermissionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCopyPermission(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CopyPermissionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDisplayBoxChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayBoxChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDisplayBoxChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayBoxChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDisplayModeChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayModeChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDisplayModeChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayModeChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDocumentChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DocumentChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDocumentChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DocumentChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObservePageChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PageChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePageChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PageChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObservePrintPermission(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PrintPermissionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePrintPermission(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PrintPermissionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveScaleChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ScaleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScaleChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ScaleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveVisiblePagesChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(VisiblePagesChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveVisiblePagesChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(VisiblePagesChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsDraggedFiles = "acceptsDraggedFiles";

	private static readonly IntPtr selAcceptsDraggedFilesHandle = Selector.GetHandle("acceptsDraggedFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDragging = "allowsDragging";

	private static readonly IntPtr selAllowsDraggingHandle = Selector.GetHandle("allowsDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimation_DidReachProgressMark_ = "animation:didReachProgressMark:";

	private static readonly IntPtr selAnimation_DidReachProgressMark_Handle = Selector.GetHandle("animation:didReachProgressMark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimation_ValueForProgress_ = "animation:valueForProgress:";

	private static readonly IntPtr selAnimation_ValueForProgress_Handle = Selector.GetHandle("animation:valueForProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidEnd_ = "animationDidEnd:";

	private static readonly IntPtr selAnimationDidEnd_Handle = Selector.GetHandle("animationDidEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidStop_ = "animationDidStop:";

	private static readonly IntPtr selAnimationDidStop_Handle = Selector.GetHandle("animationDidStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationShouldStart_ = "animationShouldStart:";

	private static readonly IntPtr selAnimationShouldStart_Handle = Selector.GetHandle("animationShouldStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotationsChangedOnPage_ = "annotationsChangedOnPage:";

	private static readonly IntPtr selAnnotationsChangedOnPage_Handle = Selector.GetHandle("annotationsChangedOnPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreaOfInterestForMouse_ = "areaOfInterestForMouse:";

	private static readonly IntPtr selAreaOfInterestForMouse_Handle = Selector.GetHandle("areaOfInterestForMouse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreaOfInterestForPoint_ = "areaOfInterestForPoint:";

	private static readonly IntPtr selAreaOfInterestForPoint_Handle = Selector.GetHandle("areaOfInterestForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoScales = "autoScales";

	private static readonly IntPtr selAutoScalesHandle = Selector.GetHandle("autoScales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoBack = "canGoBack";

	private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle("canGoBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoForward = "canGoForward";

	private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle("canGoForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoToFirstPage = "canGoToFirstPage";

	private static readonly IntPtr selCanGoToFirstPageHandle = Selector.GetHandle("canGoToFirstPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoToLastPage = "canGoToLastPage";

	private static readonly IntPtr selCanGoToLastPageHandle = Selector.GetHandle("canGoToLastPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoToNextPage = "canGoToNextPage";

	private static readonly IntPtr selCanGoToNextPageHandle = Selector.GetHandle("canGoToNextPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoToPreviousPage = "canGoToPreviousPage";

	private static readonly IntPtr selCanGoToPreviousPageHandle = Selector.GetHandle("canGoToPreviousPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanZoomIn = "canZoomIn";

	private static readonly IntPtr selCanZoomInHandle = Selector.GetHandle("canZoomIn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanZoomOut = "canZoomOut";

	private static readonly IntPtr selCanZoomOutHandle = Selector.GetHandle("canZoomOut");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearSelection = "clearSelection";

	private static readonly IntPtr selClearSelectionHandle = Selector.GetHandle("clearSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfinementRectForMenu_OnScreen_ = "confinementRectForMenu:onScreen:";

	private static readonly IntPtr selConfinementRectForMenu_OnScreen_Handle = Selector.GetHandle("confinementRectForMenu:onScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_FromPage_ = "convertPoint:fromPage:";

	private static readonly IntPtr selConvertPoint_FromPage_Handle = Selector.GetHandle("convertPoint:fromPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToPage_ = "convertPoint:toPage:";

	private static readonly IntPtr selConvertPoint_ToPage_Handle = Selector.GetHandle("convertPoint:toPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_FromPage_ = "convertRect:fromPage:";

	private static readonly IntPtr selConvertRect_FromPage_Handle = Selector.GetHandle("convertRect:fromPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_ToPage_ = "convertRect:toPage:";

	private static readonly IntPtr selConvertRect_ToPage_Handle = Selector.GetHandle("convertRect:toPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopy_ = "copy:";

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDestination = "currentDestination";

	private static readonly IntPtr selCurrentDestinationHandle = Selector.GetHandle("currentDestination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPage = "currentPage";

	private static readonly IntPtr selCurrentPageHandle = Selector.GetHandle("currentPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSelection = "currentSelection";

	private static readonly IntPtr selCurrentSelectionHandle = Selector.GetHandle("currentSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayBox = "displayBox";

	private static readonly IntPtr selDisplayBoxHandle = Selector.GetHandle("displayBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayDirection = "displayDirection";

	private static readonly IntPtr selDisplayDirectionHandle = Selector.GetHandle("displayDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayMode = "displayMode";

	private static readonly IntPtr selDisplayModeHandle = Selector.GetHandle("displayMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysAsBook = "displaysAsBook";

	private static readonly IntPtr selDisplaysAsBookHandle = Selector.GetHandle("displaysAsBook");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysPageBreaks = "displaysPageBreaks";

	private static readonly IntPtr selDisplaysPageBreaksHandle = Selector.GetHandle("displaysPageBreaks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysRTL = "displaysRTL";

	private static readonly IntPtr selDisplaysRTLHandle = Selector.GetHandle("displaysRTL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocument = "document";

	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentView = "documentView";

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPage_ = "drawPage:";

	private static readonly IntPtr selDrawPage_Handle = Selector.GetHandle("drawPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPage_ToContext_ = "drawPage:toContext:";

	private static readonly IntPtr selDrawPage_ToContext_Handle = Selector.GetHandle("drawPage:toContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPagePost_ = "drawPagePost:";

	private static readonly IntPtr selDrawPagePost_Handle = Selector.GetHandle("drawPagePost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPagePost_ToContext_ = "drawPagePost:toContext:";

	private static readonly IntPtr selDrawPagePost_ToContext_Handle = Selector.GetHandle("drawPagePost:toContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableDataDetectors = "enableDataDetectors";

	private static readonly IntPtr selEnableDataDetectorsHandle = Selector.GetHandle("enableDataDetectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnablePageShadows_ = "enablePageShadows:";

	private static readonly IntPtr selEnablePageShadows_Handle = Selector.GetHandle("enablePageShadows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoBack_ = "goBack:";

	private static readonly IntPtr selGoBack_Handle = Selector.GetHandle("goBack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoForward_ = "goForward:";

	private static readonly IntPtr selGoForward_Handle = Selector.GetHandle("goForward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToDestination_ = "goToDestination:";

	private static readonly IntPtr selGoToDestination_Handle = Selector.GetHandle("goToDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToFirstPage_ = "goToFirstPage:";

	private static readonly IntPtr selGoToFirstPage_Handle = Selector.GetHandle("goToFirstPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToLastPage_ = "goToLastPage:";

	private static readonly IntPtr selGoToLastPage_Handle = Selector.GetHandle("goToLastPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToNextPage_ = "goToNextPage:";

	private static readonly IntPtr selGoToNextPage_Handle = Selector.GetHandle("goToNextPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToPage_ = "goToPage:";

	private static readonly IntPtr selGoToPage_Handle = Selector.GetHandle("goToPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToPreviousPage_ = "goToPreviousPage:";

	private static readonly IntPtr selGoToPreviousPage_Handle = Selector.GetHandle("goToPreviousPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToRect_OnPage_ = "goToRect:onPage:";

	private static readonly IntPtr selGoToRect_OnPage_Handle = Selector.GetHandle("goToRect:onPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToSelection_ = "goToSelection:";

	private static readonly IntPtr selGoToSelection_Handle = Selector.GetHandle("goToSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreekingThreshold = "greekingThreshold";

	private static readonly IntPtr selGreekingThresholdHandle = Selector.GetHandle("greekingThreshold");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightedSelections = "highlightedSelections";

	private static readonly IntPtr selHighlightedSelectionsHandle = Selector.GetHandle("highlightedSelections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpolationQuality = "interpolationQuality";

	private static readonly IntPtr selInterpolationQualityHandle = Selector.GetHandle("interpolationQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutDocumentView = "layoutDocumentView";

	private static readonly IntPtr selLayoutDocumentViewHandle = Selector.GetHandle("layoutDocumentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxScaleFactor = "maxScaleFactor";

	private static readonly IntPtr selMaxScaleFactorHandle = Selector.GetHandle("maxScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu_UpdateItem_AtIndex_ShouldCancel_ = "menu:updateItem:atIndex:shouldCancel:";

	private static readonly IntPtr selMenu_UpdateItem_AtIndex_ShouldCancel_Handle = Selector.GetHandle("menu:updateItem:atIndex:shouldCancel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu_WillHighlightItem_ = "menu:willHighlightItem:";

	private static readonly IntPtr selMenu_WillHighlightItem_Handle = Selector.GetHandle("menu:willHighlightItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuDidClose_ = "menuDidClose:";

	private static readonly IntPtr selMenuDidClose_Handle = Selector.GetHandle("menuDidClose:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuHasKeyEquivalent_ForEvent_Target_Action_ = "menuHasKeyEquivalent:forEvent:target:action:";

	private static readonly IntPtr selMenuHasKeyEquivalent_ForEvent_Target_Action_Handle = Selector.GetHandle("menuHasKeyEquivalent:forEvent:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuNeedsUpdate_ = "menuNeedsUpdate:";

	private static readonly IntPtr selMenuNeedsUpdate_Handle = Selector.GetHandle("menuNeedsUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuWillOpen_ = "menuWillOpen:";

	private static readonly IntPtr selMenuWillOpen_Handle = Selector.GetHandle("menuWillOpen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinScaleFactor = "minScaleFactor";

	private static readonly IntPtr selMinScaleFactorHandle = Selector.GetHandle("minScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItemsInMenu_ = "numberOfItemsInMenu:";

	private static readonly IntPtr selNumberOfItemsInMenu_Handle = Selector.GetHandle("numberOfItemsInMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageBreakMargins = "pageBreakMargins";

	private static readonly IntPtr selPageBreakMarginsHandle = Selector.GetHandle("pageBreakMargins");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageForPoint_Nearest_ = "pageForPoint:nearest:";

	private static readonly IntPtr selPageForPoint_Nearest_Handle = Selector.GetHandle("pageForPoint:nearest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageShadowsEnabled = "pageShadowsEnabled";

	private static readonly IntPtr selPageShadowsEnabledHandle = Selector.GetHandle("pageShadowsEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformAction_ = "performAction:";

	private static readonly IntPtr selPerformAction_Handle = Selector.GetHandle("performAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintWithInfo_AutoRotate_ = "printWithInfo:autoRotate:";

	private static readonly IntPtr selPrintWithInfo_AutoRotate_Handle = Selector.GetHandle("printWithInfo:autoRotate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintWithInfo_AutoRotate_PageScaling_ = "printWithInfo:autoRotate:pageScaling:";

	private static readonly IntPtr selPrintWithInfo_AutoRotate_PageScaling_Handle = Selector.GetHandle("printWithInfo:autoRotate:pageScaling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowSizeForPage_ = "rowSizeForPage:";

	private static readonly IntPtr selRowSizeForPage_Handle = Selector.GetHandle("rowSizeForPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactor = "scaleFactor";

	private static readonly IntPtr selScaleFactorHandle = Selector.GetHandle("scaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactorForSizeToFit = "scaleFactorForSizeToFit";

	private static readonly IntPtr selScaleFactorForSizeToFitHandle = Selector.GetHandle("scaleFactorForSizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollSelectionToVisible_ = "scrollSelectionToVisible:";

	private static readonly IntPtr selScrollSelectionToVisible_Handle = Selector.GetHandle("scrollSelectionToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptsDraggedFiles_ = "setAcceptsDraggedFiles:";

	private static readonly IntPtr selSetAcceptsDraggedFiles_Handle = Selector.GetHandle("setAcceptsDraggedFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsDragging_ = "setAllowsDragging:";

	private static readonly IntPtr selSetAllowsDragging_Handle = Selector.GetHandle("setAllowsDragging:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoScales_ = "setAutoScales:";

	private static readonly IntPtr selSetAutoScales_Handle = Selector.GetHandle("setAutoScales:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentSelection_ = "setCurrentSelection:";

	private static readonly IntPtr selSetCurrentSelection_Handle = Selector.GetHandle("setCurrentSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentSelection_Animate_ = "setCurrentSelection:animate:";

	private static readonly IntPtr selSetCurrentSelection_Animate_Handle = Selector.GetHandle("setCurrentSelection:animate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCursorForAreaOfInterest_ = "setCursorForAreaOfInterest:";

	private static readonly IntPtr selSetCursorForAreaOfInterest_Handle = Selector.GetHandle("setCursorForAreaOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayBox_ = "setDisplayBox:";

	private static readonly IntPtr selSetDisplayBox_Handle = Selector.GetHandle("setDisplayBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayDirection_ = "setDisplayDirection:";

	private static readonly IntPtr selSetDisplayDirection_Handle = Selector.GetHandle("setDisplayDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayMode_ = "setDisplayMode:";

	private static readonly IntPtr selSetDisplayMode_Handle = Selector.GetHandle("setDisplayMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysAsBook_ = "setDisplaysAsBook:";

	private static readonly IntPtr selSetDisplaysAsBook_Handle = Selector.GetHandle("setDisplaysAsBook:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysPageBreaks_ = "setDisplaysPageBreaks:";

	private static readonly IntPtr selSetDisplaysPageBreaks_Handle = Selector.GetHandle("setDisplaysPageBreaks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysRTL_ = "setDisplaysRTL:";

	private static readonly IntPtr selSetDisplaysRTL_Handle = Selector.GetHandle("setDisplaysRTL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocument_ = "setDocument:";

	private static readonly IntPtr selSetDocument_Handle = Selector.GetHandle("setDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnableDataDetectors_ = "setEnableDataDetectors:";

	private static readonly IntPtr selSetEnableDataDetectors_Handle = Selector.GetHandle("setEnableDataDetectors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGreekingThreshold_ = "setGreekingThreshold:";

	private static readonly IntPtr selSetGreekingThreshold_Handle = Selector.GetHandle("setGreekingThreshold:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlightedSelections_ = "setHighlightedSelections:";

	private static readonly IntPtr selSetHighlightedSelections_Handle = Selector.GetHandle("setHighlightedSelections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterpolationQuality_ = "setInterpolationQuality:";

	private static readonly IntPtr selSetInterpolationQuality_Handle = Selector.GetHandle("setInterpolationQuality:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxScaleFactor_ = "setMaxScaleFactor:";

	private static readonly IntPtr selSetMaxScaleFactor_Handle = Selector.GetHandle("setMaxScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinScaleFactor_ = "setMinScaleFactor:";

	private static readonly IntPtr selSetMinScaleFactor_Handle = Selector.GetHandle("setMinScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPageBreakMargins_ = "setPageBreakMargins:";

	private static readonly IntPtr selSetPageBreakMargins_Handle = Selector.GetHandle("setPageBreakMargins:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleFactor_ = "setScaleFactor:";

	private static readonly IntPtr selSetScaleFactor_Handle = Selector.GetHandle("setScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldAntiAlias_ = "setShouldAntiAlias:";

	private static readonly IntPtr selSetShouldAntiAlias_Handle = Selector.GetHandle("setShouldAntiAlias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldAntiAlias = "shouldAntiAlias";

	private static readonly IntPtr selShouldAntiAliasHandle = Selector.GetHandle("shouldAntiAlias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeBackgroundColorFrom_ = "takeBackgroundColorFrom:";

	private static readonly IntPtr selTakeBackgroundColorFrom_Handle = Selector.GetHandle("takeBackgroundColorFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakePasswordFrom_ = "takePasswordFrom:";

	private static readonly IntPtr selTakePasswordFrom_Handle = Selector.GetHandle("takePasswordFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisiblePages = "visiblePages";

	private static readonly IntPtr selVisiblePagesHandle = Selector.GetHandle("visiblePages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomIn_ = "zoomIn:";

	private static readonly IntPtr selZoomIn_Handle = Selector.GetHandle("zoomIn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomOut_ = "zoomOut:";

	private static readonly IntPtr selZoomOut_Handle = Selector.GetHandle("zoomOut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationHitNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationWillHitNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedHistoryNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CopyPermissionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayBoxChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayModeChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PageChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PrintPermissionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScaleChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisiblePagesChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AcceptsDraggedFiles
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("acceptsDraggedFiles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsDraggedFilesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsDraggedFilesHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAcceptsDraggedFiles:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsDraggedFiles_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsDraggedFiles_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual bool AllowsDragging
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("allowsDragging")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDraggingHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("setAllowsDragging:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDragging_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDragging_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoScales
	{
		[Export("autoScales")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoScalesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoScalesHandle);
		}
		[Export("setAutoScales:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoScales_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoScales_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:")]
		set
		{
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
	public virtual bool CanGoBack
	{
		[Export("canGoBack")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoBackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoBackHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoForward
	{
		[Export("canGoForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoForwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoToFirstPage
	{
		[Export("canGoToFirstPage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToFirstPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToFirstPageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoToLastPage
	{
		[Export("canGoToLastPage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToLastPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToLastPageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoToNextPage
	{
		[Export("canGoToNextPage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToNextPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToNextPageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoToPreviousPage
	{
		[Export("canGoToPreviousPage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToPreviousPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToPreviousPageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanZoomIn
	{
		[Export("canZoomIn")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanZoomInHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanZoomInHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanZoomOut
	{
		[Export("canZoomOut")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanZoomOutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanZoomOutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDestination CurrentDestination
	{
		[Export("currentDestination")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfDestination>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDestinationHandle));
			}
			return Runtime.GetNSObject<PdfDestination>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDestinationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage CurrentPage
	{
		[Export("currentPage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPageHandle));
			}
			return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection CurrentSelection
	{
		[Export("currentSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentSelectionHandle));
			}
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentSelectionHandle));
		}
		[Export("setCurrentSelection:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentSelection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentSelection_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IPdfViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IPdfViewDelegate;
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
	public virtual PdfDisplayBox DisplayBox
	{
		[Export("displayBox")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfDisplayBox)Messaging.Int64_objc_msgSend(base.Handle, selDisplayBoxHandle);
			}
			return (PdfDisplayBox)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDisplayBoxHandle);
		}
		[Export("setDisplayBox:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDisplayBox_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDisplayBox_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual PdfDisplayDirection DisplayDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("displayDirection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfDisplayDirection)Messaging.Int64_objc_msgSend(base.Handle, selDisplayDirectionHandle);
			}
			return (PdfDisplayDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDisplayDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setDisplayDirection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDisplayDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDisplayDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDisplayMode DisplayMode
	{
		[Export("displayMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfDisplayMode)Messaging.Int64_objc_msgSend(base.Handle, selDisplayModeHandle);
			}
			return (PdfDisplayMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDisplayModeHandle);
		}
		[Export("setDisplayMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDisplayMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDisplayMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysAsBook
	{
		[Export("displaysAsBook")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysAsBookHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysAsBookHandle);
		}
		[Export("setDisplaysAsBook:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysAsBook_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysAsBook_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysPageBreaks
	{
		[Export("displaysPageBreaks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysPageBreaksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysPageBreaksHandle);
		}
		[Export("setDisplaysPageBreaks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysPageBreaks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysPageBreaks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool DisplaysRtl
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("displaysRTL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysRTLHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysRTLHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setDisplaysRTL:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysRTL_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysRTL_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDocument? Document
	{
		[Export("document")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle));
			}
			return Runtime.GetNSObject<PdfDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle));
		}
		[Export("setDocument:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView DocumentView
	{
		[Export("documentView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableDataDetectors
	{
		[Export("enableDataDetectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableDataDetectorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableDataDetectorsHandle);
		}
		[Export("setEnableDataDetectors:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableDataDetectors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableDataDetectors_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	public virtual nfloat GreekingThreshold
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("greekingThreshold")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selGreekingThresholdHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selGreekingThresholdHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setGreekingThreshold:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetGreekingThreshold_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetGreekingThreshold_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection[] HighlightedSelections
	{
		[Export("highlightedSelections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedSelectionsHandle));
			}
			return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedSelectionsHandle));
		}
		[Export("setHighlightedSelections:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHighlightedSelections_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHighlightedSelections_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfInterpolationQuality InterpolationQuality
	{
		[Export("interpolationQuality", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfInterpolationQuality)Messaging.Int64_objc_msgSend(base.Handle, selInterpolationQualityHandle);
			}
			return (PdfInterpolationQuality)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInterpolationQualityHandle);
		}
		[Export("setInterpolationQuality:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetInterpolationQuality_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetInterpolationQuality_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual nfloat MaxScaleFactor
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("maxScaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaxScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaxScaleFactorHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setMaxScaleFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaxScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaxScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual nfloat MinScaleFactor
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("minScaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinScaleFactorHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setMinScaleFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSEdgeInsets PageBreakMargins
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("pageBreakMargins")]
		get
		{
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selPageBreakMarginsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPageBreakMarginsHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPageBreakMargins:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetPageBreakMargins_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetPageBreakMargins_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual bool PageShadowsEnabled
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("pageShadowsEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPageShadowsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPageShadowsEnabledHandle);
		}
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("enablePageShadows:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selEnablePageShadows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selEnablePageShadows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScaleFactorHandle);
		}
		[Export("setScaleFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual nfloat ScaleFactorForSizeToFit
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("scaleFactorForSizeToFit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScaleFactorForSizeToFitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScaleFactorForSizeToFitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	public virtual bool ShouldAntiAlias
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("shouldAntiAlias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldAntiAliasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldAntiAliasHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setShouldAntiAlias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldAntiAlias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldAntiAlias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage[] VisiblePages
	{
		[Export("visiblePages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisiblePagesHandle));
			}
			return NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisiblePagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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

	[Field("PDFViewAnnotationHitNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveAnnotationHit helper method instead.")]
	public static NSString AnnotationHitNotification
	{
		get
		{
			if (_AnnotationHitNotification == null)
			{
				_AnnotationHitNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewAnnotationHitNotification");
			}
			return _AnnotationHitNotification;
		}
	}

	[Field("PDFViewAnnotationWillHitNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveAnnotationWillHit helper method instead.")]
	public static NSString AnnotationWillHitNotification
	{
		get
		{
			if (_AnnotationWillHitNotification == null)
			{
				_AnnotationWillHitNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewAnnotationWillHitNotification");
			}
			return _AnnotationWillHitNotification;
		}
	}

	[Field("PDFViewChangedHistoryNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveChangedHistory helper method instead.")]
	public static NSString ChangedHistoryNotification
	{
		get
		{
			if (_ChangedHistoryNotification == null)
			{
				_ChangedHistoryNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewChangedHistoryNotification");
			}
			return _ChangedHistoryNotification;
		}
	}

	[Field("PDFViewCopyPermissionNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveCopyPermission helper method instead.")]
	public static NSString CopyPermissionNotification
	{
		get
		{
			if (_CopyPermissionNotification == null)
			{
				_CopyPermissionNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewCopyPermissionNotification");
			}
			return _CopyPermissionNotification;
		}
	}

	[Field("PDFViewDisplayBoxChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveDisplayBoxChanged helper method instead.")]
	public static NSString DisplayBoxChangedNotification
	{
		get
		{
			if (_DisplayBoxChangedNotification == null)
			{
				_DisplayBoxChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewDisplayBoxChangedNotification");
			}
			return _DisplayBoxChangedNotification;
		}
	}

	[Field("PDFViewDisplayModeChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveDisplayModeChanged helper method instead.")]
	public static NSString DisplayModeChangedNotification
	{
		get
		{
			if (_DisplayModeChangedNotification == null)
			{
				_DisplayModeChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewDisplayModeChangedNotification");
			}
			return _DisplayModeChangedNotification;
		}
	}

	[Field("PDFViewDocumentChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveDocumentChanged helper method instead.")]
	public static NSString DocumentChangedNotification
	{
		get
		{
			if (_DocumentChangedNotification == null)
			{
				_DocumentChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewDocumentChangedNotification");
			}
			return _DocumentChangedNotification;
		}
	}

	[Field("PDFViewPageChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObservePageChanged helper method instead.")]
	public static NSString PageChangedNotification
	{
		get
		{
			if (_PageChangedNotification == null)
			{
				_PageChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewPageChangedNotification");
			}
			return _PageChangedNotification;
		}
	}

	[Field("PDFViewPrintPermissionNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObservePrintPermission helper method instead.")]
	public static NSString PrintPermissionNotification
	{
		get
		{
			if (_PrintPermissionNotification == null)
			{
				_PrintPermissionNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewPrintPermissionNotification");
			}
			return _PrintPermissionNotification;
		}
	}

	[Field("PDFViewScaleChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveScaleChanged helper method instead.")]
	public static NSString ScaleChangedNotification
	{
		get
		{
			if (_ScaleChangedNotification == null)
			{
				_ScaleChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewScaleChangedNotification");
			}
			return _ScaleChangedNotification;
		}
	}

	[Field("PDFViewSelectionChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveSelectionChanged helper method instead.")]
	public static NSString SelectionChangedNotification
	{
		get
		{
			if (_SelectionChangedNotification == null)
			{
				_SelectionChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewSelectionChangedNotification");
			}
			return _SelectionChangedNotification;
		}
	}

	[Field("PDFViewVisiblePagesChangedNotification", "Quartz")]
	[Advice("Use PdfView.Notifications.ObserveVisiblePagesChanged helper method instead.")]
	public static NSString VisiblePagesChangedNotification
	{
		get
		{
			if (_VisiblePagesChangedNotification == null)
			{
				_VisiblePagesChangedNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFViewVisiblePagesChangedNotification");
			}
			return _VisiblePagesChangedNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_PdfViewDelegate);

	public PdfViewTitle? TitleOfPrintJob
	{
		get
		{
			return EnsurePdfViewDelegate().titleOfPrintJob;
		}
		set
		{
			EnsurePdfViewDelegate().titleOfPrintJob = value;
		}
	}

	public PdfViewScale? WillChangeScaleFactor
	{
		get
		{
			return EnsurePdfViewDelegate().willChangeScaleFactor;
		}
		set
		{
			EnsurePdfViewDelegate().willChangeScaleFactor = value;
		}
	}

	public event EventHandler<PdfViewActionEventArgs> OpenPdf
	{
		add
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.openPdf = (EventHandler<PdfViewActionEventArgs>)System.Delegate.Combine(pdfViewDelegate.openPdf, value);
		}
		remove
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.openPdf = (EventHandler<PdfViewActionEventArgs>)System.Delegate.Remove(pdfViewDelegate.openPdf, value);
		}
	}

	public event EventHandler PerformFind
	{
		add
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performFind = (EventHandler)System.Delegate.Combine(pdfViewDelegate.performFind, value);
		}
		remove
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performFind = (EventHandler)System.Delegate.Remove(pdfViewDelegate.performFind, value);
		}
	}

	public event EventHandler PerformGoToPage
	{
		add
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performGoToPage = (EventHandler)System.Delegate.Combine(pdfViewDelegate.performGoToPage, value);
		}
		remove
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performGoToPage = (EventHandler)System.Delegate.Remove(pdfViewDelegate.performGoToPage, value);
		}
	}

	public event EventHandler PerformPrint
	{
		add
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performPrint = (EventHandler)System.Delegate.Combine(pdfViewDelegate.performPrint, value);
		}
		remove
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.performPrint = (EventHandler)System.Delegate.Remove(pdfViewDelegate.performPrint, value);
		}
	}

	public event EventHandler<PdfViewUrlEventArgs> WillClickOnLink
	{
		add
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.willClickOnLink = (EventHandler<PdfViewUrlEventArgs>)System.Delegate.Combine(pdfViewDelegate.willClickOnLink, value);
		}
		remove
		{
			_PdfViewDelegate pdfViewDelegate = EnsurePdfViewDelegate();
			pdfViewDelegate.willClickOnLink = (EventHandler<PdfViewUrlEventArgs>)System.Delegate.Remove(pdfViewDelegate.willClickOnLink, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfView()
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
	public PdfView(NSCoder coder)
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
	protected PdfView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfView(CGRect frame)
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

	[Export("animationDidEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidEnd(NSAnimation animation)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnimationDidEnd_Handle, animation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationDidEnd_Handle, animation.Handle);
		}
	}

	[Export("animation:didReachProgressMark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidReachProgressMark(NSAnimation animation, float progress)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selAnimation_DidReachProgressMark_Handle, animation.Handle, progress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAnimation_DidReachProgressMark_Handle, animation.Handle, progress);
		}
	}

	[Export("animationDidStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidStop(NSAnimation animation)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnimationDidStop_Handle, animation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationDidStop_Handle, animation.Handle);
		}
	}

	[Export("animationShouldStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimationShouldStart(NSAnimation animation)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAnimationShouldStart_Handle, animation.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationShouldStart_Handle, animation.Handle);
	}

	[Export("annotationsChangedOnPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnnotationsChanged(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnnotationsChangedOnPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnnotationsChangedOnPage_Handle, page.Handle);
		}
	}

	[Export("clearSelection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearSelection()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearSelectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearSelectionHandle);
		}
	}

	[Export("animation:valueForProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ComputeAnimationCurve(NSAnimation animation, float progress)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr_float(base.Handle, selAnimation_ValueForProgress_Handle, animation.Handle, progress);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAnimation_ValueForProgress_Handle, animation.Handle, progress);
	}

	[Export("confinementRectForMenu:onScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConfinementRectForMenu(NSMenu menu, NSScreen screen)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out retval, base.Handle, selConfinementRectForMenu_OnScreen_Handle, menu.Handle, screen.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr(out retval, base.SuperHandle, selConfinementRectForMenu_OnScreen_Handle, menu.Handle, screen.Handle);
		}
		return retval;
	}

	[Export("convertPoint:fromPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromPage(CGPoint point, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_FromPage_Handle, point, page.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_FromPage_Handle, point, page.Handle);
	}

	[Export("convertPoint:toPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToPage(CGPoint point, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToPage_Handle, point, page.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToPage_Handle, point, page.Handle);
	}

	[Export("convertRect:fromPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectangleFromPage(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_FromPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_FromPage_Handle, rect, page.Handle);
		}
		return retval;
	}

	[Export("convertRect:toPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectangleToPage(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_ToPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_ToPage_Handle, rect, page.Handle);
		}
		return retval;
	}

	[Export("copy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Copy(NSObject? sender)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("drawPage:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawPage_Handle, page.Handle);
		}
	}

	[Export("drawPage:toContext:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawPage(PdfPage page, CGContext context)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDrawPage_ToContext_Handle, page.Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDrawPage_ToContext_Handle, page.Handle, context.Handle);
		}
	}

	[Export("drawPagePost:toContext:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawPagePost(PdfPage page, CGContext context)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDrawPagePost_ToContext_Handle, page.Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDrawPagePost_ToContext_Handle, page.Handle, context.Handle);
		}
	}

	[Export("drawPagePost:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawPagePost(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawPagePost_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawPagePost_Handle, page.Handle);
		}
	}

	[Export("areaOfInterestForMouse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfAreaOfInterest GetAreaOfInterest(NSEvent mouseEvent)
	{
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			return (PdfAreaOfInterest)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selAreaOfInterestForMouse_Handle, mouseEvent.Handle);
		}
		return (PdfAreaOfInterest)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selAreaOfInterestForMouse_Handle, mouseEvent.Handle);
	}

	[Export("areaOfInterestForPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfAreaOfInterest GetAreaOfInterest(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return (PdfAreaOfInterest)Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selAreaOfInterestForPoint_Handle, point);
		}
		return (PdfAreaOfInterest)Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selAreaOfInterestForPoint_Handle, point);
	}

	[Export("pageForPoint:nearest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage GetPage(CGPoint point, bool nearest)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSend_CGPoint_bool(base.Handle, selPageForPoint_Nearest_Handle, point, nearest));
		}
		return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_bool(base.SuperHandle, selPageForPoint_Nearest_Handle, point, nearest));
	}

	[Export("goBack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoBack(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoBack_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoBack_Handle, sender.Handle);
		}
	}

	[Export("goForward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoForward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoForward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoForward_Handle, sender.Handle);
		}
	}

	[Export("goToDestination:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToDestination(PdfDestination destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToDestination_Handle, destination.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToDestination_Handle, destination.Handle);
		}
	}

	[Export("goToFirstPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToFirstPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToFirstPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToFirstPage_Handle, sender.Handle);
		}
	}

	[Export("goToLastPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToLastPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToLastPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToLastPage_Handle, sender.Handle);
		}
	}

	[Export("goToNextPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToNextPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToNextPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToNextPage_Handle, sender.Handle);
		}
	}

	[Export("goToPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToPage_Handle, page.Handle);
		}
	}

	[Export("goToPreviousPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToPreviousPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToPreviousPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToPreviousPage_Handle, sender.Handle);
		}
	}

	[Export("goToRect:onPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToRectangle(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selGoToRect_OnPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGoToRect_OnPage_Handle, rect, page.Handle);
		}
	}

	[Export("goToSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToSelection(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToSelection_Handle, selection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToSelection_Handle, selection.Handle);
		}
	}

	[Export("menuHasKeyEquivalent:forEvent:target:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasKeyEquivalentForEvent(NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selMenuHasKeyEquivalent_ForEvent_Target_Action_Handle, menu.Handle, theEvent.Handle, target.Handle, action.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMenuHasKeyEquivalent_ForEvent_Target_Action_Handle, menu.Handle, theEvent.Handle, target.Handle, action.Handle);
	}

	[Export("layoutDocumentView")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutDocumentView()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutDocumentViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutDocumentViewHandle);
		}
	}

	[Export("menuDidClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MenuDidClose(NSMenu menu)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMenuDidClose_Handle, menu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMenuDidClose_Handle, menu.Handle);
		}
	}

	[Export("numberOfItemsInMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MenuItemCount(NSMenu menu)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selNumberOfItemsInMenu_Handle, menu.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberOfItemsInMenu_Handle, menu.Handle);
	}

	[Export("menu:willHighlightItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MenuWillHighlightItem(NSMenu menu, NSMenuItem item)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMenu_WillHighlightItem_Handle, menu.Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMenu_WillHighlightItem_Handle, menu.Handle, item.Handle);
		}
	}

	[Export("menuWillOpen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MenuWillOpen(NSMenu menu)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMenuWillOpen_Handle, menu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMenuWillOpen_Handle, menu.Handle);
		}
	}

	[Export("menuNeedsUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NeedsUpdate(NSMenu menu)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMenuNeedsUpdate_Handle, menu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMenuNeedsUpdate_Handle, menu.Handle);
		}
	}

	[Export("performAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformAction(PdfAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformAction_Handle, action.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformAction_Handle, action.Handle);
		}
	}

	[Export("printWithInfo:autoRotate:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Print(NSPrintInfo printInfo, bool doRotate)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selPrintWithInfo_AutoRotate_Handle, printInfo.Handle, doRotate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selPrintWithInfo_AutoRotate_Handle, printInfo.Handle, doRotate);
		}
	}

	[Export("printWithInfo:autoRotate:pageScaling:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Print(NSPrintInfo printInfo, bool doRotate, PdfPrintScalingMode scaleMode)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_Int64(base.Handle, selPrintWithInfo_AutoRotate_PageScaling_Handle, printInfo.Handle, doRotate, (long)scaleMode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_Int64(base.SuperHandle, selPrintWithInfo_AutoRotate_PageScaling_Handle, printInfo.Handle, doRotate, (long)scaleMode);
		}
	}

	[Export("rowSizeForPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize RowSize(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selRowSizeForPage_Handle, page.Handle);
		}
		return Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowSizeForPage_Handle, page.Handle);
	}

	[Export("scrollSelectionToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollSelectionToVisible(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollSelectionToVisible_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollSelectionToVisible_Handle, sender.Handle);
		}
	}

	[Export("selectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject? sender)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("setCurrentSelection:animate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCurrentSelection(PdfSelection selection, bool animate)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetCurrentSelection_Animate_Handle, selection.Handle, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetCurrentSelection_Animate_Handle, selection.Handle, animate);
		}
	}

	[Export("setCursorForAreaOfInterest:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCursor(PdfAreaOfInterest area)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetCursorForAreaOfInterest_Handle, (long)area);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCursorForAreaOfInterest_Handle, (long)area);
		}
	}

	[Export("takeBackgroundColorFrom:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeBackgroundColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeBackgroundColorFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeBackgroundColorFrom_Handle, sender.Handle);
		}
	}

	[Export("takePasswordFrom:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakePasswordFrom(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakePasswordFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakePasswordFrom_Handle, sender.Handle);
		}
	}

	[Export("menu:updateItem:atIndex:shouldCancel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateItem(NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_bool(base.Handle, selMenu_UpdateItem_AtIndex_ShouldCancel_Handle, menu.Handle, item.Handle, atIndex, shouldCancel);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_nint_bool(base.SuperHandle, selMenu_UpdateItem_AtIndex_ShouldCancel_Handle, menu.Handle, item.Handle, atIndex, shouldCancel);
	}

	[Export("zoomIn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomIn(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomIn_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomIn_Handle, sender.Handle);
		}
	}

	[Export("zoomOut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomOut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomOut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomOut_Handle, sender.Handle);
		}
	}

	internal virtual _PdfViewDelegate CreateInternalEventDelegateType()
	{
		return new _PdfViewDelegate();
	}

	internal _PdfViewDelegate EnsurePdfViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_PdfViewDelegate pdfViewDelegate = Delegate as _PdfViewDelegate;
		if (pdfViewDelegate == null)
		{
			pdfViewDelegate = (_PdfViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return pdfViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
