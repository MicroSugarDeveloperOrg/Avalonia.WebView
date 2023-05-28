using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTypesetter", true)]
public class NSTypesetter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionForControlCharacterAtIndex_ = "actionForControlCharacterAtIndex:";

	private static readonly IntPtr selActionForControlCharacterAtIndex_Handle = Selector.GetHandle("actionForControlCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedString = "attributedString";

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesForExtraLineFragment = "attributesForExtraLineFragment";

	private static readonly IntPtr selAttributesForExtraLineFragmentHandle = Selector.GetHandle("attributesForExtraLineFragment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaselineOffsetInLayoutManager_GlyphIndex_ = "baselineOffsetInLayoutManager:glyphIndex:";

	private static readonly IntPtr selBaselineOffsetInLayoutManager_GlyphIndex_Handle = Selector.GetHandle("baselineOffsetInLayoutManager:glyphIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginLineWithGlyphAtIndex_ = "beginLineWithGlyphAtIndex:";

	private static readonly IntPtr selBeginLineWithGlyphAtIndex_Handle = Selector.GetHandle("beginLineWithGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginParagraph = "beginParagraph";

	private static readonly IntPtr selBeginParagraphHandle = Selector.GetHandle("beginParagraph");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBidiProcessingEnabled = "bidiProcessingEnabled";

	private static readonly IntPtr selBidiProcessingEnabledHandle = Selector.GetHandle("bidiProcessingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_ = "boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:";

	private static readonly IntPtr selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle = Selector.GetHandle("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterRangeForGlyphRange_ActualGlyphRange_ = "characterRangeForGlyphRange:actualGlyphRange:";

	private static readonly IntPtr selCharacterRangeForGlyphRange_ActualGlyphRange_Handle = Selector.GetHandle("characterRangeForGlyphRange:actualGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentParagraphStyle = "currentParagraphStyle";

	private static readonly IntPtr selCurrentParagraphStyleHandle = Selector.GetHandle("currentParagraphStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTextContainer = "currentTextContainer";

	private static readonly IntPtr selCurrentTextContainerHandle = Selector.GetHandle("currentTextContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTypesetterBehavior = "defaultTypesetterBehavior";

	private static readonly IntPtr selDefaultTypesetterBehaviorHandle = Selector.GetHandle("defaultTypesetterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteGlyphsInRange_ = "deleteGlyphsInRange:";

	private static readonly IntPtr selDeleteGlyphsInRange_Handle = Selector.GetHandle("deleteGlyphsInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndLineWithGlyphRange_ = "endLineWithGlyphRange:";

	private static readonly IntPtr selEndLineWithGlyphRange_Handle = Selector.GetHandle("endLineWithGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndParagraph = "endParagraph";

	private static readonly IntPtr selEndParagraphHandle = Selector.GetHandle("endParagraph");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_ = "getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:";

	private static readonly IntPtr selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_Handle = Selector.GetHandle("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_ = "getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:";

	private static readonly IntPtr selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_Handle = Selector.GetHandle("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_ = "getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:";

	private static readonly IntPtr selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_Handle = Selector.GetHandle("getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphRangeForCharacterRange_ActualCharacterRange_ = "glyphRangeForCharacterRange:actualCharacterRange:";

	private static readonly IntPtr selGlyphRangeForCharacterRange_ActualCharacterRange_Handle = Selector.GetHandle("glyphRangeForCharacterRange:actualCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHyphenCharacterForGlyphAtIndex_ = "hyphenCharacterForGlyphAtIndex:";

	private static readonly IntPtr selHyphenCharacterForGlyphAtIndex_Handle = Selector.GetHandle("hyphenCharacterForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHyphenationFactor = "hyphenationFactor";

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHyphenationFactorForGlyphAtIndex_ = "hyphenationFactorForGlyphAtIndex:";

	private static readonly IntPtr selHyphenationFactorForGlyphAtIndex_Handle = Selector.GetHandle("hyphenationFactorForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertGlyph_AtGlyphIndex_CharacterIndex_ = "insertGlyph:atGlyphIndex:characterIndex:";

	private static readonly IntPtr selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle = Selector.GetHandle("insertGlyph:atGlyphIndex:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_ = "layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:";

	private static readonly IntPtr selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_Handle = Selector.GetHandle("layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_ = "layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:";

	private static readonly IntPtr selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_Handle = Selector.GetHandle("layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManager = "layoutManager";

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutParagraphAtPoint_ = "layoutParagraphAtPoint:";

	private static readonly IntPtr selLayoutParagraphAtPoint_Handle = Selector.GetHandle("layoutParagraphAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentPadding = "lineFragmentPadding";

	private static readonly IntPtr selLineFragmentPaddingHandle = Selector.GetHandle("lineFragmentPadding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_ = "lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:";

	private static readonly IntPtr selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle = Selector.GetHandle("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphCharacterRange = "paragraphCharacterRange";

	private static readonly IntPtr selParagraphCharacterRangeHandle = Selector.GetHandle("paragraphCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphGlyphRange = "paragraphGlyphRange";

	private static readonly IntPtr selParagraphGlyphRangeHandle = Selector.GetHandle("paragraphGlyphRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSeparatorCharacterRange = "paragraphSeparatorCharacterRange";

	private static readonly IntPtr selParagraphSeparatorCharacterRangeHandle = Selector.GetHandle("paragraphSeparatorCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSeparatorGlyphRange = "paragraphSeparatorGlyphRange";

	private static readonly IntPtr selParagraphSeparatorGlyphRangeHandle = Selector.GetHandle("paragraphSeparatorGlyphRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_ = "paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:";

	private static readonly IntPtr selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle = Selector.GetHandle("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_ = "paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:";

	private static readonly IntPtr selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_Handle = Selector.GetHandle("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_ = "printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:";

	private static readonly IntPtr selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_Handle = Selector.GetHandle("printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttachmentSize_ForGlyphRange_ = "setAttachmentSize:forGlyphRange:";

	private static readonly IntPtr selSetAttachmentSize_ForGlyphRange_Handle = Selector.GetHandle("setAttachmentSize:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedString_ = "setAttributedString:";

	private static readonly IntPtr selSetAttributedString_Handle = Selector.GetHandle("setAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBidiLevels_ForGlyphRange_ = "setBidiLevels:forGlyphRange:";

	private static readonly IntPtr selSetBidiLevels_ForGlyphRange_Handle = Selector.GetHandle("setBidiLevels:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBidiProcessingEnabled_ = "setBidiProcessingEnabled:";

	private static readonly IntPtr selSetBidiProcessingEnabled_Handle = Selector.GetHandle("setBidiProcessingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsOutsideLineFragment_ForGlyphRange_ = "setDrawsOutsideLineFragment:forGlyphRange:";

	private static readonly IntPtr selSetDrawsOutsideLineFragment_ForGlyphRange_Handle = Selector.GetHandle("setDrawsOutsideLineFragment:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHardInvalidation_ForGlyphRange_ = "setHardInvalidation:forGlyphRange:";

	private static readonly IntPtr selSetHardInvalidation_ForGlyphRange_Handle = Selector.GetHandle("setHardInvalidation:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHyphenationFactor_ = "setHyphenationFactor:";

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineFragmentPadding_ = "setLineFragmentPadding:";

	private static readonly IntPtr selSetLineFragmentPadding_Handle = Selector.GetHandle("setLineFragmentPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_ = "setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:";

	private static readonly IntPtr selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle = Selector.GetHandle("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocation_WithAdvancements_ForStartOfGlyphRange_ = "setLocation:withAdvancements:forStartOfGlyphRange:";

	private static readonly IntPtr selSetLocation_WithAdvancements_ForStartOfGlyphRange_Handle = Selector.GetHandle("setLocation:withAdvancements:forStartOfGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotShownAttribute_ForGlyphRange_ = "setNotShownAttribute:forGlyphRange:";

	private static readonly IntPtr selSetNotShownAttribute_ForGlyphRange_Handle = Selector.GetHandle("setNotShownAttribute:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParagraphGlyphRange_SeparatorGlyphRange_ = "setParagraphGlyphRange:separatorGlyphRange:";

	private static readonly IntPtr selSetParagraphGlyphRange_SeparatorGlyphRange_Handle = Selector.GetHandle("setParagraphGlyphRange:separatorGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTypesetterBehavior_ = "setTypesetterBehavior:";

	private static readonly IntPtr selSetTypesetterBehavior_Handle = Selector.GetHandle("setTypesetterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFontLeading_ = "setUsesFontLeading:";

	private static readonly IntPtr selSetUsesFontLeading_Handle = Selector.GetHandle("setUsesFontLeading:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSystemTypesetter = "sharedSystemTypesetter";

	private static readonly IntPtr selSharedSystemTypesetterHandle = Selector.GetHandle("sharedSystemTypesetter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSystemTypesetterForBehavior_ = "sharedSystemTypesetterForBehavior:";

	private static readonly IntPtr selSharedSystemTypesetterForBehavior_Handle = Selector.GetHandle("sharedSystemTypesetterForBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_ = "shouldBreakLineByHyphenatingBeforeCharacterAtIndex:";

	private static readonly IntPtr selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_Handle = Selector.GetHandle("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBreakLineByWordBeforeCharacterAtIndex_ = "shouldBreakLineByWordBeforeCharacterAtIndex:";

	private static readonly IntPtr selShouldBreakLineByWordBeforeCharacterAtIndex_Handle = Selector.GetHandle("shouldBreakLineByWordBeforeCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstituteFontForFont_ = "substituteFontForFont:";

	private static readonly IntPtr selSubstituteFontForFont_Handle = Selector.GetHandle("substituteFontForFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstituteGlyphsInRange_WithGlyphs_ = "substituteGlyphsInRange:withGlyphs:";

	private static readonly IntPtr selSubstituteGlyphsInRange_WithGlyphs_Handle = Selector.GetHandle("substituteGlyphsInRange:withGlyphs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainers = "textContainers";

	private static readonly IntPtr selTextContainersHandle = Selector.GetHandle("textContainers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextTabForGlyphLocation_WritingDirection_MaxLocation_ = "textTabForGlyphLocation:writingDirection:maxLocation:";

	private static readonly IntPtr selTextTabForGlyphLocation_WritingDirection_MaxLocation_Handle = Selector.GetHandle("textTabForGlyphLocation:writingDirection:maxLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypesetterBehavior = "typesetterBehavior";

	private static readonly IntPtr selTypesetterBehaviorHandle = Selector.GetHandle("typesetterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFontLeading = "usesFontLeading";

	private static readonly IntPtr selUsesFontLeadingHandle = Selector.GetHandle("usesFontLeading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_ = "willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:";

	private static readonly IntPtr selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle = Selector.GetHandle("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTypesetter");

	public override IntPtr ClassHandle => class_ptr;

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
		[Export("setAttributedString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedString_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BidiProcessingEnabled
	{
		[Export("bidiProcessingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBidiProcessingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBidiProcessingEnabledHandle);
		}
		[Export("setBidiProcessingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBidiProcessingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBidiProcessingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSParagraphStyle CurrentParagraphStyle
	{
		[Export("currentParagraphStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSParagraphStyle>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentParagraphStyleHandle));
			}
			return Runtime.GetNSObject<NSParagraphStyle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentParagraphStyleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextContainer CurrentTextContainer
	{
		[Export("currentTextContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentTextContainerHandle));
			}
			return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentTextContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTypesetterBehavior DefaultTypesetterBehavior
	{
		[Export("defaultTypesetterBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTypesetterBehavior)Messaging.Int64_objc_msgSend(class_ptr, selDefaultTypesetterBehaviorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HyphenationFactor
	{
		[Export("hyphenationFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHyphenationFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHyphenationFactorHandle);
		}
		[Export("setHyphenationFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHyphenationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHyphenationFactor_Handle, value);
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
	public virtual nfloat LineFragmentPadding
	{
		[Export("lineFragmentPadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineFragmentPaddingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineFragmentPaddingHandle);
		}
		[Export("setLineFragmentPadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineFragmentPadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineFragmentPadding_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange ParagraphCharacterRange
	{
		[Export("paragraphCharacterRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selParagraphCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selParagraphCharacterRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange ParagraphGlyphRange
	{
		[Export("paragraphGlyphRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selParagraphGlyphRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selParagraphGlyphRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange ParagraphSeparatorCharacterRange
	{
		[Export("paragraphSeparatorCharacterRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selParagraphSeparatorCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selParagraphSeparatorCharacterRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange ParagraphSeparatorGlyphRange
	{
		[Export("paragraphSeparatorGlyphRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selParagraphSeparatorGlyphRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selParagraphSeparatorGlyphRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTypesetter SharedSystemTypesetter
	{
		[Export("sharedSystemTypesetter")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSTypesetter>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSystemTypesetterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextContainer[] TextContainers
	{
		[Export("textContainers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTextContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContainersHandle));
			}
			return NSArray.ArrayFromHandle<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContainersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTypesetterBehavior TypesetterBehavior
	{
		[Export("typesetterBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTypesetterBehavior)Messaging.Int64_objc_msgSend(base.Handle, selTypesetterBehaviorHandle);
			}
			return (NSTypesetterBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypesetterBehaviorHandle);
		}
		[Export("setTypesetterBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTypesetterBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTypesetterBehavior_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesFontLeading
	{
		[Export("usesFontLeading")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontLeadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontLeadingHandle);
		}
		[Export("setUsesFontLeading:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontLeading_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontLeading_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTypesetter()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTypesetter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTypesetter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributesForExtraLineFragment")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary AttributesForExtraLineFragment()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesForExtraLineFragmentHandle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesForExtraLineFragmentHandle));
	}

	[Export("beginLineWithGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginLine(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selBeginLineWithGlyphAtIndex_Handle, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selBeginLineWithGlyphAtIndex_Handle, glyphIndex);
		}
	}

	[Export("beginParagraph")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginParagraph()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginParagraphHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginParagraphHandle);
		}
	}

	[Export("deleteGlyphsInRange:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteGlyphs(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDeleteGlyphsInRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDeleteGlyphsInRange_Handle, glyphRange);
		}
	}

	[Export("endLineWithGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndLine(NSRange lineGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEndLineWithGlyphRange_Handle, lineGlyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEndLineWithGlyphRange_Handle, lineGlyphRange);
		}
	}

	[Export("endParagraph")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndParagraph()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndParagraphHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndParagraphHandle);
		}
	}

	[Export("actionForControlCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTypesetterControlCharacterAction GetActionForControlCharacter(nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSTypesetterControlCharacterAction)Messaging.UInt64_objc_msgSend_nuint(base.Handle, selActionForControlCharacterAtIndex_Handle, charIndex);
		}
		return (NSTypesetterControlCharacterAction)Messaging.UInt64_objc_msgSendSuper_nuint(base.SuperHandle, selActionForControlCharacterAtIndex_Handle, charIndex);
	}

	[Export("baselineOffsetInLayoutManager:glyphIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetBaselineOffset(NSLayoutManager layoutManager, nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_nuint(base.Handle, selBaselineOffsetInLayoutManager_GlyphIndex_Handle, layoutManager.Handle, glyphIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selBaselineOffsetInLayoutManager_GlyphIndex_Handle, layoutManager.Handle, glyphIndex);
	}

	[Export("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundingBoxForControlGlyph(nuint glyphIndex, NSTextContainer textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nuint_IntPtr_CGRect_CGPoint_nuint(out retval, base.Handle, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle, glyphIndex, textContainer.Handle, proposedLineFragment, glyphPosition, charIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nuint_IntPtr_CGRect_CGPoint_nuint(out retval, base.SuperHandle, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle, glyphIndex, textContainer.Handle, proposedLineFragment, glyphPosition, charIndex);
		}
		return retval;
	}

	[Export("characterRangeForGlyphRange:actualGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetCharacterRangeForGlyphRange(NSRange glyphRange, out NSRange actualGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_out_NSRange(base.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, out actualGlyphRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_out_NSRange(base.SuperHandle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, out actualGlyphRange);
	}

	[Export("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetGlyphsInRange(NSRange glyphsRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer, IntPtr bidiLevelBuffer)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_Handle, glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
		}
		return Messaging.nuint_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_Handle, glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
	}

	[Export("printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize GetInterGlyphSpacing(NSLayoutManager layoutManager, NSRange nominallySpacedGlyphsRange, IntPtr packedGlyphs, nuint packedGlyphsCount)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_NSRange_IntPtr_nuint(class_ptr, selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_Handle, layoutManager.Handle, nominallySpacedGlyphsRange, packedGlyphs, packedGlyphsCount);
	}

	[Export("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetLineFragment(out CGRect lineFragmentRect, out CGRect lineFragmentUsedRect, NSRange paragraphSeparatorGlyphRange, CGPoint proposedOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_CGRect_out_CGRect_NSRange_CGPoint(base.Handle, selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_Handle, out lineFragmentRect, out lineFragmentUsedRect, paragraphSeparatorGlyphRange, proposedOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_CGRect_out_CGRect_NSRange_CGPoint(base.SuperHandle, selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_Handle, out lineFragmentRect, out lineFragmentUsedRect, paragraphSeparatorGlyphRange, proposedOrigin);
		}
	}

	[Export("getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetLineFragment(out CGRect lineFragment, out CGRect lineFragmentUsed, out CGRect remaining, nuint startingGlyphIndex, CGRect proposedRect, nfloat lineSpacing, nfloat paragraphSpacingBefore, nfloat paragraphSpacingAfter)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_CGRect_out_CGRect_out_CGRect_nuint_CGRect_nfloat_nfloat_nfloat(base.Handle, selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_Handle, out lineFragment, out lineFragmentUsed, out remaining, startingGlyphIndex, proposedRect, lineSpacing, paragraphSpacingBefore, paragraphSpacingAfter);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_CGRect_out_CGRect_out_CGRect_nuint_CGRect_nfloat_nfloat_nfloat(base.SuperHandle, selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_Handle, out lineFragment, out lineFragmentUsed, out remaining, startingGlyphIndex, proposedRect, lineSpacing, paragraphSpacingBefore, paragraphSpacingAfter);
		}
	}

	[Export("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetLineSpacingAfterGlyph(nuint glyphIndex, CGRect proposedLineFragmentRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint_CGRect(base.Handle, selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint_CGRect(base.SuperHandle, selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
	}

	[Export("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetParagraphSpacingAfterGlyph(nuint glyphIndex, CGRect proposedLineFragmentRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint_CGRect(base.Handle, selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint_CGRect(base.SuperHandle, selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
	}

	[Export("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetParagraphSpacingBeforeGlyph(nuint glyphIndex, CGRect proposedLineFragmentRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint_CGRect(base.Handle, selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint_CGRect(base.SuperHandle, selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_Handle, glyphIndex, proposedLineFragmentRect);
	}

	[Export("sharedSystemTypesetterForBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTypesetter GetSharedSystemTypesetter(NSTypesetterBehavior forBehavior)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTypesetter>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSharedSystemTypesetterForBehavior_Handle, (long)forBehavior));
	}

	[Export("substituteFontForFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont GetSubstituteFont(NSFont originalFont)
	{
		NSApplication.EnsureUIThread();
		if (originalFont == null)
		{
			throw new ArgumentNullException("originalFont");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubstituteFontForFont_Handle, originalFont.Handle));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubstituteFontForFont_Handle, originalFont.Handle));
	}

	[Export("textTabForGlyphLocation:writingDirection:maxLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextTab GetTextTab(nfloat glyphLocation, NSWritingDirection direction, nfloat maxLocation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTextTab>(Messaging.IntPtr_objc_msgSend_nfloat_Int64_nfloat(base.Handle, selTextTabForGlyphLocation_WritingDirection_MaxLocation_Handle, glyphLocation, (long)direction, maxLocation));
		}
		return Runtime.GetNSObject<NSTextTab>(Messaging.IntPtr_objc_msgSendSuper_nfloat_Int64_nfloat(base.SuperHandle, selTextTabForGlyphLocation_WritingDirection_MaxLocation_Handle, glyphLocation, (long)direction, maxLocation));
	}

	[Export("glyphRangeForCharacterRange:actualCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GlyphRangeForCharacterRange(NSRange charRange, out NSRange actualCharRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_out_NSRange(base.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_Handle, charRange, out actualCharRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_out_NSRange(base.SuperHandle, selGlyphRangeForCharacterRange_ActualCharacterRange_Handle, charRange, out actualCharRange);
	}

	[Export("hyphenCharacterForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint HyphenCharacterForGlyph(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_nuint(base.Handle, selHyphenCharacterForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.UInt32_objc_msgSendSuper_nuint(base.SuperHandle, selHyphenCharacterForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("hyphenationFactorForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HyphenationFactorForGlyph(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_nuint(base.Handle, selHyphenationFactorForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.float_objc_msgSendSuper_nuint(base.SuperHandle, selHyphenationFactorForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("insertGlyph:atGlyphIndex:characterIndex:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertGlyph(uint glyph, nuint glyphIndex, nuint characterIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_nuint_nuint(base.Handle, selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle, glyph, glyphIndex, characterIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_nuint_nuint(base.SuperHandle, selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle, glyph, glyphIndex, characterIndex);
		}
	}

	[Export("layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange LayoutCharacters(NSRange characterRange, NSLayoutManager layoutManager, nuint maxLineFragments)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_IntPtr_nuint(base.Handle, selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_Handle, characterRange, layoutManager.Handle, maxLineFragments);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr_nuint(base.SuperHandle, selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_Handle, characterRange, layoutManager.Handle, maxLineFragments);
	}

	[Export("layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutGlyphs(NSLayoutManager layoutManager, nuint startGlyphIndex, nuint maxLineFragments, out nuint nextGlyph)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_nuint_out_nuint(base.Handle, selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_Handle, layoutManager.Handle, startGlyphIndex, maxLineFragments, out nextGlyph);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_nuint_out_nuint(base.SuperHandle, selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_Handle, layoutManager.Handle, startGlyphIndex, maxLineFragments, out nextGlyph);
		}
	}

	[Export("layoutParagraphAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint LayoutParagraphAtPoint(ref CGPoint lineFragmentOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_ref_CGPoint(base.Handle, selLayoutParagraphAtPoint_Handle, ref lineFragmentOrigin);
		}
		return Messaging.nuint_objc_msgSendSuper_ref_CGPoint(base.SuperHandle, selLayoutParagraphAtPoint_Handle, ref lineFragmentOrigin);
	}

	[Export("setAttachmentSize:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttachmentSize(CGSize attachmentSize, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize_NSRange(base.Handle, selSetAttachmentSize_ForGlyphRange_Handle, attachmentSize, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize_NSRange(base.SuperHandle, selSetAttachmentSize_ForGlyphRange_Handle, attachmentSize, glyphRange);
		}
	}

	[Export("setBidiLevels:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBidiLevels(IntPtr levels, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetBidiLevels_ForGlyphRange_Handle, levels, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetBidiLevels_ForGlyphRange_Handle, levels, glyphRange);
		}
	}

	[Export("setDrawsOutsideLineFragment:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDrawsOutsideLineFragment(bool flag, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_NSRange(base.Handle, selSetDrawsOutsideLineFragment_ForGlyphRange_Handle, flag, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_NSRange(base.SuperHandle, selSetDrawsOutsideLineFragment_ForGlyphRange_Handle, flag, glyphRange);
		}
	}

	[Export("setHardInvalidation:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHardInvalidation(bool value, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_NSRange(base.Handle, selSetHardInvalidation_ForGlyphRange_Handle, value, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_NSRange(base.SuperHandle, selSetHardInvalidation_ForGlyphRange_Handle, value, glyphRange);
		}
	}

	[Export("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLineFragment(CGRect fragmentRect, NSRange glyphRange, CGRect usedRect, nfloat baselineOffset)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_NSRange_CGRect_nfloat(base.Handle, selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle, fragmentRect, glyphRange, usedRect, baselineOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect_nfloat(base.SuperHandle, selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle, fragmentRect, glyphRange, usedRect, baselineOffset);
		}
	}

	[Export("setLocation:withAdvancements:forStartOfGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLocation(CGPoint location, IntPtr advancements, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_IntPtr_NSRange(base.Handle, selSetLocation_WithAdvancements_ForStartOfGlyphRange_Handle, location, advancements, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_IntPtr_NSRange(base.SuperHandle, selSetLocation_WithAdvancements_ForStartOfGlyphRange_Handle, location, advancements, glyphRange);
		}
	}

	[Export("setNotShownAttribute:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNotShownAttribute(bool flag, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_NSRange(base.Handle, selSetNotShownAttribute_ForGlyphRange_Handle, flag, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_NSRange(base.SuperHandle, selSetNotShownAttribute_ForGlyphRange_Handle, flag, glyphRange);
		}
	}

	[Export("setParagraphGlyphRange:separatorGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetParagraphGlyphRange(NSRange paragraphRange, NSRange paragraphSeparatorRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_NSRange(base.Handle, selSetParagraphGlyphRange_SeparatorGlyphRange_Handle, paragraphRange, paragraphSeparatorRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_NSRange(base.SuperHandle, selSetParagraphGlyphRange_SeparatorGlyphRange_Handle, paragraphRange, paragraphSeparatorRange);
		}
	}

	[Export("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBreakLineByHyphenatingBeforeCharacter(nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_Handle, charIndex);
	}

	[Export("shouldBreakLineByWordBeforeCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBreakLineByWordBeforeCharacter(nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selShouldBreakLineByWordBeforeCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selShouldBreakLineByWordBeforeCharacterAtIndex_Handle, charIndex);
	}

	[Export("substituteGlyphsInRange:withGlyphs:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SubstituteGlyphs(NSRange glyphRange, IntPtr glyphs)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selSubstituteGlyphsInRange_WithGlyphs_Handle, glyphRange, glyphs);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selSubstituteGlyphsInRange_WithGlyphs_Handle, glyphRange, glyphs);
		}
	}

	[Export("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSetLineFragment(ref CGRect lineRect, NSRange glyphRange, ref CGRect usedRect, ref nfloat baselineOffset)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_CGRect_NSRange_ref_CGRect_ref_nfloat(base.Handle, selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle, ref lineRect, glyphRange, ref usedRect, ref baselineOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_CGRect_NSRange_ref_CGRect_ref_nfloat(base.SuperHandle, selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_Handle, ref lineRect, glyphRange, ref usedRect, ref baselineOffset);
		}
	}
}
