using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextView", true)]
public class NSTextView : NSText
{
	[Register]
	private sealed class _NSTextViewDelegate : NSTextViewDelegate
	{
		internal NSTextViewLink linkClicked;

		internal EventHandler<NSTextViewClickedEventArgs> cellClicked;

		internal EventHandler<NSTextViewDoubleClickEventArgs> cellDoubleClicked;

		internal NSTextViewCellPosition getWritablePasteboardTypes;

		internal NSTextViewCellPasteboard writeCell;

		internal NSTextViewSelectionChange willChangeSelection;

		internal NSTextViewSelectionWillChange willChangeSelectionFromRanges;

		internal NSTextViewSelectionShouldChange shouldChangeTextInRanges;

		internal NSTextViewTypeAttribute shouldChangeTypingAttributes;

		internal EventHandler didChangeSelection;

		internal EventHandler didChangeTypingAttributes;

		internal NSTextViewTooltip willDisplayToolTip;

		internal NSTextViewCompletion getCompletions;

		internal NSTextViewChangeText shouldChangeTextInRange;

		internal NSTextViewSelectorCommand doCommandBySelector;

		internal NSTextViewSpellingQuery shouldSetSpellingState;

		internal NSTextViewEventMenu menuForEvent;

		internal NSTextViewOnTextCheck willCheckText;

		internal NSTextViewTextChecked didCheckText;

		internal EventHandler<NSTextViewDraggedCellEventArgs> draggedCell;

		internal NSTextViewGetUndoManager getUndoManager;

		[Preserve(Conditional = true)]
		public override bool LinkClicked(NSTextView textView, NSObject link, ulong charIndex)
		{
			return linkClicked?.Invoke(textView, link, charIndex) ?? false;
		}

		[Preserve(Conditional = true)]
		public override void CellClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
		{
			EventHandler<NSTextViewClickedEventArgs> eventHandler = cellClicked;
			if (eventHandler != null)
			{
				NSTextViewClickedEventArgs e = new NSTextViewClickedEventArgs(cell, cellFrame, charIndex);
				eventHandler(textView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void CellDoubleClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
		{
			EventHandler<NSTextViewDoubleClickEventArgs> eventHandler = cellDoubleClicked;
			if (eventHandler != null)
			{
				NSTextViewDoubleClickEventArgs e = new NSTextViewDoubleClickEventArgs(cell, cellFrame, charIndex);
				eventHandler(textView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override string[] GetWritablePasteboardTypes(NSTextView view, NSTextAttachmentCell forCell, ulong charIndex)
		{
			return getWritablePasteboardTypes?.Invoke(view, forCell, charIndex);
		}

		[Preserve(Conditional = true)]
		public override bool WriteCell(NSTextView view, NSTextAttachmentCell cell, uint charIndex, NSPasteboard pboard, string type)
		{
			return writeCell?.Invoke(view, cell, charIndex, pboard, type) ?? true;
		}

		[Preserve(Conditional = true)]
		public override NSRange WillChangeSelection(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			return willChangeSelection?.Invoke(textView, oldSelectedCharRange, newSelectedCharRange) ?? newSelectedCharRange;
		}

		[Preserve(Conditional = true)]
		public override NSValue[] WillChangeSelectionFromRanges(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			NSTextViewSelectionWillChange nSTextViewSelectionWillChange = willChangeSelectionFromRanges;
			if (nSTextViewSelectionWillChange != null)
			{
				return nSTextViewSelectionWillChange(textView, oldSelectedCharRanges, newSelectedCharRanges);
			}
			return newSelectedCharRanges;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldChangeTextInRanges(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			NSTextViewSelectionShouldChange nSTextViewSelectionShouldChange = shouldChangeTextInRanges;
			if (nSTextViewSelectionShouldChange != null)
			{
				return nSTextViewSelectionShouldChange(textView, affectedRanges, replacementStrings);
			}
			throw new Exception("No event handler has been added to the ShouldChangeTextInRanges event.");
		}

		[Preserve(Conditional = true)]
		public override NSDictionary ShouldChangeTypingAttributes(NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			NSTextViewTypeAttribute nSTextViewTypeAttribute = shouldChangeTypingAttributes;
			if (nSTextViewTypeAttribute != null)
			{
				return nSTextViewTypeAttribute(textView, oldTypingAttributes, newTypingAttributes);
			}
			return newTypingAttributes;
		}

		[Preserve(Conditional = true)]
		public override void DidChangeSelection(NSNotification notification)
		{
			didChangeSelection?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidChangeTypingAttributes(NSNotification notification)
		{
			didChangeTypingAttributes?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override string WillDisplayToolTip(NSTextView textView, string tooltip, ulong characterIndex)
		{
			NSTextViewTooltip nSTextViewTooltip = willDisplayToolTip;
			if (nSTextViewTooltip != null)
			{
				return nSTextViewTooltip(textView, tooltip, characterIndex);
			}
			return tooltip;
		}

		[Preserve(Conditional = true)]
		public override string[] GetCompletions(NSTextView textView, string[] words, NSRange charRange, long index)
		{
			return getCompletions?.Invoke(textView, words, charRange, index);
		}

		[Preserve(Conditional = true)]
		public override bool ShouldChangeTextInRange(NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			return shouldChangeTextInRange?.Invoke(textView, affectedCharRange, replacementString) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DoCommandBySelector(NSTextView textView, Selector commandSelector)
		{
			return doCommandBySelector?.Invoke(textView, commandSelector) ?? false;
		}

		[Preserve(Conditional = true)]
		public override long ShouldSetSpellingState(NSTextView textView, long value, NSRange affectedCharRange)
		{
			return shouldSetSpellingState?.Invoke(textView, value, affectedCharRange) ?? 0;
		}

		[Preserve(Conditional = true)]
		public override NSMenu MenuForEvent(NSTextView view, NSMenu menu, NSEvent theEvent, ulong charIndex)
		{
			NSTextViewEventMenu nSTextViewEventMenu = menuForEvent;
			if (nSTextViewEventMenu != null)
			{
				return nSTextViewEventMenu(view, menu, theEvent, charIndex);
			}
			return menu;
		}

		[Preserve(Conditional = true)]
		public override NSDictionary WillCheckText(NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			NSTextViewOnTextCheck nSTextViewOnTextCheck = willCheckText;
			if (nSTextViewOnTextCheck != null)
			{
				return nSTextViewOnTextCheck(view, range, options, checkingTypes);
			}
			return options;
		}

		[Preserve(Conditional = true)]
		public override NSTextCheckingResult[] DidCheckText(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, long wordCount)
		{
			NSTextViewTextChecked nSTextViewTextChecked = didCheckText;
			if (nSTextViewTextChecked != null)
			{
				return nSTextViewTextChecked(view, range, checkingTypes, options, results, orthography, wordCount);
			}
			return results;
		}

		[Preserve(Conditional = true)]
		public override void DraggedCell(NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
		{
			EventHandler<NSTextViewDraggedCellEventArgs> eventHandler = draggedCell;
			if (eventHandler != null)
			{
				NSTextViewDraggedCellEventArgs e = new NSTextViewDraggedCellEventArgs(cell, rect, theevent);
				eventHandler(view, e);
			}
		}

		[Preserve(Conditional = true)]
		public override NSUndoManager GetUndoManager(NSTextView view)
		{
			return getUndoManager?.Invoke(view);
		}
	}

	private static readonly IntPtr selTextContainerOriginHandle = Selector.GetHandle("textContainerOrigin");

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	private static readonly IntPtr selTextStorageHandle = Selector.GetHandle("textStorage");

	private static readonly IntPtr selShouldDrawInsertionPointHandle = Selector.GetHandle("shouldDrawInsertionPoint");

	private static readonly IntPtr selTextContainerHandle = Selector.GetHandle("textContainer");

	private static readonly IntPtr selSetTextContainer_Handle = Selector.GetHandle("setTextContainer:");

	private static readonly IntPtr selTextContainerInsetHandle = Selector.GetHandle("textContainerInset");

	private static readonly IntPtr selSetTextContainerInset_Handle = Selector.GetHandle("setTextContainerInset:");

	private static readonly IntPtr selSelectedRangesHandle = Selector.GetHandle("selectedRanges");

	private static readonly IntPtr selSetSelectedRanges_Handle = Selector.GetHandle("setSelectedRanges:");

	private static readonly IntPtr selSelectionGranularityHandle = Selector.GetHandle("selectionGranularity");

	private static readonly IntPtr selSetSelectionGranularity_Handle = Selector.GetHandle("setSelectionGranularity:");

	private static readonly IntPtr selSelectedTextAttributesHandle = Selector.GetHandle("selectedTextAttributes");

	private static readonly IntPtr selSetSelectedTextAttributes_Handle = Selector.GetHandle("setSelectedTextAttributes:");

	private static readonly IntPtr selInsertionPointColorHandle = Selector.GetHandle("insertionPointColor");

	private static readonly IntPtr selSetInsertionPointColor_Handle = Selector.GetHandle("setInsertionPointColor:");

	private static readonly IntPtr selMarkedTextAttributesHandle = Selector.GetHandle("markedTextAttributes");

	private static readonly IntPtr selSetMarkedTextAttributes_Handle = Selector.GetHandle("setMarkedTextAttributes:");

	private static readonly IntPtr selLinkTextAttributesHandle = Selector.GetHandle("linkTextAttributes");

	private static readonly IntPtr selSetLinkTextAttributes_Handle = Selector.GetHandle("setLinkTextAttributes:");

	private static readonly IntPtr selDisplaysLinkToolTipsHandle = Selector.GetHandle("displaysLinkToolTips");

	private static readonly IntPtr selSetDisplaysLinkToolTips_Handle = Selector.GetHandle("setDisplaysLinkToolTips:");

	private static readonly IntPtr selAcceptsGlyphInfoHandle = Selector.GetHandle("acceptsGlyphInfo");

	private static readonly IntPtr selSetAcceptsGlyphInfo_Handle = Selector.GetHandle("setAcceptsGlyphInfo:");

	private static readonly IntPtr selIsRulerVisibleHandle = Selector.GetHandle("isRulerVisible");

	private static readonly IntPtr selSetRulerVisible_Handle = Selector.GetHandle("setRulerVisible:");

	private static readonly IntPtr selUsesRulerHandle = Selector.GetHandle("usesRuler");

	private static readonly IntPtr selSetUsesRuler_Handle = Selector.GetHandle("setUsesRuler:");

	private static readonly IntPtr selIsContinuousSpellCheckingEnabledHandle = Selector.GetHandle("isContinuousSpellCheckingEnabled");

	private static readonly IntPtr selSetContinuousSpellCheckingEnabled_Handle = Selector.GetHandle("setContinuousSpellCheckingEnabled:");

	private static readonly IntPtr selIsGrammarCheckingEnabledHandle = Selector.GetHandle("isGrammarCheckingEnabled");

	private static readonly IntPtr selSetGrammarCheckingEnabled_Handle = Selector.GetHandle("setGrammarCheckingEnabled:");

	private static readonly IntPtr selTypingAttributesHandle = Selector.GetHandle("typingAttributes");

	private static readonly IntPtr selSetTypingAttributes_Handle = Selector.GetHandle("setTypingAttributes:");

	private static readonly IntPtr selUsesFindPanelHandle = Selector.GetHandle("usesFindPanel");

	private static readonly IntPtr selSetUsesFindPanel_Handle = Selector.GetHandle("setUsesFindPanel:");

	private static readonly IntPtr selAllowsDocumentBackgroundColorChangeHandle = Selector.GetHandle("allowsDocumentBackgroundColorChange");

	private static readonly IntPtr selSetAllowsDocumentBackgroundColorChange_Handle = Selector.GetHandle("setAllowsDocumentBackgroundColorChange:");

	private static readonly IntPtr selDefaultParagraphStyleHandle = Selector.GetHandle("defaultParagraphStyle");

	private static readonly IntPtr selSetDefaultParagraphStyle_Handle = Selector.GetHandle("setDefaultParagraphStyle:");

	private static readonly IntPtr selAllowsUndoHandle = Selector.GetHandle("allowsUndo");

	private static readonly IntPtr selSetAllowsUndo_Handle = Selector.GetHandle("setAllowsUndo:");

	private static readonly IntPtr selAllowsImageEditingHandle = Selector.GetHandle("allowsImageEditing");

	private static readonly IntPtr selSetAllowsImageEditing_Handle = Selector.GetHandle("setAllowsImageEditing:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	private static readonly IntPtr selIsRichTextHandle = Selector.GetHandle("isRichText");

	private static readonly IntPtr selSetRichText_Handle = Selector.GetHandle("setRichText:");

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selIsFieldEditorHandle = Selector.GetHandle("isFieldEditor");

	private static readonly IntPtr selSetFieldEditor_Handle = Selector.GetHandle("setFieldEditor:");

	private static readonly IntPtr selUsesFontPanelHandle = Selector.GetHandle("usesFontPanel");

	private static readonly IntPtr selSetUsesFontPanel_Handle = Selector.GetHandle("setUsesFontPanel:");

	private static readonly IntPtr selAllowedInputSourceLocalesHandle = Selector.GetHandle("allowedInputSourceLocales");

	private static readonly IntPtr selSetAllowedInputSourceLocales_Handle = Selector.GetHandle("setAllowedInputSourceLocales:");

	private static readonly IntPtr selSmartInsertDeleteEnabledHandle = Selector.GetHandle("smartInsertDeleteEnabled");

	private static readonly IntPtr selSetSmartInsertDeleteEnabled_Handle = Selector.GetHandle("setSmartInsertDeleteEnabled:");

	private static readonly IntPtr selIsAutomaticQuoteSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticQuoteSubstitutionEnabled");

	private static readonly IntPtr selSetAutomaticQuoteSubstitutionEnabled_Handle = Selector.GetHandle("setAutomaticQuoteSubstitutionEnabled:");

	private static readonly IntPtr selIsAutomaticLinkDetectionEnabledHandle = Selector.GetHandle("isAutomaticLinkDetectionEnabled");

	private static readonly IntPtr selSetAutomaticLinkDetectionEnabled_Handle = Selector.GetHandle("setAutomaticLinkDetectionEnabled:");

	private static readonly IntPtr selIsAutomaticDataDetectionEnabledHandle = Selector.GetHandle("isAutomaticDataDetectionEnabled");

	private static readonly IntPtr selSetAutomaticDataDetectionEnabled_Handle = Selector.GetHandle("setAutomaticDataDetectionEnabled:");

	private static readonly IntPtr selIsAutomaticDashSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticDashSubstitutionEnabled");

	private static readonly IntPtr selSetAutomaticDashSubstitutionEnabled_Handle = Selector.GetHandle("setAutomaticDashSubstitutionEnabled:");

	private static readonly IntPtr selIsAutomaticTextReplacementEnabledHandle = Selector.GetHandle("isAutomaticTextReplacementEnabled");

	private static readonly IntPtr selSetAutomaticTextReplacementEnabled_Handle = Selector.GetHandle("setAutomaticTextReplacementEnabled:");

	private static readonly IntPtr selIsAutomaticSpellingCorrectionEnabledHandle = Selector.GetHandle("isAutomaticSpellingCorrectionEnabled");

	private static readonly IntPtr selSetAutomaticSpellingCorrectionEnabled_Handle = Selector.GetHandle("setAutomaticSpellingCorrectionEnabled:");

	private static readonly IntPtr selEnabledTextCheckingTypesHandle = Selector.GetHandle("enabledTextCheckingTypes");

	private static readonly IntPtr selSetEnabledTextCheckingTypes_Handle = Selector.GetHandle("setEnabledTextCheckingTypes:");

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	private static readonly IntPtr selInitWithFrameTextContainer_Handle = Selector.GetHandle("initWithFrame:textContainer:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selReplaceTextContainer_Handle = Selector.GetHandle("replaceTextContainer:");

	private static readonly IntPtr selInvalidateTextContainerOriginHandle = Selector.GetHandle("invalidateTextContainerOrigin");

	private static readonly IntPtr selInsertText_Handle = Selector.GetHandle("insertText:");

	private static readonly IntPtr selSetConstrainedFrameSize_Handle = Selector.GetHandle("setConstrainedFrameSize:");

	private static readonly IntPtr selSetAlignmentRange_Handle = Selector.GetHandle("setAlignment:range:");

	private static readonly IntPtr selSetBaseWritingDirectionRange_Handle = Selector.GetHandle("setBaseWritingDirection:range:");

	private static readonly IntPtr selTurnOffKerning_Handle = Selector.GetHandle("turnOffKerning:");

	private static readonly IntPtr selTightenKerning_Handle = Selector.GetHandle("tightenKerning:");

	private static readonly IntPtr selLoosenKerning_Handle = Selector.GetHandle("loosenKerning:");

	private static readonly IntPtr selUseStandardKerning_Handle = Selector.GetHandle("useStandardKerning:");

	private static readonly IntPtr selTurnOffLigatures_Handle = Selector.GetHandle("turnOffLigatures:");

	private static readonly IntPtr selUseStandardLigatures_Handle = Selector.GetHandle("useStandardLigatures:");

	private static readonly IntPtr selUseAllLigatures_Handle = Selector.GetHandle("useAllLigatures:");

	private static readonly IntPtr selRaiseBaseline_Handle = Selector.GetHandle("raiseBaseline:");

	private static readonly IntPtr selLowerBaseline_Handle = Selector.GetHandle("lowerBaseline:");

	private static readonly IntPtr selToggleTraditionalCharacterShape_Handle = Selector.GetHandle("toggleTraditionalCharacterShape:");

	private static readonly IntPtr selOutline_Handle = Selector.GetHandle("outline:");

	private static readonly IntPtr selPerformFindPanelAction_Handle = Selector.GetHandle("performFindPanelAction:");

	private static readonly IntPtr selAlignJustified_Handle = Selector.GetHandle("alignJustified:");

	private static readonly IntPtr selChangeColor_Handle = Selector.GetHandle("changeColor:");

	private static readonly IntPtr selChangeAttributes_Handle = Selector.GetHandle("changeAttributes:");

	private static readonly IntPtr selChangeDocumentBackgroundColor_Handle = Selector.GetHandle("changeDocumentBackgroundColor:");

	private static readonly IntPtr selOrderFrontSpacingPanel_Handle = Selector.GetHandle("orderFrontSpacingPanel:");

	private static readonly IntPtr selOrderFrontLinkPanel_Handle = Selector.GetHandle("orderFrontLinkPanel:");

	private static readonly IntPtr selOrderFrontListPanel_Handle = Selector.GetHandle("orderFrontListPanel:");

	private static readonly IntPtr selOrderFrontTablePanel_Handle = Selector.GetHandle("orderFrontTablePanel:");

	private static readonly IntPtr selRulerViewDidMoveMarker_Handle = Selector.GetHandle("rulerView:didMoveMarker:");

	private static readonly IntPtr selRulerViewDidRemoveMarker_Handle = Selector.GetHandle("rulerView:didRemoveMarker:");

	private static readonly IntPtr selRulerViewDidAddMarker_Handle = Selector.GetHandle("rulerView:didAddMarker:");

	private static readonly IntPtr selRulerViewShouldMoveMarker_Handle = Selector.GetHandle("rulerView:shouldMoveMarker:");

	private static readonly IntPtr selRulerViewShouldAddMarker_Handle = Selector.GetHandle("rulerView:shouldAddMarker:");

	private static readonly IntPtr selRulerViewWillMoveMarkerToLocation_Handle = Selector.GetHandle("rulerView:willMoveMarker:toLocation:");

	private static readonly IntPtr selRulerViewShouldRemoveMarker_Handle = Selector.GetHandle("rulerView:shouldRemoveMarker:");

	private static readonly IntPtr selRulerViewWillAddMarkerAtLocation_Handle = Selector.GetHandle("rulerView:willAddMarker:atLocation:");

	private static readonly IntPtr selRulerViewHandleMouseDown_Handle = Selector.GetHandle("rulerView:handleMouseDown:");

	private static readonly IntPtr selSetNeedsDisplayInRectAvoidAdditionalLayout_Handle = Selector.GetHandle("setNeedsDisplayInRect:avoidAdditionalLayout:");

	private static readonly IntPtr selDrawInsertionPointInRectColorTurnedOn_Handle = Selector.GetHandle("drawInsertionPointInRect:color:turnedOn:");

	private static readonly IntPtr selDrawViewBackgroundInRect_Handle = Selector.GetHandle("drawViewBackgroundInRect:");

	private static readonly IntPtr selUpdateRulerHandle = Selector.GetHandle("updateRuler");

	private static readonly IntPtr selUpdateFontPanelHandle = Selector.GetHandle("updateFontPanel");

	private static readonly IntPtr selUpdateDragTypeRegistrationHandle = Selector.GetHandle("updateDragTypeRegistration");

	private static readonly IntPtr selSelectionRangeForProposedRangeGranularity_Handle = Selector.GetHandle("selectionRangeForProposedRange:granularity:");

	private static readonly IntPtr selClickedOnLinkAtIndex_Handle = Selector.GetHandle("clickedOnLink:atIndex:");

	private static readonly IntPtr selStartSpeaking_Handle = Selector.GetHandle("startSpeaking:");

	private static readonly IntPtr selStopSpeaking_Handle = Selector.GetHandle("stopSpeaking:");

	private static readonly IntPtr selCharacterIndexForInsertionAtPoint_Handle = Selector.GetHandle("characterIndexForInsertionAtPoint:");

	private static readonly IntPtr selComplete_Handle = Selector.GetHandle("complete:");

	private static readonly IntPtr selRangeForUserCompletionHandle = Selector.GetHandle("rangeForUserCompletion");

	private static readonly IntPtr selCompletionsForPartialWordRangeIndexOfSelectedItem_Handle = Selector.GetHandle("completionsForPartialWordRange:indexOfSelectedItem:");

	private static readonly IntPtr selInsertCompletionForPartialWordRangeMovementIsFinal_Handle = Selector.GetHandle("insertCompletion:forPartialWordRange:movement:isFinal:");

	private static readonly IntPtr selWritablePasteboardTypesHandle = Selector.GetHandle("writablePasteboardTypes");

	private static readonly IntPtr selWriteSelectionToPasteboardType_Handle = Selector.GetHandle("writeSelectionToPasteboard:type:");

	private static readonly IntPtr selWriteSelectionToPasteboardTypes_Handle = Selector.GetHandle("writeSelectionToPasteboard:types:");

	private static readonly IntPtr selReadablePasteboardTypesHandle = Selector.GetHandle("readablePasteboardTypes");

	private static readonly IntPtr selPreferredPasteboardTypeFromArrayRestrictedToTypesFromArray_Handle = Selector.GetHandle("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:");

	private static readonly IntPtr selReadSelectionFromPasteboardType_Handle = Selector.GetHandle("readSelectionFromPasteboard:type:");

	private static readonly IntPtr selReadSelectionFromPasteboard_Handle = Selector.GetHandle("readSelectionFromPasteboard:");

	private static readonly IntPtr selRegisterForServicesHandle = Selector.GetHandle("registerForServices");

	private static readonly IntPtr selValidRequestorForSendTypeReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	private static readonly IntPtr selPasteAsPlainText_Handle = Selector.GetHandle("pasteAsPlainText:");

	private static readonly IntPtr selPasteAsRichText_Handle = Selector.GetHandle("pasteAsRichText:");

	private static readonly IntPtr selAcceptableDragTypesHandle = Selector.GetHandle("acceptableDragTypes");

	private static readonly IntPtr selDragOperationForDraggingInfoType_Handle = Selector.GetHandle("dragOperationForDraggingInfo:type:");

	private static readonly IntPtr selCleanUpAfterDragOperationHandle = Selector.GetHandle("cleanUpAfterDragOperation");

	private static readonly IntPtr selSetSelectedRangesAffinityStillSelecting_Handle = Selector.GetHandle("setSelectedRanges:affinity:stillSelecting:");

	private static readonly IntPtr selSetSelectedRangeAffinityStillSelecting_Handle = Selector.GetHandle("setSelectedRange:affinity:stillSelecting:");

	private static readonly IntPtr selSelectionAffinityHandle = Selector.GetHandle("selectionAffinity");

	private static readonly IntPtr selUpdateInsertionPointStateAndRestartTimer_Handle = Selector.GetHandle("updateInsertionPointStateAndRestartTimer:");

	private static readonly IntPtr selToggleContinuousSpellChecking_Handle = Selector.GetHandle("toggleContinuousSpellChecking:");

	private static readonly IntPtr selSpellCheckerDocumentTagHandle = Selector.GetHandle("spellCheckerDocumentTag");

	private static readonly IntPtr selToggleGrammarChecking_Handle = Selector.GetHandle("toggleGrammarChecking:");

	private static readonly IntPtr selSetSpellingStateRange_Handle = Selector.GetHandle("setSpellingState:range:");

	private static readonly IntPtr selShouldChangeTextInRangesReplacementStrings_Handle = Selector.GetHandle("shouldChangeTextInRanges:replacementStrings:");

	private static readonly IntPtr selRangesForUserTextChangeHandle = Selector.GetHandle("rangesForUserTextChange");

	private static readonly IntPtr selRangesForUserCharacterAttributeChangeHandle = Selector.GetHandle("rangesForUserCharacterAttributeChange");

	private static readonly IntPtr selRangesForUserParagraphAttributeChangeHandle = Selector.GetHandle("rangesForUserParagraphAttributeChange");

	private static readonly IntPtr selRangeForUserTextChangeHandle = Selector.GetHandle("rangeForUserTextChange");

	private static readonly IntPtr selRangeForUserCharacterAttributeChangeHandle = Selector.GetHandle("rangeForUserCharacterAttributeChange");

	private static readonly IntPtr selRangeForUserParagraphAttributeChangeHandle = Selector.GetHandle("rangeForUserParagraphAttributeChange");

	private static readonly IntPtr selBreakUndoCoalescingHandle = Selector.GetHandle("breakUndoCoalescing");

	private static readonly IntPtr selIsCoalescingUndoHandle = Selector.GetHandle("isCoalescingUndo");

	private static readonly IntPtr selShowFindIndicatorForRange_Handle = Selector.GetHandle("showFindIndicatorForRange:");

	private static readonly IntPtr selSetSelectedRange_Handle = Selector.GetHandle("setSelectedRange:");

	private static readonly IntPtr selShouldChangeTextInRangeReplacementString_Handle = Selector.GetHandle("shouldChangeTextInRange:replacementString:");

	private static readonly IntPtr selDidChangeTextHandle = Selector.GetHandle("didChangeText");

	private static readonly IntPtr selSmartDeleteRangeForProposedRange_Handle = Selector.GetHandle("smartDeleteRangeForProposedRange:");

	private static readonly IntPtr selToggleSmartInsertDelete_Handle = Selector.GetHandle("toggleSmartInsertDelete:");

	private static readonly IntPtr selSmartInsertForStringReplacingRangeBeforeStringAfterString_Handle = Selector.GetHandle("smartInsertForString:replacingRange:beforeString:afterString:");

	private static readonly IntPtr selSmartInsertBeforeStringForStringReplacingRange_Handle = Selector.GetHandle("smartInsertBeforeStringForString:replacingRange:");

	private static readonly IntPtr selSmartInsertAfterStringForStringReplacingRange_Handle = Selector.GetHandle("smartInsertAfterStringForString:replacingRange:");

	private static readonly IntPtr selToggleAutomaticQuoteSubstitution_Handle = Selector.GetHandle("toggleAutomaticQuoteSubstitution:");

	private static readonly IntPtr selToggleAutomaticLinkDetection_Handle = Selector.GetHandle("toggleAutomaticLinkDetection:");

	private static readonly IntPtr selToggleAutomaticDataDetection_Handle = Selector.GetHandle("toggleAutomaticDataDetection:");

	private static readonly IntPtr selToggleAutomaticDashSubstitution_Handle = Selector.GetHandle("toggleAutomaticDashSubstitution:");

	private static readonly IntPtr selToggleAutomaticTextReplacement_Handle = Selector.GetHandle("toggleAutomaticTextReplacement:");

	private static readonly IntPtr selToggleAutomaticSpellingCorrection_Handle = Selector.GetHandle("toggleAutomaticSpellingCorrection:");

	private static readonly IntPtr selCheckTextInRangeTypesOptions_Handle = Selector.GetHandle("checkTextInRange:types:options:");

	private static readonly IntPtr selHandleTextCheckingResultsForRangeTypesOptionsOrthographyWordCount_Handle = Selector.GetHandle("handleTextCheckingResults:forRange:types:options:orthography:wordCount:");

	private static readonly IntPtr selOrderFrontSubstitutionsPanel_Handle = Selector.GetHandle("orderFrontSubstitutionsPanel:");

	private static readonly IntPtr selCheckTextInSelection_Handle = Selector.GetHandle("checkTextInSelection:");

	private static readonly IntPtr selCheckTextInDocument_Handle = Selector.GetHandle("checkTextInDocument:");

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	private static readonly IntPtr selDraggedImageBeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	private static readonly IntPtr selDraggedImageEndedAtOperation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	private static readonly IntPtr selDraggedImageMovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	private static readonly IntPtr selDraggedImageEndedAtDeposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextView");

	private object __mt_LayoutManager_var;

	private object __mt_TextStorage_var;

	private object __mt_TextContainer_var;

	private object __mt_SelectedRanges_var;

	private object __mt_SelectedTextAttributes_var;

	private object __mt_InsertionPointColor_var;

	private object __mt_MarkedTextAttributes_var;

	private object __mt_LinkTextAttributes_var;

	private object __mt_TypingAttributes_var;

	private object __mt_DefaultParagraphStyle_var;

	private object __mt_Delegate_var;

	private object __mt_BackgroundColor_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGPoint TextContainerOrigin
	{
		[Export("textContainerOrigin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selTextContainerOriginHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTextContainerOriginHandle);
		}
	}

	public virtual NSLayoutManager LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLayoutManager)(__mt_LayoutManager_var = ((!IsDirectBinding) ? ((NSLayoutManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle))) : ((NSLayoutManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle)))));
		}
	}

	public virtual NSTextStorage TextStorage
	{
		[Export("textStorage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextStorage)(__mt_TextStorage_var = ((!IsDirectBinding) ? ((NSTextStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStorageHandle))) : ((NSTextStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStorageHandle)))));
		}
	}

	public virtual bool ShouldDrawInsertionPoint
	{
		[Export("shouldDrawInsertionPoint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDrawInsertionPointHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDrawInsertionPointHandle);
		}
	}

	public virtual NSTextContainer TextContainer
	{
		[Export("textContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextContainer)(__mt_TextContainer_var = ((!IsDirectBinding) ? ((NSTextContainer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContainerHandle))) : ((NSTextContainer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContainerHandle)))));
		}
		[Export("setTextContainer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextContainer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextContainer_Handle, value.Handle);
			}
			__mt_TextContainer_var = value;
		}
	}

	public virtual CGSize TextContainerInset
	{
		[Export("textContainerInset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selTextContainerInsetHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selTextContainerInsetHandle);
		}
		[Export("setTextContainerInset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetTextContainerInset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetTextContainerInset_Handle, value);
			}
		}
	}

	public virtual NSArray SelectedRanges
	{
		[Export("selectedRanges")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSArray)(__mt_SelectedRanges_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRangesHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRangesHandle)))));
		}
		[Export("setSelectedRanges:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedRanges_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedRanges_Handle, value.Handle);
			}
			__mt_SelectedRanges_var = value;
		}
	}

	public virtual NSSelectionGranularity SelectionGranularity
	{
		[Export("selectionGranularity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSSelectionGranularity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionGranularityHandle);
			}
			return (NSSelectionGranularity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionGranularityHandle);
		}
		[Export("setSelectionGranularity:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSelectionGranularity_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSelectionGranularity_Handle, (ulong)value);
			}
		}
	}

	public virtual NSDictionary SelectedTextAttributes
	{
		[Export("selectedTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_SelectedTextAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedTextAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedTextAttributesHandle)))));
		}
		[Export("setSelectedTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedTextAttributes_Handle, value.Handle);
			}
			__mt_SelectedTextAttributes_var = value;
		}
	}

	public virtual NSColor InsertionPointColor
	{
		[Export("insertionPointColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_InsertionPointColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertionPointColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertionPointColorHandle)))));
		}
		[Export("setInsertionPointColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInsertionPointColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInsertionPointColor_Handle, value.Handle);
			}
			__mt_InsertionPointColor_var = value;
		}
	}

	public virtual NSDictionary MarkedTextAttributes
	{
		[Export("markedTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_MarkedTextAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkedTextAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMarkedTextAttributesHandle)))));
		}
		[Export("setMarkedTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarkedTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarkedTextAttributes_Handle, value.Handle);
			}
			__mt_MarkedTextAttributes_var = value;
		}
	}

	public virtual NSDictionary LinkTextAttributes
	{
		[Export("linkTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_LinkTextAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinkTextAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLinkTextAttributesHandle)))));
		}
		[Export("setLinkTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLinkTextAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLinkTextAttributes_Handle, value.Handle);
			}
			__mt_LinkTextAttributes_var = value;
		}
	}

	public virtual bool DisplaysLinkToolTips
	{
		[Export("displaysLinkToolTips")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLinkToolTipsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLinkToolTipsHandle);
		}
		[Export("setDisplaysLinkToolTips:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLinkToolTips_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLinkToolTips_Handle, value);
			}
		}
	}

	public virtual bool AcceptsGlyphInfo
	{
		[Export("acceptsGlyphInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsGlyphInfoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsGlyphInfoHandle);
		}
		[Export("setAcceptsGlyphInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsGlyphInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsGlyphInfo_Handle, value);
			}
		}
	}

	public virtual bool RulerVisible
	{
		[Export("isRulerVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRulerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRulerVisibleHandle);
		}
		[Export("setRulerVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRulerVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRulerVisible_Handle, value);
			}
		}
	}

	public virtual bool UsesRuler
	{
		[Export("usesRuler")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesRulerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesRulerHandle);
		}
		[Export("setUsesRuler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesRuler_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesRuler_Handle, value);
			}
		}
	}

	public virtual bool ContinuousSpellCheckingEnabled
	{
		[Export("isContinuousSpellCheckingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousSpellCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousSpellCheckingEnabledHandle);
		}
		[Export("setContinuousSpellCheckingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuousSpellCheckingEnabled_Handle, value);
			}
		}
	}

	public virtual bool GrammarCheckingEnabled
	{
		[Export("isGrammarCheckingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGrammarCheckingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGrammarCheckingEnabledHandle);
		}
		[Export("setGrammarCheckingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGrammarCheckingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGrammarCheckingEnabled_Handle, value);
			}
		}
	}

	public virtual NSDictionary TypingAttributes
	{
		[Export("typingAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_TypingAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypingAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTypingAttributesHandle)))));
		}
		[Export("setTypingAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypingAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypingAttributes_Handle, value.Handle);
			}
			__mt_TypingAttributes_var = value;
		}
	}

	public virtual bool UsesFindPanel
	{
		[Export("usesFindPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFindPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFindPanelHandle);
		}
		[Export("setUsesFindPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFindPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFindPanel_Handle, value);
			}
		}
	}

	public virtual bool AllowsDocumentBackgroundColorChange
	{
		[Export("allowsDocumentBackgroundColorChange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDocumentBackgroundColorChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDocumentBackgroundColorChangeHandle);
		}
		[Export("setAllowsDocumentBackgroundColorChange:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDocumentBackgroundColorChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDocumentBackgroundColorChange_Handle, value);
			}
		}
	}

	public virtual NSParagraphStyle DefaultParagraphStyle
	{
		[Export("defaultParagraphStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSParagraphStyle)(__mt_DefaultParagraphStyle_var = ((!IsDirectBinding) ? ((NSParagraphStyle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultParagraphStyleHandle))) : ((NSParagraphStyle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultParagraphStyleHandle)))));
		}
		[Export("setDefaultParagraphStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultParagraphStyle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultParagraphStyle_Handle, value.Handle);
			}
			__mt_DefaultParagraphStyle_var = value;
		}
	}

	public virtual bool AllowsUndo
	{
		[Export("allowsUndo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsUndoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsUndoHandle);
		}
		[Export("setAllowsUndo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsUndo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsUndo_Handle, value);
			}
		}
	}

	public virtual bool AllowsImageEditing
	{
		[Export("allowsImageEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsImageEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsImageEditingHandle);
		}
		[Export("setAllowsImageEditing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsImageEditing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsImageEditing_Handle, value);
			}
		}
	}

	public new virtual NSTextViewDelegate Delegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextViewDelegate)(__mt_Delegate_var = ((!IsDirectBinding) ? ((NSTextViewDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSTextViewDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_Delegate_var = value;
		}
	}

	public new virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public new virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	public new virtual bool RichText
	{
		[Export("isRichText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRichTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRichTextHandle);
		}
		[Export("setRichText:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRichText_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRichText_Handle, value);
			}
		}
	}

	public new virtual bool ImportsGraphics
	{
		[Export("importsGraphics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImportsGraphicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImportsGraphicsHandle);
		}
		[Export("setImportsGraphics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImportsGraphics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImportsGraphics_Handle, value);
			}
		}
	}

	public new virtual bool DrawsBackground
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

	public new virtual NSColor BackgroundColor
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

	public new virtual bool FieldEditor
	{
		[Export("isFieldEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFieldEditorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFieldEditorHandle);
		}
		[Export("setFieldEditor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldEditor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldEditor_Handle, value);
			}
		}
	}

	public new virtual bool UsesFontPanel
	{
		[Export("usesFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontPanelHandle);
		}
		[Export("setUsesFontPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontPanel_Handle, value);
			}
		}
	}

	public virtual string[] AllowedInputSourceLocales
	{
		[Export("allowedInputSourceLocales")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public new virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool SmartInsertDeleteEnabled
	{
		[Export("smartInsertDeleteEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSmartInsertDeleteEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSmartInsertDeleteEnabledHandle);
		}
		[Export("setSmartInsertDeleteEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSmartInsertDeleteEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticQuoteSubstitutionEnabled
	{
		[Export("isAutomaticQuoteSubstitutionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticQuoteSubstitutionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticQuoteSubstitutionEnabledHandle);
		}
		[Export("setAutomaticQuoteSubstitutionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticQuoteSubstitutionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticQuoteSubstitutionEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticLinkDetectionEnabled
	{
		[Export("isAutomaticLinkDetectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticLinkDetectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticLinkDetectionEnabledHandle);
		}
		[Export("setAutomaticLinkDetectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticLinkDetectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticLinkDetectionEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticDataDetectionEnabled
	{
		[Export("isAutomaticDataDetectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticDataDetectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticDataDetectionEnabledHandle);
		}
		[Export("setAutomaticDataDetectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticDataDetectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticDataDetectionEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticDashSubstitutionEnabled
	{
		[Export("isAutomaticDashSubstitutionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticDashSubstitutionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticDashSubstitutionEnabledHandle);
		}
		[Export("setAutomaticDashSubstitutionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticDashSubstitutionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticDashSubstitutionEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticTextReplacementEnabled
	{
		[Export("isAutomaticTextReplacementEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticTextReplacementEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticTextReplacementEnabledHandle);
		}
		[Export("setAutomaticTextReplacementEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTextReplacementEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTextReplacementEnabled_Handle, value);
			}
		}
	}

	public virtual bool AutomaticSpellingCorrectionEnabled
	{
		[Export("isAutomaticSpellingCorrectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticSpellingCorrectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticSpellingCorrectionEnabledHandle);
		}
		[Export("setAutomaticSpellingCorrectionEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticSpellingCorrectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticSpellingCorrectionEnabled_Handle, value);
			}
		}
	}

	public virtual NSTextCheckingTypes EnabledTextCheckingTypes
	{
		[Export("enabledTextCheckingTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextCheckingTypes)Messaging.UInt64_objc_msgSend(base.Handle, selEnabledTextCheckingTypesHandle);
			}
			return (NSTextCheckingTypes)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEnabledTextCheckingTypesHandle);
		}
		[Export("setEnabledTextCheckingTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetEnabledTextCheckingTypes_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetEnabledTextCheckingTypes_Handle, (ulong)value);
			}
		}
	}

	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	public NSTextViewLink LinkClicked
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

	public NSTextViewCellPosition GetWritablePasteboardTypes
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

	public NSTextViewCellPasteboard WriteCell
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

	public NSTextViewSelectionChange WillChangeSelection
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

	public NSTextViewSelectionWillChange WillChangeSelectionFromRanges
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

	public NSTextViewSelectionShouldChange ShouldChangeTextInRanges
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

	public NSTextViewTypeAttribute ShouldChangeTypingAttributes
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

	public NSTextViewTooltip WillDisplayToolTip
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

	public NSTextViewCompletion GetCompletions
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

	public NSTextViewChangeText ShouldChangeTextInRange
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

	public NSTextViewSelectorCommand DoCommandBySelector
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

	public NSTextViewSpellingQuery ShouldSetSpellingState
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

	public new NSTextViewEventMenu MenuForEvent
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

	public NSTextViewOnTextCheck WillCheckText
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

	public NSTextViewTextChecked DidCheckText
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

	public NSTextViewGetUndoManager GetUndoManager
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextView()
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
	public NSTextView(NSCoder coder)
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
	public NSTextView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:textContainer:")]
	public NSTextView(CGRect frameRect, NSTextContainer container)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrameTextContainer_Handle, frameRect, container.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrameTextContainer_Handle, frameRect, container.Handle);
		}
	}

	[Export("initWithFrame:")]
	public NSTextView(CGRect frameRect)
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

	[Export("replaceTextContainer:")]
	public virtual void ReplaceTextContainer(NSTextContainer newContainer)
	{
		NSApplication.EnsureUIThread();
		if (newContainer == null)
		{
			throw new ArgumentNullException("newContainer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceTextContainer_Handle, newContainer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceTextContainer_Handle, newContainer.Handle);
		}
	}

	[Export("invalidateTextContainerOrigin")]
	public virtual void InvalidateTextContainerOrigin()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateTextContainerOriginHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateTextContainerOriginHandle);
		}
	}

	[Export("insertText:")]
	public virtual void InsertText(NSObject insertString)
	{
		NSApplication.EnsureUIThread();
		if (insertString == null)
		{
			throw new ArgumentNullException("insertString");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertText_Handle, insertString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertText_Handle, insertString.Handle);
		}
	}

	[Export("setConstrainedFrameSize:")]
	public virtual void SetConstrainedFrameSize(CGSize desiredSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetConstrainedFrameSize_Handle, desiredSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetConstrainedFrameSize_Handle, desiredSize);
		}
	}

	[Export("setAlignment:range:")]
	public virtual void SetAlignmentRange(NSTextAlignment alignment, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_NSRange(base.Handle, selSetAlignmentRange_Handle, (ulong)alignment, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_NSRange(base.SuperHandle, selSetAlignmentRange_Handle, (ulong)alignment, range);
		}
	}

	[Export("setBaseWritingDirection:range:")]
	public virtual void SetBaseWritingDirection(NSWritingDirection writingDirection, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_NSRange(base.Handle, selSetBaseWritingDirectionRange_Handle, (long)writingDirection, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_NSRange(base.SuperHandle, selSetBaseWritingDirectionRange_Handle, (long)writingDirection, range);
		}
	}

	[Export("turnOffKerning:")]
	public virtual void TurnOffKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTurnOffKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTurnOffKerning_Handle, sender.Handle);
		}
	}

	[Export("tightenKerning:")]
	public virtual void TightenKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTightenKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTightenKerning_Handle, sender.Handle);
		}
	}

	[Export("loosenKerning:")]
	public virtual void LoosenKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoosenKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoosenKerning_Handle, sender.Handle);
		}
	}

	[Export("useStandardKerning:")]
	public virtual void UseStandardKerning(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseStandardKerning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseStandardKerning_Handle, sender.Handle);
		}
	}

	[Export("turnOffLigatures:")]
	public virtual void TurnOffLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTurnOffLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTurnOffLigatures_Handle, sender.Handle);
		}
	}

	[Export("useStandardLigatures:")]
	public virtual void UseStandardLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseStandardLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseStandardLigatures_Handle, sender.Handle);
		}
	}

	[Export("useAllLigatures:")]
	public virtual void UseAllLigatures(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUseAllLigatures_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUseAllLigatures_Handle, sender.Handle);
		}
	}

	[Export("raiseBaseline:")]
	public virtual void RaiseBaseline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRaiseBaseline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRaiseBaseline_Handle, sender.Handle);
		}
	}

	[Export("lowerBaseline:")]
	public virtual void LowerBaseline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLowerBaseline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLowerBaseline_Handle, sender.Handle);
		}
	}

	[Export("toggleTraditionalCharacterShape:")]
	public virtual void ToggleTraditionalCharacterShape(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleTraditionalCharacterShape_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleTraditionalCharacterShape_Handle, sender.Handle);
		}
	}

	[Export("outline:")]
	public virtual void Outline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOutline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOutline_Handle, sender.Handle);
		}
	}

	[Export("performFindPanelAction:")]
	public virtual void PerformFindPanelAction(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformFindPanelAction_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformFindPanelAction_Handle, sender.Handle);
		}
	}

	[Export("alignJustified:")]
	public virtual void AlignJustified(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignJustified_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignJustified_Handle, sender.Handle);
		}
	}

	[Export("changeColor:")]
	public virtual void ChangeColor(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeColor_Handle, sender.Handle);
		}
	}

	[Export("changeAttributes:")]
	public virtual void ChangeAttributes(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeAttributes_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeAttributes_Handle, sender.Handle);
		}
	}

	[Export("changeDocumentBackgroundColor:")]
	public virtual void ChangeDocumentBackgroundColor(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDocumentBackgroundColor_Handle, sender.Handle);
		}
	}

	[Export("orderFrontSpacingPanel:")]
	public virtual void OrderFrontSpacingPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontSpacingPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontSpacingPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontLinkPanel:")]
	public virtual void OrderFrontLinkPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontLinkPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontLinkPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontListPanel:")]
	public virtual void OrderFrontListPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontListPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontListPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontTablePanel:")]
	public virtual void OrderFrontTablePanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontTablePanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontTablePanel_Handle, sender.Handle);
		}
	}

	[Export("rulerView:didMoveMarker:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewDidMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewDidMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:didRemoveMarker:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewDidRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewDidRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:didAddMarker:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewDidAddMarker_Handle, ruler.Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewDidAddMarker_Handle, ruler.Handle, marker.Handle);
		}
	}

	[Export("rulerView:shouldMoveMarker:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewShouldMoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewShouldMoveMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:shouldAddMarker:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewShouldAddMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewShouldAddMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:willMoveMarker:toLocation:")]
	public virtual double RulerViewWillMoveMarker(NSRulerView ruler, NSRulerMarker marker, double location)
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
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr_IntPtr_Double(base.Handle, selRulerViewWillMoveMarkerToLocation_Handle, ruler.Handle, marker.Handle, location);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr_IntPtr_Double(base.SuperHandle, selRulerViewWillMoveMarkerToLocation_Handle, ruler.Handle, marker.Handle, location);
	}

	[Export("rulerView:shouldRemoveMarker:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewShouldRemoveMarker_Handle, ruler.Handle, marker.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewShouldRemoveMarker_Handle, ruler.Handle, marker.Handle);
	}

	[Export("rulerView:willAddMarker:atLocation:")]
	public virtual double RulerViewWillAddMarker(NSRulerView ruler, NSRulerMarker marker, double location)
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
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr_IntPtr_Double(base.Handle, selRulerViewWillAddMarkerAtLocation_Handle, ruler.Handle, marker.Handle, location);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr_IntPtr_Double(base.SuperHandle, selRulerViewWillAddMarkerAtLocation_Handle, ruler.Handle, marker.Handle, location);
	}

	[Export("rulerView:handleMouseDown:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRulerViewHandleMouseDown_Handle, ruler.Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRulerViewHandleMouseDown_Handle, ruler.Handle, theEvent.Handle);
		}
	}

	[Export("setNeedsDisplayInRect:avoidAdditionalLayout:")]
	public virtual void SetNeedsDisplay(CGRect rect, bool avoidAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selSetNeedsDisplayInRectAvoidAdditionalLayout_Handle, rect, avoidAdditionalLayout);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selSetNeedsDisplayInRectAvoidAdditionalLayout_Handle, rect, avoidAdditionalLayout);
		}
	}

	[Export("drawInsertionPointInRect:color:turnedOn:")]
	public virtual void DrawInsertionPoint(CGRect rect, NSColor color, bool turnedOn)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_bool(base.Handle, selDrawInsertionPointInRectColorTurnedOn_Handle, rect, color.Handle, turnedOn);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_bool(base.SuperHandle, selDrawInsertionPointInRectColorTurnedOn_Handle, rect, color.Handle, turnedOn);
		}
	}

	[Export("drawViewBackgroundInRect:")]
	public virtual void DrawViewBackgroundInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawViewBackgroundInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawViewBackgroundInRect_Handle, rect);
		}
	}

	[Export("updateRuler")]
	public virtual void UpdateRuler()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateRulerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateRulerHandle);
		}
	}

	[Export("updateFontPanel")]
	public virtual void UpdateFontPanel()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFontPanelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFontPanelHandle);
		}
	}

	[Export("updateDragTypeRegistration")]
	public virtual void UpdateDragTypeRegistration()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateDragTypeRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateDragTypeRegistrationHandle);
		}
	}

	[Export("selectionRangeForProposedRange:granularity:")]
	public virtual NSRange SelectionRange(NSRange proposedCharRange, NSSelectionGranularity granularity)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_UInt64(base.Handle, selSelectionRangeForProposedRangeGranularity_Handle, proposedCharRange, (ulong)granularity);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_UInt64(base.SuperHandle, selSelectionRangeForProposedRangeGranularity_Handle, proposedCharRange, (ulong)granularity);
	}

	[Export("clickedOnLink:atIndex:")]
	public virtual void ClickedOnLink(NSObject link, ulong charIndex)
	{
		NSApplication.EnsureUIThread();
		if (link == null)
		{
			throw new ArgumentNullException("link");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selClickedOnLinkAtIndex_Handle, link.Handle, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selClickedOnLinkAtIndex_Handle, link.Handle, charIndex);
		}
	}

	[Export("startSpeaking:")]
	public virtual void StartSpeaking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeaking_Handle, sender.Handle);
		}
	}

	[Export("stopSpeaking:")]
	public virtual void StopSpeaking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSpeaking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSpeaking_Handle, sender.Handle);
		}
	}

	[Export("characterIndexForInsertionAtPoint:")]
	public virtual uint CharacterIndex(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_CGPoint(base.Handle, selCharacterIndexForInsertionAtPoint_Handle, point);
		}
		return Messaging.UInt32_objc_msgSendSuper_CGPoint(base.SuperHandle, selCharacterIndexForInsertionAtPoint_Handle, point);
	}

	[Export("complete:")]
	public virtual void Complete(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selComplete_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selComplete_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("rangeForUserCompletion")]
	public virtual NSRange RangeForUserCompletion()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserCompletionHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserCompletionHandle);
	}

	[Export("completionsForPartialWordRange:indexOfSelectedItem:")]
	public virtual string[] CompletionsForPartialWord(NSRange charRange, out long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_out_Int64(base.Handle, selCompletionsForPartialWordRangeIndexOfSelectedItem_Handle, charRange, out index));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_out_Int64(base.SuperHandle, selCompletionsForPartialWordRangeIndexOfSelectedItem_Handle, charRange, out index));
	}

	[Export("insertCompletion:forPartialWordRange:movement:isFinal:")]
	public virtual void InsertCompletion(string completion, NSRange partialWordCharRange, long movement, bool isFinal)
	{
		NSApplication.EnsureUIThread();
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		IntPtr arg = NSString.CreateNative(completion);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_Int64_bool(base.Handle, selInsertCompletionForPartialWordRangeMovementIsFinal_Handle, arg, partialWordCharRange, movement, isFinal);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_Int64_bool(base.SuperHandle, selInsertCompletionForPartialWordRangeMovementIsFinal_Handle, arg, partialWordCharRange, movement, isFinal);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("writablePasteboardTypes")]
	public virtual string[] WritablePasteboardTypes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWritablePasteboardTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWritablePasteboardTypesHandle));
	}

	[Export("writeSelectionToPasteboard:type:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionToPasteboardType_Handle, pboard.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionToPasteboardType_Handle, pboard.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeSelectionToPasteboard:types:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteSelectionToPasteboardTypes_Handle, pboard.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteSelectionToPasteboardTypes_Handle, pboard.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("readablePasteboardTypes")]
	public virtual string[] ReadablePasteboardTypes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReadablePasteboardTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadablePasteboardTypesHandle));
	}

	[Export("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:")]
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
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPreferredPasteboardTypeFromArrayRestrictedToTypesFromArray_Handle, nSArray.Handle, nSArray2.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPreferredPasteboardTypeFromArrayRestrictedToTypesFromArray_Handle, nSArray.Handle, nSArray2.Handle)));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("readSelectionFromPasteboard:type:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReadSelectionFromPasteboardType_Handle, pboard.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selReadSelectionFromPasteboardType_Handle, pboard.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readSelectionFromPasteboard:")]
	public virtual bool ReadSelectionFromPasteboard(NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selReadSelectionFromPasteboard_Handle, pboard.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadSelectionFromPasteboard_Handle, pboard.Handle);
	}

	[Export("registerForServices")]
	public static void RegisterForServices()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selRegisterForServicesHandle);
	}

	[Export("validRequestorForSendType:returnType:")]
	public virtual NSObject ValidRequestorForSendType(string sendType, string returnType)
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
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pasteAsPlainText:")]
	public virtual void PasteAsPlainText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsPlainText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsPlainText_Handle, sender.Handle);
		}
	}

	[Export("pasteAsRichText:")]
	public virtual void PasteAsRichText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteAsRichText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteAsRichText_Handle, sender.Handle);
		}
	}

	[Export("acceptableDragTypes")]
	public virtual string[] AcceptableDragTypes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAcceptableDragTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAcceptableDragTypesHandle));
	}

	[Export("dragOperationForDraggingInfo:type:")]
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
		NSDragOperation result = (NSDragOperation)((!IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDragOperationForDraggingInfoType_Handle, dragInfo.Handle, arg) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selDragOperationForDraggingInfoType_Handle, dragInfo.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("cleanUpAfterDragOperation")]
	public virtual void CleanUpAfterDragOperation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCleanUpAfterDragOperationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCleanUpAfterDragOperationHandle);
		}
	}

	[Export("setSelectedRanges:affinity:stillSelecting:")]
	public virtual void SetSelectedRanges(NSArray ranges, NSSelectionAffinity affinity, bool stillSelectingFlag)
	{
		NSApplication.EnsureUIThread();
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_bool(base.Handle, selSetSelectedRangesAffinityStillSelecting_Handle, ranges.Handle, (ulong)affinity, stillSelectingFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_bool(base.SuperHandle, selSetSelectedRangesAffinityStillSelecting_Handle, ranges.Handle, (ulong)affinity, stillSelectingFlag);
		}
	}

	[Export("setSelectedRange:affinity:stillSelecting:")]
	public virtual void SetSelectedRange(NSRange charRange, NSSelectionAffinity affinity, bool stillSelectingFlag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_bool(base.Handle, selSetSelectedRangeAffinityStillSelecting_Handle, charRange, (ulong)affinity, stillSelectingFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_bool(base.SuperHandle, selSetSelectedRangeAffinityStillSelecting_Handle, charRange, (ulong)affinity, stillSelectingFlag);
		}
	}

	[Export("selectionAffinity")]
	public virtual NSSelectionAffinity SelectionAffinity()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSSelectionAffinity)Messaging.UInt64_objc_msgSend(base.Handle, selSelectionAffinityHandle);
		}
		return (NSSelectionAffinity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionAffinityHandle);
	}

	[Export("updateInsertionPointStateAndRestartTimer:")]
	public virtual void UpdateInsertionPointStateAndRestartTimer(bool restartFlag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selUpdateInsertionPointStateAndRestartTimer_Handle, restartFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selUpdateInsertionPointStateAndRestartTimer_Handle, restartFlag);
		}
	}

	[Export("toggleContinuousSpellChecking:")]
	public virtual void ToggleContinuousSpellChecking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleContinuousSpellChecking_Handle, sender.Handle);
		}
	}

	[Export("spellCheckerDocumentTag")]
	public virtual long SpellCheckerDocumentTag()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selSpellCheckerDocumentTagHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSpellCheckerDocumentTagHandle);
	}

	[Export("toggleGrammarChecking:")]
	public virtual void ToggleGrammarChecking(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleGrammarChecking_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleGrammarChecking_Handle, sender.Handle);
		}
	}

	[Export("setSpellingState:range:")]
	public virtual void SetSpellingState(long value, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_NSRange(base.Handle, selSetSpellingStateRange_Handle, value, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_NSRange(base.SuperHandle, selSetSpellingStateRange_Handle, value, charRange);
		}
	}

	[Export("shouldChangeTextInRanges:replacementStrings:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldChangeTextInRangesReplacementStrings_Handle, affectedRanges.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldChangeTextInRangesReplacementStrings_Handle, affectedRanges.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("rangesForUserTextChange")]
	public virtual NSArray RangesForUserTextChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserTextChangeHandle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserTextChangeHandle));
	}

	[Export("rangesForUserCharacterAttributeChange")]
	public virtual NSArray RangesForUserCharacterAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserCharacterAttributeChangeHandle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserCharacterAttributeChangeHandle));
	}

	[Export("rangesForUserParagraphAttributeChange")]
	public virtual NSArray RangesForUserParagraphAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRangesForUserParagraphAttributeChangeHandle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRangesForUserParagraphAttributeChangeHandle));
	}

	[Export("rangeForUserTextChange")]
	public virtual NSRange RangeForUserTextChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserTextChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserTextChangeHandle);
	}

	[Export("rangeForUserCharacterAttributeChange")]
	public virtual NSRange RangeForUserCharacterAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserCharacterAttributeChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserCharacterAttributeChangeHandle);
	}

	[Export("rangeForUserParagraphAttributeChange")]
	public virtual NSRange RangeForUserParagraphAttributeChange()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selRangeForUserParagraphAttributeChangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeForUserParagraphAttributeChangeHandle);
	}

	[Export("breakUndoCoalescing")]
	public virtual void BreakUndoCoalescing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBreakUndoCoalescingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBreakUndoCoalescingHandle);
		}
	}

	[Export("isCoalescingUndo")]
	public virtual bool IsCoalescingUndo()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsCoalescingUndoHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCoalescingUndoHandle);
	}

	[Export("showFindIndicatorForRange:")]
	public virtual void ShowFindIndicatorForRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selShowFindIndicatorForRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selShowFindIndicatorForRange_Handle, charRange);
		}
	}

	[Export("setSelectedRange:")]
	public virtual void SetSelectedRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selSetSelectedRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetSelectedRange_Handle, charRange);
		}
	}

	[Export("shouldChangeTextInRange:replacementString:")]
	public virtual bool ShouldChangeText(NSRange affectedCharRange, string replacementString)
	{
		NSApplication.EnsureUIThread();
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selShouldChangeTextInRangeReplacementString_Handle, affectedCharRange, arg) : Messaging.bool_objc_msgSend_NSRange_IntPtr(base.Handle, selShouldChangeTextInRangeReplacementString_Handle, affectedCharRange, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("didChangeText")]
	public virtual void DidChangeText()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidChangeTextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidChangeTextHandle);
		}
	}

	[Export("smartDeleteRangeForProposedRange:")]
	public virtual NSRange SmartDeleteRangeForProposedRange(NSRange proposedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selSmartDeleteRangeForProposedRange_Handle, proposedCharRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selSmartDeleteRangeForProposedRange_Handle, proposedCharRange);
	}

	[Export("toggleSmartInsertDelete:")]
	public virtual void ToggleSmartInsertDelete(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSmartInsertDelete_Handle, sender.Handle);
		}
	}

	[Export("smartInsertForString:replacingRange:beforeString:afterString:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr_IntPtr(base.Handle, selSmartInsertForStringReplacingRangeBeforeStringAfterString_Handle, arg, charRangeToReplace, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_IntPtr_IntPtr(base.SuperHandle, selSmartInsertForStringReplacingRangeBeforeStringAfterString_Handle, arg, charRangeToReplace, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("smartInsertBeforeStringForString:replacingRange:")]
	public virtual string SmartInsertBefore(string pasteString, NSRange charRangeToReplace)
	{
		NSApplication.EnsureUIThread();
		if (pasteString == null)
		{
			throw new ArgumentNullException("pasteString");
		}
		IntPtr arg = NSString.CreateNative(pasteString);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSmartInsertBeforeStringForStringReplacingRange_Handle, arg, charRangeToReplace)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(base.Handle, selSmartInsertBeforeStringForStringReplacingRange_Handle, arg, charRangeToReplace)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("smartInsertAfterStringForString:replacingRange:")]
	public virtual string SmartInsertAfter(string pasteString, NSRange charRangeToReplace)
	{
		NSApplication.EnsureUIThread();
		if (pasteString == null)
		{
			throw new ArgumentNullException("pasteString");
		}
		IntPtr arg = NSString.CreateNative(pasteString);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSmartInsertAfterStringForStringReplacingRange_Handle, arg, charRangeToReplace)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(base.Handle, selSmartInsertAfterStringForStringReplacingRange_Handle, arg, charRangeToReplace)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("toggleAutomaticQuoteSubstitution:")]
	public virtual void ToggleAutomaticQuoteSubstitution(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticQuoteSubstitution_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticQuoteSubstitution_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticLinkDetection:")]
	public virtual void ToggleAutomaticLinkDetection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticLinkDetection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticLinkDetection_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticDataDetection:")]
	public virtual void ToggleAutomaticDataDetection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticDataDetection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticDataDetection_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticDashSubstitution:")]
	public virtual void ToggleAutomaticDashSubstitution(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticDashSubstitution_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticDashSubstitution_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticTextReplacement:")]
	public virtual void ToggleAutomaticTextReplacement(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticTextReplacement_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticTextReplacement_Handle, sender.Handle);
		}
	}

	[Export("toggleAutomaticSpellingCorrection:")]
	public virtual void ToggleAutomaticSpellingCorrection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleAutomaticSpellingCorrection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleAutomaticSpellingCorrection_Handle, sender.Handle);
		}
	}

	[Export("checkTextInRange:types:options:")]
	public virtual void CheckText(NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selCheckTextInRangeTypesOptions_Handle, range, (ulong)checkingTypes, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selCheckTextInRangeTypesOptions_Handle, range, (ulong)checkingTypes, options.Handle);
		}
	}

	[Export("handleTextCheckingResults:forRange:types:options:orthography:wordCount:")]
	public virtual void HandleTextChecking(NSTextCheckingResult[] results, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSOrthography orthography, long wordCount)
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_Int64(base.Handle, selHandleTextCheckingResultsForRangeTypesOptionsOrthographyWordCount_Handle, nSArray.Handle, range, (ulong)checkingTypes, options.Handle, orthography.Handle, wordCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_Int64(base.SuperHandle, selHandleTextCheckingResultsForRangeTypesOptionsOrthographyWordCount_Handle, nSArray.Handle, range, (ulong)checkingTypes, options.Handle, orthography.Handle, wordCount);
		}
		nSArray.Dispose();
	}

	[Export("orderFrontSubstitutionsPanel:")]
	public virtual void OrderFrontSubstitutionsPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontSubstitutionsPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontSubstitutionsPanel_Handle, sender.Handle);
		}
	}

	[Export("checkTextInSelection:")]
	public virtual void CheckTextInSelection(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInSelection_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInSelection_Handle, sender.Handle);
		}
	}

	[Export("checkTextInDocument:")]
	public virtual void CheckTextInDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInDocument_Handle, sender.Handle);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("draggedImage:beganAt:")]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Obsolete("On 10.1 and newer, use DraggedImageEndedAtOperation() instead", false)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	private _NSTextViewDelegate EnsureNSTextViewDelegate()
	{
		NSTextViewDelegate nSTextViewDelegate = Delegate;
		if (nSTextViewDelegate == null || !(nSTextViewDelegate is _NSTextViewDelegate))
		{
			nSTextViewDelegate = (Delegate = new _NSTextViewDelegate());
		}
		return (_NSTextViewDelegate)nSTextViewDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LayoutManager_var = null;
			__mt_TextStorage_var = null;
			__mt_TextContainer_var = null;
			__mt_SelectedRanges_var = null;
			__mt_SelectedTextAttributes_var = null;
			__mt_InsertionPointColor_var = null;
			__mt_MarkedTextAttributes_var = null;
			__mt_LinkTextAttributes_var = null;
			__mt_TypingAttributes_var = null;
			__mt_DefaultParagraphStyle_var = null;
			__mt_Delegate_var = null;
			__mt_BackgroundColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
