using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSScrollView", true)]
public class NSScrollView : NSView
{
	private static readonly IntPtr selDocumentVisibleRectHandle = Selector.GetHandle("documentVisibleRect");

	private static readonly IntPtr selContentSizeHandle = Selector.GetHandle("contentSize");

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	private static readonly IntPtr selSetDocumentView_Handle = Selector.GetHandle("setDocumentView:");

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	private static readonly IntPtr selDocumentCursorHandle = Selector.GetHandle("documentCursor");

	private static readonly IntPtr selSetDocumentCursor_Handle = Selector.GetHandle("setDocumentCursor:");

	private static readonly IntPtr selBorderTypeHandle = Selector.GetHandle("borderType");

	private static readonly IntPtr selSetBorderType_Handle = Selector.GetHandle("setBorderType:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	private static readonly IntPtr selVerticalScrollerHandle = Selector.GetHandle("verticalScroller");

	private static readonly IntPtr selSetVerticalScroller_Handle = Selector.GetHandle("setVerticalScroller:");

	private static readonly IntPtr selHorizontalScrollerHandle = Selector.GetHandle("horizontalScroller");

	private static readonly IntPtr selSetHorizontalScroller_Handle = Selector.GetHandle("setHorizontalScroller:");

	private static readonly IntPtr selAutohidesScrollersHandle = Selector.GetHandle("autohidesScrollers");

	private static readonly IntPtr selSetAutohidesScrollers_Handle = Selector.GetHandle("setAutohidesScrollers:");

	private static readonly IntPtr selHorizontalLineScrollHandle = Selector.GetHandle("horizontalLineScroll");

	private static readonly IntPtr selSetHorizontalLineScroll_Handle = Selector.GetHandle("setHorizontalLineScroll:");

	private static readonly IntPtr selVerticalLineScrollHandle = Selector.GetHandle("verticalLineScroll");

	private static readonly IntPtr selSetVerticalLineScroll_Handle = Selector.GetHandle("setVerticalLineScroll:");

	private static readonly IntPtr selLineScrollHandle = Selector.GetHandle("lineScroll");

	private static readonly IntPtr selSetLineScroll_Handle = Selector.GetHandle("setLineScroll:");

	private static readonly IntPtr selHorizontalPageScrollHandle = Selector.GetHandle("horizontalPageScroll");

	private static readonly IntPtr selSetHorizontalPageScroll_Handle = Selector.GetHandle("setHorizontalPageScroll:");

	private static readonly IntPtr selVerticalPageScrollHandle = Selector.GetHandle("verticalPageScroll");

	private static readonly IntPtr selSetVerticalPageScroll_Handle = Selector.GetHandle("setVerticalPageScroll:");

	private static readonly IntPtr selPageScrollHandle = Selector.GetHandle("pageScroll");

	private static readonly IntPtr selSetPageScroll_Handle = Selector.GetHandle("setPageScroll:");

	private static readonly IntPtr selScrollsDynamicallyHandle = Selector.GetHandle("scrollsDynamically");

	private static readonly IntPtr selSetScrollsDynamically_Handle = Selector.GetHandle("setScrollsDynamically:");

	private static readonly IntPtr selHasVerticalRulerHandle = Selector.GetHandle("hasVerticalRuler");

	private static readonly IntPtr selSetHasVerticalRuler_Handle = Selector.GetHandle("setHasVerticalRuler:");

	private static readonly IntPtr selHasHorizontalRulerHandle = Selector.GetHandle("hasHorizontalRuler");

	private static readonly IntPtr selSetHasHorizontalRuler_Handle = Selector.GetHandle("setHasHorizontalRuler:");

	private static readonly IntPtr selRulersVisibleHandle = Selector.GetHandle("rulersVisible");

	private static readonly IntPtr selSetRulersVisible_Handle = Selector.GetHandle("setRulersVisible:");

	private static readonly IntPtr selHorizontalRulerViewHandle = Selector.GetHandle("horizontalRulerView");

	private static readonly IntPtr selSetHorizontalRulerView_Handle = Selector.GetHandle("setHorizontalRulerView:");

	private static readonly IntPtr selVerticalRulerViewHandle = Selector.GetHandle("verticalRulerView");

	private static readonly IntPtr selSetVerticalRulerView_Handle = Selector.GetHandle("setVerticalRulerView:");

	private static readonly IntPtr selFindBarPositionHandle = Selector.GetHandle("findBarPosition");

	private static readonly IntPtr selSetFindBarPosition_Handle = Selector.GetHandle("setFindBarPosition:");

	private static readonly IntPtr selHorizontalScrollElasticityHandle = Selector.GetHandle("horizontalScrollElasticity");

	private static readonly IntPtr selSetHorizontalScrollElasticity_Handle = Selector.GetHandle("setHorizontalScrollElasticity:");

	private static readonly IntPtr selScrollerKnobStyleHandle = Selector.GetHandle("scrollerKnobStyle");

	private static readonly IntPtr selSetScrollerKnobStyle_Handle = Selector.GetHandle("setScrollerKnobStyle:");

	private static readonly IntPtr selScrollerStyleHandle = Selector.GetHandle("scrollerStyle");

	private static readonly IntPtr selSetScrollerStyle_Handle = Selector.GetHandle("setScrollerStyle:");

	private static readonly IntPtr selUsesPredominantAxisScrollingHandle = Selector.GetHandle("usesPredominantAxisScrolling");

	private static readonly IntPtr selSetUsesPredominantAxisScrolling_Handle = Selector.GetHandle("setUsesPredominantAxisScrolling:");

	private static readonly IntPtr selVerticalScrollElasticityHandle = Selector.GetHandle("verticalScrollElasticity");

	private static readonly IntPtr selSetVerticalScrollElasticity_Handle = Selector.GetHandle("setVerticalScrollElasticity:");

	private static readonly IntPtr selIsFindBarVisibleHandle = Selector.GetHandle("isFindBarVisible");

	private static readonly IntPtr selSetFindBarVisible_Handle = Selector.GetHandle("setFindBarVisible:");

	private static readonly IntPtr selFindBarViewHandle = Selector.GetHandle("findBarView");

	private static readonly IntPtr selSetFindBarView_Handle = Selector.GetHandle("setFindBarView:");

	private static readonly IntPtr selFrameSizeForContentSizeHasHorizontalScrollerHasVerticalScrollerBorderType_Handle = Selector.GetHandle("frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:");

	private static readonly IntPtr selContentSizeForFrameSizeHasHorizontalScrollerHasVerticalScrollerBorderType_Handle = Selector.GetHandle("contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	private static readonly IntPtr selReflectScrolledClipView_Handle = Selector.GetHandle("reflectScrolledClipView:");

	private static readonly IntPtr selScrollWheel_Handle = Selector.GetHandle("scrollWheel:");

	private static readonly IntPtr selContentSizeForFrameSizeHorizontalScrollerClassVerticalScrollerClassBorderTypeControlSizeScrollerStyle_Handle = Selector.GetHandle("contentSizeForFrameSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:");

	private static readonly IntPtr selFlashScrollersHandle = Selector.GetHandle("flashScrollers");

	private static readonly IntPtr selFrameSizeForContentSizeHorizontalScrollerClassVerticalScrollerClassBorderTypeControlSizeScrollerStyle_Handle = Selector.GetHandle("frameSizeForContentSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:");

	private static readonly IntPtr selFindBarViewDidChangeHeightHandle = Selector.GetHandle("findBarViewDidChangeHeight");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSScrollView");

	private object __mt_DocumentView_var;

	private object __mt_ContentView_var;

	private object __mt_DocumentCursor_var;

	private object __mt_BackgroundColor_var;

	private object __mt_VerticalScroller_var;

	private object __mt_HorizontalScroller_var;

	private object __mt_HorizontalRulerView_var;

	private object __mt_VerticalRulerView_var;

	private object __mt_FindBarView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGRect DocumentVisibleRect
	{
		[Export("documentVisibleRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGSize ContentSize
	{
		[Export("contentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentSizeHandle);
		}
	}

	public virtual NSObject DocumentView
	{
		[Export("documentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_DocumentView_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle))));
		}
		[Export("setDocumentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentView_Handle, value.Handle);
			}
			__mt_DocumentView_var = value;
		}
	}

	public virtual NSClipView ContentView
	{
		[Export("contentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSClipView)(__mt_ContentView_var = ((!IsDirectBinding) ? ((NSClipView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle))) : ((NSClipView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle)))));
		}
		[Export("setContentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value.Handle);
			}
			__mt_ContentView_var = value;
		}
	}

	public virtual NSCursor DocumentCursor
	{
		[Export("documentCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_DocumentCursor_var = ((!IsDirectBinding) ? ((NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentCursorHandle))) : ((NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentCursorHandle)))));
		}
		[Export("setDocumentCursor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentCursor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentCursor_Handle, value.Handle);
			}
			__mt_DocumentCursor_var = value;
		}
	}

	public virtual NSBorderType BorderType
	{
		[Export("borderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBorderType)Messaging.UInt64_objc_msgSend(base.Handle, selBorderTypeHandle);
			}
			return (NSBorderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBorderTypeHandle);
		}
		[Export("setBorderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBorderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBorderType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	public virtual NSScroller VerticalScroller
	{
		[Export("verticalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScroller)(__mt_VerticalScroller_var = ((!IsDirectBinding) ? ((NSScroller)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalScrollerHandle))) : ((NSScroller)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalScrollerHandle)))));
		}
		[Export("setVerticalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVerticalScroller_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVerticalScroller_Handle, value.Handle);
			}
			__mt_VerticalScroller_var = value;
		}
	}

	public virtual NSScroller HorizontalScroller
	{
		[Export("horizontalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScroller)(__mt_HorizontalScroller_var = ((!IsDirectBinding) ? ((NSScroller)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHorizontalScrollerHandle))) : ((NSScroller)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHorizontalScrollerHandle)))));
		}
		[Export("setHorizontalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHorizontalScroller_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHorizontalScroller_Handle, value.Handle);
			}
			__mt_HorizontalScroller_var = value;
		}
	}

	public virtual bool AutohidesScrollers
	{
		[Export("autohidesScrollers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollersHandle);
		}
		[Export("setAutohidesScrollers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScrollers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScrollers_Handle, value);
			}
		}
	}

	public virtual double HorizontalLineScroll
	{
		[Export("horizontalLineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHorizontalLineScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHorizontalLineScrollHandle);
		}
		[Export("setHorizontalLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetHorizontalLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetHorizontalLineScroll_Handle, value);
			}
		}
	}

	public virtual double VerticalLineScroll
	{
		[Export("verticalLineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selVerticalLineScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selVerticalLineScrollHandle);
		}
		[Export("setVerticalLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetVerticalLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetVerticalLineScroll_Handle, value);
			}
		}
	}

	public virtual double LineScroll
	{
		[Export("lineScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLineScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLineScrollHandle);
		}
		[Export("setLineScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLineScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLineScroll_Handle, value);
			}
		}
	}

	public virtual double HorizontalPageScroll
	{
		[Export("horizontalPageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHorizontalPageScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHorizontalPageScrollHandle);
		}
		[Export("setHorizontalPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetHorizontalPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetHorizontalPageScroll_Handle, value);
			}
		}
	}

	public virtual double VerticalPageScroll
	{
		[Export("verticalPageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selVerticalPageScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selVerticalPageScrollHandle);
		}
		[Export("setVerticalPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetVerticalPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetVerticalPageScroll_Handle, value);
			}
		}
	}

	public virtual double PageScroll
	{
		[Export("pageScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPageScrollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPageScrollHandle);
		}
		[Export("setPageScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPageScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPageScroll_Handle, value);
			}
		}
	}

	public virtual bool ScrollsDynamically
	{
		[Export("scrollsDynamically")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selScrollsDynamicallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selScrollsDynamicallyHandle);
		}
		[Export("setScrollsDynamically:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollsDynamically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollsDynamically_Handle, value);
			}
		}
	}

	public virtual bool HasVerticalRuler
	{
		[Export("hasVerticalRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalRulerHandle);
		}
		[Export("setHasVerticalRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalRuler_Handle, value);
			}
		}
	}

	public virtual bool HasHorizontalRuler
	{
		[Export("hasHorizontalRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalRulerHandle);
		}
		[Export("setHasHorizontalRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalRuler_Handle, value);
			}
		}
	}

	public virtual bool RulersVisible
	{
		[Export("rulersVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRulersVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRulersVisibleHandle);
		}
		[Export("setRulersVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRulersVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRulersVisible_Handle, value);
			}
		}
	}

	public virtual NSRulerView HorizontalRulerView
	{
		[Export("horizontalRulerView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRulerView)(__mt_HorizontalRulerView_var = ((!IsDirectBinding) ? ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHorizontalRulerViewHandle))) : ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHorizontalRulerViewHandle)))));
		}
		[Export("setHorizontalRulerView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHorizontalRulerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHorizontalRulerView_Handle, value.Handle);
			}
			__mt_HorizontalRulerView_var = value;
		}
	}

	public virtual NSRulerView VerticalRulerView
	{
		[Export("verticalRulerView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRulerView)(__mt_VerticalRulerView_var = ((!IsDirectBinding) ? ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalRulerViewHandle))) : ((NSRulerView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalRulerViewHandle)))));
		}
		[Export("setVerticalRulerView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVerticalRulerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVerticalRulerView_Handle, value.Handle);
			}
			__mt_VerticalRulerView_var = value;
		}
	}

	public virtual NSScrollViewFindBarPosition FindBarPosition
	{
		[Export("findBarPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollViewFindBarPosition)Messaging.Int64_objc_msgSend(base.Handle, selFindBarPositionHandle);
			}
			return (NSScrollViewFindBarPosition)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFindBarPositionHandle);
		}
		[Export("setFindBarPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFindBarPosition_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFindBarPosition_Handle, (long)value);
			}
		}
	}

	public virtual NSScrollElasticity HorizontalScrollElasticity
	{
		[Export("horizontalScrollElasticity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollElasticity)Messaging.Int64_objc_msgSend(base.Handle, selHorizontalScrollElasticityHandle);
			}
			return (NSScrollElasticity)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHorizontalScrollElasticityHandle);
		}
		[Export("setHorizontalScrollElasticity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHorizontalScrollElasticity_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHorizontalScrollElasticity_Handle, (long)value);
			}
		}
	}

	public virtual NSScrollerKnobStyle ScrollerKnobStyle
	{
		[Export("scrollerKnobStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerKnobStyleHandle);
			}
			return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerKnobStyleHandle);
		}
		[Export("setScrollerKnobStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerKnobStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerKnobStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSScrollerStyle ScrollerStyle
	{
		[Export("scrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollerStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerStyleHandle);
			}
			return (NSScrollerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerStyleHandle);
		}
		[Export("setScrollerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerStyle_Handle, (long)value);
			}
		}
	}

	public virtual bool UsesPredominantAxisScrolling
	{
		[Export("usesPredominantAxisScrolling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesPredominantAxisScrollingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesPredominantAxisScrollingHandle);
		}
		[Export("setUsesPredominantAxisScrolling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesPredominantAxisScrolling_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesPredominantAxisScrolling_Handle, value);
			}
		}
	}

	public virtual NSScrollElasticity VerticalScrollElasticity
	{
		[Export("verticalScrollElasticity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollElasticity)Messaging.Int64_objc_msgSend(base.Handle, selVerticalScrollElasticityHandle);
			}
			return (NSScrollElasticity)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVerticalScrollElasticityHandle);
		}
		[Export("setVerticalScrollElasticity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVerticalScrollElasticity_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVerticalScrollElasticity_Handle, (long)value);
			}
		}
	}

	public virtual bool FindBarVisible
	{
		[Export("isFindBarVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFindBarVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFindBarVisibleHandle);
		}
		[Export("setFindBarVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFindBarVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFindBarVisible_Handle, value);
			}
		}
	}

	public virtual NSView FindBarView
	{
		[Export("findBarView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_FindBarView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFindBarViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFindBarViewHandle)))));
		}
		[Export("setFindBarView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFindBarView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFindBarView_Handle, value.Handle);
			}
			__mt_FindBarView_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScrollView()
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
	public NSScrollView(NSCoder coder)
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
	public NSScrollView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSScrollView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:")]
	public static CGSize FrameSizeForContentSize(CGSize cSize, bool hFlag, bool vFlag, NSBorderType aType)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_bool_bool_UInt64(class_ptr, selFrameSizeForContentSizeHasHorizontalScrollerHasVerticalScrollerBorderType_Handle, cSize, hFlag, vFlag, (ulong)aType);
	}

	[Export("contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:")]
	public static CGSize ContentSizeForFrame(CGSize fSize, bool hFlag, bool vFlag, NSBorderType aType)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize_bool_bool_UInt64(class_ptr, selContentSizeForFrameSizeHasHorizontalScrollerHasVerticalScrollerBorderType_Handle, fSize, hFlag, vFlag, (ulong)aType);
	}

	[Export("initWithFrame:")]
	public NSScrollView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("tile")]
	public virtual void Tile()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTileHandle);
		}
	}

	[Export("reflectScrolledClipView:")]
	public virtual void ReflectScrolledClipView(NSClipView cView)
	{
		NSApplication.EnsureUIThread();
		if (cView == null)
		{
			throw new ArgumentNullException("cView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReflectScrolledClipView_Handle, cView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReflectScrolledClipView_Handle, cView.Handle);
		}
	}

	[Export("scrollWheel:")]
	public new virtual void ScrollWheel(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollWheel_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollWheel_Handle, theEvent.Handle);
		}
	}

	[Export("contentSizeForFrameSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:")]
	public static CGSize GetContentSizeForFrame(CGSize forFrameSize, Class horizontalScrollerClass, Class verticalScrollerClass, NSBorderType borderType, NSControlSize controlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		if (horizontalScrollerClass == null)
		{
			throw new ArgumentNullException("horizontalScrollerClass");
		}
		if (verticalScrollerClass == null)
		{
			throw new ArgumentNullException("verticalScrollerClass");
		}
		return Messaging.CGSize_objc_msgSend_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(class_ptr, selContentSizeForFrameSizeHorizontalScrollerClassVerticalScrollerClassBorderTypeControlSizeScrollerStyle_Handle, forFrameSize, horizontalScrollerClass.Handle, verticalScrollerClass.Handle, (ulong)borderType, (ulong)controlSize, (long)scrollerStyle);
	}

	[Export("flashScrollers")]
	public virtual void FlashScrollers()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlashScrollersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlashScrollersHandle);
		}
	}

	[Export("frameSizeForContentSize:horizontalScrollerClass:verticalScrollerClass:borderType:controlSize:scrollerStyle:")]
	public static CGSize GetFrameSizeForContent(CGSize contentSize, Class horizontalScrollerClass, Class verticalScrollerClass, NSBorderType borderType, NSControlSize controlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		if (horizontalScrollerClass == null)
		{
			throw new ArgumentNullException("horizontalScrollerClass");
		}
		if (verticalScrollerClass == null)
		{
			throw new ArgumentNullException("verticalScrollerClass");
		}
		return Messaging.CGSize_objc_msgSend_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(class_ptr, selFrameSizeForContentSizeHorizontalScrollerClassVerticalScrollerClassBorderTypeControlSizeScrollerStyle_Handle, contentSize, horizontalScrollerClass.Handle, verticalScrollerClass.Handle, (ulong)borderType, (ulong)controlSize, (long)scrollerStyle);
	}

	[Export("findBarViewDidChangeHeight")]
	public virtual void FindBarViewDidChangeHeight()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFindBarViewDidChangeHeightHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFindBarViewDidChangeHeightHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DocumentView_var = null;
			__mt_ContentView_var = null;
			__mt_DocumentCursor_var = null;
			__mt_BackgroundColor_var = null;
			__mt_VerticalScroller_var = null;
			__mt_HorizontalScroller_var = null;
			__mt_HorizontalRulerView_var = null;
			__mt_VerticalRulerView_var = null;
			__mt_FindBarView_var = null;
		}
	}
}
