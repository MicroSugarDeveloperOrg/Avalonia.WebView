using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextAttachmentCell", true)]
public class NSTextAttachmentCell : NSCell
{
	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	private static readonly IntPtr selCellBaselineOffsetHandle = Selector.GetHandle("cellBaselineOffset");

	private static readonly IntPtr selAttachmentHandle = Selector.GetHandle("attachment");

	private static readonly IntPtr selSetAttachment_Handle = Selector.GetHandle("setAttachment:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selWantsToTrackMouseHandle = Selector.GetHandle("wantsToTrackMouse");

	private static readonly IntPtr selHighlightWithFrameInView_Handle = Selector.GetHandle("highlight:withFrame:inView:");

	private static readonly IntPtr selTrackMouseInRectOfViewUntilMouseUp_Handle = Selector.GetHandle("trackMouse:inRect:ofView:untilMouseUp:");

	private static readonly IntPtr selDrawWithFrameInViewCharacterIndex_Handle = Selector.GetHandle("drawWithFrame:inView:characterIndex:");

	private static readonly IntPtr selDrawWithFrameInViewCharacterIndexLayoutManager_Handle = Selector.GetHandle("drawWithFrame:inView:characterIndex:layoutManager:");

	private static readonly IntPtr selWantsToTrackMouseForEventInRectOfViewAtCharacterIndex_Handle = Selector.GetHandle("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:");

	private static readonly IntPtr selTrackMouseInRectOfViewAtCharacterIndexUntilMouseUp_Handle = Selector.GetHandle("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:");

	private static readonly IntPtr selCellFrameForTextContainerProposedLineFragmentGlyphPositionCharacterIndex_Handle = Selector.GetHandle("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextAttachmentCell");

	private object __mt_Attachment_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
	}

	public virtual CGPoint CellBaselineOffset
	{
		[Export("cellBaselineOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCellBaselineOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCellBaselineOffsetHandle);
		}
	}

	public virtual NSTextAttachment Attachment
	{
		[Export("attachment")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextAttachment)(__mt_Attachment_var = ((!IsDirectBinding) ? ((NSTextAttachment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachmentHandle))) : ((NSTextAttachment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachmentHandle)))));
		}
		[Export("setAttachment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttachment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttachment_Handle, value.Handle);
			}
			__mt_Attachment_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextAttachmentCell()
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
	public NSTextAttachmentCell(NSCoder coder)
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
	public NSTextAttachmentCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextAttachmentCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initImageCell:")]
	public NSTextAttachmentCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("wantsToTrackMouse")]
	public virtual bool WantsToTrackMouse()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selWantsToTrackMouseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsToTrackMouseHandle);
	}

	[Export("highlight:withFrame:inView:")]
	public new virtual void Highlight(bool highlight, CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_CGRect_IntPtr(base.Handle, selHighlightWithFrameInView_Handle, highlight, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_CGRect_IntPtr(base.SuperHandle, selHighlightWithFrameInView_Handle, highlight, cellFrame, controlView.Handle);
		}
	}

	[Export("trackMouse:inRect:ofView:untilMouseUp:")]
	public new virtual bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool(base.Handle, selTrackMouseInRectOfViewUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool(base.SuperHandle, selTrackMouseInRectOfViewUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
	}

	[Export("drawWithFrame:inView:characterIndex:")]
	public virtual void DrawWithFrame(CGRect cellFrame, NSView controlView, ulong charIndex)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_UInt64(base.Handle, selDrawWithFrameInViewCharacterIndex_Handle, cellFrame, controlView.Handle, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_UInt64(base.SuperHandle, selDrawWithFrameInViewCharacterIndex_Handle, cellFrame, controlView.Handle, charIndex);
		}
	}

	[Export("drawWithFrame:inView:characterIndex:layoutManager:")]
	public virtual void DrawWithFrame(CGRect cellFrame, NSView controlView, ulong charIndex, NSLayoutManager layoutManager)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_UInt64_IntPtr(base.Handle, selDrawWithFrameInViewCharacterIndexLayoutManager_Handle, cellFrame, controlView.Handle, charIndex, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_UInt64_IntPtr(base.SuperHandle, selDrawWithFrameInViewCharacterIndexLayoutManager_Handle, cellFrame, controlView.Handle, charIndex, layoutManager.Handle);
		}
	}

	[Export("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:")]
	public virtual bool WantsToTrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, ulong charIndex)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_UInt64(base.Handle, selWantsToTrackMouseForEventInRectOfViewAtCharacterIndex_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_UInt64(base.SuperHandle, selWantsToTrackMouseForEventInRectOfViewAtCharacterIndex_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex);
	}

	[Export("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:")]
	public virtual bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, ulong charIndex, bool untilMouseUp)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_UInt64_bool(base.Handle, selTrackMouseInRectOfViewAtCharacterIndexUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex, untilMouseUp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_UInt64_bool(base.SuperHandle, selTrackMouseInRectOfViewAtCharacterIndexUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex, untilMouseUp);
	}

	[Export("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	public virtual CGRect CellFrameForTextContainer(NSTextContainer textContainer, CGRect lineFrag, CGPoint position, ulong charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGPoint_UInt64(out retval, base.Handle, selCellFrameForTextContainerProposedLineFragmentGlyphPositionCharacterIndex_Handle, textContainer.Handle, lineFrag, position, charIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGPoint_UInt64(out retval, base.SuperHandle, selCellFrameForTextContainerProposedLineFragmentGlyphPositionCharacterIndex_Handle, textContainer.Handle, lineFrag, position, charIndex);
		}
		return retval;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Attachment_var = null;
		}
	}
}
