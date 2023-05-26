using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFView", true)]
public class PdfView : NSView
{
	[Register]
	private sealed class _PdfViewDelegate : PdfViewDelegate
	{
		internal PdfViewScale willChangeScaleFactor;

		internal EventHandler<PdfViewUrlEventArgs> willClickOnLink;

		internal PdfViewTitle titleOfPrintJob;

		internal EventHandler performFind;

		internal EventHandler performGoToPage;

		internal EventHandler performPrint;

		internal EventHandler<PdfViewActionEventArgs> openPdf;

		[Preserve(Conditional = true)]
		public override float WillChangeScaleFactor(PdfView sender, float scale)
		{
			return willChangeScaleFactor?.Invoke(sender, scale) ?? scale;
		}

		[Preserve(Conditional = true)]
		public override void WillClickOnLink(PdfView sender, NSUrl url)
		{
			EventHandler<PdfViewUrlEventArgs> eventHandler = willClickOnLink;
			if (eventHandler != null)
			{
				PdfViewUrlEventArgs e = new PdfViewUrlEventArgs(url);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override string TitleOfPrintJob(PdfView sender)
		{
			PdfViewTitle pdfViewTitle = titleOfPrintJob;
			if (pdfViewTitle != null)
			{
				return pdfViewTitle(sender);
			}
			return string.Empty;
		}

		[Preserve(Conditional = true)]
		public override void PerformFind(PdfView sender)
		{
			performFind?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void PerformGoToPage(PdfView sender)
		{
			performGoToPage?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void PerformPrint(PdfView sender)
		{
			performPrint?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void OpenPdf(PdfView sender, PdfActionRemoteGoTo action)
		{
			EventHandler<PdfViewActionEventArgs> eventHandler = openPdf;
			if (eventHandler != null)
			{
				PdfViewActionEventArgs e = new PdfViewActionEventArgs(action);
				eventHandler(sender, e);
			}
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveChangedHistory(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedHistoryNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDocumentChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DocumentChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePageChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(PageChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScaleChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ScaleChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnotationHit(EventHandler<PdfViewAnnotationHitEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationHitNotification, delegate(NSNotification notification)
			{
				handler(null, new PdfViewAnnotationHitEventArgs(notification));
			});
		}

		public static NSObject ObserveCopyPermission(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(CopyPermissionNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnotationWillHit(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnotationWillHitNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDisplayModeChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayModeChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDisplayBoxChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayBoxChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	private static readonly IntPtr selSetDocument_Handle = Selector.GetHandle("setDocument:");

	private static readonly IntPtr selCanGoToFirstPageHandle = Selector.GetHandle("canGoToFirstPage");

	private static readonly IntPtr selCanGoToLastPageHandle = Selector.GetHandle("canGoToLastPage");

	private static readonly IntPtr selCanGoToNextPageHandle = Selector.GetHandle("canGoToNextPage");

	private static readonly IntPtr selCanGoToPreviousPageHandle = Selector.GetHandle("canGoToPreviousPage");

	private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle("canGoBack");

	private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle("canGoForward");

	private static readonly IntPtr selCurrentPageHandle = Selector.GetHandle("currentPage");

	private static readonly IntPtr selCurrentDestinationHandle = Selector.GetHandle("currentDestination");

	private static readonly IntPtr selDisplayModeHandle = Selector.GetHandle("displayMode");

	private static readonly IntPtr selSetDisplayMode_Handle = Selector.GetHandle("setDisplayMode:");

	private static readonly IntPtr selDisplaysPageBreaksHandle = Selector.GetHandle("displaysPageBreaks");

	private static readonly IntPtr selSetDisplaysPageBreaks_Handle = Selector.GetHandle("setDisplaysPageBreaks:");

	private static readonly IntPtr selDisplayBoxHandle = Selector.GetHandle("displayBox");

	private static readonly IntPtr selSetDisplayBox_Handle = Selector.GetHandle("setDisplayBox:");

	private static readonly IntPtr selDisplaysAsBookHandle = Selector.GetHandle("displaysAsBook");

	private static readonly IntPtr selSetDisplaysAsBook_Handle = Selector.GetHandle("setDisplaysAsBook:");

	private static readonly IntPtr selShouldAntiAliasHandle = Selector.GetHandle("shouldAntiAlias");

	private static readonly IntPtr selSetShouldAntiAlias_Handle = Selector.GetHandle("setShouldAntiAlias:");

	private static readonly IntPtr selGreekingThresholdHandle = Selector.GetHandle("greekingThreshold");

	private static readonly IntPtr selSetGreekingThreshold_Handle = Selector.GetHandle("setGreekingThreshold:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selScaleFactorHandle = Selector.GetHandle("scaleFactor");

	private static readonly IntPtr selSetScaleFactor_Handle = Selector.GetHandle("setScaleFactor:");

	private static readonly IntPtr selCanZoomInHandle = Selector.GetHandle("canZoomIn");

	private static readonly IntPtr selCanZoomOutHandle = Selector.GetHandle("canZoomOut");

	private static readonly IntPtr selAutoScalesHandle = Selector.GetHandle("autoScales");

	private static readonly IntPtr selSetAutoScales_Handle = Selector.GetHandle("setAutoScales:");

	private static readonly IntPtr selCurrentSelectionHandle = Selector.GetHandle("currentSelection");

	private static readonly IntPtr selSetCurrentSelection_Handle = Selector.GetHandle("setCurrentSelection:");

	private static readonly IntPtr selHighlightedSelectionsHandle = Selector.GetHandle("highlightedSelections");

	private static readonly IntPtr selSetHighlightedSelections_Handle = Selector.GetHandle("setHighlightedSelections:");

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	private static readonly IntPtr selAllowsDraggingHandle = Selector.GetHandle("allowsDragging");

	private static readonly IntPtr selSetAllowsDragging_Handle = Selector.GetHandle("setAllowsDragging:");

	private static readonly IntPtr selVisiblePagesHandle = Selector.GetHandle("visiblePages");

	private static readonly IntPtr selEnableDataDetectorsHandle = Selector.GetHandle("enableDataDetectors");

	private static readonly IntPtr selSetEnableDataDetectors_Handle = Selector.GetHandle("setEnableDataDetectors:");

	private static readonly IntPtr selGoToFirstPage_Handle = Selector.GetHandle("goToFirstPage:");

	private static readonly IntPtr selGoToLastPage_Handle = Selector.GetHandle("goToLastPage:");

	private static readonly IntPtr selGoToNextPage_Handle = Selector.GetHandle("goToNextPage:");

	private static readonly IntPtr selGoToPreviousPage_Handle = Selector.GetHandle("goToPreviousPage:");

	private static readonly IntPtr selGoBack_Handle = Selector.GetHandle("goBack:");

	private static readonly IntPtr selGoForward_Handle = Selector.GetHandle("goForward:");

	private static readonly IntPtr selGoToPage_Handle = Selector.GetHandle("goToPage:");

	private static readonly IntPtr selGoToDestination_Handle = Selector.GetHandle("goToDestination:");

	private static readonly IntPtr selGoToSelection_Handle = Selector.GetHandle("goToSelection:");

	private static readonly IntPtr selGoToRectOnPage_Handle = Selector.GetHandle("goToRect:onPage:");

	private static readonly IntPtr selTakeBackgroundColorFrom_Handle = Selector.GetHandle("takeBackgroundColorFrom:");

	private static readonly IntPtr selZoomIn_Handle = Selector.GetHandle("zoomIn:");

	private static readonly IntPtr selZoomOut_Handle = Selector.GetHandle("zoomOut:");

	private static readonly IntPtr selAreaOfInterestForMouse_Handle = Selector.GetHandle("areaOfInterestForMouse:");

	private static readonly IntPtr selSetCursorForAreaOfInterest_Handle = Selector.GetHandle("setCursorForAreaOfInterest:");

	private static readonly IntPtr selPerformAction_Handle = Selector.GetHandle("performAction:");

	private static readonly IntPtr selSetCurrentSelectionAnimate_Handle = Selector.GetHandle("setCurrentSelection:animate:");

	private static readonly IntPtr selClearSelectionHandle = Selector.GetHandle("clearSelection");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selScrollSelectionToVisible_Handle = Selector.GetHandle("scrollSelectionToVisible:");

	private static readonly IntPtr selTakePasswordFrom_Handle = Selector.GetHandle("takePasswordFrom:");

	private static readonly IntPtr selDrawPage_Handle = Selector.GetHandle("drawPage:");

	private static readonly IntPtr selDrawPagePost_Handle = Selector.GetHandle("drawPagePost:");

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	private static readonly IntPtr selPrintWithInfoAutoRotate_Handle = Selector.GetHandle("printWithInfo:autoRotate:");

	private static readonly IntPtr selPrintWithInfoAutoRotatePageScaling_Handle = Selector.GetHandle("printWithInfo:autoRotate:pageScaling:");

	private static readonly IntPtr selPageForPointNearest_Handle = Selector.GetHandle("pageForPoint:nearest:");

	private static readonly IntPtr selConvertPointToPage_Handle = Selector.GetHandle("convertPoint:toPage:");

	private static readonly IntPtr selConvertRectToPage_Handle = Selector.GetHandle("convertRect:toPage:");

	private static readonly IntPtr selConvertPointFromPage_Handle = Selector.GetHandle("convertPoint:fromPage:");

	private static readonly IntPtr selConvertRectFromPage_Handle = Selector.GetHandle("convertRect:fromPage:");

	private static readonly IntPtr selLayoutDocumentViewHandle = Selector.GetHandle("layoutDocumentView");

	private static readonly IntPtr selAnnotationsChangedOnPage_Handle = Selector.GetHandle("annotationsChangedOnPage:");

	private static readonly IntPtr selRowSizeForPage_Handle = Selector.GetHandle("rowSizeForPage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFView");

	private object __mt_Document_var;

	private object __mt_CurrentPage_var;

	private object __mt_CurrentDestination_var;

	private object __mt_BackgroundColor_var;

	private object __mt_WeakDelegate_var;

	private object __mt_CurrentSelection_var;

	private object __mt_HighlightedSelections_var;

	private object __mt_DocumentView_var;

	private object __mt_VisiblePages_var;

	private static NSString _ChangedHistoryNotification;

	private static NSString _DocumentChangedNotification;

	private static NSString _PageChangedNotification;

	private static NSString _ScaleChangedNotification;

	private static NSString _AnnotationHitNotification;

	private static NSString _CopyPermissionNotification;

	private static NSString _AnnotationWillHitNotification;

	private static NSString _SelectionChangedNotification;

	private static NSString _DisplayModeChangedNotification;

	private static NSString _DisplayBoxChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfDocument Document
	{
		[Export("document")]
		get
		{
			return (PdfDocument)(__mt_Document_var = ((!IsDirectBinding) ? ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle))) : ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle)))));
		}
		[Export("setDocument:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocument_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocument_Handle, value.Handle);
			}
			__mt_Document_var = value;
		}
	}

	public virtual bool CanGoToFirstPage
	{
		[Export("canGoToFirstPage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToFirstPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToFirstPageHandle);
		}
	}

	public virtual bool CanGoToLastPage
	{
		[Export("canGoToLastPage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToLastPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToLastPageHandle);
		}
	}

	public virtual bool CanGoToNextPage
	{
		[Export("canGoToNextPage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToNextPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToNextPageHandle);
		}
	}

	public virtual bool CanGoToPreviousPage
	{
		[Export("canGoToPreviousPage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoToPreviousPageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoToPreviousPageHandle);
		}
	}

	public virtual bool CanGoBack
	{
		[Export("canGoBack")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoBackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoBackHandle);
		}
	}

	public virtual bool CanGoForward
	{
		[Export("canGoForward")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoForwardHandle);
		}
	}

	public virtual PdfPage CurrentPage
	{
		[Export("currentPage")]
		get
		{
			return (PdfPage)(__mt_CurrentPage_var = ((!IsDirectBinding) ? ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPageHandle))) : ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPageHandle)))));
		}
	}

	public virtual PdfDestination CurrentDestination
	{
		[Export("currentDestination")]
		get
		{
			return (PdfDestination)(__mt_CurrentDestination_var = ((!IsDirectBinding) ? ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDestinationHandle))) : ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDestinationHandle)))));
		}
	}

	public virtual PdfDisplayMode DisplayMode
	{
		[Export("displayMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfDisplayMode)Messaging.int_objc_msgSend(base.Handle, selDisplayModeHandle);
			}
			return (PdfDisplayMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDisplayModeHandle);
		}
		[Export("setDisplayMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDisplayMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDisplayMode_Handle, (int)value);
			}
		}
	}

	public virtual bool DisplaysPageBreaks
	{
		[Export("displaysPageBreaks")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysPageBreaksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysPageBreaksHandle);
		}
		[Export("setDisplaysPageBreaks:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysPageBreaks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysPageBreaks_Handle, value);
			}
		}
	}

	public virtual PdfDisplayBox DisplayBox
	{
		[Export("displayBox")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfDisplayBox)Messaging.int_objc_msgSend(base.Handle, selDisplayBoxHandle);
			}
			return (PdfDisplayBox)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDisplayBoxHandle);
		}
		[Export("setDisplayBox:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDisplayBox_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDisplayBox_Handle, (int)value);
			}
		}
	}

	public virtual bool DisplaysAsBook
	{
		[Export("displaysAsBook")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysAsBookHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysAsBookHandle);
		}
		[Export("setDisplaysAsBook:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysAsBook_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysAsBook_Handle, value);
			}
		}
	}

	public virtual bool ShouldAntiAlias
	{
		[Export("shouldAntiAlias")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldAntiAliasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldAntiAliasHandle);
		}
		[Export("setShouldAntiAlias:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldAntiAlias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldAntiAlias_Handle, value);
			}
		}
	}

	public virtual float GreekingThreshold
	{
		[Export("greekingThreshold")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGreekingThresholdHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGreekingThresholdHandle);
		}
		[Export("setGreekingThreshold:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGreekingThreshold_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGreekingThreshold_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public PdfViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as PdfViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual float ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleFactorHandle);
		}
		[Export("setScaleFactor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleFactor_Handle, value);
			}
		}
	}

	public virtual bool CanZoomIn
	{
		[Export("canZoomIn")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanZoomInHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanZoomInHandle);
		}
	}

	public virtual bool CanZoomOut
	{
		[Export("canZoomOut")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanZoomOutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanZoomOutHandle);
		}
	}

	public virtual bool AutoScales
	{
		[Export("autoScales")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoScalesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoScalesHandle);
		}
		[Export("setAutoScales:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoScales_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoScales_Handle, value);
			}
		}
	}

	public virtual PdfSelection CurrentSelection
	{
		[Export("currentSelection")]
		get
		{
			return (PdfSelection)(__mt_CurrentSelection_var = ((!IsDirectBinding) ? ((PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentSelectionHandle))) : ((PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentSelectionHandle)))));
		}
		[Export("setCurrentSelection:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentSelection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentSelection_Handle, value.Handle);
			}
			__mt_CurrentSelection_var = value;
		}
	}

	public virtual PdfSelection[] HighlightedSelections
	{
		[Export("highlightedSelections")]
		get
		{
			return (PdfSelection[])(__mt_HighlightedSelections_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedSelectionsHandle)) : NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedSelectionsHandle))));
		}
		[Export("setHighlightedSelections:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHighlightedSelections_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHighlightedSelections_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_HighlightedSelections_var = value;
		}
	}

	public virtual NSView DocumentView
	{
		[Export("documentView")]
		get
		{
			return (NSView)(__mt_DocumentView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle)))));
		}
	}

	public virtual bool AllowsDragging
	{
		[Export("allowsDragging")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDraggingHandle);
		}
		[Export("setAllowsDragging:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDragging_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDragging_Handle, value);
			}
		}
	}

	public virtual PdfPage[] VisiblePages
	{
		[Export("visiblePages")]
		get
		{
			return (PdfPage[])(__mt_VisiblePages_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisiblePagesHandle)) : NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisiblePagesHandle))));
		}
	}

	public virtual bool EnableDataDetectors
	{
		[Export("enableDataDetectors")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableDataDetectorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableDataDetectorsHandle);
		}
		[Export("setEnableDataDetectors:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableDataDetectors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableDataDetectors_Handle, value);
			}
		}
	}

	[Field("PDFViewChangedHistoryNotification", "PdfKit")]
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

	[Field("PDFViewDocumentChangedNotification", "PdfKit")]
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

	[Field("PDFViewPageChangedNotification", "PdfKit")]
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

	[Field("PDFViewScaleChangedNotification", "PdfKit")]
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

	[Field("PDFViewAnnotationHitNotification", "PdfKit")]
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

	[Field("PDFViewCopyPermissionNotification", "PdfKit")]
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

	[Field("PDFViewAnnotationWillHitNotification", "PdfKit")]
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

	[Field("PDFViewSelectionChangedNotification", "PdfKit")]
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

	[Field("PDFViewDisplayModeChangedNotification", "PdfKit")]
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

	[Field("PDFViewDisplayBoxChangedNotification", "PdfKit")]
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

	public PdfViewScale WillChangeScaleFactor
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

	public PdfViewTitle TitleOfPrintJob
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfView()
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
	public PdfView(NSCoder coder)
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
	public PdfView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("goToFirstPage:")]
	public virtual void GoToFirstPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToFirstPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToFirstPage_Handle, sender.Handle);
		}
	}

	[Export("goToLastPage:")]
	public virtual void GoToLastPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToLastPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToLastPage_Handle, sender.Handle);
		}
	}

	[Export("goToNextPage:")]
	public virtual void GoToNextPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToNextPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToNextPage_Handle, sender.Handle);
		}
	}

	[Export("goToPreviousPage:")]
	public virtual void GoToPreviousPage(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToPreviousPage_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToPreviousPage_Handle, sender.Handle);
		}
	}

	[Export("goBack:")]
	public virtual void GoBack(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoBack_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoBack_Handle, sender.Handle);
		}
	}

	[Export("goForward:")]
	public virtual void GoForward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoForward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoForward_Handle, sender.Handle);
		}
	}

	[Export("goToPage:")]
	public virtual void GoToPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToPage_Handle, page.Handle);
		}
	}

	[Export("goToDestination:")]
	public virtual void GoToDestination(PdfDestination destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToDestination_Handle, destination.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToDestination_Handle, destination.Handle);
		}
	}

	[Export("goToSelection:")]
	public virtual void GoToSelection(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToSelection_Handle, selection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToSelection_Handle, selection.Handle);
		}
	}

	[Export("goToRect:onPage:")]
	public virtual void GoToRectangle(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selGoToRectOnPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGoToRectOnPage_Handle, rect, page.Handle);
		}
	}

	[Export("takeBackgroundColorFrom:")]
	public virtual void TakeBackgroundColor(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeBackgroundColorFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeBackgroundColorFrom_Handle, sender.Handle);
		}
	}

	[Export("zoomIn:")]
	public virtual void ZoomIn(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomIn_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomIn_Handle, sender.Handle);
		}
	}

	[Export("zoomOut:")]
	public virtual void ZoomOut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomOut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomOut_Handle, sender.Handle);
		}
	}

	[Export("areaOfInterestForMouse:")]
	public virtual PdfAreaOfInterest GetAreaOfInterest(NSEvent mouseEvent)
	{
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (IsDirectBinding)
		{
			return (PdfAreaOfInterest)Messaging.int_objc_msgSend_IntPtr(base.Handle, selAreaOfInterestForMouse_Handle, mouseEvent.Handle);
		}
		return (PdfAreaOfInterest)Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selAreaOfInterestForMouse_Handle, mouseEvent.Handle);
	}

	[Export("setCursorForAreaOfInterest:")]
	public virtual void SetCursor(PdfAreaOfInterest area)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selSetCursorForAreaOfInterest_Handle, (int)area);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCursorForAreaOfInterest_Handle, (int)area);
		}
	}

	[Export("performAction:")]
	public virtual void PerformAction(PdfAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformAction_Handle, action.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformAction_Handle, action.Handle);
		}
	}

	[Export("setCurrentSelection:animate:")]
	public virtual void SetCurrentSelection(PdfSelection selection, bool animate)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetCurrentSelectionAnimate_Handle, selection.Handle, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetCurrentSelectionAnimate_Handle, selection.Handle, animate);
		}
	}

	[Export("clearSelection")]
	public virtual void ClearSelection()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearSelectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearSelectionHandle);
		}
	}

	[Export("selectAll:")]
	public virtual void SelectAll(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("scrollSelectionToVisible:")]
	public virtual void ScrollSelectionToVisible(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollSelectionToVisible_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollSelectionToVisible_Handle, sender.Handle);
		}
	}

	[Export("takePasswordFrom:")]
	public virtual void TakePasswordFrom(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakePasswordFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakePasswordFrom_Handle, sender.Handle);
		}
	}

	[Export("drawPage:")]
	public virtual void DrawPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawPage_Handle, page.Handle);
		}
	}

	[Export("drawPagePost:")]
	public virtual void DrawPagePost(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawPagePost_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawPagePost_Handle, page.Handle);
		}
	}

	[Export("copy:")]
	public virtual void Copy(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender.Handle);
		}
	}

	[Export("printWithInfo:autoRotate:")]
	public virtual void Print(NSPrintInfo printInfo, bool doRotate)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selPrintWithInfoAutoRotate_Handle, printInfo.Handle, doRotate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selPrintWithInfoAutoRotate_Handle, printInfo.Handle, doRotate);
		}
	}

	[Export("printWithInfo:autoRotate:pageScaling:")]
	public virtual void Print(NSPrintInfo printInfo, bool doRotate, PdfPrintScalingMode scaleMode)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_int(base.Handle, selPrintWithInfoAutoRotatePageScaling_Handle, printInfo.Handle, doRotate, (int)scaleMode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_int(base.SuperHandle, selPrintWithInfoAutoRotatePageScaling_Handle, printInfo.Handle, doRotate, (int)scaleMode);
		}
	}

	[Export("pageForPoint:nearest:")]
	public virtual PdfPage GetPage(CGPoint point, bool nearest)
	{
		if (IsDirectBinding)
		{
			return (PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint_bool(base.Handle, selPageForPointNearest_Handle, point, nearest));
		}
		return (PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint_bool(base.SuperHandle, selPageForPointNearest_Handle, point, nearest));
	}

	[Export("convertPoint:toPage:")]
	public virtual CGPoint ConvertPointToPage(CGPoint point, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointToPage_Handle, point, page.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointToPage_Handle, point, page.Handle);
	}

	[Export("convertRect:toPage:")]
	public virtual CGRect ConvertRectangleToPage(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectToPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectToPage_Handle, rect, page.Handle);
		}
		return retval;
	}

	[Export("convertPoint:fromPage:")]
	public virtual CGPoint ConvertPointFromPage(CGPoint point, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointFromPage_Handle, point, page.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointFromPage_Handle, point, page.Handle);
	}

	[Export("convertRect:fromPage:")]
	public virtual CGRect ConvertRectangleFromPage(CGRect rect, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectFromPage_Handle, rect, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectFromPage_Handle, rect, page.Handle);
		}
		return retval;
	}

	[Export("layoutDocumentView")]
	public virtual void LayoutDocumentView()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutDocumentViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutDocumentViewHandle);
		}
	}

	[Export("annotationsChangedOnPage:")]
	public virtual void AnnotationsChanged(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnnotationsChangedOnPage_Handle, page.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnnotationsChangedOnPage_Handle, page.Handle);
		}
	}

	[Export("rowSizeForPage:")]
	public virtual CGSize RowSize(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selRowSizeForPage_Handle, page.Handle);
		}
		return Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowSizeForPage_Handle, page.Handle);
	}

	private _PdfViewDelegate EnsurePdfViewDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _PdfViewDelegate))
		{
			nSObject = (WeakDelegate = new _PdfViewDelegate());
		}
		return (_PdfViewDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Document_var = null;
			__mt_CurrentPage_var = null;
			__mt_CurrentDestination_var = null;
			__mt_BackgroundColor_var = null;
			__mt_WeakDelegate_var = null;
			__mt_CurrentSelection_var = null;
			__mt_HighlightedSelections_var = null;
			__mt_DocumentView_var = null;
			__mt_VisiblePages_var = null;
		}
	}
}
