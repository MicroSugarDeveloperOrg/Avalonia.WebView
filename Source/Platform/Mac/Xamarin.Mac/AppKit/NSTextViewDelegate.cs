using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTextViewDelegate", false)]
[Model]
public class NSTextViewDelegate : NSTextDelegate, INSTextViewDelegate, INativeObject, IDisposable, INSTextDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("textView:clickedOnCell:inRect:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:doubleClickedOnCell:inRect:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellDoubleClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textViewDidChangeSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeSelection(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textViewDidChangeTypingAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeTypingAttributes(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] DidCheckText(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:doCommandBySelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoCommandBySelector(NSTextView textView, Selector commandSelector)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:draggedCell:inRect:event:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedCell(NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:candidatesForSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? GetCandidates(NSTextView textView, NSRange selectedRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetCompletions(NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:candidates:forSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] GetTextCheckingCandidates(NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("undoManagerForTextView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager GetUndoManager(NSTextView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:writablePasteboardTypesForCell:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritablePasteboardTypes(NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:clickedOnLink:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LinkClicked(NSTextView textView, NSObject link, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:menu:forEvent:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu MenuForEvent(NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTextInRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeTextInRange(NSTextView textView, NSRange affectedCharRange, string replacementString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTextInRanges:replacementStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeTextInRanges(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldChangeTypingAttributes:toAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ShouldChangeTypingAttributes(NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldSelectCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectCandidates(NSTextView textView, nuint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldSetSpellingState:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ShouldSetSpellingState(NSTextView textView, nint value, NSRange affectedCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:shouldUpdateTouchBarItemIdentifiers:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShouldUpdateTouchBarItemIdentifiers(NSTextView textView, string[] identifiers)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange WillChangeSelection(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] WillChangeSelectionFromRanges(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willCheckTextInRange:options:types:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary WillCheckText(NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:willDisplayToolTip:forCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? WillDisplayToolTip(NSTextView textView, string tooltip, nuint characterIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textView:writeCell:atIndex:toPasteboard:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteCell(NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
