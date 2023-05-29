using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextViewDelegate", true)]
[Model]
public class NSTextViewDelegate : NSTextDelegate
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextViewDelegate()
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
	public NSTextViewDelegate(NSCoder coder)
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
	public NSTextViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("textView:clickedOnLink:atIndex:")]
	public virtual bool LinkClicked(NSTextView textView, NSObject link, ulong charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:clickedOnCell:inRect:atIndex:")]
	public virtual void CellClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:doubleClickedOnCell:inRect:atIndex:")]
	public virtual void CellDoubleClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:writablePasteboardTypesForCell:atIndex:")]
	public virtual string[] GetWritablePasteboardTypes(NSTextView view, NSTextAttachmentCell forCell, ulong charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:writeCell:atIndex:toPasteboard:type:")]
	public virtual bool WriteCell(NSTextView view, NSTextAttachmentCell cell, uint charIndex, NSPasteboard pboard, string type)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
	public virtual NSRange WillChangeSelection(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
	public virtual NSValue[] WillChangeSelectionFromRanges(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTextInRanges:replacementStrings:")]
	public virtual bool ShouldChangeTextInRanges(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTypingAttributes:toAttributes:")]
	public virtual NSDictionary ShouldChangeTypingAttributes(NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textViewDidChangeSelection:")]
	public virtual void DidChangeSelection(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textViewDidChangeTypingAttributes:")]
	public virtual void DidChangeTypingAttributes(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willDisplayToolTip:forCharacterAtIndex:")]
	public virtual string WillDisplayToolTip(NSTextView textView, string tooltip, ulong characterIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	public virtual string[] GetCompletions(NSTextView textView, string[] words, NSRange charRange, long index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTextInRange:replacementString:")]
	public virtual bool ShouldChangeTextInRange(NSTextView textView, NSRange affectedCharRange, string replacementString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:doCommandBySelector:")]
	public virtual bool DoCommandBySelector(NSTextView textView, Selector commandSelector)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldSetSpellingState:range:")]
	public virtual long ShouldSetSpellingState(NSTextView textView, long value, NSRange affectedCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:menu:forEvent:atIndex:")]
	public virtual NSMenu MenuForEvent(NSTextView view, NSMenu menu, NSEvent theEvent, ulong charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willCheckTextInRange:options:types:")]
	public virtual NSDictionary WillCheckText(NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
	public virtual NSTextCheckingResult[] DidCheckText(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, long wordCount)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:draggedCell:inRect:event:")]
	public virtual void DraggedCell(NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("undoManagerForTextView:")]
	public virtual NSUndoManager GetUndoManager(NSTextView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
