using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutManager", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class NSLayoutManager : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGGlyphAtIndex_ = "CGGlyphAtIndex:";

	private static readonly IntPtr selCGGlyphAtIndex_Handle = Selector.GetHandle("CGGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGGlyphAtIndex_IsValidIndex_ = "CGGlyphAtIndex:isValidIndex:";

	private static readonly IntPtr selCGGlyphAtIndex_IsValidIndex_Handle = Selector.GetHandle("CGGlyphAtIndex:isValidIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTemporaryAttribute_Value_ForCharacterRange_ = "addTemporaryAttribute:value:forCharacterRange:";

	private static readonly IntPtr selAddTemporaryAttribute_Value_ForCharacterRange_Handle = Selector.GetHandle("addTemporaryAttribute:value:forCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTemporaryAttributes_ForCharacterRange_ = "addTemporaryAttributes:forCharacterRange:";

	private static readonly IntPtr selAddTemporaryAttributes_ForCharacterRange_Handle = Selector.GetHandle("addTemporaryAttributes:forCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTextContainer_ = "addTextContainer:";

	private static readonly IntPtr selAddTextContainer_Handle = Selector.GetHandle("addTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsNonContiguousLayout = "allowsNonContiguousLayout";

	private static readonly IntPtr selAllowsNonContiguousLayoutHandle = Selector.GetHandle("allowsNonContiguousLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachmentSizeForGlyphAtIndex_ = "attachmentSizeForGlyphAtIndex:";

	private static readonly IntPtr selAttachmentSizeForGlyphAtIndex_Handle = Selector.GetHandle("attachmentSizeForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedString = "attributedString";

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundLayoutEnabled = "backgroundLayoutEnabled";

	private static readonly IntPtr selBackgroundLayoutEnabledHandle = Selector.GetHandle("backgroundLayoutEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectForGlyphRange_InTextContainer_ = "boundingRectForGlyphRange:inTextContainer:";

	private static readonly IntPtr selBoundingRectForGlyphRange_InTextContainer_Handle = Selector.GetHandle("boundingRectForGlyphRange:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsRectForTextBlock_AtIndex_EffectiveRange_ = "boundsRectForTextBlock:atIndex:effectiveRange:";

	private static readonly IntPtr selBoundsRectForTextBlock_AtIndex_EffectiveRange_Handle = Selector.GetHandle("boundsRectForTextBlock:atIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsRectForTextBlock_GlyphRange_ = "boundsRectForTextBlock:glyphRange:";

	private static readonly IntPtr selBoundsRectForTextBlock_GlyphRange_Handle = Selector.GetHandle("boundsRectForTextBlock:glyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIndexForGlyphAtIndex_ = "characterIndexForGlyphAtIndex:";

	private static readonly IntPtr selCharacterIndexForGlyphAtIndex_Handle = Selector.GetHandle("characterIndexForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_ = "characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:";

	private static readonly IntPtr selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_Handle = Selector.GetHandle("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterRangeForGlyphRange_ActualGlyphRange_ = "characterRangeForGlyphRange:actualGlyphRange:";

	private static readonly IntPtr selCharacterRangeForGlyphRange_ActualGlyphRange_Handle = Selector.GetHandle("characterRangeForGlyphRange:actualGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAttachmentScaling = "defaultAttachmentScaling";

	private static readonly IntPtr selDefaultAttachmentScalingHandle = Selector.GetHandle("defaultAttachmentScaling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultBaselineOffsetForFont_ = "defaultBaselineOffsetForFont:";

	private static readonly IntPtr selDefaultBaselineOffsetForFont_Handle = Selector.GetHandle("defaultBaselineOffsetForFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultLineHeightForFont_ = "defaultLineHeightForFont:";

	private static readonly IntPtr selDefaultLineHeightForFont_Handle = Selector.GetHandle("defaultLineHeightForFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteGlyphsInRange_ = "deleteGlyphsInRange:";

	private static readonly IntPtr selDeleteGlyphsInRange_Handle = Selector.GetHandle("deleteGlyphsInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBackgroundForGlyphRange_AtPoint_ = "drawBackgroundForGlyphRange:atPoint:";

	private static readonly IntPtr selDrawBackgroundForGlyphRange_AtPoint_Handle = Selector.GetHandle("drawBackgroundForGlyphRange:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawGlyphsForGlyphRange_AtPoint_ = "drawGlyphsForGlyphRange:atPoint:";

	private static readonly IntPtr selDrawGlyphsForGlyphRange_AtPoint_Handle = Selector.GetHandle("drawGlyphsForGlyphRange:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_ = "drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";

	private static readonly IntPtr selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle = Selector.GetHandle("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_ = "drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";

	private static readonly IntPtr selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle = Selector.GetHandle("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsOutsideLineFragmentForGlyphAtIndex_ = "drawsOutsideLineFragmentForGlyphAtIndex:";

	private static readonly IntPtr selDrawsOutsideLineFragmentForGlyphAtIndex_Handle = Selector.GetHandle("drawsOutsideLineFragmentForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureGlyphsForCharacterRange_ = "ensureGlyphsForCharacterRange:";

	private static readonly IntPtr selEnsureGlyphsForCharacterRange_Handle = Selector.GetHandle("ensureGlyphsForCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureGlyphsForGlyphRange_ = "ensureGlyphsForGlyphRange:";

	private static readonly IntPtr selEnsureGlyphsForGlyphRange_Handle = Selector.GetHandle("ensureGlyphsForGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureLayoutForBoundingRect_InTextContainer_ = "ensureLayoutForBoundingRect:inTextContainer:";

	private static readonly IntPtr selEnsureLayoutForBoundingRect_InTextContainer_Handle = Selector.GetHandle("ensureLayoutForBoundingRect:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureLayoutForCharacterRange_ = "ensureLayoutForCharacterRange:";

	private static readonly IntPtr selEnsureLayoutForCharacterRange_Handle = Selector.GetHandle("ensureLayoutForCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureLayoutForGlyphRange_ = "ensureLayoutForGlyphRange:";

	private static readonly IntPtr selEnsureLayoutForGlyphRange_Handle = Selector.GetHandle("ensureLayoutForGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureLayoutForTextContainer_ = "ensureLayoutForTextContainer:";

	private static readonly IntPtr selEnsureLayoutForTextContainer_Handle = Selector.GetHandle("ensureLayoutForTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_ = "enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:";

	private static readonly IntPtr selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_Handle = Selector.GetHandle("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateLineFragmentsForGlyphRange_UsingBlock_ = "enumerateLineFragmentsForGlyphRange:usingBlock:";

	private static readonly IntPtr selEnumerateLineFragmentsForGlyphRange_UsingBlock_Handle = Selector.GetHandle("enumerateLineFragmentsForGlyphRange:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtraLineFragmentRect = "extraLineFragmentRect";

	private static readonly IntPtr selExtraLineFragmentRectHandle = Selector.GetHandle("extraLineFragmentRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtraLineFragmentTextContainer = "extraLineFragmentTextContainer";

	private static readonly IntPtr selExtraLineFragmentTextContainerHandle = Selector.GetHandle("extraLineFragmentTextContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtraLineFragmentUsedRect = "extraLineFragmentUsedRect";

	private static readonly IntPtr selExtraLineFragmentUsedRectHandle = Selector.GetHandle("extraLineFragmentUsedRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillBackgroundRectArray_Count_ForCharacterRange_Color_ = "fillBackgroundRectArray:count:forCharacterRange:color:";

	private static readonly IntPtr selFillBackgroundRectArray_Count_ForCharacterRange_Color_Handle = Selector.GetHandle("fillBackgroundRectArray:count:forCharacterRange:color:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstUnlaidCharacterIndex = "firstUnlaidCharacterIndex";

	private static readonly IntPtr selFirstUnlaidCharacterIndexHandle = Selector.GetHandle("firstUnlaidCharacterIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstUnlaidGlyphIndex = "firstUnlaidGlyphIndex";

	private static readonly IntPtr selFirstUnlaidGlyphIndexHandle = Selector.GetHandle("firstUnlaidGlyphIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFractionOfDistanceThroughGlyphForPoint_InTextContainer_ = "fractionOfDistanceThroughGlyphForPoint:inTextContainer:";

	private static readonly IntPtr selFractionOfDistanceThroughGlyphForPoint_InTextContainer_Handle = Selector.GetHandle("fractionOfDistanceThroughGlyphForPoint:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFirstUnlaidCharacterIndex_GlyphIndex_ = "getFirstUnlaidCharacterIndex:glyphIndex:";

	private static readonly IntPtr selGetFirstUnlaidCharacterIndex_GlyphIndex_Handle = Selector.GetHandle("getFirstUnlaidCharacterIndex:glyphIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_ = "getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:";

	private static readonly IntPtr selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_Handle = Selector.GetHandle("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_ = "getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:";

	private static readonly IntPtr selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_Handle = Selector.GetHandle("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphAtIndex_ = "glyphAtIndex:";

	private static readonly IntPtr selGlyphAtIndex_Handle = Selector.GetHandle("glyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphAtIndex_IsValidIndex_ = "glyphAtIndex:isValidIndex:";

	private static readonly IntPtr selGlyphAtIndex_IsValidIndex_Handle = Selector.GetHandle("glyphAtIndex:isValidIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphGenerator = "glyphGenerator";

	private static readonly IntPtr selGlyphGeneratorHandle = Selector.GetHandle("glyphGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphIndexForCharacterAtIndex_ = "glyphIndexForCharacterAtIndex:";

	private static readonly IntPtr selGlyphIndexForCharacterAtIndex_Handle = Selector.GetHandle("glyphIndexForCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphIndexForPoint_InTextContainer_ = "glyphIndexForPoint:inTextContainer:";

	private static readonly IntPtr selGlyphIndexForPoint_InTextContainer_Handle = Selector.GetHandle("glyphIndexForPoint:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_ = "glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:";

	private static readonly IntPtr selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_Handle = Selector.GetHandle("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphRangeForBoundingRect_InTextContainer_ = "glyphRangeForBoundingRect:inTextContainer:";

	private static readonly IntPtr selGlyphRangeForBoundingRect_InTextContainer_Handle = Selector.GetHandle("glyphRangeForBoundingRect:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_ = "glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:";

	private static readonly IntPtr selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_Handle = Selector.GetHandle("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphRangeForCharacterRange_ActualCharacterRange_ = "glyphRangeForCharacterRange:actualCharacterRange:";

	private static readonly IntPtr selGlyphRangeForCharacterRange_ActualCharacterRange_Handle = Selector.GetHandle("glyphRangeForCharacterRange:actualCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphRangeForTextContainer_ = "glyphRangeForTextContainer:";

	private static readonly IntPtr selGlyphRangeForTextContainer_Handle = Selector.GetHandle("glyphRangeForTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasNonContiguousLayout = "hasNonContiguousLayout";

	private static readonly IntPtr selHasNonContiguousLayoutHandle = Selector.GetHandle("hasNonContiguousLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHyphenationFactor = "hyphenationFactor";

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertGlyph_AtGlyphIndex_CharacterIndex_ = "insertGlyph:atGlyphIndex:characterIndex:";

	private static readonly IntPtr selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle = Selector.GetHandle("insertGlyph:atGlyphIndex:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTextContainer_AtIndex_ = "insertTextContainer:atIndex:";

	private static readonly IntPtr selInsertTextContainer_AtIndex_Handle = Selector.GetHandle("insertTextContainer:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntAttribute_ForGlyphAtIndex_ = "intAttribute:forGlyphAtIndex:";

	private static readonly IntPtr selIntAttribute_ForGlyphAtIndex_Handle = Selector.GetHandle("intAttribute:forGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateDisplayForCharacterRange_ = "invalidateDisplayForCharacterRange:";

	private static readonly IntPtr selInvalidateDisplayForCharacterRange_Handle = Selector.GetHandle("invalidateDisplayForCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateDisplayForGlyphRange_ = "invalidateDisplayForGlyphRange:";

	private static readonly IntPtr selInvalidateDisplayForGlyphRange_Handle = Selector.GetHandle("invalidateDisplayForGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_ = "invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:";

	private static readonly IntPtr selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_Handle = Selector.GetHandle("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_ = "invalidateGlyphsOnLayoutInvalidationForGlyphRange:";

	private static readonly IntPtr selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle = Selector.GetHandle("invalidateGlyphsOnLayoutInvalidationForGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateLayoutForCharacterRange_ActualCharacterRange_ = "invalidateLayoutForCharacterRange:actualCharacterRange:";

	private static readonly IntPtr selInvalidateLayoutForCharacterRange_ActualCharacterRange_Handle = Selector.GetHandle("invalidateLayoutForCharacterRange:actualCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidGlyphIndex_ = "isValidGlyphIndex:";

	private static readonly IntPtr selIsValidGlyphIndex_Handle = Selector.GetHandle("isValidGlyphIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutOptions = "layoutOptions";

	private static readonly IntPtr selLayoutOptionsHandle = Selector.GetHandle("layoutOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutRectForTextBlock_AtIndex_EffectiveRange_ = "layoutRectForTextBlock:atIndex:effectiveRange:";

	private static readonly IntPtr selLayoutRectForTextBlock_AtIndex_EffectiveRange_Handle = Selector.GetHandle("layoutRectForTextBlock:atIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutRectForTextBlock_GlyphRange_ = "layoutRectForTextBlock:glyphRange:";

	private static readonly IntPtr selLayoutRectForTextBlock_GlyphRange_Handle = Selector.GetHandle("layoutRectForTextBlock:glyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLimitsLayoutForSuspiciousContents = "limitsLayoutForSuspiciousContents";

	private static readonly IntPtr selLimitsLayoutForSuspiciousContentsHandle = Selector.GetHandle("limitsLayoutForSuspiciousContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentRectForGlyphAtIndex_EffectiveRange_ = "lineFragmentRectForGlyphAtIndex:effectiveRange:";

	private static readonly IntPtr selLineFragmentRectForGlyphAtIndex_EffectiveRange_Handle = Selector.GetHandle("lineFragmentRectForGlyphAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_ = "lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";

	private static readonly IntPtr selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle = Selector.GetHandle("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_ = "lineFragmentUsedRectForGlyphAtIndex:effectiveRange:";

	private static readonly IntPtr selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_Handle = Selector.GetHandle("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_ = "lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";

	private static readonly IntPtr selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle = Selector.GetHandle("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationForGlyphAtIndex_ = "locationForGlyphAtIndex:";

	private static readonly IntPtr selLocationForGlyphAtIndex_Handle = Selector.GetHandle("locationForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotShownAttributeForGlyphAtIndex_ = "notShownAttributeForGlyphAtIndex:";

	private static readonly IntPtr selNotShownAttributeForGlyphAtIndex_Handle = Selector.GetHandle("notShownAttributeForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfGlyphs = "numberOfGlyphs";

	private static readonly IntPtr selNumberOfGlyphsHandle = Selector.GetHandle("numberOfGlyphs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_ = "processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:";

	private static readonly IntPtr selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle = Selector.GetHandle("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyForGlyphAtIndex_ = "propertyForGlyphAtIndex:";

	private static readonly IntPtr selPropertyForGlyphAtIndex_Handle = Selector.GetHandle("propertyForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfNominallySpacedGlyphsContainingIndex_ = "rangeOfNominallySpacedGlyphsContainingIndex:";

	private static readonly IntPtr selRangeOfNominallySpacedGlyphsContainingIndex_Handle = Selector.GetHandle("rangeOfNominallySpacedGlyphsContainingIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_ = "rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:";

	private static readonly IntPtr selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_Handle = Selector.GetHandle("rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTemporaryAttribute_ForCharacterRange_ = "removeTemporaryAttribute:forCharacterRange:";

	private static readonly IntPtr selRemoveTemporaryAttribute_ForCharacterRange_Handle = Selector.GetHandle("removeTemporaryAttribute:forCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTextContainerAtIndex_ = "removeTextContainerAtIndex:";

	private static readonly IntPtr selRemoveTextContainerAtIndex_Handle = Selector.GetHandle("removeTextContainerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceGlyphAtIndex_WithGlyph_ = "replaceGlyphAtIndex:withGlyph:";

	private static readonly IntPtr selReplaceGlyphAtIndex_WithGlyph_Handle = Selector.GetHandle("replaceGlyphAtIndex:withGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceTextStorage_ = "replaceTextStorage:";

	private static readonly IntPtr selReplaceTextStorage_Handle = Selector.GetHandle("replaceTextStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsNonContiguousLayout_ = "setAllowsNonContiguousLayout:";

	private static readonly IntPtr selSetAllowsNonContiguousLayout_Handle = Selector.GetHandle("setAllowsNonContiguousLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttachmentSize_ForGlyphRange_ = "setAttachmentSize:forGlyphRange:";

	private static readonly IntPtr selSetAttachmentSize_ForGlyphRange_Handle = Selector.GetHandle("setAttachmentSize:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundLayoutEnabled_ = "setBackgroundLayoutEnabled:";

	private static readonly IntPtr selSetBackgroundLayoutEnabled_Handle = Selector.GetHandle("setBackgroundLayoutEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundsRect_ForTextBlock_GlyphRange_ = "setBoundsRect:forTextBlock:glyphRange:";

	private static readonly IntPtr selSetBoundsRect_ForTextBlock_GlyphRange_Handle = Selector.GetHandle("setBoundsRect:forTextBlock:glyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCharacterIndex_ForGlyphAtIndex_ = "setCharacterIndex:forGlyphAtIndex:";

	private static readonly IntPtr selSetCharacterIndex_ForGlyphAtIndex_Handle = Selector.GetHandle("setCharacterIndex:forGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultAttachmentScaling_ = "setDefaultAttachmentScaling:";

	private static readonly IntPtr selSetDefaultAttachmentScaling_Handle = Selector.GetHandle("setDefaultAttachmentScaling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsOutsideLineFragment_ForGlyphAtIndex_ = "setDrawsOutsideLineFragment:forGlyphAtIndex:";

	private static readonly IntPtr selSetDrawsOutsideLineFragment_ForGlyphAtIndex_Handle = Selector.GetHandle("setDrawsOutsideLineFragment:forGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtraLineFragmentRect_UsedRect_TextContainer_ = "setExtraLineFragmentRect:usedRect:textContainer:";

	private static readonly IntPtr selSetExtraLineFragmentRect_UsedRect_TextContainer_Handle = Selector.GetHandle("setExtraLineFragmentRect:usedRect:textContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGlyphGenerator_ = "setGlyphGenerator:";

	private static readonly IntPtr selSetGlyphGenerator_Handle = Selector.GetHandle("setGlyphGenerator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_ = "setGlyphs:properties:characterIndexes:font:forGlyphRange:";

	private static readonly IntPtr selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_Handle = Selector.GetHandle("setGlyphs:properties:characterIndexes:font:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHyphenationFactor_ = "setHyphenationFactor:";

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntAttribute_Value_ForGlyphAtIndex_ = "setIntAttribute:value:forGlyphAtIndex:";

	private static readonly IntPtr selSetIntAttribute_Value_ForGlyphAtIndex_Handle = Selector.GetHandle("setIntAttribute:value:forGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutRect_ForTextBlock_GlyphRange_ = "setLayoutRect:forTextBlock:glyphRange:";

	private static readonly IntPtr selSetLayoutRect_ForTextBlock_GlyphRange_Handle = Selector.GetHandle("setLayoutRect:forTextBlock:glyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLimitsLayoutForSuspiciousContents_ = "setLimitsLayoutForSuspiciousContents:";

	private static readonly IntPtr selSetLimitsLayoutForSuspiciousContents_Handle = Selector.GetHandle("setLimitsLayoutForSuspiciousContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineFragmentRect_ForGlyphRange_UsedRect_ = "setLineFragmentRect:forGlyphRange:usedRect:";

	private static readonly IntPtr selSetLineFragmentRect_ForGlyphRange_UsedRect_Handle = Selector.GetHandle("setLineFragmentRect:forGlyphRange:usedRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocation_ForStartOfGlyphRange_ = "setLocation:forStartOfGlyphRange:";

	private static readonly IntPtr selSetLocation_ForStartOfGlyphRange_Handle = Selector.GetHandle("setLocation:forStartOfGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotShownAttribute_ForGlyphAtIndex_ = "setNotShownAttribute:forGlyphAtIndex:";

	private static readonly IntPtr selSetNotShownAttribute_ForGlyphAtIndex_Handle = Selector.GetHandle("setNotShownAttribute:forGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsControlCharacters_ = "setShowsControlCharacters:";

	private static readonly IntPtr selSetShowsControlCharacters_Handle = Selector.GetHandle("setShowsControlCharacters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsInvisibleCharacters_ = "setShowsInvisibleCharacters:";

	private static readonly IntPtr selSetShowsInvisibleCharacters_Handle = Selector.GetHandle("setShowsInvisibleCharacters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTemporaryAttributes_ForCharacterRange_ = "setTemporaryAttributes:forCharacterRange:";

	private static readonly IntPtr selSetTemporaryAttributes_ForCharacterRange_Handle = Selector.GetHandle("setTemporaryAttributes:forCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextContainer_ForGlyphRange_ = "setTextContainer:forGlyphRange:";

	private static readonly IntPtr selSetTextContainer_ForGlyphRange_Handle = Selector.GetHandle("setTextContainer:forGlyphRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextStorage_ = "setTextStorage:";

	private static readonly IntPtr selSetTextStorage_Handle = Selector.GetHandle("setTextStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTypesetter_ = "setTypesetter:";

	private static readonly IntPtr selSetTypesetter_Handle = Selector.GetHandle("setTypesetter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTypesetterBehavior_ = "setTypesetterBehavior:";

	private static readonly IntPtr selSetTypesetterBehavior_Handle = Selector.GetHandle("setTypesetterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesDefaultHyphenation_ = "setUsesDefaultHyphenation:";

	private static readonly IntPtr selSetUsesDefaultHyphenation_Handle = Selector.GetHandle("setUsesDefaultHyphenation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFontLeading_ = "setUsesFontLeading:";

	private static readonly IntPtr selSetUsesFontLeading_Handle = Selector.GetHandle("setUsesFontLeading:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesScreenFonts_ = "setUsesScreenFonts:";

	private static readonly IntPtr selSetUsesScreenFonts_Handle = Selector.GetHandle("setUsesScreenFonts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowAttachmentCell_InRect_CharacterIndex_ = "showAttachmentCell:inRect:characterIndex:";

	private static readonly IntPtr selShowAttachmentCell_InRect_CharacterIndex_Handle = Selector.GetHandle("showAttachmentCell:inRect:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_ = "showCGGlyphs:positions:count:font:matrix:attributes:inContext:";

	private static readonly IntPtr selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_Handle = Selector.GetHandle("showCGGlyphs:positions:count:font:matrix:attributes:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_ = "showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:";

	private static readonly IntPtr selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_Handle = Selector.GetHandle("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsControlCharacters = "showsControlCharacters";

	private static readonly IntPtr selShowsControlCharactersHandle = Selector.GetHandle("showsControlCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsInvisibleCharacters = "showsInvisibleCharacters";

	private static readonly IntPtr selShowsInvisibleCharactersHandle = Selector.GetHandle("showsInvisibleCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_ = "strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";

	private static readonly IntPtr selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle = Selector.GetHandle("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstituteFontForFont_ = "substituteFontForFont:";

	private static readonly IntPtr selSubstituteFontForFont_Handle = Selector.GetHandle("substituteFontForFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryAttribute_AtCharacterIndex_EffectiveRange_ = "temporaryAttribute:atCharacterIndex:effectiveRange:";

	private static readonly IntPtr selTemporaryAttribute_AtCharacterIndex_EffectiveRange_Handle = Selector.GetHandle("temporaryAttribute:atCharacterIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_ = "temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:";

	private static readonly IntPtr selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_Handle = Selector.GetHandle("temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryAttributesAtCharacterIndex_EffectiveRange_ = "temporaryAttributesAtCharacterIndex:effectiveRange:";

	private static readonly IntPtr selTemporaryAttributesAtCharacterIndex_EffectiveRange_Handle = Selector.GetHandle("temporaryAttributesAtCharacterIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_ = "temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:";

	private static readonly IntPtr selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_Handle = Selector.GetHandle("temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerChangedGeometry_ = "textContainerChangedGeometry:";

	private static readonly IntPtr selTextContainerChangedGeometry_Handle = Selector.GetHandle("textContainerChangedGeometry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerChangedTextView_ = "textContainerChangedTextView:";

	private static readonly IntPtr selTextContainerChangedTextView_Handle = Selector.GetHandle("textContainerChangedTextView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerForGlyphAtIndex_EffectiveRange_ = "textContainerForGlyphAtIndex:effectiveRange:";

	private static readonly IntPtr selTextContainerForGlyphAtIndex_EffectiveRange_Handle = Selector.GetHandle("textContainerForGlyphAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_ = "textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";

	private static readonly IntPtr selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle = Selector.GetHandle("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContainers = "textContainers";

	private static readonly IntPtr selTextContainersHandle = Selector.GetHandle("textContainers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStorage = "textStorage";

	private static readonly IntPtr selTextStorageHandle = Selector.GetHandle("textStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_ = "textStorage:edited:range:changeInLength:invalidatedRange:";

	private static readonly IntPtr selTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle = Selector.GetHandle("textStorage:edited:range:changeInLength:invalidatedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_ = "truncatedGlyphRangeInLineFragmentForGlyphAtIndex:";

	private static readonly IntPtr selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_Handle = Selector.GetHandle("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypesetter = "typesetter";

	private static readonly IntPtr selTypesetterHandle = Selector.GetHandle("typesetter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypesetterBehavior = "typesetterBehavior";

	private static readonly IntPtr selTypesetterBehaviorHandle = Selector.GetHandle("typesetterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_ = "underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";

	private static readonly IntPtr selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle = Selector.GetHandle("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsedRectForTextContainer_ = "usedRectForTextContainer:";

	private static readonly IntPtr selUsedRectForTextContainer_Handle = Selector.GetHandle("usedRectForTextContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesDefaultHyphenation = "usesDefaultHyphenation";

	private static readonly IntPtr selUsesDefaultHyphenationHandle = Selector.GetHandle("usesDefaultHyphenation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFontLeading = "usesFontLeading";

	private static readonly IntPtr selUsesFontLeadingHandle = Selector.GetHandle("usesFontLeading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesScreenFonts = "usesScreenFonts";

	private static readonly IntPtr selUsesScreenFontsHandle = Selector.GetHandle("usesScreenFonts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TextStorage_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool AllowsNonContiguousLayout
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("allowsNonContiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsNonContiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsNonContiguousLayoutHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setAllowsNonContiguousLayout:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsNonContiguousLayout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsNonContiguousLayout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'TextStorage' instead.")]
	public virtual NSAttributedString AttributedString
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'TextStorage' instead.")]
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
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual bool BackgroundLayoutEnabled
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("backgroundLayoutEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBackgroundLayoutEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBackgroundLayoutEnabledHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setBackgroundLayoutEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBackgroundLayoutEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBackgroundLayoutEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual NSImageScaling DefaultAttachmentScaling
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("defaultAttachmentScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSImageScaling)Messaging.UInt64_objc_msgSend(base.Handle, selDefaultAttachmentScalingHandle);
			}
			return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDefaultAttachmentScalingHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setDefaultAttachmentScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDefaultAttachmentScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDefaultAttachmentScaling_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSLayoutManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSLayoutManagerDelegate;
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
	public virtual CGRect ExtraLineFragmentRect
	{
		[Export("extraLineFragmentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtraLineFragmentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtraLineFragmentRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextContainer ExtraLineFragmentTextContainer
	{
		[Export("extraLineFragmentTextContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtraLineFragmentTextContainerHandle));
			}
			return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtraLineFragmentTextContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ExtraLineFragmentUsedRect
	{
		[Export("extraLineFragmentUsedRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtraLineFragmentUsedRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtraLineFragmentUsedRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint FirstUnlaidCharacterIndex
	{
		[Export("firstUnlaidCharacterIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFirstUnlaidCharacterIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFirstUnlaidCharacterIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint FirstUnlaidGlyphIndex
	{
		[Export("firstUnlaidGlyphIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFirstUnlaidGlyphIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFirstUnlaidGlyphIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSGlyphGenerator GlyphGenerator
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("glyphGenerator", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSGlyphGenerator>(Messaging.IntPtr_objc_msgSend(base.Handle, selGlyphGeneratorHandle));
			}
			return Runtime.GetNSObject<NSGlyphGenerator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlyphGeneratorHandle));
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setGlyphGenerator:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGlyphGenerator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGlyphGenerator_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasNonContiguousLayout
	{
		[Export("hasNonContiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasNonContiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasNonContiguousLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public virtual float HyphenationFactor
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
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
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
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
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSGlyphStorageOptions LayoutOptions
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("layoutOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGlyphStorageOptions)Messaging.UInt64_objc_msgSend(base.Handle, selLayoutOptionsHandle);
			}
			return (NSGlyphStorageOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLayoutOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool LimitsLayoutForSuspiciousContents
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("limitsLayoutForSuspiciousContents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLimitsLayoutForSuspiciousContentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLimitsLayoutForSuspiciousContentsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setLimitsLayoutForSuspiciousContents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLimitsLayoutForSuspiciousContents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLimitsLayoutForSuspiciousContents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfGlyphs
	{
		[Export("numberOfGlyphs")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfGlyphsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfGlyphsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsControlCharacters
	{
		[Export("showsControlCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsControlCharactersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsControlCharactersHandle);
		}
		[Export("setShowsControlCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsControlCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsControlCharacters_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsInvisibleCharacters
	{
		[Export("showsInvisibleCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsInvisibleCharactersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsInvisibleCharactersHandle);
		}
		[Export("setShowsInvisibleCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsInvisibleCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsInvisibleCharacters_Handle, value);
			}
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
	public virtual NSTextStorage? TextStorage
	{
		[Export("textStorage", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSTextStorage nSTextStorage = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTextStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStorageHandle)) : Runtime.GetNSObject<NSTextStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStorageHandle)));
			MarkDirty();
			__mt_TextStorage_var = nSTextStorage;
			return nSTextStorage;
		}
		[Export("setTextStorage:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_TextStorage_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual NSTypesetter Typesetter
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("typesetter", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTypesetter>(Messaging.IntPtr_objc_msgSend(base.Handle, selTypesetterHandle));
			}
			return Runtime.GetNSObject<NSTypesetter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypesetterHandle));
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setTypesetter:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypesetter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypesetter_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual NSTypesetterBehavior TypesetterBehavior
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
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
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool UsesDefaultHyphenation
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("usesDefaultHyphenation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesDefaultHyphenationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesDefaultHyphenationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setUsesDefaultHyphenation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesDefaultHyphenation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesDefaultHyphenation_Handle, value);
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
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool UsesScreenFonts
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("usesScreenFonts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesScreenFontsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesScreenFontsHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setUsesScreenFonts:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesScreenFonts_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesScreenFonts_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
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

	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public unsafe CGRect[] GetRectArray(NSRange glyphRange, NSRange selectedGlyphRange, NSTextContainer textContainer)
	{
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		nuint rectCount;
		IntPtr rectArray = GetRectArray(glyphRange, selectedGlyphRange, textContainer.Handle, out rectCount);
		CGRect[] array = new CGRect[(ulong)rectCount];
		float* ptr = (float*)(void*)rectArray;
		for (nuint nuint = (byte)0; nuint < rectCount; ++nuint)
		{
			array[(ulong)nuint] = new CGRect(*ptr, ptr[1], ptr[2], ptr[3]);
			ptr += 4;
		}
		return array;
	}

	[Obsolete("Use 'GetIntAttribute' instead.")]
	public virtual nint IntAttributeforGlyphAtIndex(nint attributeTag, nint glyphIndex)
	{
		return GetIntAttribute(attributeTag, glyphIndex);
	}

	public unsafe nuint GetGlyphs(NSRange glyphRange, short[] glyphBuffer, NSGlyphProperty[] props, nuint[] charIndexBuffer, byte[] bidiLevelBuffer)
	{
		if (glyphBuffer != null && glyphBuffer.Length < glyphRange.Length)
		{
			throw new ArgumentOutOfRangeException($"glyphBuffer must have at least {glyphRange.Length} elements");
		}
		if (props != null && props.Length < glyphRange.Length)
		{
			throw new ArgumentOutOfRangeException($"props must have at least {glyphRange.Length} elements");
		}
		if (charIndexBuffer != null && charIndexBuffer.Length < glyphRange.Length)
		{
			throw new ArgumentOutOfRangeException($"props must have at least {glyphRange.Length} elements");
		}
		if (bidiLevelBuffer != null && bidiLevelBuffer.Length < glyphRange.Length)
		{
			throw new ArgumentOutOfRangeException($"bidiLevelBuffer must have at least {glyphRange.Length} elements");
		}
		fixed (short* ptr3 = glyphBuffer)
		{
			nuint glyphs;
			fixed (NSGlyphProperty* ptr = props)
			{
				void* ptr2 = ptr;
				fixed (nuint* ptr4 = charIndexBuffer)
				{
					fixed (byte* ptr5 = bidiLevelBuffer)
					{
						glyphs = GetGlyphs(glyphRange, (IntPtr)ptr3, (IntPtr)ptr2, (IntPtr)ptr4, (IntPtr)ptr5);
					}
				}
			}
			return glyphs;
		}
	}

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	public unsafe void ShowGlyphs(short[] glyphs, CGPoint[] positions, nuint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
	{
		fixed (short* ptr = glyphs)
		{
			fixed (CGPoint* ptr2 = positions)
			{
				ShowGlyphs((IntPtr)ptr, (IntPtr)ptr2, glyphCount, font, textMatrix, attributes, graphicsContext);
			}
		}
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public unsafe void ShowGlyphs(short[] glyphs, CGPoint[] positions, nint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
	{
		fixed (short* ptr = glyphs)
		{
			fixed (CGPoint* ptr2 = positions)
			{
				ShowGlyphs((IntPtr)ptr, (IntPtr)ptr2, glyphCount, font, textMatrix, attributes, graphicsContext);
			}
		}
	}

	public unsafe nuint GetLineFragmentInsertionPoints(nuint charIndex, bool alternatePosition, bool inDisplayOrder, nfloat[] positions, nint[] charIndexes)
	{
		fixed (nfloat* ptr = positions)
		{
			fixed (nint* ptr2 = charIndexes)
			{
				nuint lineFragmentInsertionPoints = GetLineFragmentInsertionPoints(charIndex, alternatePosition, inDisplayOrder, (IntPtr)ptr, (IntPtr)ptr2);
				if (positions != null && (ulong)positions.Length < (ulong)lineFragmentInsertionPoints)
				{
					throw new ArgumentException($"Memory corruption: the 'positions' array was not big enough to hold the number of insertion points. {lineFragmentInsertionPoints} insertion points were returned, while the array's Length is only {positions.Length}");
				}
				if (charIndexes != null && (ulong)charIndexes.Length < (ulong)lineFragmentInsertionPoints)
				{
					throw new ArgumentException($"Memory corruption: the 'charIndexes' array was not big enough to hold the number of insertion points. {lineFragmentInsertionPoints} insertion points were returned, while the array's Length is only {charIndexes.Length}");
				}
				return lineFragmentInsertionPoints;
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutManager()
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
	public NSLayoutManager(NSCoder coder)
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
	protected NSLayoutManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutManager(IntPtr handle)
		: base(handle)
	{
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddTemporaryAttribute(NSString attributeName, NSObject value, NSRange characterRange)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selAddTemporaryAttribute_Value_ForCharacterRange_Handle, attributeName.Handle, value.Handle, characterRange);
	}

	[Export("addTemporaryAttribute:value:forCharacterRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTemporaryAttribute(string attrName, NSObject value, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrName == null)
		{
			throw new ArgumentNullException("attrName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(attrName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selAddTemporaryAttribute_Value_ForCharacterRange_Handle, arg, value.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NSRange(base.SuperHandle, selAddTemporaryAttribute_Value_ForCharacterRange_Handle, arg, value.Handle, charRange);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addTemporaryAttributes:forCharacterRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTemporaryAttributes(NSDictionary attrs, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selAddTemporaryAttributes_ForCharacterRange_Handle, attrs.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selAddTemporaryAttributes_ForCharacterRange_Handle, attrs.Handle, charRange);
		}
	}

	[Export("addTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTextContainer_Handle, container.Handle);
		}
	}

	[Export("attachmentSizeForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize AttachmentSizeForGlyphAt(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_nint(base.Handle, selAttachmentSizeForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.CGSize_objc_msgSendSuper_nint(base.SuperHandle, selAttachmentSizeForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("boundingRectForGlyphRange:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundingRectForGlyphRange(NSRange glyphRange, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange_IntPtr(out retval, base.Handle, selBoundingRectForGlyphRange_InTextContainer_Handle, glyphRange, container.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange_IntPtr(out retval, base.SuperHandle, selBoundingRectForGlyphRange_InTextContainer_Handle, glyphRange, container.Handle);
		}
		return retval;
	}

	[Export("boundsRectForTextBlock:glyphRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundsRect(NSTextBlock block, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForTextBlock_GlyphRange_Handle, block.Handle, glyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForTextBlock_GlyphRange_Handle, block.Handle, glyphRange);
		}
		return retval;
	}

	[Export("characterIndexForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CharacterIndexForGlyphAtIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nint(base.Handle, selCharacterIndexForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.nuint_objc_msgSendSuper_nint(base.SuperHandle, selCharacterIndexForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:")]
	[Obsolete("Use 'GetCharacterIndex' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CharacterIndexForPoint(CGPoint point, NSTextContainer container, ref nfloat fractionOfDistanceBetweenInsertionPoints)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint_IntPtr_ref_nfloat(base.Handle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, ref fractionOfDistanceBetweenInsertionPoints);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint_IntPtr_ref_nfloat(base.SuperHandle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, ref fractionOfDistanceBetweenInsertionPoints);
	}

	[Export("characterRangeForGlyphRange:actualGlyphRange:")]
	[Obsolete("Use 'GetCharacterRange' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange CharacterRangeForGlyphRange(NSRange glyphRange, out NSRange actualGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange_out_NSRange(base.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, out actualGlyphRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange_out_NSRange(base.SuperHandle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, out actualGlyphRange);
	}

	[Export("defaultBaselineOffsetForFont:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DefaultBaselineOffsetForFont(NSFont theFont)
	{
		NSApplication.EnsureUIThread();
		if (theFont == null)
		{
			throw new ArgumentNullException("theFont");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selDefaultBaselineOffsetForFont_Handle, theFont.Handle);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultBaselineOffsetForFont_Handle, theFont.Handle);
	}

	[Export("defaultLineHeightForFont:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DefaultLineHeightForFont(NSFont theFont)
	{
		NSApplication.EnsureUIThread();
		if (theFont == null)
		{
			throw new ArgumentNullException("theFont");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selDefaultLineHeightForFont_Handle, theFont.Handle);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultLineHeightForFont_Handle, theFont.Handle);
	}

	[Export("deleteGlyphsInRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
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

	[Export("drawBackgroundForGlyphRange:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawBackgroundForGlyphRange(NSRange glyphsToShow, CGPoint origin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_CGPoint(base.Handle, selDrawBackgroundForGlyphRange_AtPoint_Handle, glyphsToShow, origin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_CGPoint(base.SuperHandle, selDrawBackgroundForGlyphRange_AtPoint_Handle, glyphsToShow, origin);
		}
	}

	[Export("drawGlyphsForGlyphRange:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawGlyphsForGlyphRange(NSRange glyphsToShow, CGPoint origin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_CGPoint(base.Handle, selDrawGlyphsForGlyphRange_AtPoint_Handle, glyphsToShow, origin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_CGPoint(base.SuperHandle, selDrawGlyphsForGlyphRange_AtPoint_Handle, glyphsToShow, origin);
		}
	}

	[Export("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawStrikethrough(NSRange glyphRange, NSUnderlineStyle strikethroughVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint(base.Handle, selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint(base.SuperHandle, selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}
	}

	[Export("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawUnderline(NSRange glyphRange, NSUnderlineStyle underlineVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint(base.Handle, selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint(base.SuperHandle, selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}
	}

	[Export("drawsOutsideLineFragmentForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsOutsideLineFragmentForGlyphAt(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selDrawsOutsideLineFragmentForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selDrawsOutsideLineFragmentForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("ensureGlyphsForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureGlyphsForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureGlyphsForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureGlyphsForCharacterRange_Handle, charRange);
		}
	}

	[Export("ensureGlyphsForGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureGlyphsForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureGlyphsForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureGlyphsForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("ensureLayoutForBoundingRect:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureLayoutForBoundingRect(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selEnsureLayoutForBoundingRect_InTextContainer_Handle, bounds, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selEnsureLayoutForBoundingRect_InTextContainer_Handle, bounds, container.Handle);
		}
	}

	[Export("ensureLayoutForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureLayoutForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureLayoutForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureLayoutForCharacterRange_Handle, charRange);
		}
	}

	[Export("ensureLayoutForGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureLayoutForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureLayoutForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureLayoutForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("ensureLayoutForTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureLayoutForTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnsureLayoutForTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnsureLayoutForTextContainer_Handle, container.Handle);
		}
	}

	[Export("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateEnclosingRects(NSRange glyphRange, NSRange selectedRange, NSTextContainer textContainer, [BlockProxy(typeof(Trampolines.NIDNSTextLayoutEnumerateEnclosingRects))] NSTextLayoutEnumerateEnclosingRects callback)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSTextLayoutEnumerateEnclosingRects.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_NSRange_IntPtr_IntPtr(base.Handle, selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_Handle, glyphRange, selectedRange, textContainer.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_NSRange_IntPtr_IntPtr(base.SuperHandle, selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_Handle, glyphRange, selectedRange, textContainer.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateLineFragmentsForGlyphRange:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateLineFragments(NSRange glyphRange, [BlockProxy(typeof(Trampolines.NIDNSTextLayoutEnumerateLineFragments))] NSTextLayoutEnumerateLineFragments callback)
	{
		NSApplication.EnsureUIThread();
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSTextLayoutEnumerateLineFragments.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selEnumerateLineFragmentsForGlyphRange_UsingBlock_Handle, glyphRange, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selEnumerateLineFragmentsForGlyphRange_UsingBlock_Handle, glyphRange, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("fillBackgroundRectArray:count:forCharacterRange:color:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This method should never be called, only overridden.")]
	protected virtual void FillBackground(IntPtr rectArray, nuint rectCount, NSRange characterRange, NSColor color)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_NSRange_IntPtr(base.Handle, selFillBackgroundRectArray_Count_ForCharacterRange_Color_Handle, rectArray, rectCount, characterRange, color.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_NSRange_IntPtr(base.SuperHandle, selFillBackgroundRectArray_Count_ForCharacterRange_Color_Handle, rectArray, rectCount, characterRange, color.Handle);
		}
	}

	[Export("fractionOfDistanceThroughGlyphForPoint:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FractionOfDistanceThroughGlyphForPoint(CGPoint point, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_CGPoint_IntPtr(base.Handle, selFractionOfDistanceThroughGlyphForPoint_InTextContainer_Handle, point, container.Handle);
		}
		return Messaging.nfloat_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selFractionOfDistanceThroughGlyphForPoint_InTextContainer_Handle, point, container.Handle);
	}

	[Export("boundsRectForTextBlock:atIndex:effectiveRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetBoundsRect(NSTextBlock block, nuint glyphIndex, IntPtr effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_nuint_IntPtr(out retval, base.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, effectiveGlyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_nuint_IntPtr(out retval, base.SuperHandle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, effectiveGlyphRange);
		}
		return retval;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetBoundsRect(NSTextBlock block, nuint glyphIndex)
	{
		return GetBoundsRect(block, glyphIndex, IntPtr.Zero);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetBoundsRect(NSTextBlock block, nuint glyphIndex, out NSRange effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_nuint_out_NSRange(out var retval, base.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, out effectiveGlyphRange);
		return retval;
	}

	[Export("CGGlyphAtIndex:isValidIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ushort GetCGGlyph(nuint glyphIndex, out bool isValidIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.UInt16_objc_msgSend_nuint_out_Boolean(base.Handle, selCGGlyphAtIndex_IsValidIndex_Handle, glyphIndex, out isValidIndex);
		}
		return Messaging.UInt16_objc_msgSendSuper_nuint_out_Boolean(base.SuperHandle, selCGGlyphAtIndex_IsValidIndex_Handle, glyphIndex, out isValidIndex);
	}

	[Export("CGGlyphAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ushort GetCGGlyph(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.UInt16_objc_msgSend_nuint(base.Handle, selCGGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.UInt16_objc_msgSendSuper_nuint(base.SuperHandle, selCGGlyphAtIndex_Handle, glyphIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal nuint GetCharacterIndex(CGPoint point, NSTextContainer container, IntPtr fractionOfDistanceBetweenInsertionPoints)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		return Messaging.nuint_objc_msgSend_CGPoint_IntPtr_IntPtr(base.Handle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, fractionOfDistanceBetweenInsertionPoints);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetCharacterIndex(CGPoint point, NSTextContainer container)
	{
		return GetCharacterIndex(point, container, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetCharacterIndex(CGPoint point, NSTextContainer container, out nfloat fractionOfDistanceBetweenInsertionPoints)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		return Messaging.nuint_objc_msgSend_CGPoint_IntPtr_out_nfloat(base.Handle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, out fractionOfDistanceBetweenInsertionPoints);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSRange GetCharacterRange(NSRange glyphRange, IntPtr actualGlyphRange)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_NSRange_IntPtr(base.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, actualGlyphRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetCharacterRange(NSRange glyphRange)
	{
		return GetCharacterRange(glyphRange, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetCharacterRange(NSRange glyphRange, out NSRange actualGlyphRange)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_NSRange_out_NSRange(base.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_Handle, glyphRange, out actualGlyphRange);
	}

	[Export("getFirstUnlaidCharacterIndex:glyphIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetFirstUnlaidCharacterIndex(ref nuint charIndex, ref nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_nuint_ref_nuint(base.Handle, selGetFirstUnlaidCharacterIndex_GlyphIndex_Handle, ref charIndex, ref glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_nuint_ref_nuint(base.SuperHandle, selGetFirstUnlaidCharacterIndex_GlyphIndex_Handle, ref charIndex, ref glyphIndex);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSRange GetGlyphRange(NSRange characterRange, IntPtr actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_NSRange_IntPtr(base.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_Handle, characterRange, actualCharacterRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetGlyphRange(NSRange characterRange)
	{
		return GetGlyphRange(characterRange, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetGlyphRange(NSRange characterRange, out NSRange actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_NSRange_out_NSRange(base.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_Handle, characterRange, out actualCharacterRange);
	}

	[Export("glyphRangeForTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetGlyphRange(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr(base.Handle, selGlyphRangeForTextContainer_Handle, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr(base.SuperHandle, selGlyphRangeForTextContainer_Handle, container.Handle);
	}

	[Export("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual nuint GetGlyphs(NSRange glyphRange, IntPtr glyphBuffer, IntPtr properties, IntPtr characterIndexBuffer, IntPtr bidiLevelBuffer)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_Handle, glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
		}
		return Messaging.nuint_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_Handle, glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
	}

	[Export("intAttribute:forGlyphAtIndex:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'GetGlyphs' instead).")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIntAttribute(nint attributeTag, nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint_nint(base.Handle, selIntAttribute_ForGlyphAtIndex_Handle, attributeTag, glyphIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nint_nint(base.SuperHandle, selIntAttribute_ForGlyphAtIndex_Handle, attributeTag, glyphIndex);
	}

	[Export("layoutRectForTextBlock:atIndex:effectiveRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetLayoutRect(NSTextBlock block, nuint glyphIndex, IntPtr effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_nuint_IntPtr(out retval, base.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, effectiveGlyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_nuint_IntPtr(out retval, base.SuperHandle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, effectiveGlyphRange);
		}
		return retval;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLayoutRect(NSTextBlock block, nuint glyphIndex)
	{
		return GetLayoutRect(block, glyphIndex, IntPtr.Zero);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLayoutRect(NSTextBlock block, nuint glyphIndex, out NSRange effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_nuint_out_NSRange(out var retval, base.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_Handle, block.Handle, glyphIndex, out effectiveGlyphRange);
		return retval;
	}

	[Export("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetLineFragmentInsertionPoints(nuint charIndex, bool aFlag, bool dFlag, IntPtr positions, IntPtr charIndexes)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint_bool_bool_IntPtr_IntPtr(base.Handle, selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_Handle, charIndex, aFlag, dFlag, positions, charIndexes);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint_bool_bool_IntPtr_IntPtr(base.SuperHandle, selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_Handle, charIndex, aFlag, dFlag, positions, charIndexes);
	}

	[Export("lineFragmentRectForGlyphAtIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetLineFragmentRect(nuint glyphIndex, IntPtr effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nuint_IntPtr(out retval, base.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nuint_IntPtr(out retval, base.SuperHandle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange);
		}
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentRect(nuint glyphIndex)
	{
		return GetLineFragmentRect(glyphIndex, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentRect(nuint glyphIndex, out NSRange effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_nuint_out_NSRange(out var retval, base.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, out effectiveGlyphRange);
		return retval;
	}

	[Export("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetLineFragmentRect(nuint glyphIndex, IntPtr effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nuint_IntPtr_bool(out retval, base.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nuint_IntPtr_bool(out retval, base.SuperHandle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout);
		}
		return retval;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentRect(nuint glyphIndex, bool withoutAdditionalLayout)
	{
		return GetLineFragmentRect(glyphIndex, IntPtr.Zero);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentRect(nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_nuint_out_NSRange_bool(out var retval, base.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, out effectiveGlyphRange, withoutAdditionalLayout);
		return retval;
	}

	[Export("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetLineFragmentUsedRect(nuint glyphIndex, IntPtr effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nuint_IntPtr(out retval, base.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nuint_IntPtr(out retval, base.SuperHandle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange);
		}
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentUsedRect(nuint glyphIndex)
	{
		return GetLineFragmentUsedRect(glyphIndex, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentUsedRect(nuint glyphIndex, out NSRange effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_nuint_out_NSRange(out var retval, base.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, out effectiveGlyphRange);
		return retval;
	}

	[Export("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual CGRect GetLineFragmentUsedRect(nuint glyphIndex, IntPtr effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nuint_IntPtr_bool(out retval, base.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nuint_IntPtr_bool(out retval, base.SuperHandle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout);
		}
		return retval;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentUsedRect(nuint glyphIndex, bool withoutAdditionalLayout)
	{
		return GetLineFragmentUsedRect(glyphIndex, IntPtr.Zero);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetLineFragmentUsedRect(nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_nuint_out_NSRange_bool(out var retval, base.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, out effectiveGlyphRange, withoutAdditionalLayout);
		return retval;
	}

	[Export("propertyForGlyphAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGlyphProperty GetProperty(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSGlyphProperty)Messaging.Int64_objc_msgSend_nuint(base.Handle, selPropertyForGlyphAtIndex_Handle, glyphIndex);
		}
		return (NSGlyphProperty)Messaging.Int64_objc_msgSendSuper_nuint(base.SuperHandle, selPropertyForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr GetRectArray(NSRange glyphRange, NSRange selectedGlyphRange, IntPtr textContainerHandle, out nuint rectCount)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_NSRange_NSRange_IntPtr_out_nuint(base.Handle, selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_Handle, glyphRange, selectedGlyphRange, textContainerHandle, out rectCount);
		}
		return Messaging.IntPtr_objc_msgSendSuper_NSRange_NSRange_IntPtr_out_nuint(base.SuperHandle, selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_Handle, glyphRange, selectedGlyphRange, textContainerHandle, out rectCount);
	}

	[Export("temporaryAttribute:atCharacterIndex:effectiveRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex, IntPtr effectiveRange)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_Handle, attributeName.Handle, characterIndex, effectiveRange));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_Handle, attributeName.Handle, characterIndex, effectiveRange));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex)
	{
		return GetTemporaryAttribute(attributeName, characterIndex, IntPtr.Zero);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex, out NSRange effectiveRange)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_out_NSRange(base.Handle, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_Handle, attributeName.Handle, characterIndex, out effectiveRange));
	}

	[Export("temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex, IntPtr longestEffectiveRange, NSRange rangeLimit)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_NSRange(base.Handle, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_Handle, attributeName.Handle, characterIndex, longestEffectiveRange, rangeLimit));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_NSRange(base.SuperHandle, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_Handle, attributeName.Handle, characterIndex, longestEffectiveRange, rangeLimit));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex, NSRange rangeLimit)
	{
		return GetTemporaryAttribute(attributeName, characterIndex, IntPtr.Zero, rangeLimit);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject GetTemporaryAttribute(NSString attributeName, nuint characterIndex, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_out_NSRange_NSRange(base.Handle, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_Handle, attributeName.Handle, characterIndex, out longestEffectiveRange, rangeLimit));
	}

	[Export("temporaryAttributesAtCharacterIndex:effectiveRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex, IntPtr effectiveCharacterRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr(base.Handle, selTemporaryAttributesAtCharacterIndex_EffectiveRange_Handle, characterIndex, effectiveCharacterRange));
		}
		return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selTemporaryAttributesAtCharacterIndex_EffectiveRange_Handle, characterIndex, effectiveCharacterRange));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex)
	{
		return GetTemporaryAttributes(characterIndex, IntPtr.Zero);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex, out NSRange effectiveCharacterRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_nuint_out_NSRange(base.Handle, selTemporaryAttributesAtCharacterIndex_EffectiveRange_Handle, characterIndex, out effectiveCharacterRange));
	}

	[Export("temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex, IntPtr longestEffectiveRange, NSRange rangeLimit)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr_NSRange(base.Handle, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_Handle, characterIndex, longestEffectiveRange, rangeLimit));
		}
		return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr_NSRange(base.SuperHandle, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_Handle, characterIndex, longestEffectiveRange, rangeLimit));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex, NSRange rangeLimit)
	{
		return GetTemporaryAttributes(characterIndex, IntPtr.Zero, rangeLimit);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary<NSString, NSObject> GetTemporaryAttributes(nuint characterIndex, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_nuint_out_NSRange_NSRange(base.Handle, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_Handle, characterIndex, out longestEffectiveRange, rangeLimit));
	}

	[Export("textContainerForGlyphAtIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSTextContainer GetTextContainer(nuint glyphIndex, IntPtr effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr(base.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange));
		}
		return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selTextContainerForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, effectiveGlyphRange));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextContainer GetTextContainer(nuint glyphIndex)
	{
		return GetTextContainer(glyphIndex, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextContainer GetTextContainer(nuint glyphIndex, out NSRange effectiveGlyphRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend_nuint_out_NSRange(base.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_Handle, glyphIndex, out effectiveGlyphRange));
	}

	[Export("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSTextContainer GetTextContainer(nuint glyphIndex, IntPtr effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr_bool(base.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout));
		}
		return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr_bool(base.SuperHandle, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextContainer GetTextContainer(nuint glyphIndex, bool flag)
	{
		return GetTextContainer(glyphIndex, IntPtr.Zero, flag);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextContainer GetTextContainer(nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTextContainer>(Messaging.IntPtr_objc_msgSend_nuint_out_NSRange_bool(base.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_Handle, glyphIndex, out effectiveGlyphRange, withoutAdditionalLayout));
	}

	[Export("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetTruncatedGlyphRangeInLineFragment(nuint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint(base.Handle, selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint(base.SuperHandle, selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("usedRectForTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetUsedRectForTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr(out retval, base.Handle, selUsedRectForTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr(out retval, base.SuperHandle, selUsedRectForTextContainer_Handle, container.Handle);
		}
		return retval;
	}

	[Export("glyphAtIndex:isValidIndex:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'GetCGGlyph' instead).")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint GlyphAtIndex(nint glyphIndex, ref bool isValidIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_nint_ref_Boolean(base.Handle, selGlyphAtIndex_IsValidIndex_Handle, glyphIndex, ref isValidIndex);
		}
		return Messaging.UInt32_objc_msgSendSuper_nint_ref_Boolean(base.SuperHandle, selGlyphAtIndex_IsValidIndex_Handle, glyphIndex, ref isValidIndex);
	}

	[Export("glyphAtIndex:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'GetCGGlyph' instead).")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint GlyphAtIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_nint(base.Handle, selGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.UInt32_objc_msgSendSuper_nint(base.SuperHandle, selGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("glyphIndexForCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GlyphIndexForCharacterAtIndex(nint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nint(base.Handle, selGlyphIndexForCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.nuint_objc_msgSendSuper_nint(base.SuperHandle, selGlyphIndexForCharacterAtIndex_Handle, charIndex);
	}

	[Export("glyphIndexForPoint:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GlyphIndexForPoint(CGPoint point, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint_IntPtr(base.Handle, selGlyphIndexForPoint_InTextContainer_Handle, point, container.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selGlyphIndexForPoint_InTextContainer_Handle, point, container.Handle);
	}

	[Export("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GlyphIndexForPointInTextContainer(CGPoint point, NSTextContainer container, ref nfloat fractionOfDistanceThroughGlyph)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint_IntPtr_ref_nfloat(base.Handle, selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_Handle, point, container.Handle, ref fractionOfDistanceThroughGlyph);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint_IntPtr_ref_nfloat(base.SuperHandle, selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_Handle, point, container.Handle, ref fractionOfDistanceThroughGlyph);
	}

	[Export("glyphRangeForBoundingRect:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GlyphRangeForBoundingRect(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect_IntPtr(base.Handle, selGlyphRangeForBoundingRect_InTextContainer_Handle, bounds, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGlyphRangeForBoundingRect_InTextContainer_Handle, bounds, container.Handle);
	}

	[Export("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GlyphRangeForBoundingRectWithoutAdditionalLayout(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect_IntPtr(base.Handle, selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_Handle, bounds, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_Handle, bounds, container.Handle);
	}

	[Export("glyphRangeForCharacterRange:actualCharacterRange:")]
	[Obsolete("Use 'GetGlyphRange' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
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

	[Export("insertGlyph:atGlyphIndex:characterIndex:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertGlyph(uint glyph, nint glyphIndex, nint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_nint_nint(base.Handle, selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle, glyph, glyphIndex, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_nint_nint(base.SuperHandle, selInsertGlyph_AtGlyphIndex_CharacterIndex_Handle, glyph, glyphIndex, charIndex);
		}
	}

	[Export("insertTextContainer:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertTextContainer(NSTextContainer container, nint index)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertTextContainer_AtIndex_Handle, container.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertTextContainer_AtIndex_Handle, container.Handle, index);
		}
	}

	[Export("invalidateDisplayForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateDisplayForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateDisplayForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateDisplayForCharacterRange_Handle, charRange);
		}
	}

	[Export("invalidateDisplayForGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateDisplayForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateDisplayForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateDisplayForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual void InvalidateGlyphs(NSRange characterRange, nint delta, IntPtr actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_nint_IntPtr(base.Handle, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_Handle, characterRange, delta, actualCharacterRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_nint_IntPtr(base.SuperHandle, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_Handle, characterRange, delta, actualCharacterRange);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateGlyphs(NSRange characterRange, nint delta)
	{
		InvalidateGlyphs(characterRange, delta, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateGlyphs(NSRange characterRange, nint delta, out NSRange actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange_nint_out_NSRange(base.Handle, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_Handle, characterRange, delta, out actualCharacterRange);
	}

	[Export("invalidateGlyphsOnLayoutInvalidationForGlyphRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateGlyphsOnLayoutInvalidation(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("invalidateLayoutForCharacterRange:actualCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual void InvalidateLayout(NSRange characterRange, IntPtr actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selInvalidateLayoutForCharacterRange_ActualCharacterRange_Handle, characterRange, actualCharacterRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selInvalidateLayoutForCharacterRange_ActualCharacterRange_Handle, characterRange, actualCharacterRange);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateLayout(NSRange characterRange)
	{
		InvalidateLayout(characterRange, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateLayout(NSRange characterRange, out NSRange actualCharacterRange)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange_out_NSRange(base.Handle, selInvalidateLayoutForCharacterRange_ActualCharacterRange_Handle, characterRange, out actualCharacterRange);
	}

	[Export("isValidGlyphIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidGlyphIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsValidGlyphIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsValidGlyphIndex_Handle, glyphIndex);
	}

	[Export("layoutRectForTextBlock:glyphRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect LayoutRect(NSTextBlock block, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_NSRange(out retval, base.Handle, selLayoutRectForTextBlock_GlyphRange_Handle, block.Handle, glyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_NSRange(out retval, base.SuperHandle, selLayoutRectForTextBlock_GlyphRange_Handle, block.Handle, glyphRange);
		}
		return retval;
	}

	[Export("locationForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LocationForGlyphAtIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_nint(base.Handle, selLocationForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.CGPoint_objc_msgSendSuper_nint(base.SuperHandle, selLocationForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("notShownAttributeForGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NotShownAttributeForGlyphAtIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selNotShownAttributeForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selNotShownAttributeForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ProcessEditing(NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharRange, nint delta, NSRange invalidatedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (textStorage == null)
		{
			throw new ArgumentNullException("textStorage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_nint_NSRange(base.Handle, selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle, textStorage.Handle, (ulong)editMask, newCharRange, delta, invalidatedCharRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_NSRange_nint_NSRange(base.SuperHandle, selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle, textStorage.Handle, (ulong)editMask, newCharRange, delta, invalidatedCharRange);
		}
	}

	[Export("rangeOfNominallySpacedGlyphsContainingIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeOfNominallySpacedGlyphsContainingIndex(nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selRangeOfNominallySpacedGlyphsContainingIndex_Handle, glyphIndex);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selRangeOfNominallySpacedGlyphsContainingIndex_Handle, glyphIndex);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveTemporaryAttribute(NSString attributeName, NSRange characterRange)
	{
		NSApplication.EnsureUIThread();
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selRemoveTemporaryAttribute_ForCharacterRange_Handle, attributeName.Handle, characterRange);
	}

	[Export("removeTemporaryAttribute:forCharacterRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTemporaryAttribute(string attrName, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrName == null)
		{
			throw new ArgumentNullException("attrName");
		}
		IntPtr arg = NSString.CreateNative(attrName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selRemoveTemporaryAttribute_ForCharacterRange_Handle, arg, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selRemoveTemporaryAttribute_ForCharacterRange_Handle, arg, charRange);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeTextContainerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTextContainer(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveTextContainerAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveTextContainerAtIndex_Handle, index);
		}
	}

	[Export("replaceGlyphAtIndex:withGlyph:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceGlyphAtIndex(nint glyphIndex, uint newGlyph)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_UInt32(base.Handle, selReplaceGlyphAtIndex_WithGlyph_Handle, glyphIndex, newGlyph);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_UInt32(base.SuperHandle, selReplaceGlyphAtIndex_WithGlyph_Handle, glyphIndex, newGlyph);
		}
	}

	[Export("replaceTextStorage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceTextStorage(NSTextStorage newTextStorage)
	{
		NSApplication.EnsureUIThread();
		if (newTextStorage == null)
		{
			throw new ArgumentNullException("newTextStorage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceTextStorage_Handle, newTextStorage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceTextStorage_Handle, newTextStorage.Handle);
		}
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

	[Export("setBoundsRect:forTextBlock:glyphRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBoundsRect(CGRect boundsRect, NSTextBlock forTextBlock, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (forTextBlock == null)
		{
			throw new ArgumentNullException("forTextBlock");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange(base.Handle, selSetBoundsRect_ForTextBlock_GlyphRange_Handle, boundsRect, forTextBlock.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange(base.SuperHandle, selSetBoundsRect_ForTextBlock_GlyphRange_Handle, boundsRect, forTextBlock.Handle, glyphRange);
		}
	}

	[Export("setCharacterIndex:forGlyphAtIndex:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCharacterIndex(nint charIndex, nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selSetCharacterIndex_ForGlyphAtIndex_Handle, charIndex, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selSetCharacterIndex_ForGlyphAtIndex_Handle, charIndex, glyphIndex);
		}
	}

	[Export("setDrawsOutsideLineFragment:forGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDrawsOutsideLineFragment(bool flag, nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetDrawsOutsideLineFragment_ForGlyphAtIndex_Handle, flag, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetDrawsOutsideLineFragment_ForGlyphAtIndex_Handle, flag, glyphIndex);
		}
	}

	[Export("setExtraLineFragmentRect:usedRect:textContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetExtraLineFragmentRect(CGRect fragmentRect, CGRect usedRect, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_IntPtr(base.Handle, selSetExtraLineFragmentRect_UsedRect_TextContainer_Handle, fragmentRect, usedRect, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_IntPtr(base.SuperHandle, selSetExtraLineFragmentRect_UsedRect_TextContainer_Handle, fragmentRect, usedRect, container.Handle);
		}
	}

	[Export("setGlyphs:properties:characterIndexes:font:forGlyphRange:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetGlyphs(IntPtr glyphs, IntPtr props, IntPtr charIndexes, NSFont aFont, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (aFont == null)
		{
			throw new ArgumentNullException("aFont");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_NSRange(base.Handle, selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_Handle, glyphs, props, charIndexes, aFont.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_NSRange(base.SuperHandle, selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_Handle, glyphs, props, charIndexes, aFont.Handle, glyphRange);
		}
	}

	[Export("setIntAttribute:value:forGlyphAtIndex:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use 'SetGlyphs' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetIntAttribute(nint attributeTag, nint value, nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint_nint(base.Handle, selSetIntAttribute_Value_ForGlyphAtIndex_Handle, attributeTag, value, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint_nint(base.SuperHandle, selSetIntAttribute_Value_ForGlyphAtIndex_Handle, attributeTag, value, glyphIndex);
		}
	}

	[Export("setLayoutRect:forTextBlock:glyphRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLayoutRect(CGRect layoutRect, NSTextBlock forTextBlock, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (forTextBlock == null)
		{
			throw new ArgumentNullException("forTextBlock");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange(base.Handle, selSetLayoutRect_ForTextBlock_GlyphRange_Handle, layoutRect, forTextBlock.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange(base.SuperHandle, selSetLayoutRect_ForTextBlock_GlyphRange_Handle, layoutRect, forTextBlock.Handle, glyphRange);
		}
	}

	[Export("setLineFragmentRect:forGlyphRange:usedRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLineFragmentRect(CGRect fragmentRect, NSRange glyphRange, CGRect usedRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_NSRange_CGRect(base.Handle, selSetLineFragmentRect_ForGlyphRange_UsedRect_Handle, fragmentRect, glyphRange, usedRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect(base.SuperHandle, selSetLineFragmentRect_ForGlyphRange_UsedRect_Handle, fragmentRect, glyphRange, usedRect);
		}
	}

	[Export("setLocation:forStartOfGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLocation(CGPoint location, NSRange forStartOfGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_NSRange(base.Handle, selSetLocation_ForStartOfGlyphRange_Handle, location, forStartOfGlyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_NSRange(base.SuperHandle, selSetLocation_ForStartOfGlyphRange_Handle, location, forStartOfGlyphRange);
		}
	}

	[Export("setNotShownAttribute:forGlyphAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNotShownAttribute(bool flag, nint glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetNotShownAttribute_ForGlyphAtIndex_Handle, flag, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetNotShownAttribute_ForGlyphAtIndex_Handle, flag, glyphIndex);
		}
	}

	[Export("setTemporaryAttributes:forCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTemporaryAttributes(NSDictionary attrs, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTemporaryAttributes_ForCharacterRange_Handle, attrs.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTemporaryAttributes_ForCharacterRange_Handle, attrs.Handle, charRange);
		}
	}

	[Export("setTextContainer:forGlyphRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextContainerForRange(NSTextContainer container, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTextContainer_ForGlyphRange_Handle, container.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTextContainer_ForGlyphRange_Handle, container.Handle, glyphRange);
		}
	}

	[Export("showAttachmentCell:inRect:characterIndex:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowAttachmentCell(NSCell cell, CGRect rect, nuint characterIndex)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_nuint(base.Handle, selShowAttachmentCell_InRect_CharacterIndex_Handle, cell.Handle, rect, characterIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_nuint(base.SuperHandle, selShowAttachmentCell_InRect_CharacterIndex_Handle, cell.Handle, rect, characterIndex);
		}
	}

	[Export("showCGGlyphs:positions:count:font:matrix:attributes:inContext:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the overload that takes 'nint glyphCount' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This API is not available when using UIKit on macOS.")]
	protected virtual void ShowGlyphs(IntPtr glyphs, IntPtr positions, nuint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext? graphicsContext)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_CGAffineTransform_IntPtr_IntPtr(base.Handle, selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_Handle, glyphs, positions, glyphCount, font.Handle, textMatrix, attributes.Handle, graphicsContext?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_CGAffineTransform_IntPtr_IntPtr(base.SuperHandle, selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_Handle, glyphs, positions, glyphCount, font.Handle, textMatrix, attributes.Handle, graphicsContext?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual void ShowGlyphs(IntPtr glyphs, IntPtr positions, nint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext? graphicsContext)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nint_IntPtr_CGAffineTransform_IntPtr_IntPtr(base.Handle, selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_Handle, glyphs, positions, glyphCount, font.Handle, textMatrix, attributes.Handle, graphicsContext?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr_CGAffineTransform_IntPtr_IntPtr(base.SuperHandle, selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_Handle, glyphs, positions, glyphCount, font.Handle, textMatrix, attributes.Handle, graphicsContext?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Strikethrough(NSRange glyphRange, NSUnderlineStyle strikethroughVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_CGRect_NSRange_CGPoint(base.Handle, selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_CGRect_NSRange_CGPoint(base.SuperHandle, selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
		}
	}

	[Export("substituteFontForFont:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont SubstituteFontForFont(NSFont originalFont)
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

	[Export("textContainerChangedGeometry:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextContainerChangedGeometry(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextContainerChangedGeometry_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextContainerChangedGeometry_Handle, container.Handle);
		}
	}

	[Export("textContainerChangedTextView:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextContainerChangedTextView(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextContainerChangedTextView_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextContainerChangedTextView_Handle, container.Handle);
		}
	}

	[Export("textStorage:edited:range:changeInLength:invalidatedRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use ProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharacterRange, nint delta, NSRange invalidatedCharacterRange) instead).")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextStorageEdited(NSTextStorage str, NSTextStorageEditedFlags editedMask, NSRange newCharRange, nint changeInLength, NSRange invalidatedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_nint_NSRange(base.Handle, selTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle, str.Handle, (ulong)editedMask, newCharRange, changeInLength, invalidatedCharRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_NSRange_nint_NSRange(base.SuperHandle, selTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_Handle, str.Handle, (ulong)editedMask, newCharRange, changeInLength, invalidatedCharRange);
		}
	}

	[Export("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Underline(NSRange glyphRange, NSUnderlineStyle underlineVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_CGRect_NSRange_CGPoint(base.Handle, selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)underlineVal, lineRect, lineGlyphRange, containerOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_CGRect_NSRange_CGPoint(base.SuperHandle, selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_Handle, glyphRange, (long)underlineVal, lineRect, lineGlyphRange, containerOrigin);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TextStorage_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
