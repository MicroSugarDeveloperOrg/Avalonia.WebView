using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextView", true)]
public class NSTextView : NSText, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityNavigableStaticText, INSAccessibilityStaticText, INSCandidateListTouchBarItemDelegate, INSDraggingSource, INSMenuItemValidation, INSTextFinderClient, INSTextInput, INSTextInputClient, INSTouchBarDelegate, INSUserInterfaceValidations
{
	[Register]
	internal class _NSTextViewDelegate : _NSTextDelegate, INSTextViewDelegate, INativeObject, IDisposable, INSTextDelegate
	{
		internal EventHandler<NSTextViewClickedEventArgs>? cellClicked;

		internal EventHandler<NSTextViewDoubleClickEventArgs>? cellDoubleClicked;

		internal EventHandler? didChangeSelection;

		internal EventHandler? didChangeTypingAttributes;

		internal NSTextViewTextChecked? didCheckText;

		internal NSTextViewSelectorCommand? doCommandBySelector;

		internal EventHandler<NSTextViewDraggedCellEventArgs>? draggedCell;

		internal NSTextViewGetCandidates? getCandidates;

		internal NSTextViewCompletion? getCompletions;

		internal NSTextViewTextCheckingResults? getTextCheckingCandidates;

		internal NSTextViewGetUndoManager? getUndoManager;

		internal NSTextViewCellPosition? getWritablePasteboardTypes;

		internal NSTextViewLink? linkClicked;

		internal NSTextViewEventMenu? menuForEvent;

		internal NSTextViewChangeText? shouldChangeTextInRange;

		internal NSTextViewSelectionShouldChange? shouldChangeTextInRanges;

		internal NSTextViewTypeAttribute? shouldChangeTypingAttributes;

		internal NSTextViewSelectCandidate? shouldSelectCandidates;

		internal NSTextViewSpellingQuery? shouldSetSpellingState;

		internal NSTextViewUpdateTouchBarItemIdentifiers? shouldUpdateTouchBarItemIdentifiers;

		internal NSTextViewSelectionChange? willChangeSelection;

		internal NSTextViewSelectionWillChange? willChangeSelectionFromRanges;

		internal NSTextViewOnTextCheck? willCheckText;

		internal NSTextViewTooltip? willDisplayToolTip;

		internal NSTextViewCellPasteboard? writeCell;

		private static IntPtr selGetCandidatesHandle = Selector.GetHandle("textView:candidatesForSelectedRange:");

		private static IntPtr selGetTextCheckingCandidatesHandle = Selector.GetHandle("textView:candidates:forSelectedRange:");

		private static IntPtr selShouldSelectCandidatesHandle = Selector.GetHandle("textView:shouldSelectCandidateAtIndex:");

		private static IntPtr selShouldUpdateTouchBarItemIdentifiersHandle = Selector.GetHandle("textView:shouldUpdateTouchBarItemIdentifiers:");

		private static IntPtr selRespondsToSelector = Selector.GetHandle("respondsToSelector:");

		public _NSTextViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("textView:clickedOnCell:inRect:atIndex:")]
		public void CellClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			EventHandler<NSTextViewClickedEventArgs> eventHandler = cellClicked;
			if (eventHandler != null)
			{
				NSTextViewClickedEventArgs e = new NSTextViewClickedEventArgs(cell, cellFrame, charIndex);
				eventHandler(textView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("textView:doubleClickedOnCell:inRect:atIndex:")]
		public void CellDoubleClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			EventHandler<NSTextViewDoubleClickEventArgs> eventHandler = cellDoubleClicked;
			if (eventHandler != null)
			{
				NSTextViewDoubleClickEventArgs e = new NSTextViewDoubleClickEventArgs(cell, cellFrame, charIndex);
				eventHandler(textView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("textViewDidChangeSelection:")]
		public void DidChangeSelection(NSNotification notification)
		{
			didChangeSelection?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textViewDidChangeTypingAttributes:")]
		public void DidChangeTypingAttributes(NSNotification notification)
		{
			didChangeTypingAttributes?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
		public NSTextCheckingResult[] DidCheckText(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			NSTextViewTextChecked nSTextViewTextChecked = didCheckText;
			if (nSTextViewTextChecked != null)
			{
				return nSTextViewTextChecked(view, range, checkingTypes, options, results, orthography, wordCount);
			}
			return results;
		}

		[Preserve(Conditional = true)]
		[Export("textView:doCommandBySelector:")]
		public bool DoCommandBySelector(NSTextView textView, Selector commandSelector)
		{
			return doCommandBySelector?.Invoke(textView, commandSelector) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("textView:draggedCell:inRect:event:")]
		public void DraggedCell(NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
		{
			EventHandler<NSTextViewDraggedCellEventArgs> eventHandler = draggedCell;
			if (eventHandler != null)
			{
				NSTextViewDraggedCellEventArgs e = new NSTextViewDraggedCellEventArgs(cell, rect, theevent);
				eventHandler(view, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("textView:candidatesForSelectedRange:")]
		public NSObject[] GetCandidates(NSTextView textView, NSRange selectedRange)
		{
			NSTextViewGetCandidates nSTextViewGetCandidates = getCandidates;
			if (nSTextViewGetCandidates != null)
			{
				return nSTextViewGetCandidates(textView, selectedRange);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		public string[] GetCompletions(NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			return getCompletions?.Invoke(textView, words, charRange, ref index);
		}

		[Preserve(Conditional = true)]
		[Export("textView:candidates:forSelectedRange:")]
		public NSTextCheckingResult[] GetTextCheckingCandidates(NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			NSTextViewTextCheckingResults nSTextViewTextCheckingResults = getTextCheckingCandidates;
			if (nSTextViewTextCheckingResults != null)
			{
				return nSTextViewTextCheckingResults(textView, candidates, selectedRange);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("undoManagerForTextView:")]
		public NSUndoManager GetUndoManager(NSTextView view)
		{
			return getUndoManager?.Invoke(view);
		}

		[Preserve(Conditional = true)]
		[Export("textView:writablePasteboardTypesForCell:atIndex:")]
		public string[] GetWritablePasteboardTypes(NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
		{
			return getWritablePasteboardTypes?.Invoke(view, forCell, charIndex);
		}

		[Preserve(Conditional = true)]
		[Export("textView:clickedOnLink:atIndex:")]
		public bool LinkClicked(NSTextView textView, NSObject link, nuint charIndex)
		{
			return linkClicked?.Invoke(textView, link, charIndex) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("textView:menu:forEvent:atIndex:")]
		public NSMenu MenuForEvent(NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
		{
			NSTextViewEventMenu nSTextViewEventMenu = menuForEvent;
			if (nSTextViewEventMenu != null)
			{
				return nSTextViewEventMenu(view, menu, theEvent, charIndex);
			}
			return menu;
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldChangeTextInRange:replacementString:")]
		public bool ShouldChangeTextInRange(NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			return shouldChangeTextInRange?.Invoke(textView, affectedCharRange, replacementString) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldChangeTextInRanges:replacementStrings:")]
		public bool ShouldChangeTextInRanges(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			return shouldChangeTextInRanges?.Invoke(textView, affectedRanges, replacementStrings) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldChangeTypingAttributes:toAttributes:")]
		public NSDictionary ShouldChangeTypingAttributes(NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			NSTextViewTypeAttribute nSTextViewTypeAttribute = shouldChangeTypingAttributes;
			if (nSTextViewTypeAttribute != null)
			{
				return nSTextViewTypeAttribute(textView, oldTypingAttributes, newTypingAttributes);
			}
			return newTypingAttributes;
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldSelectCandidateAtIndex:")]
		public bool ShouldSelectCandidates(NSTextView textView, nuint index)
		{
			NSTextViewSelectCandidate nSTextViewSelectCandidate = shouldSelectCandidates;
			if (nSTextViewSelectCandidate != null)
			{
				return nSTextViewSelectCandidate(textView, index);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldSetSpellingState:range:")]
		public nint ShouldSetSpellingState(NSTextView textView, nint value, NSRange affectedCharRange)
		{
			return shouldSetSpellingState?.Invoke(textView, value, affectedCharRange) ?? ((nint)0);
		}

		[Preserve(Conditional = true)]
		[Export("textView:shouldUpdateTouchBarItemIdentifiers:")]
		public string[] ShouldUpdateTouchBarItemIdentifiers(NSTextView textView, string[] identifiers)
		{
			NSTextViewUpdateTouchBarItemIdentifiers nSTextViewUpdateTouchBarItemIdentifiers = shouldUpdateTouchBarItemIdentifiers;
			if (nSTextViewUpdateTouchBarItemIdentifiers != null)
			{
				return nSTextViewUpdateTouchBarItemIdentifiers(textView, identifiers);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
		public NSRange WillChangeSelection(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			return willChangeSelection?.Invoke(textView, oldSelectedCharRange, newSelectedCharRange) ?? newSelectedCharRange;
		}

		[Preserve(Conditional = true)]
		[Export("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
		public NSValue[] WillChangeSelectionFromRanges(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			NSTextViewSelectionWillChange nSTextViewSelectionWillChange = willChangeSelectionFromRanges;
			if (nSTextViewSelectionWillChange != null)
			{
				return nSTextViewSelectionWillChange(textView, oldSelectedCharRanges, newSelectedCharRanges);
			}
			return newSelectedCharRanges;
		}

		[Preserve(Conditional = true)]
		[Export("textView:willCheckTextInRange:options:types:")]
		public NSDictionary WillCheckText(NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			NSTextViewOnTextCheck nSTextViewOnTextCheck = willCheckText;
			if (nSTextViewOnTextCheck != null)
			{
				return nSTextViewOnTextCheck(view, range, options, checkingTypes);
			}
			return options;
		}

		[Preserve(Conditional = true)]
		[Export("textView:willDisplayToolTip:forCharacterAtIndex:")]
		public string WillDisplayToolTip(NSTextView textView, string tooltip, nuint characterIndex)
		{
			NSTextViewTooltip nSTextViewTooltip = willDisplayToolTip;
			if (nSTextViewTooltip != null)
			{
				return nSTextViewTooltip(textView, tooltip, characterIndex);
			}
			return tooltip;
		}

		[Preserve(Conditional = true)]
		[Export("textView:writeCell:atIndex:toPasteboard:type:")]
		public bool WriteCell(NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
		{
			return writeCell?.Invoke(view, cell, charIndex, pboard, type) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool RespondsToSelector(Selector? sel)
		{
			if (sel == null)
			{
				return false;
			}
			IntPtr arg = ((sel == null) ? IntPtr.Zero : sel.Handle);
			if (arg.Equals(selGetCandidatesHandle))
			{
				return getCandidates != null;
			}
			if (arg.Equals(selGetTextCheckingCandidatesHandle))
			{
				return getTextCheckingCandidates != null;
			}
			if (arg.Equals(selShouldSelectCandidatesHandle))
			{
				return shouldSelectCandidates != null;
			}
			if (arg.Equals(selShouldUpdateTouchBarItemIdentifiersHandle))
			{
				return shouldUpdateTouchBarItemIdentifiers != null;
			}
			return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRespondsToSelector, arg);
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveDidChangeSelection(EventHandler<NSTextViewDidChangeSelectionEventArgs> handler)
		{
			EventHandler<NSTextViewDidChangeSelectionEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeSelectionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextViewDidChangeSelectionEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeSelection(NSObject objectToObserve, EventHandler<NSTextViewDidChangeSelectionEventArgs> handler)
		{
			EventHandler<NSTextViewDidChangeSelectionEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeSelectionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextViewDidChangeSelectionEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeTypingAttributes(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeTypingAttributesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeTypingAttributes(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeTypingAttributesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillChangeNotifyingTextView(EventHandler<NSTextViewWillChangeNotifyingTextViewEventArgs> handler)
		{
			EventHandler<NSTextViewWillChangeNotifyingTextViewEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillChangeNotifyingTextViewNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextViewWillChangeNotifyingTextViewEventArgs(notification));
			});
		}

		public static NSObject ObserveWillChangeNotifyingTextView(NSObject objectToObserve, EventHandler<NSTextViewWillChangeNotifyingTextViewEventArgs> handler)
		{
			EventHandler<NSTextViewWillChangeNotifyingTextViewEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillChangeNotifyingTextViewNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextViewWillChangeNotifyingTextViewEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptableDragTypes = "acceptableDragTypes";

	private static readonly IntPtr selAcceptableDragTypesHandle = Selector.GetHandle("acceptableDragTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsGlyphInfo = "acceptsGlyphInfo";

	private static readonly IntPtr selAcceptsGlyphInfoHandle = Selector.GetHandle("acceptsGlyphInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributedStringForRange_ = "accessibilityAttributedStringForRange:";

	private static readonly IntPtr selAccessibilityAttributedStringForRange_Handle = Selector.GetHandle("accessibilityAttributedStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrameForRange_ = "accessibilityFrameForRange:";

	private static readonly IntPtr selAccessibilityFrameForRange_Handle = Selector.GetHandle("accessibilityFrameForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLineForIndex_ = "accessibilityLineForIndex:";

	private static readonly IntPtr selAccessibilityLineForIndex_Handle = Selector.GetHandle("accessibilityLineForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForLine_ = "accessibilityRangeForLine:";

	private static readonly IntPtr selAccessibilityRangeForLine_Handle = Selector.GetHandle("accessibilityRangeForLine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStringForRange_ = "accessibilityStringForRange:";

	private static readonly IntPtr selAccessibilityStringForRange_Handle = Selector.GetHandle("accessibilityStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCharacterRange = "accessibilityVisibleCharacterRange";

	private static readonly IntPtr selAccessibilityVisibleCharacterRangeHandle = Selector.GetHandle("accessibilityVisibleCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignJustified_ = "alignJustified:";

	private static readonly IntPtr selAlignJustified_Handle = Selector.GetHandle("alignJustified:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedInputSourceLocales = "allowedInputSourceLocales";

	private static readonly IntPtr selAllowedInputSourceLocalesHandle = Selector.GetHandle("allowedInputSourceLocales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCharacterPickerTouchBarItem = "allowsCharacterPickerTouchBarItem";

	private static readonly IntPtr selAllowsCharacterPickerTouchBarItemHandle = Selector.GetHandle("allowsCharacterPickerTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDocumentBackgroundColorChange = "allowsDocumentBackgroundColorChange";

	private static readonly IntPtr selAllowsDocumentBackgroundColorChangeHandle = Selector.GetHandle("allowsDocumentBackgroundColorChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsImageEditing = "allowsImageEditing";

	private static readonly IntPtr selAllowsImageEditingHandle = Selector.GetHandle("allowsImageEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMultipleSelection = "allowsMultipleSelection";

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsUndo = "allowsUndo";

	private static readonly IntPtr selAllowsUndoHandle = Selector.GetHandle("allowsUndo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedString = "attributedString";

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedSubstringForProposedRange_ActualRange_ = "attributedSubstringForProposedRange:actualRange:";

	private static readonly IntPtr selAttributedSubstringForProposedRange_ActualRange_Handle = Selector.GetHandle("attributedSubstringForProposedRange:actualRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedSubstringFromRange_ = "attributedSubstringFromRange:";

	private static readonly IntPtr selAttributedSubstringFromRange_Handle = Selector.GetHandle("attributedSubstringFromRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaselineDeltaForCharacterAtIndex_ = "baselineDeltaForCharacterAtIndex:";

	private static readonly IntPtr selBaselineDeltaForCharacterAtIndex_Handle = Selector.GetHandle("baselineDeltaForCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBreakUndoCoalescing = "breakUndoCoalescing";

	private static readonly IntPtr selBreakUndoCoalescingHandle = Selector.GetHandle("breakUndoCoalescing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem = "candidateListTouchBarItem";

	private static readonly IntPtr selCandidateListTouchBarItemHandle = Selector.GetHandle("candidateListTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_ = "candidateListTouchBarItem:beginSelectingCandidateAtIndex:";

	private static readonly IntPtr selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_Handle = Selector.GetHandle("candidateListTouchBarItem:beginSelectingCandidateAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_ = "candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:";

	private static readonly IntPtr selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_Handle = Selector.GetHandle("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem_ChangedCandidateListVisibility_ = "candidateListTouchBarItem:changedCandidateListVisibility:";

	private static readonly IntPtr selCandidateListTouchBarItem_ChangedCandidateListVisibility_Handle = Selector.GetHandle("candidateListTouchBarItem:changedCandidateListVisibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_ = "candidateListTouchBarItem:endSelectingCandidateAtIndex:";

	private static readonly IntPtr selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_Handle = Selector.GetHandle("candidateListTouchBarItem:endSelectingCandidateAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeAttributes_ = "changeAttributes:";

	private static readonly IntPtr selChangeAttributes_Handle = Selector.GetHandle("changeAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeColor_ = "changeColor:";

	private static readonly IntPtr selChangeColor_Handle = Selector.GetHandle("changeColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeDocumentBackgroundColor_ = "changeDocumentBackgroundColor:";

	private static readonly IntPtr selChangeDocumentBackgroundColor_Handle = Selector.GetHandle("changeDocumentBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeLayoutOrientation_ = "changeLayoutOrientation:";

	private static readonly IntPtr selChangeLayoutOrientation_Handle = Selector.GetHandle("changeLayoutOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIndexForInsertionAtPoint_ = "characterIndexForInsertionAtPoint:";

	private static readonly IntPtr selCharacterIndexForInsertionAtPoint_Handle = Selector.GetHandle("characterIndexForInsertionAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIndexForPoint_ = "characterIndexForPoint:";

	private static readonly IntPtr selCharacterIndexForPoint_Handle = Selector.GetHandle("characterIndexForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInDocument_ = "checkTextInDocument:";

	private static readonly IntPtr selCheckTextInDocument_Handle = Selector.GetHandle("checkTextInDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInRange_Types_Options_ = "checkTextInRange:types:options:";

	private static readonly IntPtr selCheckTextInRange_Types_Options_Handle = Selector.GetHandle("checkTextInRange:types:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInSelection_ = "checkTextInSelection:";

	private static readonly IntPtr selCheckTextInSelection_Handle = Selector.GetHandle("checkTextInSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCleanUpAfterDragOperation = "cleanUpAfterDragOperation";

	private static readonly IntPtr selCleanUpAfterDragOperationHandle = Selector.GetHandle("cleanUpAfterDragOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedOnLink_AtIndex_ = "clickedOnLink:atIndex:";

	private static readonly IntPtr selClickedOnLink_AtIndex_Handle = Selector.GetHandle("clickedOnLink:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComplete_ = "complete:";

	private static readonly IntPtr selComplete_Handle = Selector.GetHandle("complete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionsForPartialWordRange_IndexOfSelectedItem_ = "completionsForPartialWordRange:indexOfSelectedItem:";

	private static readonly IntPtr selCompletionsForPartialWordRange_IndexOfSelectedItem_Handle = Selector.GetHandle("completionsForPartialWordRange:indexOfSelectedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentViewAtIndex_EffectiveCharacterRange_ = "contentViewAtIndex:effectiveCharacterRange:";

	private static readonly IntPtr selContentViewAtIndex_EffectiveCharacterRange_Handle = Selector.GetHandle("contentViewAtIndex:effectiveCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversationIdentifier = "conversationIdentifier";

	private static readonly IntPtr selConversationIdentifierHandle = Selector.GetHandle("conversationIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultParagraphStyle = "defaultParagraphStyle";

	private static readonly IntPtr selDefaultParagraphStyleHandle = Selector.GetHandle("defaultParagraphStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeText = "didChangeText";

	private static readonly IntPtr selDidChangeTextHandle = Selector.GetHandle("didChangeText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidReplaceCharacters = "didReplaceCharacters";

	private static readonly IntPtr selDidReplaceCharactersHandle = Selector.GetHandle("didReplaceCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysLinkToolTips = "displaysLinkToolTips";

	private static readonly IntPtr selDisplaysLinkToolTipsHandle = Selector.GetHandle("displaysLinkToolTips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragOperationForDraggingInfo_Type_ = "dragOperationForDraggingInfo:type:";

	private static readonly IntPtr selDragOperationForDraggingInfo_Type_Handle = Selector.GetHandle("dragOperationForDraggingInfo:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_BeganAt_ = "draggedImage:beganAt:";

	private static readonly IntPtr selDraggedImage_BeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Deposited_ = "draggedImage:endedAt:deposited:";

	private static readonly IntPtr selDraggedImage_EndedAt_Deposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Operation_ = "draggedImage:endedAt:operation:";

	private static readonly IntPtr selDraggedImage_EndedAt_Operation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_MovedTo_ = "draggedImage:movedTo:";

	private static readonly IntPtr selDraggedImage_MovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSourceOperationMaskForLocal_ = "draggingSourceOperationMaskForLocal:";

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawCharactersInRange_ForContentView_ = "drawCharactersInRange:forContentView:";

	private static readonly IntPtr selDrawCharactersInRange_ForContentView_Handle = Selector.GetHandle("drawCharactersInRange:forContentView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInsertionPointInRect_Color_TurnedOn_ = "drawInsertionPointInRect:color:turnedOn:";

	private static readonly IntPtr selDrawInsertionPointInRect_Color_TurnedOn_Handle = Selector.GetHandle("drawInsertionPointInRect:color:turnedOn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawViewBackgroundInRect_ = "drawViewBackgroundInRect:";

	private static readonly IntPtr selDrawViewBackgroundInRect_Handle = Selector.GetHandle("drawViewBackgroundInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsVerticallyForCharacterAtIndex_ = "drawsVerticallyForCharacterAtIndex:";

	private static readonly IntPtr selDrawsVerticallyForCharacterAtIndex_Handle = Selector.GetHandle("drawsVerticallyForCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnabledTextCheckingTypes = "enabledTextCheckingTypes";

	private static readonly IntPtr selEnabledTextCheckingTypesHandle = Selector.GetHandle("enabledTextCheckingTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldEditor = "fieldEditor";

	private static readonly IntPtr selFieldEditorHandle = Selector.GetHandle("fieldEditor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstRectForCharacterRange_ = "firstRectForCharacterRange:";

	private static readonly IntPtr selFirstRectForCharacterRange_Handle = Selector.GetHandle("firstRectForCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstRectForCharacterRange_ActualRange_ = "firstRectForCharacterRange:actualRange:";

	private static readonly IntPtr selFirstRectForCharacterRange_ActualRange_Handle = Selector.GetHandle("firstRectForCharacterRange:actualRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstSelectedRange = "firstSelectedRange";

	private static readonly IntPtr selFirstSelectedRangeHandle = Selector.GetHandle("firstSelectedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFractionOfDistanceThroughGlyphForPoint_ = "fractionOfDistanceThroughGlyphForPoint:";

	private static readonly IntPtr selFractionOfDistanceThroughGlyphForPoint_Handle = Selector.GetHandle("fractionOfDistanceThroughGlyphForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_ = "handleTextCheckingResults:forRange:types:options:orthography:wordCount:";

	private static readonly IntPtr selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_Handle = Selector.GetHandle("handleTextCheckingResults:forRange:types:options:orthography:wordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMarkedText = "hasMarkedText";

	private static readonly IntPtr selHasMarkedTextHandle = Selector.GetHandle("hasMarkedText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreModifierKeysWhileDragging = "ignoreModifierKeysWhileDragging";

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportsGraphics = "importsGraphics";

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_TextContainer_ = "initWithFrame:textContainer:";

	private static readonly IntPtr selInitWithFrame_TextContainer_Handle = Selector.GetHandle("initWithFrame:textContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertCompletion_ForPartialWordRange_Movement_IsFinal_ = "insertCompletion:forPartialWordRange:movement:isFinal:";

	private static readonly IntPtr selInsertCompletion_ForPartialWordRange_Movement_IsFinal_Handle = Selector.GetHandle("insertCompletion:forPartialWordRange:movement:isFinal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertText_ = "insertText:";

	private static readonly IntPtr selInsertText_Handle = Selector.GetHandle("insertText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertText_ReplacementRange_ = "insertText:replacementRange:";

	private static readonly IntPtr selInsertText_ReplacementRange_Handle = Selector.GetHandle("insertText:replacementRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertionPointColor = "insertionPointColor";

	private static readonly IntPtr selInsertionPointColorHandle = Selector.GetHandle("insertionPointColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateTextContainerOrigin = "invalidateTextContainerOrigin";

	private static readonly IntPtr selInvalidateTextContainerOriginHandle = Selector.GetHandle("invalidateTextContainerOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticDashSubstitutionEnabled = "isAutomaticDashSubstitutionEnabled";

	private static readonly IntPtr selIsAutomaticDashSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticDashSubstitutionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticDataDetectionEnabled = "isAutomaticDataDetectionEnabled";

	private static readonly IntPtr selIsAutomaticDataDetectionEnabledHandle = Selector.GetHandle("isAutomaticDataDetectionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticLinkDetectionEnabled = "isAutomaticLinkDetectionEnabled";

	private static readonly IntPtr selIsAutomaticLinkDetectionEnabledHandle = Selector.GetHandle("isAutomaticLinkDetectionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticQuoteSubstitutionEnabled = "isAutomaticQuoteSubstitutionEnabled";

	private static readonly IntPtr selIsAutomaticQuoteSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticQuoteSubstitutionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticSpellingCorrectionEnabled = "isAutomaticSpellingCorrectionEnabled";

	private static readonly IntPtr selIsAutomaticSpellingCorrectionEnabledHandle = Selector.GetHandle("isAutomaticSpellingCorrectionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticTextCompletionEnabled = "isAutomaticTextCompletionEnabled";

	private static readonly IntPtr selIsAutomaticTextCompletionEnabledHandle = Selector.GetHandle("isAutomaticTextCompletionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticTextReplacementEnabled = "isAutomaticTextReplacementEnabled";

	private static readonly IntPtr selIsAutomaticTextReplacementEnabledHandle = Selector.GetHandle("isAutomaticTextReplacementEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCoalescingUndo = "isCoalescingUndo";

	private static readonly IntPtr selIsCoalescingUndoHandle = Selector.GetHandle("isCoalescingUndo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContinuousSpellCheckingEnabled = "isContinuousSpellCheckingEnabled";

	private static readonly IntPtr selIsContinuousSpellCheckingEnabledHandle = Selector.GetHandle("isContinuousSpellCheckingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFieldEditor = "isFieldEditor";

	private static readonly IntPtr selIsFieldEditorHandle = Selector.GetHandle("isFieldEditor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGrammarCheckingEnabled = "isGrammarCheckingEnabled";

	private static readonly IntPtr selIsGrammarCheckingEnabledHandle = Selector.GetHandle("isGrammarCheckingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIncrementalSearchingEnabled = "isIncrementalSearchingEnabled";

	private static readonly IntPtr selIsIncrementalSearchingEnabledHandle = Selector.GetHandle("isIncrementalSearchingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRichText = "isRichText";

	private static readonly IntPtr selIsRichTextHandle = Selector.GetHandle("isRichText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRulerVisible = "isRulerVisible";

	private static readonly IntPtr selIsRulerVisibleHandle = Selector.GetHandle("isRulerVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectable = "isSelectable";

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManager = "layoutManager";

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutOrientation = "layoutOrientation";

	private static readonly IntPtr selLayoutOrientationHandle = Selector.GetHandle("layoutOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkTextAttributes = "linkTextAttributes";

	private static readonly IntPtr selLinkTextAttributesHandle = Selector.GetHandle("linkTextAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoosenKerning_ = "loosenKerning:";

	private static readonly IntPtr selLoosenKerning_Handle = Selector.GetHandle("loosenKerning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowerBaseline_ = "lowerBaseline:";

	private static readonly IntPtr selLowerBaseline_Handle = Selector.GetHandle("lowerBaseline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkedRange = "markedRange";

	private static readonly IntPtr selMarkedRangeHandle = Selector.GetHandle("markedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkedTextAttributes = "markedTextAttributes";

	private static readonly IntPtr selMarkedTextAttributesHandle = Selector.GetHandle("markedTextAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamesOfPromisedFilesDroppedAtDestination_ = "namesOfPromisedFilesDroppedAtDestination:";

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontLinkPanel_ = "orderFrontLinkPanel:";

	private static readonly IntPtr selOrderFrontLinkPanel_Handle = Selector.GetHandle("orderFrontLinkPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontListPanel_ = "orderFrontListPanel:";

	private static readonly IntPtr selOrderFrontListPanel_Handle = Selector.GetHandle("orderFrontListPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontSpacingPanel_ = "orderFrontSpacingPanel:";

	private static readonly IntPtr selOrderFrontSpacingPanel_Handle = Selector.GetHandle("orderFrontSpacingPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontSubstitutionsPanel_ = "orderFrontSubstitutionsPanel:";

	private static readonly IntPtr selOrderFrontSubstitutionsPanel_Handle = Selector.GetHandle("orderFrontSubstitutionsPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontTablePanel_ = "orderFrontTablePanel:";

	private static readonly IntPtr selOrderFrontTablePanel_Handle = Selector.GetHandle("orderFrontTablePanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutline_ = "outline:";

	private static readonly IntPtr selOutline_Handle = Selector.GetHandle("outline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteAsPlainText_ = "pasteAsPlainText:";

	private static readonly IntPtr selPasteAsPlainText_Handle = Selector.GetHandle("pasteAsPlainText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteAsRichText_ = "pasteAsRichText:";

	private static readonly IntPtr selPasteAsRichText_Handle = Selector.GetHandle("pasteAsRichText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformFindPanelAction_ = "performFindPanelAction:";

	private static readonly IntPtr selPerformFindPanelAction_Handle = Selector.GetHandle("performFindPanelAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformValidatedReplacementInRange_WithAttributedString_ = "performValidatedReplacementInRange:withAttributedString:";

	private static readonly IntPtr selPerformValidatedReplacementInRange_WithAttributedString_Handle = Selector.GetHandle("performValidatedReplacementInRange:withAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_ = "preferredPasteboardTypeFromArray:restrictedToTypesFromArray:";

	private static readonly IntPtr selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_Handle = Selector.GetHandle("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickLookPreviewableItemsInRanges_ = "quickLookPreviewableItemsInRanges:";

	private static readonly IntPtr selQuickLookPreviewableItemsInRanges_Handle = Selector.GetHandle("quickLookPreviewableItemsInRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRaiseBaseline_ = "raiseBaseline:";

	private static readonly IntPtr selRaiseBaseline_Handle = Selector.GetHandle("raiseBaseline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeForUserCharacterAttributeChange = "rangeForUserCharacterAttributeChange";

	private static readonly IntPtr selRangeForUserCharacterAttributeChangeHandle = Selector.GetHandle("rangeForUserCharacterAttributeChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeForUserCompletion = "rangeForUserCompletion";

	private static readonly IntPtr selRangeForUserCompletionHandle = Selector.GetHandle("rangeForUserCompletion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeForUserParagraphAttributeChange = "rangeForUserParagraphAttributeChange";

	private static readonly IntPtr selRangeForUserParagraphAttributeChangeHandle = Selector.GetHandle("rangeForUserParagraphAttributeChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeForUserTextChange = "rangeForUserTextChange";

	private static readonly IntPtr selRangeForUserTextChangeHandle = Selector.GetHandle("rangeForUserTextChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangesForUserCharacterAttributeChange = "rangesForUserCharacterAttributeChange";

	private static readonly IntPtr selRangesForUserCharacterAttributeChangeHandle = Selector.GetHandle("rangesForUserCharacterAttributeChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangesForUserParagraphAttributeChange = "rangesForUserParagraphAttributeChange";

	private static readonly IntPtr selRangesForUserParagraphAttributeChangeHandle = Selector.GetHandle("rangesForUserParagraphAttributeChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangesForUserTextChange = "rangesForUserTextChange";

	private static readonly IntPtr selRangesForUserTextChangeHandle = Selector.GetHandle("rangesForUserTextChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadSelectionFromPasteboard_ = "readSelectionFromPasteboard:";

	private static readonly IntPtr selReadSelectionFromPasteboard_Handle = Selector.GetHandle("readSelectionFromPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadSelectionFromPasteboard_Type_ = "readSelectionFromPasteboard:type:";

	private static readonly IntPtr selReadSelectionFromPasteboard_Type_Handle = Selector.GetHandle("readSelectionFromPasteboard:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadablePasteboardTypes = "readablePasteboardTypes";

	private static readonly IntPtr selReadablePasteboardTypesHandle = Selector.GetHandle("readablePasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectsForCharacterRange_ = "rectsForCharacterRange:";

	private static readonly IntPtr selRectsForCharacterRange_Handle = Selector.GetHandle("rectsForCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterForServices = "registerForServices";

	private static readonly IntPtr selRegisterForServicesHandle = Selector.GetHandle("registerForServices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithString_ = "replaceCharactersInRange:withString:";

	private static readonly IntPtr selReplaceCharactersInRange_WithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceTextContainer_ = "replaceTextContainer:";

	private static readonly IntPtr selReplaceTextContainer_Handle = Selector.GetHandle("replaceTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_DidAddMarker_ = "rulerView:didAddMarker:";

	private static readonly IntPtr selRulerView_DidAddMarker_Handle = Selector.GetHandle("rulerView:didAddMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_DidMoveMarker_ = "rulerView:didMoveMarker:";

	private static readonly IntPtr selRulerView_DidMoveMarker_Handle = Selector.GetHandle("rulerView:didMoveMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_DidRemoveMarker_ = "rulerView:didRemoveMarker:";

	private static readonly IntPtr selRulerView_DidRemoveMarker_Handle = Selector.GetHandle("rulerView:didRemoveMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_HandleMouseDown_ = "rulerView:handleMouseDown:";

	private static readonly IntPtr selRulerView_HandleMouseDown_Handle = Selector.GetHandle("rulerView:handleMouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_ShouldAddMarker_ = "rulerView:shouldAddMarker:";

	private static readonly IntPtr selRulerView_ShouldAddMarker_Handle = Selector.GetHandle("rulerView:shouldAddMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_ShouldMoveMarker_ = "rulerView:shouldMoveMarker:";

	private static readonly IntPtr selRulerView_ShouldMoveMarker_Handle = Selector.GetHandle("rulerView:shouldMoveMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_ShouldRemoveMarker_ = "rulerView:shouldRemoveMarker:";

	private static readonly IntPtr selRulerView_ShouldRemoveMarker_Handle = Selector.GetHandle("rulerView:shouldRemoveMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_WillAddMarker_AtLocation_ = "rulerView:willAddMarker:atLocation:";

	private static readonly IntPtr selRulerView_WillAddMarker_AtLocation_Handle = Selector.GetHandle("rulerView:willAddMarker:atLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_WillMoveMarker_ToLocation_ = "rulerView:willMoveMarker:toLocation:";

	private static readonly IntPtr selRulerView_WillMoveMarker_ToLocation_Handle = Selector.GetHandle("rulerView:willMoveMarker:toLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRangeToVisible_ = "scrollRangeToVisible:";

	private static readonly IntPtr selScrollRangeToVisible_Handle = Selector.GetHandle("scrollRangeToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollableDocumentContentTextView = "scrollableDocumentContentTextView";

	private static readonly IntPtr selScrollableDocumentContentTextViewHandle = Selector.GetHandle("scrollableDocumentContentTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollablePlainDocumentContentTextView = "scrollablePlainDocumentContentTextView";

	private static readonly IntPtr selScrollablePlainDocumentContentTextViewHandle = Selector.GetHandle("scrollablePlainDocumentContentTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollableTextView = "scrollableTextView";

	private static readonly IntPtr selScrollableTextViewHandle = Selector.GetHandle("scrollableTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRange = "selectedRange";

	private static readonly IntPtr selSelectedRangeHandle = Selector.GetHandle("selectedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRanges = "selectedRanges";

	private static readonly IntPtr selSelectedRangesHandle = Selector.GetHandle("selectedRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTextAttributes = "selectedTextAttributes";

	private static readonly IntPtr selSelectedTextAttributesHandle = Selector.GetHandle("selectedTextAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionAffinity = "selectionAffinity";

	private static readonly IntPtr selSelectionAffinityHandle = Selector.GetHandle("selectionAffinity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionGranularity = "selectionGranularity";

	private static readonly IntPtr selSelectionGranularityHandle = Selector.GetHandle("selectionGranularity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionRangeForProposedRange_Granularity_ = "selectionRangeForProposedRange:granularity:";

	private static readonly IntPtr selSelectionRangeForProposedRange_Granularity_Handle = Selector.GetHandle("selectionRangeForProposedRange:granularity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptsGlyphInfo_ = "setAcceptsGlyphInfo:";

	private static readonly IntPtr selSetAcceptsGlyphInfo_Handle = Selector.GetHandle("setAcceptsGlyphInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_Range_ = "setAlignment:range:";

	private static readonly IntPtr selSetAlignment_Range_Handle = Selector.GetHandle("setAlignment:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedInputSourceLocales_ = "setAllowedInputSourceLocales:";

	private static readonly IntPtr selSetAllowedInputSourceLocales_Handle = Selector.GetHandle("setAllowedInputSourceLocales:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCharacterPickerTouchBarItem_ = "setAllowsCharacterPickerTouchBarItem:";

	private static readonly IntPtr selSetAllowsCharacterPickerTouchBarItem_Handle = Selector.GetHandle("setAllowsCharacterPickerTouchBarItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsDocumentBackgroundColorChange_ = "setAllowsDocumentBackgroundColorChange:";

	private static readonly IntPtr selSetAllowsDocumentBackgroundColorChange_Handle = Selector.GetHandle("setAllowsDocumentBackgroundColorChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsImageEditing_ = "setAllowsImageEditing:";

	private static readonly IntPtr selSetAllowsImageEditing_Handle = Selector.GetHandle("setAllowsImageEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsUndo_ = "setAllowsUndo:";

	private static readonly IntPtr selSetAllowsUndo_Handle = Selector.GetHandle("setAllowsUndo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticDashSubstitutionEnabled_ = "setAutomaticDashSubstitutionEnabled:";

	private static readonly IntPtr selSetAutomaticDashSubstitutionEnabled_Handle = Selector.GetHandle("setAutomaticDashSubstitutionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticDataDetectionEnabled_ = "setAutomaticDataDetectionEnabled:";

	private static readonly IntPtr selSetAutomaticDataDetectionEnabled_Handle = Selector.GetHandle("setAutomaticDataDetectionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticLinkDetectionEnabled_ = "setAutomaticLinkDetectionEnabled:";

	private static readonly IntPtr selSetAutomaticLinkDetectionEnabled_Handle = Selector.GetHandle("setAutomaticLinkDetectionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticQuoteSubstitutionEnabled_ = "setAutomaticQuoteSubstitutionEnabled:";

	private static readonly IntPtr selSetAutomaticQuoteSubstitutionEnabled_Handle = Selector.GetHandle("setAutomaticQuoteSubstitutionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticSpellingCorrectionEnabled_ = "setAutomaticSpellingCorrectionEnabled:";

	private static readonly IntPtr selSetAutomaticSpellingCorrectionEnabled_Handle = Selector.GetHandle("setAutomaticSpellingCorrectionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticTextCompletionEnabled_ = "setAutomaticTextCompletionEnabled:";

	private static readonly IntPtr selSetAutomaticTextCompletionEnabled_Handle = Selector.GetHandle("setAutomaticTextCompletionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticTextReplacementEnabled_ = "setAutomaticTextReplacementEnabled:";

	private static readonly IntPtr selSetAutomaticTextReplacementEnabled_Handle = Selector.GetHandle("setAutomaticTextReplacementEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseWritingDirection_Range_ = "setBaseWritingDirection:range:";

	private static readonly IntPtr selSetBaseWritingDirection_Range_Handle = Selector.GetHandle("setBaseWritingDirection:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstrainedFrameSize_ = "setConstrainedFrameSize:";

	private static readonly IntPtr selSetConstrainedFrameSize_Handle = Selector.GetHandle("setConstrainedFrameSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuousSpellCheckingEnabled_ = "setContinuousSpellCheckingEnabled:";

	private static readonly IntPtr selSetContinuousSpellCheckingEnabled_Handle = Selector.GetHandle("setContinuousSpellCheckingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultParagraphStyle_ = "setDefaultParagraphStyle:";

	private static readonly IntPtr selSetDefaultParagraphStyle_Handle = Selector.GetHandle("setDefaultParagraphStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysLinkToolTips_ = "setDisplaysLinkToolTips:";

	private static readonly IntPtr selSetDisplaysLinkToolTips_Handle = Selector.GetHandle("setDisplaysLinkToolTips:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabledTextCheckingTypes_ = "setEnabledTextCheckingTypes:";

	private static readonly IntPtr selSetEnabledTextCheckingTypes_Handle = Selector.GetHandle("setEnabledTextCheckingTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldEditor_ = "setFieldEditor:";

	private static readonly IntPtr selSetFieldEditor_Handle = Selector.GetHandle("setFieldEditor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGrammarCheckingEnabled_ = "setGrammarCheckingEnabled:";

	private static readonly IntPtr selSetGrammarCheckingEnabled_Handle = Selector.GetHandle("setGrammarCheckingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImportsGraphics_ = "setImportsGraphics:";

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncrementalSearchingEnabled_ = "setIncrementalSearchingEnabled:";

	private static readonly IntPtr selSetIncrementalSearchingEnabled_Handle = Selector.GetHandle("setIncrementalSearchingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInsertionPointColor_ = "setInsertionPointColor:";

	private static readonly IntPtr selSetInsertionPointColor_Handle = Selector.GetHandle("setInsertionPointColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutOrientation_ = "setLayoutOrientation:";

	private static readonly IntPtr selSetLayoutOrientation_Handle = Selector.GetHandle("setLayoutOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLinkTextAttributes_ = "setLinkTextAttributes:";

	private static readonly IntPtr selSetLinkTextAttributes_Handle = Selector.GetHandle("setLinkTextAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkedText_SelectedRange_ = "setMarkedText:selectedRange:";

	private static readonly IntPtr selSetMarkedText_SelectedRange_Handle = Selector.GetHandle("setMarkedText:selectedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkedText_SelectedRange_ReplacementRange_ = "setMarkedText:selectedRange:replacementRange:";

	private static readonly IntPtr selSetMarkedText_SelectedRange_ReplacementRange_Handle = Selector.GetHandle("setMarkedText:selectedRange:replacementRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkedTextAttributes_ = "setMarkedTextAttributes:";

	private static readonly IntPtr selSetMarkedTextAttributes_Handle = Selector.GetHandle("setMarkedTextAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayInRect_AvoidAdditionalLayout_ = "setNeedsDisplayInRect:avoidAdditionalLayout:";

	private static readonly IntPtr selSetNeedsDisplayInRect_AvoidAdditionalLayout_Handle = Selector.GetHandle("setNeedsDisplayInRect:avoidAdditionalLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRichText_ = "setRichText:";

	private static readonly IntPtr selSetRichText_Handle = Selector.GetHandle("setRichText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRulerVisible_ = "setRulerVisible:";

	private static readonly IntPtr selSetRulerVisible_Handle = Selector.GetHandle("setRulerVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectable_ = "setSelectable:";

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedRange_ = "setSelectedRange:";

	private static readonly IntPtr selSetSelectedRange_Handle = Selector.GetHandle("setSelectedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedRange_Affinity_StillSelecting_ = "setSelectedRange:affinity:stillSelecting:";

	private static readonly IntPtr selSetSelectedRange_Affinity_StillSelecting_Handle = Selector.GetHandle("setSelectedRange:affinity:stillSelecting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedRanges_ = "setSelectedRanges:";

	private static readonly IntPtr selSetSelectedRanges_Handle = Selector.GetHandle("setSelectedRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedRanges_Affinity_StillSelecting_ = "setSelectedRanges:affinity:stillSelecting:";

	private static readonly IntPtr selSetSelectedRanges_Affinity_StillSelecting_Handle = Selector.GetHandle("setSelectedRanges:affinity:stillSelecting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedTextAttributes_ = "setSelectedTextAttributes:";

	private static readonly IntPtr selSetSelectedTextAttributes_Handle = Selector.GetHandle("setSelectedTextAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionGranularity_ = "setSelectionGranularity:";

	private static readonly IntPtr selSetSelectionGranularity_Handle = Selector.GetHandle("setSelectionGranularity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSmartInsertDeleteEnabled_ = "setSmartInsertDeleteEnabled:";

	private static readonly IntPtr selSetSmartInsertDeleteEnabled_Handle = Selector.GetHandle("setSmartInsertDeleteEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpellingState_Range_ = "setSpellingState:range:";

	private static readonly IntPtr selSetSpellingState_Range_Handle = Selector.GetHandle("setSpellingState:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextContainer_ = "setTextContainer:";

	private static readonly IntPtr selSetTextContainer_Handle = Selector.GetHandle("setTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextContainerInset_ = "setTextContainerInset:";

	private static readonly IntPtr selSetTextContainerInset_Handle = Selector.GetHandle("setTextContainerInset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTypingAttributes_ = "setTypingAttributes:";

	private static readonly IntPtr selSetTypingAttributes_Handle = Selector.GetHandle("setTypingAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesAdaptiveColorMappingForDarkAppearance_ = "setUsesAdaptiveColorMappingForDarkAppearance:";

	private static readonly IntPtr selSetUsesAdaptiveColorMappingForDarkAppearance_Handle = Selector.GetHandle("setUsesAdaptiveColorMappingForDarkAppearance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFindBar_ = "setUsesFindBar:";

	private static readonly IntPtr selSetUsesFindBar_Handle = Selector.GetHandle("setUsesFindBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFindPanel_ = "setUsesFindPanel:";

	private static readonly IntPtr selSetUsesFindPanel_Handle = Selector.GetHandle("setUsesFindPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFontPanel_ = "setUsesFontPanel:";

	private static readonly IntPtr selSetUsesFontPanel_Handle = Selector.GetHandle("setUsesFontPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesInspectorBar_ = "setUsesInspectorBar:";

	private static readonly IntPtr selSetUsesInspectorBar_Handle = Selector.GetHandle("setUsesInspectorBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesRolloverButtonForSelection_ = "setUsesRolloverButtonForSelection:";

	private static readonly IntPtr selSetUsesRolloverButtonForSelection_Handle = Selector.GetHandle("setUsesRolloverButtonForSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesRuler_ = "setUsesRuler:";

	private static readonly IntPtr selSetUsesRuler_Handle = Selector.GetHandle("setUsesRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldChangeTextInRange_ReplacementString_ = "shouldChangeTextInRange:replacementString:";

	private static readonly IntPtr selShouldChangeTextInRange_ReplacementString_Handle = Selector.GetHandle("shouldChangeTextInRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldChangeTextInRanges_ReplacementStrings_ = "shouldChangeTextInRanges:replacementStrings:";

	private static readonly IntPtr selShouldChangeTextInRanges_ReplacementStrings_Handle = Selector.GetHandle("shouldChangeTextInRanges:replacementStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldDrawInsertionPoint = "shouldDrawInsertionPoint";

	private static readonly IntPtr selShouldDrawInsertionPointHandle = Selector.GetHandle("shouldDrawInsertionPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldReplaceCharactersInRanges_WithStrings_ = "shouldReplaceCharactersInRanges:withStrings:";

	private static readonly IntPtr selShouldReplaceCharactersInRanges_WithStrings_Handle = Selector.GetHandle("shouldReplaceCharactersInRanges:withStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowFindIndicatorForRange_ = "showFindIndicatorForRange:";

	private static readonly IntPtr selShowFindIndicatorForRange_Handle = Selector.GetHandle("showFindIndicatorForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartDeleteRangeForProposedRange_ = "smartDeleteRangeForProposedRange:";

	private static readonly IntPtr selSmartDeleteRangeForProposedRange_Handle = Selector.GetHandle("smartDeleteRangeForProposedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartInsertAfterStringForString_ReplacingRange_ = "smartInsertAfterStringForString:replacingRange:";

	private static readonly IntPtr selSmartInsertAfterStringForString_ReplacingRange_Handle = Selector.GetHandle("smartInsertAfterStringForString:replacingRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartInsertBeforeStringForString_ReplacingRange_ = "smartInsertBeforeStringForString:replacingRange:";

	private static readonly IntPtr selSmartInsertBeforeStringForString_ReplacingRange_Handle = Selector.GetHandle("smartInsertBeforeStringForString:replacingRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartInsertDeleteEnabled = "smartInsertDeleteEnabled";

	private static readonly IntPtr selSmartInsertDeleteEnabledHandle = Selector.GetHandle("smartInsertDeleteEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartInsertForString_ReplacingRange_BeforeString_AfterString_ = "smartInsertForString:replacingRange:beforeString:afterString:";

	private static readonly IntPtr selSmartInsertForString_ReplacingRange_BeforeString_AfterString_Handle = Selector.GetHandle("smartInsertForString:replacingRange:beforeString:afterString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpellCheckerDocumentTag = "spellCheckerDocumentTag";

	private static readonly IntPtr selSpellCheckerDocumentTagHandle = Selector.GetHandle("spellCheckerDocumentTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSpeaking_ = "startSpeaking:";

	private static readonly IntPtr selStartSpeaking_Handle = Selector.GetHandle("startSpeaking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSpeaking_ = "stopSpeaking:";

	private static readonly IntPtr selStopSpeaking_Handle = Selector.GetHandle("stopSpeaking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringAtIndex_EffectiveRange_EndsWithSearchBoundary_ = "stringAtIndex:effectiveRange:endsWithSearchBoundary:";

	private static readonly IntPtr selStringAtIndex_EffectiveRange_EndsWithSearchBoundary_Handle = Selector.GetHandle("stringAtIndex:effectiveRange:endsWithSearchBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringLength = "stringLength";

	private static readonly IntPtr selStringLengthHandle = Selector.GetHandle("stringLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStronglyReferencesTextStorage = "stronglyReferencesTextStorage";

	private static readonly IntPtr selStronglyReferencesTextStorageHandle = Selector.GetHandle("stronglyReferencesTextStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainer = "textContainer";

	private static readonly IntPtr selTextContainerHandle = Selector.GetHandle("textContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerInset = "textContainerInset";

	private static readonly IntPtr selTextContainerInsetHandle = Selector.GetHandle("textContainerInset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerOrigin = "textContainerOrigin";

	private static readonly IntPtr selTextContainerOriginHandle = Selector.GetHandle("textContainerOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStorage = "textStorage";

	private static readonly IntPtr selTextStorageHandle = Selector.GetHandle("textStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTightenKerning_ = "tightenKerning:";

	private static readonly IntPtr selTightenKerning_Handle = Selector.GetHandle("tightenKerning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticDashSubstitution_ = "toggleAutomaticDashSubstitution:";

	private static readonly IntPtr selToggleAutomaticDashSubstitution_Handle = Selector.GetHandle("toggleAutomaticDashSubstitution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticDataDetection_ = "toggleAutomaticDataDetection:";

	private static readonly IntPtr selToggleAutomaticDataDetection_Handle = Selector.GetHandle("toggleAutomaticDataDetection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticLinkDetection_ = "toggleAutomaticLinkDetection:";

	private static readonly IntPtr selToggleAutomaticLinkDetection_Handle = Selector.GetHandle("toggleAutomaticLinkDetection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticQuoteSubstitution_ = "toggleAutomaticQuoteSubstitution:";

	private static readonly IntPtr selToggleAutomaticQuoteSubstitution_Handle = Selector.GetHandle("toggleAutomaticQuoteSubstitution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticSpellingCorrection_ = "toggleAutomaticSpellingCorrection:";

	private static readonly IntPtr selToggleAutomaticSpellingCorrection_Handle = Selector.GetHandle("toggleAutomaticSpellingCorrection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticTextCompletion_ = "toggleAutomaticTextCompletion:";

	private static readonly IntPtr selToggleAutomaticTextCompletion_Handle = Selector.GetHandle("toggleAutomaticTextCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleAutomaticTextReplacement_ = "toggleAutomaticTextReplacement:";

	private static readonly IntPtr selToggleAutomaticTextReplacement_Handle = Selector.GetHandle("toggleAutomaticTextReplacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleContinuousSpellChecking_ = "toggleContinuousSpellChecking:";

	private static readonly IntPtr selToggleContinuousSpellChecking_Handle = Selector.GetHandle("toggleContinuousSpellChecking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleGrammarChecking_ = "toggleGrammarChecking:";

	private static readonly IntPtr selToggleGrammarChecking_Handle = Selector.GetHandle("toggleGrammarChecking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleQuickLookPreviewPanel_ = "toggleQuickLookPreviewPanel:";

	private static readonly IntPtr selToggleQuickLookPreviewPanel_Handle = Selector.GetHandle("toggleQuickLookPreviewPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleSmartInsertDelete_ = "toggleSmartInsertDelete:";

	private static readonly IntPtr selToggleSmartInsertDelete_Handle = Selector.GetHandle("toggleSmartInsertDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleTraditionalCharacterShape_ = "toggleTraditionalCharacterShape:";

	private static readonly IntPtr selToggleTraditionalCharacterShape_Handle = Selector.GetHandle("toggleTraditionalCharacterShape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchBar_MakeItemForIdentifier_ = "touchBar:makeItemForIdentifier:";

	private static readonly IntPtr selTouchBar_MakeItemForIdentifier_Handle = Selector.GetHandle("touchBar:makeItemForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurnOffKerning_ = "turnOffKerning:";

	private static readonly IntPtr selTurnOffKerning_Handle = Selector.GetHandle("turnOffKerning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurnOffLigatures_ = "turnOffLigatures:";

	private static readonly IntPtr selTurnOffLigatures_Handle = Selector.GetHandle("turnOffLigatures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypingAttributes = "typingAttributes";

	private static readonly IntPtr selTypingAttributesHandle = Selector.GetHandle("typingAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnmarkText = "unmarkText";

	private static readonly IntPtr selUnmarkTextHandle = Selector.GetHandle("unmarkText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCandidates = "updateCandidates";

	private static readonly IntPtr selUpdateCandidatesHandle = Selector.GetHandle("updateCandidates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateDragTypeRegistration = "updateDragTypeRegistration";

	private static readonly IntPtr selUpdateDragTypeRegistrationHandle = Selector.GetHandle("updateDragTypeRegistration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateFontPanel = "updateFontPanel";

	private static readonly IntPtr selUpdateFontPanelHandle = Selector.GetHandle("updateFontPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateInsertionPointStateAndRestartTimer_ = "updateInsertionPointStateAndRestartTimer:";

	private static readonly IntPtr selUpdateInsertionPointStateAndRestartTimer_Handle = Selector.GetHandle("updateInsertionPointStateAndRestartTimer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateQuickLookPreviewPanel = "updateQuickLookPreviewPanel";

	private static readonly IntPtr selUpdateQuickLookPreviewPanelHandle = Selector.GetHandle("updateQuickLookPreviewPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateRuler = "updateRuler";

	private static readonly IntPtr selUpdateRulerHandle = Selector.GetHandle("updateRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTextTouchBarItems = "updateTextTouchBarItems";

	private static readonly IntPtr selUpdateTextTouchBarItemsHandle = Selector.GetHandle("updateTextTouchBarItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTouchBarItemIdentifiers = "updateTouchBarItemIdentifiers";

	private static readonly IntPtr selUpdateTouchBarItemIdentifiersHandle = Selector.GetHandle("updateTouchBarItemIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseAllLigatures_ = "useAllLigatures:";

	private static readonly IntPtr selUseAllLigatures_Handle = Selector.GetHandle("useAllLigatures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseStandardKerning_ = "useStandardKerning:";

	private static readonly IntPtr selUseStandardKerning_Handle = Selector.GetHandle("useStandardKerning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseStandardLigatures_ = "useStandardLigatures:";

	private static readonly IntPtr selUseStandardLigatures_Handle = Selector.GetHandle("useStandardLigatures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesAdaptiveColorMappingForDarkAppearance = "usesAdaptiveColorMappingForDarkAppearance";

	private static readonly IntPtr selUsesAdaptiveColorMappingForDarkAppearanceHandle = Selector.GetHandle("usesAdaptiveColorMappingForDarkAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFindBar = "usesFindBar";

	private static readonly IntPtr selUsesFindBarHandle = Selector.GetHandle("usesFindBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFindPanel = "usesFindPanel";

	private static readonly IntPtr selUsesFindPanelHandle = Selector.GetHandle("usesFindPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFontPanel = "usesFontPanel";

	private static readonly IntPtr selUsesFontPanelHandle = Selector.GetHandle("usesFontPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesInspectorBar = "usesInspectorBar";

	private static readonly IntPtr selUsesInspectorBarHandle = Selector.GetHandle("usesInspectorBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesRolloverButtonForSelection = "usesRolloverButtonForSelection";

	private static readonly IntPtr selUsesRolloverButtonForSelectionHandle = Selector.GetHandle("usesRolloverButtonForSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesRuler = "usesRuler";

	private static readonly IntPtr selUsesRulerHandle = Selector.GetHandle("usesRuler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidAttributesForMarkedText = "validAttributesForMarkedText";

	private static readonly IntPtr selValidAttributesForMarkedTextHandle = Selector.GetHandle("validAttributesForMarkedText");

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
	private const string selVisibleCharacterRanges = "visibleCharacterRanges";

	private static readonly IntPtr selVisibleCharacterRangesHandle = Selector.GetHandle("visibleCharacterRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowLevel = "windowLevel";

	private static readonly IntPtr selWindowLevelHandle = Selector.GetHandle("windowLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritablePasteboardTypes = "writablePasteboardTypes";

	private static readonly IntPtr selWritablePasteboardTypesHandle = Selector.GetHandle("writablePasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteSelectionToPasteboard_Type_ = "writeSelectionToPasteboard:type:";

	private static readonly IntPtr selWriteSelectionToPasteboard_Type_Handle = Selector.GetHandle("writeSelectionToPasteboard:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteSelectionToPasteboard_Types_ = "writeSelectionToPasteboard:types:";

	private static readonly IntPtr selWriteSelectionToPasteboard_Types_Handle = Selector.GetHandle("writeSelectionToPasteboard:types:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeSelectionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeTypingAttributesNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillChangeNotifyingTextViewNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsGlyphInfo
	{
		[Export("acceptsGlyphInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsGlyphInfoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsGlyphInfoHandle);
		}
		[Export("setAcceptsGlyphInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsGlyphInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsGlyphInfo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSRange AccessibilityVisibleCharacterRange
	{
		[Export("accessibilityVisibleCharacterRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityVisibleCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCharacterRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AllowedInputSourceLocales
	{
		[Export("allowedInputSourceLocales")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedInputSourceLocalesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedInputSourceLocalesHandle));
		}
		[Export("setAllowedInputSourceLocales:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedInputSourceLocales_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedInputSourceLocales_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual bool AllowsCharacterPickerTouchBarItem
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("allowsCharacterPickerTouchBarItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCharacterPickerTouchBarItemHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCharacterPickerTouchBarItemHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("setAllowsCharacterPickerTouchBarItem:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCharacterPickerTouchBarItem_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCharacterPickerTouchBarItem_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsDocumentBackgroundColorChange
	{
		[Export("allowsDocumentBackgroundColorChange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDocumentBackgroundColorChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDocumentBackgroundColorChangeHandle);
		}
		[Export("setAllowsDocumentBackgroundColorChange:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDocumentBackgroundColorChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDocumentBackgroundColorChange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsImageEditing
	{
		[Export("allowsImageEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsImageEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsImageEditingHandle);
		}
		[Export("setAllowsImageEditing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsImageEditing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsImageEditing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsUndo
	{
		[Export("allowsUndo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsUndoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsUndoHandle);
		}
		[Export("setAllowsUndo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsUndo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsUndo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedString
	{
		[Export("attributedString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticDashSubstitutionEnabled
	{
		[Export("isAutomaticDashSubstitutionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticDashSubstitutionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticDashSubstitutionEnabledHandle);
		}
		[Export("setAutomaticDashSubstitutionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticDashSubstitutionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticDashSubstitutionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticDataDetectionEnabled
	{
		[Export("isAutomaticDataDetectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticDataDetectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticDataDetectionEnabledHandle);
		}
		[Export("setAutomaticDataDetectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticDataDetectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticDataDetectionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticLinkDetectionEnabled
	{
		[Export("isAutomaticLinkDetectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticLinkDetectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticLinkDetectionEnabledHandle);
		}
		[Export("setAutomaticLinkDetectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticLinkDetectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticLinkDetectionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticQuoteSubstitutionEnabled
	{
		[Export("isAutomaticQuoteSubstitutionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticQuoteSubstitutionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticQuoteSubstitutionEnabledHandle);
		}
		[Export("setAutomaticQuoteSubstitutionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticQuoteSubstitutionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticQuoteSubstitutionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticSpellingCorrectionEnabled
	{
		[Export("isAutomaticSpellingCorrectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticSpellingCorrectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticSpellingCorrectionEnabledHandle);
		}
		[Export("setAutomaticSpellingCorrectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticSpellingCorrectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticSpellingCorrectionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
	public virtual bool AutomaticTextCompletionEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
		[Export("isAutomaticTextCompletionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticTextCompletionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticTextCompletionEnabledHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
		[Export("setAutomaticTextCompletionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTextCompletionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTextCompletionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticTextReplacementEnabled
	{
		[Export("isAutomaticTextReplacementEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticTextReplacementEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticTextReplacementEnabledHandle);
		}
		[Export("setAutomaticTextReplacementEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTextReplacementEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTextReplacementEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:")]
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
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSCandidateListTouchBarItem? CandidateListTouchBarItem
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("candidateListTouchBarItem", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCandidateListTouchBarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCandidateListTouchBarItemHandle));
			}
			return Runtime.GetNSObject<NSCandidateListTouchBarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCandidateListTouchBarItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContinuousSpellCheckingEnabled
	{
		[Export("isContinuousSpellCheckingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousSpellCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousSpellCheckingEnabledHandle);
		}
		[Export("setContinuousSpellCheckingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ConversationIdentifier
	{
		[Export("conversationIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selConversationIdentifierHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selConversationIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSParagraphStyle DefaultParagraphStyle
	{
		[Export("defaultParagraphStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSParagraphStyle>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultParagraphStyleHandle));
			}
			return Runtime.GetNSObject<NSParagraphStyle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultParagraphStyleHandle));
		}
		[Export("setDefaultParagraphStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultParagraphStyle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultParagraphStyle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSTextViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTextViewDelegate;
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
	public virtual bool DisplaysLinkToolTips
	{
		[Export("displaysLinkToolTips")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLinkToolTipsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLinkToolTipsHandle);
		}
		[Export("setDisplaysLinkToolTips:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLinkToolTips_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLinkToolTips_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool DrawsBackground
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
	public new virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingTypes EnabledTextCheckingTypes
	{
		[Export("enabledTextCheckingTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextCheckingTypes)Messaging.UInt64_objc_msgSend(base.Handle, selEnabledTextCheckingTypesHandle);
			}
			return (NSTextCheckingTypes)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEnabledTextCheckingTypesHandle);
		}
		[Export("setEnabledTextCheckingTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetEnabledTextCheckingTypes_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetEnabledTextCheckingTypes_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool FieldEditor
	{
		[Export("isFieldEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFieldEditorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFieldEditorHandle);
		}
		[Export("setFieldEditor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldEditor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldEditor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange FirstSelectedRange
	{
		[Export("firstSelectedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selFirstSelectedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selFirstSelectedRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GrammarCheckingEnabled
	{
		[Export("isGrammarCheckingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGrammarCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGrammarCheckingEnabledHandle);
		}
		[Export("setGrammarCheckingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGrammarCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGrammarCheckingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMarkedText
	{
		[Export("hasMarkedText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasMarkedTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMarkedTextHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool ImportsGraphics
	{
		[Export("importsGraphics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImportsGraphicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImportsGraphicsHandle);
		}
		[Export("setImportsGraphics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImportsGraphics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImportsGraphics_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor InsertionPointColor
	{
		[Export("insertionPointColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertionPointColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertionPointColorHandle));
		}
		[Export("setInsertionPointColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInsertionPointColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInsertionPointColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsIncrementalSearchingEnabled
	{
		[Export("isIncrementalSearchingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIncrementalSearchingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIncrementalSearchingEnabledHandle);
		}
		[Export("setIncrementalSearchingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncrementalSearchingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncrementalSearchingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutManager LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle));
			}
			return Runtime.GetNSObject<NSLayoutManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextLayoutOrientation LayoutOrientation
	{
		[Export("layoutOrientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextLayoutOrientation)Messaging.Int64_objc_msgSend(base.Handle, selLayoutOrientationHandle);
			}
			return (NSTextLayoutOrientation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayoutOrientationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary LinkTextAttributes
	{
		[Export("linkTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selLinkTextAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinkTextAttributesHandle));
		}
		[Export("setLinkTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLinkTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLinkTextAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange MarkedRange
	{
		[Export("markedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selMarkedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selMarkedRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary MarkedTextAttributes
	{
		[Export("markedTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMarkedTextAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkedTextAttributesHandle));
		}
		[Export("setMarkedTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarkedTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarkedTextAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool RichText
	{
		[Export("isRichText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRichTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRichTextHandle);
		}
		[Export("setRichText:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRichText_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRichText_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RulerVisible
	{
		[Export("isRulerVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRulerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRulerVisibleHandle);
		}
		[Export("setRulerVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRulerVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRulerVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray SelectedRanges
	{
		[Export("selectedRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRangesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRangesHandle));
		}
		[Export("setSelectedRanges:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedRanges_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedRanges_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary SelectedTextAttributes
	{
		[Export("selectedTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedTextAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedTextAttributesHandle));
		}
		[Export("setSelectedTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedTextAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSelectionGranularity SelectionGranularity
	{
		[Export("selectionGranularity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSelectionGranularity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionGranularityHandle);
			}
			return (NSSelectionGranularity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionGranularityHandle);
		}
		[Export("setSelectionGranularity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSelectionGranularity_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSelectionGranularity_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDrawInsertionPoint
	{
		[Export("shouldDrawInsertionPoint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDrawInsertionPointHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDrawInsertionPointHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SmartInsertDeleteEnabled
	{
		[Export("smartInsertDeleteEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSmartInsertDeleteEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSmartInsertDeleteEnabledHandle);
		}
		[Export("setSmartInsertDeleteEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static bool StronglyReferencesTextStorage
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("stronglyReferencesTextStorage")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selStronglyReferencesTextStorageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextContainer TextContainer
	{
		[Export("textContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContainerHandle));
			}
			return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContainerHandle));
		}
		[Export("setTextContainer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextContainer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextContainer_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize TextContainerInset
	{
		[Export("textContainerInset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selTextContainerInsetHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selTextContainerInsetHandle);
		}
		[Export("setTextContainerInset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetTextContainerInset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetTextContainerInset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint TextContainerOrigin
	{
		[Export("textContainerOrigin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selTextContainerOriginHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTextContainerOriginHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextStorage TextStorage
	{
		[Export("textStorage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStorageHandle));
			}
			return Runtime.GetNSObject<NSTextStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStorageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary TypingAttributes
	{
		[Export("typingAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTypingAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypingAttributesHandle));
		}
		[Export("setTypingAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypingAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypingAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual bool UsesAdaptiveColorMappingForDarkAppearance
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("usesAdaptiveColorMappingForDarkAppearance")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesAdaptiveColorMappingForDarkAppearanceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesAdaptiveColorMappingForDarkAppearanceHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setUsesAdaptiveColorMappingForDarkAppearance:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesAdaptiveColorMappingForDarkAppearance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesAdaptiveColorMappingForDarkAppearance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesFindBar
	{
		[Export("usesFindBar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFindBarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFindBarHandle);
		}
		[Export("setUsesFindBar:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFindBar_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFindBar_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesFindPanel
	{
		[Export("usesFindPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFindPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFindPanelHandle);
		}
		[Export("setUsesFindPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFindPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFindPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool UsesFontPanel
	{
		[Export("usesFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontPanelHandle);
		}
		[Export("setUsesFontPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesInspectorBar
	{
		[Export("usesInspectorBar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesInspectorBarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesInspectorBarHandle);
		}
		[Export("setUsesInspectorBar:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesInspectorBar_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesInspectorBar_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool UsesRolloverButtonForSelection
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("usesRolloverButtonForSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesRolloverButtonForSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesRolloverButtonForSelectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUsesRolloverButtonForSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesRolloverButtonForSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesRolloverButtonForSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesRuler
	{
		[Export("usesRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesRulerHandle);
		}
		[Export("setUsesRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesRuler_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] ValidAttributesForMarkedText
	{
		[Export("validAttributesForMarkedText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selValidAttributesForMarkedTextHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValidAttributesForMarkedTextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray VisibleCharacterRanges
	{
		[Export("visibleCharacterRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleCharacterRangesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleCharacterRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDelegate
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
	public virtual NSWindowLevel WindowLevel
	{
		[Export("windowLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowLevel)Messaging.Int64_objc_msgSend(base.Handle, selWindowLevelHandle);
			}
			return (NSWindowLevel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWindowLevelHandle);
		}
	}

	[Field("NSTextViewDidChangeSelectionNotification", "AppKit")]
	[Advice("Use NSTextView.Notifications.ObserveDidChangeSelection helper method instead.")]
	public static NSString DidChangeSelectionNotification
	{
		get
		{
			if (_DidChangeSelectionNotification == null)
			{
				_DidChangeSelectionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextViewDidChangeSelectionNotification");
			}
			return _DidChangeSelectionNotification;
		}
	}

	[Field("NSTextViewDidChangeTypingAttributesNotification", "AppKit")]
	[Advice("Use NSTextView.Notifications.ObserveDidChangeTypingAttributes helper method instead.")]
	public static NSString DidChangeTypingAttributesNotification
	{
		get
		{
			if (_DidChangeTypingAttributesNotification == null)
			{
				_DidChangeTypingAttributesNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextViewDidChangeTypingAttributesNotification");
			}
			return _DidChangeTypingAttributesNotification;
		}
	}

	[Field("NSTextViewWillChangeNotifyingTextViewNotification", "AppKit")]
	[Advice("Use NSTextView.Notifications.ObserveWillChangeNotifyingTextView helper method instead.")]
	public static NSString WillChangeNotifyingTextViewNotification
	{
		get
		{
			if (_WillChangeNotifyingTextViewNotification == null)
			{
				_WillChangeNotifyingTextViewNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextViewWillChangeNotifyingTextViewNotification");
			}
			return _WillChangeNotifyingTextViewNotification;
		}
	}

	internal override Type GetInternalEventDelegateType => typeof(_NSTextViewDelegate);

	public NSTextViewTextChecked? DidCheckText
	{
		get
		{
			return EnsureNSTextViewDelegate().didCheckText;
		}
		set
		{
			EnsureNSTextViewDelegate().didCheckText = value;
		}
	}

	public NSTextViewSelectorCommand? DoCommandBySelector
	{
		get
		{
			return EnsureNSTextViewDelegate().doCommandBySelector;
		}
		set
		{
			EnsureNSTextViewDelegate().doCommandBySelector = value;
		}
	}

	public NSTextViewGetCandidates? GetCandidates
	{
		get
		{
			return EnsureNSTextViewDelegate().getCandidates;
		}
		set
		{
			EnsureNSTextViewDelegate().getCandidates = value;
		}
	}

	public NSTextViewCompletion? GetCompletions
	{
		get
		{
			return EnsureNSTextViewDelegate().getCompletions;
		}
		set
		{
			EnsureNSTextViewDelegate().getCompletions = value;
		}
	}

	public NSTextViewTextCheckingResults? GetTextCheckingCandidates
	{
		get
		{
			return EnsureNSTextViewDelegate().getTextCheckingCandidates;
		}
		set
		{
			EnsureNSTextViewDelegate().getTextCheckingCandidates = value;
		}
	}

	public NSTextViewGetUndoManager? GetUndoManager
	{
		get
		{
			return EnsureNSTextViewDelegate().getUndoManager;
		}
		set
		{
			EnsureNSTextViewDelegate().getUndoManager = value;
		}
	}

	public NSTextViewCellPosition? GetWritablePasteboardTypes
	{
		get
		{
			return EnsureNSTextViewDelegate().getWritablePasteboardTypes;
		}
		set
		{
			EnsureNSTextViewDelegate().getWritablePasteboardTypes = value;
		}
	}

	public NSTextViewLink? LinkClicked
	{
		get
		{
			return EnsureNSTextViewDelegate().linkClicked;
		}
		set
		{
			EnsureNSTextViewDelegate().linkClicked = value;
		}
	}

	public new NSTextViewEventMenu? MenuForEvent
	{
		get
		{
			return EnsureNSTextViewDelegate().menuForEvent;
		}
		set
		{
			EnsureNSTextViewDelegate().menuForEvent = value;
		}
	}

	public NSTextViewChangeText? ShouldChangeTextInRange
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldChangeTextInRange;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldChangeTextInRange = value;
		}
	}

	public NSTextViewSelectionShouldChange? ShouldChangeTextInRanges
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldChangeTextInRanges;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldChangeTextInRanges = value;
		}
	}

	public NSTextViewTypeAttribute? ShouldChangeTypingAttributes
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldChangeTypingAttributes;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldChangeTypingAttributes = value;
		}
	}

	public NSTextViewSelectCandidate? ShouldSelectCandidates
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldSelectCandidates;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldSelectCandidates = value;
		}
	}

	public NSTextViewSpellingQuery? ShouldSetSpellingState
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldSetSpellingState;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldSetSpellingState = value;
		}
	}

	public NSTextViewUpdateTouchBarItemIdentifiers? ShouldUpdateTouchBarItemIdentifiers
	{
		get
		{
			return EnsureNSTextViewDelegate().shouldUpdateTouchBarItemIdentifiers;
		}
		set
		{
			EnsureNSTextViewDelegate().shouldUpdateTouchBarItemIdentifiers = value;
		}
	}

	public NSTextViewSelectionChange? WillChangeSelection
	{
		get
		{
			return EnsureNSTextViewDelegate().willChangeSelection;
		}
		set
		{
			EnsureNSTextViewDelegate().willChangeSelection = value;
		}
	}

	public NSTextViewSelectionWillChange? WillChangeSelectionFromRanges
	{
		get
		{
			return EnsureNSTextViewDelegate().willChangeSelectionFromRanges;
		}
		set
		{
			EnsureNSTextViewDelegate().willChangeSelectionFromRanges = value;
		}
	}

	public NSTextViewOnTextCheck? WillCheckText
	{
		get
		{
			return EnsureNSTextViewDelegate().willCheckText;
		}
		set
		{
			EnsureNSTextViewDelegate().willCheckText = value;
		}
	}

	public NSTextViewTooltip? WillDisplayToolTip
	{
		get
		{
			return EnsureNSTextViewDelegate().willDisplayToolTip;
		}
		set
		{
			EnsureNSTextViewDelegate().willDisplayToolTip = value;
		}
	}

	public NSTextViewCellPasteboard? WriteCell
	{
		get
		{
			return EnsureNSTextViewDelegate().writeCell;
		}
		set
		{
			EnsureNSTextViewDelegate().writeCell = value;
		}
	}

	public event EventHandler<NSTextViewClickedEventArgs> CellClicked
	{
		add
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.cellClicked = (EventHandler<NSTextViewClickedEventArgs>)System.Delegate.Combine(nSTextViewDelegate.cellClicked, value);
		}
		remove
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.cellClicked = (EventHandler<NSTextViewClickedEventArgs>)System.Delegate.Remove(nSTextViewDelegate.cellClicked, value);
		}
	}

	public event EventHandler<NSTextViewDoubleClickEventArgs> CellDoubleClicked
	{
		add
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.cellDoubleClicked = (EventHandler<NSTextViewDoubleClickEventArgs>)System.Delegate.Combine(nSTextViewDelegate.cellDoubleClicked, value);
		}
		remove
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.cellDoubleClicked = (EventHandler<NSTextViewDoubleClickEventArgs>)System.Delegate.Remove(nSTextViewDelegate.cellDoubleClicked, value);
		}
	}

	public event EventHandler DidChangeSelection
	{
		add
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.didChangeSelection = (EventHandler)System.Delegate.Combine(nSTextViewDelegate.didChangeSelection, value);
		}
		remove
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.didChangeSelection = (EventHandler)System.Delegate.Remove(nSTextViewDelegate.didChangeSelection, value);
		}
	}

	public event EventHandler DidChangeTypingAttributes
	{
		add
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.didChangeTypingAttributes = (EventHandler)System.Delegate.Combine(nSTextViewDelegate.didChangeTypingAttributes, value);
		}
		remove
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.didChangeTypingAttributes = (EventHandler)System.Delegate.Remove(nSTextViewDelegate.didChangeTypingAttributes, value);
		}
	}

	public event EventHandler<NSTextViewDraggedCellEventArgs> DraggedCell
	{
		add
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.draggedCell = (EventHandler<NSTextViewDraggedCellEventArgs>)System.Delegate.Combine(nSTextViewDelegate.draggedCell, value);
		}
		remove
		{
			_NSTextViewDelegate nSTextViewDelegate = EnsureNSTextViewDelegate();
			nSTextViewDelegate.draggedCell = (EventHandler<NSTextViewDraggedCellEventArgs>)System.Delegate.Remove(nSTextViewDelegate.draggedCell, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextView()
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
	public NSTextView(NSCoder coder)
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
	protected NSTextView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:textContainer:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextView(CGRect frameRect, NSTextContainer container)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrame_TextContainer_Handle, frameRect, container.Handle), "initWithFrame:textContainer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrame_TextContainer_Handle, frameRect, container.Handle), "initWithFrame:textContainer:");
		}
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextView(CGRect frameRect)
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

	[Export("acceptableDragTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AcceptableDragTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAcceptableDragTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAcceptableDragTypesHandle));
	}

	[Export("alignJustified:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignJustified(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignJustified_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignJustified_Handle, sender.Handle);
		}
	}

	[Export("candidateListTouchBarItem:beginSelectingCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginSelectingCandidate(NSCandidateListTouchBarItem anItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_Handle, anItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_Handle, anItem.Handle, index);
		}
	}

	[Export("breakUndoCoalescing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BreakUndoCoalescing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBreakUndoCoalescingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBreakUndoCoalescingHandle);
		}
	}

	[Export("changeAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeAttributes(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeAttributes_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeAttributes_Handle, sender.Handle);
		}
	}

	[Export("changeColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeColor(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeColor_Handle, sender.Handle);
		}
	}

	[Export("changeDocumentBackgroundColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeDocumentBackgroundColor(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
	}

	[Export("changeLayoutOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeLayoutOrientation(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeLayoutOrientation_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeLayoutOrientation_Handle, sender.Handle);
		}
	}

	[Export("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeSelectionFromCandidate(NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_nint(base.Handle, selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_Handle, anItem.Handle, previousIndex, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_nint(base.SuperHandle, selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_Handle, anItem.Handle, previousIndex, index);
		}
	}

	[Export("candidateListTouchBarItem:changedCandidateListVisibility:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangedCandidateListVisibility(NSCandidateListTouchBarItem anItem, bool isVisible)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selCandidateListTouchBarItem_ChangedCandidateListVisibility_Handle, anItem.Handle, isVisible);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selCandidateListTouchBarItem_ChangedCandidateListVisibility_Handle, anItem.Handle, isVisible);
		}
	}

	[Export("characterIndexForInsertionAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CharacterIndex(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint(base.Handle, selCharacterIndexForInsertionAtPoint_Handle, point);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCharacterIndexForInsertionAtPoint_Handle, point);
	}

	[Export("checkTextInRange:types:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckText(NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selCheckTextInRange_Types_Options_Handle, range, (ulong)checkingTypes, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selCheckTextInRange_Types_Options_Handle, range, (ulong)checkingTypes, options.Handle);
		}
	}

	[Export("checkTextInDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckTextInDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInDocument_Handle, sender.Handle);
		}
	}

	[Export("checkTextInSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckTextInSelection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInSelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInSelection_Handle, sender.Handle);
		}
	}

	[Export("cleanUpAfterDragOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CleanUpAfterDragOperation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCleanUpAfterDragOperationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCleanUpAfterDragOperationHandle);
		}
	}

	[Export("clickedOnLink:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClickedOnLink(NSObject link, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (link == null)
		{
			throw new ArgumentNullException("link");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selClickedOnLink_AtIndex_Handle, link.Handle, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selClickedOnLink_AtIndex_Handle, link.Handle, charIndex);
		}
	}

	[Export("complete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Complete(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selComplete_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selComplete_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("completionsForPartialWordRange:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] CompletionsForPartialWord(NSRange charRange, out nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_out_nint(base.Handle, selCompletionsForPartialWordRange_IndexOfSelectedItem_Handle, charRange, out index));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_out_nint(base.SuperHandle, selCompletionsForPartialWordRange_IndexOfSelectedItem_Handle, charRange, out index));
	}

	[Export("contentViewAtIndex:effectiveCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView ContentViewAtIndexeffectiveCharacterRange(nuint index, ref NSRange outRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_nuint_ref_NSRange(base.Handle, selContentViewAtIndex_EffectiveCharacterRange_Handle, index, ref outRange));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_nuint_ref_NSRange(base.SuperHandle, selContentViewAtIndex_EffectiveCharacterRange_Handle, index, ref outRange));
	}

	[Export("fieldEditor")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextView CreateFieldEditor()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSend(class_ptr, selFieldEditorHandle));
	}

	[Export("scrollableDocumentContentTextView")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSScrollView CreateScrollableDocumentContentTextView()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSend(class_ptr, selScrollableDocumentContentTextViewHandle));
	}

	[Export("scrollablePlainDocumentContentTextView")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSScrollView CreateScrollablePlainDocumentContentTextView()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSend(class_ptr, selScrollablePlainDocumentContentTextViewHandle));
	}

	[Export("scrollableTextView")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSScrollView CreateScrollableTextView()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSend(class_ptr, selScrollableTextViewHandle));
	}

	[Export("didChangeText")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeText()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidChangeTextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidChangeTextHandle);
		}
	}

	[Export("didReplaceCharacters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReplaceCharacters()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidReplaceCharactersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidReplaceCharactersHandle);
		}
	}

	[Export("dragOperationForDraggingInfo:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DragOperationForDraggingInfo(NSDraggingInfo dragInfo, string type)
	{
		NSApplication.EnsureUIThread();
		if (dragInfo == null)
		{
			throw new ArgumentNullException("dragInfo");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSDragOperation result = (NSDragOperation)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDragOperationForDraggingInfo_Type_Handle, dragInfo.Handle, arg) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selDragOperationForDraggingInfo_Type_Handle, dragInfo.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("draggedImage:beganAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Deprecated(PlatformName.MacOSX, 10, 1, PlatformArchitecture.All, "Use DraggedImageEndedAtOperation instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("drawCharactersInRange:forContentView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawCharactersInRangeforContentView(NSRange range, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selDrawCharactersInRange_ForContentView_Handle, range, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selDrawCharactersInRange_ForContentView_Handle, range, view.Handle);
		}
	}

	[Export("drawInsertionPointInRect:color:turnedOn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInsertionPoint(CGRect rect, NSColor color, bool turnedOn)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_bool(base.Handle, selDrawInsertionPointInRect_Color_TurnedOn_Handle, rect, color.Handle, turnedOn);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_bool(base.SuperHandle, selDrawInsertionPointInRect_Color_TurnedOn_Handle, rect, color.Handle, turnedOn);
		}
	}

	[Export("drawViewBackgroundInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawViewBackgroundInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawViewBackgroundInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawViewBackgroundInRect_Handle, rect);
		}
	}

	[Export("drawsVerticallyForCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsVertically(nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selDrawsVerticallyForCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selDrawsVerticallyForCharacterAtIndex_Handle, charIndex);
	}

	[Export("candidateListTouchBarItem:endSelectingCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSelectingCandidate(NSCandidateListTouchBarItem anItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_Handle, anItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_Handle, anItem.Handle, index);
		}
	}

	[Export("accessibilityAttributedStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityAttributedStringForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityAttributedStringForRange_Handle, range));
	}

	[Export("accessibilityFrameForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGRect GetAccessibilityFrame(NSRange range)
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

	[Export("accessibilityLineForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selAccessibilityLineForIndex_Handle, index);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityLineForIndex_Handle, index);
	}

	[Export("accessibilityRangeForLine:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSRange GetAccessibilityRangeForLine(nint lineNumber)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForLine_Handle, lineNumber);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForLine_Handle, lineNumber);
	}

	[Export("accessibilityStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityStringForRange_Handle, range));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityStringForRange_Handle, range));
	}

	[Export("attributedSubstringForProposedRange:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAttributedSubstring(NSRange proposedRange, out NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange_out_NSRange(base.Handle, selAttributedSubstringForProposedRange_ActualRange_Handle, proposedRange, out actualRange));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange_out_NSRange(base.SuperHandle, selAttributedSubstringForProposedRange_ActualRange_Handle, proposedRange, out actualRange));
	}

	[Export("attributedSubstringFromRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAttributedSubstring(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAttributedSubstringFromRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAttributedSubstringFromRange_Handle, range));
	}

	[Export("baselineDeltaForCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetBaselineDelta(nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint(base.Handle, selBaselineDeltaForCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint(base.SuperHandle, selBaselineDeltaForCharacterAtIndex_Handle, charIndex);
	}

	[Export("characterIndexForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetCharacterIndex(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint(base.Handle, selCharacterIndexForPoint_Handle, point);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCharacterIndexForPoint_Handle, point);
	}

	[Export("firstRectForCharacterRange:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetFirstRect(NSRange characterRange, out NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange_out_NSRange(out retval, base.Handle, selFirstRectForCharacterRange_ActualRange_Handle, characterRange, out actualRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange_out_NSRange(out retval, base.SuperHandle, selFirstRectForCharacterRange_ActualRange_Handle, characterRange, out actualRange);
		}
		return retval;
	}

	[Export("firstRectForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetFirstRectForCharacterRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange(out retval, base.Handle, selFirstRectForCharacterRange_Handle, range);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange(out retval, base.SuperHandle, selFirstRectForCharacterRange_Handle, range);
		}
		return retval;
	}

	[Export("fractionOfDistanceThroughGlyphForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetFractionOfDistanceThroughGlyph(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_CGPoint(base.Handle, selFractionOfDistanceThroughGlyphForPoint_Handle, point);
		}
		return Messaging.nfloat_objc_msgSendSuper_CGPoint(base.SuperHandle, selFractionOfDistanceThroughGlyphForPoint_Handle, point);
	}

	[Export("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetPreferredPasteboardType(string[] availableTypes, string[] allowedTypes)
	{
		NSApplication.EnsureUIThread();
		if (availableTypes == null)
		{
			throw new ArgumentNullException("availableTypes");
		}
		if (allowedTypes == null)
		{
			throw new ArgumentNullException("allowedTypes");
		}
		NSArray nSArray = NSArray.FromStrings(availableTypes);
		NSArray nSArray2 = NSArray.FromStrings(allowedTypes);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_Handle, nSArray.Handle, nSArray2.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_Handle, nSArray.Handle, nSArray2.Handle)));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("handleTextCheckingResults:forRange:types:options:orthography:wordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleTextChecking(NSTextCheckingResult[] results, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSOrthography orthography, nint wordCount)
	{
		NSApplication.EnsureUIThread();
		if (results == null)
		{
			throw new ArgumentNullException("results");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (orthography == null)
		{
			throw new ArgumentNullException("orthography");
		}
		NSArray nSArray = NSArray.FromNSObjects(results);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_nint(base.Handle, selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_Handle, nSArray.Handle, range, (ulong)checkingTypes, options.Handle, orthography.Handle, wordCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_nint(base.SuperHandle, selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_Handle, nSArray.Handle, range, (ulong)checkingTypes, options.Handle, orthography.Handle, wordCount);
		}
		nSArray.Dispose();
	}

	[Export("insertCompletion:forPartialWordRange:movement:isFinal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertCompletion(string completion, NSRange partialWordCharRange, nint movement, bool isFinal)
	{
		NSApplication.EnsureUIThread();
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		IntPtr arg = NSString.CreateNative(completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_nint_bool(base.Handle, selInsertCompletion_ForPartialWordRange_Movement_IsFinal_Handle, arg, partialWordCharRange, movement, isFinal);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_nint_bool(base.SuperHandle, selInsertCompletion_ForPartialWordRange_Movement_IsFinal_Handle, arg, partialWordCharRange, movement, isFinal);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertText:replacementRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertText(NSObject text, NSRange replacementRange)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selInsertText_ReplacementRange_Handle, text.Handle, replacementRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selInsertText_ReplacementRange_Handle, text.Handle, replacementRange);
		}
	}

	[Export("insertText:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertText(NSObject insertString)
	{
		NSApplication.EnsureUIThread();
		if (insertString == null)
		{
			throw new ArgumentNullException("insertString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertText_Handle, insertString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertText_Handle, insertString.Handle);
		}
	}

	[Export("invalidateTextContainerOrigin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateTextContainerOrigin()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateTextContainerOriginHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateTextContainerOriginHandle);
		}
	}

	[Export("isCoalescingUndo")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCoalescingUndo()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsCoalescingUndoHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCoalescingUndoHandle);
	}

	[Export("loosenKerning:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoosenKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoosenKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoosenKerning_Handle, sender.Handle);
		}
	}

	[Export("lowerBaseline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LowerBaseline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLowerBaseline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLowerBaseline_Handle, sender.Handle);
		}
	}

	[Export("touchBar:makeItemForIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTouchBarItem? MakeItem(NSTouchBar touchBar, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (touchBar == null)
		{
			throw new ArgumentNullException("touchBar");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSTouchBarItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTouchBarItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTouchBar_MakeItemForIdentifier_Handle, touchBar.Handle, arg)) : Runtime.GetNSObject<NSTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTouchBar_MakeItemForIdentifier_Handle, touchBar.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("orderFrontLinkPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontLinkPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontLinkPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontLinkPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontListPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontListPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontListPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontListPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontSpacingPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontSpacingPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontSpacingPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontSpacingPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontSubstitutionsPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontSubstitutionsPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontSubstitutionsPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontSubstitutionsPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontTablePanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontTablePanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontTablePanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontTablePanel_Handle, sender.Handle);
		}
	}

	[Export("outline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Outline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOutline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOutline_Handle, sender.Handle);
		}
	}

	[Export("pasteAsPlainText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteAsPlainText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsPlainText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsPlainText_Handle, sender.Handle);
		}
	}

	[Export("pasteAsRichText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteAsRichText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsRichText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsRichText_Handle, sender.Handle);
		}
	}

	[Export("performFindPanelAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformFindPanelAction(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformFindPanelAction_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformFindPanelAction_Handle, sender.Handle);
		}
	}

	[Export("performValidatedReplacementInRange:withAttributedString:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformValidatedReplacement(NSRange range, NSAttributedString attributedString)
	{
		NSApplication.EnsureUIThread();
		if (attributedString == null)
		{
			throw new ArgumentNullException("attributedString");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_NSRange_IntPtr(base.Handle, selPerformValidatedReplacementInRange_WithAttributedString_Handle, range, attributedString.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selPerformValidatedReplacementInRange_WithAttributedString_Handle, range, attributedString.Handle);
	}

	[Export("quickLookPreviewableItemsInRanges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray QuickLookPreviewableItemsInRanges(NSArray ranges)
	{
		NSApplication.EnsureUIThread();
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQuickLookPreviewableItemsInRanges_Handle, ranges.Handle));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuickLookPreviewableItemsInRanges_Handle, ranges.Handle));
	}

	[Export("raiseBaseline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RaiseBaseline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRaiseBaseline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRaiseBaseline_Handle, sender.Handle);
		}
	}

	[Export("rangeForUserCharacterAttributeChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeForUserCharacterAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserCharacterAttributeChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserCharacterAttributeChangeHandle);
	}

	[Export("rangeForUserCompletion")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeForUserCompletion()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserCompletionHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserCompletionHandle);
	}

	[Export("rangeForUserParagraphAttributeChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeForUserParagraphAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserParagraphAttributeChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserParagraphAttributeChangeHandle);
	}

	[Export("rangeForUserTextChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeForUserTextChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserTextChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserTextChangeHandle);
	}

	[Export("rangesForUserCharacterAttributeChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray RangesForUserCharacterAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserCharacterAttributeChangeHandle));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserCharacterAttributeChangeHandle));
	}

	[Export("rangesForUserParagraphAttributeChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray RangesForUserParagraphAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserParagraphAttributeChangeHandle));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserParagraphAttributeChangeHandle));
	}

	[Export("rangesForUserTextChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray RangesForUserTextChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserTextChangeHandle));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserTextChangeHandle));
	}

	[Export("readSelectionFromPasteboard:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadSelectionFromPasteboard(NSPasteboard pboard, string type)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReadSelectionFromPasteboard_Type_Handle, pboard.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selReadSelectionFromPasteboard_Type_Handle, pboard.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readSelectionFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadSelectionFromPasteboard(NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selReadSelectionFromPasteboard_Handle, pboard.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadSelectionFromPasteboard_Handle, pboard.Handle);
	}

	[Export("readablePasteboardTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ReadablePasteboardTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReadablePasteboardTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadablePasteboardTypesHandle));
	}

	[Export("rectsForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray RectsForCharacterRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRectsForCharacterRange_Handle, range));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRectsForCharacterRange_Handle, range));
	}

	[Export("registerForServices")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterForServices()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selRegisterForServicesHandle);
	}

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceCharactersInRangewithString(NSRange range, string str)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceTextContainer(NSTextContainer newContainer)
	{
		NSApplication.EnsureUIThread();
		if (newContainer == null)
		{
			throw new ArgumentNullException("newContainer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceTextContainer_Handle, newContainer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceTextContainer_Handle, newContainer.Handle);
		}
	}

	[Export("rulerView:didAddMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RulerViewDidAddMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_DidAddMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_DidAddMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:didMoveMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RulerViewDidMoveMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_DidMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_DidMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:didRemoveMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RulerViewDidRemoveMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_DidRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_DidRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:handleMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RulerViewHandleMouseDown(NSRulerView ruler, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_HandleMouseDown_Handle, ruler.Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_HandleMouseDown_Handle, ruler.Handle, theEvent.Handle);
		}
	}

	[Export("rulerView:shouldAddMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RulerViewShouldAddMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_ShouldAddMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_ShouldAddMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:shouldMoveMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RulerViewShouldMoveMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_ShouldMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_ShouldMoveMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:shouldRemoveMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RulerViewShouldRemoveMarker(NSRulerView ruler, NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerView_ShouldRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerView_ShouldRemoveMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:willAddMarker:atLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RulerViewWillAddMarker(NSRulerView ruler, NSRulerMarker marker, nfloat location)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_IntPtr_nfloat(base.Handle, selRulerView_WillAddMarker_AtLocation_Handle, ruler.Handle, marker.Handle, location);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_IntPtr_nfloat(base.SuperHandle, selRulerView_WillAddMarker_AtLocation_Handle, ruler.Handle, marker.Handle, location);
	}

	[Export("rulerView:willMoveMarker:toLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RulerViewWillMoveMarker(NSRulerView ruler, NSRulerMarker marker, nfloat location)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_IntPtr_nfloat(base.Handle, selRulerView_WillMoveMarker_ToLocation_Handle, ruler.Handle, marker.Handle, location);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_IntPtr_nfloat(base.SuperHandle, selRulerView_WillMoveMarker_ToLocation_Handle, ruler.Handle, marker.Handle, location);
	}

	[Export("scrollRangeToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ScrollRangeToVisible(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selScrollRangeToVisible_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selScrollRangeToVisible_Handle, range);
		}
	}

	[Export("selectionAffinity")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSelectionAffinity SelectionAffinity()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSSelectionAffinity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionAffinityHandle);
		}
		return (NSSelectionAffinity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionAffinityHandle);
	}

	[Export("selectionRangeForProposedRange:granularity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange SelectionRange(NSRange proposedCharRange, NSSelectionGranularity granularity)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_UInt64(base.Handle, selSelectionRangeForProposedRange_Granularity_Handle, proposedCharRange, (ulong)granularity);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_UInt64(base.SuperHandle, selSelectionRangeForProposedRange_Granularity_Handle, proposedCharRange, (ulong)granularity);
	}

	[Export("setAlignment:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAlignmentRange(NSTextAlignment alignment, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_NSRange(base.Handle, selSetAlignment_Range_Handle, (ulong)alignment, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_NSRange(base.SuperHandle, selSetAlignment_Range_Handle, (ulong)alignment, range);
		}
	}

	[Export("setBaseWritingDirection:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBaseWritingDirection(NSWritingDirection writingDirection, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_NSRange(base.Handle, selSetBaseWritingDirection_Range_Handle, (long)writingDirection, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_NSRange(base.SuperHandle, selSetBaseWritingDirection_Range_Handle, (long)writingDirection, range);
		}
	}

	[Export("setConstrainedFrameSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetConstrainedFrameSize(CGSize desiredSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetConstrainedFrameSize_Handle, desiredSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetConstrainedFrameSize_Handle, desiredSize);
		}
	}

	[Export("setLayoutOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLayoutOrientation(NSTextLayoutOrientation theOrientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayoutOrientation_Handle, (long)theOrientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayoutOrientation_Handle, (long)theOrientation);
		}
	}

	[Export("setMarkedText:selectedRange:replacementRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMarkedText(NSObject text, NSRange selectedRange, NSRange replacementRange)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_NSRange(base.Handle, selSetMarkedText_SelectedRange_ReplacementRange_Handle, text.Handle, selectedRange, replacementRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_NSRange(base.SuperHandle, selSetMarkedText_SelectedRange_ReplacementRange_Handle, text.Handle, selectedRange, replacementRange);
		}
	}

	[Export("setMarkedText:selectedRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMarkedText(NSObject @string, NSRange selRange)
	{
		NSApplication.EnsureUIThread();
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetMarkedText_SelectedRange_Handle, @string.Handle, selRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetMarkedText_SelectedRange_Handle, @string.Handle, selRange);
		}
	}

	[Export("setNeedsDisplayInRect:avoidAdditionalLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay(CGRect rect, bool avoidAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selSetNeedsDisplayInRect_AvoidAdditionalLayout_Handle, rect, avoidAdditionalLayout);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selSetNeedsDisplayInRect_AvoidAdditionalLayout_Handle, rect, avoidAdditionalLayout);
		}
	}

	[Export("setSelectedRange:affinity:stillSelecting:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedRange(NSRange charRange, NSSelectionAffinity affinity, bool stillSelectingFlag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_bool(base.Handle, selSetSelectedRange_Affinity_StillSelecting_Handle, charRange, (ulong)affinity, stillSelectingFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_bool(base.SuperHandle, selSetSelectedRange_Affinity_StillSelecting_Handle, charRange, (ulong)affinity, stillSelectingFlag);
		}
	}

	[Export("setSelectedRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selSetSelectedRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetSelectedRange_Handle, charRange);
		}
	}

	[Export("setSelectedRanges:affinity:stillSelecting:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedRanges(NSArray ranges, NSSelectionAffinity affinity, bool stillSelectingFlag)
	{
		NSApplication.EnsureUIThread();
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_bool(base.Handle, selSetSelectedRanges_Affinity_StillSelecting_Handle, ranges.Handle, (ulong)affinity, stillSelectingFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_bool(base.SuperHandle, selSetSelectedRanges_Affinity_StillSelecting_Handle, ranges.Handle, (ulong)affinity, stillSelectingFlag);
		}
	}

	[Export("setSpellingState:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSpellingState(nint value, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_NSRange(base.Handle, selSetSpellingState_Range_Handle, value, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_NSRange(base.SuperHandle, selSetSpellingState_Range_Handle, value, charRange);
		}
	}

	[Export("shouldChangeTextInRanges:replacementStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeText(NSArray affectedRanges, string[] replacementStrings)
	{
		NSApplication.EnsureUIThread();
		if (affectedRanges == null)
		{
			throw new ArgumentNullException("affectedRanges");
		}
		if (replacementStrings == null)
		{
			throw new ArgumentNullException("replacementStrings");
		}
		NSArray nSArray = NSArray.FromStrings(replacementStrings);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldChangeTextInRanges_ReplacementStrings_Handle, affectedRanges.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldChangeTextInRanges_ReplacementStrings_Handle, affectedRanges.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("shouldChangeTextInRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeText(NSRange affectedCharRange, string replacementString)
	{
		NSApplication.EnsureUIThread();
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selShouldChangeTextInRange_ReplacementString_Handle, affectedCharRange, arg) : Messaging.bool_objc_msgSend_NSRange_IntPtr(base.Handle, selShouldChangeTextInRange_ReplacementString_Handle, affectedCharRange, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("shouldReplaceCharactersInRanges:withStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReplaceCharactersInRangeswithStrings(NSArray ranges, NSArray strings)
	{
		NSApplication.EnsureUIThread();
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (strings == null)
		{
			throw new ArgumentNullException("strings");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldReplaceCharactersInRanges_WithStrings_Handle, ranges.Handle, strings.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldReplaceCharactersInRanges_WithStrings_Handle, ranges.Handle, strings.Handle);
	}

	[Export("showFindIndicatorForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowFindIndicatorForRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selShowFindIndicatorForRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selShowFindIndicatorForRange_Handle, charRange);
		}
	}

	[Export("smartDeleteRangeForProposedRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange SmartDeleteRangeForProposedRange(NSRange proposedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selSmartDeleteRangeForProposedRange_Handle, proposedCharRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selSmartDeleteRangeForProposedRange_Handle, proposedCharRange);
	}

	[Export("smartInsertForString:replacingRange:beforeString:afterString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SmartInsert(string pasteString, NSRange charRangeToReplace, string beforeString, string afterString)
	{
		NSApplication.EnsureUIThread();
		if (pasteString == null)
		{
			throw new ArgumentNullException("pasteString");
		}
		if (beforeString == null)
		{
			throw new ArgumentNullException("beforeString");
		}
		if (afterString == null)
		{
			throw new ArgumentNullException("afterString");
		}
		IntPtr arg = NSString.CreateNative(pasteString);
		IntPtr arg2 = NSString.CreateNative(beforeString);
		IntPtr arg3 = NSString.CreateNative(afterString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr_IntPtr(base.Handle, selSmartInsertForString_ReplacingRange_BeforeString_AfterString_Handle, arg, charRangeToReplace, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_IntPtr_IntPtr(base.SuperHandle, selSmartInsertForString_ReplacingRange_BeforeString_AfterString_Handle, arg, charRangeToReplace, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("smartInsertAfterStringForString:replacingRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SmartInsertAfter(string pasteString, NSRange charRangeToReplace)
	{
		NSApplication.EnsureUIThread();
		if (pasteString == null)
		{
			throw new ArgumentNullException("pasteString");
		}
		IntPtr arg = NSString.CreateNative(pasteString);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSmartInsertAfterStringForString_ReplacingRange_Handle, arg, charRangeToReplace)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(base.Handle, selSmartInsertAfterStringForString_ReplacingRange_Handle, arg, charRangeToReplace)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("smartInsertBeforeStringForString:replacingRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SmartInsertBefore(string pasteString, NSRange charRangeToReplace)
	{
		NSApplication.EnsureUIThread();
		if (pasteString == null)
		{
			throw new ArgumentNullException("pasteString");
		}
		IntPtr arg = NSString.CreateNative(pasteString);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSmartInsertBeforeStringForString_ReplacingRange_Handle, arg, charRangeToReplace)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(base.Handle, selSmartInsertBeforeStringForString_ReplacingRange_Handle, arg, charRangeToReplace)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("spellCheckerDocumentTag")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SpellCheckerDocumentTag()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selSpellCheckerDocumentTagHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSpellCheckerDocumentTagHandle);
	}

	[Export("startSpeaking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartSpeaking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stopSpeaking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSpeaking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stringAtIndex:effectiveRange:endsWithSearchBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringAtIndexeffectiveRangeendsWithSearchBoundary(nuint characterIndex, ref NSRange outRange, bool outFlag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nuint_ref_NSRange_bool(base.Handle, selStringAtIndex_EffectiveRange_EndsWithSearchBoundary_Handle, characterIndex, ref outRange, outFlag));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nuint_ref_NSRange_bool(base.SuperHandle, selStringAtIndex_EffectiveRange_EndsWithSearchBoundary_Handle, characterIndex, ref outRange, outFlag));
	}

	[Export("stringLength")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint StringLength()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend(base.Handle, selStringLengthHandle);
		}
		return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStringLengthHandle);
	}

	[Export("tightenKerning:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TightenKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTightenKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTightenKerning_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticDashSubstitution:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticDashSubstitution(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticDashSubstitution_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticDashSubstitution_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticDataDetection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticDataDetection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticDataDetection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticDataDetection_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticLinkDetection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticLinkDetection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticLinkDetection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticLinkDetection_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticQuoteSubstitution:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticQuoteSubstitution(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticQuoteSubstitution_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticQuoteSubstitution_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticSpellingCorrection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticSpellingCorrection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticSpellingCorrection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticSpellingCorrection_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticTextCompletion:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticTextCompletion(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticTextCompletion_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticTextCompletion_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("toggleAutomaticTextReplacement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleAutomaticTextReplacement(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticTextReplacement_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticTextReplacement_Handle, sender.Handle);
		}
	}

	[Export("toggleContinuousSpellChecking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleContinuousSpellChecking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
	}

	[Export("toggleGrammarChecking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleGrammarChecking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleGrammarChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleGrammarChecking_Handle, sender.Handle);
		}
	}

	[Export("toggleQuickLookPreviewPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleQuickLookPreviewPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleQuickLookPreviewPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleQuickLookPreviewPanel_Handle, sender.Handle);
		}
	}

	[Export("toggleSmartInsertDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleSmartInsertDelete(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
	}

	[Export("toggleTraditionalCharacterShape:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use unicode characters via the character palette.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleTraditionalCharacterShape(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleTraditionalCharacterShape_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleTraditionalCharacterShape_Handle, sender.Handle);
		}
	}

	[Export("turnOffKerning:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TurnOffKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTurnOffKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTurnOffKerning_Handle, sender.Handle);
		}
	}

	[Export("turnOffLigatures:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TurnOffLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTurnOffLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTurnOffLigatures_Handle, sender.Handle);
		}
	}

	[Export("unmarkText")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnmarkText()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnmarkTextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnmarkTextHandle);
		}
	}

	[Export("updateCandidates")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCandidates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateCandidatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateCandidatesHandle);
		}
	}

	[Export("updateDragTypeRegistration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateDragTypeRegistration()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateDragTypeRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateDragTypeRegistrationHandle);
		}
	}

	[Export("updateFontPanel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateFontPanel()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFontPanelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFontPanelHandle);
		}
	}

	[Export("updateInsertionPointStateAndRestartTimer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateInsertionPointStateAndRestartTimer(bool restartFlag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selUpdateInsertionPointStateAndRestartTimer_Handle, restartFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selUpdateInsertionPointStateAndRestartTimer_Handle, restartFlag);
		}
	}

	[Export("updateQuickLookPreviewPanel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateQuickLookPreviewPanel()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateQuickLookPreviewPanelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateQuickLookPreviewPanelHandle);
		}
	}

	[Export("updateRuler")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateRuler()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateRulerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateRulerHandle);
		}
	}

	[Export("updateTextTouchBarItems")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateTextTouchBarItems()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateTextTouchBarItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateTextTouchBarItemsHandle);
		}
	}

	[Export("updateTouchBarItemIdentifiers")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateTouchBarItemIdentifiers()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateTouchBarItemIdentifiersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateTouchBarItemIdentifiersHandle);
		}
	}

	[Export("useAllLigatures:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UseAllLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseAllLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseAllLigatures_Handle, sender.Handle);
		}
	}

	[Export("useStandardKerning:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UseStandardKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseStandardKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseStandardKerning_Handle, sender.Handle);
		}
	}

	[Export("useStandardLigatures:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UseStandardLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseStandardLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseStandardLigatures_Handle, sender.Handle);
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

	[Export("writablePasteboardTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] WritablePasteboardTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWritablePasteboardTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWritablePasteboardTypesHandle));
	}

	[Export("writeSelectionToPasteboard:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteSelectionToPasteboard(NSPasteboard pboard, string type)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionToPasteboard_Type_Handle, pboard.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionToPasteboard_Type_Handle, pboard.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeSelectionToPasteboard:types:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteSelectionToPasteboard(NSPasteboard pboard, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionToPasteboard_Types_Handle, pboard.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionToPasteboard_Types_Handle, pboard.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	internal override _NSTextDelegate CreateInternalEventDelegateType()
	{
		return new _NSTextViewDelegate();
	}

	internal _NSTextViewDelegate EnsureNSTextViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTextViewDelegate nSTextViewDelegate = Delegate as _NSTextViewDelegate;
		if (nSTextViewDelegate == null)
		{
			nSTextViewDelegate = (_NSTextViewDelegate)(Delegate = (_NSTextViewDelegate)CreateInternalEventDelegateType());
		}
		return nSTextViewDelegate;
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
