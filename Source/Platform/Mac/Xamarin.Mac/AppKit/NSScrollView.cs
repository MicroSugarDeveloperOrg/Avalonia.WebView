using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSScrollView", true)]
public class NSScrollView : NSView, INSTextFinderBarContainer, INativeObject, IDisposable
{
	public new static class Notifications
	{
		public static NSObject ObserveDidEndLiveMagnify(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveMagnifyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndLiveMagnify(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveMagnifyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndLiveScroll(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndLiveScroll(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidLiveScroll(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidLiveScroll(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillStartLiveMagnify(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveMagnifyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillStartLiveMagnify(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveMagnifyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillStartLiveScroll(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillStartLiveScroll(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillStartLiveScrollNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFloatingSubview_ForAxis_ = "addFloatingSubview:forAxis:";

	private static readonly IntPtr selAddFloatingSubview_ForAxis_Handle = Selector.GetHandle("addFloatingSubview:forAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMagnification = "allowsMagnification";

	private static readonly IntPtr selAllowsMagnificationHandle = Selector.GetHandle("allowsMagnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutohidesScrollers = "autohidesScrollers";

	private static readonly IntPtr selAutohidesScrollersHandle = Selector.GetHandle("autohidesScrollers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyAdjustsContentInsets = "automaticallyAdjustsContentInsets";

	private static readonly IntPtr selAutomaticallyAdjustsContentInsetsHandle = Selector.GetHandle("automaticallyAdjustsContentInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBorderType = "borderType";

	private static readonly IntPtr selBorderTypeHandle = Selector.GetHandle("borderType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentInsets = "contentInsets";

	private static readonly IntPtr selContentInsetsHandle = Selector.GetHandle("contentInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentSize = "contentSize";

	private static readonly IntPtr selContentSizeHandle = Selector.GetHandle("contentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentSizeForFrameSize_HasHorizontalScroller_HasVerticalScroller_BorderType_ = "contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:";

	private static readonly IntPtr selContentSizeForFrameSize_HasHorizontalScroller_HasVerticalScroller_BorderType_Handle = Selector.GetHandle("contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentSizeForFrameSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_ = "contentSizeForFrameSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:";

	private static readonly IntPtr selContentSizeForFrameSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_Handle = Selector.GetHandle("contentSizeForFrameSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentView = "contentView";

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentCursor = "documentCursor";

	private static readonly IntPtr selDocumentCursorHandle = Selector.GetHandle("documentCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentView = "documentView";

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentVisibleRect = "documentVisibleRect";

	private static readonly IntPtr selDocumentVisibleRectHandle = Selector.GetHandle("documentVisibleRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindBarPosition = "findBarPosition";

	private static readonly IntPtr selFindBarPositionHandle = Selector.GetHandle("findBarPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindBarView = "findBarView";

	private static readonly IntPtr selFindBarViewHandle = Selector.GetHandle("findBarView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindBarViewDidChangeHeight = "findBarViewDidChangeHeight";

	private static readonly IntPtr selFindBarViewDidChangeHeightHandle = Selector.GetHandle("findBarViewDidChangeHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlashScrollers = "flashScrollers";

	private static readonly IntPtr selFlashScrollersHandle = Selector.GetHandle("flashScrollers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameSizeForContentSize_HasHorizontalScroller_HasVerticalScroller_BorderType_ = "frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:";

	private static readonly IntPtr selFrameSizeForContentSize_HasHorizontalScroller_HasVerticalScroller_BorderType_Handle = Selector.GetHandle("frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameSizeForContentSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_ = "frameSizeForContentSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:";

	private static readonly IntPtr selFrameSizeForContentSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_Handle = Selector.GetHandle("frameSizeForContentSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasHorizontalRuler = "hasHorizontalRuler";

	private static readonly IntPtr selHasHorizontalRulerHandle = Selector.GetHandle("hasHorizontalRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasHorizontalScroller = "hasHorizontalScroller";

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasVerticalRuler = "hasVerticalRuler";

	private static readonly IntPtr selHasVerticalRulerHandle = Selector.GetHandle("hasVerticalRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasVerticalScroller = "hasVerticalScroller";

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalLineScroll = "horizontalLineScroll";

	private static readonly IntPtr selHorizontalLineScrollHandle = Selector.GetHandle("horizontalLineScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalPageScroll = "horizontalPageScroll";

	private static readonly IntPtr selHorizontalPageScrollHandle = Selector.GetHandle("horizontalPageScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalRulerView = "horizontalRulerView";

	private static readonly IntPtr selHorizontalRulerViewHandle = Selector.GetHandle("horizontalRulerView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalScrollElasticity = "horizontalScrollElasticity";

	private static readonly IntPtr selHorizontalScrollElasticityHandle = Selector.GetHandle("horizontalScrollElasticity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalScroller = "horizontalScroller";

	private static readonly IntPtr selHorizontalScrollerHandle = Selector.GetHandle("horizontalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFindBarVisible = "isFindBarVisible";

	private static readonly IntPtr selIsFindBarVisibleHandle = Selector.GetHandle("isFindBarVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineScroll = "lineScroll";

	private static readonly IntPtr selLineScrollHandle = Selector.GetHandle("lineScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnification = "magnification";

	private static readonly IntPtr selMagnificationHandle = Selector.GetHandle("magnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnifyToFitRect_ = "magnifyToFitRect:";

	private static readonly IntPtr selMagnifyToFitRect_Handle = Selector.GetHandle("magnifyToFitRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxMagnification = "maxMagnification";

	private static readonly IntPtr selMaxMagnificationHandle = Selector.GetHandle("maxMagnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinMagnification = "minMagnification";

	private static readonly IntPtr selMinMagnificationHandle = Selector.GetHandle("minMagnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageScroll = "pageScroll";

	private static readonly IntPtr selPageScrollHandle = Selector.GetHandle("pageScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReflectScrolledClipView_ = "reflectScrolledClipView:";

	private static readonly IntPtr selReflectScrolledClipView_Handle = Selector.GetHandle("reflectScrolledClipView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulersVisible = "rulersVisible";

	private static readonly IntPtr selRulersVisibleHandle = Selector.GetHandle("rulersVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollWheel_ = "scrollWheel:";

	private static readonly IntPtr selScrollWheel_Handle = Selector.GetHandle("scrollWheel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerInsets = "scrollerInsets";

	private static readonly IntPtr selScrollerInsetsHandle = Selector.GetHandle("scrollerInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerKnobStyle = "scrollerKnobStyle";

	private static readonly IntPtr selScrollerKnobStyleHandle = Selector.GetHandle("scrollerKnobStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerStyle = "scrollerStyle";

	private static readonly IntPtr selScrollerStyleHandle = Selector.GetHandle("scrollerStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollsDynamically = "scrollsDynamically";

	private static readonly IntPtr selScrollsDynamicallyHandle = Selector.GetHandle("scrollsDynamically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMagnification_ = "setAllowsMagnification:";

	private static readonly IntPtr selSetAllowsMagnification_Handle = Selector.GetHandle("setAllowsMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutohidesScrollers_ = "setAutohidesScrollers:";

	private static readonly IntPtr selSetAutohidesScrollers_Handle = Selector.GetHandle("setAutohidesScrollers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyAdjustsContentInsets_ = "setAutomaticallyAdjustsContentInsets:";

	private static readonly IntPtr selSetAutomaticallyAdjustsContentInsets_Handle = Selector.GetHandle("setAutomaticallyAdjustsContentInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderType_ = "setBorderType:";

	private static readonly IntPtr selSetBorderType_Handle = Selector.GetHandle("setBorderType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentInsets_ = "setContentInsets:";

	private static readonly IntPtr selSetContentInsets_Handle = Selector.GetHandle("setContentInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentView_ = "setContentView:";

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentCursor_ = "setDocumentCursor:";

	private static readonly IntPtr selSetDocumentCursor_Handle = Selector.GetHandle("setDocumentCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentView_ = "setDocumentView:";

	private static readonly IntPtr selSetDocumentView_Handle = Selector.GetHandle("setDocumentView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFindBarPosition_ = "setFindBarPosition:";

	private static readonly IntPtr selSetFindBarPosition_Handle = Selector.GetHandle("setFindBarPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFindBarView_ = "setFindBarView:";

	private static readonly IntPtr selSetFindBarView_Handle = Selector.GetHandle("setFindBarView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFindBarVisible_ = "setFindBarVisible:";

	private static readonly IntPtr selSetFindBarVisible_Handle = Selector.GetHandle("setFindBarVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasHorizontalRuler_ = "setHasHorizontalRuler:";

	private static readonly IntPtr selSetHasHorizontalRuler_Handle = Selector.GetHandle("setHasHorizontalRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasHorizontalScroller_ = "setHasHorizontalScroller:";

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasVerticalRuler_ = "setHasVerticalRuler:";

	private static readonly IntPtr selSetHasVerticalRuler_Handle = Selector.GetHandle("setHasVerticalRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasVerticalScroller_ = "setHasVerticalScroller:";

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalLineScroll_ = "setHorizontalLineScroll:";

	private static readonly IntPtr selSetHorizontalLineScroll_Handle = Selector.GetHandle("setHorizontalLineScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalPageScroll_ = "setHorizontalPageScroll:";

	private static readonly IntPtr selSetHorizontalPageScroll_Handle = Selector.GetHandle("setHorizontalPageScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalRulerView_ = "setHorizontalRulerView:";

	private static readonly IntPtr selSetHorizontalRulerView_Handle = Selector.GetHandle("setHorizontalRulerView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalScrollElasticity_ = "setHorizontalScrollElasticity:";

	private static readonly IntPtr selSetHorizontalScrollElasticity_Handle = Selector.GetHandle("setHorizontalScrollElasticity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalScroller_ = "setHorizontalScroller:";

	private static readonly IntPtr selSetHorizontalScroller_Handle = Selector.GetHandle("setHorizontalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineScroll_ = "setLineScroll:";

	private static readonly IntPtr selSetLineScroll_Handle = Selector.GetHandle("setLineScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnification_ = "setMagnification:";

	private static readonly IntPtr selSetMagnification_Handle = Selector.GetHandle("setMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnification_CenteredAtPoint_ = "setMagnification:centeredAtPoint:";

	private static readonly IntPtr selSetMagnification_CenteredAtPoint_Handle = Selector.GetHandle("setMagnification:centeredAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxMagnification_ = "setMaxMagnification:";

	private static readonly IntPtr selSetMaxMagnification_Handle = Selector.GetHandle("setMaxMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinMagnification_ = "setMinMagnification:";

	private static readonly IntPtr selSetMinMagnification_Handle = Selector.GetHandle("setMinMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPageScroll_ = "setPageScroll:";

	private static readonly IntPtr selSetPageScroll_Handle = Selector.GetHandle("setPageScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRulersVisible_ = "setRulersVisible:";

	private static readonly IntPtr selSetRulersVisible_Handle = Selector.GetHandle("setRulersVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollerInsets_ = "setScrollerInsets:";

	private static readonly IntPtr selSetScrollerInsets_Handle = Selector.GetHandle("setScrollerInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollerKnobStyle_ = "setScrollerKnobStyle:";

	private static readonly IntPtr selSetScrollerKnobStyle_Handle = Selector.GetHandle("setScrollerKnobStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollerStyle_ = "setScrollerStyle:";

	private static readonly IntPtr selSetScrollerStyle_Handle = Selector.GetHandle("setScrollerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollsDynamically_ = "setScrollsDynamically:";

	private static readonly IntPtr selSetScrollsDynamically_Handle = Selector.GetHandle("setScrollsDynamically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesPredominantAxisScrolling_ = "setUsesPredominantAxisScrolling:";

	private static readonly IntPtr selSetUsesPredominantAxisScrolling_Handle = Selector.GetHandle("setUsesPredominantAxisScrolling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalLineScroll_ = "setVerticalLineScroll:";

	private static readonly IntPtr selSetVerticalLineScroll_Handle = Selector.GetHandle("setVerticalLineScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalPageScroll_ = "setVerticalPageScroll:";

	private static readonly IntPtr selSetVerticalPageScroll_Handle = Selector.GetHandle("setVerticalPageScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalRulerView_ = "setVerticalRulerView:";

	private static readonly IntPtr selSetVerticalRulerView_Handle = Selector.GetHandle("setVerticalRulerView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalScrollElasticity_ = "setVerticalScrollElasticity:";

	private static readonly IntPtr selSetVerticalScrollElasticity_Handle = Selector.GetHandle("setVerticalScrollElasticity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalScroller_ = "setVerticalScroller:";

	private static readonly IntPtr selSetVerticalScroller_Handle = Selector.GetHandle("setVerticalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTile = "tile";

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesPredominantAxisScrolling = "usesPredominantAxisScrolling";

	private static readonly IntPtr selUsesPredominantAxisScrollingHandle = Selector.GetHandle("usesPredominantAxisScrolling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalLineScroll = "verticalLineScroll";

	private static readonly IntPtr selVerticalLineScrollHandle = Selector.GetHandle("verticalLineScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalPageScroll = "verticalPageScroll";

	private static readonly IntPtr selVerticalPageScrollHandle = Selector.GetHandle("verticalPageScroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalRulerView = "verticalRulerView";

	private static readonly IntPtr selVerticalRulerViewHandle = Selector.GetHandle("verticalRulerView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalScrollElasticity = "verticalScrollElasticity";

	private static readonly IntPtr selVerticalScrollElasticityHandle = Selector.GetHandle("verticalScrollElasticity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalScroller = "verticalScroller";

	private static readonly IntPtr selVerticalScrollerHandle = Selector.GetHandle("verticalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScrollView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndLiveMagnifyNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndLiveScrollNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidLiveScrollNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillStartLiveMagnifyNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillStartLiveScrollNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMagnification
	{
		[Export("allowsMagnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMagnificationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMagnificationHandle);
		}
		[Export("setAllowsMagnification:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutohidesScrollers
	{
		[Export("autohidesScrollers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollersHandle);
		}
		[Export("setAutohidesScrollers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScrollers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScrollers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AutomaticallyAdjustsContentInsets
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("automaticallyAdjustsContentInsets")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyAdjustsContentInsetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyAdjustsContentInsetsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAutomaticallyAdjustsContentInsets:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyAdjustsContentInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyAdjustsContentInsets_Handle, value);
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
	public virtual NSBorderType BorderType
	{
		[Export("borderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBorderType)Messaging.UInt64_objc_msgSend(base.Handle, selBorderTypeHandle);
			}
			return (NSBorderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBorderTypeHandle);
		}
		[Export("setBorderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBorderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBorderType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSEdgeInsets ContentInsets
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contentInsets", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selContentInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentInsetsHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setContentInsets:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetContentInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetContentInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentSize
	{
		[Export("contentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSClipView ContentView
	{
		[Export("contentView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSClipView>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle));
			}
			return Runtime.GetNSObject<NSClipView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle));
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
	public virtual NSCursor DocumentCursor
	{
		[Export("documentCursor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentCursorHandle));
			}
			return Runtime.GetNSObject<NSCursor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentCursorHandle));
		}
		[Export("setDocumentCursor:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentCursor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentCursor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? DocumentView
	{
		[Export("documentView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle));
		}
		[Export("setDocumentView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect DocumentVisibleRect
	{
		[Export("documentVisibleRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selDocumentVisibleRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDocumentVisibleRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual NSScrollViewFindBarPosition FindBarPosition
	{
		[Export("findBarPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollViewFindBarPosition)Messaging.Int64_objc_msgSend(base.Handle, selFindBarPositionHandle);
			}
			return (NSScrollViewFindBarPosition)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFindBarPositionHandle);
		}
		[Export("setFindBarPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFindBarPosition_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFindBarPosition_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView FindBarView
	{
		[Export("findBarView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selFindBarViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFindBarViewHandle));
		}
		[Export("setFindBarView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFindBarView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFindBarView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FindBarVisible
	{
		[Export("isFindBarVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFindBarVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFindBarVisibleHandle);
		}
		[Export("setFindBarVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFindBarVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFindBarVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasHorizontalRuler
	{
		[Export("hasHorizontalRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalRulerHandle);
		}
		[Export("setHasHorizontalRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalRuler_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasVerticalRuler
	{
		[Export("hasVerticalRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalRulerHandle);
		}
		[Export("setHasVerticalRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalRuler_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat HorizontalLineScroll
	{
		[Export("horizontalLineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHorizontalLineScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHorizontalLineScrollHandle);
		}
		[Export("setHorizontalLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetHorizontalLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetHorizontalLineScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat HorizontalPageScroll
	{
		[Export("horizontalPageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHorizontalPageScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHorizontalPageScrollHandle);
		}
		[Export("setHorizontalPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetHorizontalPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetHorizontalPageScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRulerView HorizontalRulerView
	{
		[Export("horizontalRulerView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSend(base.Handle, selHorizontalRulerViewHandle));
			}
			return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHorizontalRulerViewHandle));
		}
		[Export("setHorizontalRulerView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHorizontalRulerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHorizontalRulerView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollElasticity HorizontalScrollElasticity
	{
		[Export("horizontalScrollElasticity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollElasticity)Messaging.Int64_objc_msgSend(base.Handle, selHorizontalScrollElasticityHandle);
			}
			return (NSScrollElasticity)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHorizontalScrollElasticityHandle);
		}
		[Export("setHorizontalScrollElasticity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHorizontalScrollElasticity_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHorizontalScrollElasticity_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScroller HorizontalScroller
	{
		[Export("horizontalScroller", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScroller>(Messaging.IntPtr_objc_msgSend(base.Handle, selHorizontalScrollerHandle));
			}
			return Runtime.GetNSObject<NSScroller>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHorizontalScrollerHandle));
		}
		[Export("setHorizontalScroller:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHorizontalScroller_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHorizontalScroller_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineScroll
	{
		[Export("lineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineScrollHandle);
		}
		[Export("setLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Magnification
	{
		[Export("magnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMagnificationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMagnificationHandle);
		}
		[Export("setMagnification:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaxMagnification
	{
		[Export("maxMagnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaxMagnificationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaxMagnificationHandle);
		}
		[Export("setMaxMagnification:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaxMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaxMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinMagnification
	{
		[Export("minMagnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinMagnificationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinMagnificationHandle);
		}
		[Export("setMinMagnification:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PageScroll
	{
		[Export("pageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPageScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPageScrollHandle);
		}
		[Export("setPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPageScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RulersVisible
	{
		[Export("rulersVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRulersVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRulersVisibleHandle);
		}
		[Export("setRulersVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRulersVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRulersVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSEdgeInsets ScrollerInsets
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("scrollerInsets", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selScrollerInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selScrollerInsetsHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setScrollerInsets:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetScrollerInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetScrollerInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollerKnobStyle ScrollerKnobStyle
	{
		[Export("scrollerKnobStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerKnobStyleHandle);
			}
			return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerKnobStyleHandle);
		}
		[Export("setScrollerKnobStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerKnobStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerKnobStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollerStyle ScrollerStyle
	{
		[Export("scrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollerStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerStyleHandle);
			}
			return (NSScrollerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerStyleHandle);
		}
		[Export("setScrollerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ScrollsDynamically
	{
		[Export("scrollsDynamically")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selScrollsDynamicallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selScrollsDynamicallyHandle);
		}
		[Export("setScrollsDynamically:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollsDynamically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollsDynamically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesPredominantAxisScrolling
	{
		[Export("usesPredominantAxisScrolling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesPredominantAxisScrollingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesPredominantAxisScrollingHandle);
		}
		[Export("setUsesPredominantAxisScrolling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesPredominantAxisScrolling_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesPredominantAxisScrolling_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat VerticalLineScroll
	{
		[Export("verticalLineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selVerticalLineScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selVerticalLineScrollHandle);
		}
		[Export("setVerticalLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetVerticalLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetVerticalLineScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat VerticalPageScroll
	{
		[Export("verticalPageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selVerticalPageScrollHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selVerticalPageScrollHandle);
		}
		[Export("setVerticalPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetVerticalPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetVerticalPageScroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRulerView VerticalRulerView
	{
		[Export("verticalRulerView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalRulerViewHandle));
			}
			return Runtime.GetNSObject<NSRulerView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalRulerViewHandle));
		}
		[Export("setVerticalRulerView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVerticalRulerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVerticalRulerView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollElasticity VerticalScrollElasticity
	{
		[Export("verticalScrollElasticity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollElasticity)Messaging.Int64_objc_msgSend(base.Handle, selVerticalScrollElasticityHandle);
			}
			return (NSScrollElasticity)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVerticalScrollElasticityHandle);
		}
		[Export("setVerticalScrollElasticity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVerticalScrollElasticity_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVerticalScrollElasticity_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScroller VerticalScroller
	{
		[Export("verticalScroller", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScroller>(Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalScrollerHandle));
			}
			return Runtime.GetNSObject<NSScroller>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalScrollerHandle));
		}
		[Export("setVerticalScroller:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVerticalScroller_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVerticalScroller_Handle, value.Handle);
			}
		}
	}

	[Field("NSScrollViewDidEndLiveMagnifyNotification", "AppKit")]
	[Advice("Use NSScrollView.Notifications.ObserveDidEndLiveMagnify helper method instead.")]
	public static NSString DidEndLiveMagnifyNotification
	{
		get
		{
			if (_DidEndLiveMagnifyNotification == null)
			{
				_DidEndLiveMagnifyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScrollViewDidEndLiveMagnifyNotification");
			}
			return _DidEndLiveMagnifyNotification;
		}
	}

	[Field("NSScrollViewDidEndLiveScrollNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use NSScrollView.Notifications.ObserveDidEndLiveScroll helper method instead.")]
	public static NSString DidEndLiveScrollNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DidEndLiveScrollNotification == null)
			{
				_DidEndLiveScrollNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScrollViewDidEndLiveScrollNotification");
			}
			return _DidEndLiveScrollNotification;
		}
	}

	[Field("NSScrollViewDidLiveScrollNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use NSScrollView.Notifications.ObserveDidLiveScroll helper method instead.")]
	public static NSString DidLiveScrollNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DidLiveScrollNotification == null)
			{
				_DidLiveScrollNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScrollViewDidLiveScrollNotification");
			}
			return _DidLiveScrollNotification;
		}
	}

	[Field("NSScrollViewWillStartLiveMagnifyNotification", "AppKit")]
	[Advice("Use NSScrollView.Notifications.ObserveWillStartLiveMagnify helper method instead.")]
	public static NSString WillStartLiveMagnifyNotification
	{
		get
		{
			if (_WillStartLiveMagnifyNotification == null)
			{
				_WillStartLiveMagnifyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScrollViewWillStartLiveMagnifyNotification");
			}
			return _WillStartLiveMagnifyNotification;
		}
	}

	[Field("NSScrollViewWillStartLiveScrollNotification", "AppKit")]
	[Advice("Use NSScrollView.Notifications.ObserveWillStartLiveScroll helper method instead.")]
	public static NSString WillStartLiveScrollNotification
	{
		get
		{
			if (_WillStartLiveScrollNotification == null)
			{
				_WillStartLiveScrollNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScrollViewWillStartLiveScrollNotification");
			}
			return _WillStartLiveScrollNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScrollView()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSScrollView(NSCoder coder)
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
	protected NSScrollView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScrollView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSScrollView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("addFloatingSubview:forAxis:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddFloatingSubview(NSView view, NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddFloatingSubview_ForAxis_Handle, view.Handle, (long)axis);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddFloatingSubview_ForAxis_Handle, view.Handle, (long)axis);
		}
	}

	[Export("contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize ContentSizeForFrame(CGSize fSize, bool hFlag, bool vFlag, NSBorderType aType)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_bool_bool_UInt64(class_ptr, selContentSizeForFrameSize_HasHorizontalScroller_HasVerticalScroller_BorderType_Handle, fSize, hFlag, vFlag, (ulong)aType);
	}

	[Export("findBarViewDidChangeHeight")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindBarViewDidChangeHeight()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFindBarViewDidChangeHeightHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFindBarViewDidChangeHeightHandle);
		}
	}

	[Export("flashScrollers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlashScrollers()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlashScrollersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlashScrollersHandle);
		}
	}

	[Export("frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize FrameSizeForContentSize(CGSize cSize, bool hFlag, bool vFlag, NSBorderType aType)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_bool_bool_UInt64(class_ptr, selFrameSizeForContentSize_HasHorizontalScroller_HasVerticalScroller_BorderType_Handle, cSize, hFlag, vFlag, (ulong)aType);
	}

	[Export("contentSizeForFrameSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize GetContentSizeForFrame(CGSize forFrameSize, Class? horizontalScrollerClass, Class? verticalScrollerClass, NSBorderType borderType, NSControlSize controlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(class_ptr, selContentSizeForFrameSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_Handle, forFrameSize, horizontalScrollerClass?.Handle ?? IntPtr.Zero, verticalScrollerClass?.Handle ?? IntPtr.Zero, (ulong)borderType, (ulong)controlSize, (long)scrollerStyle);
	}

	[Export("frameSizeForContentSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize GetFrameSizeForContent(CGSize contentSize, Class? horizontalScrollerClass, Class? verticalScrollerClass, NSBorderType borderType, NSControlSize controlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(class_ptr, selFrameSizeForContentSize_HorizontalScrollerClass_VerticalScrollerClass_BorderType_ControlSize_ScrollerStyle_Handle, contentSize, horizontalScrollerClass?.Handle ?? IntPtr.Zero, verticalScrollerClass?.Handle ?? IntPtr.Zero, (ulong)borderType, (ulong)controlSize, (long)scrollerStyle);
	}

	[Export("magnifyToFitRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MagnifyToFitRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selMagnifyToFitRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selMagnifyToFitRect_Handle, rect);
		}
	}

	[Export("reflectScrolledClipView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReflectScrolledClipView(NSClipView cView)
	{
		NSApplication.EnsureUIThread();
		if (cView == null)
		{
			throw new ArgumentNullException("cView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReflectScrolledClipView_Handle, cView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReflectScrolledClipView_Handle, cView.Handle);
		}
	}

	[Export("scrollWheel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ScrollWheel(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollWheel_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollWheel_Handle, theEvent.Handle);
		}
	}

	[Export("setMagnification:centeredAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMagnification(nfloat magnification, CGPoint centeredAtPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_CGPoint(base.Handle, selSetMagnification_CenteredAtPoint_Handle, magnification, centeredAtPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_CGPoint(base.SuperHandle, selSetMagnification_CenteredAtPoint_Handle, magnification, centeredAtPoint);
		}
	}

	[Export("tile")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Tile()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTileHandle);
		}
	}
}
